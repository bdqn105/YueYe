namespace LogisPrj
{
    partial class FrmTransferFee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTransferFee));
            this.cbxFeeType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.btnAddFeeType = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvOrderFee = new System.Windows.Forms.DataGridView();
            this.colDelete = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colModify = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDeliveryOrderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDeliveryOrderDetailID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colfeetype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFeetypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colfee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotalFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRemark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkIsShow = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderFee)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxFeeType
            // 
            this.cbxFeeType.FormattingEnabled = true;
            this.cbxFeeType.Location = new System.Drawing.Point(66, 16);
            this.cbxFeeType.Name = "cbxFeeType";
            this.cbxFeeType.Size = new System.Drawing.Size(104, 20);
            this.cbxFeeType.TabIndex = 0;
            this.cbxFeeType.SelectedValueChanged += new System.EventHandler(this.cbxFeeType_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "费用类型";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(265, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "金额";
            // 
            // txtMoney
            // 
            this.txtMoney.Location = new System.Drawing.Point(300, 15);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.Size = new System.Drawing.Size(100, 21);
            this.txtMoney.TabIndex = 2;
            this.txtMoney.Text = "0";
            // 
            // btnAddFeeType
            // 
            this.btnAddFeeType.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAddFeeType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddFeeType.Location = new System.Drawing.Point(173, 15);
            this.btnAddFeeType.Name = "btnAddFeeType";
            this.btnAddFeeType.Size = new System.Drawing.Size(39, 23);
            this.btnAddFeeType.TabIndex = 4;
            this.btnAddFeeType.Text = "增加";
            this.btnAddFeeType.UseVisualStyleBackColor = false;
            this.btnAddFeeType.Click += new System.EventHandler(this.btnAddFeeType_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(628, 368);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.ForestGreen;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Location = new System.Drawing.Point(576, 21);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "确认";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvOrderFee);
            this.groupBox1.Location = new System.Drawing.Point(24, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(697, 304);
            this.groupBox1.TabIndex = 69;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "订单费用相关详细信息";
            // 
            // dgvOrderFee
            // 
            this.dgvOrderFee.AllowUserToAddRows = false;
            this.dgvOrderFee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrderFee.BackgroundColor = System.Drawing.Color.White;
            this.dgvOrderFee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderFee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDelete,
            this.colModify,
            this.colId,
            this.colDeliveryOrderId,
            this.colDeliveryOrderDetailID,
            this.colProductName,
            this.colQuantity,
            this.colfeetype,
            this.colFeetypeName,
            this.colfee,
            this.colTotalFee,
            this.colRemark});
            this.dgvOrderFee.Location = new System.Drawing.Point(10, 20);
            this.dgvOrderFee.Name = "dgvOrderFee";
            this.dgvOrderFee.RowHeadersVisible = false;
            this.dgvOrderFee.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvOrderFee.RowTemplate.Height = 23;
            this.dgvOrderFee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrderFee.Size = new System.Drawing.Size(669, 275);
            this.dgvOrderFee.TabIndex = 68;
            this.dgvOrderFee.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrderFee_CellClick);
            this.dgvOrderFee.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrderFee_CellContentClick);
            // 
            // colDelete
            // 
            this.colDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle4.NullValue = "删除";
            this.colDelete.DefaultCellStyle = dataGridViewCellStyle4;
            this.colDelete.HeaderText = "";
            this.colDelete.Name = "colDelete";
            this.colDelete.Width = 5;
            // 
            // colModify
            // 
            this.colModify.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle5.NullValue = "修改";
            this.colModify.DefaultCellStyle = dataGridViewCellStyle5;
            this.colModify.HeaderText = "修改";
            this.colModify.Name = "colModify";
            this.colModify.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colModify.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colModify.Width = 54;
            // 
            // colId
            // 
            this.colId.DataPropertyName = "Id";
            dataGridViewCellStyle6.NullValue = "删除";
            this.colId.DefaultCellStyle = dataGridViewCellStyle6;
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
            // 
            // colDeliveryOrderDetailID
            // 
            this.colDeliveryOrderDetailID.DataPropertyName = "DeliveryOrderDetailID";
            this.colDeliveryOrderDetailID.HeaderText = "订单序号";
            this.colDeliveryOrderDetailID.Name = "colDeliveryOrderDetailID";
            this.colDeliveryOrderDetailID.Visible = false;
            // 
            // colProductName
            // 
            this.colProductName.DataPropertyName = "productName";
            this.colProductName.FillWeight = 40F;
            this.colProductName.HeaderText = "货品";
            this.colProductName.Name = "colProductName";
            this.colProductName.Visible = false;
            // 
            // colQuantity
            // 
            this.colQuantity.DataPropertyName = "ProductCount";
            this.colQuantity.FillWeight = 30F;
            this.colQuantity.HeaderText = "数量";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.Visible = false;
            // 
            // colfeetype
            // 
            this.colfeetype.DataPropertyName = "feetypeId";
            this.colfeetype.HeaderText = "费用类型编号";
            this.colfeetype.Name = "colfeetype";
            this.colfeetype.Visible = false;
            // 
            // colFeetypeName
            // 
            this.colFeetypeName.DataPropertyName = "feetypeName";
            this.colFeetypeName.FillWeight = 30F;
            this.colFeetypeName.HeaderText = "费用类型";
            this.colFeetypeName.Name = "colFeetypeName";
            // 
            // colfee
            // 
            this.colfee.DataPropertyName = "fee";
            this.colfee.FillWeight = 40F;
            this.colfee.HeaderText = "金额/单位";
            this.colfee.Name = "colfee";
            // 
            // colTotalFee
            // 
            this.colTotalFee.DataPropertyName = "totalFee";
            this.colTotalFee.HeaderText = "总费用";
            this.colTotalFee.Name = "colTotalFee";
            this.colTotalFee.Visible = false;
            // 
            // colRemark
            // 
            this.colRemark.DataPropertyName = "Remark";
            this.colRemark.HeaderText = "备注";
            this.colRemark.Name = "colRemark";
            this.colRemark.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkIsShow);
            this.groupBox2.Controls.Add(this.cbxFeeType);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtMoney);
            this.groupBox2.Controls.Add(this.btnAddFeeType);
            this.groupBox2.Location = new System.Drawing.Point(24, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(535, 49);
            this.groupBox2.TabIndex = 70;
            this.groupBox2.TabStop = false;
            // 
            // chkIsShow
            // 
            this.chkIsShow.AutoSize = true;
            this.chkIsShow.Location = new System.Drawing.Point(455, 18);
            this.chkIsShow.Name = "chkIsShow";
            this.chkIsShow.Size = new System.Drawing.Size(48, 16);
            this.chkIsShow.TabIndex = 5;
            this.chkIsShow.Text = "显示";
            this.chkIsShow.UseVisualStyleBackColor = true;
            // 
            // FrmTransferFee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 402);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnSave);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTransferFee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "订单费用";
            this.Load += new System.EventHandler(this.FrmTransferFee_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderFee)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxFeeType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMoney;
        private System.Windows.Forms.Button btnAddFeeType;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvOrderFee;
        private System.Windows.Forms.DataGridViewLinkColumn colDelete;
        private System.Windows.Forms.DataGridViewLinkColumn colModify;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDeliveryOrderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDeliveryOrderDetailID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colfeetype;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFeetypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colfee;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotalFee;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRemark;
        private System.Windows.Forms.CheckBox chkIsShow;
    }
}