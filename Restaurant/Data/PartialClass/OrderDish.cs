namespace Restaurant.Data
{
   public partial class OrderDish
    {
        public string DishName { get { return Dish.DishName; } }

        public decimal DishPrice { get { return Dish.Price; } }

        public decimal Totalprice { get { return Dish.Price * Quantity; }}
    }
}
