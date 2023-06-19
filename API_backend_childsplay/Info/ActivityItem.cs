namespace API_backend_childsplay.Info
{
    public class Activity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Img { get; set; }
        public Guid Id;

        public Activity(string name, string description, string img)
        {
            Name = name;
            Description = description;
            Img = img;
            Id = Guid.NewGuid();
        }
    }
}
