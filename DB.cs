namespace SideProjectApp
{
    public class DB
    {
        public List<FoodItem>? foodItems = new List<FoodItem>();
        public List<Activity>? activities = new List<Activity>();
        public List<ToDoTask>? tasks = new List<ToDoTask>();
        public DB()
        {
            foodItems.Add(new FoodItem("Kake", "Bake kake.", null));
            foodItems.Add(new FoodItem("Lasagne", "Følg Toro-oppskriften!", null));

            activities.Add(new Activity("Gå tur", "Hvis det er fint vær.", null));
            activities.Add(new Activity("Leke på lekeplassen", "Grave i sandkassa og huske.", null));

            tasks.Add(new ToDoTask("Ta klesvasken."));
            tasks.Add(new ToDoTask("Handle."));
        }

        public void NewFoodItem(string name, string description, string img)
        {
            foodItems?.Add(new FoodItem(name, description, img));
        }

        public void NewActivity(string name, string desctiption, string img)
        {
            activities?.Add(new Activity(name, desctiption, img));
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
