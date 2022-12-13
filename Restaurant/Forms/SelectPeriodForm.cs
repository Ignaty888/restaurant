using System;
using System.Windows.Forms;
using Restaurant.Data;

namespace Restaurant.Forms
{
    public partial class SelectPeriodForm : Form
    {
        public Employee Employee { get; private set; }

        public DateTime DateTimeFrom { get; private set; }

        public DateTime DateTimeTo { get; private set; }

        public SelectPeriodForm(Repository repository)
        {
            InitializeComponent();
            comboBoxEmployees.DataSource = repository.GetEntityes<Employee>();
        }

        /// <summary>
        /// Нажатие кнопки Отмена
        /// </summary>
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Нажатие кнопки Ок
        /// </summary>
        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (comboBoxEmployees.SelectedItem == null)
            {
                MessageBox.Show("Не выбран сотрудник из списка!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dateTimePickerTo.Value<dateTimePickerFrom.Value)
            {
                MessageBox.Show("Конечная дата превышает начальную!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dateTimePickerTo.Value == dateTimePickerFrom.Value)
            {
                MessageBox.Show("Даты совпадают!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Employee=comboBoxEmployees.SelectedItem as Employee;
            DateTimeFrom = dateTimePickerFrom.Value;
            DateTimeTo = dateTimePickerTo.Value;
            DialogResult = DialogResult.OK;
        }

        
    }
}
