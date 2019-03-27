namespace LogisPrj
{
    partial class FrmVehicleKeepReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVehicleKeepReport));
            this.rpView = new Microsoft.Reporting.WinForms.ReportViewer();
            this.vehicleupkeepBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.vehicleupkeepBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rpView
            // 
            this.rpView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpView.LocalReport.ReportEmbeddedResource = "LogisPrj.VehicleKeep.rdlc";
            this.rpView.Location = new System.Drawing.Point(0, 0);
            this.rpView.Name = "rpView";
            this.rpView.Size = new System.Drawing.Size(860, 437);
            this.rpView.TabIndex = 0;
            // 
            // vehicleupkeepBindingSource
            // 
            this.vehicleupkeepBindingSource.DataSource = typeof(YueYePlat.Model.vehicleupkeep);
            // 
            // FrmVehicleKeepReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 437);
            this.Controls.Add(this.rpView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmVehicleKeepReport";
            this.Text = "车辆保养报表";
            this.Load += new System.EventHandler(this.FrmVehicleKeepReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vehicleupkeepBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpView;
        private System.Windows.Forms.BindingSource vehicleupkeepBindingSource;
    }
}