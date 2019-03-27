namespace LogisPrj
{
    partial class FrmDataExport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDataExport));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.monthCalendar2 = new System.Windows.Forms.MonthCalendar();
            this.btnOut = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDeliveryTimeEnd = new System.Windows.Forms.TextBox();
            this.txtDeliveryTimeStart = new System.Windows.Forms.TextBox();
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnClose = new System.Windows.Forms.Button();
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
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderList)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1523, 635);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnGoPage);
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.lbltotalCount);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.label19);
            this.tabPage1.Controls.Add(this.label18);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.txtPage);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.lbltotalPage);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.lblPre);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.btnLastPage);
            this.tabPage1.Controls.Add(this.btnNextPage);
            this.tabPage1.Controls.Add(this.btnFirstPage);
            this.tabPage1.Controls.Add(this.btnPrePage);
            this.tabPage1.Controls.Add(this.monthCalendar1);
            this.tabPage1.Controls.Add(this.monthCalendar2);
            this.tabPage1.Controls.Add(this.btnOut);
            this.tabPage1.Controls.Add(this.btnSearch);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtDeliveryTimeEnd);
            this.tabPage1.Controls.Add(this.txtDeliveryTimeStart);
            this.tabPage1.Controls.Add(this.dgvOrderList);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1515, 609);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "订单数据";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(46, 34);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 14;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // monthCalendar2
            // 
            this.monthCalendar2.Location = new System.Drawing.Point(199, 34);
            this.monthCalendar2.Name = "monthCalendar2";
            this.monthCalendar2.TabIndex = 13;
            this.monthCalendar2.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar2_DateSelected);
            // 
            // btnOut
            // 
            this.btnOut.BackColor = System.Drawing.Color.ForestGreen;
            this.btnOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOut.Location = new System.Drawing.Point(419, 4);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(75, 23);
            this.btnOut.TabIndex = 10;
            this.btnOut.Text = "导出";
            this.btnOut.UseVisualStyleBackColor = false;
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Gold;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(338, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(181, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "至";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "日期";
            // 
            // txtDeliveryTimeEnd
            // 
            this.txtDeliveryTimeEnd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDeliveryTimeEnd.Location = new System.Drawing.Point(199, 6);
            this.txtDeliveryTimeEnd.Name = "txtDeliveryTimeEnd";
            this.txtDeliveryTimeEnd.Size = new System.Drawing.Size(133, 21);
            this.txtDeliveryTimeEnd.TabIndex = 7;
            this.txtDeliveryTimeEnd.Click += new System.EventHandler(this.txtDeliveryTimeEnd_Click);
            // 
            // txtDeliveryTimeStart
            // 
            this.txtDeliveryTimeStart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDeliveryTimeStart.Location = new System.Drawing.Point(46, 6);
            this.txtDeliveryTimeStart.Name = "txtDeliveryTimeStart";
            this.txtDeliveryTimeStart.Size = new System.Drawing.Size(133, 21);
            this.txtDeliveryTimeStart.TabIndex = 8;
            this.txtDeliveryTimeStart.Click += new System.EventHandler(this.txtDeliveryTimeStart_Click);
            // 
            // dgvOrderList
            // 
            this.dgvOrderList.AllowUserToAddRows = false;
            this.dgvOrderList.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.AliceBlue;
            this.dgvOrderList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
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
            this.dgvOrderList.Location = new System.Drawing.Point(2, 37);
            this.dgvOrderList.Name = "dgvOrderList";
            this.dgvOrderList.ReadOnly = true;
            this.dgvOrderList.RowHeadersVisible = false;
            this.dgvOrderList.RowTemplate.Height = 25;
            this.dgvOrderList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrderList.Size = new System.Drawing.Size(1517, 541);
            this.dgvOrderList.TabIndex = 15;
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
            this.colCbxDelete.Visible = false;
            this.colCbxDelete.Width = 40;
            // 
            // colDelete
            // 
            this.colDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle4.NullValue = "删除";
            this.colDelete.DefaultCellStyle = dataGridViewCellStyle4;
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
            this.colDeliveryorderId.DataPropertyName = "colDeliveryorderId";
            this.colDeliveryorderId.FillWeight = 35F;
            this.colDeliveryorderId.HeaderText = "订单号";
            this.colDeliveryorderId.Name = "colDeliveryorderId";
            this.colDeliveryorderId.ReadOnly = true;
            this.colDeliveryorderId.Width = 99;
            // 
            // colDeliveryId
            // 
            this.colDeliveryId.DataPropertyName = "colDeliveryId";
            this.colDeliveryId.HeaderText = "运单号";
            this.colDeliveryId.Name = "colDeliveryId";
            this.colDeliveryId.ReadOnly = true;
            this.colDeliveryId.Visible = false;
            // 
            // colClientId
            // 
            this.colClientId.DataPropertyName = "colClientId";
            this.colClientId.FillWeight = 30F;
            this.colClientId.HeaderText = "客户编号";
            this.colClientId.Name = "colClientId";
            this.colClientId.ReadOnly = true;
            this.colClientId.Visible = false;
            // 
            // colClientName
            // 
            this.colClientName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colClientName.DataPropertyName = "colClientName";
            this.colClientName.FillWeight = 20F;
            this.colClientName.HeaderText = "客户";
            this.colClientName.Name = "colClientName";
            this.colClientName.ReadOnly = true;
            this.colClientName.Width = 120;
            // 
            // colSourTransType
            // 
            this.colSourTransType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colSourTransType.DataPropertyName = "colSourTransType";
            this.colSourTransType.FillWeight = 30F;
            this.colSourTransType.HeaderText = "运输类型";
            this.colSourTransType.Name = "colSourTransType";
            this.colSourTransType.ReadOnly = true;
            this.colSourTransType.Width = 80;
            // 
            // colSourTransId
            // 
            this.colSourTransId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colSourTransId.DataPropertyName = "colSourTransId";
            this.colSourTransId.FillWeight = 20F;
            this.colSourTransId.HeaderText = "班次号";
            this.colSourTransId.Name = "colSourTransId";
            this.colSourTransId.ReadOnly = true;
            this.colSourTransId.Width = 60;
            // 
            // colAirWaybill
            // 
            this.colAirWaybill.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colAirWaybill.DataPropertyName = "colAirWaybill";
            this.colAirWaybill.FillWeight = 30F;
            this.colAirWaybill.HeaderText = "空运单号";
            this.colAirWaybill.Name = "colAirWaybill";
            this.colAirWaybill.ReadOnly = true;
            this.colAirWaybill.Width = 80;
            // 
            // colOrigin
            // 
            this.colOrigin.DataPropertyName = "colOrigin";
            this.colOrigin.FillWeight = 70F;
            this.colOrigin.HeaderText = "起点";
            this.colOrigin.Name = "colOrigin";
            this.colOrigin.ReadOnly = true;
            this.colOrigin.Visible = false;
            // 
            // colBeginTime
            // 
            this.colBeginTime.DataPropertyName = "colBeginTime";
            this.colBeginTime.FillWeight = 40F;
            this.colBeginTime.HeaderText = "起点时间";
            this.colBeginTime.Name = "colBeginTime";
            this.colBeginTime.ReadOnly = true;
            this.colBeginTime.Visible = false;
            // 
            // colDestination
            // 
            this.colDestination.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colDestination.DataPropertyName = "colDestination";
            this.colDestination.FillWeight = 60F;
            this.colDestination.HeaderText = "送达地点";
            this.colDestination.Name = "colDestination";
            this.colDestination.ReadOnly = true;
            this.colDestination.Width = 200;
            // 
            // colLongitude
            // 
            this.colLongitude.DataPropertyName = "colLongitude";
            this.colLongitude.FillWeight = 20F;
            this.colLongitude.HeaderText = "经度";
            this.colLongitude.Name = "colLongitude";
            this.colLongitude.ReadOnly = true;
            this.colLongitude.Visible = false;
            // 
            // colLatitude
            // 
            this.colLatitude.DataPropertyName = "colLatitude";
            this.colLatitude.FillWeight = 20F;
            this.colLatitude.HeaderText = "纬度";
            this.colLatitude.Name = "colLatitude";
            this.colLatitude.ReadOnly = true;
            this.colLatitude.Visible = false;
            // 
            // colPredictDeliveryTime
            // 
            this.colPredictDeliveryTime.DataPropertyName = "colPredictDeliveryTime";
            this.colPredictDeliveryTime.FillWeight = 40F;
            this.colPredictDeliveryTime.HeaderText = "预计送达时间";
            this.colPredictDeliveryTime.Name = "colPredictDeliveryTime";
            this.colPredictDeliveryTime.ReadOnly = true;
            this.colPredictDeliveryTime.Visible = false;
            // 
            // colDeliveryTime
            // 
            this.colDeliveryTime.DataPropertyName = "colDeliveryTime";
            this.colDeliveryTime.FillWeight = 40F;
            this.colDeliveryTime.HeaderText = "送达时间";
            this.colDeliveryTime.Name = "colDeliveryTime";
            this.colDeliveryTime.ReadOnly = true;
            this.colDeliveryTime.Visible = false;
            // 
            // colSigner
            // 
            this.colSigner.DataPropertyName = "colSigner";
            this.colSigner.FillWeight = 30F;
            this.colSigner.HeaderText = "签收人";
            this.colSigner.Name = "colSigner";
            this.colSigner.ReadOnly = true;
            this.colSigner.Visible = false;
            // 
            // colTelephone
            // 
            this.colTelephone.DataPropertyName = "colTelephone";
            this.colTelephone.FillWeight = 40F;
            this.colTelephone.HeaderText = "签收人电话";
            this.colTelephone.Name = "colTelephone";
            this.colTelephone.ReadOnly = true;
            this.colTelephone.Visible = false;
            // 
            // colIsBackFee
            // 
            this.colIsBackFee.DataPropertyName = "colIsBackFee";
            this.colIsBackFee.FillWeight = 20F;
            this.colIsBackFee.HeaderText = "是否有代收款";
            this.colIsBackFee.Name = "colIsBackFee";
            this.colIsBackFee.ReadOnly = true;
            this.colIsBackFee.Visible = false;
            // 
            // colAmount
            // 
            this.colAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colAmount.DataPropertyName = "colAmount";
            this.colAmount.FillWeight = 30F;
            this.colAmount.HeaderText = "实收代收款";
            this.colAmount.Name = "colAmount";
            this.colAmount.ReadOnly = true;
            this.colAmount.Width = 90;
            // 
            // colReceivable
            // 
            this.colReceivable.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colReceivable.DataPropertyName = "colReceivable";
            this.colReceivable.FillWeight = 30F;
            this.colReceivable.HeaderText = "应收代收款";
            this.colReceivable.Name = "colReceivable";
            this.colReceivable.ReadOnly = true;
            this.colReceivable.Width = 90;
            // 
            // colIsDeliver
            // 
            this.colIsDeliver.DataPropertyName = "colIsDeliver";
            this.colIsDeliver.FillWeight = 20F;
            this.colIsDeliver.HeaderText = "是否送货上门";
            this.colIsDeliver.Name = "colIsDeliver";
            this.colIsDeliver.ReadOnly = true;
            this.colIsDeliver.Visible = false;
            // 
            // colIsdeliveryName
            // 
            this.colIsdeliveryName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colIsdeliveryName.DataPropertyName = "colIsdeliveryName";
            this.colIsdeliveryName.FillWeight = 30F;
            this.colIsdeliveryName.HeaderText = "送货上门";
            this.colIsdeliveryName.Name = "colIsdeliveryName";
            this.colIsdeliveryName.ReadOnly = true;
            this.colIsdeliveryName.Width = 80;
            // 
            // colPaymentMethod
            // 
            this.colPaymentMethod.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colPaymentMethod.DataPropertyName = "colPaymentMethod";
            this.colPaymentMethod.FillWeight = 30F;
            this.colPaymentMethod.HeaderText = "付款方式";
            this.colPaymentMethod.Name = "colPaymentMethod";
            this.colPaymentMethod.ReadOnly = true;
            this.colPaymentMethod.Width = 80;
            // 
            // colTotalFee
            // 
            this.colTotalFee.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colTotalFee.DataPropertyName = "colTotalFee";
            this.colTotalFee.FillWeight = 30F;
            this.colTotalFee.HeaderText = "总费用";
            this.colTotalFee.Name = "colTotalFee";
            this.colTotalFee.ReadOnly = true;
            this.colTotalFee.Width = 70;
            // 
            // colIsEnd
            // 
            this.colIsEnd.DataPropertyName = "colIsEnd";
            this.colIsEnd.FillWeight = 20F;
            this.colIsEnd.HeaderText = "是否完结";
            this.colIsEnd.Name = "colIsEnd";
            this.colIsEnd.ReadOnly = true;
            this.colIsEnd.Visible = false;
            // 
            // colIfEndName
            // 
            this.colIfEndName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colIfEndName.DataPropertyName = "colIfEndName";
            this.colIfEndName.FillWeight = 20F;
            this.colIfEndName.HeaderText = "完结";
            this.colIfEndName.Name = "colIfEndName";
            this.colIfEndName.ReadOnly = true;
            this.colIfEndName.Width = 40;
            // 
            // colTerminator
            // 
            this.colTerminator.DataPropertyName = "colTerminator";
            this.colTerminator.HeaderText = "完结人编号";
            this.colTerminator.Name = "colTerminator";
            this.colTerminator.ReadOnly = true;
            this.colTerminator.Visible = false;
            // 
            // colTerminatorName
            // 
            this.colTerminatorName.DataPropertyName = "colTerminatorName";
            this.colTerminatorName.FillWeight = 30F;
            this.colTerminatorName.HeaderText = "完结人";
            this.colTerminatorName.Name = "colTerminatorName";
            this.colTerminatorName.ReadOnly = true;
            this.colTerminatorName.Visible = false;
            // 
            // colIsChecked
            // 
            this.colIsChecked.DataPropertyName = "colIsChecked";
            this.colIsChecked.HeaderText = "是否审核";
            this.colIsChecked.Name = "colIsChecked";
            this.colIsChecked.ReadOnly = true;
            this.colIsChecked.Visible = false;
            // 
            // colIfCheckedName
            // 
            this.colIfCheckedName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colIfCheckedName.DataPropertyName = "colIfCheckedName";
            this.colIfCheckedName.FillWeight = 30F;
            this.colIfCheckedName.HeaderText = "审核状态";
            this.colIfCheckedName.Name = "colIfCheckedName";
            this.colIfCheckedName.ReadOnly = true;
            this.colIfCheckedName.Visible = false;
            this.colIfCheckedName.Width = 80;
            // 
            // coldeliveryStatus
            // 
            this.coldeliveryStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.coldeliveryStatus.DataPropertyName = "coldeliveryStatus";
            this.coldeliveryStatus.FillWeight = 30F;
            this.coldeliveryStatus.HeaderText = "派送状态";
            this.coldeliveryStatus.Name = "coldeliveryStatus";
            this.coldeliveryStatus.ReadOnly = true;
            this.coldeliveryStatus.Visible = false;
            this.coldeliveryStatus.Width = 80;
            // 
            // colRecorderID
            // 
            this.colRecorderID.DataPropertyName = "colRecorderID";
            this.colRecorderID.HeaderText = "录单人ID";
            this.colRecorderID.Name = "colRecorderID";
            this.colRecorderID.ReadOnly = true;
            this.colRecorderID.Visible = false;
            // 
            // colRecorderName
            // 
            this.colRecorderName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colRecorderName.DataPropertyName = "colRecorderName";
            this.colRecorderName.FillWeight = 30F;
            this.colRecorderName.HeaderText = "录单人";
            this.colRecorderName.Name = "colRecorderName";
            this.colRecorderName.ReadOnly = true;
            this.colRecorderName.Width = 80;
            // 
            // colAuditor
            // 
            this.colAuditor.DataPropertyName = "colAuditor";
            this.colAuditor.HeaderText = "审核人编号";
            this.colAuditor.Name = "colAuditor";
            this.colAuditor.ReadOnly = true;
            this.colAuditor.Visible = false;
            // 
            // colAuditorName
            // 
            this.colAuditorName.DataPropertyName = "colAuditorName";
            this.colAuditorName.HeaderText = "审核人";
            this.colAuditorName.Name = "colAuditorName";
            this.colAuditorName.ReadOnly = true;
            this.colAuditorName.Visible = false;
            // 
            // colLogisCompanyShortName
            // 
            this.colLogisCompanyShortName.DataPropertyName = "colLogisCompanyShortName";
            this.colLogisCompanyShortName.FillWeight = 40F;
            this.colLogisCompanyShortName.HeaderText = "物流公司简称";
            this.colLogisCompanyShortName.Name = "colLogisCompanyShortName";
            this.colLogisCompanyShortName.ReadOnly = true;
            this.colLogisCompanyShortName.Visible = false;
            // 
            // colLogisCompanyID
            // 
            this.colLogisCompanyID.DataPropertyName = "colLogisCompanyID";
            this.colLogisCompanyID.FillWeight = 30F;
            this.colLogisCompanyID.HeaderText = "物流公司ID";
            this.colLogisCompanyID.Name = "colLogisCompanyID";
            this.colLogisCompanyID.ReadOnly = true;
            this.colLogisCompanyID.Visible = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1515, 609);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "加油数据";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(1442, -1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnGoPage
            // 
            this.btnGoPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGoPage.FlatAppearance.BorderSize = 0;
            this.btnGoPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoPage.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnGoPage.Location = new System.Drawing.Point(390, 582);
            this.btnGoPage.Name = "btnGoPage";
            this.btnGoPage.Size = new System.Drawing.Size(32, 23);
            this.btnGoPage.TabIndex = 42;
            this.btnGoPage.Text = "GO";
            this.btnGoPage.UseVisualStyleBackColor = true;
            this.btnGoPage.Click += new System.EventHandler(this.btnGoPage_Click);
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(493, 588);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(41, 12);
            this.label17.TabIndex = 41;
            this.label17.Text = "条记录";
            // 
            // lbltotalCount
            // 
            this.lbltotalCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbltotalCount.AutoSize = true;
            this.lbltotalCount.Location = new System.Drawing.Point(463, 588);
            this.lbltotalCount.Name = "lbltotalCount";
            this.lbltotalCount.Size = new System.Drawing.Size(11, 12);
            this.lbltotalCount.TabIndex = 40;
            this.lbltotalCount.Text = "N";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(370, 588);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(17, 12);
            this.label14.TabIndex = 39;
            this.label14.Text = "页";
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(449, 588);
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
            this.label19.Location = new System.Drawing.Point(276, 586);
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
            this.label18.Location = new System.Drawing.Point(427, 586);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(16, 16);
            this.label18.TabIndex = 36;
            this.label18.Text = "|";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(304, 588);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 12);
            this.label9.TabIndex = 35;
            this.label9.Text = "第";
            // 
            // txtPage
            // 
            this.txtPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPage.Location = new System.Drawing.Point(324, 583);
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
            this.label11.Location = new System.Drawing.Point(132, 588);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(11, 12);
            this.label11.TabIndex = 33;
            this.label11.Text = "/";
            // 
            // lbltotalPage
            // 
            this.lbltotalPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbltotalPage.AutoSize = true;
            this.lbltotalPage.Location = new System.Drawing.Point(154, 588);
            this.lbltotalPage.Name = "lbltotalPage";
            this.lbltotalPage.Size = new System.Drawing.Size(11, 12);
            this.lbltotalPage.TabIndex = 32;
            this.lbltotalPage.Text = "1";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(175, 588);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(17, 12);
            this.label13.TabIndex = 30;
            this.label13.Text = "页";
            // 
            // lblPre
            // 
            this.lblPre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPre.AutoSize = true;
            this.lblPre.Location = new System.Drawing.Point(93, 588);
            this.lblPre.Name = "lblPre";
            this.lblPre.Size = new System.Drawing.Size(11, 12);
            this.lblPre.TabIndex = 31;
            this.lblPre.Text = "1";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(140, 588);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(17, 12);
            this.label12.TabIndex = 29;
            this.label12.Text = "共";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(115, 588);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 12);
            this.label10.TabIndex = 28;
            this.label10.Text = "页";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(79, 588);
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
            this.btnLastPage.Location = new System.Drawing.Point(225, 583);
            this.btnLastPage.Name = "btnLastPage";
            this.btnLastPage.Size = new System.Drawing.Size(29, 23);
            this.btnLastPage.TabIndex = 25;
            this.btnLastPage.UseVisualStyleBackColor = false;
            this.btnLastPage.Click += new System.EventHandler(this.btnLastPage_Click);
            // 
            // btnNextPage
            // 
            this.btnNextPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNextPage.BackColor = System.Drawing.Color.Transparent;
            this.btnNextPage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNextPage.BackgroundImage")));
            this.btnNextPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNextPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextPage.Location = new System.Drawing.Point(192, 583);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(29, 23);
            this.btnNextPage.TabIndex = 24;
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
            this.btnFirstPage.Location = new System.Drawing.Point(9, 583);
            this.btnFirstPage.Name = "btnFirstPage";
            this.btnFirstPage.Size = new System.Drawing.Size(29, 23);
            this.btnFirstPage.TabIndex = 26;
            this.btnFirstPage.UseVisualStyleBackColor = false;
            this.btnFirstPage.Click += new System.EventHandler(this.btnFirstPage_Click);
            // 
            // btnPrePage
            // 
            this.btnPrePage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPrePage.BackColor = System.Drawing.Color.Transparent;
            this.btnPrePage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPrePage.BackgroundImage")));
            this.btnPrePage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPrePage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrePage.Location = new System.Drawing.Point(44, 583);
            this.btnPrePage.Name = "btnPrePage";
            this.btnPrePage.Size = new System.Drawing.Size(29, 23);
            this.btnPrePage.TabIndex = 23;
            this.btnPrePage.UseVisualStyleBackColor = false;
            this.btnPrePage.Click += new System.EventHandler(this.btnPrePage_Click);
            // 
            // FrmDataExport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1525, 645);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmDataExport";
            this.Text = "数据导出";
            this.Load += new System.EventHandler(this.FrmDataExport_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnOut;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDeliveryTimeEnd;
        private System.Windows.Forms.TextBox txtDeliveryTimeStart;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.MonthCalendar monthCalendar2;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.DataGridView dgvOrderList;
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