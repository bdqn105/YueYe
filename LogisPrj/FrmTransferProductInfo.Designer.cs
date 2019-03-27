namespace LogisPrj
{
    partial class FrmTransferProductInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTransferProductInfo));
            this.dgvProductList = new System.Windows.Forms.DataGridView();
            this.columnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coluDeliveryOrderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOrderDetailId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVolumeDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colfeetype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colfeetypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProductFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colfee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRemark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvOrderFee = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDeliveryOrderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDeliveryOrderDetailID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotalFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIsShow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOrderProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderFee)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProductList
            // 
            this.dgvProductList.AllowUserToAddRows = false;
            this.dgvProductList.AllowUserToResizeRows = false;
            this.dgvProductList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProductList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductList.BackgroundColor = System.Drawing.Color.White;
            this.dgvProductList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnID,
            this.coluDeliveryOrderId,
            this.colOrderDetailId,
            this.colProductName,
            this.colProductId,
            this.colQuantity,
            this.colWeight,
            this.colVolumeDescription,
            this.colfeetype,
            this.colfeetypeName,
            this.colProductFee,
            this.colfee,
            this.colRemark});
            this.dgvProductList.Location = new System.Drawing.Point(12, 12);
            this.dgvProductList.Name = "dgvProductList";
            this.dgvProductList.ReadOnly = true;
            this.dgvProductList.RowHeadersVisible = false;
            this.dgvProductList.RowTemplate.Height = 23;
            this.dgvProductList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductList.Size = new System.Drawing.Size(785, 144);
            this.dgvProductList.TabIndex = 82;
            // 
            // columnID
            // 
            this.columnID.DataPropertyName = "Id";
            this.columnID.HeaderText = "ID";
            this.columnID.Name = "columnID";
            this.columnID.ReadOnly = true;
            this.columnID.Visible = false;
            // 
            // coluDeliveryOrderId
            // 
            this.coluDeliveryOrderId.DataPropertyName = "DeliveryOrderId";
            this.coluDeliveryOrderId.HeaderText = "订单编号";
            this.coluDeliveryOrderId.Name = "coluDeliveryOrderId";
            this.coluDeliveryOrderId.ReadOnly = true;
            this.coluDeliveryOrderId.Visible = false;
            // 
            // colOrderDetailId
            // 
            this.colOrderDetailId.DataPropertyName = "OrderDetailId";
            this.colOrderDetailId.FillWeight = 20F;
            this.colOrderDetailId.HeaderText = "订单序号";
            this.colOrderDetailId.Name = "colOrderDetailId";
            this.colOrderDetailId.ReadOnly = true;
            this.colOrderDetailId.Visible = false;
            // 
            // colProductName
            // 
            this.colProductName.DataPropertyName = "ProductName";
            this.colProductName.FillWeight = 30F;
            this.colProductName.HeaderText = "货品";
            this.colProductName.Name = "colProductName";
            this.colProductName.ReadOnly = true;
            // 
            // colProductId
            // 
            this.colProductId.DataPropertyName = "ProductId";
            this.colProductId.FillWeight = 20F;
            this.colProductId.HeaderText = "货品编号";
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
            // 
            // colWeight
            // 
            this.colWeight.DataPropertyName = "weight";
            this.colWeight.FillWeight = 10F;
            this.colWeight.HeaderText = "重量";
            this.colWeight.Name = "colWeight";
            this.colWeight.ReadOnly = true;
            // 
            // colVolumeDescription
            // 
            this.colVolumeDescription.DataPropertyName = "VolumeDescription";
            this.colVolumeDescription.FillWeight = 40F;
            this.colVolumeDescription.HeaderText = "体积描述";
            this.colVolumeDescription.Name = "colVolumeDescription";
            this.colVolumeDescription.ReadOnly = true;
            // 
            // colfeetype
            // 
            this.colfeetype.DataPropertyName = "feetype";
            this.colfeetype.FillWeight = 30F;
            this.colfeetype.HeaderText = "费用类型";
            this.colfeetype.Name = "colfeetype";
            this.colfeetype.ReadOnly = true;
            this.colfeetype.Visible = false;
            // 
            // colfeetypeName
            // 
            this.colfeetypeName.DataPropertyName = "feetypeName";
            this.colfeetypeName.FillWeight = 20F;
            this.colfeetypeName.HeaderText = "费用类型";
            this.colfeetypeName.Name = "colfeetypeName";
            this.colfeetypeName.ReadOnly = true;
            // 
            // colProductFee
            // 
            this.colProductFee.DataPropertyName = "fee";
            this.colProductFee.FillWeight = 20F;
            this.colProductFee.HeaderText = "费用/单位";
            this.colProductFee.Name = "colProductFee";
            this.colProductFee.ReadOnly = true;
            // 
            // colfee
            // 
            this.colfee.DataPropertyName = "totalfee";
            this.colfee.FillWeight = 20F;
            this.colfee.HeaderText = "总金额";
            this.colfee.Name = "colfee";
            this.colfee.ReadOnly = true;
            // 
            // colRemark
            // 
            this.colRemark.DataPropertyName = "Remark";
            this.colRemark.FillWeight = 50F;
            this.colRemark.HeaderText = "备注";
            this.colRemark.Name = "colRemark";
            this.colRemark.ReadOnly = true;
            this.colRemark.Visible = false;
            // 
            // dgvOrderFee
            // 
            this.dgvOrderFee.AllowUserToAddRows = false;
            this.dgvOrderFee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrderFee.BackgroundColor = System.Drawing.Color.White;
            this.dgvOrderFee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderFee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colDeliveryOrderId,
            this.colDeliveryOrderDetailID,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.colTotalFee,
            this.dataGridViewTextBoxColumn6,
            this.colIsShow,
            this.colOrderProductId});
            this.dgvOrderFee.Location = new System.Drawing.Point(12, 173);
            this.dgvOrderFee.Name = "dgvOrderFee";
            this.dgvOrderFee.RowHeadersVisible = false;
            this.dgvOrderFee.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvOrderFee.RowTemplate.Height = 23;
            this.dgvOrderFee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrderFee.Size = new System.Drawing.Size(785, 275);
            this.dgvOrderFee.TabIndex = 83;
            // 
            // colId
            // 
            this.colId.DataPropertyName = "Id";
            dataGridViewCellStyle2.NullValue = "删除";
            this.colId.DefaultCellStyle = dataGridViewCellStyle2;
            this.colId.HeaderText = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = false;
            // 
            // colDeliveryOrderId
            // 
            this.colDeliveryOrderId.DataPropertyName = "DeliveryOrderId";
            this.colDeliveryOrderId.FillWeight = 50F;
            this.colDeliveryOrderId.HeaderText = "订单号";
            this.colDeliveryOrderId.Name = "colDeliveryOrderId";
            this.colDeliveryOrderId.Visible = false;
            // 
            // colDeliveryOrderDetailID
            // 
            this.colDeliveryOrderDetailID.DataPropertyName = "DeliveryOrderDetailID";
            this.colDeliveryOrderDetailID.HeaderText = "订单序号";
            this.colDeliveryOrderDetailID.Name = "colDeliveryOrderDetailID";
            this.colDeliveryOrderDetailID.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "productName";
            this.dataGridViewTextBoxColumn1.FillWeight = 40F;
            this.dataGridViewTextBoxColumn1.HeaderText = "货品";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ProductCount";
            this.dataGridViewTextBoxColumn2.FillWeight = 30F;
            this.dataGridViewTextBoxColumn2.HeaderText = "数量";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "feetypeId";
            this.dataGridViewTextBoxColumn3.HeaderText = "费用类型编号";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "feetypeName";
            this.dataGridViewTextBoxColumn4.FillWeight = 30F;
            this.dataGridViewTextBoxColumn4.HeaderText = "费用类型";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "fee";
            this.dataGridViewTextBoxColumn5.FillWeight = 40F;
            this.dataGridViewTextBoxColumn5.HeaderText = "金额/单位";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // colTotalFee
            // 
            this.colTotalFee.DataPropertyName = "totalFee";
            this.colTotalFee.HeaderText = "总费用";
            this.colTotalFee.Name = "colTotalFee";
            this.colTotalFee.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Remark";
            this.dataGridViewTextBoxColumn6.HeaderText = "备注";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // colIsShow
            // 
            this.colIsShow.DataPropertyName = "IsShow";
            this.colIsShow.HeaderText = "显示";
            this.colIsShow.Name = "colIsShow";
            this.colIsShow.Visible = false;
            // 
            // colOrderProductId
            // 
            this.colOrderProductId.DataPropertyName = "ProductId";
            this.colOrderProductId.HeaderText = "货品";
            this.colOrderProductId.Name = "colOrderProductId";
            this.colOrderProductId.Visible = false;
            // 
            // FrmTransferProductInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 460);
            this.Controls.Add(this.dgvOrderFee);
            this.Controls.Add(this.dgvProductList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTransferProductInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "货品信息";
            this.Load += new System.EventHandler(this.FrmTransferProductInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderFee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProductList;
        private System.Windows.Forms.DataGridView dgvOrderFee;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDeliveryOrderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDeliveryOrderDetailID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotalFee;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIsShow;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrderProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn coluDeliveryOrderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrderDetailId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVolumeDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn colfeetype;
        private System.Windows.Forms.DataGridViewTextBoxColumn colfeetypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductFee;
        private System.Windows.Forms.DataGridViewTextBoxColumn colfee;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRemark;
    }
}