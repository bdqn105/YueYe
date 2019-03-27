namespace LogisPrj
{
    partial class FrmTranferAddProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTranferAddProduct));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.cbxproductId = new System.Windows.Forms.ComboBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.lblUnitofMeasurement = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtVolumeDescription = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.label39 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnFee = new System.Windows.Forms.Button();
            this.cbxfeetype = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFee = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvOrderFee = new System.Windows.Forms.DataGridView();
            this.colDelete = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDeliveryOrderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDeliveryOrderDetailID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colfeetype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFeetypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colfee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRemark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotalFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkIfShow = new System.Windows.Forms.CheckBox();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderFee)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.btnAddProduct);
            this.groupBox3.Controls.Add(this.cbxproductId);
            this.groupBox3.Controls.Add(this.label26);
            this.groupBox3.Controls.Add(this.label32);
            this.groupBox3.Controls.Add(this.lblUnitofMeasurement);
            this.groupBox3.Controls.Add(this.txtWeight);
            this.groupBox3.Controls.Add(this.label37);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.txtVolumeDescription);
            this.groupBox3.Controls.Add(this.txtQuantity);
            this.groupBox3.Controls.Add(this.label27);
            this.groupBox3.Controls.Add(this.label38);
            this.groupBox3.Controls.Add(this.txtRemark);
            this.groupBox3.Controls.Add(this.label39);
            this.groupBox3.Location = new System.Drawing.Point(12, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(755, 114);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(205, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 65;
            this.label3.Text = "KG";
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduct.Location = new System.Drawing.Point(235, 20);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(70, 22);
            this.btnAddProduct.TabIndex = 64;
            this.btnAddProduct.Text = "增加货品";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // cbxproductId
            // 
            this.cbxproductId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxproductId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxproductId.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbxproductId.FormattingEnabled = true;
            this.cbxproductId.Location = new System.Drawing.Point(74, 20);
            this.cbxproductId.Name = "cbxproductId";
            this.cbxproductId.Size = new System.Drawing.Size(155, 20);
            this.cbxproductId.TabIndex = 1;
            this.cbxproductId.SelectedValueChanged += new System.EventHandler(this.cbxproductId_SelectedValueChanged);
            this.cbxproductId.MouseLeave += new System.EventHandler(this.cbxproductId_MouseLeave);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(42, 24);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(29, 12);
            this.label26.TabIndex = 0;
            this.label26.Text = "货品";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.BackColor = System.Drawing.Color.Transparent;
            this.label32.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label32.ForeColor = System.Drawing.Color.Brown;
            this.label32.Location = new System.Drawing.Point(29, 23);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(14, 14);
            this.label32.TabIndex = 63;
            this.label32.Tag = "";
            this.label32.Text = "*";
            // 
            // lblUnitofMeasurement
            // 
            this.lblUnitofMeasurement.AutoSize = true;
            this.lblUnitofMeasurement.Location = new System.Drawing.Point(666, 25);
            this.lblUnitofMeasurement.Name = "lblUnitofMeasurement";
            this.lblUnitofMeasurement.Size = new System.Drawing.Size(29, 12);
            this.lblUnitofMeasurement.TabIndex = 0;
            this.lblUnitofMeasurement.Text = "计量";
            // 
            // txtWeight
            // 
            this.txtWeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtWeight.Location = new System.Drawing.Point(74, 47);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(125, 21);
            this.txtWeight.TabIndex = 4;
            this.txtWeight.Text = "0";
            this.txtWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWeight_KeyPress);
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(42, 52);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(29, 12);
            this.label37.TabIndex = 0;
            this.label37.Text = "重量";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(534, 25);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(29, 12);
            this.label19.TabIndex = 0;
            this.label19.Text = "件数";
            // 
            // txtVolumeDescription
            // 
            this.txtVolumeDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVolumeDescription.Location = new System.Drawing.Point(569, 50);
            this.txtVolumeDescription.Name = "txtVolumeDescription";
            this.txtVolumeDescription.Size = new System.Drawing.Size(174, 21);
            this.txtVolumeDescription.TabIndex = 6;
            // 
            // txtQuantity
            // 
            this.txtQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQuantity.Location = new System.Drawing.Point(569, 21);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(97, 21);
            this.txtQuantity.TabIndex = 3;
            this.txtQuantity.Text = "0";
            this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantity_KeyPress);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label27.ForeColor = System.Drawing.Color.Brown;
            this.label27.Location = new System.Drawing.Point(521, 24);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(14, 14);
            this.label27.TabIndex = 1;
            this.label27.Tag = "";
            this.label27.Text = "*";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(510, 55);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(53, 12);
            this.label38.TabIndex = 0;
            this.label38.Text = "体积描述";
            // 
            // txtRemark
            // 
            this.txtRemark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemark.Location = new System.Drawing.Point(74, 77);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(669, 23);
            this.txtRemark.TabIndex = 7;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(42, 79);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(29, 12);
            this.label39.TabIndex = 0;
            this.label39.Text = "备注";
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.ForestGreen;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Location = new System.Drawing.Point(631, 17);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "增加";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnFee
            // 
            this.btnFee.Location = new System.Drawing.Point(190, 17);
            this.btnFee.Name = "btnFee";
            this.btnFee.Size = new System.Drawing.Size(32, 22);
            this.btnFee.TabIndex = 0;
            this.btnFee.Text = "...";
            this.btnFee.UseVisualStyleBackColor = true;
            this.btnFee.Click += new System.EventHandler(this.btnFee_Click);
            // 
            // cbxfeetype
            // 
            this.cbxfeetype.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbxfeetype.FormattingEnabled = true;
            this.cbxfeetype.Location = new System.Drawing.Point(89, 18);
            this.cbxfeetype.Name = "cbxfeetype";
            this.cbxfeetype.Size = new System.Drawing.Size(97, 20);
            this.cbxfeetype.TabIndex = 1;
            this.cbxfeetype.SelectedValueChanged += new System.EventHandler(this.cbxfeetype_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "费用类型";
            // 
            // txtFee
            // 
            this.txtFee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFee.Location = new System.Drawing.Point(536, 17);
            this.txtFee.Name = "txtFee";
            this.txtFee.Size = new System.Drawing.Size(87, 21);
            this.txtFee.TabIndex = 2;
            this.txtFee.Text = "0";
            this.txtFee.Click += new System.EventHandler(this.txtFee_Click);
            this.txtFee.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFee_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(503, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "单价";
            // 
            // dgvOrderFee
            // 
            this.dgvOrderFee.AllowUserToAddRows = false;
            this.dgvOrderFee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrderFee.BackgroundColor = System.Drawing.Color.White;
            this.dgvOrderFee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderFee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDelete,
            this.colId,
            this.colDeliveryOrderId,
            this.colDeliveryOrderDetailID,
            this.colQuantity,
            this.colfeetype,
            this.colFeetypeName,
            this.colfee,
            this.colRemark,
            this.colTotalFee});
            this.dgvOrderFee.Location = new System.Drawing.Point(38, 50);
            this.dgvOrderFee.Name = "dgvOrderFee";
            this.dgvOrderFee.RowHeadersVisible = false;
            this.dgvOrderFee.RowTemplate.Height = 23;
            this.dgvOrderFee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrderFee.Size = new System.Drawing.Size(702, 131);
            this.dgvOrderFee.TabIndex = 0;
            this.dgvOrderFee.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrderFee_CellClick);
            this.dgvOrderFee.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrderFee_CellContentClick);
            // 
            // colDelete
            // 
            this.colDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.NullValue = "删除";
            this.colDelete.DefaultCellStyle = dataGridViewCellStyle3;
            this.colDelete.HeaderText = "";
            this.colDelete.Name = "colDelete";
            this.colDelete.Width = 5;
            // 
            // colId
            // 
            this.colId.DataPropertyName = "Id";
            dataGridViewCellStyle4.NullValue = "删除";
            this.colId.DefaultCellStyle = dataGridViewCellStyle4;
            this.colId.HeaderText = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = false;
            // 
            // colDeliveryOrderId
            // 
            this.colDeliveryOrderId.DataPropertyName = "DeliveryOrderId";
            this.colDeliveryOrderId.HeaderText = "订单号";
            this.colDeliveryOrderId.Name = "colDeliveryOrderId";
            this.colDeliveryOrderId.Visible = false;
            // 
            // colDeliveryOrderDetailID
            // 
            this.colDeliveryOrderDetailID.DataPropertyName = "DeliveryOrderDetailID";
            this.colDeliveryOrderDetailID.HeaderText = "订单里面的序号";
            this.colDeliveryOrderDetailID.Name = "colDeliveryOrderDetailID";
            this.colDeliveryOrderDetailID.Visible = false;
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
            this.colfeetype.FillWeight = 40F;
            this.colfeetype.HeaderText = "费用类型编号";
            this.colfeetype.Name = "colfeetype";
            this.colfeetype.Visible = false;
            // 
            // colFeetypeName
            // 
            this.colFeetypeName.DataPropertyName = "feetypeName";
            this.colFeetypeName.FillWeight = 40F;
            this.colFeetypeName.HeaderText = "费用类型";
            this.colFeetypeName.Name = "colFeetypeName";
            // 
            // colfee
            // 
            this.colfee.DataPropertyName = "fee";
            this.colfee.FillWeight = 40F;
            this.colfee.HeaderText = "费用/单位";
            this.colfee.Name = "colfee";
            // 
            // colRemark
            // 
            this.colRemark.DataPropertyName = "Remark";
            this.colRemark.HeaderText = "备注";
            this.colRemark.Name = "colRemark";
            this.colRemark.Visible = false;
            // 
            // colTotalFee
            // 
            this.colTotalFee.DataPropertyName = "totalFee";
            this.colTotalFee.FillWeight = 40F;
            this.colTotalFee.HeaderText = "总费用";
            this.colTotalFee.Name = "colTotalFee";
            this.colTotalFee.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(677, 319);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkIfShow);
            this.groupBox1.Controls.Add(this.btnOK);
            this.groupBox1.Controls.Add(this.btnFee);
            this.groupBox1.Controls.Add(this.dgvOrderFee);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbxfeetype);
            this.groupBox1.Controls.Add(this.txtFee);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 122);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(755, 191);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "货品相关费用详细信息";
            // 
            // chkIfShow
            // 
            this.chkIfShow.AutoSize = true;
            this.chkIfShow.Location = new System.Drawing.Point(373, 20);
            this.chkIfShow.Name = "chkIfShow";
            this.chkIfShow.Size = new System.Drawing.Size(48, 16);
            this.chkIfShow.TabIndex = 4;
            this.chkIfShow.Text = "显示";
            this.chkIfShow.UseVisualStyleBackColor = true;
            // 
            // FrmTranferAddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 347);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTranferAddProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "货品信息";
            this.Load += new System.EventHandler(this.FrmTranferAddProduct_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderFee)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbxproductId;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblUnitofMeasurement;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.TextBox txtVolumeDescription;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.ComboBox cbxfeetype;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFee;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFee;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.DataGridView dgvOrderFee;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewLinkColumn colDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDeliveryOrderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDeliveryOrderDetailID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colfeetype;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFeetypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colfee;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRemark;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotalFee;
        private System.Windows.Forms.CheckBox chkIfShow;
    }
}