using System;
using System.Windows.Forms;
using Restaurant.Data;
using Restaurant.Forms.AddEditForms;

namespace Restaurant.Forms
{
    public partial class EmployeesForm : Form
    {
        /// <summary>
        /// Выбранный сотрудник в режиме выбора для формы заказа
        /// </summary>
        public Employee Employee { get;private set; }

        /// <summary>
        /// ссылка на объект для доступа к БД
        /// </summary>
        private readonly Repository _repository;

        /// <summary>
        /// Режим выбора сотрудника для формы заказа
        /// </summary>
        private readonly bool _selectMode;

        /// <summary>
        /// Конструктор формы
        /// </summary>
        public EmployeesForm(Repository repository)
        {
            _repository = repository;
            InitializeComponent();
            UpdateDatagrid();
        }

        /// <summary>
        /// Конструктор формы для режима выбора сотрудника в заказе
        /// </summary>
        public EmployeesForm(Repository repository,bool selectMode)
        {
            _selectMode = true;
            _repository = repository;
            InitializeComponent();
            UpdateDatagrid();
        }

        /// <summary>
        /// Метод обновления данных в DataGrid
        /// </summary>
        private void UpdateDatagrid()
        {
            dataGridView.DataSource = null;
            dataGridView.DataSource = _repository.GetEntityes<Employee>();
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
                var item = dataGridView.SelectedRows[0].DataBoundItem as Employee;
                // передаём полученный объект в конструктор формы редактирования и показываем форму
                new AddEditEmployeeForm(item, _repository).ShowDialog();
                // обновляем DataGrid после закрытия формы редактирования
                UpdateDatagrid();
            }
            // если клик по кнопке Выбрать сотрудника в режиме выбора
            if (e.ColumnIndex == dataGridView.Columns["SelectColumn"].Index)
            {
                // получаем объект, привязанный к строке
                Employee = dataGridView.SelectedRows[0].DataBoundItem as Employee;
                // сообщаем вызвавшему окну об успешном выборе сотрудника
                DialogResult=DialogResult.OK;
            }
            // если клик по кнопке в строке с кнопкой удаления
            if (e.ColumnIndex == dataGridView.Columns["DeleteColumn"].Index)
            {
                // получаем объект, привязанный к строке
                var item = dataGridView.SelectedRows[0].DataBoundItem as Employee;
                // задаём пользователю вопрос
                var result = MessageBox.Show("Удалить объект с кодом " + item.ID_Employee,"",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
                // если ответ не положительный - выйти из метода
                if (result!=DialogResult.OK) return;
                // в противном случае попытаться удалить объект с БД
                try
                {
                    _repository.RemoveItem<Employee>(item); // удаляем объект
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
            new AddEditEmployeeForm(_repository).ShowDialog();
            // после добавления объекта обновляем DataGrid
            UpdateDatagrid();
        }

        /// <summary>
        /// Обработка события нажатия кнопки Поиск
        /// </summary>
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            var post = comboBoxPost.SelectedItem as Post;
            dataGridView.DataSource = null;
            // обновляем DataGrid коллекцией полученной с помощью поиска по заданным параметрам
            dataGridView.DataSource = _repository.SearchEmployees(textBoxFName.Text,textBoxName.Text, textBoxLName.Text,post);
        }

        /// <summary>
        /// Обработка события нажатия кнопки Очистить
        /// </summary>
        private void buttonClearSearch_Click(object sender, EventArgs e)
        {
            // очищаем поля поиска
            comboBoxPost.SelectedItem = null;
            textBoxFName.Clear();
            textBoxName.Clear();
            textBoxLName.Clear();
            // обновляем DataGrid
            UpdateDatagrid();
        }

        /// <summary>
        /// Обработка события загрузки формы
        /// </summary>
        private void EmployeesForm_Load(object sender, EventArgs e)
        {
            // заполняем список должностей в панели поиска
            comboBoxPost.DataSource = _repository.GetEntityes<Post>();
            comboBoxPost.SelectedItem = null;
            if (_selectMode)
            {
                dataGridView.Columns["EditColumn"].Visible = false;
                dataGridView.Columns["DeleteColumn"].Visible = false;
                buttonAdd.Visible = false;
                dataGridView.Columns["SelectColumn"].Visible = true;
            }
            else
            {
                dataGridView.Columns["SelectColumn"].Visible = false; 
            }
        }
    }
}
