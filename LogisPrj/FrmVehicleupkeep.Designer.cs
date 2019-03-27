namespace LogisPrj
{
    partial class FrmVehicleupkeep
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVehicleupkeep));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dtupkeepEnd = new System.Windows.Forms.DateTimePicker();
            this.dtupkeepStart = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cbxDriverId = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxVehicleId = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvVehicleKeep = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVehicleId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVehicleNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKilometres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUpkeepDescribe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUpkeepMoneys = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUpkeepTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUpkeepMan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKeepManName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUpkeepLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInvoicePhoto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicleKeep)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dtupkeepEnd);
            this.splitContainer1.Panel1.Controls.Add(this.dtupkeepStart);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.btnSearch);
            this.splitContainer1.Panel1.Controls.Add(this.cbxDriverId);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.cbxVehicleId);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.btnClose);
            this.splitContainer1.Panel1.Controls.Add(this.btnModify);
            this.splitContainer1.Panel1.Controls.Add(this.btnAdd);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvVehicleKeep);
            this.splitContainer1.Size = new System.Drawing.Size(1100, 549);
            this.splitContainer1.SplitterDistance = 74;
            this.splitContainer1.TabIndex = 0;
            // 
            // dtupkeepEnd
            // 
            this.dtupkeepEnd.Location = new System.Drawing.Point(585, 4);
            this.dtupkeepEnd.Name = "dtupkeepEnd";
            this.dtupkeepEnd.Size = new System.Drawing.Size(126, 21);
            this.dtupkeepEnd.TabIndex = 17;
            this.dtupkeepEnd.ValueChanged += new System.EventHandler(this.dtupkeepEnd_ValueChanged);
            // 
            // dtupkeepStart
            // 
            this.dtupkeepStart.Location = new System.Drawing.Point(430, 4);
            this.dtupkeepStart.Name = "dtupkeepStart";
            this.dtupkeepStart.Size = new System.Drawing.Size(126, 21);
            this.dtupkeepStart.TabIndex = 17;
            this.dtupkeepStart.ValueChanged += new System.EventHandler(this.dtupkeepStart_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(562, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 15;
            this.label4.Text = "至";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(393, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 15;
            this.label3.Text = "日期";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Gold;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(749, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cbxDriverId
            // 
            this.cbxDriverId.FormattingEnabled = true;
            this.cbxDriverId.Location = new System.Drawing.Point(224, 5);
            this.cbxDriverId.Name = "cbxDriverId";
            this.cbxDriverId.Size = new System.Drawing.Size(121, 20);
            this.cbxDriverId.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 12;
            this.label2.Text = "保养人";
            // 
            // cbxVehicleId
            // 
            this.cbxVehicleId.FormattingEnabled = true;
            this.cbxVehicleId.Location = new System.Drawing.Point(47, 5);
            this.cbxVehicleId.Name = "cbxVehicleId";
            this.cbxVehicleId.Size = new System.Drawing.Size(121, 20);
            this.cbxVehicleId.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 12;
            this.label1.Text = "车辆";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(1022, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnModify
            // 
            this.btnModify.BackColor = System.Drawing.Color.Peru;
            this.btnModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModify.Location = new System.Drawing.Point(87, 48);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 23);
            this.btnModify.TabIndex = 9;
            this.btnModify.Text = "修改";
            this.btnModify.UseVisualStyleBackColor = false;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(6, 48);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvVehicleKeep
            // 
            this.dgvVehicleKeep.AllowUserToAddRows = false;
            this.dgvVehicleKeep.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            this.dgvVehicleKeep.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvVehicleKeep.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVehicleKeep.BackgroundColor = System.Drawing.Color.White;
            this.dgvVehicleKeep.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvVehicleKeep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehicleKeep.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colVehicleId,
            this.colVehicleNumber,
            this.colKilometres,
            this.colUpkeepDescribe,
            this.colUpkeepMoneys,
            this.colUpkeepTime,
            this.colUpkeepMan,
            this.colKeepManName,
            this.colUpkeepLocation,
            this.colInvoicePhoto});
            this.dgvVehicleKeep.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVehicleKeep.Location = new System.Drawing.Point(0, 0);
            this.dgvVehicleKeep.Name = "dgvVehicleKeep";
            this.dgvVehicleKeep.ReadOnly = true;
            this.dgvVehicleKeep.RowHeadersVisible = false;
            this.dgvVehicleKeep.RowTemplate.Height = 23;
            this.dgvVehicleKeep.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVehicleKeep.Size = new System.Drawing.Size(1100, 471);
            this.dgvVehicleKeep.TabIndex = 0;
            this.dgvVehicleKeep.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVehicleKeep_CellClick);
            this.dgvVehicleKeep.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVehicleKeep_CellDoubleClick);
            // 
            // colId
            // 
            this.colId.DataPropertyName = "Id";
            this.colId.HeaderText = "ID";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Visible = false;
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
            this.colVehicleNumber.DataPropertyName = "VehicleNumber";
            this.colVehicleNumber.FillWeight = 30F;
            this.colVehicleNumber.HeaderText = "车辆";
            this.colVehicleNumber.Name = "colVehicleNumber";
            this.colVehicleNumber.ReadOnly = true;
            // 
            // colKilometres
            // 
            this.colKilometres.DataPropertyName = "Kilometres";
            this.colKilometres.FillWeight = 20F;
            this.colKilometres.HeaderText = "保养公里数";
            this.colKilometres.Name = "colKilometres";
            this.colKilometres.ReadOnly = true;
            this.colKilometres.Visible = false;
            // 
            // colUpkeepDescribe
            // 
            this.colUpkeepDescribe.DataPropertyName = "UpkeepDescribe";
            this.colUpkeepDescribe.FillWeight = 80F;
            this.colUpkeepDescribe.HeaderText = "保养描述";
            this.colUpkeepDescribe.Name = "colUpkeepDescribe";
            this.colUpkeepDescribe.ReadOnly = true;
            this.colUpkeepDescribe.Visible = false;
            // 
            // colUpkeepMoneys
            // 
            this.colUpkeepMoneys.DataPropertyName = "UpkeepMoneys";
            this.colUpkeepMoneys.FillWeight = 20F;
            this.colUpkeepMoneys.HeaderText = "保养总金额";
            this.colUpkeepMoneys.Name = "colUpkeepMoneys";
            this.colUpkeepMoneys.ReadOnly = true;
            // 
            // colUpkeepTime
            // 
            this.colUpkeepTime.DataPropertyName = "UpkeepTime";
            this.colUpkeepTime.FillWeight = 50F;
            this.colUpkeepTime.HeaderText = "保养时间";
            this.colUpkeepTime.Name = "colUpkeepTime";
            this.colUpkeepTime.ReadOnly = true;
            // 
            // colUpkeepMan
            // 
            this.colUpkeepMan.DataPropertyName = "UpkeepMan";
            this.colUpkeepMan.FillWeight = 30F;
            this.colUpkeepMan.HeaderText = "保养人编号";
            this.colUpkeepMan.Name = "colUpkeepMan";
            this.colUpkeepMan.ReadOnly = true;
            this.colUpkeepMan.Visible = false;
            // 
            // colKeepManName
            // 
            this.colKeepManName.DataPropertyName = "KeepManName";
            this.colKeepManName.FillWeight = 30F;
            this.colKeepManName.HeaderText = "保养人";
            this.colKeepManName.Name = "colKeepManName";
            this.colKeepManName.ReadOnly = true;
            // 
            // colUpkeepLocation
            // 
            this.colUpkeepLocation.DataPropertyName = "UpkeepLocation";
            this.colUpkeepLocation.FillWeight = 70F;
            this.colUpkeepLocation.HeaderText = "保养地点";
            this.colUpkeepLocation.Name = "colUpkeepLocation";
            this.colUpkeepLocation.ReadOnly = true;
            // 
            // colInvoicePhoto
            // 
            this.colInvoicePhoto.DataPropertyName = "InvoicePhoto";
            this.colInvoicePhoto.HeaderText = "发票照片";
            this.colInvoicePhoto.Name = "colInvoicePhoto";
            this.colInvoicePhoto.ReadOnly = true;
            this.colInvoicePhoto.Visible = false;
            // 
            // FrmVehicleupkeep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 549);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmVehicleupkeep";
            this.Text = "车辆保养";
            this.Load += new System.EventHandler(this.FrmVehicleupkeep_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicleKeep)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvVehicleKeep;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cbxVehicleId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxDriverId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtupkeepEnd;
        private System.Windows.Forms.DateTimePicker dtupkeepStart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVehicleId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVehicleNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKilometres;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUpkeepDescribe;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUpkeepMoneys;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUpkeepTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUpkeepMan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKeepManName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUpkeepLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInvoicePhoto;
    }
}