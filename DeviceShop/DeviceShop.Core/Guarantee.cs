namespace DeviceShop.Models
{
    public class Guarantee
    {
        public int Id { get; set; }
        public string GuaranteeName { get; set; }

        public List<Device> Devices { get; set; }
    }
}
