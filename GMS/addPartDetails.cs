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
    public partial class addPartDetails : Form
    {
        public addPartDetails()
        {
            InitializeComponent();
            lblPartId.Text= getPartId();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\MY APP DEVELOPMENTS\Marks Managemnet System\GMS\GMS\GarageManagementSystem.mdf;Integrated Security=True");
        SqlCommand com;
        SqlDataReader dr;

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
        }

         
        private string getPartId()
        {
            string pid = "";

            string query = "SELECT TOP (1) ProductID FROM quot_parts ORDER BY ProductID DESC";
            com = new SqlCommand(query, con);
            con.Open();
            dr = com.ExecuteReader();
            if (dr.HasRows == true)
            {
                dr.Read();
                string id = dr["ProductID"].ToString(); //Largest Job id in the table eg. JOB00016
                int num = int.Parse(id.Substring(3, 6)) + 1;
                pid = "PAR" + num.ToString().PadLeft(6, '0');
                dr.Close();
            }
            else
            {
                pid = "PAR000001";

            }
            con.Close();
            return pid;

        }
        private void checkEmpty()
        {
            if (txtItemCode.Text == "")
            {
                MessageBox.Show("Enter Item Code !", "Invalid Action", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtItemCode.Focus();
            }
            else if ( txtPartName.Text == "")
            {
                MessageBox.Show(" Enter Part Name !", "Invalid Action", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                txtPartName.Focus();
            }

            else if (cmbCatTyp.Text == "Select Category Type")
            {
                MessageBox.Show(" Enter your Last Name !", "Invalid Action", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cmbCatTyp.Focus();
            }

            else if ( txtUnitPrice.Text == "")
            {
                MessageBox.Show(" Enter Unit Price !", "Invalid Action", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtUnitPrice.Focus();
            }

            else if ( txtTax.Text == "")
            {
                MessageBox.Show(" Enter Tax Amount (Only Numbers) !", "Invalid Action", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtTax.Focus();
            }

        }

            

        
        private void button3_Click(object sender, EventArgs e)
        {
           try{
               checkEmpty();
              con.Open();
              string sql = "INSERT INTO quot_parts (ProductID,ItemCode,PartName,part_descri,UnitPrice,tax) VALUES ('" + lblPartId.Text + "', '" + txtItemCode.Text + "', '" + txtPartName.Text + "', '" + cmbCatTyp.Text + "', '" + txtUnitPrice.Text + "', '" + txtTax.Text + "')";
                com = new SqlCommand(sql, con);
                com.ExecuteNonQuery();
                MessageBox.Show(" Part Added Sucessfully !", "Part Added", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtItemCode.Text = "";
                txtPartName.Text = "";
                cmbCatTyp.Text = "Select Category Type";
                txtUnitPrice.Text = "";
                txtTax.Text = "";
           
            }
            catch (Exception)
            {
                MessageBox.Show(" Input Valid Data !", "Invalid Search", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                con.Close();
                lblPartId.Text = getPartId();
                
            }
            finally
            {

                con.Close();
                lblPartId.Text = getPartId();

            }
          

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtItemCode.Text = "";
            txtPartName.Text = "";
            cmbCatTyp.Text = "Select Category Type";
            txtUnitPrice.Text = "";
            txtTax.Text = "";
        }

        private void addPartDetails_Load(object sender, EventArgs e)
        {
            cmbCatTyp.Text = "Select Category";
            cmbCatTyp.Items.Add("Burgmen"); // add item to combo box
            cmbCatTyp.Items.Add("Access"); // add item to combo box
            cmbCatTyp.Items.Add("Gixxer"); // add item to combo box
            cmbCatTyp.Items.Add("GL150"); // add item to combo box
            cmbCatTyp.Items.Add("GN125H"); // add item to combo box
            cmbCatTyp.Items.Add("Lets"); // add item to combo box
            cmbCatTyp.Items.Add("UP 125"); // add item to combo box
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
                con.Open();
                string sql = "SELECT ProductID,ItemCode,PartName,part_descri,UnitPrice,tax FROM quot_parts WHERE  ItemCode  like '%" + txtSearch.Text + "%' OR part_descri like '%" + txtSearch.Text + "%'OR PartName like '%" + txtSearch.Text + "%'";
                com = new SqlCommand(sql, con);

                SqlDataReader dr = com.ExecuteReader();

                if (dr.Read())
                {
                    lblPartId.Text = dr["ProductID"].ToString();
                    txtItemCode.Text = dr["ItemCode"].ToString();
                    txtPartName.Text = dr["PartName"].ToString();
                    cmbCatTyp.Text = dr["part_descri"].ToString();
                    txtUnitPrice.Text = dr["UnitPrice"].ToString();
                    txtTax.Text = dr["tax"].ToString();


                    txtSearch.Text = "Enter Item Code/ Name";
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Part Not Found");
                    con.Close();
                    txtSearch.Text = "Enter Item Code/ Name";
                    lblPartId.Text = getPartId();
                    

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(" Search Again with Valid Data !", "Invalid Search", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                con.Close();
                lblPartId.Text = getPartId();
                
            }
            finally
            {

                con.Close();

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string sql = "DELETE FROM quot_parts WHERE ProductID= '" + lblPartId.Text+ "' ";

                com = new SqlCommand(sql, con);
                com.ExecuteNonQuery();

   


            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Try", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
                
            }
            finally
            {
                con.Close();
                MessageBox.Show("Job Deleted Sucessfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblPartId.Text = getPartId();
                txtItemCode.Text = "";
                txtPartName.Text = "";
                cmbCatTyp.Text = "Select Category Type";
                txtUnitPrice.Text = "";
                txtTax.Text = "";
               
            }
        }

        private void btnViewParts_Click(object sender, EventArgs e)
        {
            frmViewPartDetails frm = new frmViewPartDetails();
            frm.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                // UPDATE Query
                string sql = "UPDATE quot_parts SET ItemCode = '" + txtItemCode.Text + "',PartName = '" + txtPartName.Text + "',part_descri = '" + cmbCatTyp.Text + "',UnitPrice = '" + txtUnitPrice.Text + "',tax = '" + txtTax.Text + "' WHERE  ProductID= '" + lblPartId.Text + "'";
              
                SqlCommand com = new SqlCommand(sql, con);
                com.ExecuteNonQuery();

                MessageBox.Show("Record Updated Sucessfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);



            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Try", "Info", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                con.Close();
                lblPartId.Text = getPartId();
            }
            finally
            {
                con.Close();
                lblPartId.Text = getPartId();
                txtItemCode.Text = "";
                txtPartName.Text = "";
                cmbCatTyp.Text = "Select Category Type";
                txtUnitPrice.Text = "";
                txtTax.Text = "";
                lblPartId.Text = getPartId();
            }
        }
    }
}
