namespace GMS
{
    partial class frmviewJob
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmviewJob));
            this.bunViewJobDetails = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.txtSearchdetails = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.AddminNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.job_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cus_title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cus_fn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cus_ln = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cus_nic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cus_mob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cus_houseno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cus_street = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cus_city = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.job_title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.job_vehid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.job_servicetyp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.job_descr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.job_sercharge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bunViewJobDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunViewJobDetails
            // 
            this.bunViewJobDetails.AllowUserToAddRows = false;
            this.bunViewJobDetails.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.bunViewJobDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bunViewJobDetails.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.bunViewJobDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunViewJobDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunViewJobDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bunViewJobDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AddminNo,
            this.job_id,
            this.cus_title,
            this.cus_fn,
            this.cus_ln,
            this.cus_nic,
            this.cus_mob,
            this.cus_houseno,
            this.cus_street,
            this.cus_city,
            this.job_title,
            this.job_vehid,
            this.job_servicetyp,
            this.job_descr,
            this.job_sercharge});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bunViewJobDetails.DefaultCellStyle = dataGridViewCellStyle3;
            this.bunViewJobDetails.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bunViewJobDetails.DoubleBuffered = true;
            this.bunViewJobDetails.EnableHeadersVisualStyles = false;
            this.bunViewJobDetails.HeaderBgColor = System.Drawing.SystemColors.HotTrack;
            this.bunViewJobDetails.HeaderForeColor = System.Drawing.Color.White;
            this.bunViewJobDetails.Location = new System.Drawing.Point(0, 153);
            this.bunViewJobDetails.Name = "bunViewJobDetails";
            this.bunViewJobDetails.ReadOnly = true;
            this.bunViewJobDetails.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunViewJobDetails.Size = new System.Drawing.Size(893, 506);
            this.bunViewJobDetails.TabIndex = 10;
            // 
            // txtSearchdetails
            // 
            this.txtSearchdetails.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchdetails.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtSearchdetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSearchdetails.HintForeColor = System.Drawing.Color.Empty;
            this.txtSearchdetails.HintText = "ENTER JOB ID/NIC/Name";
            this.txtSearchdetails.isPassword = false;
            this.txtSearchdetails.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtSearchdetails.LineIdleColor = System.Drawing.Color.Gray;
            this.txtSearchdetails.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtSearchdetails.LineThickness = 3;
            this.txtSearchdetails.Location = new System.Drawing.Point(15, 83);
            this.txtSearchdetails.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchdetails.Name = "txtSearchdetails";
            this.txtSearchdetails.Size = new System.Drawing.Size(212, 44);
            this.txtSearchdetails.TabIndex = 8;
            this.txtSearchdetails.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSearchdetails.OnValueChanged += new System.EventHandler(this.txtSearchStud_OnValueChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GMS.Properties.Resources.icons8_office_160;
            this.pictureBox1.Location = new System.Drawing.Point(234, 83);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Controls.Add(this.label12);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(893, 68);
            this.panel2.TabIndex = 29;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label12.Location = new System.Drawing.Point(26, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(263, 32);
            this.label12.TabIndex = 0;
            this.label12.Text = "VIEW JOB RECORDS";
            // 
            // AddminNo
            // 
            this.AddminNo.DataPropertyName = "job_date";
            this.AddminNo.HeaderText = "Job Date";
            this.AddminNo.Name = "AddminNo";
            this.AddminNo.ReadOnly = true;
            // 
            // job_id
            // 
            this.job_id.DataPropertyName = "job_id";
            this.job_id.HeaderText = "Job ID";
            this.job_id.Name = "job_id";
            this.job_id.ReadOnly = true;
            // 
            // cus_title
            // 
            this.cus_title.DataPropertyName = "cus_title";
            this.cus_title.HeaderText = "Customer Title";
            this.cus_title.Name = "cus_title";
            this.cus_title.ReadOnly = true;
            // 
            // cus_fn
            // 
            this.cus_fn.DataPropertyName = "cus_fn";
            this.cus_fn.HeaderText = "First Name";
            this.cus_fn.Name = "cus_fn";
            this.cus_fn.ReadOnly = true;
            // 
            // cus_ln
            // 
            this.cus_ln.DataPropertyName = "cus_ln";
            this.cus_ln.HeaderText = "Last Name";
            this.cus_ln.Name = "cus_ln";
            this.cus_ln.ReadOnly = true;
            // 
            // cus_nic
            // 
            this.cus_nic.DataPropertyName = "cus_nic";
            this.cus_nic.HeaderText = "NIC";
            this.cus_nic.Name = "cus_nic";
            this.cus_nic.ReadOnly = true;
            // 
            // cus_mob
            // 
            this.cus_mob.DataPropertyName = "cus_mob";
            this.cus_mob.HeaderText = "Contact No";
            this.cus_mob.Name = "cus_mob";
            this.cus_mob.ReadOnly = true;
            // 
            // cus_houseno
            // 
            this.cus_houseno.DataPropertyName = "cus_houseno";
            this.cus_houseno.HeaderText = "House No";
            this.cus_houseno.Name = "cus_houseno";
            this.cus_houseno.ReadOnly = true;
            // 
            // cus_street
            // 
            this.cus_street.DataPropertyName = "cus_street";
            this.cus_street.HeaderText = "Street Name";
            this.cus_street.Name = "cus_street";
            this.cus_street.ReadOnly = true;
            // 
            // cus_city
            // 
            this.cus_city.DataPropertyName = "cus_city";
            this.cus_city.HeaderText = "City";
            this.cus_city.Name = "cus_city";
            this.cus_city.ReadOnly = true;
            // 
            // job_title
            // 
            this.job_title.DataPropertyName = "job_title";
            this.job_title.HeaderText = "Job Title";
            this.job_title.Name = "job_title";
            this.job_title.ReadOnly = true;
            // 
            // job_vehid
            // 
            this.job_vehid.DataPropertyName = "job_vehid";
            this.job_vehid.HeaderText = "Vehicle ID";
            this.job_vehid.Name = "job_vehid";
            this.job_vehid.ReadOnly = true;
            // 
            // job_servicetyp
            // 
            this.job_servicetyp.DataPropertyName = "job_servicetyp";
            this.job_servicetyp.HeaderText = "Service Type";
            this.job_servicetyp.Name = "job_servicetyp";
            this.job_servicetyp.ReadOnly = true;
            // 
            // job_descr
            // 
            this.job_descr.DataPropertyName = "job_descr";
            this.job_descr.HeaderText = "Description";
            this.job_descr.Name = "job_descr";
            this.job_descr.ReadOnly = true;
            this.job_descr.Width = 200;
            // 
            // job_sercharge
            // 
            this.job_sercharge.DataPropertyName = "job_sercharge";
            this.job_sercharge.HeaderText = "Service Charge";
            this.job_sercharge.Name = "job_sercharge";
            this.job_sercharge.ReadOnly = true;
            this.job_sercharge.Width = 150;
            // 
            // frmviewJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 659);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.bunViewJobDetails);
            this.Controls.Add(this.txtSearchdetails);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmviewJob";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmviewJob";
            this.Load += new System.EventHandler(this.frmviewJob_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunViewJobDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid bunViewJobDetails;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtSearchdetails;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddminNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn job_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cus_title;
        private System.Windows.Forms.DataGridViewTextBoxColumn cus_fn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cus_ln;
        private System.Windows.Forms.DataGridViewTextBoxColumn cus_nic;
        private System.Windows.Forms.DataGridViewTextBoxColumn cus_mob;
        private System.Windows.Forms.DataGridViewTextBoxColumn cus_houseno;
        private System.Windows.Forms.DataGridViewTextBoxColumn cus_street;
        private System.Windows.Forms.DataGridViewTextBoxColumn cus_city;
        private System.Windows.Forms.DataGridViewTextBoxColumn job_title;
        private System.Windows.Forms.DataGridViewTextBoxColumn job_vehid;
        private System.Windows.Forms.DataGridViewTextBoxColumn job_servicetyp;
        private System.Windows.Forms.DataGridViewTextBoxColumn job_descr;
        private System.Windows.Forms.DataGridViewTextBoxColumn job_sercharge;
    }
}