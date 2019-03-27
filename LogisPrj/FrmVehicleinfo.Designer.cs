namespace LogisPrj
{
    partial class FrmVehicleinfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVehicleinfo));
            this.btnDel = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvVehicle = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVehicleId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVehicleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVehicleNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCompanyId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVehicleType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVehicleTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLoadCapacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLicensePhoto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVehiclePhoto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIfBelongtoName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIFBelongsto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnLoad = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxVehicleStatus = new System.Windows.Forms.ComboBox();
            this.btnTempVehicle = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.Red;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.Location = new System.Drawing.Point(251, 35);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 3;
            this.btnDel.Text = "删除";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Visible = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnModify
            // 
            this.btnModify.BackColor = System.Drawing.Color.Peru;
            this.btnModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModify.Location = new System.Drawing.Point(171, 35);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 23);
            this.btnModify.TabIndex = 2;
            this.btnModify.Text = "修改";
            this.btnModify.UseVisualStyleBackColor = false;
            this.btnModify.Visible = false;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(91, 35);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "增加";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvVehicle
            // 
            this.dgvVehicle.AllowUserToAddRows = false;
            this.dgvVehicle.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            this.dgvVehicle.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvVehicle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVehicle.BackgroundColor = System.Drawing.Color.White;
            this.dgvVehicle.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvVehicle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehicle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colVehicleId,
            this.colVehicleName,
            this.colVehicleNumber,
            this.colCompanyId,
            this.colVehicleType,
            this.colVehicleTypeName,
            this.colLoadCapacity,
            this.colLicensePhoto,
            this.colVehiclePhoto,
            this.colIfBelongtoName,
            this.colIFBelongsto});
            this.dgvVehicle.DataMember = "vehicleinfo";
            this.dgvVehicle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVehicle.Location = new System.Drawing.Point(0, 0);
            this.dgvVehicle.Name = "dgvVehicle";
            this.dgvVehicle.ReadOnly = true;
            this.dgvVehicle.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvVehicle.RowHeadersVisible = false;
            this.dgvVehicle.RowTemplate.Height = 23;
            this.dgvVehicle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVehicle.Size = new System.Drawing.Size(1183, 560);
            this.dgvVehicle.TabIndex = 0;
            this.dgvVehicle.VirtualMode = true;
            this.dgvVehicle.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dgvVehicle.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVehicle_CellDoubleClick);
            // 
            // colId
            // 
            this.colId.DataPropertyName = "Id";
            this.colId.HeaderText = "Id";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Visible = false;
            // 
            // colVehicleId
            // 
            this.colVehicleId.DataPropertyName = "VehicleId";
            this.colVehicleId.HeaderText = "车辆编号";
            this.colVehicleId.Name = "colVehicleId";
            this.colVehicleId.ReadOnly = true;
            this.colVehicleId.Visible = false;
            // 
            // colVehicleName
            // 
            this.colVehicleName.DataPropertyName = "VehicleName";
            this.colVehicleName.FillWeight = 20F;
            this.colVehicleName.HeaderText = "车辆名称";
            this.colVehicleName.Name = "colVehicleName";
            this.colVehicleName.ReadOnly = true;
            this.colVehicleName.Visible = false;
            // 
            // colVehicleNumber
            // 
            this.colVehicleNumber.DataPropertyName = "VehicleNumber";
            this.colVehicleNumber.FillWeight = 30F;
            this.colVehicleNumber.HeaderText = "车牌号";
            this.colVehicleNumber.Name = "colVehicleNumber";
            this.colVehicleNumber.ReadOnly = true;
            // 
            // colCompanyId
            // 
            this.colCompanyId.DataPropertyName = "CompanyId";
            this.colCompanyId.FillWeight = 30F;
            this.colCompanyId.HeaderText = "公司编号";
            this.colCompanyId.Name = "colCompanyId";
            this.colCompanyId.ReadOnly = true;
            this.colCompanyId.Visible = false;
            // 
            // colVehicleType
            // 
            this.colVehicleType.DataPropertyName = "VehicleType";
            this.colVehicleType.FillWeight = 40F;
            this.colVehicleType.HeaderText = "车辆类型编号";
            this.colVehicleType.Name = "colVehicleType";
            this.colVehicleType.ReadOnly = true;
            this.colVehicleType.Visible = false;
            // 
            // colVehicleTypeName
            // 
            this.colVehicleTypeName.DataPropertyName = "vehicleTypeName";
            this.colVehicleTypeName.FillWeight = 30F;
            this.colVehicleTypeName.HeaderText = "车辆类型";
            this.colVehicleTypeName.Name = "colVehicleTypeName";
            this.colVehicleTypeName.ReadOnly = true;
            // 
            // colLoadCapacity
            // 
            this.colLoadCapacity.DataPropertyName = "LoadCapacity";
            this.colLoadCapacity.FillWeight = 20F;
            this.colLoadCapacity.HeaderText = "载重量";
            this.colLoadCapacity.Name = "colLoadCapacity";
            this.colLoadCapacity.ReadOnly = true;
            // 
            // colLicensePhoto
            // 
            this.colLicensePhoto.DataPropertyName = "LicensePhoto";
            this.colLicensePhoto.FillWeight = 50F;
            this.colLicensePhoto.HeaderText = "行驶证照片";
            this.colLicensePhoto.Name = "colLicensePhoto";
            this.colLicensePhoto.ReadOnly = true;
            this.colLicensePhoto.Visible = false;
            // 
            // colVehiclePhoto
            // 
            this.colVehiclePhoto.DataPropertyName = "VehiclePhoto";
            this.colVehiclePhoto.FillWeight = 50F;
            this.colVehiclePhoto.HeaderText = "车辆照片";
            this.colVehiclePhoto.Name = "colVehiclePhoto";
            this.colVehiclePhoto.ReadOnly = true;
            this.colVehiclePhoto.Visible = false;
            // 
            // colIfBelongtoName
            // 
            this.colIfBelongtoName.DataPropertyName = "IsBelongstoName";
            this.colIfBelongtoName.FillWeight = 10F;
            this.colIfBelongtoName.HeaderText = "隶属于公司";
            this.colIfBelongtoName.Name = "colIfBelongtoName";
            this.colIfBelongtoName.ReadOnly = true;
            // 
            // colIFBelongsto
            // 
            this.colIFBelongsto.DataPropertyName = "IFBelongsto";
            this.colIFBelongsto.FillWeight = 20F;
            this.colIFBelongsto.HeaderText = "是否隶属于公司";
            this.colIFBelongsto.Name = "colIFBelongsto";
            this.colIFBelongsto.ReadOnly = true;
            this.colIFBelongsto.Visible = false;
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
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.cbxVehicleStatus);
            this.splitContainer1.Panel1.Controls.Add(this.btnTempVehicle);
            this.splitContainer1.Panel1.Controls.Add(this.btnClose);
            this.splitContainer1.Panel1.Controls.Add(this.btnDel);
            this.splitContainer1.Panel1.Controls.Add(this.btnAdd);
            this.splitContainer1.Panel1.Controls.Add(this.btnModify);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvVehicle);
            this.splitContainer1.Size = new System.Drawing.Size(1183, 629);
            this.splitContainer1.SplitterDistance = 65;
            this.splitContainer1.TabIndex = 4;
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.Gold;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.Location = new System.Drawing.Point(187, 4);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 8;
            this.btnLoad.Text = "查询";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "请选择";
            // 
            // cbxVehicleStatus
            // 
            this.cbxVehicleStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxVehicleStatus.FormattingEnabled = true;
            this.cbxVehicleStatus.Items.AddRange(new object[] {
            "全部",
            "公司车辆",
            "临时车辆"});
            this.cbxVehicleStatus.Location = new System.Drawing.Point(61, 5);
            this.cbxVehicleStatus.Name = "cbxVehicleStatus";
            this.cbxVehicleStatus.Size = new System.Drawing.Size(121, 20);
            this.cbxVehicleStatus.TabIndex = 6;
            // 
            // btnTempVehicle
            // 
            this.btnTempVehicle.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnTempVehicle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTempVehicle.Location = new System.Drawing.Point(11, 35);
            this.btnTempVehicle.Name = "btnTempVehicle";
            this.btnTempVehicle.Size = new System.Drawing.Size(75, 23);
            this.btnTempVehicle.TabIndex = 5;
            this.btnTempVehicle.Text = "临时车辆";
            this.btnTempVehicle.UseVisualStyleBackColor = false;
            this.btnTempVehicle.Click += new System.EventHandler(this.btnTempVehicle_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(1105, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FrmVehicleinfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(1183, 629);
            this.Controls.Add(this.splitContainer1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmVehicleinfo";
            this.Text = "车辆信息";
            this.Load += new System.EventHandler(this.FrmVehicleinfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicle)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvVehicle;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnTempVehicle;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxVehicleStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVehicleId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVehicleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVehicleNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCompanyId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVehicleType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVehicleTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLoadCapacity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLicensePhoto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVehiclePhoto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIfBelongtoName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIFBelongsto;
    }
}