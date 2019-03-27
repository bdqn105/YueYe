namespace LogisPrj
{
    partial class FrmClientOrderInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClientOrderInfo));
            this.label1 = new System.Windows.Forms.Label();
            this.txtClientOrderId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtListnumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAirWaybillID = new System.Windows.Forms.TextBox();
            this.cbxSourTransType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSourceTransId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dTAirArriverTime = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtClientPhone = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtClientAddress = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtReceiver = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtReceiverPhone = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtReceiverAddress = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.chkIsDelivery = new System.Windows.Forms.CheckBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbxClientId = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "客户订单编号";
            // 
            // txtClientOrderId
            // 
            this.txtClientOrderId.Location = new System.Drawing.Point(97, 26);
            this.txtClientOrderId.Name = "txtClientOrderId";
            this.txtClientOrderId.Size = new System.Drawing.Size(121, 21);
            this.txtClientOrderId.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(292, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "清单号";
            // 
            // txtListnumber
            // 
            this.txtListnumber.Location = new System.Drawing.Point(339, 26);
            this.txtListnumber.Name = "txtListnumber";
            this.txtListnumber.Size = new System.Drawing.Size(121, 21);
            this.txtListnumber.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(549, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "运单号";
            // 
            // txtAirWaybillID
            // 
            this.txtAirWaybillID.Location = new System.Drawing.Point(596, 26);
            this.txtAirWaybillID.Name = "txtAirWaybillID";
            this.txtAirWaybillID.Size = new System.Drawing.Size(121, 21);
            this.txtAirWaybillID.TabIndex = 1;
            // 
            // cbxSourTransType
            // 
            this.cbxSourTransType.FormattingEnabled = true;
            this.cbxSourTransType.Location = new System.Drawing.Point(97, 53);
            this.cbxSourTransType.Name = "cbxSourTransType";
            this.cbxSourTransType.Size = new System.Drawing.Size(121, 20);
            this.cbxSourTransType.TabIndex = 2;
            this.cbxSourTransType.SelectedIndexChanged += new System.EventHandler(this.cbxSourTransType_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "运输方式";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(292, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "班次号";
            // 
            // txtSourceTransId
            // 
            this.txtSourceTransId.Location = new System.Drawing.Point(339, 53);
            this.txtSourceTransId.Name = "txtSourceTransId";
            this.txtSourceTransId.Size = new System.Drawing.Size(121, 21);
            this.txtSourceTransId.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(513, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "航班到达时间";
            // 
            // dTAirArriverTime
            // 
            this.dTAirArriverTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dTAirArriverTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTAirArriverTime.Location = new System.Drawing.Point(596, 53);
            this.dTAirArriverTime.Name = "dTAirArriverTime";
            this.dTAirArriverTime.Size = new System.Drawing.Size(166, 21);
            this.dTAirArriverTime.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(62, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "客户";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(280, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "联系方式";
            // 
            // txtClientPhone
            // 
            this.txtClientPhone.Location = new System.Drawing.Point(339, 80);
            this.txtClientPhone.Name = "txtClientPhone";
            this.txtClientPhone.Size = new System.Drawing.Size(121, 21);
            this.txtClientPhone.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(537, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 0;
            this.label9.Text = "发货地址";
            // 
            // txtClientAddress
            // 
            this.txtClientAddress.Location = new System.Drawing.Point(596, 80);
            this.txtClientAddress.Name = "txtClientAddress";
            this.txtClientAddress.Size = new System.Drawing.Size(287, 21);
            this.txtClientAddress.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(50, 111);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 0;
            this.label10.Text = "收货人";
            // 
            // txtReceiver
            // 
            this.txtReceiver.Location = new System.Drawing.Point(97, 107);
            this.txtReceiver.Name = "txtReceiver";
            this.txtReceiver.Size = new System.Drawing.Size(121, 21);
            this.txtReceiver.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(280, 111);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
            this.label11.TabIndex = 0;
            this.label11.Text = "联系方式";
            // 
            // txtReceiverPhone
            // 
            this.txtReceiverPhone.Location = new System.Drawing.Point(339, 107);
            this.txtReceiverPhone.Name = "txtReceiverPhone";
            this.txtReceiverPhone.Size = new System.Drawing.Size(121, 21);
            this.txtReceiverPhone.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(537, 111);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 12);
            this.label12.TabIndex = 0;
            this.label12.Text = "收货地址";
            // 
            // txtReceiverAddress
            // 
            this.txtReceiverAddress.Location = new System.Drawing.Point(596, 107);
            this.txtReceiverAddress.Name = "txtReceiverAddress";
            this.txtReceiverAddress.Size = new System.Drawing.Size(299, 21);
            this.txtReceiverAddress.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(62, 19);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 12);
            this.label13.TabIndex = 0;
            this.label13.Text = "品名";
            // 
            // txtProductId
            // 
            this.txtProductId.Location = new System.Drawing.Point(97, 15);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.Size = new System.Drawing.Size(121, 21);
            this.txtProductId.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(292, 19);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 12);
            this.label14.TabIndex = 0;
            this.label14.Text = "数量";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(339, 15);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(121, 21);
            this.txtQuantity.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(549, 19);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(29, 12);
            this.label15.TabIndex = 0;
            this.label15.Text = "重量";
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(596, 15);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(121, 21);
            this.txtWeight.TabIndex = 1;
            // 
            // chkIsDelivery
            // 
            this.chkIsDelivery.AutoSize = true;
            this.chkIsDelivery.Location = new System.Drawing.Point(802, 17);
            this.chkIsDelivery.Name = "chkIsDelivery";
            this.chkIsDelivery.Size = new System.Drawing.Size(72, 16);
            this.chkIsDelivery.TabIndex = 4;
            this.chkIsDelivery.Text = "送货上楼";
            this.chkIsDelivery.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(74, 193);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(29, 12);
            this.label16.TabIndex = 0;
            this.label16.Text = "备注";
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(109, 193);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(882, 61);
            this.txtRemark.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkIsDelivery);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtProductId);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txtQuantity);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.txtWeight);
            this.groupBox1.Location = new System.Drawing.Point(12, 145);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(979, 42);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtReceiverAddress);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dTAirArriverTime);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cbxClientId);
            this.groupBox2.Controls.Add(this.cbxSourTransType);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtClientOrderId);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtClientAddress);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtListnumber);
            this.groupBox2.Controls.Add(this.txtReceiver);
            this.groupBox2.Controls.Add(this.txtAirWaybillID);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtReceiverPhone);
            this.groupBox2.Controls.Add(this.txtClientPhone);
            this.groupBox2.Controls.Add(this.txtSourceTransId);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(979, 132);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // cbxClientId
            // 
            this.cbxClientId.FormattingEnabled = true;
            this.cbxClientId.Location = new System.Drawing.Point(97, 81);
            this.cbxClientId.Name = "cbxClientId";
            this.cbxClientId.Size = new System.Drawing.Size(121, 20);
            this.cbxClientId.TabIndex = 2;
            this.cbxClientId.SelectedIndexChanged += new System.EventHandler(this.cbxSourTransType_SelectedIndexChanged);
            // 
            // FrmClientOrderInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 292);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.label16);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmClientOrderInfo";
            this.Text = "客户订单详细信息";
            this.Load += new System.EventHandler(this.FrmClientOrderInfo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtClientOrderId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtListnumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAirWaybillID;
        private System.Windows.Forms.ComboBox cbxSourTransType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSourceTransId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dTAirArriverTime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtClientPhone;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtClientAddress;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtReceiver;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtReceiverPhone;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtReceiverAddress;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtProductId;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.CheckBox chkIsDelivery;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbxClientId;
    }
}