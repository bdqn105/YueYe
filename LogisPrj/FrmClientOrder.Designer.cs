namespace LogisPrj
{
    partial class FrmClientOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClientOrder));
            this.dgvClientOrder = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClientOrderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colListnumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAirWaybillID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSourTransType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSourceTransId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAirArriverTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClientId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClientPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClientAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReceiver = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReceiverPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReceiverAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIsDeliver = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIsDeal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIsDelivery = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDealName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRemark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.dTStart = new System.Windows.Forms.DateTimePicker();
            this.cbxClientId = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxStatus = new System.Windows.Forms.ComboBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TSMenuDeliveryOrder = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientOrder)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvClientOrder
            // 
            this.dgvClientOrder.AllowUserToAddRows = false;
            this.dgvClientOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClientOrder.BackgroundColor = System.Drawing.Color.White;
            this.dgvClientOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colClientOrderId,
            this.colListnumber,
            this.colAirWaybillID,
            this.colSourTransType,
            this.colSourceTransId,
            this.colAirArriverTime,
            this.colClientId,
            this.colClientName,
            this.colClientPhone,
            this.colClientAddress,
            this.colReceiver,
            this.colReceiverPhone,
            this.colReceiverAddress,
            this.colProductId,
            this.colQuantity,
            this.colWeight,
            this.colIsDeliver,
            this.colIsDeal,
            this.colIsDelivery,
            this.colDealName,
            this.colRemark});
            this.dgvClientOrder.Location = new System.Drawing.Point(12, 42);
            this.dgvClientOrder.Name = "dgvClientOrder";
            this.dgvClientOrder.ReadOnly = true;
            this.dgvClientOrder.RowHeadersVisible = false;
            this.dgvClientOrder.RowTemplate.Height = 23;
            this.dgvClientOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientOrder.Size = new System.Drawing.Size(1294, 595);
            this.dgvClientOrder.TabIndex = 0;
            this.dgvClientOrder.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientOrder_CellDoubleClick);
            this.dgvClientOrder.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvClientOrder_CellMouseDown);
            this.dgvClientOrder.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvClientOrder_CellPainting);
            // 
            // colId
            // 
            this.colId.DataPropertyName = "Id";
            this.colId.HeaderText = "ID";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Visible = false;
            // 
            // colClientOrderId
            // 
            this.colClientOrderId.DataPropertyName = "ClientOrderId";
            this.colClientOrderId.FillWeight = 30F;
            this.colClientOrderId.HeaderText = "订单编号";
            this.colClientOrderId.Name = "colClientOrderId";
            this.colClientOrderId.ReadOnly = true;
            // 
            // colListnumber
            // 
            this.colListnumber.DataPropertyName = "Listnumber";
            this.colListnumber.FillWeight = 25F;
            this.colListnumber.HeaderText = "清单号";
            this.colListnumber.Name = "colListnumber";
            this.colListnumber.ReadOnly = true;
            // 
            // colAirWaybillID
            // 
            this.colAirWaybillID.DataPropertyName = "AirWaybillID";
            this.colAirWaybillID.FillWeight = 25F;
            this.colAirWaybillID.HeaderText = "运单号";
            this.colAirWaybillID.Name = "colAirWaybillID";
            this.colAirWaybillID.ReadOnly = true;
            // 
            // colSourTransType
            // 
            this.colSourTransType.DataPropertyName = "SourTransType";
            this.colSourTransType.FillWeight = 25F;
            this.colSourTransType.HeaderText = "运输方式";
            this.colSourTransType.Name = "colSourTransType";
            this.colSourTransType.ReadOnly = true;
            // 
            // colSourceTransId
            // 
            this.colSourceTransId.DataPropertyName = "SourceTransId";
            this.colSourceTransId.FillWeight = 20F;
            this.colSourceTransId.HeaderText = "班次号";
            this.colSourceTransId.Name = "colSourceTransId";
            this.colSourceTransId.ReadOnly = true;
            // 
            // colAirArriverTime
            // 
            this.colAirArriverTime.DataPropertyName = "AirArriverTime";
            this.colAirArriverTime.FillWeight = 35F;
            this.colAirArriverTime.HeaderText = "到达时间";
            this.colAirArriverTime.Name = "colAirArriverTime";
            this.colAirArriverTime.ReadOnly = true;
            // 
            // colClientId
            // 
            this.colClientId.DataPropertyName = "ClientId";
            this.colClientId.FillWeight = 20F;
            this.colClientId.HeaderText = "客户编号";
            this.colClientId.Name = "colClientId";
            this.colClientId.ReadOnly = true;
            this.colClientId.Visible = false;
            // 
            // colClientName
            // 
            this.colClientName.DataPropertyName = "ClientName";
            this.colClientName.FillWeight = 20F;
            this.colClientName.HeaderText = "客户";
            this.colClientName.Name = "colClientName";
            this.colClientName.ReadOnly = true;
            // 
            // colClientPhone
            // 
            this.colClientPhone.DataPropertyName = "ClientPhone";
            this.colClientPhone.FillWeight = 30F;
            this.colClientPhone.HeaderText = "客户电话";
            this.colClientPhone.Name = "colClientPhone";
            this.colClientPhone.ReadOnly = true;
            this.colClientPhone.Visible = false;
            // 
            // colClientAddress
            // 
            this.colClientAddress.DataPropertyName = "ClientAddress";
            this.colClientAddress.FillWeight = 50F;
            this.colClientAddress.HeaderText = "客户地址";
            this.colClientAddress.Name = "colClientAddress";
            this.colClientAddress.ReadOnly = true;
            this.colClientAddress.Visible = false;
            // 
            // colReceiver
            // 
            this.colReceiver.DataPropertyName = "Receiver";
            this.colReceiver.FillWeight = 20F;
            this.colReceiver.HeaderText = "收货人";
            this.colReceiver.Name = "colReceiver";
            this.colReceiver.ReadOnly = true;
            // 
            // colReceiverPhone
            // 
            this.colReceiverPhone.DataPropertyName = "ReceiverPhone";
            this.colReceiverPhone.FillWeight = 30F;
            this.colReceiverPhone.HeaderText = "收货人电话";
            this.colReceiverPhone.Name = "colReceiverPhone";
            this.colReceiverPhone.ReadOnly = true;
            this.colReceiverPhone.Visible = false;
            // 
            // colReceiverAddress
            // 
            this.colReceiverAddress.DataPropertyName = "ReceiverAddress";
            this.colReceiverAddress.FillWeight = 50F;
            this.colReceiverAddress.HeaderText = "收货地址";
            this.colReceiverAddress.Name = "colReceiverAddress";
            this.colReceiverAddress.ReadOnly = true;
            // 
            // colProductId
            // 
            this.colProductId.DataPropertyName = "ProductId";
            this.colProductId.FillWeight = 30F;
            this.colProductId.HeaderText = "品名";
            this.colProductId.Name = "colProductId";
            this.colProductId.ReadOnly = true;
            this.colProductId.Visible = false;
            // 
            // colQuantity
            // 
            this.colQuantity.DataPropertyName = "Quantity";
            this.colQuantity.FillWeight = 10F;
            this.colQuantity.HeaderText = "数量";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.ReadOnly = true;
            this.colQuantity.Visible = false;
            // 
            // colWeight
            // 
            this.colWeight.DataPropertyName = "Weight";
            this.colWeight.FillWeight = 10F;
            this.colWeight.HeaderText = "重量";
            this.colWeight.Name = "colWeight";
            this.colWeight.ReadOnly = true;
            this.colWeight.Visible = false;
            // 
            // colIsDeliver
            // 
            this.colIsDeliver.DataPropertyName = "IsDeliver";
            this.colIsDeliver.FillWeight = 10F;
            this.colIsDeliver.HeaderText = "是否送货上楼";
            this.colIsDeliver.Name = "colIsDeliver";
            this.colIsDeliver.ReadOnly = true;
            this.colIsDeliver.Visible = false;
            // 
            // colIsDeal
            // 
            this.colIsDeal.DataPropertyName = "IsDeal";
            this.colIsDeal.FillWeight = 10F;
            this.colIsDeal.HeaderText = "是否处理";
            this.colIsDeal.Name = "colIsDeal";
            this.colIsDeal.ReadOnly = true;
            this.colIsDeal.Visible = false;
            // 
            // colIsDelivery
            // 
            this.colIsDelivery.DataPropertyName = "IsDeliveryName";
            this.colIsDelivery.FillWeight = 25F;
            this.colIsDelivery.HeaderText = "送货上楼";
            this.colIsDelivery.Name = "colIsDelivery";
            this.colIsDelivery.ReadOnly = true;
            // 
            // colDealName
            // 
            this.colDealName.DataPropertyName = "IsDealName";
            this.colDealName.FillWeight = 25F;
            this.colDealName.HeaderText = "处理";
            this.colDealName.Name = "colDealName";
            this.colDealName.ReadOnly = true;
            // 
            // colRemark
            // 
            this.colRemark.DataPropertyName = "Remark";
            this.colRemark.HeaderText = "备注";
            this.colRemark.Name = "colRemark";
            this.colRemark.ReadOnly = true;
            this.colRemark.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(210, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "日期";
            // 
            // dTStart
            // 
            this.dTStart.Location = new System.Drawing.Point(245, 12);
            this.dTStart.Name = "dTStart";
            this.dTStart.Size = new System.Drawing.Size(121, 21);
            this.dTStart.TabIndex = 2;
            // 
            // cbxClientId
            // 
            this.cbxClientId.FormattingEnabled = true;
            this.cbxClientId.Location = new System.Drawing.Point(447, 11);
            this.cbxClientId.Name = "cbxClientId";
            this.cbxClientId.Size = new System.Drawing.Size(121, 20);
            this.cbxClientId.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(414, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "客户";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "查询";
            // 
            // cbxStatus
            // 
            this.cbxStatus.FormattingEnabled = true;
            this.cbxStatus.Items.AddRange(new object[] {
            "全部",
            "已处理",
            "待处理"});
            this.cbxStatus.Location = new System.Drawing.Point(58, 13);
            this.cbxStatus.Name = "cbxStatus";
            this.cbxStatus.Size = new System.Drawing.Size(121, 20);
            this.cbxStatus.TabIndex = 3;
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.Gold;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.Location = new System.Drawing.Point(600, 10);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 4;
            this.btnLoad.Text = "加载";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMenuDeliveryOrder});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(125, 26);
            // 
            // TSMenuDeliveryOrder
            // 
            this.TSMenuDeliveryOrder.Name = "TSMenuDeliveryOrder";
            this.TSMenuDeliveryOrder.Size = new System.Drawing.Size(124, 22);
            this.TSMenuDeliveryOrder.Text = "生成订单";
            this.TSMenuDeliveryOrder.Click += new System.EventHandler(this.TSMenuDeliveryOrder_Click);
            // 
            // FrmClientOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1318, 649);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.cbxStatus);
            this.Controls.Add(this.cbxClientId);
            this.Controls.Add(this.dTStart);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvClientOrder);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmClientOrder";
            this.Text = "客户订单管理";
            this.Load += new System.EventHandler(this.FrmClientOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientOrder)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClientOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dTStart;
        private System.Windows.Forms.ComboBox cbxClientId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxStatus;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClientOrderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colListnumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAirWaybillID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSourTransType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSourceTransId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAirArriverTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClientId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClientPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClientAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReceiver;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReceiverPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReceiverAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIsDeliver;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIsDeal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIsDelivery;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDealName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRemark;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TSMenuDeliveryOrder;
    }
}