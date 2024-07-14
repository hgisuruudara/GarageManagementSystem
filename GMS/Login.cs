using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GMS
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
        
            String us, pass;

            us =( "Chaminda");
            pass =("Chaminda@123");

            if ((txtun.Text == us && txtpw.Text == pass))
            {
                MessageBox.Show("Sucessfully Logged In");
                Loading s = new Loading();
                s.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect Username or Password");
                txtun.Focus();
                txtpw.Clear();
                txtun.Clear();

            } 
        }




   

        private void checkboxpw_CheckedChanged(object sender, EventArgs e)
        {
            if (checkboxpw.Checked == true)
            {
                txtpw.UseSystemPasswordChar = true;
            }
            else
            {
                
                txtpw.UseSystemPasswordChar = false;
            }
        }
        

     
    }
}
