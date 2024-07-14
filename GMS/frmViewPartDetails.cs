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
    public partial class frmViewPartDetails : Form
    {
        public frmViewPartDetails()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\MY APP DEVELOPMENTS\Marks Managemnet System\GMS\GMS\GarageManagementSystem.mdf;Integrated Security=True");
        SqlCommand com;
        SqlDataReader dr;
        DataTable billingDt = new DataTable();

        private void frmViewPartDetails_Load(object sender, EventArgs e)
        {
            cmbCatTyp.Text = "Select Category";
            cmbCatTyp.Items.Add("Burgmen"); // add item to combo box
            cmbCatTyp.Items.Add("Access"); // add item to combo box
            cmbCatTyp.Items.Add("Gixxer"); // add item to combo box
            cmbCatTyp.Items.Add("GL150"); // add item to combo box
            cmbCatTyp.Items.Add("GN125H"); // add item to combo box
            cmbCatTyp.Items.Add("Lets"); // add item to combo box
            cmbCatTyp.Items.Add("UP 125"); // add item to combo box


            con.Open();
            string sql = "SELECT * FROM quot_parts";
            com = new SqlCommand(sql, con);
            DataTable dt = new DataTable();
            SqlDataAdapter ada = new SqlDataAdapter(com);
            ada.Fill(dt);
            bunViewPartDetails.DataSource = dt;
            con.Close();
        }

        private void txtSearchdetails_OnValueChanged(object sender, EventArgs e)
        {
            con.Open();
            string sql = "SELECT ProductID,ItemCode,part_descri,PartName,UnitPrice,tax FROM quot_parts WHERE  ItemCode  like '%" + txtSearchdetails.Text + "%' OR part_descri like '%" + txtSearchdetails.Text + "%'OR PartName like '%" + txtSearchdetails.Text + "%'";
            com = new SqlCommand(sql, con);
            DataTable dt = new DataTable();
            SqlDataAdapter ada = new SqlDataAdapter(com);
            ada.Fill(dt);
            bunViewPartDetails.DataSource = dt;
            con.Close();
        }

        private void cmbCatTyp_SelectedIndexChanged(object sender, EventArgs e)
        {
    

           if (cmbCatTyp.Text == "Select Category")
            {
                con.Open();
                string sql = "SELECT * FROM quot_parts";
                com = new SqlCommand(sql, con);
                DataTable dt = new DataTable();
                SqlDataAdapter ada = new SqlDataAdapter(com);
                ada.Fill(dt);
                bunViewPartDetails.DataSource = dt;
                con.Close();
            }
           else if (cmbCatTyp.Text == "Burgmen")
           {
               con.Open();
               string sql = "SELECT * FROM quot_parts WHERE part_descri ='Burgmen' ";
               com = new SqlCommand(sql, con);
               DataTable dt = new DataTable();
               SqlDataAdapter ada = new SqlDataAdapter(com);
               ada.Fill(dt);
               bunViewPartDetails.DataSource = dt;
               con.Close();
           }

           else if (cmbCatTyp.Text == "Access")
           {
               con.Open();
               string sql = "SELECT * FROM quot_parts WHERE part_descri ='Access'";
               com = new SqlCommand(sql, con);
               DataTable dt = new DataTable();
               SqlDataAdapter ada = new SqlDataAdapter(com);
               ada.Fill(dt);
               bunViewPartDetails.DataSource = dt;
               con.Close();
           }
           else if (cmbCatTyp.Text == "Gixxer")
           {
               con.Open();
               string sql = "SELECT * FROM quot_parts WHERE part_descri ='Gixxer'";
               com = new SqlCommand(sql, con);
               DataTable dt = new DataTable();
               SqlDataAdapter ada = new SqlDataAdapter(com);
               ada.Fill(dt);
               bunViewPartDetails.DataSource = dt;
               con.Close();
           }

           else if (cmbCatTyp.Text == "GL150")
           {
               con.Open();
               string sql = "SELECT * FROM quot_parts WHERE part_descri ='GL150'";
               com = new SqlCommand(sql, con);
               DataTable dt = new DataTable();
               SqlDataAdapter ada = new SqlDataAdapter(com);
               ada.Fill(dt);
               bunViewPartDetails.DataSource = dt;
               con.Close();
           }
           else if (cmbCatTyp.Text == "GN125H")
           {
               con.Open();
               string sql = "SELECT * FROM quot_parts WHERE part_descri = 'GN125H'";
               com = new SqlCommand(sql, con);
               DataTable dt = new DataTable();
               SqlDataAdapter ada = new SqlDataAdapter(com);
               ada.Fill(dt);
               bunViewPartDetails.DataSource = dt;
               con.Close();
           }
           else if (cmbCatTyp.Text == "Lets")
           {
               con.Open();
               string sql = "SELECT * FROM quot_parts WHERE part_descri = 'Lets' ";
               com = new SqlCommand(sql, con);
               DataTable dt = new DataTable();
               SqlDataAdapter ada = new SqlDataAdapter(com);
               ada.Fill(dt);
               bunViewPartDetails.DataSource = dt;
               con.Close();

           }
           else if (cmbCatTyp.Text == "UP 125")
           {
               con.Open();
               string sql = "SELECT * FROM quot_parts WHERE part_descri = 'UP 125 '";
               com = new SqlCommand(sql, con);
               DataTable dt = new DataTable();
               SqlDataAdapter ada = new SqlDataAdapter(com);
               ada.Fill(dt);
               bunViewPartDetails.DataSource = dt;
               con.Close();
           }
        }
    }
}
