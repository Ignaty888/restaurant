using System.Linq;

namespace Restaurant.Data
{
    public partial class Order
    {
        /// <summary>
        /// Количество блюд в заказе
        /// </summary>
        public int DishesCount { get { return OrderDishes.Count; } }

        /// <summary>
        /// Итоговая сумма заказа
        /// </summary>
        public decimal TotalPrice { get { return OrderDishes.Sum(orderDish => orderDish.Totalprice); } }

        /// <summary>
        /// ФИОсотрудника в заказе
        /// </summary>
        public string EmployeeFio { get { return Employee.EmployeeFio; } }

        public decimal Comission
        {
            get { return TotalPrice * Employee.Post.SalePercent / 100; }
        }
    }
}
