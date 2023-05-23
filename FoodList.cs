namespace SideProjectApp
{
    public class FoodList
    {
        public List<FoodItem> foodItems = new List<FoodItem>();

        public FoodList(FoodItem newItem)
        {
            foodItems.Add(newItem);
        }
    }
}
