namespace BentoSystemWinform
{
	partial class OrderForm
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.btnLogout = new System.Windows.Forms.Button();
			this.btnOrders = new System.Windows.Forms.Button();
			this.btnMembers = new System.Windows.Forms.Button();
			this.btnProducts = new System.Windows.Forms.Button();
			this.btnMainForm = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.gbOrderInfo = new System.Windows.Forms.GroupBox();
			this.labelOrderTime = new System.Windows.Forms.Label();
			this.cbMemberList = new System.Windows.Forms.ComboBox();
			this.labelOrderType = new System.Windows.Forms.Label();
			this.txtOrderPhone = new System.Windows.Forms.TextBox();
			this.labelOrderPhone = new System.Windows.Forms.Label();
			this.labelOrderDateTime = new System.Windows.Forms.Label();
			this.txtInsertOrderName = new System.Windows.Forms.TextBox();
			this.rbtnNonMember = new System.Windows.Forms.RadioButton();
			this.rbtnIsMember = new System.Windows.Forms.RadioButton();
			this.panel2 = new System.Windows.Forms.Panel();
			this.rbtnPickup = new System.Windows.Forms.RadioButton();
			this.rbtnDelivery = new System.Windows.Forms.RadioButton();
			this.gbOrderChoose = new System.Windows.Forms.GroupBox();
			this.label2 = new System.Windows.Forms.Label();
			this.dgvProductList = new System.Windows.Forms.DataGridView();
			this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ProductPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.StockQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ProductDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnOrderAdd = new System.Windows.Forms.Button();
			this.labelOrderNumber = new System.Windows.Forms.Label();
			this.nudQuantity = new System.Windows.Forms.NumericUpDown();
			this.product_LBSMSBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.bentoSystemDataSet = new BentoSystemWinform.BentoSystemDataSet();
			this.bentoSystemDataSet2 = new BentoSystemWinform.BentoSystemDataSet2();
			this.orderDataLBSMSBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.orderData_LBSMSTableAdapter = new BentoSystemWinform.BentoSystemDataSet2TableAdapters.OrderData_LBSMSTableAdapter();
			this.orderDataLBSMSBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.bentoSystemDataSet3 = new BentoSystemWinform.BentoSystemDataSet3();
			this.orderItem_LBSMSBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.orderItem_LBSMSTableAdapter = new BentoSystemWinform.BentoSystemDataSet3TableAdapters.OrderItem_LBSMSTableAdapter();
			this.tableAdapterManager = new BentoSystemWinform.BentoSystemDataSet3TableAdapters.TableAdapterManager();
			this.gbOrderAmount = new System.Windows.Forms.GroupBox();
			this.labelTotal = new System.Windows.Forms.Label();
			this.labelDiscount = new System.Windows.Forms.Label();
			this.labelSubtotal = new System.Windows.Forms.Label();
			this.labelTotalTitle = new System.Windows.Forms.Label();
			this.labelDiscountTitle = new System.Windows.Forms.Label();
			this.labelSubTotalTitle = new System.Windows.Forms.Label();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.btnSubmitOrder = new System.Windows.Forms.Button();
			this.btnOrderMemberCheck = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.gbOrderInfo.SuspendLayout();
			this.panel2.SuspendLayout();
			this.gbOrderChoose.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvProductList)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.product_LBSMSBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bentoSystemDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bentoSystemDataSet2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.orderDataLBSMSBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.orderDataLBSMSBindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bentoSystemDataSet3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.orderItem_LBSMSBindingSource)).BeginInit();
			this.gbOrderAmount.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
			this.panel1.Controls.Add(this.pictureBox2);
			this.panel1.Controls.Add(this.btnLogout);
			this.panel1.Controls.Add(this.btnOrders);
			this.panel1.Controls.Add(this.btnMembers);
			this.panel1.Controls.Add(this.btnProducts);
			this.panel1.Controls.Add(this.btnMainForm);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Location = new System.Drawing.Point(-1, -1);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(245, 631);
			this.panel1.TabIndex = 11;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(41, 200);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(156, 53);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 13;
			this.pictureBox2.TabStop = false;
			this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
			// 
			// btnLogout
			// 
			this.btnLogout.BackColor = System.Drawing.Color.Tomato;
			this.btnLogout.FlatAppearance.BorderSize = 0;
			this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLogout.Font = new System.Drawing.Font("jf open 粉圓 2.1", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLogout.ForeColor = System.Drawing.Color.White;
			this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
			this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnLogout.Location = new System.Drawing.Point(1, 586);
			this.btnLogout.Name = "btnLogout";
			this.btnLogout.Size = new System.Drawing.Size(244, 44);
			this.btnLogout.TabIndex = 6;
			this.btnLogout.Text = "登出";
			this.btnLogout.UseVisualStyleBackColor = false;
			this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
			// 
			// btnOrders
			// 
			this.btnOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(140)))), ((int)(((byte)(33)))));
			this.btnOrders.FlatAppearance.BorderSize = 0;
			this.btnOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnOrders.Font = new System.Drawing.Font("jf open 粉圓 2.1", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnOrders.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
			this.btnOrders.Image = ((System.Drawing.Image)(resources.GetObject("btnOrders.Image")));
			this.btnOrders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnOrders.Location = new System.Drawing.Point(41, 509);
			this.btnOrders.Name = "btnOrders";
			this.btnOrders.Size = new System.Drawing.Size(156, 44);
			this.btnOrders.TabIndex = 4;
			this.btnOrders.Text = " 訂單管理";
			this.btnOrders.UseVisualStyleBackColor = false;
			this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
			// 
			// btnMembers
			// 
			this.btnMembers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
			this.btnMembers.FlatAppearance.BorderSize = 0;
			this.btnMembers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(140)))), ((int)(((byte)(33)))));
			this.btnMembers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMembers.Font = new System.Drawing.Font("jf open 粉圓 2.1", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMembers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
			this.btnMembers.Image = ((System.Drawing.Image)(resources.GetObject("btnMembers.Image")));
			this.btnMembers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnMembers.Location = new System.Drawing.Point(41, 434);
			this.btnMembers.Name = "btnMembers";
			this.btnMembers.Size = new System.Drawing.Size(156, 44);
			this.btnMembers.TabIndex = 3;
			this.btnMembers.Text = " 會員管理";
			this.btnMembers.UseVisualStyleBackColor = false;
			this.btnMembers.Click += new System.EventHandler(this.btnMember_Click);
			// 
			// btnProducts
			// 
			this.btnProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
			this.btnProducts.FlatAppearance.BorderSize = 0;
			this.btnProducts.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(140)))), ((int)(((byte)(33)))));
			this.btnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnProducts.Font = new System.Drawing.Font("jf open 粉圓 2.1", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnProducts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
			this.btnProducts.Image = ((System.Drawing.Image)(resources.GetObject("btnProducts.Image")));
			this.btnProducts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnProducts.Location = new System.Drawing.Point(41, 359);
			this.btnProducts.Name = "btnProducts";
			this.btnProducts.Size = new System.Drawing.Size(156, 44);
			this.btnProducts.TabIndex = 2;
			this.btnProducts.Text = " 產品管理";
			this.btnProducts.UseVisualStyleBackColor = false;
			this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
			// 
			// btnMainForm
			// 
			this.btnMainForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
			this.btnMainForm.FlatAppearance.BorderSize = 0;
			this.btnMainForm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(140)))), ((int)(((byte)(33)))));
			this.btnMainForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMainForm.Font = new System.Drawing.Font("jf open 粉圓 2.1", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMainForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
			this.btnMainForm.Image = ((System.Drawing.Image)(resources.GetObject("btnMainForm.Image")));
			this.btnMainForm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnMainForm.Location = new System.Drawing.Point(41, 284);
			this.btnMainForm.Name = "btnMainForm";
			this.btnMainForm.Size = new System.Drawing.Size(156, 44);
			this.btnMainForm.TabIndex = 1;
			this.btnMainForm.Text = "主選單";
			this.btnMainForm.UseVisualStyleBackColor = false;
			this.btnMainForm.Click += new System.EventHandler(this.btnMainForm_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(41, 32);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(156, 137);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// gbOrderInfo
			// 
			this.gbOrderInfo.Controls.Add(this.labelOrderTime);
			this.gbOrderInfo.Controls.Add(this.cbMemberList);
			this.gbOrderInfo.Controls.Add(this.labelOrderType);
			this.gbOrderInfo.Controls.Add(this.txtOrderPhone);
			this.gbOrderInfo.Controls.Add(this.labelOrderPhone);
			this.gbOrderInfo.Controls.Add(this.labelOrderDateTime);
			this.gbOrderInfo.Controls.Add(this.txtInsertOrderName);
			this.gbOrderInfo.Controls.Add(this.rbtnNonMember);
			this.gbOrderInfo.Controls.Add(this.rbtnIsMember);
			this.gbOrderInfo.Controls.Add(this.panel2);
			this.gbOrderInfo.Location = new System.Drawing.Point(478, 12);
			this.gbOrderInfo.Name = "gbOrderInfo";
			this.gbOrderInfo.Size = new System.Drawing.Size(510, 145);
			this.gbOrderInfo.TabIndex = 24;
			this.gbOrderInfo.TabStop = false;
			this.gbOrderInfo.Text = "訂單資訊";
			this.gbOrderInfo.Enter += new System.EventHandler(this.gbOrderInfo_Enter);
			// 
			// labelOrderTime
			// 
			this.labelOrderTime.AutoSize = true;
			this.labelOrderTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(140)))), ((int)(((byte)(33)))));
			this.labelOrderTime.Location = new System.Drawing.Point(114, 111);
			this.labelOrderTime.Name = "labelOrderTime";
			this.labelOrderTime.Size = new System.Drawing.Size(0, 17);
			this.labelOrderTime.TabIndex = 13;
			// 
			// cbMemberList
			// 
			this.cbMemberList.FormattingEnabled = true;
			this.cbMemberList.Location = new System.Drawing.Point(89, 27);
			this.cbMemberList.Name = "cbMemberList";
			this.cbMemberList.Size = new System.Drawing.Size(149, 25);
			this.cbMemberList.TabIndex = 10;
			this.cbMemberList.SelectedIndexChanged += new System.EventHandler(this.cbMemberList_SelectedIndexChanged);
			// 
			// labelOrderType
			// 
			this.labelOrderType.AutoSize = true;
			this.labelOrderType.Location = new System.Drawing.Point(244, 72);
			this.labelOrderType.Name = "labelOrderType";
			this.labelOrderType.Size = new System.Drawing.Size(98, 17);
			this.labelOrderType.TabIndex = 6;
			this.labelOrderType.Text = "【訂購方式】";
			// 
			// txtOrderPhone
			// 
			this.txtOrderPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(140)))), ((int)(((byte)(33)))));
			this.txtOrderPhone.Location = new System.Drawing.Point(89, 68);
			this.txtOrderPhone.Name = "txtOrderPhone";
			this.txtOrderPhone.Size = new System.Drawing.Size(149, 25);
			this.txtOrderPhone.TabIndex = 4;
			// 
			// labelOrderPhone
			// 
			this.labelOrderPhone.AutoSize = true;
			this.labelOrderPhone.Location = new System.Drawing.Point(4, 72);
			this.labelOrderPhone.Name = "labelOrderPhone";
			this.labelOrderPhone.Size = new System.Drawing.Size(68, 17);
			this.labelOrderPhone.TabIndex = 3;
			this.labelOrderPhone.Text = "【電話】";
			// 
			// labelOrderDateTime
			// 
			this.labelOrderDateTime.AutoSize = true;
			this.labelOrderDateTime.Location = new System.Drawing.Point(4, 111);
			this.labelOrderDateTime.Name = "labelOrderDateTime";
			this.labelOrderDateTime.Size = new System.Drawing.Size(98, 17);
			this.labelOrderDateTime.TabIndex = 8;
			this.labelOrderDateTime.Text = "【訂購時間】";
			this.labelOrderDateTime.Click += new System.EventHandler(this.labelOrderDateTime_Click);
			// 
			// txtInsertOrderName
			// 
			this.txtInsertOrderName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtInsertOrderName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(140)))), ((int)(((byte)(33)))));
			this.txtInsertOrderName.Location = new System.Drawing.Point(348, 27);
			this.txtInsertOrderName.Name = "txtInsertOrderName";
			this.txtInsertOrderName.Size = new System.Drawing.Size(138, 25);
			this.txtInsertOrderName.TabIndex = 2;
			// 
			// rbtnNonMember
			// 
			this.rbtnNonMember.AutoSize = true;
			this.rbtnNonMember.Location = new System.Drawing.Point(256, 29);
			this.rbtnNonMember.Name = "rbtnNonMember";
			this.rbtnNonMember.Size = new System.Drawing.Size(86, 21);
			this.rbtnNonMember.TabIndex = 1;
			this.rbtnNonMember.TabStop = true;
			this.rbtnNonMember.Text = "非會員：";
			this.rbtnNonMember.UseVisualStyleBackColor = true;
			this.rbtnNonMember.CheckedChanged += new System.EventHandler(this.MemberTypeChanged);
			// 
			// rbtnIsMember
			// 
			this.rbtnIsMember.AutoSize = true;
			this.rbtnIsMember.Location = new System.Drawing.Point(13, 29);
			this.rbtnIsMember.Name = "rbtnIsMember";
			this.rbtnIsMember.Size = new System.Drawing.Size(71, 21);
			this.rbtnIsMember.TabIndex = 0;
			this.rbtnIsMember.TabStop = true;
			this.rbtnIsMember.Text = "會員：";
			this.rbtnIsMember.UseVisualStyleBackColor = true;
			this.rbtnIsMember.CheckedChanged += new System.EventHandler(this.MemberTypeChanged);
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.rbtnPickup);
			this.panel2.Controls.Add(this.rbtnDelivery);
			this.panel2.Location = new System.Drawing.Point(346, 72);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(140, 25);
			this.panel2.TabIndex = 14;
			// 
			// rbtnPickup
			// 
			this.rbtnPickup.AutoSize = true;
			this.rbtnPickup.Location = new System.Drawing.Point(81, 1);
			this.rbtnPickup.Name = "rbtnPickup";
			this.rbtnPickup.Size = new System.Drawing.Size(56, 21);
			this.rbtnPickup.TabIndex = 12;
			this.rbtnPickup.TabStop = true;
			this.rbtnPickup.Text = "自取";
			this.rbtnPickup.UseVisualStyleBackColor = true;
			// 
			// rbtnDelivery
			// 
			this.rbtnDelivery.AutoSize = true;
			this.rbtnDelivery.Location = new System.Drawing.Point(5, 1);
			this.rbtnDelivery.Name = "rbtnDelivery";
			this.rbtnDelivery.Size = new System.Drawing.Size(56, 21);
			this.rbtnDelivery.TabIndex = 11;
			this.rbtnDelivery.TabStop = true;
			this.rbtnDelivery.Text = "外帶";
			this.rbtnDelivery.UseVisualStyleBackColor = true;
			// 
			// gbOrderChoose
			// 
			this.gbOrderChoose.Controls.Add(this.label2);
			this.gbOrderChoose.Controls.Add(this.dgvProductList);
			this.gbOrderChoose.Controls.Add(this.btnOrderAdd);
			this.gbOrderChoose.Controls.Add(this.labelOrderNumber);
			this.gbOrderChoose.Controls.Add(this.nudQuantity);
			this.gbOrderChoose.Location = new System.Drawing.Point(262, 162);
			this.gbOrderChoose.Name = "gbOrderChoose";
			this.gbOrderChoose.Size = new System.Drawing.Size(726, 283);
			this.gbOrderChoose.TabIndex = 25;
			this.gbOrderChoose.TabStop = false;
			this.gbOrderChoose.Text = "餐點選擇";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.label2.Location = new System.Drawing.Point(11, 230);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(338, 17);
			this.label2.TabIndex = 6;
			this.label2.Text = "＊每個便當均附紫菜蛋花湯、珍珠奶茶和焦糖布丁";
			// 
			// dgvProductList
			// 
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
			this.dgvProductList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvProductList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvProductList.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
			this.dgvProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvProductList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductName,
            this.ProductPrice,
            this.StockQuantity,
            this.ProductDesc});
			this.dgvProductList.Location = new System.Drawing.Point(16, 30);
			this.dgvProductList.Name = "dgvProductList";
			this.dgvProductList.RowTemplate.Height = 24;
			this.dgvProductList.Size = new System.Drawing.Size(588, 196);
			this.dgvProductList.TabIndex = 5;
			this.dgvProductList.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvProductList_CellFormatting);
			// 
			// ProductName
			// 
			this.ProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.ProductName.DataPropertyName = "ProductName";
			this.ProductName.HeaderText = "品項";
			this.ProductName.Name = "ProductName";
			this.ProductName.ReadOnly = true;
			this.ProductName.ToolTipText = "品項";
			this.ProductName.Width = 63;
			// 
			// ProductPrice
			// 
			this.ProductPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.ProductPrice.DataPropertyName = "ProductPrice";
			this.ProductPrice.HeaderText = "單價";
			this.ProductPrice.Name = "ProductPrice";
			this.ProductPrice.ReadOnly = true;
			this.ProductPrice.ToolTipText = "單價";
			this.ProductPrice.Width = 63;
			// 
			// StockQuantity
			// 
			this.StockQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.StockQuantity.DataPropertyName = "StockQuantity";
			this.StockQuantity.HeaderText = "庫存";
			this.StockQuantity.Name = "StockQuantity";
			this.StockQuantity.ReadOnly = true;
			this.StockQuantity.ToolTipText = "庫存";
			this.StockQuantity.Width = 63;
			// 
			// ProductDesc
			// 
			this.ProductDesc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.ProductDesc.DataPropertyName = "ProductDesc";
			this.ProductDesc.HeaderText = "描述";
			this.ProductDesc.Name = "ProductDesc";
			this.ProductDesc.ReadOnly = true;
			this.ProductDesc.ToolTipText = "描述";
			this.ProductDesc.Width = 63;
			// 
			// btnOrderAdd
			// 
			this.btnOrderAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(140)))), ((int)(((byte)(33)))));
			this.btnOrderAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnOrderAdd.Font = new System.Drawing.Font("jf open 粉圓 2.1", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnOrderAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
			this.btnOrderAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnOrderAdd.Image")));
			this.btnOrderAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnOrderAdd.Location = new System.Drawing.Point(585, 233);
			this.btnOrderAdd.Name = "btnOrderAdd";
			this.btnOrderAdd.Size = new System.Drawing.Size(125, 38);
			this.btnOrderAdd.TabIndex = 4;
			this.btnOrderAdd.Text = "   加入訂單";
			this.btnOrderAdd.UseVisualStyleBackColor = false;
			this.btnOrderAdd.Click += new System.EventHandler(this.btnOrderAdd_Click_1);
			// 
			// labelOrderNumber
			// 
			this.labelOrderNumber.AutoSize = true;
			this.labelOrderNumber.Font = new System.Drawing.Font("jf open 粉圓 2.1", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.labelOrderNumber.Location = new System.Drawing.Point(610, 155);
			this.labelOrderNumber.Name = "labelOrderNumber";
			this.labelOrderNumber.Size = new System.Drawing.Size(56, 18);
			this.labelOrderNumber.TabIndex = 2;
			this.labelOrderNumber.Text = "數量：";
			this.labelOrderNumber.Click += new System.EventHandler(this.labelOrderNumber_Click);
			// 
			// nudQuantity
			// 
			this.nudQuantity.Font = new System.Drawing.Font("jf open 粉圓 2.1", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.nudQuantity.Location = new System.Drawing.Point(660, 176);
			this.nudQuantity.Name = "nudQuantity";
			this.nudQuantity.Size = new System.Drawing.Size(50, 32);
			this.nudQuantity.TabIndex = 1;
			this.nudQuantity.ValueChanged += new System.EventHandler(this.nudQuantity_ValueChanged);
			// 
			// product_LBSMSBindingSource
			// 
			this.product_LBSMSBindingSource.DataMember = "Product_LBSMS";
			this.product_LBSMSBindingSource.DataSource = this.bentoSystemDataSet;
			// 
			// bentoSystemDataSet
			// 
			this.bentoSystemDataSet.DataSetName = "BentoSystemDataSet";
			this.bentoSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// bentoSystemDataSet2
			// 
			this.bentoSystemDataSet2.DataSetName = "BentoSystemDataSet2";
			this.bentoSystemDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// orderDataLBSMSBindingSource
			// 
			this.orderDataLBSMSBindingSource.DataMember = "OrderData_LBSMS";
			this.orderDataLBSMSBindingSource.DataSource = this.bentoSystemDataSet2;
			// 
			// orderData_LBSMSTableAdapter
			// 
			this.orderData_LBSMSTableAdapter.ClearBeforeFill = true;
			// 
			// orderDataLBSMSBindingSource1
			// 
			this.orderDataLBSMSBindingSource1.DataMember = "OrderData_LBSMS";
			this.orderDataLBSMSBindingSource1.DataSource = this.bentoSystemDataSet2;
			// 
			// bentoSystemDataSet3
			// 
			this.bentoSystemDataSet3.DataSetName = "BentoSystemDataSet3";
			this.bentoSystemDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// orderItem_LBSMSBindingSource
			// 
			this.orderItem_LBSMSBindingSource.DataMember = "OrderItem_LBSMS";
			this.orderItem_LBSMSBindingSource.DataSource = this.bentoSystemDataSet3;
			// 
			// orderItem_LBSMSTableAdapter
			// 
			this.orderItem_LBSMSTableAdapter.ClearBeforeFill = true;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.OrderItem_LBSMSTableAdapter = this.orderItem_LBSMSTableAdapter;
			this.tableAdapterManager.UpdateOrder = BentoSystemWinform.BentoSystemDataSet3TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			// 
			// gbOrderAmount
			// 
			this.gbOrderAmount.Controls.Add(this.labelTotal);
			this.gbOrderAmount.Controls.Add(this.labelDiscount);
			this.gbOrderAmount.Controls.Add(this.labelSubtotal);
			this.gbOrderAmount.Controls.Add(this.labelTotalTitle);
			this.gbOrderAmount.Controls.Add(this.labelDiscountTitle);
			this.gbOrderAmount.Controls.Add(this.labelSubTotalTitle);
			this.gbOrderAmount.Location = new System.Drawing.Point(262, 459);
			this.gbOrderAmount.Name = "gbOrderAmount";
			this.gbOrderAmount.Size = new System.Drawing.Size(397, 138);
			this.gbOrderAmount.TabIndex = 26;
			this.gbOrderAmount.TabStop = false;
			this.gbOrderAmount.Text = "金額試算";
			this.gbOrderAmount.Enter += new System.EventHandler(this.gbOrderAmount_Enter);
			// 
			// labelTotal
			// 
			this.labelTotal.AutoSize = true;
			this.labelTotal.BackColor = System.Drawing.Color.Transparent;
			this.labelTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.labelTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.labelTotal.Font = new System.Drawing.Font("jf open 粉圓 2.1", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.labelTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(140)))), ((int)(((byte)(33)))));
			this.labelTotal.Location = new System.Drawing.Point(118, 94);
			this.labelTotal.Name = "labelTotal";
			this.labelTotal.Size = new System.Drawing.Size(2, 26);
			this.labelTotal.TabIndex = 5;
			// 
			// labelDiscount
			// 
			this.labelDiscount.AutoSize = true;
			this.labelDiscount.BackColor = System.Drawing.Color.Transparent;
			this.labelDiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.labelDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.labelDiscount.ForeColor = System.Drawing.Color.Red;
			this.labelDiscount.Location = new System.Drawing.Point(118, 65);
			this.labelDiscount.Name = "labelDiscount";
			this.labelDiscount.Size = new System.Drawing.Size(2, 19);
			this.labelDiscount.TabIndex = 4;
			// 
			// labelSubtotal
			// 
			this.labelSubtotal.AutoSize = true;
			this.labelSubtotal.BackColor = System.Drawing.Color.Transparent;
			this.labelSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.labelSubtotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.labelSubtotal.Location = new System.Drawing.Point(118, 36);
			this.labelSubtotal.Name = "labelSubtotal";
			this.labelSubtotal.Size = new System.Drawing.Size(2, 19);
			this.labelSubtotal.TabIndex = 3;
			// 
			// labelTotalTitle
			// 
			this.labelTotalTitle.AutoSize = true;
			this.labelTotalTitle.Font = new System.Drawing.Font("jf open 粉圓 2.1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.labelTotalTitle.Location = new System.Drawing.Point(28, 95);
			this.labelTotalTitle.Name = "labelTotalTitle";
			this.labelTotalTitle.Size = new System.Drawing.Size(86, 22);
			this.labelTotalTitle.TabIndex = 2;
			this.labelTotalTitle.Text = "總金額：";
			this.labelTotalTitle.Click += new System.EventHandler(this.labelTotalTitle_Click);
			// 
			// labelDiscountTitle
			// 
			this.labelDiscountTitle.AutoSize = true;
			this.labelDiscountTitle.Location = new System.Drawing.Point(28, 66);
			this.labelDiscountTitle.Name = "labelDiscountTitle";
			this.labelDiscountTitle.Size = new System.Drawing.Size(53, 17);
			this.labelDiscountTitle.TabIndex = 1;
			this.labelDiscountTitle.Text = "折扣：";
			// 
			// labelSubTotalTitle
			// 
			this.labelSubTotalTitle.AutoSize = true;
			this.labelSubTotalTitle.Location = new System.Drawing.Point(28, 37);
			this.labelSubTotalTitle.Name = "labelSubTotalTitle";
			this.labelSubTotalTitle.Size = new System.Drawing.Size(53, 17);
			this.labelSubTotalTitle.TabIndex = 0;
			this.labelSubTotalTitle.Text = "小計：";
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.btnOrderMemberCheck, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(690, 459);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(147, 138);
			this.tableLayoutPanel1.TabIndex = 28;
			// 
			// btnSubmitOrder
			// 
			this.btnSubmitOrder.BackColor = System.Drawing.Color.Red;
			this.btnSubmitOrder.FlatAppearance.BorderSize = 0;
			this.btnSubmitOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSubmitOrder.Font = new System.Drawing.Font("jf open 粉圓 2.1", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnSubmitOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
			this.btnSubmitOrder.Location = new System.Drawing.Point(847, 462);
			this.btnSubmitOrder.Name = "btnSubmitOrder";
			this.btnSubmitOrder.Size = new System.Drawing.Size(143, 135);
			this.btnSubmitOrder.TabIndex = 29;
			this.btnSubmitOrder.Text = "送出訂單";
			this.btnSubmitOrder.UseVisualStyleBackColor = false;
			this.btnSubmitOrder.Click += new System.EventHandler(this.btnSubmitOrder_Click);
			// 
			// btnOrderMemberCheck
			// 
			this.btnOrderMemberCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(140)))), ((int)(((byte)(33)))));
			this.btnOrderMemberCheck.FlatAppearance.BorderSize = 0;
			this.btnOrderMemberCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnOrderMemberCheck.Font = new System.Drawing.Font("jf open 粉圓 2.1", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnOrderMemberCheck.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
			this.btnOrderMemberCheck.Location = new System.Drawing.Point(3, 3);
			this.btnOrderMemberCheck.Name = "btnOrderMemberCheck";
			this.btnOrderMemberCheck.Size = new System.Drawing.Size(141, 63);
			this.btnOrderMemberCheck.TabIndex = 30;
			this.btnOrderMemberCheck.Text = "點數確認";
			this.btnOrderMemberCheck.UseVisualStyleBackColor = false;
			this.btnOrderMemberCheck.Click += new System.EventHandler(this.btnPointCheck_Click);
			// 
			// btnExit
			// 
			this.btnExit.BackColor = System.Drawing.Color.Transparent;
			this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
			this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btnExit.ForeColor = System.Drawing.Color.Transparent;
			this.btnExit.Location = new System.Drawing.Point(994, 11);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(27, 27);
			this.btnExit.TabIndex = 23;
			this.btnExit.UseVisualStyleBackColor = false;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(262, 12);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(209, 73);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox3.TabIndex = 22;
			this.pictureBox3.TabStop = false;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.label1.Font = new System.Drawing.Font("jf open 粉圓 2.1", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.label1.Location = new System.Drawing.Point(3, 69);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(141, 69);
			this.label1.TabIndex = 31;
			this.label1.Text = "【消費百元累積1點】\r\n【壽星我最大活動】\r\n會員生日當月均打８折\r\n當天完全免費(限1筆)\r\n";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// OrderForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
			this.ClientSize = new System.Drawing.Size(1033, 629);
			this.Controls.Add(this.btnSubmitOrder);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.gbOrderAmount);
			this.Controls.Add(this.gbOrderChoose);
			this.Controls.Add(this.gbOrderInfo);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("jf open 粉圓 2.1", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "OrderForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "阿萱便當後臺系統：訂單管理";
			this.Load += new System.EventHandler(this.OrderForm_Load);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OrderForm_MouseDown);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OrderForm_MouseMove);
			this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OrderForm_MouseUp);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.gbOrderInfo.ResumeLayout(false);
			this.gbOrderInfo.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.gbOrderChoose.ResumeLayout(false);
			this.gbOrderChoose.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvProductList)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.product_LBSMSBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bentoSystemDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bentoSystemDataSet2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.orderDataLBSMSBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.orderDataLBSMSBindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bentoSystemDataSet3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.orderItem_LBSMSBindingSource)).EndInit();
			this.gbOrderAmount.ResumeLayout(false);
			this.gbOrderAmount.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Button btnLogout;
		private System.Windows.Forms.Button btnOrders;
		private System.Windows.Forms.Button btnMembers;
		private System.Windows.Forms.Button btnProducts;
		private System.Windows.Forms.Button btnMainForm;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.GroupBox gbOrderInfo;
		private System.Windows.Forms.TextBox txtInsertOrderName;
		private System.Windows.Forms.RadioButton rbtnNonMember;
		private System.Windows.Forms.RadioButton rbtnIsMember;
		private System.Windows.Forms.TextBox txtOrderPhone;
		private System.Windows.Forms.Label labelOrderPhone;
		private System.Windows.Forms.Label labelOrderType;
		private BentoSystemDataSet2 bentoSystemDataSet2;
		private System.Windows.Forms.BindingSource orderDataLBSMSBindingSource;
		private BentoSystemDataSet2TableAdapters.OrderData_LBSMSTableAdapter orderData_LBSMSTableAdapter;
		private System.Windows.Forms.BindingSource orderDataLBSMSBindingSource1;
		private System.Windows.Forms.Label labelOrderDateTime;
		private System.Windows.Forms.GroupBox gbOrderChoose;
		private BentoSystemDataSet3 bentoSystemDataSet3;
		private System.Windows.Forms.BindingSource orderItem_LBSMSBindingSource;
		private BentoSystemDataSet3TableAdapters.OrderItem_LBSMSTableAdapter orderItem_LBSMSTableAdapter;
		private BentoSystemDataSet3TableAdapters.TableAdapterManager tableAdapterManager;
		private BentoSystemDataSet bentoSystemDataSet;
		private System.Windows.Forms.BindingSource product_LBSMSBindingSource;
		private System.Windows.Forms.Label labelOrderNumber;
		private System.Windows.Forms.NumericUpDown nudQuantity;
		private System.Windows.Forms.GroupBox gbOrderAmount;
		private System.Windows.Forms.Label labelTotalTitle;
		private System.Windows.Forms.Label labelDiscountTitle;
		private System.Windows.Forms.Label labelSubTotalTitle;
		private System.Windows.Forms.Label labelSubtotal;
		private System.Windows.Forms.Label labelTotal;
		private System.Windows.Forms.Label labelDiscount;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Button btnOrderMemberCheck;
		private System.Windows.Forms.ComboBox cbMemberList;
		private System.Windows.Forms.RadioButton rbtnDelivery;
		private System.Windows.Forms.RadioButton rbtnPickup;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Label labelOrderTime;
		private System.Windows.Forms.DataGridView dgvProductList;
		private System.Windows.Forms.Button btnOrderAdd;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button btnSubmitOrder;
		private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
		private System.Windows.Forms.DataGridViewTextBoxColumn ProductPrice;
		private System.Windows.Forms.DataGridViewTextBoxColumn StockQuantity;
		private System.Windows.Forms.DataGridViewTextBoxColumn ProductDesc;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}