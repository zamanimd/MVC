namespace MVCCore6.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string ImageName { get; set; }


        public Product(int id, string name, string description, string category, string imageName)
        {
            Id = id;
            Name = name;
            Description = description;
            Category = category;
            ImageName = imageName;           
        }
    }
}
