namespace LogisPrj
{
    partial class FrmTranferOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTranferOrder));
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDeliveryTimeStart = new System.Windows.Forms.TextBox();
            this.cbxClient = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtInvoiceId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxSelect = new System.Windows.Forms.ComboBox();
            this.txtDeliveryOrderId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSourTransId = new System.Windows.Forms.TextBox();
            this.txtDeliveryTimeEnd = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.dgvOrderList = new System.Windows.Forms.DataGridView();
            this.colCbxDelete = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colDelete = new System.Windows.Forms.DataGridViewLinkColumn();
            this.coluId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDeliveryorderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDeliveryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClientId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSourTransType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSourTransId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAirWaybill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOrigin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBeginTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDestination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLongitude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLatitude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPredictDeliveryTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDeliveryTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSigner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTelephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIsBackFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReceivable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIsDeliver = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIsdeliveryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPaymentMethod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotalFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIsEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIfEndName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTerminator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTerminatorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIsChecked = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIfCheckedName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coldeliveryStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRecorderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRecorderName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAuditor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAuditorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLogisCompanyShortName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLogisCompanyID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monthCalendar2 = new System.Windows.Forms.MonthCalendar();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TSMenuOrderId = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMenuDelivery = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMenuFee = new System.Windows.Forms.ToolStripMenuItem();
            this.TSmenuProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMenuData = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.TSMenuReport = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMenuEnd = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.TSMenuMap = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMenuTemp = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMenuJam = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TSMenuException = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMenuPark = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMenuPath = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMenuTempManager = new System.Windows.Forms.ToolStripMenuItem();
            this.TSTempInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnRenewUpload = new System.Windows.Forms.Button();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.btnPrePage = new System.Windows.Forms.Button();
            this.btnNextPage = new System.Windows.Forms.Button();
            this.btnFirstPage = new System.Windows.Forms.Button();
            this.btnLastPage = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.lblPre = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lbltotalPage = new System.Windows.Forms.Label();
            this.txtPage = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnGoPage = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.lbltotalCount = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderList)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(223, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "配送日期";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(239, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "客户";
            // 
            // txtDeliveryTimeStart
            // 
            this.txtDeliveryTimeStart.Location = new System.Drawing.Point(275, 44);
            this.txtDeliveryTimeStart.Name = "txtDeliveryTimeStart";
            this.txtDeliveryTimeStart.Size = new System.Drawing.Size(133, 21);
            this.txtDeliveryTimeStart.TabIndex = 2;
            this.txtDeliveryTimeStart.Click += new System.EventHandler(this.txtDeliveryId_Click);
            this.txtDeliveryTimeStart.Leave += new System.EventHandler(this.txtDeliveryId_Leave);
            // 
            // cbxClient
            // 
            this.cbxClient.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxClient.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxClient.FormattingEnabled = true;
            this.cbxClient.Location = new System.Drawing.Point(274, 15);
            this.cbxClient.Name = "cbxClient";
            this.cbxClient.Size = new System.Drawing.Size(134, 20);
            this.cbxClient.TabIndex = 3;
            this.cbxClient.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbxClient_MouseClick);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Gold;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(639, 42);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtInvoiceId);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.cbxSelect);
            this.groupBox1.Controls.Add(this.cbxClient);
            this.groupBox1.Controls.Add(this.txtDeliveryOrderId);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtSourTransId);
            this.groupBox1.Controls.Add(this.txtDeliveryTimeEnd);
            this.groupBox1.Controls.Add(this.txtDeliveryTimeStart);
            this.groupBox1.Location = new System.Drawing.Point(12, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(831, 71);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(604, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 16;
            this.label6.Text = "单号";
            // 
            // txtInvoiceId
            // 
            this.txtInvoiceId.Location = new System.Drawing.Point(639, 16);
            this.txtInvoiceId.Name = "txtInvoiceId";
            this.txtInvoiceId.Size = new System.Drawing.Size(127, 21);
            this.txtInvoiceId.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 14;
            this.label3.Text = "订单号";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(410, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "至";
            // 
            // cbxSelect
            // 
            this.cbxSelect.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxSelect.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxSelect.FormattingEnabled = true;
            this.cbxSelect.Items.AddRange(new object[] {
            "全部",
            "中转",
            "未派送",
            "已审核",
            "待审核"});
            this.cbxSelect.Location = new System.Drawing.Point(49, 15);
            this.cbxSelect.Name = "cbxSelect";
            this.cbxSelect.Size = new System.Drawing.Size(117, 20);
            this.cbxSelect.TabIndex = 3;
            // 
            // txtDeliveryOrderId
            // 
            this.txtDeliveryOrderId.Location = new System.Drawing.Point(49, 44);
            this.txtDeliveryOrderId.Name = "txtDeliveryOrderId";
            this.txtDeliveryOrderId.Size = new System.Drawing.Size(134, 21);
            this.txtDeliveryOrderId.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 1;
            this.label7.Text = "查询";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(432, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "班次号";
            // 
            // txtSourTransId
            // 
            this.txtSourTransId.Location = new System.Drawing.Point(473, 15);
            this.txtSourTransId.Name = "txtSourTransId";
            this.txtSourTransId.Size = new System.Drawing.Size(88, 21);
            this.txtSourTransId.TabIndex = 2;
            // 
            // txtDeliveryTimeEnd
            // 
            this.txtDeliveryTimeEnd.Location = new System.Drawing.Point(428, 44);
            this.txtDeliveryTimeEnd.Name = "txtDeliveryTimeEnd";
            this.txtDeliveryTimeEnd.Size = new System.Drawing.Size(133, 21);
            this.txtDeliveryTimeEnd.TabIndex = 2;
            this.txtDeliveryTimeEnd.Click += new System.EventHandler(this.txtDeliveryTimeEnd_Click);
            this.txtDeliveryTimeEnd.Leave += new System.EventHandler(this.txtDeliveryTimeEnd_Leave);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(1298, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(287, 72);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 9;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // dgvOrderList
            // 
            this.dgvOrderList.AllowUserToAddRows = false;
            this.dgvOrderList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            this.dgvOrderList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOrderList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOrderList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrderList.BackgroundColor = System.Drawing.Color.White;
            this.dgvOrderList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvOrderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCbxDelete,
            this.colDelete,
            this.coluId,
            this.colDeliveryorderId,
            this.colDeliveryId,
            this.colClientId,
            this.colClientName,
            this.colSourTransType,
            this.colSourTransId,
            this.colAirWaybill,
            this.colOrigin,
            this.colBeginTime,
            this.colDestination,
            this.colLongitude,
            this.colLatitude,
            this.colPredictDeliveryTime,
            this.colDeliveryTime,
            this.colSigner,
            this.colTelephone,
            this.colIsBackFee,
            this.colAmount,
            this.colReceivable,
            this.colIsDeliver,
            this.colIsdeliveryName,
            this.colPaymentMethod,
            this.colTotalFee,
            this.colIsEnd,
            this.colIfEndName,
            this.colTerminator,
            this.colTerminatorName,
            this.colIsChecked,
            this.colIfCheckedName,
            this.coldeliveryStatus,
            this.colRecorderID,
            this.colRecorderName,
            this.colAuditor,
            this.colAuditorName,
            this.colLogisCompanyShortName,
            this.colLogisCompanyID});
            this.dgvOrderList.Location = new System.Drawing.Point(12, 102);
            this.dgvOrderList.Name = "dgvOrderList";
            this.dgvOrderList.ReadOnly = true;
            this.dgvOrderList.RowHeadersVisible = false;
            this.dgvOrderList.RowTemplate.Height = 25;
            this.dgvOrderList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrderList.Size = new System.Drawing.Size(1361, 447);
            this.dgvOrderList.TabIndex = 11;
            this.dgvOrderList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrderList_CellContentClick);
            this.dgvOrderList.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrderList_CellContentDoubleClick);
            this.dgvOrderList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrderList_CellDoubleClick);
            this.dgvOrderList.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvOrderList_CellMouseDown);
            this.dgvOrderList.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvOrderList_CellPainting);
            this.dgvOrderList.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrderList_CellValueChanged);
            this.dgvOrderList.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvOrderList_ColumnHeaderMouseClick);
            this.dgvOrderList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvOrderList_MouseClick);
            this.dgvOrderList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvOrderList_MouseDown);
            // 
            // colCbxDelete
            // 
            this.colCbxDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colCbxDelete.FillWeight = 10F;
            this.colCbxDelete.HeaderText = "删除";
            this.colCbxDelete.Name = "colCbxDelete";
            this.colCbxDelete.ReadOnly = true;
            this.colCbxDelete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colCbxDelete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colCbxDelete.Width = 40;
            // 
            // colDelete
            // 
            this.colDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.NullValue = "删除";
            this.colDelete.DefaultCellStyle = dataGridViewCellStyle2;
            this.colDelete.HeaderText = "删除";
            this.colDelete.Name = "colDelete";
            this.colDelete.ReadOnly = true;
            this.colDelete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colDelete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colDelete.Visible = false;
            // 
            // coluId
            // 
            this.coluId.DataPropertyName = "Id";
            this.coluId.HeaderText = "ID";
            this.coluId.Name = "coluId";
            this.coluId.ReadOnly = true;
            this.coluId.Visible = false;
            // 
            // colDeliveryorderId
            // 
            this.colDeliveryorderId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colDeliveryorderId.DataPropertyName = "DeliveryorderId";
            this.colDeliveryorderId.FillWeight = 35F;
            this.colDeliveryorderId.HeaderText = "订单号";
            this.colDeliveryorderId.Name = "colDeliveryorderId";
            this.colDeliveryorderId.ReadOnly = true;
            this.colDeliveryorderId.Width = 99;
            // 
            // colDeliveryId
            // 
            this.colDeliveryId.DataPropertyName = "DeliveryId";
            this.colDeliveryId.HeaderText = "运单号";
            this.colDeliveryId.Name = "colDeliveryId";
            this.colDeliveryId.ReadOnly = true;
            this.colDeliveryId.Visible = false;
            // 
            // colClientId
            // 
            this.colClientId.DataPropertyName = "ClientId";
            this.colClientId.FillWeight = 30F;
            this.colClientId.HeaderText = "客户编号";
            this.colClientId.Name = "colClientId";
            this.colClientId.ReadOnly = true;
            this.colClientId.Visible = false;
            // 
            // colClientName
            // 
            this.colClientName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colClientName.DataPropertyName = "ClientName";
            this.colClientName.FillWeight = 20F;
            this.colClientName.HeaderText = "客户";
            this.colClientName.Name = "colClientName";
            this.colClientName.ReadOnly = true;
            this.colClientName.Width = 120;
            // 
            // colSourTransType
            // 
            this.colSourTransType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colSourTransType.DataPropertyName = "SourceTransType";
            this.colSourTransType.FillWeight = 30F;
            this.colSourTransType.HeaderText = "运输类型";
            this.colSourTransType.Name = "colSourTransType";
            this.colSourTransType.ReadOnly = true;
            this.colSourTransType.Width = 80;
            // 
            // colSourTransId
            // 
            this.colSourTransId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colSourTransId.DataPropertyName = "SourceTransId";
            this.colSourTransId.FillWeight = 20F;
            this.colSourTransId.HeaderText = "班次号";
            this.colSourTransId.Name = "colSourTransId";
            this.colSourTransId.ReadOnly = true;
            this.colSourTransId.Width = 60;
            // 
            // colAirWaybill
            // 
            this.colAirWaybill.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colAirWaybill.DataPropertyName = "AirWaybillID";
            this.colAirWaybill.FillWeight = 30F;
            this.colAirWaybill.HeaderText = "空运单号";
            this.colAirWaybill.Name = "colAirWaybill";
            this.colAirWaybill.ReadOnly = true;
            this.colAirWaybill.Width = 80;
            // 
            // colOrigin
            // 
            this.colOrigin.DataPropertyName = "Origin";
            this.colOrigin.FillWeight = 70F;
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
            // colDestination
            // 
            this.colDestination.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colDestination.DataPropertyName = "Destination";
            this.colDestination.FillWeight = 60F;
            this.colDestination.HeaderText = "送达地点";
            this.colDestination.Name = "colDestination";
            this.colDestination.ReadOnly = true;
            this.colDestination.Width = 200;
            // 
            // colLongitude
            // 
            this.colLongitude.DataPropertyName = "Longitude";
            this.colLongitude.FillWeight = 20F;
            this.colLongitude.HeaderText = "经度";
            this.colLongitude.Name = "colLongitude";
            this.colLongitude.ReadOnly = true;
            this.colLongitude.Visible = false;
            // 
            // colLatitude
            // 
            this.colLatitude.DataPropertyName = "Latitude";
            this.colLatitude.FillWeight = 20F;
            this.colLatitude.HeaderText = "纬度";
            this.colLatitude.Name = "colLatitude";
            this.colLatitude.ReadOnly = true;
            this.colLatitude.Visible = false;
            // 
            // colPredictDeliveryTime
            // 
            this.colPredictDeliveryTime.DataPropertyName = "PredictDeliveryTime";
            this.colPredictDeliveryTime.FillWeight = 40F;
            this.colPredictDeliveryTime.HeaderText = "预计送达时间";
            this.colPredictDeliveryTime.Name = "colPredictDeliveryTime";
            this.colPredictDeliveryTime.ReadOnly = true;
            this.colPredictDeliveryTime.Visible = false;
            // 
            // colDeliveryTime
            // 
            this.colDeliveryTime.DataPropertyName = "DeliveryTime";
            this.colDeliveryTime.FillWeight = 40F;
            this.colDeliveryTime.HeaderText = "送达时间";
            this.colDeliveryTime.Name = "colDeliveryTime";
            this.colDeliveryTime.ReadOnly = true;
            this.colDeliveryTime.Visible = false;
            // 
            // colSigner
            // 
            this.colSigner.DataPropertyName = "Signer";
            this.colSigner.FillWeight = 30F;
            this.colSigner.HeaderText = "签收人";
            this.colSigner.Name = "colSigner";
            this.colSigner.ReadOnly = true;
            this.colSigner.Visible = false;
            // 
            // colTelephone
            // 
            this.colTelephone.DataPropertyName = "Telephone";
            this.colTelephone.FillWeight = 40F;
            this.colTelephone.HeaderText = "签收人电话";
            this.colTelephone.Name = "colTelephone";
            this.colTelephone.ReadOnly = true;
            this.colTelephone.Visible = false;
            // 
            // colIsBackFee
            // 
            this.colIsBackFee.DataPropertyName = "IsBackFee";
            this.colIsBackFee.FillWeight = 20F;
            this.colIsBackFee.HeaderText = "是否有代收款";
            this.colIsBackFee.Name = "colIsBackFee";
            this.colIsBackFee.ReadOnly = true;
            this.colIsBackFee.Visible = false;
            // 
            // colAmount
            // 
            this.colAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colAmount.DataPropertyName = "Amount";
            this.colAmount.FillWeight = 30F;
            this.colAmount.HeaderText = "实收代收款";
            this.colAmount.Name = "colAmount";
            this.colAmount.ReadOnly = true;
            this.colAmount.Width = 90;
            // 
            // colReceivable
            // 
            this.colReceivable.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colReceivable.DataPropertyName = "Receivable";
            this.colReceivable.FillWeight = 30F;
            this.colReceivable.HeaderText = "应收代收款";
            this.colReceivable.Name = "colReceivable";
            this.colReceivable.ReadOnly = true;
            this.colReceivable.Width = 90;
            // 
            // colIsDeliver
            // 
            this.colIsDeliver.DataPropertyName = "IsDeliver";
            this.colIsDeliver.FillWeight = 20F;
            this.colIsDeliver.HeaderText = "是否送货上门";
            this.colIsDeliver.Name = "colIsDeliver";
            this.colIsDeliver.ReadOnly = true;
            this.colIsDeliver.Visible = false;
            // 
            // colIsdeliveryName
            // 
            this.colIsdeliveryName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colIsdeliveryName.DataPropertyName = "IsDeliverName";
            this.colIsdeliveryName.FillWeight = 30F;
            this.colIsdeliveryName.HeaderText = "送货上门";
            this.colIsdeliveryName.Name = "colIsdeliveryName";
            this.colIsdeliveryName.ReadOnly = true;
            this.colIsdeliveryName.Width = 80;
            // 
            // colPaymentMethod
            // 
            this.colPaymentMethod.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colPaymentMethod.DataPropertyName = "PaymentMethod";
            this.colPaymentMethod.FillWeight = 30F;
            this.colPaymentMethod.HeaderText = "付款方式";
            this.colPaymentMethod.Name = "colPaymentMethod";
            this.colPaymentMethod.ReadOnly = true;
            this.colPaymentMethod.Width = 80;
            // 
            // colTotalFee
            // 
            this.colTotalFee.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colTotalFee.DataPropertyName = "TotalFee";
            this.colTotalFee.FillWeight = 30F;
            this.colTotalFee.HeaderText = "总费用";
            this.colTotalFee.Name = "colTotalFee";
            this.colTotalFee.ReadOnly = true;
            this.colTotalFee.Width = 70;
            // 
            // colIsEnd
            // 
            this.colIsEnd.DataPropertyName = "IsEnd";
            this.colIsEnd.FillWeight = 20F;
            this.colIsEnd.HeaderText = "是否完结";
            this.colIsEnd.Name = "colIsEnd";
            this.colIsEnd.ReadOnly = true;
            this.colIsEnd.Visible = false;
            // 
            // colIfEndName
            // 
            this.colIfEndName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colIfEndName.DataPropertyName = "IfEndName";
            this.colIfEndName.FillWeight = 20F;
            this.colIfEndName.HeaderText = "完结";
            this.colIfEndName.Name = "colIfEndName";
            this.colIfEndName.ReadOnly = true;
            this.colIfEndName.Width = 40;
            // 
            // colTerminator
            // 
            this.colTerminator.HeaderText = "完结人编号";
            this.colTerminator.Name = "colTerminator";
            this.colTerminator.ReadOnly = true;
            this.colTerminator.Visible = false;
            // 
            // colTerminatorName
            // 
            this.colTerminatorName.DataPropertyName = "TerminatorName";
            this.colTerminatorName.FillWeight = 30F;
            this.colTerminatorName.HeaderText = "完结人";
            this.colTerminatorName.Name = "colTerminatorName";
            this.colTerminatorName.ReadOnly = true;
            this.colTerminatorName.Visible = false;
            // 
            // colIsChecked
            // 
            this.colIsChecked.DataPropertyName = "IsChecked";
            this.colIsChecked.HeaderText = "是否审核";
            this.colIsChecked.Name = "colIsChecked";
            this.colIsChecked.ReadOnly = true;
            this.colIsChecked.Visible = false;
            // 
            // colIfCheckedName
            // 
            this.colIfCheckedName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colIfCheckedName.DataPropertyName = "ifCheckedName";
            this.colIfCheckedName.FillWeight = 30F;
            this.colIfCheckedName.HeaderText = "审核状态";
            this.colIfCheckedName.Name = "colIfCheckedName";
            this.colIfCheckedName.ReadOnly = true;
            this.colIfCheckedName.Width = 80;
            // 
            // coldeliveryStatus
            // 
            this.coldeliveryStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.coldeliveryStatus.DataPropertyName = "DeliveryStatus";
            this.coldeliveryStatus.FillWeight = 30F;
            this.coldeliveryStatus.HeaderText = "派送状态";
            this.coldeliveryStatus.Name = "coldeliveryStatus";
            this.coldeliveryStatus.ReadOnly = true;
            this.coldeliveryStatus.Width = 80;
            // 
            // colRecorderID
            // 
            this.colRecorderID.DataPropertyName = "RecorderID";
            this.colRecorderID.HeaderText = "录单人ID";
            this.colRecorderID.Name = "colRecorderID";
            this.colRecorderID.ReadOnly = true;
            this.colRecorderID.Visible = false;
            // 
            // colRecorderName
            // 
            this.colRecorderName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colRecorderName.DataPropertyName = "RecorderName";
            this.colRecorderName.FillWeight = 30F;
            this.colRecorderName.HeaderText = "录单人";
            this.colRecorderName.Name = "colRecorderName";
            this.colRecorderName.ReadOnly = true;
            this.colRecorderName.Width = 80;
            // 
            // colAuditor
            // 
            this.colAuditor.DataPropertyName = "Auditor";
            this.colAuditor.HeaderText = "审核人编号";
            this.colAuditor.Name = "colAuditor";
            this.colAuditor.ReadOnly = true;
            this.colAuditor.Visible = false;
            // 
            // colAuditorName
            // 
            this.colAuditorName.DataPropertyName = "AuditorName";
            this.colAuditorName.HeaderText = "审核人";
            this.colAuditorName.Name = "colAuditorName";
            this.colAuditorName.ReadOnly = true;
            this.colAuditorName.Visible = false;
            // 
            // colLogisCompanyShortName
            // 
            this.colLogisCompanyShortName.DataPropertyName = "LogisCompanyShortName";
            this.colLogisCompanyShortName.FillWeight = 40F;
            this.colLogisCompanyShortName.HeaderText = "物流公司简称";
            this.colLogisCompanyShortName.Name = "colLogisCompanyShortName";
            this.colLogisCompanyShortName.ReadOnly = true;
            this.colLogisCompanyShortName.Visible = false;
            // 
            // colLogisCompanyID
            // 
            this.colLogisCompanyID.DataPropertyName = "LogisCompanyID";
            this.colLogisCompanyID.FillWeight = 30F;
            this.colLogisCompanyID.HeaderText = "物流公司ID";
            this.colLogisCompanyID.Name = "colLogisCompanyID";
            this.colLogisCompanyID.ReadOnly = true;
            this.colLogisCompanyID.Visible = false;
            // 
            // monthCalendar2
            // 
            this.monthCalendar2.Location = new System.Drawing.Point(440, 71);
            this.monthCalendar2.Name = "monthCalendar2";
            this.monthCalendar2.TabIndex = 9;
            this.monthCalendar2.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar2_DateSelected);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMenuOrderId,
            this.TSMenuDelivery,
            this.TSMenuFee,
            this.TSmenuProduct,
            this.TSMenuData,
            this.toolStripMenuItem1,
            this.TSMenuReport,
            this.TSMenuEnd,
            this.toolStripSeparator2,
            this.TSMenuMap,
            this.TSMenuTemp,
            this.TSMenuJam,
            this.toolStripSeparator1,
            this.TSMenuException,
            this.TSMenuPark,
            this.TSMenuPath,
            this.TSMenuTempManager,
            this.TSTempInfo});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(161, 352);
            // 
            // TSMenuOrderId
            // 
            this.TSMenuOrderId.Name = "TSMenuOrderId";
            this.TSMenuOrderId.Size = new System.Drawing.Size(160, 22);
            this.TSMenuOrderId.Text = "复制订单号";
            this.TSMenuOrderId.Click += new System.EventHandler(this.TSMenuOrderId_Click);
            // 
            // TSMenuDelivery
            // 
            this.TSMenuDelivery.Name = "TSMenuDelivery";
            this.TSMenuDelivery.Size = new System.Drawing.Size(160, 22);
            this.TSMenuDelivery.Text = "查看配送信息";
            this.TSMenuDelivery.Click += new System.EventHandler(this.TSMenuDelivery_Click);
            // 
            // TSMenuFee
            // 
            this.TSMenuFee.Name = "TSMenuFee";
            this.TSMenuFee.Size = new System.Drawing.Size(160, 22);
            this.TSMenuFee.Text = "查看费用信息";
            this.TSMenuFee.Click += new System.EventHandler(this.TSMenuFee_Click_1);
            // 
            // TSmenuProduct
            // 
            this.TSmenuProduct.Name = "TSmenuProduct";
            this.TSmenuProduct.Size = new System.Drawing.Size(160, 22);
            this.TSmenuProduct.Text = "查看详细信息";
            this.TSmenuProduct.Visible = false;
            this.TSmenuProduct.Click += new System.EventHandler(this.TSmenuProduct_Click);
            // 
            // TSMenuData
            // 
            this.TSMenuData.Name = "TSMenuData";
            this.TSMenuData.Size = new System.Drawing.Size(160, 22);
            this.TSMenuData.Text = "导出当前数据";
            this.TSMenuData.Visible = false;
            this.TSMenuData.Click += new System.EventHandler(this.TSMenuData_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.Black;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(157, 6);
            // 
            // TSMenuReport
            // 
            this.TSMenuReport.Name = "TSMenuReport";
            this.TSMenuReport.Size = new System.Drawing.Size(160, 22);
            this.TSMenuReport.Text = "打印报表";
            this.TSMenuReport.Click += new System.EventHandler(this.TSMenuReport_Click);
            // 
            // TSMenuEnd
            // 
            this.TSMenuEnd.Name = "TSMenuEnd";
            this.TSMenuEnd.Size = new System.Drawing.Size(160, 22);
            this.TSMenuEnd.Text = "订单完结/审核";
            this.TSMenuEnd.Click += new System.EventHandler(this.TSMenuEnd_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.ForeColor = System.Drawing.Color.Black;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(157, 6);
            // 
            // TSMenuMap
            // 
            this.TSMenuMap.Name = "TSMenuMap";
            this.TSMenuMap.Size = new System.Drawing.Size(160, 22);
            this.TSMenuMap.Text = "地图轨迹";
            this.TSMenuMap.Click += new System.EventHandler(this.TSMenuMap_Click);
            // 
            // TSMenuTemp
            // 
            this.TSMenuTemp.Name = "TSMenuTemp";
            this.TSMenuTemp.Size = new System.Drawing.Size(160, 22);
            this.TSMenuTemp.Text = "温湿度历史数据";
            this.TSMenuTemp.Click += new System.EventHandler(this.TSMenuTemp_Click);
            // 
            // TSMenuJam
            // 
            this.TSMenuJam.Name = "TSMenuJam";
            this.TSMenuJam.Size = new System.Drawing.Size(160, 22);
            this.TSMenuJam.Text = "堵车管理";
            this.TSMenuJam.Click += new System.EventHandler(this.TSMenuJam_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.ForeColor = System.Drawing.Color.Black;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(157, 6);
            // 
            // TSMenuException
            // 
            this.TSMenuException.Name = "TSMenuException";
            this.TSMenuException.Size = new System.Drawing.Size(160, 22);
            this.TSMenuException.Text = "异常管理";
            this.TSMenuException.Click += new System.EventHandler(this.TSMenuException_Click);
            // 
            // TSMenuPark
            // 
            this.TSMenuPark.Name = "TSMenuPark";
            this.TSMenuPark.Size = new System.Drawing.Size(160, 22);
            this.TSMenuPark.Text = "区域停车设置";
            this.TSMenuPark.Click += new System.EventHandler(this.TSMenuPark_Click);
            // 
            // TSMenuPath
            // 
            this.TSMenuPath.Name = "TSMenuPath";
            this.TSMenuPath.Size = new System.Drawing.Size(160, 22);
            this.TSMenuPath.Text = "配送路径设置";
            this.TSMenuPath.Click += new System.EventHandler(this.TSMenuPath_Click);
            // 
            // TSMenuTempManager
            // 
            this.TSMenuTempManager.Name = "TSMenuTempManager";
            this.TSMenuTempManager.Size = new System.Drawing.Size(160, 22);
            this.TSMenuTempManager.Text = "温度管理";
            this.TSMenuTempManager.Click += new System.EventHandler(this.TSMenuTempManager_Click);
            // 
            // TSTempInfo
            // 
            this.TSTempInfo.Name = "TSTempInfo";
            this.TSTempInfo.Size = new System.Drawing.Size(160, 22);
            this.TSTempInfo.Text = "温湿度数据信息";
            this.TSTempInfo.Click += new System.EventHandler(this.TSTempInfo_Click);
            // 
            // BtnRenewUpload
            // 
            this.BtnRenewUpload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRenewUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRenewUpload.Location = new System.Drawing.Point(1298, 31);
            this.BtnRenewUpload.Name = "BtnRenewUpload";
            this.BtnRenewUpload.Size = new System.Drawing.Size(75, 23);
            this.BtnRenewUpload.TabIndex = 12;
            this.BtnRenewUpload.Text = "刷新";
            this.BtnRenewUpload.UseVisualStyleBackColor = true;
            this.BtnRenewUpload.Click += new System.EventHandler(this.BtnRenewUpload_Click);
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAddOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddOrder.ForeColor = System.Drawing.Color.Black;
            this.btnAddOrder.Location = new System.Drawing.Point(20, 76);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(75, 23);
            this.btnAddOrder.TabIndex = 13;
            this.btnAddOrder.Text = "增加";
            this.btnAddOrder.UseVisualStyleBackColor = false;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.BackColor = System.Drawing.Color.Peru;
            this.btnEnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnd.Location = new System.Drawing.Point(101, 76);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(75, 23);
            this.btnEnd.TabIndex = 14;
            this.btnEnd.Text = "完结";
            this.btnEnd.UseVisualStyleBackColor = false;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // btnPrePage
            // 
            this.btnPrePage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPrePage.BackColor = System.Drawing.Color.Transparent;
            this.btnPrePage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPrePage.BackgroundImage")));
            this.btnPrePage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPrePage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrePage.Location = new System.Drawing.Point(65, 556);
            this.btnPrePage.Name = "btnPrePage";
            this.btnPrePage.Size = new System.Drawing.Size(29, 23);
            this.btnPrePage.TabIndex = 15;
            this.btnPrePage.UseVisualStyleBackColor = false;
            this.btnPrePage.Click += new System.EventHandler(this.btnPrePage_Click);
            // 
            // btnNextPage
            // 
            this.btnNextPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNextPage.BackColor = System.Drawing.Color.Transparent;
            this.btnNextPage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNextPage.BackgroundImage")));
            this.btnNextPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNextPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextPage.Location = new System.Drawing.Point(213, 556);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(29, 23);
            this.btnNextPage.TabIndex = 15;
            this.btnNextPage.UseVisualStyleBackColor = false;
            this.btnNextPage.Click += new System.EventHandler(this.btnNextPage_Click);
            // 
            // btnFirstPage
            // 
            this.btnFirstPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnFirstPage.BackColor = System.Drawing.Color.Transparent;
            this.btnFirstPage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFirstPage.BackgroundImage")));
            this.btnFirstPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFirstPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirstPage.Location = new System.Drawing.Point(30, 556);
            this.btnFirstPage.Name = "btnFirstPage";
            this.btnFirstPage.Size = new System.Drawing.Size(29, 23);
            this.btnFirstPage.TabIndex = 15;
            this.btnFirstPage.UseVisualStyleBackColor = false;
            this.btnFirstPage.Click += new System.EventHandler(this.btnFirstPage_Click);
            // 
            // btnLastPage
            // 
            this.btnLastPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLastPage.BackColor = System.Drawing.Color.Transparent;
            this.btnLastPage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLastPage.BackgroundImage")));
            this.btnLastPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLastPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLastPage.Location = new System.Drawing.Point(246, 556);
            this.btnLastPage.Name = "btnLastPage";
            this.btnLastPage.Size = new System.Drawing.Size(29, 23);
            this.btnLastPage.TabIndex = 15;
            this.btnLastPage.UseVisualStyleBackColor = false;
            this.btnLastPage.Click += new System.EventHandler(this.btnLastPage_Click);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(100, 561);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 12);
            this.label8.TabIndex = 16;
            this.label8.Text = "第";
            // 
            // lblPre
            // 
            this.lblPre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPre.AutoSize = true;
            this.lblPre.Location = new System.Drawing.Point(114, 561);
            this.lblPre.Name = "lblPre";
            this.lblPre.Size = new System.Drawing.Size(11, 12);
            this.lblPre.TabIndex = 17;
            this.lblPre.Text = "1";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(136, 561);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 12);
            this.label10.TabIndex = 16;
            this.label10.Text = "页";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(153, 561);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(11, 12);
            this.label11.TabIndex = 18;
            this.label11.Text = "/";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(161, 561);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(17, 12);
            this.label12.TabIndex = 16;
            this.label12.Text = "共";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(196, 561);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(17, 12);
            this.label13.TabIndex = 16;
            this.label13.Text = "页";
            // 
            // lbltotalPage
            // 
            this.lbltotalPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbltotalPage.AutoSize = true;
            this.lbltotalPage.Location = new System.Drawing.Point(175, 561);
            this.lbltotalPage.Name = "lbltotalPage";
            this.lbltotalPage.Size = new System.Drawing.Size(11, 12);
            this.lbltotalPage.TabIndex = 17;
            this.lbltotalPage.Text = "1";
            // 
            // txtPage
            // 
            this.txtPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPage.Location = new System.Drawing.Point(345, 556);
            this.txtPage.Name = "txtPage";
            this.txtPage.Size = new System.Drawing.Size(41, 21);
            this.txtPage.TabIndex = 19;
            this.txtPage.Text = "1";
            this.txtPage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(325, 561);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 12);
            this.label9.TabIndex = 20;
            this.label9.Text = "第";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(391, 561);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(17, 12);
            this.label14.TabIndex = 21;
            this.label14.Text = "页";
            // 
            // btnGoPage
            // 
            this.btnGoPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGoPage.FlatAppearance.BorderSize = 0;
            this.btnGoPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoPage.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnGoPage.Location = new System.Drawing.Point(411, 555);
            this.btnGoPage.Name = "btnGoPage";
            this.btnGoPage.Size = new System.Drawing.Size(32, 23);
            this.btnGoPage.TabIndex = 22;
            this.btnGoPage.Text = "GO";
            this.btnGoPage.UseVisualStyleBackColor = true;
            this.btnGoPage.Click += new System.EventHandler(this.btnGoPage_Click);
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(470, 561);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(17, 12);
            this.label15.TabIndex = 20;
            this.label15.Text = "共";
            // 
            // lbltotalCount
            // 
            this.lbltotalCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbltotalCount.AutoSize = true;
            this.lbltotalCount.Location = new System.Drawing.Point(484, 561);
            this.lbltotalCount.Name = "lbltotalCount";
            this.lbltotalCount.Size = new System.Drawing.Size(11, 12);
            this.lbltotalCount.TabIndex = 21;
            this.lbltotalCount.Text = "N";
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(514, 561);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(41, 12);
            this.label17.TabIndex = 21;
            this.label17.Text = "条记录";
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label18.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label18.Location = new System.Drawing.Point(448, 559);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(16, 16);
            this.label18.TabIndex = 20;
            this.label18.Text = "|";
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label19.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label19.Location = new System.Drawing.Point(297, 559);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(16, 16);
            this.label19.TabIndex = 20;
            this.label19.Text = "|";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Peru;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(182, 76);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // FrmTranferOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1380, 581);
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
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.btnAddOrder);
            this.Controls.Add(this.BtnRenewUpload);
            this.Controls.Add(this.monthCalendar2);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.dgvOrderList);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmTranferOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "运单管理";
            this.Load += new System.EventHandler(this.FrmTranferOrder_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderList)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDeliveryTimeStart;
        private System.Windows.Forms.ComboBox cbxClient;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.DataGridView dgvOrderList;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDeliveryTimeEnd;
        private System.Windows.Forms.MonthCalendar monthCalendar2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSourTransId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDeliveryOrderId;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TSMenuMap;
        private System.Windows.Forms.ToolStripMenuItem TSMenuTemp;
        private System.Windows.Forms.ToolStripMenuItem TSMenuException;
        private System.Windows.Forms.ToolStripMenuItem TSMenuPark;
        private System.Windows.Forms.ToolStripMenuItem TSMenuPath;
        private System.Windows.Forms.ToolStripMenuItem TSMenuEnd;
        private System.Windows.Forms.ToolStripMenuItem TSmenuProduct;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtInvoiceId;
        private System.Windows.Forms.ToolStripMenuItem TSMenuOrderId;
        private System.Windows.Forms.Button BtnRenewUpload;
        private System.Windows.Forms.ToolStripMenuItem TSMenuData;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem TSMenuReport;
        private System.Windows.Forms.ToolStripMenuItem TSMenuDelivery;
        private System.Windows.Forms.ToolStripMenuItem TSMenuJam;
        private System.Windows.Forms.ToolStripMenuItem TSMenuFee;
        private System.Windows.Forms.ComboBox cbxSelect;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolStripMenuItem TSMenuTempManager;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.ToolStripMenuItem TSTempInfo;
        private System.Windows.Forms.Button btnPrePage;
        private System.Windows.Forms.Button btnNextPage;
        private System.Windows.Forms.Button btnFirstPage;
        private System.Windows.Forms.Button btnLastPage;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblPre;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbltotalPage;
        private System.Windows.Forms.TextBox txtPage;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnGoPage;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lbltotalCount;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colCbxDelete;
        private System.Windows.Forms.DataGridViewLinkColumn colDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn coluId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDeliveryorderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDeliveryId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClientId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSourTransType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSourTransId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAirWaybill;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrigin;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBeginTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDestination;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLongitude;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLatitude;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPredictDeliveryTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDeliveryTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSigner;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTelephone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIsBackFee;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReceivable;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIsDeliver;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIsdeliveryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPaymentMethod;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotalFee;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIsEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIfEndName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTerminator;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTerminatorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIsChecked;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIfCheckedName;
        private System.Windows.Forms.DataGridViewTextBoxColumn coldeliveryStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRecorderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRecorderName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAuditor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAuditorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLogisCompanyShortName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLogisCompanyID;
    }
}