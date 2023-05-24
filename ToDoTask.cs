namespace SideProjectApp
{
    public class ToDoTask
    {
        public Guid Id { get; set; }
        public string Task { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? DoneDate { get; set; }

        public ToDoTask(string newTask)
        {
            Id = Guid.NewGuid();
            Task = newTask;
            CreatedDate = DateTime.Today;
            DoneDate = null;
        }

        public void CreateTask(string taskToAdd)
        {
            new ToDoTask(taskToAdd);
        }

        public Guid ShowID()
        {
            return Id;
        }
        public string ShowTask()
        {
            return Task;
        }
        public DateTime? ShowDate()
        {
            return CreatedDate;
        }

        public DateTime? ShowDoneDate()
        {
            return DoneDate;
        }

        public void MarkAsDone()
        {
            DoneDate = DateTime.Today;
        }

        public void EditTask(string newTask)
        {
            Task = newTask;
        }


    }
}
