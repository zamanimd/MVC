namespace MVCCore6.Models
{
    public class Slider
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string LinkText { get; set; }
        public string ImageName { get; set; }
        public string TextPosition { get; set; }

        public Slider(int id, string name, string description, string linkText, string imageName, string textPosition)
        {
            Id = id;
            Name = name;
            Description = description;
            LinkText = linkText;
            ImageName = imageName;
            TextPosition = textPosition;
        }
    }
}
