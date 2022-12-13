using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Restaurant.Data;

namespace Restaurant.Forms.AddEditForms
{
    public partial class AddEditOrderForm : Form
    {
        /// <summary>
        /// Ссылка на объект для работы с БД
        /// </summary>
        private readonly Repository _repository;

        /// <summary>
        /// Ссылка на объект добавляемой/редактируемой сущности
        /// </summary>
        private Order _order;

        /// <summary>
        /// Сотрудник в заказе
        /// </summary>
        private Employee _orderEmployee;

        /// <summary>
        /// Блюда в заказе
        /// </summary>
        private List<OrderDish> _orderDishes;

        /// <summary>
        /// Флаг режима редактирования сущности
        /// </summary>
        /// 
        private readonly bool _edit;

        /// <summary>
        /// Конструктор для редактирования
        /// </summary>
        public AddEditOrderForm(Order order, Repository repository)
        {
            _order = order; // редактируемая сущность
            _orderDishes = order.OrderDishes.ToList();
            _repository = repository; // ссылка на объект для работы с БД
            _edit = true; // выставляем флаг режима редактирования
            InitializeComponent();
        }

        /// <summary>
        /// Конструктор для добавления
        /// </summary>
        public AddEditOrderForm(Repository repository)
        {
            _repository = repository;
            _orderDishes = new List<OrderDish>();
            InitializeComponent();
        }

        /// <summary>
        /// Метод проверки вводимых пользователем значений
        /// </summary>
        private bool Check()
        {
            if (_orderEmployee == null)
            {
                MessageBox.Show("Не выбран сотрудник в заказе", "", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        /// <summary>
        /// Обработка события нажатия кнопки Добавить/Сохранить
        /// </summary>
        private void buttonAddEdit_Click(object sender, EventArgs e)
        {
            // проверяем вводимые данные
            if (!Check()) return;
            try
            {
                if (_edit)// если стоит флаг редактирования
                {
                    // присваиваем введенные значения редактируемой сущности
                    _order.ID_Employee = _orderEmployee.ID_Employee;
                    _repository.UpdateOrder(_order);
                }
                else
                {
                    // создаём новую сущность Заказ
                    _order = new Order()
                    {
                        Date = DateTime.Now.Date,
                        ID_Employee = _orderEmployee.ID_Employee
                    };
                    // Добавляем сущность в БД
                    var addedOrder = _repository.AddEntity(_order);
                    // добавляем блюда заказа в БД
                    foreach (var orderDish in _orderDishes)
                    {
                        orderDish.Dish = null;
                        orderDish.ID_Order = addedOrder.ID_Order;
                        _repository.AddEntity(orderDish);
                    }
                }
                // закрываем форму
                Close();
            }
            catch (Exception exception)
            {
                // обработка исключений
                _repository.HandleException(exception);
            }
        }

        /// <summary>
        /// Обработка события загрузки формы
        /// </summary>
        private void AddEditPostForm_Load(object sender, EventArgs e)
        {
            // после загрузки формы подписываем названия формы и названия кнопок
            if (_order != null) // если сущность не равна NULL - редактирование
            {
                buttonAddEdit.Text = "Сохранить";
                Text = "Редактирование";
                // выводим дату заказа
                _orderEmployee = _order.Employee;
                labelOrderDate.Text = _order.Date.ToString("g");
                // выводим свойства редактируемой сущности на форму
                textBoxEmployee.Text = _order.Employee.EmployeeFio; // сотрудник
                UpdateDataGrid();
            }
            else
            {
                buttonAddEdit.Text = "Добавить";
                Text = "Добавление";
            }
        }

        /// <summary>
        /// Обработка события нажатия кнопки поиска сотрудника для заказа
        /// </summary>
        private void buttonSelectEmployee_Click(object sender, EventArgs e)
        {
            var findEmployeeForm = new EmployeesForm(_repository, true);
            if (findEmployeeForm.ShowDialog() == DialogResult.OK)
            {
                _orderEmployee = findEmployeeForm.Employee;
                textBoxEmployee.Text = _orderEmployee.EmployeeFio;
            }
        }

        /// <summary>
        /// Обработка события нажатия кнопки Добавить блюдо
        /// </summary>
        private void buttonAddDish_Click(object sender, EventArgs e)
        {
            // выводим форму выбора блюда из списка
            var orderDishForm = new AddOrderDishForm(_repository);
            // если пользователь нажал кнопку выбрать блюдо
            if (orderDishForm.ShowDialog() == DialogResult.OK)
            {
                if (_edit) // если редактирование заказа
                {
                    try
                    {
                        // при редактировании у нас есть номер заказа
                        // поэтому можем добавлять данные сразу в БД
                        var orderDish = orderDishForm.OrderDish;
                        orderDish.Dish = null;
                        orderDish.ID_Order = _order.ID_Order;
                        _repository.AddEntity(orderDish);
                    }
                    catch (Exception exception)
                    {
                        _repository.HandleException(exception);
                    }
                }
                else
                {
                    // если добавление нового заказа
                    // добавляем блюда во временную коллекцию
                    if (_orderDishes.Find(orderDish => orderDish.Dish_ID == orderDishForm.OrderDish.Dish_ID) != null)
                    {
                        MessageBox.Show(
                            " В данном заказе уже есть данное блюдо! Удалите блюдо и добавьте с требуемым количеством порций!",
                            "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        _orderDishes.Add(orderDishForm.OrderDish);
                    }
                }
                // обновляем DataGrid с блюдами
                UpdateDataGrid();
            }
        }

        /// <summary>
        /// Метод обновления данных DataGrid с блюдами
        /// </summary>
        private void UpdateDataGrid()
        {
            if (_edit)// если редактирование - обновляем таблицу с БД
            {
                dataGridView.DataSource = null;
                var list = _repository.GetEntityes<OrderDish>(order => order.ID_Order == _order.ID_Order);
                dataGridView.DataSource = list;
                textBoxTotal.Text = list.Sum(dish => dish.Totalprice).ToString("C2");
            }
            else // если добавление нового заказа - обновляем с временной коллекции, так как ещё нет ID заказа
            {
                dataGridView.DataSource = null;
                dataGridView.DataSource = _orderDishes;
                textBoxTotal.Text = _orderDishes.Sum(dish => dish.Totalprice).ToString("C2");
            }
        }

        /// <summary>
        /// Обработка события нажатия кнопки Удалить в таблице блюд заказа
        /// </summary>
        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == dataGridView.NewRowIndex || e.RowIndex < 0)
                return;
            // если клик по кнопке в строке с кнопкой удаления
            if (e.ColumnIndex == dataGridView.Columns["DeleteColumn"].Index)
            {
                // получаем объект, привязанный к строке
                var item = dataGridView.SelectedRows[0].DataBoundItem as OrderDish;
                try
                {
                    if (_edit)// если редактирование - удаляем с БД
                    {
                        _repository.RemoveItem<OrderDish>(item); // удаляем объект 
                    }
                    else // если добавление нового заказа - удаляем с временной коллекции 
                    {
                        var orderDish = _orderDishes.Find(dish => dish.Dish_ID == item.Dish_ID);
                        _orderDishes.Remove(orderDish);
                    }
                    UpdateDataGrid(); // после удаления обновляем DataGrid
                }
                catch (Exception ex)
                {
                    // если выбросило исключение - обрабатываем
                    _repository.HandleException(ex);
                }
            }
        }

        /// <summary>
        /// Обработка события нажатия кнопки Отмена
        /// </summary>
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
