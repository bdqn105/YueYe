namespace LogisPrj
{
    partial class FrmLocationMonitor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLocationMonitor));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDeliveryOrderId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDeliveryTime = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cbxClientId = new System.Windows.Forms.ComboBox();
            this.cbxDriverId = new System.Windows.Forms.ComboBox();
            this.cbxVehicleId = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvDelivery = new System.Windows.Forms.DataGridView();
            this.colDetail = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colTempLocation = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDeliveryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVehicleId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDeviceId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClientId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDriver1Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDriver2Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOrigin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBeginTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMinTempThreshold = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaxTempThreshold = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMinHumThreshold = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaxHumThreshold = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRecordId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIfEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAuditor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colstrCarCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClose = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDelivery)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDeliveryOrderId);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtDeliveryTime);
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Controls.Add(this.cbxClientId);
            this.groupBox2.Controls.Add(this.cbxDriverId);
            this.groupBox2.Controls.Add(this.cbxVehicleId);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(12, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(964, 43);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // txtDeliveryOrderId
            // 
            this.txtDeliveryOrderId.Location = new System.Drawing.Point(54, 15);
            this.txtDeliveryOrderId.Name = "txtDeliveryOrderId";
            this.txtDeliveryOrderId.Size = new System.Drawing.Size(137, 21);
            this.txtDeliveryOrderId.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "订单号";
            // 
            // txtDeliveryTime
            // 
            this.txtDeliveryTime.Location = new System.Drawing.Point(233, 15);
            this.txtDeliveryTime.Name = "txtDeliveryTime";
            this.txtDeliveryTime.Size = new System.Drawing.Size(138, 21);
            this.txtDeliveryTime.TabIndex = 0;
            this.txtDeliveryTime.Click += new System.EventHandler(this.txtDeliveryTime_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Gold;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(864, 16);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cbxClientId
            // 
            this.cbxClientId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxClientId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxClientId.FormattingEnabled = true;
            this.cbxClientId.Location = new System.Drawing.Point(742, 16);
            this.cbxClientId.Name = "cbxClientId";
            this.cbxClientId.Size = new System.Drawing.Size(97, 20);
            this.cbxClientId.TabIndex = 3;
            // 
            // cbxDriverId
            // 
            this.cbxDriverId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxDriverId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxDriverId.FormattingEnabled = true;
            this.cbxDriverId.Location = new System.Drawing.Point(587, 15);
            this.cbxDriverId.Name = "cbxDriverId";
            this.cbxDriverId.Size = new System.Drawing.Size(99, 20);
            this.cbxDriverId.TabIndex = 2;
            // 
            // cbxVehicleId
            // 
            this.cbxVehicleId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxVehicleId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxVehicleId.FormattingEnabled = true;
            this.cbxVehicleId.Location = new System.Drawing.Point(418, 16);
            this.cbxVehicleId.Name = "cbxVehicleId";
            this.cbxVehicleId.Size = new System.Drawing.Size(106, 20);
            this.cbxVehicleId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(198, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "日期";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(707, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "客户";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(540, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "驾驶员";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(383, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "车辆";
            // 
            // dgvDelivery
            // 
            this.dgvDelivery.AllowUserToAddRows = false;
            this.dgvDelivery.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            this.dgvDelivery.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDelivery.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDelivery.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDelivery.BackgroundColor = System.Drawing.Color.White;
            this.dgvDelivery.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDelivery.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDelivery.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDelivery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDelivery.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDetail,
            this.colTempLocation,
            this.colId,
            this.colDeliveryId,
            this.colVehicleId,
            this.colDeviceId,
            this.colClientId,
            this.colClientName,
            this.colDriver1Id,
            this.colDriver2Id,
            this.colOrigin,
            this.colBeginTime,
            this.colMinTempThreshold,
            this.colMaxTempThreshold,
            this.colMinHumThreshold,
            this.colMaxHumThreshold,
            this.colRecordId,
            this.colIfEnd,
            this.colAuditor,
            this.colstrCarCode});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDelivery.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDelivery.Location = new System.Drawing.Point(12, 51);
            this.dgvDelivery.MultiSelect = false;
            this.dgvDelivery.Name = "dgvDelivery";
            this.dgvDelivery.ReadOnly = true;
            this.dgvDelivery.RowHeadersVisible = false;
            this.dgvDelivery.RowTemplate.Height = 23;
            this.dgvDelivery.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDelivery.Size = new System.Drawing.Size(1210, 410);
            this.dgvDelivery.TabIndex = 6;
            this.dgvDelivery.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDelivery_CellContentClick);
            // 
            // colDetail
            // 
            this.colDetail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.NullValue = "位置监控";
            this.colDetail.DefaultCellStyle = dataGridViewCellStyle3;
            this.colDetail.FillWeight = 30F;
            this.colDetail.HeaderText = "";
            this.colDetail.Name = "colDetail";
            this.colDetail.ReadOnly = true;
            this.colDetail.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colDetail.Width = 5;
            // 
            // colTempLocation
            // 
            this.colTempLocation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle4.NullValue = "温湿度历史监控";
            this.colTempLocation.DefaultCellStyle = dataGridViewCellStyle4;
            this.colTempLocation.HeaderText = "";
            this.colTempLocation.Name = "colTempLocation";
            this.colTempLocation.ReadOnly = true;
            this.colTempLocation.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colTempLocation.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colTempLocation.Width = 19;
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
            this.colDriver1Id.HeaderText = "驾驶员1";
            this.colDriver1Id.Name = "colDriver1Id";
            this.colDriver1Id.ReadOnly = true;
            // 
            // colDriver2Id
            // 
            this.colDriver2Id.DataPropertyName = "Driver2Id";
            this.colDriver2Id.FillWeight = 30F;
            this.colDriver2Id.HeaderText = "驾驶员2";
            this.colDriver2Id.Name = "colDriver2Id";
            this.colDriver2Id.ReadOnly = true;
            // 
            // colOrigin
            // 
            this.colOrigin.DataPropertyName = "Origin";
            this.colOrigin.FillWeight = 50F;
            this.colOrigin.HeaderText = "起点";
            this.colOrigin.Name = "colOrigin";
            this.colOrigin.ReadOnly = true;
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
            // colAuditor
            // 
            this.colAuditor.DataPropertyName = "Auditor";
            this.colAuditor.FillWeight = 30F;
            this.colAuditor.HeaderText = "审核完结人ID";
            this.colAuditor.Name = "colAuditor";
            this.colAuditor.ReadOnly = true;
            this.colAuditor.ToolTipText = "查看";
            this.colAuditor.Visible = false;
            // 
            // colstrCarCode
            // 
            this.colstrCarCode.DataPropertyName = "strCarCode";
            this.colstrCarCode.HeaderText = "strCarCode";
            this.colstrCarCode.Name = "colstrCarCode";
            this.colstrCarCode.ReadOnly = true;
            this.colstrCarCode.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(1158, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(245, 42);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 8;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // FrmLocationMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 473);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvDelivery);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLocationMonitor";
            this.Text = "位置";
            this.Load += new System.EventHandler(this.FrmLocationMonitor_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDelivery)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbxClientId;
        private System.Windows.Forms.ComboBox cbxDriverId;
        private System.Windows.Forms.ComboBox cbxVehicleId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDelivery;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridViewLinkColumn colDetail;
        private System.Windows.Forms.DataGridViewLinkColumn colTempLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDeliveryId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVehicleId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDeviceId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClientId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDriver1Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDriver2Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrigin;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBeginTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMinTempThreshold;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaxTempThreshold;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMinHumThreshold;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaxHumThreshold;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRecordId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIfEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAuditor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colstrCarCode;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.TextBox txtDeliveryTime;
        private System.Windows.Forms.TextBox txtDeliveryOrderId;
        private System.Windows.Forms.Label label2;
    }
}