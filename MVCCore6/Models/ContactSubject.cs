namespace MVCCore6.Models
{
    public class ContactSubject
    {
        public string Value { get; set; }
        public string Name { get; set; }

        public ContactSubject(string value, string name)
        {
            Value = value;
            Name = name;
        }
    }
}
