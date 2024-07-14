namespace GMS
{
    partial class frmdashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmdashboard));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblJobsNo = new System.Windows.Forms.Label();
            this.lable = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblday = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbldate = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblhrs = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuGradientPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.panel1);
            this.bunifuGradientPanel1.Controls.Add(this.lblJobsNo);
            this.bunifuGradientPanel1.Controls.Add(this.lable);
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox1);
            this.bunifuGradientPanel1.Controls.Add(this.lblday);
            this.bunifuGradientPanel1.Controls.Add(this.lbldate);
            this.bunifuGradientPanel1.Controls.Add(this.lblhrs);
            this.bunifuGradientPanel1.Controls.Add(this.label1);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.MidnightBlue;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.Black;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.Indigo;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.DeepPink;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(943, 659);
            this.bunifuGradientPanel1.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 629);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(943, 30);
            this.panel1.TabIndex = 15;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblJobsNo
            // 
            this.lblJobsNo.AutoSize = true;
            this.lblJobsNo.BackColor = System.Drawing.Color.Transparent;
            this.lblJobsNo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20F);
            this.lblJobsNo.ForeColor = System.Drawing.Color.White;
            this.lblJobsNo.Location = new System.Drawing.Point(816, 524);
            this.lblJobsNo.Name = "lblJobsNo";
            this.lblJobsNo.Size = new System.Drawing.Size(31, 32);
            this.lblJobsNo.TabIndex = 13;
            this.lblJobsNo.Text = "0";
            this.lblJobsNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lable
            // 
            this.lable.AutoSize = true;
            this.lable.BackColor = System.Drawing.Color.Transparent;
            this.lable.Font = new System.Drawing.Font("Fugaz One", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable.ForeColor = System.Drawing.Color.White;
            this.lable.Location = new System.Drawing.Point(645, 489);
            this.lable.Name = "lable";
            this.lable.Size = new System.Drawing.Size(202, 35);
            this.lable.TabIndex = 10;
            this.lable.Text = "Number of Jobs";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::GMS.Properties.Resources.htf;
            this.pictureBox1.Location = new System.Drawing.Point(375, 192);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // lblday
            // 
            this.lblday.AutoSize = true;
            this.lblday.BackColor = System.Drawing.Color.Transparent;
            this.lblday.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblday.ForeColor = System.Drawing.Color.White;
            this.lblday.Location = new System.Drawing.Point(739, 109);
            this.lblday.Name = "lblday";
            this.lblday.Size = new System.Drawing.Size(127, 32);
            this.lblday.TabIndex = 0;
            this.lblday.Text = "Saturday";
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.BackColor = System.Drawing.Color.Transparent;
            this.lbldate.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldate.ForeColor = System.Drawing.Color.White;
            this.lbldate.Location = new System.Drawing.Point(565, 109);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(179, 32);
            this.lbldate.TabIndex = 6;
            this.lbldate.Text = "Mar 09 2020,";
            // 
            // lblhrs
            // 
            this.lblhrs.AutoSize = true;
            this.lblhrs.BackColor = System.Drawing.Color.Transparent;
            this.lblhrs.Font = new System.Drawing.Font("Times New Roman", 65.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhrs.ForeColor = System.Drawing.Color.White;
            this.lblhrs.Location = new System.Drawing.Point(529, 23);
            this.lblhrs.Name = "lblhrs";
            this.lblhrs.Size = new System.Drawing.Size(364, 98);
            this.lblhrs.TabIndex = 7;
            this.lblhrs.Text = "00:00:00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("FN CHUTY", 71.99999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(185, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(559, 192);
            this.label1.TabIndex = 9;
            this.label1.Text = "udOj fudag¾iA";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(577, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(298, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "All Rights Reserved © Madawa Motors (Pvt) Ltd";
            // 
            // frmdashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 659);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmdashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmdashboard";
            this.Load += new System.EventHandler(this.frmdashboard_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Label lblJobsNo;
        private System.Windows.Forms.Label lable;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuCustomLabel lblday;
        private Bunifu.Framework.UI.BunifuCustomLabel lbldate;
        private Bunifu.Framework.UI.BunifuCustomLabel lblhrs;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;

    }
}