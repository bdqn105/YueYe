namespace LogisPrj
{
    partial class FrmTransferOrderReport
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTransferOrderReport));
            this.vehicledeliveryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rpViewOrder = new Microsoft.Reporting.WinForms.ReportViewer();
            this.productdeliveryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.vehicledeliveryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productdeliveryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // vehicledeliveryBindingSource
            // 
            this.vehicledeliveryBindingSource.DataSource = typeof(YueYePlat.Model.vehicledelivery);
            // 
            // rpViewOrder
            // 
            this.rpViewOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "myDeliveryList";
            reportDataSource2.Value = this.vehicledeliveryBindingSource;
            this.rpViewOrder.LocalReport.DataSources.Add(reportDataSource2);
            this.rpViewOrder.LocalReport.ReportEmbeddedResource = "LogisPrj.Report2.rdlc";
            this.rpViewOrder.Location = new System.Drawing.Point(0, 0);
            this.rpViewOrder.Name = "rpViewOrder";
            this.rpViewOrder.Size = new System.Drawing.Size(1166, 594);
            this.rpViewOrder.TabIndex = 0;
            this.rpViewOrder.Print += new Microsoft.Reporting.WinForms.ReportPrintEventHandler(this.rpViewOrder_Print);
            this.rpViewOrder.Load += new System.EventHandler(this.rpViewOrder_Load);
            // 
            // productdeliveryBindingSource
            // 
            this.productdeliveryBindingSource.DataSource = typeof(YueYePlat.Model.productdelivery);
            // 
            // FrmTransferOrderReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 594);
            this.Controls.Add(this.rpViewOrder);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTransferOrderReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "订单报表信息";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmTransferOrderReport_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmTransferOrderReport_FormClosed);
            this.Load += new System.EventHandler(this.FrmTransferOrderReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vehicledeliveryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productdeliveryBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpViewOrder;
        private System.Windows.Forms.BindingSource productdeliveryBindingSource;
        private System.Windows.Forms.BindingSource vehicledeliveryBindingSource;
    }
}