using System;
using System.Windows.Forms;
using Restaurant.Data;
using Restaurant.Forms.AddEditForms;

namespace Restaurant.Forms
{
    public partial class OrdersForm : Form
    {
        /// <summary>
        /// ссылка на объект для доступа к БД
        /// </summary>
        private readonly Repository _repository;

        /// <summary>
        /// Конструктор формы
        /// </summary>
        public OrdersForm(Repository repository)
        {
            _repository = repository;
            InitializeComponent();
            UpdateDatagrid();
            // заполняем ComboBox типами блюд из БД
            comboBoxEmployee.DataSource = _repository.GetEntityes<Employee>();
            comboBoxEmployee.SelectedItem = null;
        }

        /// <summary>
        /// Метод обновления данных в DataGrid
        /// </summary>
        private void UpdateDatagrid()
        {
            dataGridView.DataSource = null;
            dataGridView.DataSource = _repository.GetEntityes<Order>();
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
                var item = dataGridView.SelectedRows[0].DataBoundItem as Order;
                // передаём полученный объект в конструктор формы редактирования и показываем форму
                new AddEditOrderForm(item, _repository).ShowDialog();
                // обновляем DataGrid после закрытия формы редактирования
                UpdateDatagrid();
            }
            // если клик по кнопке в строке с кнопкой удаления
            if (e.ColumnIndex == dataGridView.Columns["DeleteColumn"].Index)
            {
                // получаем объект, привязанный к строке
                var item = dataGridView.SelectedRows[0].DataBoundItem as Order;
                // задаём пользователю вопрос
                var result = MessageBox.Show("Удалить заказ с кодом " + item.ID_Order,"",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
                // если ответ не положительный - выйти из метода
                if (result!=DialogResult.OK) return;
                // в противном случае попытаться удалить объект с БД
                try
                {
                    _repository.RemoveItem<Order>(item); // удаляем объект
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
            new AddEditOrderForm(_repository).ShowDialog();
            // после добавления объекта обновляем DataGrid
            UpdateDatagrid();
        }

        /// <summary>
        /// Обработка события нажатия кнопки Поиск
        /// </summary>
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            var employee = comboBoxEmployee.SelectedItem as Employee;
            dataGridView.DataSource = null;
            DateTime date;
            if (DateTime.TryParse(maskedTextBox.Text,out date))
            {
                // обновляем DataGrid коллекцией полученной с помощью поиска по заданным параметрам
                dataGridView.DataSource = _repository.SearchOrder(employee,date);
            }
            else
            {
                // обновляем DataGrid коллекцией полученной с помощью поиска по заданным параметрам
                dataGridView.DataSource = _repository.SearchOrder(employee, null);
            }
            
        }

        /// <summary>
        /// Обработка события нажатия кнопки Очистить
        /// </summary>
        private void buttonClearSearch_Click(object sender, EventArgs e)
        {
            // очищаем поля поиска
            comboBoxEmployee.SelectedItem = null;
            maskedTextBox.Clear();
            // обновляем DataGrid
            UpdateDatagrid();
        }

        


    }
}
