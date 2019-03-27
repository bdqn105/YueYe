namespace LogisPrj
{
    partial class FrmTempvehicle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTempvehicle));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtComents = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxVehicleId = new System.Windows.Forms.ComboBox();
            this.cbxDriverId = new System.Windows.Forms.ComboBox();
            this.btnAddTempVehicle = new System.Windows.Forms.Button();
            this.btnAddtempDriver = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnVehicletoDriver = new System.Windows.Forms.Button();
            this.dgvTempVehicle = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVehicleId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVehicleNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDriverId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDriverName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colComents = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTempVehicle)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.txtComents);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.cbxVehicleId);
            this.splitContainer1.Panel1.Controls.Add(this.cbxDriverId);
            this.splitContainer1.Panel1.Controls.Add(this.btnAddTempVehicle);
            this.splitContainer1.Panel1.Controls.Add(this.btnAddtempDriver);
            this.splitContainer1.Panel1.Controls.Add(this.btnClose);
            this.splitContainer1.Panel1.Controls.Add(this.btnDel);
            this.splitContainer1.Panel1.Controls.Add(this.btnVehicletoDriver);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvTempVehicle);
            this.splitContainer1.Size = new System.Drawing.Size(1227, 658);
            this.splitContainer1.SplitterDistance = 116;
            this.splitContainer1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "备注";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(343, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "驾驶员";
            // 
            // txtComents
            // 
            this.txtComents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtComents.Location = new System.Drawing.Point(66, 41);
            this.txtComents.Multiline = true;
            this.txtComents.Name = "txtComents";
            this.txtComents.Size = new System.Drawing.Size(481, 40);
            this.txtComents.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "车辆";
            // 
            // cbxVehicleId
            // 
            this.cbxVehicleId.FormattingEnabled = true;
            this.cbxVehicleId.Location = new System.Drawing.Point(66, 13);
            this.cbxVehicleId.Name = "cbxVehicleId";
            this.cbxVehicleId.Size = new System.Drawing.Size(121, 20);
            this.cbxVehicleId.TabIndex = 11;
            // 
            // cbxDriverId
            // 
            this.cbxDriverId.FormattingEnabled = true;
            this.cbxDriverId.Location = new System.Drawing.Point(390, 12);
            this.cbxDriverId.Name = "cbxDriverId";
            this.cbxDriverId.Size = new System.Drawing.Size(122, 20);
            this.cbxDriverId.TabIndex = 1;
            // 
            // btnAddTempVehicle
            // 
            this.btnAddTempVehicle.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAddTempVehicle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTempVehicle.Location = new System.Drawing.Point(188, 12);
            this.btnAddTempVehicle.Name = "btnAddTempVehicle";
            this.btnAddTempVehicle.Size = new System.Drawing.Size(21, 23);
            this.btnAddTempVehicle.TabIndex = 9;
            this.btnAddTempVehicle.Text = "+";
            this.btnAddTempVehicle.UseVisualStyleBackColor = false;
            this.btnAddTempVehicle.Click += new System.EventHandler(this.btnAddTempVehicle_Click);
            // 
            // btnAddtempDriver
            // 
            this.btnAddtempDriver.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAddtempDriver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddtempDriver.Location = new System.Drawing.Point(515, 11);
            this.btnAddtempDriver.Name = "btnAddtempDriver";
            this.btnAddtempDriver.Size = new System.Drawing.Size(21, 23);
            this.btnAddtempDriver.TabIndex = 9;
            this.btnAddtempDriver.Text = "+";
            this.btnAddtempDriver.UseVisualStyleBackColor = false;
            this.btnAddtempDriver.Click += new System.EventHandler(this.btnAddtempDriver_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(1149, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Visible = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.Red;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.Location = new System.Drawing.Point(147, 87);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 6;
            this.btnDel.Text = "删除";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Visible = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnVehicletoDriver
            // 
            this.btnVehicletoDriver.BackColor = System.Drawing.Color.ForestGreen;
            this.btnVehicletoDriver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVehicletoDriver.Location = new System.Drawing.Point(66, 87);
            this.btnVehicletoDriver.Name = "btnVehicletoDriver";
            this.btnVehicletoDriver.Size = new System.Drawing.Size(75, 23);
            this.btnVehicletoDriver.TabIndex = 4;
            this.btnVehicletoDriver.Text = "设置绑定";
            this.btnVehicletoDriver.UseVisualStyleBackColor = false;
            this.btnVehicletoDriver.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvTempVehicle
            // 
            this.dgvTempVehicle.AllowUserToAddRows = false;
            this.dgvTempVehicle.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            this.dgvTempVehicle.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTempVehicle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTempVehicle.BackgroundColor = System.Drawing.Color.White;
            this.dgvTempVehicle.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTempVehicle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTempVehicle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colVehicleId,
            this.colVehicleNumber,
            this.colDriverId,
            this.colDriverName,
            this.colTime,
            this.colComents});
            this.dgvTempVehicle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTempVehicle.Location = new System.Drawing.Point(0, 0);
            this.dgvTempVehicle.Name = "dgvTempVehicle";
            this.dgvTempVehicle.ReadOnly = true;
            this.dgvTempVehicle.RowHeadersVisible = false;
            this.dgvTempVehicle.RowTemplate.Height = 23;
            this.dgvTempVehicle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTempVehicle.Size = new System.Drawing.Size(1227, 538);
            this.dgvTempVehicle.TabIndex = 0;
            this.dgvTempVehicle.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTempVehicle_CellClick);
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
            // colDriverId
            // 
            this.colDriverId.DataPropertyName = "DriverId";
            this.colDriverId.FillWeight = 30F;
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
            // colTime
            // 
            this.colTime.DataPropertyName = "Time";
            this.colTime.FillWeight = 60F;
            this.colTime.HeaderText = "时间";
            this.colTime.Name = "colTime";
            this.colTime.ReadOnly = true;
            // 
            // colComents
            // 
            this.colComents.DataPropertyName = "Coments";
            this.colComents.FillWeight = 150F;
            this.colComents.HeaderText = "备注";
            this.colComents.Name = "colComents";
            this.colComents.ReadOnly = true;
            // 
            // FrmTempvehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 658);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTempvehicle";
            this.Text = "临时车辆信息";
            this.Load += new System.EventHandler(this.FrmTempvehicle_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTempVehicle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ComboBox cbxDriverId;
        private System.Windows.Forms.TextBox txtComents;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnVehicletoDriver;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvTempVehicle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAddTempVehicle;
        private System.Windows.Forms.Button btnAddtempDriver;
        private System.Windows.Forms.ComboBox cbxVehicleId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVehicleId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVehicleNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDriverId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDriverName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colComents;
    }
}