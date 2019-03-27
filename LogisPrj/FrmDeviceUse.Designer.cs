namespace LogisPrj
{
    partial class FrmDeviceUse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDeviceUse));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.chkIfBind = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBindTime = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.lblUnbindTime = new System.Windows.Forms.Label();
            this.dateUnbindTime = new System.Windows.Forms.DateTimePicker();
            this.dateBindTime = new System.Windows.Forms.DateTimePicker();
            this.cbxDeviceId = new System.Windows.Forms.ComboBox();
            this.cbxVehicleId = new System.Windows.Forms.ComboBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvDeviceUse = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDeviceId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDeviceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVehicleId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVehicleNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIfBindName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIfBind = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBindTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnbindTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colComment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeviceUse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.btnClose);
            this.splitContainer1.Panel1.Controls.Add(this.btnSearch);
            this.splitContainer1.Panel1.Controls.Add(this.btnModify);
            this.splitContainer1.Panel1.Controls.Add(this.btnAdd);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvDeviceUse);
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(993, 566);
            this.splitContainer1.SplitterDistance = 168;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label33);
            this.groupBox1.Controls.Add(this.chkIfBind);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblBindTime);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtComment);
            this.groupBox1.Controls.Add(this.lblUnbindTime);
            this.groupBox1.Controls.Add(this.dateUnbindTime);
            this.groupBox1.Controls.Add(this.dateBindTime);
            this.groupBox1.Controls.Add(this.cbxDeviceId);
            this.groupBox1.Controls.Add(this.cbxVehicleId);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Location = new System.Drawing.Point(3, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(851, 124);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Brown;
            this.label3.Location = new System.Drawing.Point(394, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 14);
            this.label3.TabIndex = 65;
            this.label3.Tag = "";
            this.label3.Text = "*";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.BackColor = System.Drawing.Color.Transparent;
            this.label33.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label33.ForeColor = System.Drawing.Color.Brown;
            this.label33.Location = new System.Drawing.Point(15, 18);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(14, 14);
            this.label33.TabIndex = 64;
            this.label33.Tag = "";
            this.label33.Text = "*";
            // 
            // chkIfBind
            // 
            this.chkIfBind.AutoSize = true;
            this.chkIfBind.Location = new System.Drawing.Point(63, 47);
            this.chkIfBind.Name = "chkIfBind";
            this.chkIfBind.Size = new System.Drawing.Size(72, 16);
            this.chkIfBind.TabIndex = 2;
            this.chkIfBind.Text = "是否绑定";
            this.chkIfBind.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkIfBind.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "设备";
            // 
            // lblBindTime
            // 
            this.lblBindTime.AutoSize = true;
            this.lblBindTime.Location = new System.Drawing.Point(157, 47);
            this.lblBindTime.Name = "lblBindTime";
            this.lblBindTime.Size = new System.Drawing.Size(53, 12);
            this.lblBindTime.TabIndex = 0;
            this.lblBindTime.Text = "绑定时间";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "备注";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(409, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "车辆";
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(63, 70);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(532, 43);
            this.txtComment.TabIndex = 5;
            // 
            // lblUnbindTime
            // 
            this.lblUnbindTime.AutoSize = true;
            this.lblUnbindTime.Location = new System.Drawing.Point(385, 49);
            this.lblUnbindTime.Name = "lblUnbindTime";
            this.lblUnbindTime.Size = new System.Drawing.Size(53, 12);
            this.lblUnbindTime.TabIndex = 0;
            this.lblUnbindTime.Text = "解绑时间";
            // 
            // dateUnbindTime
            // 
            this.dateUnbindTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateUnbindTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateUnbindTime.Location = new System.Drawing.Point(444, 44);
            this.dateUnbindTime.Name = "dateUnbindTime";
            this.dateUnbindTime.Size = new System.Drawing.Size(151, 21);
            this.dateUnbindTime.TabIndex = 4;
            this.dateUnbindTime.ValueChanged += new System.EventHandler(this.dateUnbindTime_ValueChanged);
            // 
            // dateBindTime
            // 
            this.dateBindTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateBindTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateBindTime.Location = new System.Drawing.Point(210, 42);
            this.dateBindTime.Name = "dateBindTime";
            this.dateBindTime.Size = new System.Drawing.Size(151, 21);
            this.dateBindTime.TabIndex = 3;
            this.dateBindTime.ValueChanged += new System.EventHandler(this.dateBindTime_ValueChanged);
            // 
            // cbxDeviceId
            // 
            this.cbxDeviceId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxDeviceId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxDeviceId.FormattingEnabled = true;
            this.cbxDeviceId.Location = new System.Drawing.Point(63, 14);
            this.cbxDeviceId.Name = "cbxDeviceId";
            this.cbxDeviceId.Size = new System.Drawing.Size(168, 20);
            this.cbxDeviceId.TabIndex = 0;
            this.cbxDeviceId.SelectedValueChanged += new System.EventHandler(this.cbxDeviceId_SelectedValueChanged);
            // 
            // cbxVehicleId
            // 
            this.cbxVehicleId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxVehicleId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxVehicleId.FormattingEnabled = true;
            this.cbxVehicleId.Location = new System.Drawing.Point(444, 14);
            this.cbxVehicleId.Name = "cbxVehicleId";
            this.cbxVehicleId.Size = new System.Drawing.Size(150, 20);
            this.cbxVehicleId.TabIndex = 1;
            this.cbxVehicleId.SelectedValueChanged += new System.EventHandler(this.cbxVehicleId_SelectedValueChanged);
            this.cbxVehicleId.Click += new System.EventHandler(this.cbxVehicleId_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(915, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(21, 136);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnModify
            // 
            this.btnModify.BackColor = System.Drawing.Color.Red;
            this.btnModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModify.Location = new System.Drawing.Point(183, 136);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 23);
            this.btnModify.TabIndex = 3;
            this.btnModify.Text = "解除绑定";
            this.btnModify.UseVisualStyleBackColor = false;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Peru;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(102, 136);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "绑定";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvDeviceUse
            // 
            this.dgvDeviceUse.AllowUserToAddRows = false;
            this.dgvDeviceUse.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            this.dgvDeviceUse.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDeviceUse.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDeviceUse.BackgroundColor = System.Drawing.Color.White;
            this.dgvDeviceUse.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDeviceUse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeviceUse.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colDeviceId,
            this.colDeviceName,
            this.colVehicleId,
            this.colVehicleNumber,
            this.colIfBindName,
            this.colIfBind,
            this.colBindTime,
            this.colUnbindTime,
            this.colComment});
            this.dgvDeviceUse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDeviceUse.GridColor = System.Drawing.SystemColors.Control;
            this.dgvDeviceUse.Location = new System.Drawing.Point(0, 0);
            this.dgvDeviceUse.Name = "dgvDeviceUse";
            this.dgvDeviceUse.ReadOnly = true;
            this.dgvDeviceUse.RowHeadersVisible = false;
            this.dgvDeviceUse.RowTemplate.Height = 23;
            this.dgvDeviceUse.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDeviceUse.Size = new System.Drawing.Size(993, 394);
            this.dgvDeviceUse.TabIndex = 1;
            this.dgvDeviceUse.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDeviceUse_CellClick);
            // 
            // colId
            // 
            this.colId.DataPropertyName = "Id";
            this.colId.HeaderText = "ID";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Visible = false;
            // 
            // colDeviceId
            // 
            this.colDeviceId.DataPropertyName = "DeviceId";
            this.colDeviceId.FillWeight = 40F;
            this.colDeviceId.HeaderText = "设备Id";
            this.colDeviceId.Name = "colDeviceId";
            this.colDeviceId.ReadOnly = true;
            this.colDeviceId.Visible = false;
            // 
            // colDeviceName
            // 
            this.colDeviceName.DataPropertyName = "DeviceName";
            this.colDeviceName.FillWeight = 30F;
            this.colDeviceName.HeaderText = "设备";
            this.colDeviceName.Name = "colDeviceName";
            this.colDeviceName.ReadOnly = true;
            // 
            // colVehicleId
            // 
            this.colVehicleId.DataPropertyName = "VehicleId";
            this.colVehicleId.FillWeight = 30F;
            this.colVehicleId.HeaderText = "车辆Id";
            this.colVehicleId.Name = "colVehicleId";
            this.colVehicleId.ReadOnly = true;
            this.colVehicleId.Visible = false;
            // 
            // colVehicleNumber
            // 
            this.colVehicleNumber.DataPropertyName = "VehicleNumber";
            this.colVehicleNumber.FillWeight = 30F;
            this.colVehicleNumber.HeaderText = "车辆";
            this.colVehicleNumber.Name = "colVehicleNumber";
            this.colVehicleNumber.ReadOnly = true;
            // 
            // colIfBindName
            // 
            this.colIfBindName.DataPropertyName = "IfBindName";
            this.colIfBindName.FillWeight = 20F;
            this.colIfBindName.HeaderText = "是否绑定";
            this.colIfBindName.Name = "colIfBindName";
            this.colIfBindName.ReadOnly = true;
            // 
            // colIfBind
            // 
            this.colIfBind.DataPropertyName = "IfBind";
            this.colIfBind.FillWeight = 20F;
            this.colIfBind.HeaderText = "是否绑定";
            this.colIfBind.Name = "colIfBind";
            this.colIfBind.ReadOnly = true;
            this.colIfBind.Visible = false;
            // 
            // colBindTime
            // 
            this.colBindTime.DataPropertyName = "BindTime";
            this.colBindTime.FillWeight = 50F;
            this.colBindTime.HeaderText = "绑定时间";
            this.colBindTime.Name = "colBindTime";
            this.colBindTime.ReadOnly = true;
            // 
            // colUnbindTime
            // 
            this.colUnbindTime.DataPropertyName = "UnbindTime";
            this.colUnbindTime.FillWeight = 50F;
            this.colUnbindTime.HeaderText = "解除绑定时间";
            this.colUnbindTime.Name = "colUnbindTime";
            this.colUnbindTime.ReadOnly = true;
            // 
            // colComment
            // 
            this.colComment.DataPropertyName = "Comment";
            this.colComment.FillWeight = 120F;
            this.colComment.HeaderText = "备注";
            this.colComment.Name = "colComment";
            this.colComment.ReadOnly = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(993, 394);
            this.dataGridView1.TabIndex = 0;
            // 
            // FrmDeviceUse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 566);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDeviceUse";
            this.Text = "设备使用情况";
            this.Load += new System.EventHandler(this.FrmDeviceUse_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeviceUse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dgvDeviceUse;
        private System.Windows.Forms.Label lblUnbindTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblBindTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.DateTimePicker dateUnbindTime;
        private System.Windows.Forms.DateTimePicker dateBindTime;
        private System.Windows.Forms.ComboBox cbxVehicleId;
        private System.Windows.Forms.ComboBox cbxDeviceId;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkIfBind;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDeviceId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDeviceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVehicleId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVehicleNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIfBindName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIfBind;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBindTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnbindTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colComment;
    }
}