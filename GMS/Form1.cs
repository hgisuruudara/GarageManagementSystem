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
    public partial class frmAddjob : Form
    {
        public frmAddjob()
        {
            InitializeComponent();
            lblJobId.Text = getJobId();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\MY APP DEVELOPMENTS\Marks Managemnet System\GMS\GMS\GarageManagementSystem.mdf;Integrated Security=True");
        SqlCommand com;
        SqlDataReader dr;
        DataTable billingDt = new DataTable();
        ReportDataSource rds;
        ReportParameterCollection repParams;



        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmAddjob_Load(object sender, EventArgs e)
        {
            this.dt1.Value = DateTime.Now;
            txtFn.Focus();

            cmbTitle.Text = "Select Title";
            cmbTitle.Items.Add("Mr."); // add item to combo box
            cmbTitle.Items.Add("Mrs."); // add item to combo box
            cmbTitle.Items.Add("Miss."); // add item to combo box
            cmbTitle.Items.Add("Master."); // add item to combo box
            cmbTitle.Items.Add("Rev."); // add item to combo box
            cmbTitle.Items.Add("Dr."); // add item to combo box


            cmbJbTitle.Text = "Select Service Title";
            cmbJbTitle.Items.Add("Full Service"); // add item to combo box
            cmbJbTitle.Items.Add("Free Company Service"); // add item to combo box
            cmbJbTitle.Items.Add("Repair"); // add item to combo box
            cmbJbTitle.Items.Add("Other"); // add item to combo box


            cmbServicetyp.Text = "Select Service Type";
            cmbServicetyp.Items.Add("Paid"); // add item to combo box
            cmbServicetyp.Items.Add("Free"); // add item to combo box





        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (cmbTitle.Text == "Select Title")
            {
                MessageBox.Show("Select the Title First !", "Invalid Action", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txtFn.Text == "")
            {
                MessageBox.Show(" Enter your First Name !", "Invalid Action", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else if (txtLn.Text == "")
            {
                MessageBox.Show(" Enter your Last Name !", "Invalid Action", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else if (txtNic.Text == "")
            {
                MessageBox.Show(" Enter your NIC Number !", "Invalid Action", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else if (txtMobile.Text == "")
            {
                MessageBox.Show(" Enter your Contact Number (Only Numbers) !", "Invalid Action", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else if (txtNo.Text == "")
            {
                MessageBox.Show(" Enter your House Number !", "Invalid Action", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


            else if (txtStreet.Text == "")
            {
                MessageBox.Show(" Enter your Street Name !", "Invalid Action", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else if (txtCity.Text == "")
            {
                MessageBox.Show(" Enter your City Name !", "Invalid Action", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else if (cmbJbTitle.Text == "Select Service Title")
            {
                MessageBox.Show(" Select the Job Title !", "Invalid Action", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else if (txtVehiId.Text == "")
            {
                MessageBox.Show(" Enter your Vehicle ID !", "Invalid Action", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else if (cmbServicetyp.Text == "Select Service Type")
            {
                MessageBox.Show(" Select the Service Type !", "Invalid Action", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                saveJob();
            }
            

        }



        public void resetForm()
        {
            cmbTitle.Text = "Select Title";
            txtFn.Text = "";
            txtLn.Text = "";
            txtNic.Text = "";
            txtMobile.Text = "";
            txtNo.Text = "";
            txtStreet.Text = "";
            txtCity.Text = "";
            cmbJbTitle.Text = "Select Service Title";
            txtVehiId.Clear();
            cmbServicetyp.Text = "Select Service Type";
            txtDescript.Clear();
            txtcharg.Text = "0.00";
            txtSearch.Text = "Enter ID";
            lblJobId.Text = getJobId();
            txtFn.Focus();
        }

        private void txtLand_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private string getJobId()
        {
            string jid = "";

            string query = "SELECT TOP (1) job_id FROM job_details ORDER BY job_id DESC";
            com = new SqlCommand(query, con);
            con.Open();
            dr = com.ExecuteReader();
            if (dr.HasRows == true)
            {
                dr.Read();
                string id = dr["job_id"].ToString(); //Largest Job id in the table eg. JOB00016
                int num = int.Parse(id.Substring(3, 5)) + 1;
                jid = "JOB" + num.ToString().PadLeft(5, '0');
                dr.Close();
            }
            else
            {
                jid = "JOB00001";

            }
            con.Close();
            return jid;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            resetForm();
        }


        private void saveJob()
        {
            try
            {
                checkEmpty();
                con.Open();
                string sql = "INSERT INTO job_details (job_id,cus_title,cus_fn,cus_ln,cus_nic,cus_mob,cus_houseno,cus_street,cus_city,job_title,job_vehid,job_servicetyp,job_descr,job_sercharge,job_date) VALUES ('" + lblJobId.Text + "', '" + cmbTitle.Text + "','" + txtFn.Text + "', '" + txtLn.Text + "','" + txtNic.Text + "', '" + txtMobile.Text + "', '" + txtNo.Text + "', '" + txtStreet.Text + "', '" + txtCity.Text + "', '" + cmbJbTitle.Text + "', '" + txtVehiId.Text + "', '" + cmbServicetyp.Text + "', '" + txtDescript.Text + "', '" + txtcharg.Text + "', '" + dt1.Text + "')";
                com = new SqlCommand(sql, con);
                com.ExecuteNonQuery();

                    ReportParameterCollection repParams = new ReportParameterCollection();

                    reportJobDetails frmp = new reportJobDetails();


                    repParams.Add(new ReportParameter("paramJobId", lblJobId.Text));
                    repParams.Add(new ReportParameter("paramCusTitle", cmbTitle.Text));
                    repParams.Add(new ReportParameter("paramFn", txtFn.Text));
                    repParams.Add(new ReportParameter("paramLn", txtLn.Text));

                    repParams.Add(new ReportParameter("paramnic", txtNic.Text));
                    repParams.Add(new ReportParameter("paramMob", txtMobile.Text));
                    repParams.Add(new ReportParameter("paramNo", txtNo.Text));
                    repParams.Add(new ReportParameter("paramStreet", txtStreet.Text));
                    repParams.Add(new ReportParameter("paramCity", txtCity.Text));
                    repParams.Add(new ReportParameter("paramJobTitle", cmbJbTitle.Text));

                    repParams.Add(new ReportParameter("paramVehiNo", txtVehiId.Text));
                    repParams.Add(new ReportParameter("paramServTyp", cmbServicetyp.Text));
                    repParams.Add(new ReportParameter("paramDescr", txtDescript.Text));
                    repParams.Add(new ReportParameter("paramCharge", txtcharg.Text));

                    frmp.reportViewer1.LocalReport.SetParameters(repParams);
                    frmp.reportViewer1.RefreshReport();
                    MessageBox.Show("Job Details : " + lblJobId.Text + " Successfully inserted", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    con.Close();
                    frmp.ShowDialog();
                    resetForm();
                   
                    
                }

             
            catch (Exception)
            {
                MessageBox.Show("TRY AGAIN WITH VALID INPUTS","",MessageBoxButtons.OK,MessageBoxIcon.Information);
                con.Close();
            }
            finally
            {
                
                lblJobId.Text = getJobId();

            }
            
        }




        private void checkEmpty()
        {
            if (cmbTitle.Text== "Select Title")
            {
                MessageBox.Show("Select the Title First !", "Invalid Action", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cmbTitle.Focus();
            }
            else if (txtFn.Text == "")
            {
                MessageBox.Show(" Enter your First Name !", "Invalid Action", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                txtFn.Focus();
            }

            else if (txtLn.Text == "")
            {
                MessageBox.Show(" Enter your Last Name !", "Invalid Action", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtLn.Focus();
            }

            else if (txtNic.Text == "")
            {
                MessageBox.Show(" Enter your NIC Number !", "Invalid Action", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNic.Focus();
            }

            else if (txtMobile.Text == "")
            {
                MessageBox.Show(" Enter your Contact Number (Only Numbers) !", "Invalid Action", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtMobile.Focus();
            }

            else if (txtNo.Text == "")
            {
                MessageBox.Show(" Enter your House Number !", "Invalid Action", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNo.Focus();
            }


            else if (txtStreet.Text == "")
            {
                MessageBox.Show(" Enter your Street Name !", "Invalid Action", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtStreet.Focus();
            }

            else if (txtCity.Text == "")
            {
                MessageBox.Show(" Enter your City Name !", "Invalid Action", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCity.Focus();
            }

            else if (cmbJbTitle.Text == "Select Service Title")
            {
                MessageBox.Show(" Select the Job Title !", "Invalid Action", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cmbJbTitle.Focus();
            }

            else if (txtVehiId.Text == "")
            {
                MessageBox.Show(" Enter your Vehicle ID !", "Invalid Action", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtVehiId.Focus();
            }

            else if (cmbServicetyp.Text == "Select Service Type")
            {
                MessageBox.Show(" Select the Service Type !", "Invalid Action", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cmbServicetyp.Focus();
            }

        }

         private void searchJob()
        {
            try
            {
                con.Open();
                string sql = "SELECT * FROM job_details WHERE job_id= '" + txtSearch.Text + "' ";
                com = new SqlCommand(sql, con);

                SqlDataReader dr = com.ExecuteReader();

                if (dr.Read())
                {
                    lblJobId.Text = dr["job_id"].ToString();
                    cmbTitle.Text = dr["cus_title"].ToString();
                    txtFn.Text = dr["cus_fn"].ToString();
                    txtLn.Text = dr["cus_ln"].ToString();
                    txtNic.Text = dr["cus_nic"].ToString();
                    txtMobile.Text = dr["cus_mob"].ToString();
                    txtNo.Text = dr["cus_houseno"].ToString();
                    txtStreet.Text = dr["cus_street"].ToString();
                    txtCity.Text = dr["cus_city"].ToString();
                    cmbJbTitle.Text = dr["job_title"].ToString();
                    txtVehiId.Text = dr["job_vehid"].ToString();
                    cmbServicetyp.Text = dr["job_servicetyp"].ToString();
                    txtDescript.Text = dr["job_descr"].ToString();
                    txtcharg.Text = dr["job_sercharge"].ToString();
                   
                    txtSearch.Text = "Enter Job ID";
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Job Not Found");
                    con.Close();
                    txtSearch.Text = "Enter Job ID";
                    lblJobId.Text = getJobId();
                    
                }

            }
            catch (Exception)
            {
                MessageBox.Show(" Search Again with Valid Data !", "Invalid Search", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                con.Close();
                lblJobId.Text = getJobId();
            }
            finally
            {

                con.Close();
                
            }




        }

         private void txtSearch_Click(object sender, EventArgs e)
         {
             txtSearch.Text = "";
             

         }

         private void btnSearch_Click(object sender, EventArgs e)
         {
             searchJob();
             btnUpdate.Enabled = true;
             btnDelete.Enabled = true;
         }


         private void updateJob()
         {
             try
             {
                 con.Open();
                 // UPDATE Query
                 string sql = "UPDATE job_details SET cus_title = '" + cmbTitle.Text + "',cus_fn = '" + txtFn.Text + "',cus_ln = '" + txtLn.Text + "',cus_nic = '" + txtNic.Text + "',cus_mob = '" + txtMobile.Text + "',cus_houseno = '" + txtNo.Text + "',cus_street = '" + txtStreet.Text + "',cus_city = '" + txtCity.Text + "',job_title = '" + cmbJbTitle.Text + "',job_vehid = '" + txtVehiId.Text + "'   ,job_servicetyp = '" + cmbServicetyp.Text + "',job_descr = '" + txtDescript.Text + "',job_sercharge = '" + txtcharg.Text + "',job_date = '" + dt1.Text + "' WHERE job_id= '" + lblJobId.Text + "'";
                 SqlCommand com = new SqlCommand(sql, con);
                 com.ExecuteNonQuery();

                 MessageBox.Show("Record Updated Sucessfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                             


             }
             catch (Exception)
             {
                 MessageBox.Show("Invalid Try", "Info", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                 con.Close();
                 lblJobId.Text = getJobId();
             }
             finally
             {
                 con.Close();
                 resetForm();
                 lblJobId.Text = getJobId();     
             }
         }

         private void btnUpdate_Click(object sender, EventArgs e)
         {
             updateJob();
         }

         private void deleteJob()
         {
             try
            {
                con.Open();
                string sql = "DELETE FROM job_details WHERE job_id = '" + lblJobId.Text + "'";
                com = new SqlCommand(sql ,con);
                com.ExecuteNonQuery();

                MessageBox.Show("Job Deleted Sucessfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Try", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
                resetForm();
            }
             finally
             {
                 con.Close();
                 resetForm();
                 lblJobId.Text = getJobId();  
             }
         }

         private void btnDelete_Click(object sender, EventArgs e)
         {

         }


    }      

}
