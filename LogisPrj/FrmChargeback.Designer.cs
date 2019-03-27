namespace LogisPrj
{
    partial class FrmChargeback
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmChargeback));
            this.dgvChargeBack = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDeliveryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDeliveryOrderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colChargeBackDispose = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colChargebackerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colChargebackTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChargeBack)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvChargeBack
            // 
            this.dgvChargeBack.AllowUserToAddRows = false;
            this.dgvChargeBack.AllowUserToDeleteRows = false;
            this.dgvChargeBack.AllowUserToOrderColumns = true;
            this.dgvChargeBack.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChargeBack.BackgroundColor = System.Drawing.Color.White;
            this.dgvChargeBack.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChargeBack.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colDeliveryId,
            this.colDeliveryOrderID,
            this.colChargeBackDispose,
            this.colChargebackerId,
            this.colChargebackTime});
            this.dgvChargeBack.Location = new System.Drawing.Point(12, 32);
            this.dgvChargeBack.Name = "dgvChargeBack";
            this.dgvChargeBack.RowTemplate.Height = 23;
            this.dgvChargeBack.Size = new System.Drawing.Size(1198, 606);
            this.dgvChargeBack.TabIndex = 0;
            // 
            // colId
            // 
            this.colId.HeaderText = "ID";
            this.colId.Name = "colId";
            this.colId.Visible = false;
            // 
            // colDeliveryId
            // 
            this.colDeliveryId.HeaderText = "运单编号";
            this.colDeliveryId.Name = "colDeliveryId";
            // 
            // colDeliveryOrderID
            // 
            this.colDeliveryOrderID.HeaderText = "订单编号";
            this.colDeliveryOrderID.Name = "colDeliveryOrderID";
            // 
            // colChargeBackDispose
            // 
            this.colChargeBackDispose.HeaderText = "退单描述";
            this.colChargeBackDispose.Name = "colChargeBackDispose";
            // 
            // colChargebackerId
            // 
            this.colChargebackerId.HeaderText = "退单人编号";
            this.colChargebackerId.Name = "colChargebackerId";
            // 
            // colChargebackTime
            // 
            this.colChargebackTime.HeaderText = "退单时间";
            this.colChargebackTime.Name = "colChargebackTime";
            // 
            // FrmChargeback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 650);
            this.Controls.Add(this.dgvChargeBack);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmChargeback";
            this.Text = "退单详细信息";
            this.Load += new System.EventHandler(this.FrmChargeback_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChargeBack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvChargeBack;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDeliveryId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDeliveryOrderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colChargeBackDispose;
        private System.Windows.Forms.DataGridViewTextBoxColumn colChargebackerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colChargebackTime;
    }
}