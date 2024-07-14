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
    public partial class ReportQuotation : Form
    {
        public ReportQuotation()
        {
            InitializeComponent();
        }

        private void ReportQuotation_Load(object sender, EventArgs e)
        {

            this.reportViewer2.RefreshReport();
        }
    }
}
