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
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
        }

        private void Loading_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void ploading_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                pictureBox1.Width += 1;
                if (pictureBox1.Width >= 615)
                {
                    timer1.Stop();

                    MainMenu f = new MainMenu();
                    f.Show();
                    this.Hide();
                    timer1.Enabled = false;
                }
            }
            catch (Exception)
            {
                return;
            }
        }
    }
}
