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
    public partial class reportJobDetails : Form
    {
        public reportJobDetails()
        {
            InitializeComponent();
        }

        private void reportJobDetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'GarageManagementSystemDataSet.job_details' table. You can move, or remove it, as needed.
            this.job_detailsTableAdapter.Fill(this.GarageManagementSystemDataSet.job_details);

            this.reportViewer1.RefreshReport();
        }
    }
}
