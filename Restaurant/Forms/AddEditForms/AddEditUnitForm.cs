using System;
using System.Windows.Forms;
using Restaurant.Data;

namespace Restaurant.Forms.AddEditForms
{
    public partial class AddEditUnitForm : Form
    {
        /// <summary>
        /// Ссылка на объект для работы с БД
        /// </summary>
        private readonly Repository _repository;

        private Unit _item;

        /// <summary>
        /// Флаг режима редактирования сущности
        /// </summary>
        /// 
        private readonly bool _edit;
        /// <summary>
        /// Конструктор для редактирования
        /// </summary>
        public AddEditUnitForm(Unit item, Repository repository)
        {
            _item = item; // редактируемая сущность
            _repository = repository; // ссылка на объект для работы с БД
            _edit = true; // выставляем флаг режима редактирования
            InitializeComponent();
        }

        /// <summary>
        /// Конструктор для добавления
        /// </summary>
        public AddEditUnitForm(Repository repository)
        {
            _repository = repository;
            InitializeComponent();
        }

        /// <summary>
        /// Метод проверки вводимых пользователем значений
        /// </summary>
        /// <returns></returns>
        private bool Check()
        {
            if (string.IsNullOrWhiteSpace(textBoxUnitName.Text))
            {
                MessageBox.Show("Не верно заполнено поле Наименование еденицы измерения", "", MessageBoxButtons.OK,
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
                    _item.UnitName = textBoxUnitName.Text;
                    // обновляем в БД
                    _repository.UpdateUnit(_item);
                }
                else
                {
                    // создаём новую сущность
                    _item = new Unit
                    {
                        UnitName = textBoxUnitName.Text,
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
                textBoxUnitName.Text = _item.UnitName;
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
