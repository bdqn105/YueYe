namespace LogisPrj
{
    partial class FrmExceptionInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmExceptionInfo));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDeliveryId = new System.Windows.Forms.TextBox();
            this.btnAddException = new System.Windows.Forms.Button();
            this.cbxSender = new System.Windows.Forms.ComboBox();
            this.dateDisposeTime = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dateSendTime = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtExceptionDispose = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtExceptiondescribe = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxConductor = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxExceptionType = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtDeliveryId);
            this.groupBox1.Controls.Add(this.btnAddException);
            this.groupBox1.Controls.Add(this.cbxSender);
            this.groupBox1.Controls.Add(this.dateDisposeTime);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateSendTime);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtExceptionDispose);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtExceptiondescribe);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbxConductor);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbxExceptionType);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(578, 176);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "配送编号";
            // 
            // txtDeliveryId
            // 
            this.txtDeliveryId.Location = new System.Drawing.Point(93, 17);
            this.txtDeliveryId.Name = "txtDeliveryId";
            this.txtDeliveryId.Size = new System.Drawing.Size(158, 21);
            this.txtDeliveryId.TabIndex = 0;
            // 
            // btnAddException
            // 
            this.btnAddException.BackColor = System.Drawing.Color.Red;
            this.btnAddException.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddException.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAddException.Location = new System.Drawing.Point(518, 15);
            this.btnAddException.Name = "btnAddException";
            this.btnAddException.Size = new System.Drawing.Size(44, 23);
            this.btnAddException.TabIndex = 6;
            this.btnAddException.Text = "增加";
            this.btnAddException.UseVisualStyleBackColor = false;
            this.btnAddException.Click += new System.EventHandler(this.btnAddException_Click);
            // 
            // cbxSender
            // 
            this.cbxSender.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxSender.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxSender.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbxSender.FormattingEnabled = true;
            this.cbxSender.Location = new System.Drawing.Point(94, 118);
            this.cbxSender.Name = "cbxSender";
            this.cbxSender.Size = new System.Drawing.Size(195, 20);
            this.cbxSender.TabIndex = 4;
            // 
            // dateDisposeTime
            // 
            this.dateDisposeTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateDisposeTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateDisposeTime.Location = new System.Drawing.Point(404, 141);
            this.dateDisposeTime.Name = "dateDisposeTime";
            this.dateDisposeTime.Size = new System.Drawing.Size(158, 21);
            this.dateDisposeTime.TabIndex = 7;
            this.dateDisposeTime.Enter += new System.EventHandler(this.dateDisposeTime_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(339, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "异常类型";
            // 
            // dateSendTime
            // 
            this.dateSendTime.CalendarFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateSendTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateSendTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateSendTime.Location = new System.Drawing.Point(404, 118);
            this.dateSendTime.Name = "dateSendTime";
            this.dateSendTime.Size = new System.Drawing.Size(158, 21);
            this.dateSendTime.TabIndex = 5;
            this.dateSendTime.Value = new System.DateTime(2018, 4, 16, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "异常处理";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(345, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "发送时间";
            // 
            // txtExceptionDispose
            // 
            this.txtExceptionDispose.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtExceptionDispose.Location = new System.Drawing.Point(94, 94);
            this.txtExceptionDispose.Name = "txtExceptionDispose";
            this.txtExceptionDispose.Size = new System.Drawing.Size(468, 21);
            this.txtExceptionDispose.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(345, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "处理时间";
            // 
            // txtExceptiondescribe
            // 
            this.txtExceptiondescribe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtExceptiondescribe.Location = new System.Drawing.Point(94, 45);
            this.txtExceptiondescribe.Multiline = true;
            this.txtExceptiondescribe.Name = "txtExceptiondescribe";
            this.txtExceptiondescribe.Size = new System.Drawing.Size(468, 46);
            this.txtExceptiondescribe.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "异常信息描述";
            // 
            // cbxConductor
            // 
            this.cbxConductor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxConductor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxConductor.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbxConductor.FormattingEnabled = true;
            this.cbxConductor.Location = new System.Drawing.Point(94, 141);
            this.cbxConductor.Name = "cbxConductor";
            this.cbxConductor.Size = new System.Drawing.Size(195, 20);
            this.cbxConductor.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "发送人";
            // 
            // cbxExceptionType
            // 
            this.cbxExceptionType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxExceptionType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxExceptionType.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbxExceptionType.FormattingEnabled = true;
            this.cbxExceptionType.Location = new System.Drawing.Point(398, 17);
            this.cbxExceptionType.Name = "cbxExceptionType";
            this.cbxExceptionType.Size = new System.Drawing.Size(115, 20);
            this.cbxExceptionType.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(47, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "处理人";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(493, 194);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FrmExceptionInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 221);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmExceptionInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "异常信息详细表";
            this.Load += new System.EventHandler(this.FrmExceptionInfo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDeliveryId;
        private System.Windows.Forms.Button btnAddException;
        private System.Windows.Forms.ComboBox cbxSender;
        private System.Windows.Forms.DateTimePicker dateDisposeTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateSendTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtExceptionDispose;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtExceptiondescribe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxConductor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxExceptionType;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSave;
    }
}