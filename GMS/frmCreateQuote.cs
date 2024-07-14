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
    public partial class frmCreateQuote : Form
    {
        public frmCreateQuote()
        {
            InitializeComponent();
            lblQuoteId.Text = getQuoteId();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\MY APP DEVELOPMENTS\Marks Managemnet System\GMS\GMS\GarageManagementSystem.mdf;Integrated Security=True");
        SqlCommand com;
        SqlDataReader dr;
        DataTable billingDt = new DataTable();
        ReportDataSource rds;
        ReportParameterCollection repParams;

        private void bunifu2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnViewPartsDetails_Click(object sender, EventArgs e)
        {
            frmViewPartDetails frm = new frmViewPartDetails();
            frm.Show();
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
        }

        private void searchPart()
        {
            try
            {
                con.Open();
                string sql = "SELECT ItemCode,part_descri,PartName,UnitPrice,tax FROM quot_parts WHERE  ItemCode  like '%" + txtSearch.Text + "%' OR part_descri like '%" + txtSearch.Text + "%'OR PartName like '%" + txtSearch.Text + "%'";
                com = new SqlCommand(sql, con);

                SqlDataReader dr = com.ExecuteReader();

                if (dr.Read())
                {

                    txtCatNa.Text = dr["part_descri"].ToString();
                    txtPrtNa.Text = dr["PartName"].ToString();
                    txtItemCode.Text = dr["ItemCode"].ToString();
                    txtPrice.Text = dr["UnitPrice"].ToString();

                    txtSearch.Text = "Enter Item Code/Part Name";
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Part Not Found", "Invalid Search", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    con.Close();
                    txtSearch.Text = "Enter Item Code/Part Name";

                }

            }
            catch (Exception)
            {
                MessageBox.Show(" Search Again with Valid Part Details !", "Invalid Search", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                con.Close();
                
            }
            finally
            {

                con.Close();

            }




        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            searchPart();
        }

        private void frmCreateQuote_Load(object sender, EventArgs e)
        {
            this.dt1.Value = DateTime.Now;
            lblQuoteId.Text = getQuoteId();
            txtCustNa.Focus();

            cmbTitle.Text = "Select Title";
            cmbTitle.Items.Add("Mr."); // add item to combo box
            cmbTitle.Items.Add("Mrs."); // add item to combo box
            cmbTitle.Items.Add("Miss."); // add item to combo box
            cmbTitle.Items.Add("Master."); // add item to combo box
            cmbTitle.Items.Add("Rev."); // add item to combo box
            cmbTitle.Items.Add("Dr."); // add item to combo box


            cmbCat.Text = "Select Category";
            cmbCat.Items.Add("Burgemn"); // add item to combo box
            cmbCat.Items.Add("Access"); // add item to combo box
            cmbCat.Items.Add("Gixxer"); // add item to combo box
            cmbCat.Items.Add("GL150"); // add item to combo box
            cmbCat.Items.Add("GN125H"); // add item to combo box
            cmbCat.Items.Add("Lets"); // add item to combo box
            cmbCat.Items.Add("UP 125"); // add item to combo box

            billingDt.Columns.Add("Category");
            billingDt.Columns.Add("Part Name");
            billingDt.Columns.Add("Item Code");
            billingDt.Columns.Add("Unit Price");
            billingDt.Columns.Add("Quantity");
            billingDt.Columns.Add("Line Total");


           
        }

        private string getQuoteId()
            
        {
            string qid = "";

            string query = "SELECT TOP (1) quoteID FROM quote_Details ORDER BY quoteID DESC";
            com = new SqlCommand(query, con);
            con.Open();
            dr = com.ExecuteReader();
            if (dr.HasRows == true)
            {
                dr.Read();
                string id = dr["quoteID"].ToString(); //Largest Quote id in the table eg. QUO00016
                int num = int.Parse(id.Substring(3, 5)) + 1;
                qid = "QUO" + num.ToString().PadLeft(5, '0');
                dr.Close();
            }
            else
            {
                qid = "QUO00001";

            }
            con.Close();
            return qid;

        }

        private void btnaddbill_Click(object sender, EventArgs e)
        {


            string catName = txtCatNa.Text;
            string partName = txtPrtNa.Text;
            string itemCode = txtItemCode.Text;
            decimal itemprice = decimal.Parse(txtPrice.Text);
            decimal qty = decimal.Parse(txtQntyUnit.Text);
            decimal linetot = itemprice * qty;

            // display Total in textbox

            //get the total valu from textbox
            decimal grossTotal = decimal.Parse(txtGrossTotal.Text);
            grossTotal = linetot + grossTotal;

            if (catName == "")
            {
                MessageBox.Show("Select the Products First. Try Again ","Alert",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else if (partName == "")
            {
                MessageBox.Show("Select the Products First. Try Again ","Alert",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else if (itemCode == "")
            {
                MessageBox.Show("Select the Products First. Try Again ","Alert",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else if (txtPrice.Text == "0.00")
            {
                MessageBox.Show("Select the Products First. Try Again ","Alert",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

            else if (txtQntyUnit.Text == "0")
            {
                MessageBox.Show("Select the Products First. Try Again ","Alert",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

           
                else
                {
                    con.Open();


                    billingDt.Rows.Add(catName, partName, itemCode, itemprice, qty, linetot);


                    dvgBilledItems.DataSource = billingDt;

                    //display the total in textbox
                    txtGrossTotal.Text = grossTotal.ToString();
                    TxtNetTotal.Text = grossTotal.ToString();
                    txtCatNa.Text = "";
                    txtPrtNa.Text = "";
                    txtItemCode.Text = "";
                    txtPrice.Text = "0.00";
                    txtQntyUnit.Text = "0";
                   

                    con.Close();
                 

                                        
                }
        }

        private void dvgBilledItems_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

             /* if(e.RowIndex>=0)
              {
                  DataGridViewRow row = this.dvgBilledItems.Rows[e.RowIndex];

                  txtCatNa.Text = row.Cells["Category"].Value.ToString();
                  txtPrtNa.Text = row.Cells["Part Name"].Value.ToString();
                  txtItemCode.Text = row.Cells["Item Code"].Value.ToString();
                  txtPrice.Text = row.Cells["Unit Price"].Value.ToString();
                  txtQntyUnit.Text = row.Cells["Quantity"].Value.ToString();
                  txtlinetot.Text = row.Cells["Line Total"].Value.ToString();
              
              }*/

            if (dvgBilledItems.SelectedRows.Count > 0) // make sure user select at least 1 row 
            {
                string catna = dvgBilledItems.SelectedRows[0].Cells[0].Value + string.Empty;
                string partna = dvgBilledItems.SelectedRows[0].Cells[1].Value + string.Empty;

                string itemcode = dvgBilledItems.SelectedRows[0].Cells[2].Value + string.Empty;
                string price = dvgBilledItems.SelectedRows[0].Cells[3].Value + string.Empty;

                string qty = dvgBilledItems.SelectedRows[0].Cells[4].Value + string.Empty;


                txtCatNa.Text = catna;
                txtPrtNa.Text = partna;
                txtItemCode.Text = itemcode;
                txtPrice.Text = price;
                txtQntyUnit.Text = qty;

                dvgBilledItems.Rows.RemoveAt(this.dvgBilledItems.SelectedRows[0].Index);
                

            }

            
        }

        private void txtRepairChg_TextChanged(object sender, EventArgs e)
        {
            decimal grossTotal = decimal.Parse(txtGrossTotal.Text);
            decimal Rechg = decimal.Parse(txtRepairChg.Text);

            // Caluculate the Final Total

            decimal netTotal = grossTotal + Rechg;

            //display the final tota in text box

            TxtNetTotal.Text = netTotal.ToString();
        }


        private void checkEmpty()
        {
            if (cmbTitle.Text == "Select Title")
            {
                MessageBox.Show("Select the Title First !", "Invalid Action", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cmbTitle.Focus();
            }
            else if (txtCustNa.Text == "")
            {
                MessageBox.Show(" Enter Cusomer Name !", "Invalid Action", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                txtCustNa.Focus();
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

        }


        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            if (cmbTitle.Text == "Select Title")
            {
                MessageBox.Show("Select the Title First !", "Invalid Action", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cmbTitle.Focus();
            }
            else if (txtCustNa.Text == "")
            {
                MessageBox.Show(" Enter Cusomer Name !", "Invalid Action", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                txtCustNa.Focus();
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
            else
            {
                saveJob();
            }
            
        }

        private void resetForm()
        {
            cmbTitle.Text = "Select Title";
            txtCustNa.Text = "";
            txtNic.Text = "";
            txtMobile.Text = "";
            txtNo.Text = "";
            txtStreet.Text = "";
            txtCity.Text = "";
            cmbCat.Text = "Select Category";
            txtCatNa.Text = "";
            txtPrtNa.Text = "";
            txtItemCode.Text = "";
            txtPrice.Text = "0.00";
            txtQntyUnit.Text = "0";
            txtGrossTotal.Text="0.00";
            txtRepairChg.Text="0.00";
            TxtNetTotal.Text = "0.00";
            dvgBilledItems.DataSource = null;
            dvgBilledItems.Rows.Clear();
            dvgBilledItems.Refresh();
            lblQuoteId.Text = getQuoteId();
        }

        private void saveJob()
        {
            try
            {
                checkEmpty();
                con.Open();
                string sql = "INSERT INTO quote_Details (quoteID,Quotedatetime,CategoryName,GrossTotal,Discount,NetTotal,Tax,CustTitle,CustName,CustNic,CustMob,CustNo,CustStreet,CustCity,Operator) VALUES ('" + lblQuoteId.Text + "','" + DateTime.Now + "' , '" + cmbCat.Text + "','" + txtGrossTotal.Text + "', '" + "0.00" + "','" + TxtNetTotal.Text + "','" + "0.00" + "','" + cmbTitle.Text + "','" + txtCustNa.Text + "','" + txtNic.Text + "', '" + txtMobile.Text + "', '" + txtNo.Text + "', '" + txtStreet.Text + "', '" + txtCity.Text + "', '" + "Mr.Chaminda" + "')";
                com = new SqlCommand(sql, con);
                com.ExecuteNonQuery();

                rds = new ReportDataSource();
                repParams = new ReportParameterCollection();
                List<BillDetails> lst = new List<BillDetails>();

                for (int i = 0; i < dvgBilledItems.Rows.Count; i++)
                {
                    BillDetails obj = new BillDetails();
                    obj.Item_code = dvgBilledItems.Rows[i].Cells[1].Value.ToString();
                    obj.Component_name = dvgBilledItems.Rows[i].Cells[2].Value.ToString();
                    obj.Unit_price = float.Parse(dvgBilledItems.Rows[i].Cells[3].Value.ToString());
                    obj.Pro_qty = int.Parse(dvgBilledItems.Rows[i].Cells[4].Value.ToString());
                    obj.Pro_grtotal = float.Parse(dvgBilledItems.Rows[i].Cells[5].Value.ToString());
                    lst.Add(obj);
                }

                rds.Name = "DataSet1";
                rds.Value = lst;
                ReportQuotation frmp = new ReportQuotation();
                repParams.Add(new ReportParameter("ParmQuoteID", lblQuoteId.Text));
                repParams.Add(new ReportParameter("paramCusTitle", cmbTitle.Text));
                repParams.Add(new ReportParameter("paramCustName", txtCustNa.Text));


                repParams.Add(new ReportParameter("paramnic", txtNic.Text));
                repParams.Add(new ReportParameter("paramMob", txtMobile.Text));
                repParams.Add(new ReportParameter("paramNo", txtNo.Text));
                repParams.Add(new ReportParameter("paramStreet", txtStreet.Text));
                repParams.Add(new ReportParameter("paramCity", txtCity.Text));
                repParams.Add(new ReportParameter("paramGross", txtGrossTotal.Text));

                repParams.Add(new ReportParameter("paramRepair", txtRepairChg.Text));
                repParams.Add(new ReportParameter("paramNetTotal", TxtNetTotal.Text));

                frmp.reportViewer2.LocalReport.SetParameters(repParams);
                frmp.reportViewer2.LocalReport.DataSources.Clear();
                frmp.reportViewer2.LocalReport.DataSources.Add(rds);
                frmp.reportViewer2.LocalReport.ReportEmbeddedResource = "GMS.createQuoteReport.rdlc";



                frmp.reportViewer2.LocalReport.SetParameters(repParams);
                frmp.reportViewer2.RefreshReport();
                MessageBox.Show("Quotation Saved : " + lblQuoteId.Text + " Successfully inserted", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
                frmp.ShowDialog();
                resetForm();
            }
            catch (Exception)
            {
                MessageBox.Show("TRY AGAIN WITH VALID INPUTS", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
            }
            finally
            {
               
                lblQuoteId.Text = getQuoteId();

            }
                

       


        }

        public class BillDetails
        {
            private string item_code;
            private string component_name;
            private float unit_price;
            private int pro_qty;
            private float pro_grtotal;

            public string Item_code
            {
                get { return item_code; }
                set { item_code = value; }
            }

            public string Component_name
            {
                get { return component_name; }
                set { component_name = value; }
            }

            public float Unit_price
            {
                get { return unit_price; }
                set { unit_price = value; }
            }

            public int Pro_qty
            {
                get { return pro_qty; }
                set { pro_qty = value; }
            }

            public float Pro_grtotal
            {
                get { return pro_grtotal; }
                set { pro_grtotal = value; }
            }
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            resetForm();
        }

        private void dvgBilledItems_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {

            if (dvgBilledItems.SelectedRows.Count > 0) // make sure user select at least 1 row 
            {
                string catna = dvgBilledItems.SelectedRows[0].Cells[0].Value + string.Empty;
                string partna = dvgBilledItems.SelectedRows[0].Cells[1].Value + string.Empty;

                string itemcode = dvgBilledItems.SelectedRows[0].Cells[2].Value + string.Empty;
                string price = dvgBilledItems.SelectedRows[0].Cells[3].Value + string.Empty;

                string qty = dvgBilledItems.SelectedRows[0].Cells[4].Value + string.Empty;


                txtCatNa.Text = catna;
                txtPrtNa.Text = partna;
                txtItemCode.Text = itemcode;
                txtPrice.Text = price;
                txtQntyUnit.Text = qty;

                dvgBilledItems.Rows.RemoveAt(this.dvgBilledItems.SelectedRows[0].Index);
            }


        }

 
    }
}
