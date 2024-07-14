using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GMS
{
    public partial class frmdashboard : Form
    {
        public frmdashboard()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\MY APP DEVELOPMENTS\Marks Managemnet System\GMS\GMS\GarageManagementSystem.mdf;Integrated Security=True");
        SqlCommand com;
        SqlCommand com1;
        SqlCommand com2;

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblhrs.Text = DateTime.Now.ToString("HH:mm:ss");
            lbldate.Text = DateTime.Now.ToString("MMM dd yyyy,");
            lblday.Text = DateTime.Now.ToString("dddd");
        }

        private void frmdashboard_Load(object sender, EventArgs e)
        {
            timer1.Start();

            try
            {

                con.Open();
                string sql = "SELECT COUNT (job_id) FROM job_details";
               

                com = new SqlCommand(sql, con);
               
              

                //read from db
                Int32 rows_count = Convert.ToInt32(com.ExecuteScalar());
                com.Dispose();

              



                con.Close();

                // display data on the page

                lblJobsNo.ForeColor = Color.White;
                lblJobsNo.Text = rows_count.ToString();

               

            
                
    
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


    }
}
