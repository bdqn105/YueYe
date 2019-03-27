namespace LogisPrj
{
    partial class FrmRefuelingInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRefuelingInfo));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.picRefueling = new System.Windows.Forms.PictureBox();
            this.txtDeliveryId = new System.Windows.Forms.TextBox();
            this.chkIfVerifyed = new System.Windows.Forms.CheckBox();
            this.cbxVerfiel = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnUploadImage = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtRefuelTime = new System.Windows.Forms.DateTimePicker();
            this.txtPetrolPostiton = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbxDriverId = new System.Windows.Forms.ComboBox();
            this.cbxVehicleId = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRefueling)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.picRefueling);
            this.groupBox1.Controls.Add(this.txtDeliveryId);
            this.groupBox1.Controls.Add(this.chkIfVerifyed);
            this.groupBox1.Controls.Add(this.cbxVerfiel);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.btnUploadImage);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtRefuelTime);
            this.groupBox1.Controls.Add(this.txtPetrolPostiton);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cbxDriverId);
            this.groupBox1.Controls.Add(this.cbxVehicleId);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtQuantity);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtMoney);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(765, 486);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // picRefueling
            // 
            this.picRefueling.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picRefueling.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picRefueling.Location = new System.Drawing.Point(84, 115);
            this.picRefueling.Name = "picRefueling";
            this.picRefueling.Size = new System.Drawing.Size(606, 329);
            this.picRefueling.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRefueling.TabIndex = 14;
            this.picRefueling.TabStop = false;
            this.picRefueling.LoadCompleted += new System.ComponentModel.AsyncCompletedEventHandler(this.picRefueling_LoadCompleted);
            this.picRefueling.Click += new System.EventHandler(this.picRefueling_Click);
            this.picRefueling.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.picRefueling_MouseDoubleClick);
            // 
            // txtDeliveryId
            // 
            this.txtDeliveryId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDeliveryId.Location = new System.Drawing.Point(84, 21);
            this.txtDeliveryId.Name = "txtDeliveryId";
            this.txtDeliveryId.Size = new System.Drawing.Size(168, 21);
            this.txtDeliveryId.TabIndex = 11;
            // 
            // chkIfVerifyed
            // 
            this.chkIfVerifyed.AutoSize = true;
            this.chkIfVerifyed.Checked = true;
            this.chkIfVerifyed.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIfVerifyed.Location = new System.Drawing.Point(433, 452);
            this.chkIfVerifyed.Name = "chkIfVerifyed";
            this.chkIfVerifyed.Size = new System.Drawing.Size(84, 16);
            this.chkIfVerifyed.TabIndex = 6;
            this.chkIfVerifyed.Text = "是否已验证";
            this.chkIfVerifyed.UseVisualStyleBackColor = true;
            // 
            // cbxVerfiel
            // 
            this.cbxVerfiel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxVerfiel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxVerfiel.FormattingEnabled = true;
            this.cbxVerfiel.Location = new System.Drawing.Point(569, 450);
            this.cbxVerfiel.Name = "cbxVerfiel";
            this.cbxVerfiel.Size = new System.Drawing.Size(121, 20);
            this.cbxVerfiel.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(523, 454);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 12);
            this.label11.TabIndex = 0;
            this.label11.Text = "验证人";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(684, 52);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(17, 12);
            this.label16.TabIndex = 8;
            this.label16.Text = "元";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(432, 52);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 12);
            this.label10.TabIndex = 8;
            this.label10.Text = "升";
            // 
            // btnUploadImage
            // 
            this.btnUploadImage.Location = new System.Drawing.Point(84, 452);
            this.btnUploadImage.Name = "btnUploadImage";
            this.btnUploadImage.Size = new System.Drawing.Size(75, 24);
            this.btnUploadImage.TabIndex = 7;
            this.btnUploadImage.Text = "图片上传";
            this.btnUploadImage.UseVisualStyleBackColor = true;
            this.btnUploadImage.Visible = false;
            this.btnUploadImage.Click += new System.EventHandler(this.btnUploadImage_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(522, 23);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 12);
            this.label15.TabIndex = 0;
            this.label15.Text = "驾驶人";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(287, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "车辆";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "配送编号";
            // 
            // dtRefuelTime
            // 
            this.dtRefuelTime.CustomFormat = "yyyy-MM-dd HH:mm:00";
            this.dtRefuelTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtRefuelTime.Location = new System.Drawing.Point(83, 52);
            this.dtRefuelTime.Name = "dtRefuelTime";
            this.dtRefuelTime.Size = new System.Drawing.Size(169, 21);
            this.dtRefuelTime.TabIndex = 5;
            // 
            // txtPetrolPostiton
            // 
            this.txtPetrolPostiton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPetrolPostiton.Location = new System.Drawing.Point(84, 82);
            this.txtPetrolPostiton.Name = "txtPetrolPostiton";
            this.txtPetrolPostiton.Size = new System.Drawing.Size(606, 21);
            this.txtPetrolPostiton.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(533, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "金额";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 3;
            this.label8.Text = "加油日期";
            // 
            // cbxDriverId
            // 
            this.cbxDriverId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxDriverId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxDriverId.FormattingEnabled = true;
            this.cbxDriverId.Location = new System.Drawing.Point(569, 20);
            this.cbxDriverId.Name = "cbxDriverId";
            this.cbxDriverId.Size = new System.Drawing.Size(148, 20);
            this.cbxDriverId.TabIndex = 1;
            // 
            // cbxVehicleId
            // 
            this.cbxVehicleId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxVehicleId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxVehicleId.FormattingEnabled = true;
            this.cbxVehicleId.Location = new System.Drawing.Point(322, 21);
            this.cbxVehicleId.Name = "cbxVehicleId";
            this.cbxVehicleId.Size = new System.Drawing.Size(148, 20);
            this.cbxVehicleId.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "加油站";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 115);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 0;
            this.label9.Text = "发票照片";
            // 
            // txtQuantity
            // 
            this.txtQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQuantity.Location = new System.Drawing.Point(324, 48);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(103, 21);
            this.txtQuantity.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(281, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "加油量";
            // 
            // txtMoney
            // 
            this.txtMoney.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMoney.Location = new System.Drawing.Point(569, 48);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.Size = new System.Drawing.Size(115, 21);
            this.txtMoney.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(638, 524);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FrmRefuelingInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 569);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRefuelingInfo";
            this.Text = " 车辆加油费用管理";
            this.Load += new System.EventHandler(this.FrmRefuelingInfo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRefueling)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDeliveryId;
        private System.Windows.Forms.CheckBox chkIfVerifyed;
        private System.Windows.Forms.ComboBox cbxVerfiel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnUploadImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtRefuelTime;
        private System.Windows.Forms.TextBox txtPetrolPostiton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbxVehicleId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMoney;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cbxDriverId;
        private System.Windows.Forms.PictureBox picRefueling;
    }
}