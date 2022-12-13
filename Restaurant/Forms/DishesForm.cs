using System;
using System.Windows.Forms;
using Restaurant.Data;
using Restaurant.Forms.AddEditForms;

namespace Restaurant.Forms
{
    public partial class DishesForm : Form
    {
        /// <summary>
        /// ссылка на объект для доступа к БД
        /// </summary>
        private readonly Repository _repository;

        /// <summary>
        /// Режим выбора блюда для заказа
        /// </summary>
        private readonly bool _selectMode;

        /// <summary>
        /// Выбранное блюдо для заказа
        /// </summary>
        public Dish Dish { get;private set; }

        /// <summary>
        /// Конструктор формы
        /// </summary>
        public DishesForm(Repository repository)
        {
            _repository = repository;
            InitializeComponent();
            UpdateDatagrid();
            // заполняем ComboBox типами блюд из БД
            comboBoxTypeDish.DataSource = _repository.GetEntityes<TypeDish>();
            comboBoxTypeDish.SelectedItem = null;
        }

        /// <summary>
        /// Конструктор формы режима выбора блюда для заказа
        /// </summary>
        public DishesForm(Repository repository, bool selectMode)
        {
            _selectMode = true;
            _repository = repository;
            InitializeComponent();
            UpdateDatagrid();
            // заполняем ComboBox типами блюд из БД
            comboBoxTypeDish.DataSource = _repository.GetEntityes<TypeDish>();
            comboBoxTypeDish.SelectedItem = null;
        }

        /// <summary>
        /// Метод обновления данных в DataGrid
        /// </summary>
        private void UpdateDatagrid()
        {
            dataGridView.DataSource = null;
            dataGridView.DataSource = _repository.GetEntityes<Dish>();
        }

        /// <summary>
        /// Метод обработки события клика по ячейке DataGrid
        /// </summary>
        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == dataGridView.NewRowIndex || e.RowIndex < 0)
                return;
            // если клик по кнопке в строке с кнопкой редактирования
            if (e.ColumnIndex == dataGridView.Columns["EditColumn"].Index)
            {
                // получаем объект, привязанный к строке
                var item = dataGridView.SelectedRows[0].DataBoundItem as Dish;
                // передаём полученный объект в конструктор формы редактирования и показываем форму
                new AddEditDishForm(item, _repository).ShowDialog();
                // обновляем DataGrid после закрытия формы редактирования
                UpdateDatagrid();
            }
            // выбранное блюда в режиме выбора для заказа
            if (e.ColumnIndex == dataGridView.Columns["SelectColumn"].Index)
            {
                // получаем объект, привязанный к строке
                Dish = dataGridView.SelectedRows[0].DataBoundItem as Dish;
                DialogResult=DialogResult.OK;
            }
            if (e.ColumnIndex == dataGridView.Columns["DishIngridientsColumn"].Index)
            {
                // получаем объект, привязанный к строке
                var item = dataGridView.SelectedRows[0].DataBoundItem as Dish;
                // скрываем текущую форму
                Hide();
                // передаём полученный объект в конструктор формы редактирования и показываем форму
                new DishIngridientsForm(_repository, item).ShowDialog();
                // показываем текущую форму
                Show();
                // обновляем DataGrid после закрытия формы редактирования
                UpdateDatagrid();
            }
            
            // если клик по кнопке в строке с кнопкой удаления
            if (e.ColumnIndex == dataGridView.Columns["DeleteColumn"].Index)
            {
                // получаем объект, привязанный к строке
                var item = dataGridView.SelectedRows[0].DataBoundItem as Dish;
                // задаём пользователю вопрос
                var result = MessageBox.Show("Удалить объект с кодом " + item.ID_Dish,"",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
                // если ответ не положительный - выйти из метода
                if (result!=DialogResult.OK) return;
                // в противном случае попытаться удалить объект с БД
                try
                {
                    _repository.RemoveItem<Dish>(item); // удаляем объект
                    UpdateDatagrid(); // после удаления обновляем DataGrid
                }
                catch (Exception ex)
                {
                    // если выбросило исключение - обрабатываем
                    _repository.HandleException(ex);
                }
            }
        }

        /// <summary>
        /// Обработка события нажатия кнопки Добавить
        /// </summary>
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // открываем форму добавления сущности
            // в конструкторе передаём ссылку на объект для работы с БД
            new AddEditDishForm(_repository).ShowDialog();
            // после добавления объекта обновляем DataGrid
            UpdateDatagrid();
        }

        /// <summary>
        /// Обработка события нажатия кнопки Поиск
        /// </summary>
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            var typeDish = comboBoxTypeDish.SelectedItem as TypeDish;
            dataGridView.DataSource = null;
            // обновляем DataGrid коллекцией полученной с помощью поиска по заданным параметрам
            dataGridView.DataSource = _repository.SearchDishes(typeDish, textBoxDishName.Text);
        }

        /// <summary>
        /// Обработка события нажатия кнопки Очистить
        /// </summary>
        private void buttonClearSearch_Click(object sender, EventArgs e)
        {
            // очищаем поля поиска
            comboBoxTypeDish.SelectedItem = null;
            textBoxDishName.Clear();
            // обновляем DataGrid
            UpdateDatagrid();
        }

        /// <summary>
        /// Обработка события загрузки формы
        /// </summary>
        private void DishesForm_Load(object sender, EventArgs e)
        {
            if (_selectMode)
            {
                dataGridView.Columns["SelectColumn"].Visible = true;
                dataGridView.Columns["DeleteColumn"].Visible = false;
                dataGridView.Columns["EditColumn"].Visible = false;
                buttonAdd.Visible = false;
            }
            else
            {
                dataGridView.Columns["SelectColumn"].Visible = false;//
            }
        }

        


    }
}
