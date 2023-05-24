namespace SideProjectApp
{
    public class DB
    {
        public List<FoodItem>? foodItems = new List<FoodItem>();
        public List<Activity>? activities = new List<Activity>();
        public List<ToDoTask>? tasks = new List<ToDoTask>();
        public DB()
        {
            foodItems.Add(new FoodItem("Kake", "Bake kake.", 2));
            foodItems.Add(new FoodItem("Lasagne", "Følg Toro-oppskriften!", 1));

            activities.Add(new Activity("Gå tur", "Hvis det er fint vær."));
            activities.Add(new Activity("Leke på lekeplassen", "Grave i sandkassa og huske."));

            tasks.Add(new ToDoTask("Ta klesvasken."));
            tasks.Add(new ToDoTask("Handle."));
        }

        public void NewFoodItem(string name, string description, int difficulty)
        {
            foodItems?.Add(new FoodItem(name, description, difficulty));
        }

        public void NewActivity(string name, string desctiption)
        {
            activities?.Add(new Activity(name, desctiption));
        }

        public void NewToDo(string task)
        {
            tasks?.Add(new ToDoTask(task));
        }

        public List<FoodItem> ShowFood()
        {
            return foodItems;
        }

        public List<Activity> ShowActivity()
        {
            return activities;
        }

        public List<ToDoTask> ShowToDo()
        {
            return tasks;
        }
    }
}
