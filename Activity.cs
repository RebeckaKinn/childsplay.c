namespace SideProjectApp
{
    public class Activity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid Id;

        public Activity(string name, string description)
        {
            Name = name;
            Description = description;
            Id = Guid.NewGuid();
        }
    }
}
