using System;
using System.Windows.Forms;
using Restaurant.Data;

namespace Restaurant.Forms.AddEditForms
{
    public partial class AddEditPostForm : Form
    {
        /// <summary>
        /// Ссылка на объект для работы с БД
        /// </summary>
        private readonly Repository _repository;

        /// <summary>
        /// Ссылка на объект добавляемой/редактируемой сущности
        /// </summary>
        private Post _item;

        /// <summary>
        /// Флаг режима редактирования сущности
        /// </summary>
        /// 
        private readonly bool _edit;
        /// <summary>
        /// Конструктор для редактирования
        /// </summary>
        public AddEditPostForm(Post item, Repository repository)
        {
            _item = item; // редактируемая сущность
            _repository = repository; // ссылка на объект для работы с БД
            _edit = true; // выставляем флаг режима редактирования
            InitializeComponent();
        }

        /// <summary>
        /// Конструктор для добавления
        /// </summary>
        public AddEditPostForm(Repository repository)
        {
            _repository = repository;
            InitializeComponent();
        }

        /// <summary>
        /// Метод проверки вводимых пользователем значений
        /// </summary>
        private bool Check()
        {
            if (string.IsNullOrWhiteSpace(textBoxPostName.Text))
            {
                MessageBox.Show("Не верно заполнено поле Наименование Должности", "", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }
            decimal salary;
            if (!decimal.TryParse(textBoxSalary.Text, out salary))
            {
                MessageBox.Show("Не верно заполнено поле Оклад", "", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }
            int percent;
            if (!int.TryParse(textBoxSalePercent.Text, out percent))
            {
                MessageBox.Show("Не верно заполнено поле Процент от продаж", "", MessageBoxButtons.OK,
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
                    _item.PostName = textBoxPostName.Text;
                    _item.Salary = decimal.Parse(textBoxSalary.Text);
                    _item.SalePercent = int.Parse(textBoxSalePercent.Text);
                    _repository.UpdatePost(_item);
                }
                else
                {
                    // создаём новую сущность
                    _item = new Post
                    {
                        PostName = textBoxPostName.Text,
                        Salary = decimal.Parse(textBoxSalary.Text),
                        SalePercent = int.Parse(textBoxSalePercent.Text)
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
            // после загрузки формы подписываем названия формы и названия кнопок
            if (_item != null)
            {
                // если сущность не равна NULL - редактирование
                buttonAddEdit.Text = "Сохранить";
                Text = "Редактирование";
                // выводим свойства редактируемой сущности на форму
                textBoxPostName.Text = _item.PostName;
                textBoxSalary.Text = _item.Salary.ToString("F2");
                textBoxSalePercent.Text = _item.SalePercent.ToString();
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
