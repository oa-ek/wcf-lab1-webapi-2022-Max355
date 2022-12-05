using DeviceShop.Core;
using Microsoft.AspNetCore.Mvc;

namespace DeviceApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : Controller
    {
        private readonly DeviceShopContext _context;
       
        public UsersController(DeviceShopContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Get List of all users in db
        /// </summary>
        /// <returns>List of User</returns>
        [HttpGet]
        public List<User> Get()
        {
            return _context.Users.ToList();
        }
    }
}
