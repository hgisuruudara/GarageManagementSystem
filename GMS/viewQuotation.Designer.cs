namespace GMS
{
    partial class viewQuotation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label12 = new System.Windows.Forms.Label();
            this.txtSearchdetails = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunViewQuoteDetails = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Quotedatetime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quoteID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustNic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustMob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustStreet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GrossTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NetTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunViewQuoteDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label12.Location = new System.Drawing.Point(26, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(361, 32);
            this.label12.TabIndex = 0;
            this.label12.Text = "VIEW QUOTATION RECORDS";
            // 
            // txtSearchdetails
            // 
            this.txtSearchdetails.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchdetails.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtSearchdetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSearchdetails.HintForeColor = System.Drawing.Color.Empty;
            this.txtSearchdetails.HintText = "ENTER QUOTATION ID/NIC/Name";
            this.txtSearchdetails.isPassword = false;
            this.txtSearchdetails.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtSearchdetails.LineIdleColor = System.Drawing.Color.Gray;
            this.txtSearchdetails.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtSearchdetails.LineThickness = 3;
            this.txtSearchdetails.Location = new System.Drawing.Point(15, 83);
            this.txtSearchdetails.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchdetails.Name = "txtSearchdetails";
            this.txtSearchdetails.Size = new System.Drawing.Size(236, 44);
            this.txtSearchdetails.TabIndex = 30;
            this.txtSearchdetails.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSearchdetails.OnValueChanged += new System.EventHandler(this.txtSearchdetails_OnValueChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Controls.Add(this.label12);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(877, 68);
            this.panel2.TabIndex = 33;
            // 
            // bunViewQuoteDetails
            // 
            this.bunViewQuoteDetails.AllowUserToAddRows = false;
            this.bunViewQuoteDetails.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.bunViewQuoteDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bunViewQuoteDetails.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.bunViewQuoteDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunViewQuoteDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunViewQuoteDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bunViewQuoteDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Quotedatetime,
            this.quoteID,
            this.CategoryName,
            this.CustTitle,
            this.CustName,
            this.CustNic,
            this.CustMob,
            this.CustNo,
            this.CustStreet,
            this.CustCity,
            this.GrossTotal,
            this.NetTotal,
            this.Discount,
            this.Tax});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bunViewQuoteDetails.DefaultCellStyle = dataGridViewCellStyle3;
            this.bunViewQuoteDetails.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bunViewQuoteDetails.DoubleBuffered = true;
            this.bunViewQuoteDetails.EnableHeadersVisualStyles = false;
            this.bunViewQuoteDetails.HeaderBgColor = System.Drawing.SystemColors.HotTrack;
            this.bunViewQuoteDetails.HeaderForeColor = System.Drawing.Color.White;
            this.bunViewQuoteDetails.Location = new System.Drawing.Point(0, 154);
            this.bunViewQuoteDetails.Name = "bunViewQuoteDetails";
            this.bunViewQuoteDetails.ReadOnly = true;
            this.bunViewQuoteDetails.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunViewQuoteDetails.Size = new System.Drawing.Size(877, 466);
            this.bunViewQuoteDetails.TabIndex = 32;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GMS.Properties.Resources.icons8_office_160;
            this.pictureBox1.Location = new System.Drawing.Point(258, 82);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // Quotedatetime
            // 
            this.Quotedatetime.DataPropertyName = "Quotedatetime";
            this.Quotedatetime.HeaderText = "Quote Date";
            this.Quotedatetime.Name = "Quotedatetime";
            this.Quotedatetime.ReadOnly = true;
            // 
            // quoteID
            // 
            this.quoteID.DataPropertyName = "quoteID";
            this.quoteID.HeaderText = "Quote ID";
            this.quoteID.Name = "quoteID";
            this.quoteID.ReadOnly = true;
            // 
            // CategoryName
            // 
            this.CategoryName.DataPropertyName = "CategoryName";
            this.CategoryName.HeaderText = "Category Name";
            this.CategoryName.Name = "CategoryName";
            this.CategoryName.ReadOnly = true;
            // 
            // CustTitle
            // 
            this.CustTitle.DataPropertyName = "CustTitle";
            this.CustTitle.HeaderText = "Cutomer Title";
            this.CustTitle.Name = "CustTitle";
            this.CustTitle.ReadOnly = true;
            // 
            // CustName
            // 
            this.CustName.DataPropertyName = "CustName";
            this.CustName.HeaderText = "Customer Name";
            this.CustName.Name = "CustName";
            this.CustName.ReadOnly = true;
            // 
            // CustNic
            // 
            this.CustNic.DataPropertyName = "CustNic";
            this.CustNic.HeaderText = "NIC";
            this.CustNic.Name = "CustNic";
            this.CustNic.ReadOnly = true;
            // 
            // CustMob
            // 
            this.CustMob.DataPropertyName = "CustMob";
            this.CustMob.HeaderText = "Contact No";
            this.CustMob.Name = "CustMob";
            this.CustMob.ReadOnly = true;
            // 
            // CustNo
            // 
            this.CustNo.DataPropertyName = "CustNo";
            this.CustNo.HeaderText = "House No";
            this.CustNo.Name = "CustNo";
            this.CustNo.ReadOnly = true;
            // 
            // CustStreet
            // 
            this.CustStreet.DataPropertyName = "CustStreet";
            this.CustStreet.HeaderText = "Street Name";
            this.CustStreet.Name = "CustStreet";
            this.CustStreet.ReadOnly = true;
            // 
            // CustCity
            // 
            this.CustCity.DataPropertyName = "CustCity";
            this.CustCity.HeaderText = "City";
            this.CustCity.Name = "CustCity";
            this.CustCity.ReadOnly = true;
            // 
            // GrossTotal
            // 
            this.GrossTotal.DataPropertyName = "GrossTotal";
            this.GrossTotal.HeaderText = "Gross Total";
            this.GrossTotal.Name = "GrossTotal";
            this.GrossTotal.ReadOnly = true;
            // 
            // NetTotal
            // 
            this.NetTotal.DataPropertyName = "NetTotal";
            this.NetTotal.HeaderText = "Net Total";
            this.NetTotal.Name = "NetTotal";
            this.NetTotal.ReadOnly = true;
            // 
            // Discount
            // 
            this.Discount.DataPropertyName = "Discount";
            this.Discount.HeaderText = "Discount";
            this.Discount.Name = "Discount";
            this.Discount.ReadOnly = true;
            // 
            // Tax
            // 
            this.Tax.DataPropertyName = "Tax";
            this.Tax.HeaderText = "Tax";
            this.Tax.Name = "Tax";
            this.Tax.ReadOnly = true;
            this.Tax.Width = 200;
            // 
            // viewQuotation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 620);
            this.Controls.Add(this.txtSearchdetails);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.bunViewQuoteDetails);
            this.Name = "viewQuotation";
            this.Text = "viewQuotation";
            this.Load += new System.EventHandler(this.viewQuotation_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunViewQuoteDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtSearchdetails;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunViewQuoteDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quotedatetime;
        private System.Windows.Forms.DataGridViewTextBoxColumn quoteID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustNic;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustMob;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustStreet;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn GrossTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn NetTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tax;
    }
}