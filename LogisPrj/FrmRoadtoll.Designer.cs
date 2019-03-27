namespace LogisPrj
{
    partial class FrmRoadtoll
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRoadtoll));
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.cbxDriverId = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDeliveryId = new System.Windows.Forms.TextBox();
            this.dgvRoadtoll = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDeliveryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDriverId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDriverName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOrderNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTollStation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTollTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInvoicePhoto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.txtStart = new System.Windows.Forms.TextBox();
            this.monStart = new System.Windows.Forms.MonthCalendar();
            this.monEnd = new System.Windows.Forms.MonthCalendar();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoadtoll)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Gold;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(786, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 25;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(1227, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.Red;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.Location = new System.Drawing.Point(174, 30);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 4;
            this.btnDel.Text = "删除";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Visible = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnModify
            // 
            this.btnModify.BackColor = System.Drawing.Color.Peru;
            this.btnModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModify.Location = new System.Drawing.Point(93, 30);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 23);
            this.btnModify.TabIndex = 4;
            this.btnModify.Text = "修改";
            this.btnModify.UseVisualStyleBackColor = false;
            this.btnModify.Visible = false;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // cbxDriverId
            // 
            this.cbxDriverId.FormattingEnabled = true;
            this.cbxDriverId.Location = new System.Drawing.Point(656, 5);
            this.cbxDriverId.Name = "cbxDriverId";
            this.cbxDriverId.Size = new System.Drawing.Size(112, 20);
            this.cbxDriverId.TabIndex = 22;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(12, 30);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "增加";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Visible = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(237, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 15;
            this.label4.Text = "日期";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 19;
            this.label1.Text = "配送编号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(613, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 18;
            this.label2.Text = "驾驶员";
            // 
            // txtDeliveryId
            // 
            this.txtDeliveryId.Location = new System.Drawing.Point(74, 5);
            this.txtDeliveryId.Name = "txtDeliveryId";
            this.txtDeliveryId.Size = new System.Drawing.Size(150, 21);
            this.txtDeliveryId.TabIndex = 20;
            // 
            // dgvRoadtoll
            // 
            this.dgvRoadtoll.AllowUserToAddRows = false;
            this.dgvRoadtoll.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            this.dgvRoadtoll.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRoadtoll.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRoadtoll.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRoadtoll.BackgroundColor = System.Drawing.Color.White;
            this.dgvRoadtoll.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvRoadtoll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoadtoll.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colDeliveryId,
            this.colDriverId,
            this.colDriverName,
            this.colOrderNumber,
            this.colTollStation,
            this.colMoney,
            this.colTollTime,
            this.colInvoicePhoto});
            this.dgvRoadtoll.Location = new System.Drawing.Point(0, 59);
            this.dgvRoadtoll.Name = "dgvRoadtoll";
            this.dgvRoadtoll.ReadOnly = true;
            this.dgvRoadtoll.RowHeadersVisible = false;
            this.dgvRoadtoll.RowTemplate.Height = 23;
            this.dgvRoadtoll.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRoadtoll.Size = new System.Drawing.Size(1310, 572);
            this.dgvRoadtoll.TabIndex = 0;
            this.dgvRoadtoll.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRoadtoll_CellClick);
            this.dgvRoadtoll.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRoadtoll_CellDoubleClick);
            // 
            // colId
            // 
            this.colId.DataPropertyName = "Id";
            this.colId.HeaderText = "ID";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
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
            // colDriverId
            // 
            this.colDriverId.DataPropertyName = "DriverId";
            this.colDriverId.HeaderText = "驾驶员编号";
            this.colDriverId.Name = "colDriverId";
            this.colDriverId.ReadOnly = true;
            this.colDriverId.Visible = false;
            // 
            // colDriverName
            // 
            this.colDriverName.DataPropertyName = "DriverName";
            this.colDriverName.FillWeight = 30F;
            this.colDriverName.HeaderText = "驾驶员";
            this.colDriverName.Name = "colDriverName";
            this.colDriverName.ReadOnly = true;
            // 
            // colOrderNumber
            // 
            this.colOrderNumber.DataPropertyName = "OrderNumber";
            this.colOrderNumber.FillWeight = 30F;
            this.colOrderNumber.HeaderText = "序号";
            this.colOrderNumber.Name = "colOrderNumber";
            this.colOrderNumber.ReadOnly = true;
            // 
            // colTollStation
            // 
            this.colTollStation.DataPropertyName = "TollStation";
            this.colTollStation.FillWeight = 50F;
            this.colTollStation.HeaderText = "收费站";
            this.colTollStation.Name = "colTollStation";
            this.colTollStation.ReadOnly = true;
            // 
            // colMoney
            // 
            this.colMoney.DataPropertyName = "Money";
            this.colMoney.FillWeight = 20F;
            this.colMoney.HeaderText = "金额";
            this.colMoney.Name = "colMoney";
            this.colMoney.ReadOnly = true;
            // 
            // colTollTime
            // 
            this.colTollTime.DataPropertyName = "TollTime";
            this.colTollTime.FillWeight = 60F;
            this.colTollTime.HeaderText = "时间";
            this.colTollTime.Name = "colTollTime";
            this.colTollTime.ReadOnly = true;
            // 
            // colInvoicePhoto
            // 
            this.colInvoicePhoto.DataPropertyName = "InvoicePhoto";
            this.colInvoicePhoto.FillWeight = 80F;
            this.colInvoicePhoto.HeaderText = "发票照片";
            this.colInvoicePhoto.Name = "colInvoicePhoto";
            this.colInvoicePhoto.ReadOnly = true;
            this.colInvoicePhoto.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(411, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 28;
            this.label3.Text = "至";
            // 
            // txtEnd
            // 
            this.txtEnd.Location = new System.Drawing.Point(429, 5);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(133, 21);
            this.txtEnd.TabIndex = 26;
            this.txtEnd.Click += new System.EventHandler(this.txtDeliveryTimeEnd_Click);
            // 
            // txtStart
            // 
            this.txtStart.Location = new System.Drawing.Point(276, 5);
            this.txtStart.Name = "txtStart";
            this.txtStart.Size = new System.Drawing.Size(133, 21);
            this.txtStart.TabIndex = 27;
            this.txtStart.Click += new System.EventHandler(this.txtDeliveryTimeStart_Click);
            this.txtStart.Leave += new System.EventHandler(this.txtDeliveryTimeStart_Leave);
            // 
            // monStart
            // 
            this.monStart.Location = new System.Drawing.Point(276, 30);
            this.monStart.Name = "monStart";
            this.monStart.TabIndex = 29;
            this.monStart.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monStart_DateSelected);
            // 
            // monEnd
            // 
            this.monEnd.Location = new System.Drawing.Point(429, 30);
            this.monEnd.Name = "monEnd";
            this.monEnd.TabIndex = 29;
            this.monEnd.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monEnd_DateSelected);
            // 
            // FrmRoadtoll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1310, 631);
            this.Controls.Add(this.monEnd);
            this.Controls.Add(this.monStart);
            this.Controls.Add(this.dgvRoadtoll);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxDriverId);
            this.Controls.Add(this.txtEnd);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.txtStart);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDeliveryId);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRoadtoll";
            this.Text = "过路费用表";
            this.Load += new System.EventHandler(this.FrmRoadtoll_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoadtoll)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvRoadtoll;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cbxDriverId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDeliveryId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEnd;
        private System.Windows.Forms.TextBox txtStart;
        private System.Windows.Forms.MonthCalendar monStart;
        private System.Windows.Forms.MonthCalendar monEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDeliveryId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDriverId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDriverName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrderNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTollStation;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTollTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInvoicePhoto;
    }
}