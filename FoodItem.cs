namespace SideProjectApp
{
    public class FoodItem
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Difficulty { get; set; }

        public Guid Id;

        public FoodItem(string name, string description, int difficulty)
        {
            Name = name;
            Description = description;
            Difficulty = difficulty;
            Id = Guid.NewGuid();
        }
    }
}
