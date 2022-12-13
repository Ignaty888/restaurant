using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Restaurant.Data;

namespace Restaurant.Forms.AddEditForms
{
    public partial class AddEditDishForm : Form
    {
        /// <summary>
        /// Ссылка на объект для работы с БД
        /// </summary>
        private readonly Repository _repository;

        /// <summary>
        /// Ссылка на объект добавляемой/редактируемой сущности
        /// </summary>
        private Dish _item;

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
        public AddEditDishForm(Dish item, Repository repository)
        {
            _item = item; // редактируемая сущность
            _repository = repository; // ссылка на объект для работы с БД
            _edit = true; // выставляем флаг режима редактирования
            InitializeComponent();
        }

        /// <summary>
        /// Конструктор для добавления
        /// </summary>
        public AddEditDishForm(Repository repository)
        {
            _repository = repository;
            InitializeComponent();
        }

        /// <summary>
        /// Метод проверки вводимых пользователем значений
        /// </summary>
        private bool Check()
        {
            if (string.IsNullOrWhiteSpace(textBoxDishName.Text))
            {
                MessageBox.Show("Не верно заполнено поле Наименование Блюда", "", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }
            decimal price;
            if (!decimal.TryParse(textBoxprice.Text, out price))
            {
                MessageBox.Show("Не верно заполнено поле Цена", "", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }
            if (comboBoxTypeDish.SelectedItem == null)
            {
                MessageBox.Show("Не выбран Тип блюда", "", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }
            if (_photo == null)
            {
                MessageBox.Show("Не загружено Фото блюда", "", MessageBoxButtons.OK,
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
                    _item.DishName = textBoxDishName.Text;
                    _item.ID_TypeDish = (comboBoxTypeDish.SelectedItem as TypeDish).ID_TypeDish;
                    _item.Price = decimal.Parse(textBoxprice.Text);
                    _item.Detail = textBoxDetailed.Text;
                    _item.Photo = _photo;
                    _repository.UpdateDish(_item);
                }
                else
                {
                    // создаём новую сущность
                    _item = new Dish
                    {
                        DishName = textBoxDishName.Text,
                        ID_TypeDish = (comboBoxTypeDish.SelectedItem as TypeDish).ID_TypeDish,
                        Price = decimal.Parse(textBoxprice.Text),
                        Detail = textBoxDetailed.Text,
                        Photo = _photo
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
            comboBoxTypeDish.DataSource = _repository.GetEntityes<TypeDish>();
            // убираем выбор с ComboBox
            comboBoxTypeDish.SelectedItem = null;
            // после загрузки формы подписываем названия формы и названия кнопок
            if (_item != null)
            {
                // если сущность не равна NULL - редактирование
                buttonAddEdit.Text = "Сохранить";
                Text = "Редактирование";
                // выводим свойства редактируемой сущности на форму
                textBoxDishName.Text = _item.DishName;
                textBoxprice.Text = _item.Price.ToString("F2");
                textBoxDetailed.Text = _item.Detail;
                comboBoxTypeDish.SelectedItem = _item.TypeDish;
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
