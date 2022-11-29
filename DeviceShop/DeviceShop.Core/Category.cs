namespace DeviceShop.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<CategoryModel>? CategoryModels { get; set; } = new List<CategoryModel>();
    }
}
