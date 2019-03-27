namespace LogisPrj
{
    partial class FrmException
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmException));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtDeliveryId = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvException = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDeliverId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExceptionType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExceptiondescribe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExceptionDispose = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSendTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colConductor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDisposeTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvException)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.btnSearch);
            this.splitContainer1.Panel1.Controls.Add(this.txtDeliveryId);
            this.splitContainer1.Panel1.Controls.Add(this.btnClose);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.btnDel);
            this.splitContainer1.Panel1.Controls.Add(this.btnModify);
            this.splitContainer1.Panel1.Controls.Add(this.btnAdd);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvException);
            this.splitContainer1.Size = new System.Drawing.Size(1202, 615);
            this.splitContainer1.SplitterDistance = 63;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Gold;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(261, 7);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtDeliveryId
            // 
            this.txtDeliveryId.Location = new System.Drawing.Point(65, 7);
            this.txtDeliveryId.Name = "txtDeliveryId";
            this.txtDeliveryId.Size = new System.Drawing.Size(184, 21);
            this.txtDeliveryId.TabIndex = 8;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(1124, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "配送编号";
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.Red;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.Location = new System.Drawing.Point(174, 34);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 3;
            this.btnDel.Text = "删除";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Visible = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnModify
            // 
            this.btnModify.BackColor = System.Drawing.Color.Peru;
            this.btnModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModify.Location = new System.Drawing.Point(93, 34);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 23);
            this.btnModify.TabIndex = 2;
            this.btnModify.Text = "修改";
            this.btnModify.UseVisualStyleBackColor = false;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(12, 34);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "增加";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvException
            // 
            this.dgvException.AllowUserToAddRows = false;
            this.dgvException.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            this.dgvException.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvException.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvException.BackgroundColor = System.Drawing.Color.White;
            this.dgvException.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvException.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvException.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colDeliverId,
            this.colExceptionType,
            this.colExceptiondescribe,
            this.colExceptionDispose,
            this.colSender,
            this.colSendTime,
            this.colConductor,
            this.colDisposeTime});
            this.dgvException.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvException.Location = new System.Drawing.Point(0, 0);
            this.dgvException.Name = "dgvException";
            this.dgvException.ReadOnly = true;
            this.dgvException.RowHeadersVisible = false;
            this.dgvException.RowTemplate.Height = 23;
            this.dgvException.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvException.Size = new System.Drawing.Size(1202, 548);
            this.dgvException.TabIndex = 0;
            this.dgvException.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvException_CellClick);
            this.dgvException.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvException_CellDoubleClick);
            // 
            // colId
            // 
            this.colId.DataPropertyName = "Id";
            this.colId.HeaderText = "ID";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Visible = false;
            // 
            // colDeliverId
            // 
            this.colDeliverId.DataPropertyName = "DeliverId";
            this.colDeliverId.FillWeight = 30F;
            this.colDeliverId.HeaderText = "配送编号";
            this.colDeliverId.Name = "colDeliverId";
            this.colDeliverId.ReadOnly = true;
            // 
            // colExceptionType
            // 
            this.colExceptionType.DataPropertyName = "ExceptionType";
            this.colExceptionType.FillWeight = 30F;
            this.colExceptionType.HeaderText = "异常类型";
            this.colExceptionType.Name = "colExceptionType";
            this.colExceptionType.ReadOnly = true;
            // 
            // colExceptiondescribe
            // 
            this.colExceptiondescribe.DataPropertyName = "Exceptiondescribe";
            this.colExceptiondescribe.FillWeight = 80F;
            this.colExceptiondescribe.HeaderText = "异常信息描述";
            this.colExceptiondescribe.Name = "colExceptiondescribe";
            this.colExceptiondescribe.ReadOnly = true;
            // 
            // colExceptionDispose
            // 
            this.colExceptionDispose.DataPropertyName = "ExceptionDispose";
            this.colExceptionDispose.FillWeight = 30F;
            this.colExceptionDispose.HeaderText = "异常处理";
            this.colExceptionDispose.Name = "colExceptionDispose";
            this.colExceptionDispose.ReadOnly = true;
            // 
            // colSender
            // 
            this.colSender.DataPropertyName = "Sender";
            this.colSender.FillWeight = 30F;
            this.colSender.HeaderText = "发送人";
            this.colSender.Name = "colSender";
            this.colSender.ReadOnly = true;
            // 
            // colSendTime
            // 
            this.colSendTime.DataPropertyName = "SendTime";
            this.colSendTime.FillWeight = 50F;
            this.colSendTime.HeaderText = "发送时间";
            this.colSendTime.Name = "colSendTime";
            this.colSendTime.ReadOnly = true;
            // 
            // colConductor
            // 
            this.colConductor.DataPropertyName = "Conductor";
            this.colConductor.FillWeight = 30F;
            this.colConductor.HeaderText = "处理人";
            this.colConductor.Name = "colConductor";
            this.colConductor.ReadOnly = true;
            // 
            // colDisposeTime
            // 
            this.colDisposeTime.DataPropertyName = "DisposeTime";
            this.colDisposeTime.FillWeight = 50F;
            this.colDisposeTime.HeaderText = "处理时间";
            this.colDisposeTime.Name = "colDisposeTime";
            this.colDisposeTime.ReadOnly = true;
            // 
            // FrmException
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 615);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmException";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "异常信息表";
            this.Load += new System.EventHandler(this.FrmException_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvException)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvException;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDeliverId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExceptionType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExceptiondescribe;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExceptionDispose;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSender;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSendTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colConductor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDisposeTime;
        private System.Windows.Forms.TextBox txtDeliveryId;
        private System.Windows.Forms.Button btnSearch;
    }
}