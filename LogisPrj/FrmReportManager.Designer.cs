namespace LogisPrj
{
    partial class FrmReportManager
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReportManager));
            this.label2 = new System.Windows.Forms.Label();
            this.dTDeliveryTime = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxVehicleId = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxDriverId = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvDelivery = new System.Windows.Forms.DataGridView();
            this.colDetail = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDeliveryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVehicleId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVehicleNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDeviceId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClientId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDriver1Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDriver1Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDriver2Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDriver2Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOrigin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBeginTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMinTempThreshold = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaxTempThreshold = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMinHumThreshold = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaxHumThreshold = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRecordId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIfEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIfEndName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAuditor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colstrCarCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDelivery)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "日期";
            // 
            // dTDeliveryTime
            // 
            this.dTDeliveryTime.Location = new System.Drawing.Point(47, 9);
            this.dTDeliveryTime.Name = "dTDeliveryTime";
            this.dTDeliveryTime.Size = new System.Drawing.Size(135, 21);
            this.dTDeliveryTime.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(271, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "车辆";
            // 
            // cbxVehicleId
            // 
            this.cbxVehicleId.FormattingEnabled = true;
            this.cbxVehicleId.Location = new System.Drawing.Point(306, 9);
            this.cbxVehicleId.Name = "cbxVehicleId";
            this.cbxVehicleId.Size = new System.Drawing.Size(121, 20);
            this.cbxVehicleId.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(442, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "驾驶员";
            // 
            // cbxDriverId
            // 
            this.cbxDriverId.FormattingEnabled = true;
            this.cbxDriverId.Location = new System.Drawing.Point(489, 9);
            this.cbxDriverId.Name = "cbxDriverId";
            this.cbxDriverId.Size = new System.Drawing.Size(102, 20);
            this.cbxDriverId.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Gold;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(597, 7);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(1103, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvDelivery
            // 
            this.dgvDelivery.AllowUserToAddRows = false;
            this.dgvDelivery.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.AliceBlue;
            this.dgvDelivery.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDelivery.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDelivery.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDelivery.BackgroundColor = System.Drawing.Color.White;
            this.dgvDelivery.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDelivery.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDelivery.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDelivery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDelivery.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDetail,
            this.colId,
            this.colDeliveryId,
            this.colVehicleId,
            this.colVehicleNumber,
            this.colDeviceId,
            this.colClientId,
            this.colClientName,
            this.colDriver1Id,
            this.colDriver1Name,
            this.colDriver2Id,
            this.colDriver2Name,
            this.colOrigin,
            this.colBeginTime,
            this.colMinTempThreshold,
            this.colMaxTempThreshold,
            this.colMinHumThreshold,
            this.colMaxHumThreshold,
            this.colRecordId,
            this.colIfEnd,
            this.colIfEndName,
            this.colAuditor,
            this.colstrCarCode});
            this.dgvDelivery.Location = new System.Drawing.Point(6, 39);
            this.dgvDelivery.MultiSelect = false;
            this.dgvDelivery.Name = "dgvDelivery";
            this.dgvDelivery.ReadOnly = true;
            this.dgvDelivery.RowHeadersVisible = false;
            this.dgvDelivery.RowTemplate.Height = 23;
            this.dgvDelivery.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDelivery.Size = new System.Drawing.Size(1172, 483);
            this.dgvDelivery.TabIndex = 7;
            this.dgvDelivery.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDelivery_CellContentClick);
            // 
            // colDetail
            // 
            this.colDetail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.NullValue = "打印报表";
            this.colDetail.DefaultCellStyle = dataGridViewCellStyle6;
            this.colDetail.FillWeight = 30F;
            this.colDetail.HeaderText = "";
            this.colDetail.Name = "colDetail";
            this.colDetail.ReadOnly = true;
            this.colDetail.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colDetail.Width = 5;
            // 
            // colId
            // 
            this.colId.DataPropertyName = "Id";
            this.colId.HeaderText = "ID";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colId.Visible = false;
            // 
            // colDeliveryId
            // 
            this.colDeliveryId.DataPropertyName = "DeliveryId";
            this.colDeliveryId.FillWeight = 30F;
            this.colDeliveryId.HeaderText = "配送编号";
            this.colDeliveryId.Name = "colDeliveryId";
            this.colDeliveryId.ReadOnly = true;
            // 
            // colVehicleId
            // 
            this.colVehicleId.DataPropertyName = "VehicleId";
            this.colVehicleId.FillWeight = 30F;
            this.colVehicleId.HeaderText = "车辆编号";
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
            // colDeviceId
            // 
            this.colDeviceId.DataPropertyName = "DeviceId";
            this.colDeviceId.HeaderText = "设备编号";
            this.colDeviceId.Name = "colDeviceId";
            this.colDeviceId.ReadOnly = true;
            this.colDeviceId.Visible = false;
            // 
            // colClientId
            // 
            this.colClientId.DataPropertyName = "ClientId";
            this.colClientId.HeaderText = "客户编号";
            this.colClientId.Name = "colClientId";
            this.colClientId.ReadOnly = true;
            this.colClientId.Visible = false;
            // 
            // colClientName
            // 
            this.colClientName.DataPropertyName = "ClientName";
            this.colClientName.FillWeight = 30F;
            this.colClientName.HeaderText = "客户姓名";
            this.colClientName.Name = "colClientName";
            this.colClientName.ReadOnly = true;
            this.colClientName.Visible = false;
            // 
            // colDriver1Id
            // 
            this.colDriver1Id.DataPropertyName = "Driver1Id";
            this.colDriver1Id.FillWeight = 30F;
            this.colDriver1Id.HeaderText = "驾驶员1编号";
            this.colDriver1Id.Name = "colDriver1Id";
            this.colDriver1Id.ReadOnly = true;
            this.colDriver1Id.Visible = false;
            // 
            // colDriver1Name
            // 
            this.colDriver1Name.DataPropertyName = "Driver1Name";
            this.colDriver1Name.FillWeight = 30F;
            this.colDriver1Name.HeaderText = "驾驶员1";
            this.colDriver1Name.Name = "colDriver1Name";
            this.colDriver1Name.ReadOnly = true;
            // 
            // colDriver2Id
            // 
            this.colDriver2Id.DataPropertyName = "Driver2Id";
            this.colDriver2Id.FillWeight = 30F;
            this.colDriver2Id.HeaderText = "驾驶员2编号";
            this.colDriver2Id.Name = "colDriver2Id";
            this.colDriver2Id.ReadOnly = true;
            this.colDriver2Id.Visible = false;
            // 
            // colDriver2Name
            // 
            this.colDriver2Name.DataPropertyName = "Driver2Name";
            this.colDriver2Name.FillWeight = 30F;
            this.colDriver2Name.HeaderText = "驾驶员2";
            this.colDriver2Name.Name = "colDriver2Name";
            this.colDriver2Name.ReadOnly = true;
            // 
            // colOrigin
            // 
            this.colOrigin.DataPropertyName = "Origin";
            this.colOrigin.FillWeight = 50F;
            this.colOrigin.HeaderText = "起点";
            this.colOrigin.Name = "colOrigin";
            this.colOrigin.ReadOnly = true;
            this.colOrigin.Visible = false;
            // 
            // colBeginTime
            // 
            this.colBeginTime.DataPropertyName = "BeginTime";
            this.colBeginTime.FillWeight = 40F;
            this.colBeginTime.HeaderText = "起点时间";
            this.colBeginTime.Name = "colBeginTime";
            this.colBeginTime.ReadOnly = true;
            this.colBeginTime.Visible = false;
            // 
            // colMinTempThreshold
            // 
            this.colMinTempThreshold.DataPropertyName = "MinTempThreshold";
            this.colMinTempThreshold.HeaderText = "温度最小阈值";
            this.colMinTempThreshold.Name = "colMinTempThreshold";
            this.colMinTempThreshold.ReadOnly = true;
            this.colMinTempThreshold.Visible = false;
            // 
            // colMaxTempThreshold
            // 
            this.colMaxTempThreshold.DataPropertyName = "MaxTempThreshold";
            this.colMaxTempThreshold.HeaderText = "温度最大阈值";
            this.colMaxTempThreshold.Name = "colMaxTempThreshold";
            this.colMaxTempThreshold.ReadOnly = true;
            this.colMaxTempThreshold.Visible = false;
            // 
            // colMinHumThreshold
            // 
            this.colMinHumThreshold.DataPropertyName = "MinHumThreshold";
            this.colMinHumThreshold.HeaderText = "湿度最小阈值";
            this.colMinHumThreshold.Name = "colMinHumThreshold";
            this.colMinHumThreshold.ReadOnly = true;
            this.colMinHumThreshold.Visible = false;
            // 
            // colMaxHumThreshold
            // 
            this.colMaxHumThreshold.DataPropertyName = "MaxHumThreshold";
            this.colMaxHumThreshold.HeaderText = "湿度最大阈值";
            this.colMaxHumThreshold.Name = "colMaxHumThreshold";
            this.colMaxHumThreshold.ReadOnly = true;
            this.colMaxHumThreshold.Visible = false;
            // 
            // colRecordId
            // 
            this.colRecordId.DataPropertyName = "RecordId";
            this.colRecordId.FillWeight = 30F;
            this.colRecordId.HeaderText = "信息录入人ID";
            this.colRecordId.Name = "colRecordId";
            this.colRecordId.ReadOnly = true;
            this.colRecordId.Visible = false;
            // 
            // colIfEnd
            // 
            this.colIfEnd.DataPropertyName = "IfEnd";
            this.colIfEnd.FillWeight = 10F;
            this.colIfEnd.HeaderText = "是否完结";
            this.colIfEnd.Name = "colIfEnd";
            this.colIfEnd.ReadOnly = true;
            this.colIfEnd.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colIfEnd.Visible = false;
            // 
            // colIfEndName
            // 
            this.colIfEndName.DataPropertyName = "IfEndName";
            this.colIfEndName.FillWeight = 20F;
            this.colIfEndName.HeaderText = "完结";
            this.colIfEndName.Name = "colIfEndName";
            this.colIfEndName.ReadOnly = true;
            // 
            // colAuditor
            // 
            this.colAuditor.DataPropertyName = "Auditor";
            this.colAuditor.FillWeight = 30F;
            this.colAuditor.HeaderText = "审核完结人";
            this.colAuditor.Name = "colAuditor";
            this.colAuditor.ReadOnly = true;
            this.colAuditor.ToolTipText = "查看";
            // 
            // colstrCarCode
            // 
            this.colstrCarCode.DataPropertyName = "strCarCode";
            this.colstrCarCode.HeaderText = "strCarCode";
            this.colstrCarCode.Name = "colstrCarCode";
            this.colstrCarCode.ReadOnly = true;
            this.colstrCarCode.Visible = false;
            // 
            // FrmReportManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 526);
            this.Controls.Add(this.dgvDelivery);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cbxDriverId);
            this.Controls.Add(this.cbxVehicleId);
            this.Controls.Add(this.dTDeliveryTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmReportManager";
            this.Text = "报表管理";
            this.Load += new System.EventHandler(this.FrmReportManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDelivery)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dTDeliveryTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxVehicleId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxDriverId;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvDelivery;
        private System.Windows.Forms.DataGridViewButtonColumn colDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDeliveryId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVehicleId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVehicleNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDeviceId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClientId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDriver1Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDriver1Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDriver2Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDriver2Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrigin;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBeginTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMinTempThreshold;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaxTempThreshold;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMinHumThreshold;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaxHumThreshold;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRecordId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIfEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIfEndName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAuditor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colstrCarCode;
    }
}