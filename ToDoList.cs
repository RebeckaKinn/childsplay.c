namespace SideProjectApp
{
    public class ToDoList
    {
        public List<ToDoTask>? Tasks { get; set; }

        public void AddToList(ToDoTask newTask)
        {
            Tasks?.Add(newTask);
        }

        
    }
}
