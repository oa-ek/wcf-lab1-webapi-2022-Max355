using System.ComponentModel.DataAnnotations;

namespace DeviceShop.Models
{
    public class Colour
    {
        
        public int Id { get; set; }
        public string ColourTitle { get; set; }

        public List<Device> Devices { get; set; }
    }
}
