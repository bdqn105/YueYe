namespace LogisPrj
{
    partial class FrmTransferFeeType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTransferFeeType));
            this.chkLBFeeType = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAddFeeType = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chkLBFeeType
            // 
            this.chkLBFeeType.BackColor = System.Drawing.Color.White;
            this.chkLBFeeType.CheckOnClick = true;
            this.chkLBFeeType.ColumnWidth = 200;
            this.chkLBFeeType.FormattingEnabled = true;
            this.chkLBFeeType.Location = new System.Drawing.Point(31, 41);
            this.chkLBFeeType.MultiColumn = true;
            this.chkLBFeeType.Name = "chkLBFeeType";
            this.chkLBFeeType.Size = new System.Drawing.Size(351, 228);
            this.chkLBFeeType.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(30, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "请选择您要增加的费用：";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(307, 275);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "确定";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAddFeeType
            // 
            this.btnAddFeeType.BackColor = System.Drawing.Color.Gold;
            this.btnAddFeeType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddFeeType.Location = new System.Drawing.Point(226, 275);
            this.btnAddFeeType.Name = "btnAddFeeType";
            this.btnAddFeeType.Size = new System.Drawing.Size(75, 23);
            this.btnAddFeeType.TabIndex = 4;
            this.btnAddFeeType.Text = "增加新费用";
            this.btnAddFeeType.UseVisualStyleBackColor = false;
            this.btnAddFeeType.Click += new System.EventHandler(this.btnAddFeeType_Click);
            // 
            // FrmTransferFeeType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 310);
            this.Controls.Add(this.btnAddFeeType);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkLBFeeType);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTransferFeeType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "费用名称";
            this.Load += new System.EventHandler(this.FrmTransferFeeType_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox chkLBFeeType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAddFeeType;
    }
}