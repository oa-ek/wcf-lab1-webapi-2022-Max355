using DeviceShop.Core;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace DeviceShop.Models
{
    public class Device
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [JsonIgnore]
        public int DeviceId { get; set; }
        public string Title { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
        public string? Image { get; set; }
        public int CategoryId { get; set; }
        [JsonIgnore]
        public Category? Category { get; set; }
        public double Rating { get; set; }
        [JsonIgnore]
        public virtual ICollection<User>? Users { get; set; } = new List<User>();

    }
}
