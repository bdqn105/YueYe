namespace LogisPrj
{
    partial class FrmRetrunOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRetrunOrder));
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.btnBig = new System.Windows.Forms.Button();
            this.btnSmall = new System.Windows.Forms.Button();
            this.btnSpin = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnDownLoad = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            this.printDocument1.QueryPageSettings += new System.Drawing.Printing.QueryPageSettingsEventHandler(this.printDocument1_QueryPageSettings);
            // 
            // btnBig
            // 
            this.btnBig.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBig.BackgroundImage")));
            this.btnBig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBig.FlatAppearance.BorderSize = 0;
            this.btnBig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBig.Location = new System.Drawing.Point(88, 621);
            this.btnBig.Name = "btnBig";
            this.btnBig.Size = new System.Drawing.Size(34, 23);
            this.btnBig.TabIndex = 3;
            this.btnBig.UseVisualStyleBackColor = true;
            this.btnBig.Click += new System.EventHandler(this.btnBig_Click);
            // 
            // btnSmall
            // 
            this.btnSmall.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSmall.BackgroundImage")));
            this.btnSmall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSmall.FlatAppearance.BorderSize = 0;
            this.btnSmall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSmall.Location = new System.Drawing.Point(164, 621);
            this.btnSmall.Name = "btnSmall";
            this.btnSmall.Size = new System.Drawing.Size(34, 23);
            this.btnSmall.TabIndex = 3;
            this.btnSmall.UseVisualStyleBackColor = true;
            this.btnSmall.Click += new System.EventHandler(this.btnSmall_Click);
            // 
            // btnSpin
            // 
            this.btnSpin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSpin.BackgroundImage")));
            this.btnSpin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSpin.FlatAppearance.BorderSize = 0;
            this.btnSpin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpin.Location = new System.Drawing.Point(240, 621);
            this.btnSpin.Name = "btnSpin";
            this.btnSpin.Size = new System.Drawing.Size(34, 23);
            this.btnSpin.TabIndex = 3;
            this.btnSpin.UseVisualStyleBackColor = true;
            this.btnSpin.Click += new System.EventHandler(this.btnSpin_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPrint.BackgroundImage")));
            this.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Location = new System.Drawing.Point(392, 621);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(34, 23);
            this.btnPrint.TabIndex = 3;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnDownLoad
            // 
            this.btnDownLoad.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDownLoad.BackgroundImage")));
            this.btnDownLoad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDownLoad.FlatAppearance.BorderSize = 0;
            this.btnDownLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDownLoad.Location = new System.Drawing.Point(316, 621);
            this.btnDownLoad.Name = "btnDownLoad";
            this.btnDownLoad.Size = new System.Drawing.Size(34, 23);
            this.btnDownLoad.TabIndex = 3;
            this.btnDownLoad.UseVisualStyleBackColor = true;
            this.btnDownLoad.Click += new System.EventHandler(this.btnDownLoad_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(555, 605);
            this.panel1.TabIndex = 2;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(51, 9);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(412, 582);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // FrmRetrunOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 665);
            this.Controls.Add(this.btnDownLoad);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnSpin);
            this.Controls.Add(this.btnSmall);
            this.Controls.Add(this.btnBig);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRetrunOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "回单";
            this.Load += new System.EventHandler(this.FrmRetrunOrder_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button btnBig;
        private System.Windows.Forms.Button btnSmall;
        private System.Windows.Forms.Button btnSpin;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnDownLoad;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}