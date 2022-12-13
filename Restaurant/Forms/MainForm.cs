using System.Linq;
using System.Windows.Forms;
using Restaurant.Data;
using Restaurant.Forms.AddEditForms;

namespace Restaurant.Forms
{
    public partial class MainForm : Form
    {
        private readonly Repository _repository;

        public MainForm()
        {
            _repository = new Repository();
            InitializeComponent();
        }

        /// <summary>
        /// Обработка события нажатия пункта меню Единицы измерения
        /// </summary>
        private void единицыИзмеренияToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            new UnitsForm(_repository).ShowDialog();
        }

        /// <summary>
        /// Обработка события нажатия пункта меню Должности
        /// </summary>
        private void должностиToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            new PostsForm(_repository).ShowDialog();
        }

        /// <summary>
        /// Обработка события нажатия пункта меню Блюда
        /// </summary>
        private void блюдаToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            new DishesForm(_repository).ShowDialog();
        }

        /// <summary>
        /// Обработка события нажатия пункта меню Типы блюд
        /// </summary>
        private void типыБлюдToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            new TypeDishesForm(_repository).ShowDialog();
        }

        /// <summary>
        /// Обработка события нажатия пункта меню Ингридиенты
        /// </summary>
        private void ингридиентыToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            new IngridientsForm(_repository).ShowDialog();
        }

        /// <summary>
        /// Обработка события нажатия пункта меню Сотрудники
        /// </summary>
        private void сотрудникиToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            new EmployeesForm(_repository).ShowDialog();
        }

        /// <summary>
        /// Обработка события нажатия пункта меню Заказы
        /// </summary>
        private void отчётыToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            new OrdersForm(_repository).ShowDialog();
        }

        /// <summary>
        /// Обработка события нажатия пункта меню Отчёты - Доход по сотрудникам
        /// </summary>
        private void доходПоСотрудникамToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            var selectdate = new SelectPeriodForm(_repository);
            if (selectdate.ShowDialog() == DialogResult.OK)
            {
                new ReportForm(selectdate.Employee, selectdate.DateTimeFrom, selectdate.DateTimeTo, _repository)
                    .ShowDialog();
            }
        }

        /// <summary>
        /// Обработка события нажатия кнокпи Создать заказ
        /// </summary>
        private void buttonCreateOrder_Click(object sender, System.EventArgs e)
        {
            new AddEditOrderForm(_repository).ShowDialog();
        }

        /// <summary>
        /// Обработка события нажатия кнокпи Блюда
        /// </summary>
        private void buttonDishes_Click(object sender, System.EventArgs e)
        {
            new DishesForm(_repository).ShowDialog();
        }


    }
}
