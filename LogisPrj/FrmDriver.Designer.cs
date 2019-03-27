namespace LogisPrj
{
    partial class FrmDriver
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDriver));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnLoad = new System.Windows.Forms.Button();
            this.cbxDriverType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvDriver = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDriverId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDriverName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDriverSex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFamilyAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIdNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDriverLicense = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLicenseType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDriverLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmergencyContact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmergencyMobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmergencyRelations = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDriverPhoto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCompanyId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDriver)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnLoad);
            this.splitContainer1.Panel1.Controls.Add(this.cbxDriverType);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.btnClose);
            this.splitContainer1.Panel1.Controls.Add(this.btnDel);
            this.splitContainer1.Panel1.Controls.Add(this.btnModify);
            this.splitContainer1.Panel1.Controls.Add(this.btnAdd);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvDriver);
            this.splitContainer1.Size = new System.Drawing.Size(1256, 535);
            this.splitContainer1.SplitterDistance = 65;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.Gold;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.Location = new System.Drawing.Point(187, 10);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 4;
            this.btnLoad.Text = "查询";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // cbxDriverType
            // 
            this.cbxDriverType.FormattingEnabled = true;
            this.cbxDriverType.Items.AddRange(new object[] {
            "全部",
            "正式",
            "临时",
            "离职"});
            this.cbxDriverType.Location = new System.Drawing.Point(59, 12);
            this.cbxDriverType.Name = "cbxDriverType";
            this.cbxDriverType.Size = new System.Drawing.Size(122, 20);
            this.cbxDriverType.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "请选择";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(1178, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.Red;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.Location = new System.Drawing.Point(164, 39);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 0;
            this.btnDel.Text = "删除";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Visible = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnModify
            // 
            this.btnModify.BackColor = System.Drawing.Color.Peru;
            this.btnModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModify.Location = new System.Drawing.Point(83, 39);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 23);
            this.btnModify.TabIndex = 0;
            this.btnModify.Text = "修改";
            this.btnModify.UseVisualStyleBackColor = false;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(2, 39);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "增加";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvDriver
            // 
            this.dgvDriver.AllowUserToAddRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            this.dgvDriver.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDriver.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDriver.BackgroundColor = System.Drawing.Color.White;
            this.dgvDriver.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDriver.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvDriver.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colDriverId,
            this.colDriverName,
            this.colDriverSex,
            this.colFamilyAddress,
            this.colMobile,
            this.colIdNumber,
            this.colDriverLicense,
            this.colLicenseType,
            this.colDriverLocation,
            this.colEmergencyContact,
            this.colEmergencyMobile,
            this.colEmergencyRelations,
            this.colDriverPhoto,
            this.colCompanyId,
            this.colType});
            this.dgvDriver.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDriver.Location = new System.Drawing.Point(0, 0);
            this.dgvDriver.Name = "dgvDriver";
            this.dgvDriver.ReadOnly = true;
            this.dgvDriver.RowHeadersVisible = false;
            this.dgvDriver.RowTemplate.Height = 23;
            this.dgvDriver.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDriver.Size = new System.Drawing.Size(1256, 466);
            this.dgvDriver.TabIndex = 0;
            this.dgvDriver.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDriver_CellClick);
            this.dgvDriver.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDriver_CellContentDoubleClick);
            this.dgvDriver.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDriver_CellDoubleClick);
            // 
            // colId
            // 
            this.colId.DataPropertyName = "Id";
            this.colId.HeaderText = "ID";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Visible = false;
            // 
            // colDriverId
            // 
            this.colDriverId.DataPropertyName = "DriverId";
            this.colDriverId.FillWeight = 30F;
            this.colDriverId.HeaderText = "驾驶员编号";
            this.colDriverId.Name = "colDriverId";
            this.colDriverId.ReadOnly = true;
            this.colDriverId.Visible = false;
            // 
            // colDriverName
            // 
            this.colDriverName.DataPropertyName = "DriverName";
            this.colDriverName.FillWeight = 20F;
            this.colDriverName.HeaderText = "姓名";
            this.colDriverName.Name = "colDriverName";
            this.colDriverName.ReadOnly = true;
            // 
            // colDriverSex
            // 
            this.colDriverSex.DataPropertyName = "DriverSex";
            this.colDriverSex.FillWeight = 10F;
            this.colDriverSex.HeaderText = "性别";
            this.colDriverSex.Name = "colDriverSex";
            this.colDriverSex.ReadOnly = true;
            // 
            // colFamilyAddress
            // 
            this.colFamilyAddress.DataPropertyName = "FamilyAddress";
            this.colFamilyAddress.FillWeight = 50F;
            this.colFamilyAddress.HeaderText = "家庭住址";
            this.colFamilyAddress.Name = "colFamilyAddress";
            this.colFamilyAddress.ReadOnly = true;
            // 
            // colMobile
            // 
            this.colMobile.DataPropertyName = "Mobile";
            this.colMobile.FillWeight = 40F;
            this.colMobile.HeaderText = "联系电话";
            this.colMobile.Name = "colMobile";
            this.colMobile.ReadOnly = true;
            // 
            // colIdNumber
            // 
            this.colIdNumber.DataPropertyName = "IdNumber";
            this.colIdNumber.FillWeight = 50F;
            this.colIdNumber.HeaderText = "身份证号码";
            this.colIdNumber.Name = "colIdNumber";
            this.colIdNumber.ReadOnly = true;
            this.colIdNumber.Visible = false;
            // 
            // colDriverLicense
            // 
            this.colDriverLicense.DataPropertyName = "DriverLicense";
            this.colDriverLicense.FillWeight = 50F;
            this.colDriverLicense.HeaderText = "驾照编号";
            this.colDriverLicense.Name = "colDriverLicense";
            this.colDriverLicense.ReadOnly = true;
            this.colDriverLicense.Visible = false;
            // 
            // colLicenseType
            // 
            this.colLicenseType.DataPropertyName = "LicenseType";
            this.colLicenseType.FillWeight = 30F;
            this.colLicenseType.HeaderText = "驾照类型";
            this.colLicenseType.Name = "colLicenseType";
            this.colLicenseType.ReadOnly = true;
            // 
            // colDriverLocation
            // 
            this.colDriverLocation.DataPropertyName = "DriverLocation";
            this.colDriverLocation.FillWeight = 30F;
            this.colDriverLocation.HeaderText = "所在地";
            this.colDriverLocation.Name = "colDriverLocation";
            this.colDriverLocation.ReadOnly = true;
            this.colDriverLocation.Visible = false;
            // 
            // colEmergencyContact
            // 
            this.colEmergencyContact.DataPropertyName = "EmergencyContact";
            this.colEmergencyContact.FillWeight = 30F;
            this.colEmergencyContact.HeaderText = "紧急联系人姓名";
            this.colEmergencyContact.Name = "colEmergencyContact";
            this.colEmergencyContact.ReadOnly = true;
            this.colEmergencyContact.Visible = false;
            // 
            // colEmergencyMobile
            // 
            this.colEmergencyMobile.DataPropertyName = "EmergencyMobile";
            this.colEmergencyMobile.FillWeight = 50F;
            this.colEmergencyMobile.HeaderText = "紧急联系人手机号码";
            this.colEmergencyMobile.Name = "colEmergencyMobile";
            this.colEmergencyMobile.ReadOnly = true;
            this.colEmergencyMobile.Visible = false;
            // 
            // colEmergencyRelations
            // 
            this.colEmergencyRelations.DataPropertyName = "EmergencyRelations";
            this.colEmergencyRelations.FillWeight = 30F;
            this.colEmergencyRelations.HeaderText = "紧急联系人关系";
            this.colEmergencyRelations.Name = "colEmergencyRelations";
            this.colEmergencyRelations.ReadOnly = true;
            this.colEmergencyRelations.Visible = false;
            // 
            // colDriverPhoto
            // 
            this.colDriverPhoto.DataPropertyName = "DriverPhoto";
            this.colDriverPhoto.FillWeight = 60F;
            this.colDriverPhoto.HeaderText = "驾照照片";
            this.colDriverPhoto.Name = "colDriverPhoto";
            this.colDriverPhoto.ReadOnly = true;
            this.colDriverPhoto.Visible = false;
            // 
            // colCompanyId
            // 
            this.colCompanyId.DataPropertyName = "CompanyId";
            this.colCompanyId.FillWeight = 30F;
            this.colCompanyId.HeaderText = "公司";
            this.colCompanyId.Name = "colCompanyId";
            this.colCompanyId.ReadOnly = true;
            this.colCompanyId.Visible = false;
            // 
            // colType
            // 
            this.colType.DataPropertyName = "Type";
            this.colType.FillWeight = 30F;
            this.colType.HeaderText = "类型";
            this.colType.Name = "colType";
            this.colType.ReadOnly = true;
            // 
            // FrmDriver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 535);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDriver";
            this.Text = "驾驶员信息表";
            this.Load += new System.EventHandler(this.FrmDriver_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDriver)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvDriver;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDriverId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDriverName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDriverSex;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFamilyAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDriverLicense;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLicenseType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDriverLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmergencyContact;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmergencyMobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmergencyRelations;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDriverPhoto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCompanyId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colType;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.ComboBox cbxDriverType;
        private System.Windows.Forms.Label label1;
    }
}