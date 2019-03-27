namespace LogisPrj
{
    partial class FrmTransferManager
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTransferManager));
            this.dgvDelivery = new System.Windows.Forms.DataGridView();
            this.btnEnd = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TSMenuRefueling = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMenuRoad = new System.Windows.Forms.ToolStripMenuItem();
            this.TSAddNewOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnClientOrder = new System.Windows.Forms.Button();
            this.cbxVehicleId = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxDriver = new System.Windows.Forms.ComboBox();
            this.label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDeliveryId = new System.Windows.Forms.TextBox();
            this.colModify = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colEnd = new System.Windows.Forms.DataGridViewLinkColumn();
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
            this.colRecorderName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIfEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIfEndName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIfChargeback = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIfChargebackName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAuditor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colstrCarCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGoPage = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.lbltotalCount = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPage = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lbltotalPage = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblPre = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnLastPage = new System.Windows.Forms.Button();
            this.btnNextPage = new System.Windows.Forms.Button();
            this.btnFirstPage = new System.Windows.Forms.Button();
            this.btnPrePage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDelivery)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
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
            this.colModify,
            this.colEnd,
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
            this.colRecorderName,
            this.colIfEnd,
            this.colIfEndName,
            this.colIfChargeback,
            this.colIfChargebackName,
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
            this.dgvDelivery.Location = new System.Drawing.Point(4, 41);
            this.dgvDelivery.MultiSelect = false;
            this.dgvDelivery.Name = "dgvDelivery";
            this.dgvDelivery.ReadOnly = true;
            this.dgvDelivery.RowHeadersVisible = false;
            this.dgvDelivery.RowTemplate.Height = 23;
            this.dgvDelivery.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDelivery.Size = new System.Drawing.Size(1290, 524);
            this.dgvDelivery.TabIndex = 6;
            this.dgvDelivery.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDelivery_CellContentClick);
            this.dgvDelivery.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDelivery_CellMouseDown);
            this.dgvDelivery.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvDelivery_CellPainting);
            // 
            // btnEnd
            // 
            this.btnEnd.BackColor = System.Drawing.Color.Peru;
            this.btnEnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnd.Location = new System.Drawing.Point(640, 12);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(75, 23);
            this.btnEnd.TabIndex = 9;
            this.btnEnd.Text = "完结";
            this.btnEnd.UseVisualStyleBackColor = false;
            this.btnEnd.Visible = false;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Gold;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(557, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMenuRefueling,
            this.TSMenuRoad,
            this.TSAddNewOrder});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(137, 70);
            // 
            // TSMenuRefueling
            // 
            this.TSMenuRefueling.Name = "TSMenuRefueling";
            this.TSMenuRefueling.Size = new System.Drawing.Size(136, 22);
            this.TSMenuRefueling.Text = "加油费管理";
            this.TSMenuRefueling.Click += new System.EventHandler(this.TSMenuRefueling_Click);
            // 
            // TSMenuRoad
            // 
            this.TSMenuRoad.Name = "TSMenuRoad";
            this.TSMenuRoad.Size = new System.Drawing.Size(136, 22);
            this.TSMenuRoad.Text = "过路费管理";
            this.TSMenuRoad.Click += new System.EventHandler(this.TSMenuRoad_Click);
            // 
            // TSAddNewOrder
            // 
            this.TSAddNewOrder.Name = "TSAddNewOrder";
            this.TSAddNewOrder.Size = new System.Drawing.Size(136, 22);
            this.TSAddNewOrder.Text = "追加新订单";
            this.TSAddNewOrder.Visible = false;
            this.TSAddNewOrder.Click += new System.EventHandler(this.TSAddNewOrder_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(1213, 7);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnClientOrder
            // 
            this.btnClientOrder.BackColor = System.Drawing.Color.Peru;
            this.btnClientOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientOrder.Location = new System.Drawing.Point(721, 12);
            this.btnClientOrder.Name = "btnClientOrder";
            this.btnClientOrder.Size = new System.Drawing.Size(75, 23);
            this.btnClientOrder.TabIndex = 9;
            this.btnClientOrder.Text = "客户下单";
            this.btnClientOrder.UseVisualStyleBackColor = false;
            this.btnClientOrder.Visible = false;
            this.btnClientOrder.Click += new System.EventHandler(this.btnClientOrder_Click);
            // 
            // cbxVehicleId
            // 
            this.cbxVehicleId.FormattingEnabled = true;
            this.cbxVehicleId.Location = new System.Drawing.Point(222, 14);
            this.cbxVehicleId.Name = "cbxVehicleId";
            this.cbxVehicleId.Size = new System.Drawing.Size(121, 20);
            this.cbxVehicleId.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 15;
            this.label2.Text = "车辆";
            // 
            // cbxDriver
            // 
            this.cbxDriver.FormattingEnabled = true;
            this.cbxDriver.Location = new System.Drawing.Point(421, 13);
            this.cbxDriver.Name = "cbxDriver";
            this.cbxDriver.Size = new System.Drawing.Size(121, 20);
            this.cbxDriver.TabIndex = 14;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(374, 18);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(41, 12);
            this.label.TabIndex = 15;
            this.label.Text = "驾驶员";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 16;
            this.label1.Text = "订单号";
            // 
            // txtDeliveryId
            // 
            this.txtDeliveryId.Location = new System.Drawing.Point(54, 13);
            this.txtDeliveryId.Name = "txtDeliveryId";
            this.txtDeliveryId.Size = new System.Drawing.Size(115, 21);
            this.txtDeliveryId.TabIndex = 17;
            // 
            // colModify
            // 
            this.colModify.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.NullValue = "修改";
            this.colModify.DefaultCellStyle = dataGridViewCellStyle3;
            this.colModify.FillWeight = 30F;
            this.colModify.HeaderText = "";
            this.colModify.Name = "colModify";
            this.colModify.ReadOnly = true;
            this.colModify.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colModify.Visible = false;
            this.colModify.Width = 5;
            // 
            // colEnd
            // 
            this.colEnd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle4.NullValue = "完结";
            this.colEnd.DefaultCellStyle = dataGridViewCellStyle4;
            this.colEnd.HeaderText = "完结";
            this.colEnd.Name = "colEnd";
            this.colEnd.ReadOnly = true;
            this.colEnd.Visible = false;
            this.colEnd.Width = 35;
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
            this.colVehicleNumber.DataPropertyName = "vehicleNumber";
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
            // colRecorderName
            // 
            this.colRecorderName.DataPropertyName = "RecorderName";
            this.colRecorderName.FillWeight = 30F;
            this.colRecorderName.HeaderText = "录单人";
            this.colRecorderName.Name = "colRecorderName";
            this.colRecorderName.ReadOnly = true;
            this.colRecorderName.Visible = false;
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
            // colIfChargeback
            // 
            this.colIfChargeback.DataPropertyName = "IfChargeback";
            this.colIfChargeback.FillWeight = 10F;
            this.colIfChargeback.HeaderText = "是否退单完结";
            this.colIfChargeback.Name = "colIfChargeback";
            this.colIfChargeback.ReadOnly = true;
            this.colIfChargeback.Visible = false;
            // 
            // colIfChargebackName
            // 
            this.colIfChargebackName.DataPropertyName = "IfChargebackName";
            this.colIfChargebackName.FillWeight = 15F;
            this.colIfChargebackName.HeaderText = "退单完结";
            this.colIfChargebackName.Name = "colIfChargebackName";
            this.colIfChargebackName.ReadOnly = true;
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
            // btnGoPage
            // 
            this.btnGoPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGoPage.FlatAppearance.BorderSize = 0;
            this.btnGoPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoPage.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnGoPage.Location = new System.Drawing.Point(400, 572);
            this.btnGoPage.Name = "btnGoPage";
            this.btnGoPage.Size = new System.Drawing.Size(32, 23);
            this.btnGoPage.TabIndex = 42;
            this.btnGoPage.Text = "GO";
            this.btnGoPage.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(503, 578);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(41, 12);
            this.label17.TabIndex = 41;
            this.label17.Text = "条记录";
            // 
            // lbltotalCount
            // 
            this.lbltotalCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbltotalCount.AutoSize = true;
            this.lbltotalCount.Location = new System.Drawing.Point(473, 578);
            this.lbltotalCount.Name = "lbltotalCount";
            this.lbltotalCount.Size = new System.Drawing.Size(11, 12);
            this.lbltotalCount.TabIndex = 40;
            this.lbltotalCount.Text = "N";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(380, 578);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(17, 12);
            this.label14.TabIndex = 39;
            this.label14.Text = "页";
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(459, 578);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(17, 12);
            this.label15.TabIndex = 38;
            this.label15.Text = "共";
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label19.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label19.Location = new System.Drawing.Point(286, 576);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(16, 16);
            this.label19.TabIndex = 37;
            this.label19.Text = "|";
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label18.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label18.Location = new System.Drawing.Point(437, 576);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(16, 16);
            this.label18.TabIndex = 36;
            this.label18.Text = "|";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(314, 578);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 12);
            this.label9.TabIndex = 35;
            this.label9.Text = "第";
            // 
            // txtPage
            // 
            this.txtPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPage.Location = new System.Drawing.Point(334, 573);
            this.txtPage.Name = "txtPage";
            this.txtPage.Size = new System.Drawing.Size(41, 21);
            this.txtPage.TabIndex = 34;
            this.txtPage.Text = "1";
            this.txtPage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(142, 578);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(11, 12);
            this.label11.TabIndex = 33;
            this.label11.Text = "/";
            // 
            // lbltotalPage
            // 
            this.lbltotalPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbltotalPage.AutoSize = true;
            this.lbltotalPage.Location = new System.Drawing.Point(164, 578);
            this.lbltotalPage.Name = "lbltotalPage";
            this.lbltotalPage.Size = new System.Drawing.Size(11, 12);
            this.lbltotalPage.TabIndex = 32;
            this.lbltotalPage.Text = "1";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(185, 578);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(17, 12);
            this.label13.TabIndex = 30;
            this.label13.Text = "页";
            // 
            // lblPre
            // 
            this.lblPre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPre.AutoSize = true;
            this.lblPre.Location = new System.Drawing.Point(103, 578);
            this.lblPre.Name = "lblPre";
            this.lblPre.Size = new System.Drawing.Size(11, 12);
            this.lblPre.TabIndex = 31;
            this.lblPre.Text = "1";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(150, 578);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(17, 12);
            this.label12.TabIndex = 29;
            this.label12.Text = "共";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(125, 578);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 12);
            this.label10.TabIndex = 28;
            this.label10.Text = "页";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(89, 578);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 12);
            this.label8.TabIndex = 27;
            this.label8.Text = "第";
            // 
            // btnLastPage
            // 
            this.btnLastPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLastPage.BackColor = System.Drawing.Color.Transparent;
            this.btnLastPage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLastPage.BackgroundImage")));
            this.btnLastPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLastPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLastPage.Location = new System.Drawing.Point(235, 573);
            this.btnLastPage.Name = "btnLastPage";
            this.btnLastPage.Size = new System.Drawing.Size(29, 23);
            this.btnLastPage.TabIndex = 25;
            this.btnLastPage.UseVisualStyleBackColor = false;
            // 
            // btnNextPage
            // 
            this.btnNextPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNextPage.BackColor = System.Drawing.Color.Transparent;
            this.btnNextPage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNextPage.BackgroundImage")));
            this.btnNextPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNextPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextPage.Location = new System.Drawing.Point(202, 573);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(29, 23);
            this.btnNextPage.TabIndex = 24;
            this.btnNextPage.UseVisualStyleBackColor = false;
            // 
            // btnFirstPage
            // 
            this.btnFirstPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnFirstPage.BackColor = System.Drawing.Color.Transparent;
            this.btnFirstPage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFirstPage.BackgroundImage")));
            this.btnFirstPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFirstPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirstPage.Location = new System.Drawing.Point(19, 573);
            this.btnFirstPage.Name = "btnFirstPage";
            this.btnFirstPage.Size = new System.Drawing.Size(29, 23);
            this.btnFirstPage.TabIndex = 26;
            this.btnFirstPage.UseVisualStyleBackColor = false;
            // 
            // btnPrePage
            // 
            this.btnPrePage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPrePage.BackColor = System.Drawing.Color.Transparent;
            this.btnPrePage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPrePage.BackgroundImage")));
            this.btnPrePage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPrePage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrePage.Location = new System.Drawing.Point(54, 573);
            this.btnPrePage.Name = "btnPrePage";
            this.btnPrePage.Size = new System.Drawing.Size(29, 23);
            this.btnPrePage.TabIndex = 23;
            this.btnPrePage.UseVisualStyleBackColor = false;
            // 
            // FrmTransferManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1299, 603);
            this.Controls.Add(this.btnGoPage);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.lbltotalCount);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtPage);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lbltotalPage);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblPre);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnLastPage);
            this.Controls.Add(this.btnNextPage);
            this.Controls.Add(this.btnFirstPage);
            this.Controls.Add(this.btnPrePage);
            this.Controls.Add(this.txtDeliveryId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxDriver);
            this.Controls.Add(this.cbxVehicleId);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnClientOrder);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.dgvDelivery);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTransferManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "运输管理";
            this.Load += new System.EventHandler(this.FrmTransport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDelivery)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvDelivery;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TSMenuRefueling;
        private System.Windows.Forms.ToolStripMenuItem TSMenuRoad;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnClientOrder;
        private System.Windows.Forms.ToolStripMenuItem TSAddNewOrder;
        private System.Windows.Forms.ComboBox cbxVehicleId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxDriver;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDeliveryId;
        private System.Windows.Forms.DataGridViewLinkColumn colModify;
        private System.Windows.Forms.DataGridViewLinkColumn colEnd;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn colRecorderName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIfEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIfEndName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIfChargeback;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIfChargebackName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAuditor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colstrCarCode;
        private System.Windows.Forms.Button btnGoPage;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lbltotalCount;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPage;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbltotalPage;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblPre;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnLastPage;
        private System.Windows.Forms.Button btnNextPage;
        private System.Windows.Forms.Button btnFirstPage;
        private System.Windows.Forms.Button btnPrePage;
    }
}