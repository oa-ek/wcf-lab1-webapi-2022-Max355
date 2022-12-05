using DeviceShop.Core;
using DeviceShop.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DeviceApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class CartController : Controller
    {
     
            private readonly DeviceShopContext _context;
            public CartController(DeviceShopContext _context)
            {
                this._context = _context;
            }
            /// <summary>
            /// Get authorized user 
            /// </summary>
            [HttpGet]
            public List<Device> Index()
            {
                var currentUser = _context.Users.Include(x => x.Devices).FirstOrDefault(x => x.UserName == User.Identity.Name);
                if (currentUser != null)
                {
                    return currentUser.Devices?.ToList();
                }
                return null;
            }
        
    }
}
