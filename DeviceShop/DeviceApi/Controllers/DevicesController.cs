using AutoMapper;
using DeviceShop.Core;
using DeviceShop.Repos.DTO;
using Microsoft.AspNetCore.Mvc;

namespace DeviceApi.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class DevicesController : Controller
    {
        private readonly DeviceShopContext  _context;

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
        public async Task<IEnumerable<DevicesDto>> GetActorsAsync()
        {
            return _mapper.Map<IEnumerable<DevicesDto>>(_context.Devices.ToList());
        }

    }
}
