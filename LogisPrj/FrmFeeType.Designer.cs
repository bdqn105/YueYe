namespace LogisPrj
{
    partial class FrmFeeType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFeeType));
            this.txtFeeTypeName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvFeeType = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFeeTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDefaultFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDefaultFee = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ckBisDetailWight = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFeeType)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFeeTypeName
            // 
            this.txtFeeTypeName.Location = new System.Drawing.Point(87, 14);
            this.txtFeeTypeName.Name = "txtFeeTypeName";
            this.txtFeeTypeName.Size = new System.Drawing.Size(189, 21);
            this.txtFeeTypeName.TabIndex = 0;
            this.txtFeeTypeName.Enter += new System.EventHandler(this.txtFeeTypeName_Enter);
            this.txtFeeTypeName.Leave += new System.EventHandler(this.txtFeeTypeName_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "费用类型名称";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(555, 85);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "增加";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvFeeType
            // 
            this.dgvFeeType.AllowUserToAddRows = false;
            this.dgvFeeType.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFeeType.BackgroundColor = System.Drawing.Color.White;
            this.dgvFeeType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFeeType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colFeeTypeName,
            this.colDefaultFee});
            this.dgvFeeType.Location = new System.Drawing.Point(12, 64);
            this.dgvFeeType.Name = "dgvFeeType";
            this.dgvFeeType.RowHeadersVisible = false;
            this.dgvFeeType.RowTemplate.Height = 23;
            this.dgvFeeType.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFeeType.Size = new System.Drawing.Size(166, 44);
            this.dgvFeeType.TabIndex = 1;
            this.dgvFeeType.Visible = false;
            // 
            // colId
            // 
            this.colId.DataPropertyName = "Id";
            this.colId.FillWeight = 30F;
            this.colId.HeaderText = "编号";
            this.colId.Name = "colId";
            this.colId.Visible = false;
            // 
            // colFeeTypeName
            // 
            this.colFeeTypeName.DataPropertyName = "FeeTypeName";
            this.colFeeTypeName.FillWeight = 50F;
            this.colFeeTypeName.HeaderText = "费用类型";
            this.colFeeTypeName.Name = "colFeeTypeName";
            // 
            // colDefaultFee
            // 
            this.colDefaultFee.DataPropertyName = "DefaultFee";
            this.colDefaultFee.HeaderText = "默认费用";
            this.colDefaultFee.Name = "colDefaultFee";
            // 
            // txtDefaultFee
            // 
            this.txtDefaultFee.Location = new System.Drawing.Point(340, 14);
            this.txtDefaultFee.Name = "txtDefaultFee";
            this.txtDefaultFee.Size = new System.Drawing.Size(95, 21);
            this.txtDefaultFee.TabIndex = 1;
            this.txtDefaultFee.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(290, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "默认费用";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(441, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "元";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ckBisDetailWight);
            this.groupBox1.Controls.Add(this.txtFeeTypeName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtDefaultFee);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(1, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(629, 50);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // ckBisDetailWight
            // 
            this.ckBisDetailWight.AutoSize = true;
            this.ckBisDetailWight.Location = new System.Drawing.Point(504, 17);
            this.ckBisDetailWight.Name = "ckBisDetailWight";
            this.ckBisDetailWight.Size = new System.Drawing.Size(108, 16);
            this.ckBisDetailWight.TabIndex = 5;
            this.ckBisDetailWight.Text = "是否和重量相关";
            this.ckBisDetailWight.UseVisualStyleBackColor = true;
            // 
            // FrmFeeType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 120);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvFeeType);
            this.Controls.Add(this.btnAdd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmFeeType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmFeeType";
            this.Load += new System.EventHandler(this.FrmFeeType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFeeType)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtFeeTypeName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvFeeType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFeeTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDefaultFee;
        private System.Windows.Forms.TextBox txtDefaultFee;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ckBisDetailWight;
    }
}