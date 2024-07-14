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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            CustomizeDesign();
        }

        private void CustomizeDesign()
        {
            panelSubmenuInvoice.Visible = false;
            panelSubmenuQuote.Visible = false;
            panelSubmenuStore.Visible = false;
         

            // customize designing
        }

        private void hideSubMenu()
        {
            if (panelSubmenuInvoice.Visible == true)
                panelSubmenuInvoice.Visible = false;
            if (panelSubmenuQuote.Visible == true)
                panelSubmenuQuote.Visible = false;
            if (panelSubmenuStore.Visible == true)
                panelSubmenuStore.Visible = false;
        

        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new frmdashboard());


            sidepanelmark1.Height = btnDashboard.Height;//Side panel
            sidepanelmark1.Top = btnDashboard.Top;
        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubmenuInvoice);

            sidepanelmark1.Height = btnInvoice.Height;//Side panel
            sidepanelmark1.Top = btnInvoice.Top;
        }

        private void btnAddjob_Click(object sender, EventArgs e)
        {
            sidepanelmark1.Height = btnInvoice.Height;//Side panel
            sidepanelmark1.Top = btnInvoice.Top;
            openChildFormInPanel(new frmAddjob());
            hideSubMenu();
        }

        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            sidepanelmark1.Height = btnInvoice.Height;//Side panel
            sidepanelmark1.Top = btnInvoice.Top;
            //..
            //your codes
            //..
            openChildFormInPanel(new frmviewJob());
            hideSubMenu();
        }

        private void btncreateQuote_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubmenuQuote);


            sidepanelmark1.Height = btnQuota.Height;//Side panel
            sidepanelmark1.Top = btnQuota.Top;

            openChildFormInPanel(new frmCreateQuote());
            hideSubMenu();

        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubmenuStore);

            sidepanelmark1.Height = btnStock.Height;//Side panel
            sidepanelmark1.Top = btnStock.Top;
        }

      

        private void btnAddStock_Click(object sender, EventArgs e)
        {
            sidepanelmark1.Height = btnStock.Height;//Side panel
            sidepanelmark1.Top = btnStock.Top;

            openChildFormInPanel(new createInvoice());
            hideSubMenu();
        }

        private Form activeForm = null;
        private void openChildFormInPanel(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnQuota_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubmenuQuote);


            sidepanelmark1.Height = btnQuota.Height;//Side panel
            sidepanelmark1.Top = btnQuota.Top;
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
           
            
            openChildFormInPanel(new frmdashboard());
        }

        private void btnViewQuotations_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubmenuQuote);


            sidepanelmark1.Height = btnQuota.Height;//Side panel
            sidepanelmark1.Top = btnQuota.Top;

            openChildFormInPanel(new viewQuotation());
            hideSubMenu();
        }

     

        private void btnparts_Click(object sender, EventArgs e)
        {
            sidepanelmark1.Height = btnQuota.Height;//Side panel
            sidepanelmark1.Top = btnQuota.Top;

            openChildFormInPanel(new addPartDetails());
            hideSubMenu();
        }






    
    }
}
