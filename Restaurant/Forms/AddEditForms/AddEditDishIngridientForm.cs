using System;
using System.Windows.Forms;
using Restaurant.Data;

namespace Restaurant.Forms.AddEditForms
{
    public partial class AddEditDishIngridientForm : Form
    {
        /// <summary>
        /// Ссылка на объект для работы с БД
        /// </summary>
        private readonly Repository _repository;

        private DishIngredient _item;

        private Dish _dish;

        /// <summary>
        /// Флаг режима редактирования сущности
        /// </summary>
        /// 
        private readonly bool _edit;
        /// <summary>
        /// Конструктор для редактирования
        /// </summary>
        public AddEditDishIngridientForm(DishIngredient item, Repository repository)
        {
            _item = item; // редактируемая сущность
            _repository = repository; // ссылка на объект для работы с БД
            _edit = true; // выставляем флаг режима редактирования
            InitializeComponent();
        }

        /// <summary>
        /// Конструктор для добавления
        /// </summary>
        public AddEditDishIngridientForm(Repository repository, Dish dish)
        {
            _dish = dish;
            _repository = repository;
            InitializeComponent();
        }

        /// <summary>
        /// Метод проверки вводимых пользователем значений
        /// </summary>
        /// <returns></returns>
        private bool Check()
        {
            double quantity;
            if (!double.TryParse(textBoxQuantity.Text, out quantity))
            {
                MessageBox.Show("Не верно заполнено поле Количество", "", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }
            if (comboBoxIngridient.SelectedItem==null)
            {
                MessageBox.Show("Не выбран ингридиент", "", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }
            if (comboBoxUnit.SelectedItem == null)
            {
                MessageBox.Show("Не выбрана единица измерения", "", MessageBoxButtons.OK,
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
                    // присваиваем введенные значения сущности
                    _item.Ingridient_ID = (comboBoxIngridient.SelectedItem as Ingredient).ID_Ingredient;
                    _item.ID_Unit = (comboBoxUnit.SelectedItem as Unit).ID_Unit;
                    _item.Quantity = double.Parse(textBoxQuantity.Text);
                    _repository.UpdateDishIngridient(_item);
                }
                else
                {
                    // создаём новую сущность
                    _item = new DishIngredient()
                    {
                        Dish_ID = _dish.ID_Dish,
                        Ingridient_ID = (comboBoxIngridient.SelectedItem as Ingredient).ID_Ingredient,
                        ID_Unit = (comboBoxUnit.SelectedItem as Unit).ID_Unit,
                        Quantity = double.Parse(textBoxQuantity.Text)
                    };
                    // Добавляем сущность в БД
                    _repository.AddEntity(_item);
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
            comboBoxIngridient.DataSource = _repository.GetEntityes<Ingredient>();
            comboBoxUnit.DataSource = _repository.GetEntityes<Unit>();
            comboBoxIngridient.SelectedItem = null;
            comboBoxUnit.SelectedItem = null;

            // после загрузки формы подписываем названия формы и названия кнопок
            if (_item != null)
            {
                // если сущность не равна NULL - редактирование
                buttonAddEdit.Text = "Сохранить";
                Text = "Редактирование";
                textBoxQuantity.Text = _item.Quantity.ToString("F2");
                comboBoxIngridient.SelectedItem = _item.Ingredient;
                comboBoxUnit.SelectedItem = _item.Unit;
            }
            else
            {
                buttonAddEdit.Text = "Добавить";
                Text = "Добавление";
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
