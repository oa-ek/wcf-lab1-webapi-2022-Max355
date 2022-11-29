using DeviceShop.Core;
using DeviceShop.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.IO;
namespace DeviceShop.Controllers
{
 
    public class DeviceController : Controller
    {
        // GET: DeviceController
        private readonly DeviceShopContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public DeviceController(DeviceShopContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }
        public ActionResult Index()
        {


            List<Device> devices = _context.Devices.ToList();
            return View(devices);
        }

        // GET: DeviceController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DeviceController/Create
        

       


        [Authorize(Roles = "Admin")]
        // GET: DeviceController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(_context.Devices.Find(id));
        }

        // POST: DeviceController/Delete/5
        [HttpPost]
     
        
        public ActionResult Delete(int? id)
        {
            _context.Devices.Remove(_context.Devices.Find(id));
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        
        public IActionResult Detail(int id)
        {
            if (id == null) return NotFound();

            var device = _context.Devices
                .FirstOrDefault(x => x.DeviceId == id);
            if(device == null) return NotFound();
            return View(device);
        }

        
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Device device, IFormFile picture)
        {
            
          
                string picturePath = Path.Combine(_webHostEnvironment.WebRootPath, "img", "device", picture.FileName);

                using (FileStream stream = new FileStream(picturePath, FileMode.Create))
                    picture.CopyTo(stream);


                device.Image = Path.Combine("img", "device", picture.FileName);

                _context.Devices.Add(device);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));     
        }

        [HttpGet]
        public FileContentResult GetImage(int id)
        {
            var item = _context.Devices.Find(id);
            var path = Path.Combine(_webHostEnvironment.WebRootPath, item.Image);
            var byteArray = System.IO.File.ReadAllBytes(path);
            return new FileContentResult(byteArray, "image/jpeg");
        }

        // GET: MovieController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_context.Devices.FirstOrDefault(x => x.DeviceId == id));
        }

        // POST: MovieController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Device device)
        {
            if (device.DeviceId == null)
                return NotFound();

             Device edited = _context.Devices.FirstOrDefault(x => x.DeviceId == device.DeviceId);
            
            edited.Title = device.Title;
            edited.Description = device.Description;
            edited.Rating = device.Rating;
            edited.Price = device.Price;
            edited.Image = device.Image;
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        public ActionResult AddToCart(int id)
        {
            var mov = _context.Devices.FirstOrDefault(x => x.DeviceId == id);
            var currentUser = _context.Users.Include(x => x.Devices).FirstOrDefault(x => x.UserName == User.Identity.Name);
            if (mov != null && currentUser != null)
            {
                currentUser.Devices.Add(mov);
                _context.SaveChanges();
            }
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Index(string deviceSearch)
        {
            ViewData["GetDevicesDetails"] = deviceSearch;

            var mquery = from x in _context.Devices select x;
            if (!String.IsNullOrEmpty(deviceSearch))
            {
                mquery = mquery.Where(x => x.Title.Contains(deviceSearch));
            }
            return View(await mquery.Include(x => x.Category).ToListAsync());
        }



    }
}
