namespace LogisPrj
{
    partial class FrmTransferTempInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTransferTempInfo));
            this.txtDeliveryId = new System.Windows.Forms.TextBox();
            this.dgvTempInfo = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDeliveryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTemperature1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTemperature2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTemperature3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHumidity1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHumidity2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHumidity3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCurrentTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTempInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDeliveryId
            // 
            this.txtDeliveryId.Location = new System.Drawing.Point(96, 16);
            this.txtDeliveryId.Name = "txtDeliveryId";
            this.txtDeliveryId.Size = new System.Drawing.Size(120, 21);
            this.txtDeliveryId.TabIndex = 14;
            // 
            // dgvTempInfo
            // 
            this.dgvTempInfo.AllowUserToAddRows = false;
            this.dgvTempInfo.AllowUserToDeleteRows = false;
            this.dgvTempInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTempInfo.BackgroundColor = System.Drawing.Color.White;
            this.dgvTempInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTempInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.colID,
            this.colDeliveryId,
            this.colTemperature1,
            this.colTemperature2,
            this.colTemperature3,
            this.colHumidity1,
            this.colHumidity2,
            this.colHumidity3,
            this.colCurrentTime});
            this.dgvTempInfo.Location = new System.Drawing.Point(46, 46);
            this.dgvTempInfo.Name = "dgvTempInfo";
            this.dgvTempInfo.RowHeadersVisible = false;
            this.dgvTempInfo.RowTemplate.Height = 23;
            this.dgvTempInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTempInfo.Size = new System.Drawing.Size(1151, 558);
            this.dgvTempInfo.TabIndex = 13;
            this.dgvTempInfo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTempInfo_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.FillWeight = 10F;
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            // 
            // colID
            // 
            this.colID.DataPropertyName = "Id";
            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = false;
            // 
            // colDeliveryId
            // 
            this.colDeliveryId.HeaderText = "配送单号";
            this.colDeliveryId.Name = "colDeliveryId";
            this.colDeliveryId.Visible = false;
            // 
            // colTemperature1
            // 
            this.colTemperature1.DataPropertyName = "Temperature1";
            this.colTemperature1.HeaderText = "温度1";
            this.colTemperature1.Name = "colTemperature1";
            // 
            // colTemperature2
            // 
            this.colTemperature2.DataPropertyName = "Temperature2";
            this.colTemperature2.HeaderText = "温度2";
            this.colTemperature2.Name = "colTemperature2";
            // 
            // colTemperature3
            // 
            this.colTemperature3.DataPropertyName = "Temperature3";
            this.colTemperature3.HeaderText = "温度3";
            this.colTemperature3.Name = "colTemperature3";
            // 
            // colHumidity1
            // 
            this.colHumidity1.DataPropertyName = "Humidity1";
            this.colHumidity1.HeaderText = "湿度1";
            this.colHumidity1.Name = "colHumidity1";
            this.colHumidity1.Visible = false;
            // 
            // colHumidity2
            // 
            this.colHumidity2.DataPropertyName = "Humidity2";
            this.colHumidity2.HeaderText = "湿度2";
            this.colHumidity2.Name = "colHumidity2";
            this.colHumidity2.Visible = false;
            // 
            // colHumidity3
            // 
            this.colHumidity3.DataPropertyName = "Humidity3";
            this.colHumidity3.HeaderText = "湿度3";
            this.colHumidity3.Name = "colHumidity3";
            this.colHumidity3.Visible = false;
            // 
            // colCurrentTime
            // 
            this.colCurrentTime.DataPropertyName = "CurrentTime";
            this.colCurrentTime.HeaderText = "时间";
            this.colCurrentTime.Name = "colCurrentTime";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(786, 15);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "增加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Visible = false;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(705, 15);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 12;
            this.btnLoad.Text = "查询";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Visible = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(453, 16);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 21);
            this.dateTimePicker1.TabIndex = 10;
            this.dateTimePicker1.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(257, 16);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(394, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "开始时间";
            this.label2.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "配送编号";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(222, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "车辆";
            this.label1.Visible = false;
            // 
            // FrmTransferTempInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 621);
            this.Controls.Add(this.txtDeliveryId);
            this.Controls.Add(this.dgvTempInfo);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmTransferTempInfo";
            this.Text = "温湿度详细信息";
            this.Load += new System.EventHandler(this.FrmTransferTempInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTempInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDeliveryId;
        private System.Windows.Forms.DataGridView dgvTempInfo;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDeliveryId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTemperature1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTemperature2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTemperature3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHumidity1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHumidity2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHumidity3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCurrentTime;
    }
}