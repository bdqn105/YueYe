namespace LogisPrj
{
    partial class FrmTransferPath
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTransferPath));
            this.btnClose = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.lbl = new System.Windows.Forms.Label();
            this.txtOrigin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDestional = new System.Windows.Forms.TextBox();
            this.btnOrigin = new System.Windows.Forms.Button();
            this.btnDestination = new System.Windows.Forms.Button();
            this.btnSetPath = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDeliveryId = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colDeliveryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOrderNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLocationSign = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLocationName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLng = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLimitSpeed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnOk = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDestinationLng = new System.Windows.Forms.Label();
            this.lblDestionationLat = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblOriginLat = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblOriginLng = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtViaLocation = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblViaLng = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblViaLat = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(1309, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(2, 277);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1372, 358);
            this.webBrowser1.TabIndex = 1;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(9, 17);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(29, 12);
            this.lbl.TabIndex = 2;
            this.lbl.Text = "起点";
            // 
            // txtOrigin
            // 
            this.txtOrigin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOrigin.Location = new System.Drawing.Point(44, 14);
            this.txtOrigin.Name = "txtOrigin";
            this.txtOrigin.Size = new System.Drawing.Size(382, 21);
            this.txtOrigin.TabIndex = 3;
            this.txtOrigin.Leave += new System.EventHandler(this.txtOrigin_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "终点";
            // 
            // txtDestional
            // 
            this.txtDestional.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDestional.Location = new System.Drawing.Point(44, 37);
            this.txtDestional.Name = "txtDestional";
            this.txtDestional.Size = new System.Drawing.Size(382, 21);
            this.txtDestional.TabIndex = 3;
            this.txtDestional.Leave += new System.EventHandler(this.txtDestional_Leave);
            // 
            // btnOrigin
            // 
            this.btnOrigin.BackColor = System.Drawing.SystemColors.Window;
            this.btnOrigin.FlatAppearance.BorderSize = 0;
            this.btnOrigin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrigin.Font = new System.Drawing.Font("宋体", 8F);
            this.btnOrigin.ForeColor = System.Drawing.Color.Blue;
            this.btnOrigin.Location = new System.Drawing.Point(361, 15);
            this.btnOrigin.Name = "btnOrigin";
            this.btnOrigin.Size = new System.Drawing.Size(64, 19);
            this.btnOrigin.TabIndex = 65;
            this.btnOrigin.Text = "点击地图";
            this.btnOrigin.UseVisualStyleBackColor = false;
            this.btnOrigin.Click += new System.EventHandler(this.btnOrigin_Click);
            // 
            // btnDestination
            // 
            this.btnDestination.BackColor = System.Drawing.SystemColors.Window;
            this.btnDestination.FlatAppearance.BorderSize = 0;
            this.btnDestination.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDestination.Font = new System.Drawing.Font("宋体", 8F);
            this.btnDestination.ForeColor = System.Drawing.Color.Blue;
            this.btnDestination.Location = new System.Drawing.Point(361, 38);
            this.btnDestination.Name = "btnDestination";
            this.btnDestination.Size = new System.Drawing.Size(64, 19);
            this.btnDestination.TabIndex = 65;
            this.btnDestination.Text = "点击地图";
            this.btnDestination.UseVisualStyleBackColor = false;
            this.btnDestination.Click += new System.EventHandler(this.btnDestination_Click);
            // 
            // btnSetPath
            // 
            this.btnSetPath.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSetPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetPath.Location = new System.Drawing.Point(706, 34);
            this.btnSetPath.Name = "btnSetPath";
            this.btnSetPath.Size = new System.Drawing.Size(75, 23);
            this.btnSetPath.TabIndex = 0;
            this.btnSetPath.Text = "设置路径";
            this.btnSetPath.UseVisualStyleBackColor = false;
            this.btnSetPath.Click += new System.EventHandler(this.btnSetPath_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(432, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "经度";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(563, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "纬度";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(432, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "经度";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(563, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 2;
            this.label6.Text = "纬度";
            // 
            // txtDeliveryId
            // 
            this.txtDeliveryId.Location = new System.Drawing.Point(69, 9);
            this.txtDeliveryId.Name = "txtDeliveryId";
            this.txtDeliveryId.Size = new System.Drawing.Size(199, 21);
            this.txtDeliveryId.TabIndex = 69;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Khaki;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(277, 8);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 68;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 67;
            this.label7.Text = "配送编号";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(729, 143);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 70;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDeliveryID,
            this.colID,
            this.colOrderNumber,
            this.colLocationSign,
            this.colLocationName,
            this.colLng,
            this.colLat,
            this.colLimitSpeed});
            this.dataGridView1.Location = new System.Drawing.Point(22, 172);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(980, 99);
            this.dataGridView1.TabIndex = 71;
            // 
            // colDeliveryID
            // 
            this.colDeliveryID.DataPropertyName = "DeliverID";
            this.colDeliveryID.HeaderText = "配送编号";
            this.colDeliveryID.Name = "colDeliveryID";
            // 
            // colID
            // 
            this.colID.DataPropertyName = "ID";
            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = false;
            // 
            // colOrderNumber
            // 
            this.colOrderNumber.DataPropertyName = "OrderNumber";
            this.colOrderNumber.HeaderText = "订单编号";
            this.colOrderNumber.Name = "colOrderNumber";
            // 
            // colLocationSign
            // 
            this.colLocationSign.DataPropertyName = "LocationSign";
            this.colLocationSign.HeaderText = "位置标识";
            this.colLocationSign.Name = "colLocationSign";
            // 
            // colLocationName
            // 
            this.colLocationName.DataPropertyName = "LocationName";
            this.colLocationName.HeaderText = "地点名称";
            this.colLocationName.Name = "colLocationName";
            // 
            // colLng
            // 
            this.colLng.DataPropertyName = "longitude";
            this.colLng.HeaderText = "经度";
            this.colLng.Name = "colLng";
            // 
            // colLat
            // 
            this.colLat.DataPropertyName = "latitude";
            this.colLat.HeaderText = "纬度";
            this.colLat.Name = "colLat";
            // 
            // colLimitSpeed
            // 
            this.colLimitSpeed.DataPropertyName = "LimitSpeed";
            this.colLimitSpeed.HeaderText = "限制速度";
            this.colLimitSpeed.Name = "colLimitSpeed";
            this.colLimitSpeed.Visible = false;
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.ForestGreen;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Location = new System.Drawing.Point(729, 115);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 70;
            this.btnOk.Text = "设置途经点";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Visible = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblDestinationLng);
            this.groupBox1.Controls.Add(this.lblDestionationLat);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.lblOriginLat);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.lblOriginLng);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.btnOrigin);
            this.groupBox1.Controls.Add(this.txtOrigin);
            this.groupBox1.Controls.Add(this.lbl);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnDestination);
            this.groupBox1.Controls.Add(this.btnSetPath);
            this.groupBox1.Controls.Add(this.txtDestional);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Location = new System.Drawing.Point(23, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(798, 63);
            this.groupBox1.TabIndex = 72;
            this.groupBox1.TabStop = false;
            // 
            // lblDestinationLng
            // 
            this.lblDestinationLng.AutoSize = true;
            this.lblDestinationLng.Location = new System.Drawing.Point(467, 39);
            this.lblDestinationLng.Name = "lblDestinationLng";
            this.lblDestinationLng.Size = new System.Drawing.Size(47, 12);
            this.lblDestinationLng.TabIndex = 68;
            this.lblDestinationLng.Text = "label11";
            // 
            // lblDestionationLat
            // 
            this.lblDestionationLat.AutoSize = true;
            this.lblDestionationLat.Location = new System.Drawing.Point(598, 40);
            this.lblDestionationLat.Name = "lblDestionationLat";
            this.lblDestionationLat.Size = new System.Drawing.Size(47, 12);
            this.lblDestionationLat.TabIndex = 68;
            this.lblDestionationLat.Text = "label11";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(596, 42);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 12);
            this.label13.TabIndex = 67;
            this.label13.Text = "____________";
            // 
            // lblOriginLat
            // 
            this.lblOriginLat.AutoSize = true;
            this.lblOriginLat.Location = new System.Drawing.Point(598, 14);
            this.lblOriginLat.Name = "lblOriginLat";
            this.lblOriginLat.Size = new System.Drawing.Size(47, 12);
            this.lblOriginLat.TabIndex = 68;
            this.lblOriginLat.Text = "label11";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(596, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 12);
            this.label12.TabIndex = 67;
            this.label12.Text = "____________";
            // 
            // lblOriginLng
            // 
            this.lblOriginLng.AutoSize = true;
            this.lblOriginLng.Location = new System.Drawing.Point(468, 14);
            this.lblOriginLng.Name = "lblOriginLng";
            this.lblOriginLng.Size = new System.Drawing.Size(47, 12);
            this.lblOriginLng.TabIndex = 68;
            this.lblOriginLng.Text = "label11";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(466, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 12);
            this.label10.TabIndex = 67;
            this.label10.Text = "____________";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(465, 40);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 12);
            this.label11.TabIndex = 69;
            this.label11.Text = "____________";
            // 
            // txtViaLocation
            // 
            this.txtViaLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtViaLocation.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtViaLocation.ForeColor = System.Drawing.Color.Black;
            this.txtViaLocation.Location = new System.Drawing.Point(67, 115);
            this.txtViaLocation.Name = "txtViaLocation";
            this.txtViaLocation.Size = new System.Drawing.Size(382, 21);
            this.txtViaLocation.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "途经点";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(586, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 2;
            this.label8.Text = "纬度";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(455, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 2;
            this.label9.Text = "经度";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(486, 120);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 12);
            this.label14.TabIndex = 69;
            this.label14.Text = "____________";
            // 
            // lblViaLng
            // 
            this.lblViaLng.AutoSize = true;
            this.lblViaLng.Location = new System.Drawing.Point(488, 119);
            this.lblViaLng.Name = "lblViaLng";
            this.lblViaLng.Size = new System.Drawing.Size(47, 12);
            this.lblViaLng.TabIndex = 68;
            this.lblViaLng.Text = "label11";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(619, 121);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(77, 12);
            this.label15.TabIndex = 67;
            this.label15.Text = "____________";
            // 
            // lblViaLat
            // 
            this.lblViaLat.AutoSize = true;
            this.lblViaLat.Location = new System.Drawing.Point(621, 119);
            this.lblViaLat.Name = "lblViaLat";
            this.lblViaLat.Size = new System.Drawing.Size(47, 12);
            this.lblViaLat.TabIndex = 68;
            this.lblViaLat.Text = "label11";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(67, 143);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(245, 12);
            this.label16.TabIndex = 73;
            this.label16.Text = "如果有途经点，请依次点击拖动点，进行添加";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label17.ForeColor = System.Drawing.Color.Red;
            this.label17.Location = new System.Drawing.Point(69, 97);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(161, 12);
            this.label17.TabIndex = 73;
            this.label17.Text = "您可以拖动路线进行路径规划";
            // 
            // FrmTransferPath
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 637);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.lblViaLng);
            this.Controls.Add(this.lblViaLat);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtDeliveryId);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtViaLocation);
            this.Controls.Add(this.label14);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTransferPath";
            this.Text = "配送路径";
            this.Load += new System.EventHandler(this.FrmTransferPath_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TextBox txtOrigin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDestional;
        private System.Windows.Forms.Button btnOrigin;
        private System.Windows.Forms.Button btnDestination;
        private System.Windows.Forms.Button btnSetPath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDeliveryId;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtViaLocation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDeliveryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrderNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLocationSign;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLocationName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLng;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLimitSpeed;
        private System.Windows.Forms.Label lblDestinationLng;
        private System.Windows.Forms.Label lblDestionationLat;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblOriginLat;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblOriginLng;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblViaLng;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblViaLat;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
    }
}