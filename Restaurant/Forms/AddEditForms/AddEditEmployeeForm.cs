using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Restaurant.Data;

namespace Restaurant.Forms.AddEditForms
{
    public partial class AddEditEmployeeForm : Form
    {
        /// <summary>
        /// Ссылка на объект для работы с БД
        /// </summary>
        private readonly Repository _repository;

        /// <summary>
        /// Ссылка на объект добавляемой/редактируемой сущности
        /// </summary>
        private Employee _item;

        /// <summary>
        /// Массив байт для фото блюда
        /// </summary>
        private byte[] _photo;

        /// <summary>
        /// Флаг режима редактирования сущности
        /// </summary>
        /// 
        private readonly bool _edit;
        /// <summary>
        /// Конструктор для редактирования
        /// </summary>
        public AddEditEmployeeForm(Employee item, Repository repository)
        {
            _item = item; // редактируемая сущность
            _repository = repository; // ссылка на объект для работы с БД
            _edit = true; // выставляем флаг режима редактирования
            InitializeComponent();
        }

        /// <summary>
        /// Конструктор для добавления
        /// </summary>
        public AddEditEmployeeForm(Repository repository)
        {
            _repository = repository;
            InitializeComponent();
        }

        /// <summary>
        /// Метод проверки вводимых пользователем значений
        /// </summary>
        private bool Check()
        {
            if (string.IsNullOrWhiteSpace(textBoxFName.Text))
            {
                MessageBox.Show("Не верно заполнено поле Фамилия", "", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(textBoxName.Text))
            {
                MessageBox.Show("Не верно заполнено поле Имя", "", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(textBoxLName.Text))
            {
                MessageBox.Show("Не верно заполнено поле Отчество", "", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }
            if (!maskedTextBoxPhone.MaskFull)
            {
                MessageBox.Show("Не верно заполнено поле Телефон", "", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }
            if (dateTimePickerBirthdate.Value.Date==DateTime.Now.Date)
            {
                MessageBox.Show("Не верно заполнено поле Дата рождения (указана текущая дата)", "", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }
            if (comboBoxPost.SelectedItem==null)
            {
                MessageBox.Show("Не выбрана должность сотрудника", "", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(textBoxAddress.Text))
            {
                MessageBox.Show("Не заполнено поле Адрес", "", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }
            if (_photo == null)
            {
                MessageBox.Show("Не загружено Фото сотрудника", "", MessageBoxButtons.OK,
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
                    _item.FName = textBoxFName.Text;
                    _item.EmpName = textBoxName.Text;
                    _item.LName = textBoxLName.Text;
                    _item.ID_post = (comboBoxPost.SelectedItem as Post).ID_post;
                    _item.Birthdate = dateTimePickerBirthdate.Value;
                    _item.Address = textBoxAddress.Text;
                    _item.Phone =maskedTextBoxPhone.Text;
                    _item.Photo = _photo;
                   
                    _repository.UpdateEmployee(_item);
                }
                else
                {
                    // создаём новую сущность
                    _item = new Employee
                    {
                        FName = textBoxFName.Text,
                        EmpName = textBoxName.Text,
                        LName = textBoxLName.Text,
                        ID_post = (comboBoxPost.SelectedItem as Post).ID_post,
                        Birthdate = dateTimePickerBirthdate.Value,
                        Address = textBoxAddress.Text,
                        Phone =maskedTextBoxPhone.Text,
                        Photo = _photo,
                        DateEmployment=DateTime.Now.Date
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
            // загружаем в ComboBox с БД коллекцию типов блюда
            comboBoxPost.DataSource = _repository.GetEntityes<Post>();
            // убираем выбор с ComboBox
            comboBoxPost.SelectedItem = null;
            // после загрузки формы подписываем названия формы и названия кнопок
            if (_item != null)
            {
                // если сущность не равна NULL - редактирование
                buttonAddEdit.Text = "Сохранить";
                Text = "Редактирование";

                // выводим свойства редактируемой сущности на форму
                textBoxFName.Text = _item.FName;
                textBoxName.Text = _item.EmpName;
                textBoxLName.Text = _item.LName;
                comboBoxPost.SelectedItem = _item.Post;
                dateTimePickerBirthdate.Value = _item.Birthdate;
                textBoxAddress.Text = _item.Address;
                maskedTextBoxPhone.Text = _item.Phone;
                textBoxDateEmployment.Text = _item.DateEmployment.ToShortDateString();
                // выводим фото в PictureBox
                pictureBox.Image = _item.Photo == null ? null : Image.FromStream(new MemoryStream(_item.Photo));
                _photo = _item.Photo;
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

        /// <summary>
        /// Обработка события нажатия кнопки Загрузить фото
        /// </summary>
        private void buttonLoadPhoto_Click(object sender, EventArgs e)
        {
            var opd = new OpenFileDialog
            {
                Filter = "jpeg files (*.jpg)|*.jpg|bmp files (*.bmp)|*.bmp|png files (*.png)|*.png"
            };
            if (opd.ShowDialog() != DialogResult.OK) return;

            _photo = File.ReadAllBytes(opd.FileName);
            pictureBox.Image = Image.FromStream(new MemoryStream(_photo));
        }
    }
}
