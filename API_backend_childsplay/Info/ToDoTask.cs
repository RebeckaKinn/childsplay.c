namespace API_backend_childsplay.Info
{
    public class ToDoTask
    {
        public Guid Id { get; set; }
        public string Task { get; set; }
        public bool IsCompleted { get; set; }
        public DateTime Date { get; set; }
        public DateTime? Done { get; set; }

        public ToDoTask() { }
        public ToDoTask(string newTask)
        {
            Id = Guid.NewGuid();
            Task = newTask;
            IsCompleted = false;
            Date = DateTime.Now;
            Done = null;
        }

        public string ToString()
        {

            return Task + " : " + Id + " : " + IsCompleted;
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
            if (IsCompleted) { Done = DateTime.Now; }
            else { Done = null; };
        }

    }
}
