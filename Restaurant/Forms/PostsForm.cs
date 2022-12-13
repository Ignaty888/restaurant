using System;
using System.Windows.Forms;
using Restaurant.Data;
using Restaurant.Forms.AddEditForms;

namespace Restaurant.Forms
{
    public partial class PostsForm : Form
    {
        /// <summary>
        /// ссылка на объект для доступа к БД
        /// </summary>
        private readonly Repository _repository;

        /// <summary>
        /// Конструктор формы
        /// </summary>
        public PostsForm(Repository repository)
        {
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
            dataGridView.DataSource = _repository.GetEntityes<Post>();
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
                var item = dataGridView.SelectedRows[0].DataBoundItem as Post;
                // передаём полученный объект в конструктор формы редактирования и показываем форму
                new AddEditPostForm(item, _repository).ShowDialog();
                // обновляем DataGrid после закрытия формы редактирования
                UpdateDatagrid();
            }
            // если клик по кнопке в строке с кнопкой удаления
            if (e.ColumnIndex == dataGridView.Columns["DeleteColumn"].Index)
            {
                // получаем объект, привязанный к строке
                var item = dataGridView.SelectedRows[0].DataBoundItem as Post;
                // задаём пользователю вопрос
                var result = MessageBox.Show("Удалить объект с кодом " + item.ID_post,"",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
                // если ответ не положительный - выйти из метода
                if (result!=DialogResult.OK) return;
                // в противном случае попытаться удалить объект с БД
                try
                {
                    _repository.RemoveItem<Post>(item); // удаляем объект
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
            new AddEditPostForm(_repository).ShowDialog();
            // после добавления объекта обновляем DataGrid
            UpdateDatagrid();
        }

        


    }
}
