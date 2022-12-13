using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Restaurant.Data
{
    /// <summary>
    /// Класс реализующий логику доступа к данным в БД
    /// </summary>
    public class Repository
    {

        /// <summary>
        /// Метод поиска сотрудника по заданным параметрам
        /// </summary>
        public List<Order> SearchOrder(Employee employee, DateTime? orderDate)
        {
            using (var context = new RestaurantDBEntities())
            {
                context.Dishes.Load();
                context.Posts.Load();
                var query = context.Orders.Include("Employee").Include("OrderDishes").AsQueryable();
                if (employee!=null)
                {
                    query = query.Where(order => order.ID_Employee == employee.ID_Employee);
                }

                if (orderDate.HasValue)
                {
                    query = query.Where(order => order.Date==orderDate.Value);
                }
                return query.ToList();
            }
        }

        /// <summary>
        /// Метод обновления Заказа в БД
        /// </summary>
        public void UpdateOrder(Order order)
        {
            using (var context = new RestaurantDBEntities())
            {
                // находим сущность в БД по ID
                var item = context.Orders.FirstOrDefault(order1 => order1.ID_Order==order.ID_Order);
                // если сущность найдена - обвноляем свойства
                if (item == null) return;
                item.ID_Employee = order.ID_Employee;
                // сохраняем обновление в БД
                context.SaveChanges();
            }
        }

        /// <summary>
        /// Метод поиска сотрудника по заданным параметрам
        /// </summary>
        public List<Employee> SearchEmployees(string fName, string name, string lName, Post post)
        {
            using (var context = new RestaurantDBEntities())
            {
                var query = context.Employees.Include("Post").AsQueryable();
                if (post != null)
                {
                    query = query.Where(employee => employee.ID_post==post.ID_post);
                }
                if (!string.IsNullOrWhiteSpace(fName))
                {
                    query = query.Where(employee => employee.FName.ToLower().Contains(fName.ToLower()));
                }
                if (!string.IsNullOrWhiteSpace(name))
                {
                    query = query.Where(employee => employee.EmpName.ToLower().Contains(name.ToLower()));
                }
                if (!string.IsNullOrWhiteSpace(lName))
                {
                    query = query.Where(employee => employee.LName.ToLower().Contains(lName.ToLower()));
                }
                return query.ToList();
            }
        }

        /// <summary>
        /// Метод обновления данных Сотрудника
        /// </summary>
        public void UpdateEmployee(Employee employee)
        {
            using (var context = new RestaurantDBEntities())
            {
                // находим сущность в БД по ID
                var item = context.Employees.FirstOrDefault(employee1 => employee1.ID_Employee==employee.ID_Employee);
                // если сущность найдена - обвноляем свойства
                if (item == null) return;
                item.ID_post = employee.ID_post;
                item.FName = employee.FName;
                item.EmpName = employee.EmpName;
                item.LName = employee.LName;
                item.Photo = employee.Photo;
                item.Phone = employee.Phone;
                item.DateEmployment = employee.DateEmployment;
                item.Birthdate = employee.Birthdate;
                item.Address = employee.Address;
                
                // сохраняем обновление в БД
                context.SaveChanges();
            }
        }

        /// <summary>
        /// Метод обновления ингридиента блюда
        /// </summary>
        public void UpdateDishIngridient(DishIngredient dishIngredient)
        {
            using (var context = new RestaurantDBEntities())
            {
                // находим сущность в БД по ID
                var item = context.DishIngredients.FirstOrDefault(ingredient => ingredient.ID_IngridientDish==dishIngredient.ID_IngridientDish);
                // если сущность найдена - обвноляем свойства
                if (item == null) return;
                item.Ingridient_ID = dishIngredient.Ingridient_ID;
                item.ID_Unit = dishIngredient.ID_Unit;
                item.Quantity = dishIngredient.Quantity;
                // сохраняем обновление в БД
                context.SaveChanges();
            }
        }

        /// <summary>
        /// Метод поиска Блюда в БД по заданным параметрам
        /// </summary>
        public List<Dish> SearchDishes(TypeDish typeDish, string dishName)
        {
            using (var context = new RestaurantDBEntities())
            {
                var query = context.Dishes.Include("TypeDish").AsQueryable();
                if (typeDish!=null)
                {
                    query = query.Where(dish => dish.ID_TypeDish == typeDish.ID_TypeDish);
                }
                if (!string.IsNullOrWhiteSpace(dishName))
                {
                    query = query.Where(dish => dish.DishName.ToLower().Contains(dishName.ToLower()));
                }
                return query.ToList();
            }
        }

        /// <summary>
        /// Метод обовноления Блюда в БД
        /// </summary>
        public void UpdateDish(Dish dish)
        {
            using (var context = new RestaurantDBEntities())
            {
                // находим сущность в БД по ID
                var item = context.Dishes.FirstOrDefault(dish1 => dish1.ID_Dish==dish.ID_Dish);
                // если сущность найдена - обвноляем свойства
                if (item == null) return;
                item.DishName = dish.DishName;
                item.ID_TypeDish = dish.ID_TypeDish;
                item.Price = dish.Price;
                item.Photo = dish.Photo;
                item.Detail = dish.Detail;
                // сохраняем обновление в БД
                context.SaveChanges();
            }
        }

        /// <summary>
        /// Метод обновления Ингридиента в БД
        /// </summary>
        public void UpdateIngredient(Ingredient ingredient)
        {
            using (var context = new RestaurantDBEntities())
            {
                // находим сущность в БД по ID
                var item = context.Ingredients.FirstOrDefault(ingredient1 => ingredient1.ID_Ingredient == ingredient.ID_Ingredient);
                // если сущность найдена - обвноляем свойства
                if (item == null) return;
                item.IngridientName = ingredient.IngridientName;
                // сохраняем обновление в БД
                context.SaveChanges();
            }
        }

        /// <summary>
        /// Метод обовноления Единиц измерения в БД
        /// </summary>
        public void UpdateTypeDish(TypeDish typeDish)
        {
            using (var context = new RestaurantDBEntities())
            {
                // находим сущность в БД по ID
                var item = context.TypeDishes.FirstOrDefault(dish => dish.ID_TypeDish == typeDish.ID_TypeDish);
                // если сущность найдена - обвноляем свойства
                if (item == null) return;
                item.TypeDishName = typeDish.TypeDishName;
                item.Detailed = typeDish.Detailed;
                // сохраняем обновление в БД
                context.SaveChanges();
            }
        }

        /// <summary>
        /// Метод обновления Должности в БД
        /// </summary>
        public void UpdatePost(Post post)
        {
            using (var context = new RestaurantDBEntities())
            {
                // находим сущность в БД по ID
                var item = context.Posts.FirstOrDefault(post1 => post1.ID_post == post.ID_post);
                // если сущность найдена - обвноляем свойства
                if (item == null) return;
                item.PostName = post.PostName;
                item.Salary = post.Salary;
                item.SalePercent = post.SalePercent;
                // сохраняем обновление в БД
                context.SaveChanges();
            }
        }

        /// <summary>
        /// Метод обновления Единиц измерения в БД
        /// </summary>
        public void UpdateUnit(Unit unit)
        {
            using (var context = new RestaurantDBEntities())
            {
                // находим сущность в БД по ID
                var item = context.Units.FirstOrDefault(unit1 => unit1.ID_Unit == unit.ID_Unit);
                // если сущность найдена - обвноляем свойства
                if (item == null) return;
                item.UnitName = unit.UnitName;
                // сохраняем обновление в БД
                context.SaveChanges();
            }
        }

        /// <summary>
        /// Метод удаления сущности из БД
        /// </summary>
        public void RemoveItem<T>(object item) where T : class
        {
            using (var context = new RestaurantDBEntities())
            {
                // определяем имя типа сущности
                var typeName = typeof(T).Name;
                switch (typeName)
                {
                    case "Unit":
                        // приводим входной объект к требуемому типу
                        var i1 = item as Unit;
                        // по ID находим объект в БД
                        var t1 = context.Units.FirstOrDefault(unit => unit.ID_Unit == i1.ID_Unit);
                        // если сущность найдена в БД - удаляем
                        if (t1 != null) context.Units.Remove(t1);
                        break;
                    case "Post":
                        // приводим входной объект к требуемому типу
                        var i2 = item as Post;
                        // по ID находим объект в БД
                        var t2 = context.Posts.FirstOrDefault(post => post.ID_post == i2.ID_post);
                        // если сущность найдена в БД - удаляем
                        if (t2 != null) context.Posts.Remove(t2);
                        break;
                    case "TypeDish":
                        // приводим входной объект к требуемому типу
                        var i3 = item as TypeDish;
                        // по ID находим объект в БД
                        var t3 = context.TypeDishes.FirstOrDefault(dish => dish.ID_TypeDish == i3.ID_TypeDish);
                        // если сущность найдена в БД - удаляем
                        if (t3 != null) context.TypeDishes.Remove(t3);
                        break;
                    case "OrderDish":
                        // приводим входной объект к требуемому типу
                        var i4 = item as OrderDish;
                        // по ID находим объект в БД
                        var t4 = context.OrderDishes.FirstOrDefault(dish => dish.ID_OrderDish == i4.ID_OrderDish);
                        // если сущность найдена в БД - удаляем
                        if (t4 != null) context.OrderDishes.Remove(t4);
                        break;
                    case "Order":
                        // приводим входной объект к требуемому типу
                        var i5 = item as Order;
                        // по ID находим объект в БД
                        var t5 = context.Orders.FirstOrDefault(order => order.ID_Order == i5.ID_Order);
                        // если сущность найдена в БД - удаляем
                        if (t5 != null) context.Orders.Remove(t5);
                        break;
                    case "Ingredient":
                        // приводим входной объект к требуемому типу
                        var i6 = item as Ingredient;
                        // по ID находим объект в БД
                        var t6 = context.Ingredients.FirstOrDefault(ingredient => ingredient.ID_Ingredient == i6.ID_Ingredient);
                        // если сущность найдена в БД - удаляем
                        if (t6 != null) context.Ingredients.Remove(t6);
                        break;
                    case "Employee":
                        // приводим входной объект к требуемому типу
                        var i7 = item as Employee;
                        // по ID находим объект в БД
                        var t7 = context.Employees.FirstOrDefault(employee => employee.ID_Employee == i7.ID_Employee);
                        // если сущность найдена в БД - удаляем
                        if (t7 != null) context.Employees.Remove(t7);
                        break;
                    case "DishIngredient":
                        // приводим входной объект к требуемому типу
                        var i8 = item as DishIngredient;
                        // по ID находим объект в БД
                        var t8 = context.DishIngredients.FirstOrDefault(ingredient => ingredient.ID_IngridientDish == i8.ID_IngridientDish);
                        // если сущность найдена в БД - удаляем
                        if (t8 != null) context.DishIngredients.Remove(t8);
                        break;
                    case "Dish":
                        // приводим входной объект к требуемому типу
                        var i9 = item as Dish;
                        // по ID находим объект в БД
                        var t9 = context.Dishes.FirstOrDefault(dish => dish.ID_Dish == i9.ID_Dish);
                        // если сущность найдена в БД - удаляем
                        if (t9 != null) context.Dishes.Remove(t9);
                        break;

                }
                context.SaveChanges();
            }
        }

        /// <summary>
        /// Метод выбора коллекции сущностей по указнному условию предиката
        /// </summary>
        /// <typeparam name="T">Тип сущности</typeparam>
        /// <param name="predicate">Делегат предикат для условия поиска</param>
        public List<T> GetEntityes<T>(Func<T, bool> predicate) where T : class
        {
            using (var context = new RestaurantDBEntities())
            {
                if (typeof(T).Name == "OrderDish")
                {
                    return context.Set<T>().Include("Order").Include("Dish").Where(predicate).ToList();
                }
                if (typeof(T).Name == "Order")
                {
                    context.Dishes.Load();
                    context.Posts.Load();
                    return context.Set<T>().Include("Employee").Include("OrderDishes").Where(predicate).ToList();
                }
                if (typeof(T).Name == "DishIngredient")
                {
                    context.Ingredients.Load();
                    context.Units.Load();
                    return context.Set<T>().Include("Ingredient").Include("Dish").Include("Unit").Where(predicate).ToList();
                }
                if (typeof(T).Name == "Dish")
                {
                    return context.Set<T>().Include("TypeDish").ToList();
                }
                return context.Set<T>().Where(predicate).ToList();
            }
        }

        /// <summary>
        /// Метод выбора коллекции сущностей
        /// </summary>
        /// <typeparam name="T">Тип сущности</typeparam>
        /// <returns></returns>
        public List<T> GetEntityes<T>() where T : class
        {
            using (var context = new RestaurantDBEntities())
            {
                if (typeof(T).Name == "OrderDish")
                {
                    return context.Set<T>().Include("Order`").Include("Dish").ToList();
                }
                if (typeof(T).Name == "Order")
                {
                    context.Dishes.Load();
                    context.Posts.Load();
                    return context.Set<T>().Include("Employee").Include("OrderDishes").ToList();
                }
                if (typeof(T).Name == "Employee")
                {
                    
                    return context.Set<T>().Include("Post").ToList();
                }
                if (typeof(T).Name == "DishIngredient")
                {
                    context.Ingredients.Load();
                    context.Units.Load();
                    return context.Set<T>().Include("Ingredient").Include("Dish").Include("Unit").ToList();
                }
                if (typeof(T).Name == "Dish")
                {
                    context.TypeDishes.Load();
                    context.Units.Load();
                    return context.Set<T>().Include("TypeDish").ToList();
                }
                return context.Set<T>().ToList();
            }
        }

        /// <summary>
        /// Метод добавления сущности в БД
        /// </summary>
        public T AddEntity<T>(T entity) where T : class
        {
            using (var context = new RestaurantDBEntities())
            {
                var adedEntity = context.Set<T>().Add(entity);
                context.SaveChanges();
                return adedEntity;
            }
        }

        /// <summary>
        /// Метод обработки исключений
        /// </summary>
        public void HandleException(Exception exception)
        {
            var sb = new StringBuilder();
            var validationException = exception as DbEntityValidationException;
            if (validationException != null)
            {
                foreach (var dbEntityValidationResult in validationException.EntityValidationErrors)
                {
                    foreach (var dbValidationError in dbEntityValidationResult.ValidationErrors)
                    {
                        sb.AppendLine(dbValidationError.ErrorMessage);
                    }
                }
            }
            var innerEx = exception.InnerException ?? exception;
            while (true)
            {
                if (innerEx.InnerException == null)
                {
                    break;
                }
                innerEx = innerEx.InnerException;
            }
            MessageBox.Show(innerEx.Message + "\n" + sb, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
