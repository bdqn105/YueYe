namespace LogisPrj
{
    partial class FrmRoadtollInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRoadtollInfo));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.picRoadtall = new System.Windows.Forms.PictureBox();
            this.txtDeliveryId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dTTollTime = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtOrderNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTollStation = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRoadtall)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.picRoadtall);
            this.groupBox1.Controls.Add(this.txtDeliveryId);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.dTTollTime);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtOrderNumber);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtMoney);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtTollStation);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(682, 352);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // picRoadtall
            // 
            this.picRoadtall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picRoadtall.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picRoadtall.Location = new System.Drawing.Point(65, 73);
            this.picRoadtall.Name = "picRoadtall";
            this.picRoadtall.Size = new System.Drawing.Size(586, 273);
            this.picRoadtall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRoadtall.TabIndex = 9;
            this.picRoadtall.TabStop = false;
            this.picRoadtall.LoadCompleted += new System.ComponentModel.AsyncCompletedEventHandler(this.picRoadtall_LoadCompleted);
            this.picRoadtall.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.picRoadtall_MouseDoubleClick);
            // 
            // txtDeliveryId
            // 
            this.txtDeliveryId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDeliveryId.Location = new System.Drawing.Point(65, 14);
            this.txtDeliveryId.Name = "txtDeliveryId";
            this.txtDeliveryId.Size = new System.Drawing.Size(120, 21);
            this.txtDeliveryId.TabIndex = 5;
            this.txtDeliveryId.Leave += new System.EventHandler(this.txtDeliveryId_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(634, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 12);
            this.label7.TabIndex = 4;
            this.label7.Text = "元";
            // 
            // dTTollTime
            // 
            this.dTTollTime.Location = new System.Drawing.Point(366, 14);
            this.dTTollTime.Name = "dTTollTime";
            this.dTTollTime.Size = new System.Drawing.Size(130, 21);
            this.dTTollTime.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "运单号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "序号";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "收费站";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(331, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "时间";
            // 
            // txtOrderNumber
            // 
            this.txtOrderNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOrderNumber.Location = new System.Drawing.Point(236, 14);
            this.txtOrderNumber.Name = "txtOrderNumber";
            this.txtOrderNumber.Size = new System.Drawing.Size(62, 21);
            this.txtOrderNumber.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(524, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "金额";
            // 
            // txtMoney
            // 
            this.txtMoney.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMoney.Location = new System.Drawing.Point(559, 14);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.Size = new System.Drawing.Size(69, 21);
            this.txtMoney.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "发票照片";
            // 
            // txtTollStation
            // 
            this.txtTollStation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTollStation.Location = new System.Drawing.Point(65, 42);
            this.txtTollStation.Name = "txtTollStation";
            this.txtTollStation.Size = new System.Drawing.Size(586, 21);
            this.txtTollStation.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(588, 370);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FrmRoadtollInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 405);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRoadtollInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "车辆过路费详细信息";
            this.Load += new System.EventHandler(this.FrmRoadtollInfo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRoadtall)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDeliveryId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dTTollTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtOrderNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMoney;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTollStation;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox picRoadtall;
    }
}