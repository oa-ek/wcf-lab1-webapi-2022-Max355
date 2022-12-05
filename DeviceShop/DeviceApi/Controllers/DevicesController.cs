using AutoMapper;
using DeviceShop.Core;
using DeviceShop.Repos.DTO;
using Microsoft.AspNetCore.Mvc;
using DeviceShop.Models;
using Microsoft.EntityFrameworkCore;

namespace DeviceApi.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class DevicesController : Controller
    {
        private readonly DeviceShopContext _context;

        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IMapper _mapper;

        public DevicesController(DeviceShopContext context, IWebHostEnvironment webHostEnvironment, IMapper mapper)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
            _mapper = mapper;
        }
        /// <summary>
        /// returns list of devices
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IEnumerable<DevicesDto>> GetDevicesAsync()
        {
            return _mapper.Map<IEnumerable<DevicesDto>>(_context.Devices.ToList());
        }

        /// <summary>
        /// Search using title, that will return list of devices contains query
        /// </summary>
        /// <param name="title"></param>
        [HttpGet("search")]
        public List<Device> search(string devicesearch)
        {


            IQueryable<Device> mquery = _context.Devices;
            if (!string.IsNullOrEmpty(devicesearch))
            {
                mquery = mquery.Where(x => x.Title.Contains(devicesearch));
            }
            return mquery.Include(x => x.Category).ToList();
        }

        /// <summary>
        /// Creating new device
        /// </summary>
        /// <param name="device"></param>
        [HttpPost]
        public async Task<ActionResult<Device>> CreateDevices(Device device)
        {
            //var dbDevice =  _mapper.Map<Device>(device);
            _context.Devices.Add(device);
            _context.SaveChanges();
            return Ok(device);
        }

        /// <summary>
        /// Edit device, previously geting it by id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="device"></param>
        [HttpPut("{id}")]
        public ActionResult<DevicesDto> Edit(int id, DevicesDto device)
        {
            var edited = _context.Devices.FirstOrDefault(x => x.DeviceId == id);
            if (edited == null) return Ok("Not found");
            edited.Title = device.Title;
            edited.Description = device.Description;
            edited.Price = device.Price;
            _context.SaveChanges();
            return Ok("Edited");
        }

        /// <summary>
        /// Delete device by id param
        /// </summary>
        /// <param name="id"></param>
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            if (_context.Devices != null)
            {
                _context.Devices.Remove(_context.Devices.Find(id));
                _context.SaveChanges();
            }
        }

        /// <summary>
        /// Get device by id, including all related tables
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public DevicesDto Get(int id)
        {
            var device = _context.Devices?
                .FirstOrDefault(x => x.DeviceId == id);
            if (device == null) return null;
            var DeviceApi = _mapper.Map<DevicesDto>(device);
            return DeviceApi;
        }
    }
}
