using BussinessLogicLayer_BLL;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PresentationLayer
{
    public partial class FormPrint : Form
    {
        SaleManagement mngSale = new SaleManagement();
        DataSet ds;
        BindingSource bs;
        public FormPrint()
        {
            InitializeComponent();
        }

        private void FormPrint_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DsSale.Vw_detail' table. You can move, or remove it, as needed.
            //this.Vw_detailTableAdapter.Fill(this.DsSale.Vw_detail);

            //this.reportViewer1.RefreshReport();

            ds = mngSale.ViewInvoice();
            bs = new BindingSource();
            bs.DataSource = ds.Tables[0];
            comboBox1.DisplayMember = "ID";
            comboBox1.ValueMember = "ID";
            comboBox1.DataSource = bs;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int invoiceId = (int)comboBox1.SelectedValue;
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Vw_detail where invoice_id='" + invoiceId + "'",
                "server=AN\\ANTRAN;user id=sa;password=1;database=BookStore");
            DataSet ds = new DataSet();
            adapter.Fill(ds);


            LocalReport localreport = reportViewer1.LocalReport;
            localreport.DataSources.Clear();
            ReportDataSource reportDatasource = new ReportDataSource();
            reportDatasource.Value = ds.Tables[0];
            reportDatasource.Name = "DataSet1";
            localreport.DataSources.Add(reportDatasource);

            reportViewer1.RefreshReport();
        }
    }
}
