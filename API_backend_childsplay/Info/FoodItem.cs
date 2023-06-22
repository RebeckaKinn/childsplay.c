namespace API_backend_childsplay.Info
{
    public class FoodItem : IMenuItem
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Img { get; set; }
        public Guid Id { get; }

        public FoodItem() { }
        public FoodItem(string name, string description, string img)
        {
            Name = name;
            Description = description;
            Img = img;
            Id = Guid.NewGuid();
        }
    }
}
