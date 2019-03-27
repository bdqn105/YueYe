namespace LogisPrj
{
    partial class FrmVehicleJam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVehicleJam));
            this.dgvJam = new System.Windows.Forms.DataGridView();
            this.colJamId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDeliverId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colJamTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colJamLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLongitude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLatitude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDeliveryId = new System.Windows.Forms.TextBox();
            this.btnLoad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJam)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvJam
            // 
            this.dgvJam.AllowUserToAddRows = false;
            this.dgvJam.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvJam.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvJam.BackgroundColor = System.Drawing.Color.White;
            this.dgvJam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJam.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colJamId,
            this.colDeliverId,
            this.colJamTime,
            this.colJamLocation,
            this.colLongitude,
            this.colLatitude});
            this.dgvJam.Location = new System.Drawing.Point(3, 34);
            this.dgvJam.Name = "dgvJam";
            this.dgvJam.RowHeadersVisible = false;
            this.dgvJam.RowTemplate.Height = 23;
            this.dgvJam.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvJam.Size = new System.Drawing.Size(1064, 558);
            this.dgvJam.TabIndex = 0;
            this.dgvJam.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvJam_CellDoubleClick);
            // 
            // colJamId
            // 
            this.colJamId.DataPropertyName = "JamId";
            this.colJamId.HeaderText = "Id";
            this.colJamId.Name = "colJamId";
            this.colJamId.Visible = false;
            // 
            // colDeliverId
            // 
            this.colDeliverId.DataPropertyName = "DeliverId";
            this.colDeliverId.FillWeight = 30F;
            this.colDeliverId.HeaderText = "配送编号";
            this.colDeliverId.Name = "colDeliverId";
            // 
            // colJamTime
            // 
            this.colJamTime.DataPropertyName = "JamTime";
            this.colJamTime.FillWeight = 50F;
            this.colJamTime.HeaderText = "时间";
            this.colJamTime.Name = "colJamTime";
            // 
            // colJamLocation
            // 
            this.colJamLocation.DataPropertyName = "JamLocation";
            this.colJamLocation.FillWeight = 70F;
            this.colJamLocation.HeaderText = "图片位置";
            this.colJamLocation.Name = "colJamLocation";
            // 
            // colLongitude
            // 
            this.colLongitude.DataPropertyName = "Longitude";
            this.colLongitude.HeaderText = "经度";
            this.colLongitude.Name = "colLongitude";
            this.colLongitude.Visible = false;
            // 
            // colLatitude
            // 
            this.colLatitude.DataPropertyName = "Latitude";
            this.colLatitude.HeaderText = "纬度";
            this.colLatitude.Name = "colLatitude";
            this.colLatitude.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "配送编号";
            // 
            // txtDeliveryId
            // 
            this.txtDeliveryId.Location = new System.Drawing.Point(71, 6);
            this.txtDeliveryId.Name = "txtDeliveryId";
            this.txtDeliveryId.Size = new System.Drawing.Size(129, 21);
            this.txtDeliveryId.TabIndex = 2;
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.Gold;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.Location = new System.Drawing.Point(226, 4);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 3;
            this.btnLoad.Text = "查询";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // FrmVehicleJam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 595);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.txtDeliveryId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvJam);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmVehicleJam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "车辆堵车照片管理";
            this.Load += new System.EventHandler(this.FrmVehicleJam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvJam;
        private System.Windows.Forms.DataGridViewTextBoxColumn colJamId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDeliverId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colJamTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colJamLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLongitude;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLatitude;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDeliveryId;
        private System.Windows.Forms.Button btnLoad;
    }
}