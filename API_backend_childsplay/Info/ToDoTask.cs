namespace API_backend_childsplay.Info
{
    public class ToDoTask
    {
        public Guid Id { get; set; }
        public string Task { get; set; }
        public bool IsCompleted { get; set; }

        public ToDoTask() { } //this is needed for some reason
        public ToDoTask(string newTask)
        {
            Id = Guid.NewGuid();
            Task = newTask;
            IsCompleted = false;
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

        public void ToggleComplete()
        {
            IsCompleted = !IsCompleted;
        }

    }
}
