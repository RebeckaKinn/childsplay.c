namespace SideProjectApp
{
    public class ToDoTask
    {
        private Guid _id { get; set; }
        private string _task { get; set; }
        private DateTime? _createdDate { get; set; }
        private DateTime? _doneDate { get; set; }

        public ToDoTask(string newTask)
        {
            _id = Guid.NewGuid();
            _task = newTask;
            _createdDate = DateTime.Today;
            _doneDate = null;
        }

        public void CreateTask(string taskToAdd)
        {
            new ToDoTask(taskToAdd);
        }

        public Guid ShowID()
        {
            return _id;
        }
        public string ShowTask()
        {
            return _task;
        }
        public DateTime? ShowDate()
        {
            return _createdDate;
        }

        public DateTime? ShowDoneDate()
        {
            return _doneDate;
        }

        public void MarkAsDone()
        {
            _doneDate = DateTime.Today;
        }

        public void EditTask(string newTask)
        {
            _task = newTask;
        }


    }
}
