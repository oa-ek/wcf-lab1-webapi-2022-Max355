using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DeviceShop.Repos.DTO
{
    public class DevicesDto
    {
        [JsonIgnore]
        public int DeviceId { get; set; }
        public string Title { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
    }
}
