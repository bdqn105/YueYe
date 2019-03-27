namespace LogisPrj
{
    partial class FrmJamphotomanger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmJamphotomanger));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnUploadJamPhoto = new System.Windows.Forms.Button();
            this.btnLoadJamPhoto = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtJamPhotos = new System.Windows.Forms.TextBox();
            this.txtJamId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvJamphoto = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colJamID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colJamPhotos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJamphoto)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.btnUploadJamPhoto);
            this.splitContainer1.Panel1.Controls.Add(this.btnLoadJamPhoto);
            this.splitContainer1.Panel1.Controls.Add(this.btnClose);
            this.splitContainer1.Panel1.Controls.Add(this.txtJamPhotos);
            this.splitContainer1.Panel1.Controls.Add(this.txtJamId);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvJamphoto);
            this.splitContainer1.Size = new System.Drawing.Size(1104, 415);
            this.splitContainer1.SplitterDistance = 31;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnUploadJamPhoto
            // 
            this.btnUploadJamPhoto.Location = new System.Drawing.Point(640, 4);
            this.btnUploadJamPhoto.Name = "btnUploadJamPhoto";
            this.btnUploadJamPhoto.Size = new System.Drawing.Size(75, 23);
            this.btnUploadJamPhoto.TabIndex = 3;
            this.btnUploadJamPhoto.Text = "上传图片";
            this.btnUploadJamPhoto.UseVisualStyleBackColor = true;
            this.btnUploadJamPhoto.Click += new System.EventHandler(this.btnUploadJamPhoto_Click);
            // 
            // btnLoadJamPhoto
            // 
            this.btnLoadJamPhoto.Location = new System.Drawing.Point(559, 4);
            this.btnLoadJamPhoto.Name = "btnLoadJamPhoto";
            this.btnLoadJamPhoto.Size = new System.Drawing.Size(75, 23);
            this.btnLoadJamPhoto.TabIndex = 2;
            this.btnLoadJamPhoto.Text = "加载图片";
            this.btnLoadJamPhoto.UseVisualStyleBackColor = true;
            this.btnLoadJamPhoto.Click += new System.EventHandler(this.btnLoadJamPhoto_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(1021, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtJamPhotos
            // 
            this.txtJamPhotos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtJamPhotos.Location = new System.Drawing.Point(289, 6);
            this.txtJamPhotos.Name = "txtJamPhotos";
            this.txtJamPhotos.Size = new System.Drawing.Size(269, 21);
            this.txtJamPhotos.TabIndex = 1;
            // 
            // txtJamId
            // 
            this.txtJamId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtJamId.Location = new System.Drawing.Point(65, 5);
            this.txtJamId.Name = "txtJamId";
            this.txtJamId.Size = new System.Drawing.Size(100, 21);
            this.txtJamId.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "堵车照片URL";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "堵车编号";
            // 
            // dgvJamphoto
            // 
            this.dgvJamphoto.AllowUserToAddRows = false;
            this.dgvJamphoto.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            this.dgvJamphoto.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvJamphoto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvJamphoto.BackgroundColor = System.Drawing.Color.White;
            this.dgvJamphoto.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvJamphoto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJamphoto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colJamID,
            this.colJamPhotos});
            this.dgvJamphoto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvJamphoto.Location = new System.Drawing.Point(0, 0);
            this.dgvJamphoto.Name = "dgvJamphoto";
            this.dgvJamphoto.ReadOnly = true;
            this.dgvJamphoto.RowHeadersVisible = false;
            this.dgvJamphoto.RowTemplate.Height = 23;
            this.dgvJamphoto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvJamphoto.Size = new System.Drawing.Size(1104, 380);
            this.dgvJamphoto.TabIndex = 0;
            // 
            // colId
            // 
            this.colId.DataPropertyName = "Id";
            this.colId.HeaderText = "ID";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Visible = false;
            // 
            // colJamID
            // 
            this.colJamID.DataPropertyName = "JamId";
            this.colJamID.FillWeight = 30F;
            this.colJamID.HeaderText = "堵车编号";
            this.colJamID.Name = "colJamID";
            this.colJamID.ReadOnly = true;
            // 
            // colJamPhotos
            // 
            this.colJamPhotos.DataPropertyName = "JamPhotos";
            this.colJamPhotos.FillWeight = 60F;
            this.colJamPhotos.HeaderText = "堵车照片";
            this.colJamPhotos.Name = "colJamPhotos";
            this.colJamPhotos.ReadOnly = true;
            // 
            // FrmJamphotomanger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 415);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmJamphotomanger";
            this.Text = "堵车照片管理";
            this.Load += new System.EventHandler(this.FrmJamphotomanger_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJamphoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtJamPhotos;
        private System.Windows.Forms.TextBox txtJamId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvJamphoto;
        private System.Windows.Forms.Button btnUploadJamPhoto;
        private System.Windows.Forms.Button btnLoadJamPhoto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colJamID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colJamPhotos;
    }
}