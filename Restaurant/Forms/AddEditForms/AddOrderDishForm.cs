using System;
using System.Windows.Forms;
using Restaurant.Data;

namespace Restaurant.Forms.AddEditForms
{
    public partial class AddOrderDishForm : Form
    {
        /// <summary>
        /// Ссылка на объект для работы с БД
        /// </summary>
        private readonly Repository _repository;

        /// <summary>
        /// Блюдо в заказе
        /// </summary>
        public OrderDish OrderDish { get; private set; }

        /// <summary>
        /// Выбранное блюдо
        /// </summary>
        private Dish _selectedDish;

        /// <summary>
        /// Конструктор для добавления
        /// </summary>
        public AddOrderDishForm(Repository repository)
        {
            _repository = repository;
            InitializeComponent();
        }

       
        /// <summary>
        /// Обработка события нажатия кнопки Добавить/Сохранить
        /// </summary>
        private void buttonAddEdit_Click(object sender, EventArgs e)
        {
            int quantity;
            if (!int.TryParse(textBoxQuantity.Text, out quantity))
            {
                MessageBox.Show("Не верно заполнено поле Количество порций", "", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            OrderDish=new OrderDish()
            {
                Dish_ID = _selectedDish.ID_Dish,
                Quantity = quantity,
                Dish = _selectedDish
            };
           
            DialogResult=DialogResult.OK;
        }

        /// <summary>
        /// Обработка события нажатия кнопки поиска Блюда
        /// </summary>
        private void buttonFindDish_Click(object sender, EventArgs e)
        {
            var selectDishForm = new DishesForm(_repository, true);
            if (selectDishForm.ShowDialog() == DialogResult.OK)
            {
                _selectedDish = selectDishForm.Dish;
                textBoxSelectedDish.Text = _selectedDish.DishName;
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
