namespace DeviceShop.Models
{
    public class Company
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }

        public List<Device> Devices { get; set; }
    }
}
