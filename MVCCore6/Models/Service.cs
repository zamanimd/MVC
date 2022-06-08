namespace MVCCore6.Models
{
    public class Service
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageName { get; set; }
        public string LinkText { get; set; }

        public Service(int id, string name, string description, string imageName, string linkText)
        {
            Id = id;
            Name = name;
            Description = description;
            ImageName = imageName;
            LinkText = linkText;
        }
    }
}
