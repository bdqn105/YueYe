namespace LogisPrj
{
    partial class FrmTransferFeeInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTransferFeeInfo));
            this.dgvOrderfee = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDeliveryOrderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coldeliveryOrderDetail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorderFeetype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFeetypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOrderfee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderfee)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOrderfee
            // 
            this.dgvOrderfee.AllowUserToAddRows = false;
            this.dgvOrderfee.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOrderfee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrderfee.BackgroundColor = System.Drawing.Color.White;
            this.dgvOrderfee.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvOrderfee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderfee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colProductId,
            this.colProductName,
            this.colQuantity,
            this.colWeight,
            this.colDeliveryOrderId,
            this.coldeliveryOrderDetail,
            this.colorderFeetype,
            this.colFeetypeName,
            this.colOrderfee});
            this.dgvOrderfee.Location = new System.Drawing.Point(12, 12);
            this.dgvOrderfee.Name = "dgvOrderfee";
            this.dgvOrderfee.RowHeadersVisible = false;
            this.dgvOrderfee.RowTemplate.Height = 23;
            this.dgvOrderfee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrderfee.Size = new System.Drawing.Size(861, 302);
            this.dgvOrderfee.TabIndex = 70;
            // 
            // colId
            // 
            this.colId.HeaderText = "ID";
            this.colId.Name = "colId";
            this.colId.Visible = false;
            // 
            // colProductId
            // 
            this.colProductId.DataPropertyName = "ProductId";
            this.colProductId.HeaderText = "货品编号";
            this.colProductId.Name = "colProductId";
            this.colProductId.Visible = false;
            // 
            // colProductName
            // 
            this.colProductName.DataPropertyName = "ProductName";
            this.colProductName.HeaderText = "货品";
            this.colProductName.Name = "colProductName";
            // 
            // colQuantity
            // 
            this.colQuantity.DataPropertyName = "ProductCount";
            this.colQuantity.HeaderText = "件数";
            this.colQuantity.Name = "colQuantity";
            // 
            // colWeight
            // 
            this.colWeight.DataPropertyName = "ProductWeight";
            this.colWeight.HeaderText = "重量";
            this.colWeight.Name = "colWeight";
            // 
            // colDeliveryOrderId
            // 
            this.colDeliveryOrderId.DataPropertyName = "DeliveryOrderId";
            this.colDeliveryOrderId.HeaderText = "订单号";
            this.colDeliveryOrderId.Name = "colDeliveryOrderId";
            this.colDeliveryOrderId.Visible = false;
            // 
            // coldeliveryOrderDetail
            // 
            this.coldeliveryOrderDetail.DataPropertyName = "DeliveryOrderDetailID";
            this.coldeliveryOrderDetail.HeaderText = "订单序号";
            this.coldeliveryOrderDetail.Name = "coldeliveryOrderDetail";
            this.coldeliveryOrderDetail.Visible = false;
            // 
            // colorderFeetype
            // 
            this.colorderFeetype.DataPropertyName = "FeetypeId";
            this.colorderFeetype.HeaderText = "费用类型编号";
            this.colorderFeetype.Name = "colorderFeetype";
            this.colorderFeetype.Visible = false;
            // 
            // colFeetypeName
            // 
            this.colFeetypeName.DataPropertyName = "feetypeName";
            this.colFeetypeName.HeaderText = "费用类型";
            this.colFeetypeName.Name = "colFeetypeName";
            // 
            // colOrderfee
            // 
            this.colOrderfee.DataPropertyName = "fee";
            this.colOrderfee.HeaderText = "金额";
            this.colOrderfee.Name = "colOrderfee";
            // 
            // FrmTransferFeeInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 326);
            this.Controls.Add(this.dgvOrderfee);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmTransferFeeInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "订单费用详细信息";
            this.Load += new System.EventHandler(this.FrmTransferFeeInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderfee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOrderfee;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDeliveryOrderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn coldeliveryOrderDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorderFeetype;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFeetypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrderfee;
    }
}