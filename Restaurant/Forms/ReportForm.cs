using System;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using Restaurant.Data;

namespace Restaurant.Forms
{
    public partial class ReportForm : Form
    {
        private Repository _repository;
        private Employee _employee;
        private DateTime _dateFrom;
        private DateTime _dateTo;

        public ReportForm(Employee employee, DateTime dateFrom, DateTime dateTo, Repository repository)
        {
            _employee = employee;
            _dateFrom = dateFrom;
            _dateTo = dateTo;
            _repository = repository;
            InitializeComponent();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            var reportDataSource = new ReportDataSource
            {
                Name = "OrderDataSet",
                Value = _repository.GetEntityes<Order>(order => order.Date >= _dateFrom && order.Date <= _dateTo&&order.ID_Employee==_employee.ID_Employee)
            };
            reportViewer.LocalReport.ReportEmbeddedResource = "Restaurant.Forms.Reports.ProceedsReport.rdlc";
            reportViewer.LocalReport.DataSources.Add(reportDataSource);
            reportViewer.RefreshReport();
        }
    }
}
