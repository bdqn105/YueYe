namespace LogisPrj
{
    partial class FrmVehicleAddOrUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVehicleAddOrUpdate));
            this.txtVehicleName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVehicleNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLoadCapacity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblVehiclePhoto = new System.Windows.Forms.Label();
            this.lblLicensePhoto = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cbxCompanyID = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLoadVehiclePhoto = new System.Windows.Forms.Button();
            this.btnUploadVehicle = new System.Windows.Forms.Button();
            this.btnUploadLicense = new System.Windows.Forms.Button();
            this.btnLoadLicense = new System.Windows.Forms.Button();
            this.btnAddVehilceType = new System.Windows.Forms.Button();
            this.chkIFBelongsto = new System.Windows.Forms.CheckBox();
            this.cbxVehicleTypeId = new System.Windows.Forms.ComboBox();
            this.lblBelong = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtVehicleName
            // 
            this.txtVehicleName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVehicleName.Location = new System.Drawing.Point(390, 20);
            this.txtVehicleName.Name = "txtVehicleName";
            this.txtVehicleName.Size = new System.Drawing.Size(156, 21);
            this.txtVehicleName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(331, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "车辆名称";
            // 
            // txtVehicleNumber
            // 
            this.txtVehicleNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVehicleNumber.Location = new System.Drawing.Point(86, 20);
            this.txtVehicleNumber.Name = "txtVehicleNumber";
            this.txtVehicleNumber.Size = new System.Drawing.Size(167, 21);
            this.txtVehicleNumber.TabIndex = 3;
            this.txtVehicleNumber.Leave += new System.EventHandler(this.txtVehicleNumber_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "车牌号";
            // 
            // txtLoadCapacity
            // 
            this.txtLoadCapacity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLoadCapacity.Location = new System.Drawing.Point(390, 47);
            this.txtLoadCapacity.Name = "txtLoadCapacity";
            this.txtLoadCapacity.Size = new System.Drawing.Size(156, 21);
            this.txtLoadCapacity.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(343, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 14;
            this.label5.Text = "载重量";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "车辆类型";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("宋体", 9F);
            this.btnSave.Location = new System.Drawing.Point(481, 190);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "行驶证照片";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "车辆照片";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblVehiclePhoto);
            this.groupBox1.Controls.Add(this.lblLicensePhoto);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.cbxCompanyID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtVehicleName);
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnLoadVehiclePhoto);
            this.groupBox1.Controls.Add(this.btnUploadVehicle);
            this.groupBox1.Controls.Add(this.btnUploadLicense);
            this.groupBox1.Controls.Add(this.btnLoadLicense);
            this.groupBox1.Controls.Add(this.btnAddVehilceType);
            this.groupBox1.Controls.Add(this.chkIFBelongsto);
            this.groupBox1.Controls.Add(this.cbxVehicleTypeId);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtLoadCapacity);
            this.groupBox1.Controls.Add(this.lblBelong);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtVehicleNumber);
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(562, 174);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // lblVehiclePhoto
            // 
            this.lblVehiclePhoto.AutoSize = true;
            this.lblVehiclePhoto.Location = new System.Drawing.Point(89, 133);
            this.lblVehiclePhoto.Name = "lblVehiclePhoto";
            this.lblVehiclePhoto.Size = new System.Drawing.Size(47, 12);
            this.lblVehiclePhoto.TabIndex = 66;
            this.lblVehiclePhoto.Text = "label11";
            // 
            // lblLicensePhoto
            // 
            this.lblLicensePhoto.AutoSize = true;
            this.lblLicensePhoto.Location = new System.Drawing.Point(89, 106);
            this.lblLicensePhoto.Name = "lblLicensePhoto";
            this.lblLicensePhoto.Size = new System.Drawing.Size(47, 12);
            this.lblLicensePhoto.TabIndex = 66;
            this.lblLicensePhoto.Text = "label11";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(86, 134);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(293, 12);
            this.label12.TabIndex = 66;
            this.label12.Text = "________________________________________________";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(86, 109);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(293, 12);
            this.label11.TabIndex = 66;
            this.label11.Text = "________________________________________________";
            // 
            // cbxCompanyID
            // 
            this.cbxCompanyID.FormattingEnabled = true;
            this.cbxCompanyID.Location = new System.Drawing.Point(390, 74);
            this.cbxCompanyID.Name = "cbxCompanyID";
            this.cbxCompanyID.Size = new System.Drawing.Size(156, 20);
            this.cbxCompanyID.TabIndex = 65;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Brown;
            this.label3.Location = new System.Drawing.Point(17, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 14);
            this.label3.TabIndex = 64;
            this.label3.Tag = "";
            this.label3.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.ForeColor = System.Drawing.Color.Brown;
            this.label9.Location = new System.Drawing.Point(90, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 14);
            this.label9.TabIndex = 64;
            this.label9.Tag = "";
            this.label9.Text = "*";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label23.ForeColor = System.Drawing.Color.Brown;
            this.label23.Location = new System.Drawing.Point(311, 23);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(14, 14);
            this.label23.TabIndex = 64;
            this.label23.Tag = "";
            this.label23.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(24, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 14);
            this.label1.TabIndex = 64;
            this.label1.Tag = "";
            this.label1.Text = "*";
            // 
            // btnLoadVehiclePhoto
            // 
            this.btnLoadVehiclePhoto.Location = new System.Drawing.Point(394, 128);
            this.btnLoadVehiclePhoto.Name = "btnLoadVehiclePhoto";
            this.btnLoadVehiclePhoto.Size = new System.Drawing.Size(75, 23);
            this.btnLoadVehiclePhoto.TabIndex = 20;
            this.btnLoadVehiclePhoto.Text = "查看";
            this.btnLoadVehiclePhoto.UseVisualStyleBackColor = true;
            this.btnLoadVehiclePhoto.Click += new System.EventHandler(this.btnLoadVehiclePhoto_Click);
            // 
            // btnUploadVehicle
            // 
            this.btnUploadVehicle.Location = new System.Drawing.Point(471, 128);
            this.btnUploadVehicle.Name = "btnUploadVehicle";
            this.btnUploadVehicle.Size = new System.Drawing.Size(75, 23);
            this.btnUploadVehicle.TabIndex = 20;
            this.btnUploadVehicle.Text = "上传图片";
            this.btnUploadVehicle.UseVisualStyleBackColor = true;
            this.btnUploadVehicle.Click += new System.EventHandler(this.btnUploadVehicle_Click);
            // 
            // btnUploadLicense
            // 
            this.btnUploadLicense.Location = new System.Drawing.Point(471, 101);
            this.btnUploadLicense.Name = "btnUploadLicense";
            this.btnUploadLicense.Size = new System.Drawing.Size(75, 23);
            this.btnUploadLicense.TabIndex = 20;
            this.btnUploadLicense.Text = "上传图片";
            this.btnUploadLicense.UseVisualStyleBackColor = true;
            this.btnUploadLicense.Click += new System.EventHandler(this.btnUploadLicense_Click);
            // 
            // btnLoadLicense
            // 
            this.btnLoadLicense.Location = new System.Drawing.Point(394, 101);
            this.btnLoadLicense.Name = "btnLoadLicense";
            this.btnLoadLicense.Size = new System.Drawing.Size(75, 23);
            this.btnLoadLicense.TabIndex = 20;
            this.btnLoadLicense.Text = "查看";
            this.btnLoadLicense.UseVisualStyleBackColor = true;
            this.btnLoadLicense.Click += new System.EventHandler(this.btnLoadLicense_Click);
            // 
            // btnAddVehilceType
            // 
            this.btnAddVehilceType.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAddVehilceType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddVehilceType.Location = new System.Drawing.Point(209, 46);
            this.btnAddVehilceType.Name = "btnAddVehilceType";
            this.btnAddVehilceType.Size = new System.Drawing.Size(44, 23);
            this.btnAddVehilceType.TabIndex = 19;
            this.btnAddVehilceType.Text = "增加";
            this.btnAddVehilceType.UseVisualStyleBackColor = false;
            this.btnAddVehilceType.Click += new System.EventHandler(this.btnAddVehilceType_Click);
            // 
            // chkIFBelongsto
            // 
            this.chkIFBelongsto.AutoSize = true;
            this.chkIFBelongsto.Location = new System.Drawing.Point(107, 75);
            this.chkIFBelongsto.Name = "chkIFBelongsto";
            this.chkIFBelongsto.Size = new System.Drawing.Size(72, 16);
            this.chkIFBelongsto.TabIndex = 18;
            this.chkIFBelongsto.Text = "属于公司";
            this.chkIFBelongsto.UseVisualStyleBackColor = true;
            this.chkIFBelongsto.CheckedChanged += new System.EventHandler(this.chkIFBelongsto_CheckedChanged);
            // 
            // cbxVehicleTypeId
            // 
            this.cbxVehicleTypeId.FormattingEnabled = true;
            this.cbxVehicleTypeId.Location = new System.Drawing.Point(86, 47);
            this.cbxVehicleTypeId.Name = "cbxVehicleTypeId";
            this.cbxVehicleTypeId.Size = new System.Drawing.Size(116, 20);
            this.cbxVehicleTypeId.TabIndex = 17;
            this.cbxVehicleTypeId.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbxVehicleTypeId_MouseClick);
            // 
            // lblBelong
            // 
            this.lblBelong.AutoSize = true;
            this.lblBelong.Location = new System.Drawing.Point(335, 78);
            this.lblBelong.Name = "lblBelong";
            this.lblBelong.Size = new System.Drawing.Size(53, 12);
            this.lblBelong.TabIndex = 14;
            this.lblBelong.Text = "所属公司";
            // 
            // FrmVehicleAddOrUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 220);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSave);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmVehicleAddOrUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "车辆信息";
            this.Load += new System.EventHandler(this.FrmVehicleAddOrUpdate_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtVehicleName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtVehicleNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLoadCapacity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbxVehicleTypeId;
        private System.Windows.Forms.CheckBox chkIFBelongsto;
        private System.Windows.Forms.Button btnAddVehilceType;
        private System.Windows.Forms.Button btnLoadVehiclePhoto;
        private System.Windows.Forms.Button btnLoadLicense;
        private System.Windows.Forms.Button btnUploadVehicle;
        private System.Windows.Forms.Button btnUploadLicense;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbxCompanyID;
        private System.Windows.Forms.Label lblBelong;
        private System.Windows.Forms.Label lblVehiclePhoto;
        private System.Windows.Forms.Label lblLicensePhoto;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
    }
}