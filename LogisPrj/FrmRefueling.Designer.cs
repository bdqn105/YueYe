namespace LogisPrj
{
    partial class FrmRefueling
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRefueling));
            this.dgvRefuel = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDeliveryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVehicleNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVehicleID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDriverID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDriverName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLongitude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLatitude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPetrolStation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRefuelTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInvoicePhoto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIfVerifyed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIfVerifyedName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVerfielId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cbxVehicleId = new System.Windows.Forms.ComboBox();
            this.cbxDriverId = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDeliveryId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.monEnd = new System.Windows.Forms.MonthCalendar();
            this.monStart = new System.Windows.Forms.MonthCalendar();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.txtStart = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRefuel)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRefuel
            // 
            this.dgvRefuel.AllowUserToAddRows = false;
            this.dgvRefuel.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            this.dgvRefuel.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRefuel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRefuel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRefuel.BackgroundColor = System.Drawing.Color.White;
            this.dgvRefuel.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvRefuel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRefuel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colDeliveryId,
            this.colVehicleNumber,
            this.colVehicleID,
            this.colDriverID,
            this.colDriverName,
            this.colLongitude,
            this.colLatitude,
            this.colPetrolStation,
            this.colMoney,
            this.colQuantity,
            this.colRefuelTime,
            this.colInvoicePhoto,
            this.colIfVerifyed,
            this.colIfVerifyedName,
            this.colVerfielId});
            this.dgvRefuel.Location = new System.Drawing.Point(3, 58);
            this.dgvRefuel.Name = "dgvRefuel";
            this.dgvRefuel.RowHeadersVisible = false;
            this.dgvRefuel.RowTemplate.Height = 23;
            this.dgvRefuel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRefuel.Size = new System.Drawing.Size(1391, 602);
            this.dgvRefuel.TabIndex = 0;
            this.dgvRefuel.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRefuel_CellDoubleClick);
            this.dgvRefuel.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvRefuel_CellPainting);
            // 
            // colId
            // 
            this.colId.DataPropertyName = "Id";
            this.colId.FillWeight = 30F;
            this.colId.HeaderText = "ID";
            this.colId.Name = "colId";
            this.colId.Visible = false;
            // 
            // colDeliveryId
            // 
            this.colDeliveryId.DataPropertyName = "DeliveryId";
            this.colDeliveryId.FillWeight = 30F;
            this.colDeliveryId.HeaderText = "配送编号";
            this.colDeliveryId.Name = "colDeliveryId";
            // 
            // colVehicleNumber
            // 
            this.colVehicleNumber.DataPropertyName = "VehicleNumber";
            this.colVehicleNumber.FillWeight = 30F;
            this.colVehicleNumber.HeaderText = "车辆";
            this.colVehicleNumber.Name = "colVehicleNumber";
            // 
            // colVehicleID
            // 
            this.colVehicleID.DataPropertyName = "VehicleID";
            this.colVehicleID.FillWeight = 30F;
            this.colVehicleID.HeaderText = "车辆编号";
            this.colVehicleID.Name = "colVehicleID";
            this.colVehicleID.Visible = false;
            // 
            // colDriverID
            // 
            this.colDriverID.DataPropertyName = "DriverId";
            this.colDriverID.FillWeight = 30F;
            this.colDriverID.HeaderText = "驾驶员编号";
            this.colDriverID.Name = "colDriverID";
            this.colDriverID.Visible = false;
            // 
            // colDriverName
            // 
            this.colDriverName.DataPropertyName = "DriverName";
            this.colDriverName.FillWeight = 30F;
            this.colDriverName.HeaderText = "驾驶员";
            this.colDriverName.Name = "colDriverName";
            // 
            // colLongitude
            // 
            this.colLongitude.DataPropertyName = "Longitude";
            this.colLongitude.FillWeight = 20F;
            this.colLongitude.HeaderText = "经度";
            this.colLongitude.Name = "colLongitude";
            this.colLongitude.Visible = false;
            // 
            // colLatitude
            // 
            this.colLatitude.DataPropertyName = "Latitude";
            this.colLatitude.FillWeight = 20F;
            this.colLatitude.HeaderText = "纬度";
            this.colLatitude.Name = "colLatitude";
            this.colLatitude.Visible = false;
            // 
            // colPetrolStation
            // 
            this.colPetrolStation.DataPropertyName = "PetrolStation";
            this.colPetrolStation.FillWeight = 50F;
            this.colPetrolStation.HeaderText = "加油站名称";
            this.colPetrolStation.Name = "colPetrolStation";
            // 
            // colMoney
            // 
            this.colMoney.DataPropertyName = "Money";
            this.colMoney.FillWeight = 20F;
            this.colMoney.HeaderText = "金额";
            this.colMoney.Name = "colMoney";
            // 
            // colQuantity
            // 
            this.colQuantity.DataPropertyName = "Quantity";
            this.colQuantity.FillWeight = 20F;
            this.colQuantity.HeaderText = "数量";
            this.colQuantity.Name = "colQuantity";
            // 
            // colRefuelTime
            // 
            this.colRefuelTime.DataPropertyName = "RefuelTime";
            this.colRefuelTime.FillWeight = 50F;
            this.colRefuelTime.HeaderText = "加油日期";
            this.colRefuelTime.Name = "colRefuelTime";
            // 
            // colInvoicePhoto
            // 
            this.colInvoicePhoto.DataPropertyName = "InvoicePhoto";
            this.colInvoicePhoto.FillWeight = 70F;
            this.colInvoicePhoto.HeaderText = "发票照片";
            this.colInvoicePhoto.Name = "colInvoicePhoto";
            this.colInvoicePhoto.Visible = false;
            // 
            // colIfVerifyed
            // 
            this.colIfVerifyed.DataPropertyName = "IfVerifyed";
            this.colIfVerifyed.FillWeight = 20F;
            this.colIfVerifyed.HeaderText = "是否已验证";
            this.colIfVerifyed.Name = "colIfVerifyed";
            this.colIfVerifyed.Visible = false;
            // 
            // colIfVerifyedName
            // 
            this.colIfVerifyedName.DataPropertyName = "IfVerifyedName";
            this.colIfVerifyedName.FillWeight = 10F;
            this.colIfVerifyedName.HeaderText = "验证";
            this.colIfVerifyedName.Name = "colIfVerifyedName";
            // 
            // colVerfielId
            // 
            this.colVerfielId.DataPropertyName = "VerfielId";
            this.colVerfielId.FillWeight = 30F;
            this.colVerfielId.HeaderText = "验证人";
            this.colVerfielId.Name = "colVerfielId";
            this.colVerfielId.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(1319, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 23;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Gold;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(941, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 24;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cbxVehicleId
            // 
            this.cbxVehicleId.FormattingEnabled = true;
            this.cbxVehicleId.Location = new System.Drawing.Point(630, 3);
            this.cbxVehicleId.Name = "cbxVehicleId";
            this.cbxVehicleId.Size = new System.Drawing.Size(120, 20);
            this.cbxVehicleId.TabIndex = 21;
            // 
            // cbxDriverId
            // 
            this.cbxDriverId.FormattingEnabled = true;
            this.cbxDriverId.Location = new System.Drawing.Point(810, 3);
            this.cbxDriverId.Name = "cbxDriverId";
            this.cbxDriverId.Size = new System.Drawing.Size(112, 20);
            this.cbxDriverId.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(598, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 17;
            this.label3.Text = "车辆";
            // 
            // txtDeliveryId
            // 
            this.txtDeliveryId.Location = new System.Drawing.Point(73, 2);
            this.txtDeliveryId.Name = "txtDeliveryId";
            this.txtDeliveryId.Size = new System.Drawing.Size(150, 21);
            this.txtDeliveryId.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(765, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 18;
            this.label2.Text = "驾驶员";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 19;
            this.label1.Text = "配送编号";
            // 
            // btnModify
            // 
            this.btnModify.BackColor = System.Drawing.Color.Peru;
            this.btnModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModify.Location = new System.Drawing.Point(94, 29);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 23);
            this.btnModify.TabIndex = 15;
            this.btnModify.Text = "审核";
            this.btnModify.UseVisualStyleBackColor = false;
            this.btnModify.Visible = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(15, 29);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "增加";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Visible = false;
            // 
            // monEnd
            // 
            this.monEnd.Location = new System.Drawing.Point(436, 37);
            this.monEnd.Name = "monEnd";
            this.monEnd.TabIndex = 34;
            this.monEnd.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monEnd_DateSelected);
            // 
            // monStart
            // 
            this.monStart.Location = new System.Drawing.Point(283, 37);
            this.monStart.Name = "monStart";
            this.monStart.TabIndex = 35;
            this.monStart.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monStart_DateSelected);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(418, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 33;
            this.label4.Text = "至";
            // 
            // txtEnd
            // 
            this.txtEnd.Location = new System.Drawing.Point(436, 4);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(133, 21);
            this.txtEnd.TabIndex = 31;
            this.txtEnd.Click += new System.EventHandler(this.txtEnd_Click);
            // 
            // txtStart
            // 
            this.txtStart.Location = new System.Drawing.Point(283, 4);
            this.txtStart.Name = "txtStart";
            this.txtStart.Size = new System.Drawing.Size(133, 21);
            this.txtStart.TabIndex = 32;
            this.txtStart.Click += new System.EventHandler(this.txtStart_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(244, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 30;
            this.label5.Text = "日期";
            // 
            // FrmRefueling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1399, 660);
            this.Controls.Add(this.monEnd);
            this.Controls.Add(this.monStart);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEnd);
            this.Controls.Add(this.txtStart);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvRefuel);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cbxVehicleId);
            this.Controls.Add(this.cbxDriverId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDeliveryId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnAdd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRefueling";
            this.Text = "车辆加油表";
            this.Load += new System.EventHandler(this.FrmRefueling_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRefuel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvRefuel;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cbxVehicleId;
        private System.Windows.Forms.ComboBox cbxDriverId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDeliveryId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.MonthCalendar monEnd;
        private System.Windows.Forms.MonthCalendar monStart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEnd;
        private System.Windows.Forms.TextBox txtStart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDeliveryId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVehicleNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVehicleID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDriverID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDriverName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLongitude;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLatitude;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPetrolStation;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRefuelTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInvoicePhoto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIfVerifyed;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIfVerifyedName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVerfielId;
    }
}