using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;

namespace GMS
{
    public partial class viewQuotation : Form
    {
        public viewQuotation()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\MY APP DEVELOPMENTS\Marks Managemnet System\GMS\GMS\GarageManagementSystem.mdf;Integrated Security=True");
        SqlCommand com;
        SqlDataReader dr;
        DataTable billingDt = new DataTable();
        ReportDataSource rds;
        ReportParameterCollection repParams;

        private void txtSearchdetails_OnValueChanged(object sender, EventArgs e)
        {
            con.Open();
            string sql = "SELECT * FROM quote_Details WHERE  quoteID  like '%" + txtSearchdetails.Text + "%' OR CustName like '%" + txtSearchdetails.Text + "%'OR CustNic like '%" + txtSearchdetails.Text + "%'";
            com = new SqlCommand(sql, con);
            DataTable dt = new DataTable();
            SqlDataAdapter ada = new SqlDataAdapter(com);
            ada.Fill(dt);
            bunViewQuoteDetails.DataSource = dt;
            con.Close();
        }

        private void viewQuotation_Load(object sender, EventArgs e)
        {
            con.Open();
            string sql = "SELECT * FROM quote_Details";
            com = new SqlCommand(sql, con);
            DataTable dt = new DataTable();
            SqlDataAdapter ada = new SqlDataAdapter(com);
            ada.Fill(dt);
            bunViewQuoteDetails.DataSource = dt;
            con.Close();
        }
    }
}
