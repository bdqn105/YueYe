namespace LogisPrj
{
    partial class FrmCompany
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCompany));
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.dgvCompany = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCompanyID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCompanyUnifiedCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colToPublicAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colToPrivateAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCompanyLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCompanyAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBusinessNature = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLegalRepresentative = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTelephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFaxNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClose = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnGoPage = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.lbltotalCount = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPage = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lbltotalPage = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblPre = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnLastPage = new System.Windows.Forms.Button();
            this.btnNextPage = new System.Windows.Forms.Button();
            this.btnFirstPage = new System.Windows.Forms.Button();
            this.btnPrePage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompany)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(3, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "增加";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnModify
            // 
            this.btnModify.BackColor = System.Drawing.Color.Peru;
            this.btnModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModify.Location = new System.Drawing.Point(81, 3);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 23);
            this.btnModify.TabIndex = 1;
            this.btnModify.Text = "修改";
            this.btnModify.UseVisualStyleBackColor = false;
            this.btnModify.Visible = false;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.Red;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.Location = new System.Drawing.Point(160, 3);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 2;
            this.btnDel.Text = "删除";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Visible = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // dgvCompany
            // 
            this.dgvCompany.AllowDrop = true;
            this.dgvCompany.AllowUserToAddRows = false;
            this.dgvCompany.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.AliceBlue;
            this.dgvCompany.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCompany.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCompany.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCompany.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCompany.BackgroundColor = System.Drawing.Color.White;
            this.dgvCompany.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCompany.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCompany.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompany.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colCompanyID,
            this.colCompanyName,
            this.colCompanyUnifiedCode,
            this.colToPublicAccount,
            this.colToPrivateAccount,
            this.colCompanyLocation,
            this.colCompanyAddress,
            this.colBusinessNature,
            this.colLegalRepresentative,
            this.colTelephone,
            this.colMobile,
            this.colFaxNo});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCompany.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCompany.Location = new System.Drawing.Point(0, 0);
            this.dgvCompany.Name = "dgvCompany";
            this.dgvCompany.ReadOnly = true;
            this.dgvCompany.RowHeadersVisible = false;
            this.dgvCompany.RowTemplate.Height = 23;
            this.dgvCompany.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCompany.Size = new System.Drawing.Size(1122, 479);
            this.dgvCompany.TabIndex = 0;
            this.dgvCompany.TabStop = false;
            this.dgvCompany.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCompany_CellClick);
            this.dgvCompany.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCompany_CellDoubleClick);
            // 
            // colId
            // 
            this.colId.DataPropertyName = "Id";
            this.colId.HeaderText = "ID";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Visible = false;
            // 
            // colCompanyID
            // 
            this.colCompanyID.DataPropertyName = "CompanyID";
            this.colCompanyID.FillWeight = 30F;
            this.colCompanyID.HeaderText = "公司编号";
            this.colCompanyID.Name = "colCompanyID";
            this.colCompanyID.ReadOnly = true;
            this.colCompanyID.Visible = false;
            // 
            // colCompanyName
            // 
            this.colCompanyName.DataPropertyName = "CompanyName";
            this.colCompanyName.FillWeight = 40F;
            this.colCompanyName.HeaderText = "公司名称";
            this.colCompanyName.Name = "colCompanyName";
            this.colCompanyName.ReadOnly = true;
            // 
            // colCompanyUnifiedCode
            // 
            this.colCompanyUnifiedCode.DataPropertyName = "CompanyUnifiedCode";
            this.colCompanyUnifiedCode.FillWeight = 50F;
            this.colCompanyUnifiedCode.HeaderText = "社会信用代码";
            this.colCompanyUnifiedCode.Name = "colCompanyUnifiedCode";
            this.colCompanyUnifiedCode.ReadOnly = true;
            this.colCompanyUnifiedCode.Visible = false;
            // 
            // colToPublicAccount
            // 
            this.colToPublicAccount.DataPropertyName = "ToPublicAccount";
            this.colToPublicAccount.FillWeight = 50F;
            this.colToPublicAccount.HeaderText = "对公账号";
            this.colToPublicAccount.Name = "colToPublicAccount";
            this.colToPublicAccount.ReadOnly = true;
            this.colToPublicAccount.Visible = false;
            // 
            // colToPrivateAccount
            // 
            this.colToPrivateAccount.DataPropertyName = "ToPrivateAccount";
            this.colToPrivateAccount.FillWeight = 50F;
            this.colToPrivateAccount.HeaderText = "对私账号";
            this.colToPrivateAccount.Name = "colToPrivateAccount";
            this.colToPrivateAccount.ReadOnly = true;
            this.colToPrivateAccount.Visible = false;
            // 
            // colCompanyLocation
            // 
            this.colCompanyLocation.DataPropertyName = "CompanyLocation";
            this.colCompanyLocation.FillWeight = 40F;
            this.colCompanyLocation.HeaderText = "所在地";
            this.colCompanyLocation.Name = "colCompanyLocation";
            this.colCompanyLocation.ReadOnly = true;
            // 
            // colCompanyAddress
            // 
            this.colCompanyAddress.DataPropertyName = "CompanyAddress";
            this.colCompanyAddress.FillWeight = 80F;
            this.colCompanyAddress.HeaderText = "详细地址";
            this.colCompanyAddress.Name = "colCompanyAddress";
            this.colCompanyAddress.ReadOnly = true;
            // 
            // colBusinessNature
            // 
            this.colBusinessNature.DataPropertyName = "BusinessNature";
            this.colBusinessNature.FillWeight = 40F;
            this.colBusinessNature.HeaderText = "性质";
            this.colBusinessNature.Name = "colBusinessNature";
            this.colBusinessNature.ReadOnly = true;
            this.colBusinessNature.Visible = false;
            // 
            // colLegalRepresentative
            // 
            this.colLegalRepresentative.DataPropertyName = "LegalRepresentative";
            this.colLegalRepresentative.FillWeight = 40F;
            this.colLegalRepresentative.HeaderText = "法人代表";
            this.colLegalRepresentative.Name = "colLegalRepresentative";
            this.colLegalRepresentative.ReadOnly = true;
            this.colLegalRepresentative.Visible = false;
            // 
            // colTelephone
            // 
            this.colTelephone.DataPropertyName = "Telephone";
            this.colTelephone.FillWeight = 40F;
            this.colTelephone.HeaderText = "座机号码";
            this.colTelephone.Name = "colTelephone";
            this.colTelephone.ReadOnly = true;
            // 
            // colMobile
            // 
            this.colMobile.DataPropertyName = "Mobile";
            this.colMobile.FillWeight = 40F;
            this.colMobile.HeaderText = "手机号码";
            this.colMobile.Name = "colMobile";
            this.colMobile.ReadOnly = true;
            // 
            // colFaxNo
            // 
            this.colFaxNo.DataPropertyName = "FaxNo";
            this.colFaxNo.FillWeight = 50F;
            this.colFaxNo.HeaderText = "传真号码";
            this.colFaxNo.Name = "colFaxNo";
            this.colFaxNo.ReadOnly = true;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(1044, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
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
            this.splitContainer1.Panel1.Controls.Add(this.btnAdd);
            this.splitContainer1.Panel1.Controls.Add(this.btnClose);
            this.splitContainer1.Panel1.Controls.Add(this.btnDel);
            this.splitContainer1.Panel1.Controls.Add(this.btnModify);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnGoPage);
            this.splitContainer1.Panel2.Controls.Add(this.label17);
            this.splitContainer1.Panel2.Controls.Add(this.lbltotalCount);
            this.splitContainer1.Panel2.Controls.Add(this.label14);
            this.splitContainer1.Panel2.Controls.Add(this.label15);
            this.splitContainer1.Panel2.Controls.Add(this.label19);
            this.splitContainer1.Panel2.Controls.Add(this.label18);
            this.splitContainer1.Panel2.Controls.Add(this.label9);
            this.splitContainer1.Panel2.Controls.Add(this.txtPage);
            this.splitContainer1.Panel2.Controls.Add(this.label11);
            this.splitContainer1.Panel2.Controls.Add(this.lbltotalPage);
            this.splitContainer1.Panel2.Controls.Add(this.label13);
            this.splitContainer1.Panel2.Controls.Add(this.lblPre);
            this.splitContainer1.Panel2.Controls.Add(this.label12);
            this.splitContainer1.Panel2.Controls.Add(this.label10);
            this.splitContainer1.Panel2.Controls.Add(this.label8);
            this.splitContainer1.Panel2.Controls.Add(this.btnLastPage);
            this.splitContainer1.Panel2.Controls.Add(this.btnNextPage);
            this.splitContainer1.Panel2.Controls.Add(this.btnFirstPage);
            this.splitContainer1.Panel2.Controls.Add(this.btnPrePage);
            this.splitContainer1.Panel2.Controls.Add(this.dgvCompany);
            this.splitContainer1.Size = new System.Drawing.Size(1122, 548);
            this.splitContainer1.SplitterDistance = 29;
            this.splitContainer1.TabIndex = 3;
            this.splitContainer1.TabStop = false;
            // 
            // btnGoPage
            // 
            this.btnGoPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGoPage.FlatAppearance.BorderSize = 0;
            this.btnGoPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoPage.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnGoPage.Location = new System.Drawing.Point(392, 484);
            this.btnGoPage.Name = "btnGoPage";
            this.btnGoPage.Size = new System.Drawing.Size(32, 23);
            this.btnGoPage.TabIndex = 62;
            this.btnGoPage.Text = "GO";
            this.btnGoPage.UseVisualStyleBackColor = true;
            this.btnGoPage.Click += new System.EventHandler(this.btnGoPage_Click);
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(495, 490);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(41, 12);
            this.label17.TabIndex = 61;
            this.label17.Text = "条记录";
            // 
            // lbltotalCount
            // 
            this.lbltotalCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbltotalCount.AutoSize = true;
            this.lbltotalCount.Location = new System.Drawing.Point(465, 490);
            this.lbltotalCount.Name = "lbltotalCount";
            this.lbltotalCount.Size = new System.Drawing.Size(11, 12);
            this.lbltotalCount.TabIndex = 60;
            this.lbltotalCount.Text = "N";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(372, 490);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(17, 12);
            this.label14.TabIndex = 59;
            this.label14.Text = "页";
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(451, 490);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(17, 12);
            this.label15.TabIndex = 58;
            this.label15.Text = "共";
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label19.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label19.Location = new System.Drawing.Point(278, 488);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(16, 16);
            this.label19.TabIndex = 57;
            this.label19.Text = "|";
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label18.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label18.Location = new System.Drawing.Point(429, 488);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(16, 16);
            this.label18.TabIndex = 56;
            this.label18.Text = "|";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(306, 490);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 12);
            this.label9.TabIndex = 55;
            this.label9.Text = "第";
            // 
            // txtPage
            // 
            this.txtPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPage.Location = new System.Drawing.Point(326, 485);
            this.txtPage.Name = "txtPage";
            this.txtPage.Size = new System.Drawing.Size(41, 21);
            this.txtPage.TabIndex = 54;
            this.txtPage.Text = "1";
            this.txtPage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(134, 490);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(11, 12);
            this.label11.TabIndex = 53;
            this.label11.Text = "/";
            // 
            // lbltotalPage
            // 
            this.lbltotalPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbltotalPage.AutoSize = true;
            this.lbltotalPage.Location = new System.Drawing.Point(156, 490);
            this.lbltotalPage.Name = "lbltotalPage";
            this.lbltotalPage.Size = new System.Drawing.Size(11, 12);
            this.lbltotalPage.TabIndex = 52;
            this.lbltotalPage.Text = "1";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(177, 490);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(17, 12);
            this.label13.TabIndex = 50;
            this.label13.Text = "页";
            // 
            // lblPre
            // 
            this.lblPre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPre.AutoSize = true;
            this.lblPre.Location = new System.Drawing.Point(95, 490);
            this.lblPre.Name = "lblPre";
            this.lblPre.Size = new System.Drawing.Size(11, 12);
            this.lblPre.TabIndex = 51;
            this.lblPre.Text = "1";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(142, 490);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(17, 12);
            this.label12.TabIndex = 49;
            this.label12.Text = "共";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(117, 490);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 12);
            this.label10.TabIndex = 48;
            this.label10.Text = "页";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(81, 490);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 12);
            this.label8.TabIndex = 47;
            this.label8.Text = "第";
            // 
            // btnLastPage
            // 
            this.btnLastPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLastPage.BackColor = System.Drawing.Color.Transparent;
            this.btnLastPage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLastPage.BackgroundImage")));
            this.btnLastPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLastPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLastPage.Location = new System.Drawing.Point(227, 485);
            this.btnLastPage.Name = "btnLastPage";
            this.btnLastPage.Size = new System.Drawing.Size(29, 23);
            this.btnLastPage.TabIndex = 45;
            this.btnLastPage.UseVisualStyleBackColor = false;
            this.btnLastPage.Click += new System.EventHandler(this.btnLastPage_Click);
            // 
            // btnNextPage
            // 
            this.btnNextPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNextPage.BackColor = System.Drawing.Color.Transparent;
            this.btnNextPage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNextPage.BackgroundImage")));
            this.btnNextPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNextPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextPage.Location = new System.Drawing.Point(194, 485);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(29, 23);
            this.btnNextPage.TabIndex = 44;
            this.btnNextPage.UseVisualStyleBackColor = false;
            this.btnNextPage.Click += new System.EventHandler(this.btnNextPage_Click);
            // 
            // btnFirstPage
            // 
            this.btnFirstPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnFirstPage.BackColor = System.Drawing.Color.Transparent;
            this.btnFirstPage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFirstPage.BackgroundImage")));
            this.btnFirstPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFirstPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirstPage.Location = new System.Drawing.Point(11, 485);
            this.btnFirstPage.Name = "btnFirstPage";
            this.btnFirstPage.Size = new System.Drawing.Size(29, 23);
            this.btnFirstPage.TabIndex = 46;
            this.btnFirstPage.UseVisualStyleBackColor = false;
            this.btnFirstPage.Click += new System.EventHandler(this.btnFirstPage_Click);
            // 
            // btnPrePage
            // 
            this.btnPrePage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPrePage.BackColor = System.Drawing.Color.Transparent;
            this.btnPrePage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPrePage.BackgroundImage")));
            this.btnPrePage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPrePage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrePage.Location = new System.Drawing.Point(46, 485);
            this.btnPrePage.Name = "btnPrePage";
            this.btnPrePage.Size = new System.Drawing.Size(29, 23);
            this.btnPrePage.TabIndex = 43;
            this.btnPrePage.UseVisualStyleBackColor = false;
            this.btnPrePage.Click += new System.EventHandler(this.btnPrePage_Click);
            // 
            // FrmCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 548);
            this.Controls.Add(this.splitContainer1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCompany";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "公司信息";
            this.Load += new System.EventHandler(this.FrmCompany_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompany)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.DataGridView dgvCompany;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCompanyID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCompanyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCompanyUnifiedCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colToPublicAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colToPrivateAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCompanyLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCompanyAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBusinessNature;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLegalRepresentative;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTelephone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFaxNo;
        private System.Windows.Forms.Button btnGoPage;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lbltotalCount;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPage;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbltotalPage;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblPre;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnLastPage;
        private System.Windows.Forms.Button btnNextPage;
        private System.Windows.Forms.Button btnFirstPage;
        private System.Windows.Forms.Button btnPrePage;
    }
}