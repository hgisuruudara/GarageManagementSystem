namespace GMS
{
    partial class frmViewPartDetails
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label12 = new System.Windows.Forms.Label();
            this.txtSearchdetails = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.garageManagementSystemDataSet = new GMS.GarageManagementSystemDataSet();
            this.garageManagementSystemDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bunViewPartDetails = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.ItemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.part_descri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbCatTyp = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.garageManagementSystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.garageManagementSystemDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunViewPartDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label12.Location = new System.Drawing.Point(26, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(325, 32);
            this.label12.TabIndex = 0;
            this.label12.Text = "VIEW QUOTATION PARTS";
            // 
            // txtSearchdetails
            // 
            this.txtSearchdetails.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchdetails.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtSearchdetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSearchdetails.HintForeColor = System.Drawing.Color.Empty;
            this.txtSearchdetails.HintText = "ENTER ITEM CODE/CATEGORY NAME/PART NAME";
            this.txtSearchdetails.isPassword = false;
            this.txtSearchdetails.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtSearchdetails.LineIdleColor = System.Drawing.Color.Gray;
            this.txtSearchdetails.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtSearchdetails.LineThickness = 3;
            this.txtSearchdetails.Location = new System.Drawing.Point(15, 83);
            this.txtSearchdetails.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchdetails.Name = "txtSearchdetails";
            this.txtSearchdetails.Size = new System.Drawing.Size(331, 44);
            this.txtSearchdetails.TabIndex = 30;
            this.txtSearchdetails.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSearchdetails.OnValueChanged += new System.EventHandler(this.txtSearchdetails_OnValueChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GMS.Properties.Resources.icons8_office_160;
            this.pictureBox1.Location = new System.Drawing.Point(353, 83);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Controls.Add(this.label12);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(671, 68);
            this.panel2.TabIndex = 33;
            // 
            // garageManagementSystemDataSet
            // 
            this.garageManagementSystemDataSet.DataSetName = "GarageManagementSystemDataSet";
            this.garageManagementSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // garageManagementSystemDataSetBindingSource
            // 
            this.garageManagementSystemDataSetBindingSource.DataSource = this.garageManagementSystemDataSet;
            this.garageManagementSystemDataSetBindingSource.Position = 0;
            // 
            // bunViewPartDetails
            // 
            this.bunViewPartDetails.AllowUserToAddRows = false;
            this.bunViewPartDetails.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.bunViewPartDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.bunViewPartDetails.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.bunViewPartDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunViewPartDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunViewPartDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.bunViewPartDetails.ColumnHeadersHeight = 30;
            this.bunViewPartDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemCode,
            this.PartName,
            this.part_descri,
            this.UnitPrice,
            this.tax,
            this.ProductID});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bunViewPartDetails.DefaultCellStyle = dataGridViewCellStyle6;
            this.bunViewPartDetails.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bunViewPartDetails.DoubleBuffered = true;
            this.bunViewPartDetails.EnableHeadersVisualStyles = false;
            this.bunViewPartDetails.HeaderBgColor = System.Drawing.SystemColors.HotTrack;
            this.bunViewPartDetails.HeaderForeColor = System.Drawing.Color.White;
            this.bunViewPartDetails.Location = new System.Drawing.Point(0, 152);
            this.bunViewPartDetails.Name = "bunViewPartDetails";
            this.bunViewPartDetails.ReadOnly = true;
            this.bunViewPartDetails.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunViewPartDetails.Size = new System.Drawing.Size(671, 284);
            this.bunViewPartDetails.TabIndex = 34;
            // 
            // ItemCode
            // 
            this.ItemCode.DataPropertyName = "ItemCode";
            this.ItemCode.FillWeight = 98.4127F;
            this.ItemCode.HeaderText = "Item Code";
            this.ItemCode.Name = "ItemCode";
            this.ItemCode.ReadOnly = true;
            this.ItemCode.Width = 124;
            // 
            // PartName
            // 
            this.PartName.DataPropertyName = "PartName";
            this.PartName.FillWeight = 187.2818F;
            this.PartName.HeaderText = "Part Name";
            this.PartName.Name = "PartName";
            this.PartName.ReadOnly = true;
            this.PartName.Width = 236;
            // 
            // part_descri
            // 
            this.part_descri.DataPropertyName = "part_descri";
            this.part_descri.FillWeight = 71.19917F;
            this.part_descri.HeaderText = "Category Type";
            this.part_descri.Name = "part_descri";
            this.part_descri.ReadOnly = true;
            // 
            // UnitPrice
            // 
            this.UnitPrice.DataPropertyName = "UnitPrice";
            this.UnitPrice.FillWeight = 71.85059F;
            this.UnitPrice.HeaderText = "Unit Price";
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.ReadOnly = true;
            this.UnitPrice.Width = 90;
            // 
            // tax
            // 
            this.tax.DataPropertyName = "tax";
            this.tax.FillWeight = 71.25575F;
            this.tax.HeaderText = "Tax";
            this.tax.Name = "tax";
            this.tax.ReadOnly = true;
            this.tax.Width = 90;
            // 
            // ProductID
            // 
            this.ProductID.DataPropertyName = "ProductID";
            this.ProductID.HeaderText = "Product ID";
            this.ProductID.Name = "ProductID";
            this.ProductID.ReadOnly = true;
            // 
            // cmbCatTyp
            // 
            this.cmbCatTyp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCatTyp.FormattingEnabled = true;
            this.cmbCatTyp.Location = new System.Drawing.Point(469, 101);
            this.cmbCatTyp.Name = "cmbCatTyp";
            this.cmbCatTyp.Size = new System.Drawing.Size(190, 27);
            this.cmbCatTyp.TabIndex = 128;
            this.cmbCatTyp.SelectedIndexChanged += new System.EventHandler(this.cmbCatTyp_SelectedIndexChanged);
            // 
            // frmViewPartDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 436);
            this.Controls.Add(this.cmbCatTyp);
            this.Controls.Add(this.bunViewPartDetails);
            this.Controls.Add(this.txtSearchdetails);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmViewPartDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmViewPartDetails";
            this.Load += new System.EventHandler(this.frmViewPartDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.garageManagementSystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.garageManagementSystemDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunViewPartDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtSearchdetails;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private GarageManagementSystemDataSet garageManagementSystemDataSet;
        private System.Windows.Forms.BindingSource garageManagementSystemDataSetBindingSource;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunViewPartDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartName;
        private System.Windows.Forms.DataGridViewTextBoxColumn part_descri;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn tax;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.ComboBox cmbCatTyp;

    }
}