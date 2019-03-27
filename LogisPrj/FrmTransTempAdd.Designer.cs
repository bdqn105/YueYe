namespace LogisPrj
{
    partial class FrmTransTempAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTransTempAdd));
            this.label1 = new System.Windows.Forms.Label();
            this.txtDeviceId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTemp1 = new System.Windows.Forms.TextBox();
            this.txtTemp2 = new System.Windows.Forms.TextBox();
            this.txtTemp3 = new System.Windows.Forms.TextBox();
            this.dTGetTime = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dTUploadTime = new System.Windows.Forms.DateTimePicker();
            this.chkGet = new System.Windows.Forms.CheckBox();
            this.chkUpload = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "运输编号";
            // 
            // txtDeviceId
            // 
            this.txtDeviceId.Location = new System.Drawing.Point(71, 18);
            this.txtDeviceId.Name = "txtDeviceId";
            this.txtDeviceId.Size = new System.Drawing.Size(158, 21);
            this.txtDeviceId.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(382, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "温度";
            // 
            // txtTemp1
            // 
            this.txtTemp1.Location = new System.Drawing.Point(415, 18);
            this.txtTemp1.Name = "txtTemp1";
            this.txtTemp1.Size = new System.Drawing.Size(51, 21);
            this.txtTemp1.TabIndex = 1;
            this.txtTemp1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTemp1_KeyPress);
            // 
            // txtTemp2
            // 
            this.txtTemp2.Location = new System.Drawing.Point(469, 18);
            this.txtTemp2.Name = "txtTemp2";
            this.txtTemp2.Size = new System.Drawing.Size(51, 21);
            this.txtTemp2.TabIndex = 1;
            this.txtTemp2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTemp2_KeyPress);
            // 
            // txtTemp3
            // 
            this.txtTemp3.Location = new System.Drawing.Point(523, 18);
            this.txtTemp3.Name = "txtTemp3";
            this.txtTemp3.Size = new System.Drawing.Size(51, 21);
            this.txtTemp3.TabIndex = 1;
            this.txtTemp3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTemp3_KeyPress);
            // 
            // dTGetTime
            // 
            this.dTGetTime.CustomFormat = "yyyy-MM-dd HH:mm:00";
            this.dTGetTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTGetTime.Location = new System.Drawing.Point(71, 43);
            this.dTGetTime.Name = "dTGetTime";
            this.dTGetTime.Size = new System.Drawing.Size(158, 21);
            this.dTGetTime.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "温度时间";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(358, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "上传时间";
            // 
            // dTUploadTime
            // 
            this.dTUploadTime.CustomFormat = "yyyy-MM-dd HH:mm:00";
            this.dTUploadTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTUploadTime.Location = new System.Drawing.Point(415, 43);
            this.dTUploadTime.Name = "dTUploadTime";
            this.dTUploadTime.Size = new System.Drawing.Size(160, 21);
            this.dTUploadTime.TabIndex = 2;
            // 
            // chkGet
            // 
            this.chkGet.AutoSize = true;
            this.chkGet.Location = new System.Drawing.Point(235, 45);
            this.chkGet.Name = "chkGet";
            this.chkGet.Size = new System.Drawing.Size(60, 16);
            this.chkGet.TabIndex = 3;
            this.chkGet.Text = "+5分钟";
            this.chkGet.UseVisualStyleBackColor = true;
            // 
            // chkUpload
            // 
            this.chkUpload.AutoSize = true;
            this.chkUpload.Location = new System.Drawing.Point(581, 45);
            this.chkUpload.Name = "chkUpload";
            this.chkUpload.Size = new System.Drawing.Size(60, 16);
            this.chkUpload.TabIndex = 3;
            this.chkUpload.Text = "+5分钟";
            this.chkUpload.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(578, 91);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dTGetTime);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.chkUpload);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.chkGet);
            this.groupBox1.Controls.Add(this.txtDeviceId);
            this.groupBox1.Controls.Add(this.dTUploadTime);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTemp3);
            this.groupBox1.Controls.Add(this.txtTemp1);
            this.groupBox1.Controls.Add(this.txtTemp2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(657, 73);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // FrmTransTempAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 129);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSave);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTransTempAdd";
            this.Text = "增加";
            this.Load += new System.EventHandler(this.FrmTransTempAdd_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDeviceId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTemp1;
        private System.Windows.Forms.TextBox txtTemp2;
        private System.Windows.Forms.TextBox txtTemp3;
        private System.Windows.Forms.DateTimePicker dTGetTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dTUploadTime;
        private System.Windows.Forms.CheckBox chkGet;
        private System.Windows.Forms.CheckBox chkUpload;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}