namespace SideProjectApp
{
    public class ActivityList
    {
        public List<Activity> activities = new List<Activity>();

        public ActivityList(Activity newActivity)
        {
            activities.Add(newActivity);
        }
    }
}
