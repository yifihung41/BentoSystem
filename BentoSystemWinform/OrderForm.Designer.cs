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
			this.labelOrderDateTime = new System.Windows.Forms.Label();
			this.cbOrderType = new System.Windows.Forms.ComboBox();
			this.labelOrderType = new System.Windows.Forms.Label();
			this.textOrderPhone = new System.Windows.Forms.TextBox();
			this.labelOrderPhone = new System.Windows.Forms.Label();
			this.txtNonMember = new System.Windows.Forms.TextBox();
			this.rbtnNonMember = new System.Windows.Forms.RadioButton();
			this.rbtnIsMember = new System.Windows.Forms.RadioButton();
			this.gbOrderChoose = new System.Windows.Forms.GroupBox();
			this.btnOrderAdd = new System.Windows.Forms.Button();
			this.chbSpicy = new System.Windows.Forms.CheckBox();
			this.labelOrderNumber = new System.Windows.Forms.Label();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
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
			this.btnOrderClear = new System.Windows.Forms.Button();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.btnOrderPre = new System.Windows.Forms.Button();
			this.btnOrderOK = new System.Windows.Forms.Button();
			this.btnOrderMemberCheck = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.gbOrderInfo.SuspendLayout();
			this.gbOrderChoose.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
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
			this.gbOrderInfo.Controls.Add(this.labelOrderDateTime);
			this.gbOrderInfo.Controls.Add(this.cbOrderType);
			this.gbOrderInfo.Controls.Add(this.labelOrderType);
			this.gbOrderInfo.Controls.Add(this.textOrderPhone);
			this.gbOrderInfo.Controls.Add(this.labelOrderPhone);
			this.gbOrderInfo.Controls.Add(this.txtNonMember);
			this.gbOrderInfo.Controls.Add(this.rbtnNonMember);
			this.gbOrderInfo.Controls.Add(this.rbtnIsMember);
			this.gbOrderInfo.Location = new System.Drawing.Point(478, 11);
			this.gbOrderInfo.Name = "gbOrderInfo";
			this.gbOrderInfo.Size = new System.Drawing.Size(510, 97);
			this.gbOrderInfo.TabIndex = 24;
			this.gbOrderInfo.TabStop = false;
			this.gbOrderInfo.Text = "訂單資訊";
			// 
			// labelOrderTime
			// 
			this.labelOrderTime.AutoSize = true;
			this.labelOrderTime.BackColor = System.Drawing.Color.White;
			this.labelOrderTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(140)))), ((int)(((byte)(33)))));
			this.labelOrderTime.Location = new System.Drawing.Point(334, 59);
			this.labelOrderTime.Name = "labelOrderTime";
			this.labelOrderTime.Size = new System.Drawing.Size(0, 17);
			this.labelOrderTime.TabIndex = 9;
			// 
			// labelOrderDateTime
			// 
			this.labelOrderDateTime.AutoSize = true;
			this.labelOrderDateTime.Location = new System.Drawing.Point(244, 59);
			this.labelOrderDateTime.Name = "labelOrderDateTime";
			this.labelOrderDateTime.Size = new System.Drawing.Size(83, 17);
			this.labelOrderDateTime.TabIndex = 8;
			this.labelOrderDateTime.Text = "訂購時間：";
			// 
			// cbOrderType
			// 
			this.cbOrderType.FormattingEnabled = true;
			this.cbOrderType.Location = new System.Drawing.Point(100, 55);
			this.cbOrderType.Name = "cbOrderType";
			this.cbOrderType.Size = new System.Drawing.Size(121, 25);
			this.cbOrderType.TabIndex = 7;
			// 
			// labelOrderType
			// 
			this.labelOrderType.AutoSize = true;
			this.labelOrderType.Location = new System.Drawing.Point(16, 59);
			this.labelOrderType.Name = "labelOrderType";
			this.labelOrderType.Size = new System.Drawing.Size(83, 17);
			this.labelOrderType.TabIndex = 6;
			this.labelOrderType.Text = "訂購方式：";
			// 
			// textOrderPhone
			// 
			this.textOrderPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(140)))), ((int)(((byte)(33)))));
			this.textOrderPhone.Location = new System.Drawing.Point(343, 22);
			this.textOrderPhone.Name = "textOrderPhone";
			this.textOrderPhone.Size = new System.Drawing.Size(149, 25);
			this.textOrderPhone.TabIndex = 4;
			// 
			// labelOrderPhone
			// 
			this.labelOrderPhone.AutoSize = true;
			this.labelOrderPhone.Location = new System.Drawing.Point(283, 26);
			this.labelOrderPhone.Name = "labelOrderPhone";
			this.labelOrderPhone.Size = new System.Drawing.Size(53, 17);
			this.labelOrderPhone.TabIndex = 3;
			this.labelOrderPhone.Text = "電話：";
			// 
			// txtNonMember
			// 
			this.txtNonMember.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtNonMember.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(140)))), ((int)(((byte)(33)))));
			this.txtNonMember.Location = new System.Drawing.Point(173, 22);
			this.txtNonMember.Name = "txtNonMember";
			this.txtNonMember.Size = new System.Drawing.Size(100, 25);
			this.txtNonMember.TabIndex = 2;
			// 
			// rbtnNonMember
			// 
			this.rbtnNonMember.AutoSize = true;
			this.rbtnNonMember.Location = new System.Drawing.Point(78, 24);
			this.rbtnNonMember.Name = "rbtnNonMember";
			this.rbtnNonMember.Size = new System.Drawing.Size(86, 21);
			this.rbtnNonMember.TabIndex = 1;
			this.rbtnNonMember.TabStop = true;
			this.rbtnNonMember.Text = "非會員：";
			this.rbtnNonMember.UseVisualStyleBackColor = true;
			// 
			// rbtnIsMember
			// 
			this.rbtnIsMember.AutoSize = true;
			this.rbtnIsMember.Location = new System.Drawing.Point(16, 24);
			this.rbtnIsMember.Name = "rbtnIsMember";
			this.rbtnIsMember.Size = new System.Drawing.Size(56, 21);
			this.rbtnIsMember.TabIndex = 0;
			this.rbtnIsMember.TabStop = true;
			this.rbtnIsMember.Text = "會員";
			this.rbtnIsMember.UseVisualStyleBackColor = true;
			// 
			// gbOrderChoose
			// 
			this.gbOrderChoose.Controls.Add(this.btnOrderAdd);
			this.gbOrderChoose.Controls.Add(this.chbSpicy);
			this.gbOrderChoose.Controls.Add(this.labelOrderNumber);
			this.gbOrderChoose.Controls.Add(this.numericUpDown1);
			this.gbOrderChoose.Location = new System.Drawing.Point(262, 127);
			this.gbOrderChoose.Name = "gbOrderChoose";
			this.gbOrderChoose.Size = new System.Drawing.Size(726, 283);
			this.gbOrderChoose.TabIndex = 25;
			this.gbOrderChoose.TabStop = false;
			this.gbOrderChoose.Text = "餐點選擇";
			// 
			// btnOrderAdd
			// 
			this.btnOrderAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(140)))), ((int)(((byte)(33)))));
			this.btnOrderAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnOrderAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
			this.btnOrderAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnOrderAdd.Image")));
			this.btnOrderAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnOrderAdd.Location = new System.Drawing.Point(609, 244);
			this.btnOrderAdd.Name = "btnOrderAdd";
			this.btnOrderAdd.Size = new System.Drawing.Size(111, 29);
			this.btnOrderAdd.TabIndex = 4;
			this.btnOrderAdd.Text = "   加入訂單";
			this.btnOrderAdd.UseVisualStyleBackColor = false;
			// 
			// chbSpicy
			// 
			this.chbSpicy.AutoSize = true;
			this.chbSpicy.Location = new System.Drawing.Point(428, 248);
			this.chbSpicy.Name = "chbSpicy";
			this.chbSpicy.Size = new System.Drawing.Size(57, 21);
			this.chbSpicy.TabIndex = 3;
			this.chbSpicy.Text = "加辣";
			this.chbSpicy.UseVisualStyleBackColor = true;
			// 
			// labelOrderNumber
			// 
			this.labelOrderNumber.AutoSize = true;
			this.labelOrderNumber.Location = new System.Drawing.Point(491, 250);
			this.labelOrderNumber.Name = "labelOrderNumber";
			this.labelOrderNumber.Size = new System.Drawing.Size(53, 17);
			this.labelOrderNumber.TabIndex = 2;
			this.labelOrderNumber.Text = "數量：";
			this.labelOrderNumber.Click += new System.EventHandler(this.labelOrderNumber_Click);
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Location = new System.Drawing.Point(550, 246);
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(41, 25);
			this.numericUpDown1.TabIndex = 1;
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
			this.gbOrderAmount.Location = new System.Drawing.Point(262, 444);
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
			this.labelTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.labelTotal.Font = new System.Drawing.Font("jf open 粉圓 2.1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.labelTotal.Location = new System.Drawing.Point(118, 94);
			this.labelTotal.Name = "labelTotal";
			this.labelTotal.Size = new System.Drawing.Size(2, 24);
			this.labelTotal.TabIndex = 5;
			// 
			// labelDiscount
			// 
			this.labelDiscount.AutoSize = true;
			this.labelDiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.labelDiscount.Location = new System.Drawing.Point(118, 65);
			this.labelDiscount.Name = "labelDiscount";
			this.labelDiscount.Size = new System.Drawing.Size(2, 19);
			this.labelDiscount.TabIndex = 4;
			// 
			// labelSubtotal
			// 
			this.labelSubtotal.AutoSize = true;
			this.labelSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
			// btnOrderClear
			// 
			this.btnOrderClear.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.btnOrderClear.FlatAppearance.BorderSize = 0;
			this.btnOrderClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnOrderClear.Font = new System.Drawing.Font("jf open 粉圓 2.1", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnOrderClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
			this.btnOrderClear.Location = new System.Drawing.Point(3, 3);
			this.btnOrderClear.Name = "btnOrderClear";
			this.btnOrderClear.Size = new System.Drawing.Size(142, 63);
			this.btnOrderClear.TabIndex = 27;
			this.btnOrderClear.Text = "清除訂單";
			this.btnOrderClear.UseVisualStyleBackColor = false;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.btnOrderClear, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.btnOrderPre, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.btnOrderOK, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.btnOrderMemberCheck, 0, 1);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(690, 444);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(297, 138);
			this.tableLayoutPanel1.TabIndex = 28;
			// 
			// btnOrderPre
			// 
			this.btnOrderPre.BackColor = System.Drawing.Color.Pink;
			this.btnOrderPre.FlatAppearance.BorderSize = 0;
			this.btnOrderPre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnOrderPre.Font = new System.Drawing.Font("jf open 粉圓 2.1", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnOrderPre.ForeColor = System.Drawing.Color.Black;
			this.btnOrderPre.Location = new System.Drawing.Point(151, 3);
			this.btnOrderPre.Name = "btnOrderPre";
			this.btnOrderPre.Size = new System.Drawing.Size(142, 63);
			this.btnOrderPre.TabIndex = 28;
			this.btnOrderPre.Text = "訂單預覽";
			this.btnOrderPre.UseVisualStyleBackColor = false;
			// 
			// btnOrderOK
			// 
			this.btnOrderOK.BackColor = System.Drawing.Color.Red;
			this.btnOrderOK.FlatAppearance.BorderSize = 0;
			this.btnOrderOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnOrderOK.Font = new System.Drawing.Font("jf open 粉圓 2.1", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnOrderOK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
			this.btnOrderOK.Location = new System.Drawing.Point(151, 72);
			this.btnOrderOK.Name = "btnOrderOK";
			this.btnOrderOK.Size = new System.Drawing.Size(143, 63);
			this.btnOrderOK.TabIndex = 29;
			this.btnOrderOK.Text = "送出訂單";
			this.btnOrderOK.UseVisualStyleBackColor = false;
			// 
			// btnOrderMemberCheck
			// 
			this.btnOrderMemberCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(140)))), ((int)(((byte)(33)))));
			this.btnOrderMemberCheck.FlatAppearance.BorderSize = 0;
			this.btnOrderMemberCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnOrderMemberCheck.Font = new System.Drawing.Font("jf open 粉圓 2.1", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnOrderMemberCheck.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
			this.btnOrderMemberCheck.Location = new System.Drawing.Point(3, 72);
			this.btnOrderMemberCheck.Name = "btnOrderMemberCheck";
			this.btnOrderMemberCheck.Size = new System.Drawing.Size(142, 63);
			this.btnOrderMemberCheck.TabIndex = 30;
			this.btnOrderMemberCheck.Text = "點數確認";
			this.btnOrderMemberCheck.UseVisualStyleBackColor = false;
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
			// OrderForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
			this.ClientSize = new System.Drawing.Size(1033, 629);
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
			this.gbOrderChoose.ResumeLayout(false);
			this.gbOrderChoose.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
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
		private System.Windows.Forms.TextBox txtNonMember;
		private System.Windows.Forms.RadioButton rbtnNonMember;
		private System.Windows.Forms.RadioButton rbtnIsMember;
		private System.Windows.Forms.TextBox textOrderPhone;
		private System.Windows.Forms.Label labelOrderPhone;
		private System.Windows.Forms.Label labelOrderType;
		private BentoSystemDataSet2 bentoSystemDataSet2;
		private System.Windows.Forms.BindingSource orderDataLBSMSBindingSource;
		private BentoSystemDataSet2TableAdapters.OrderData_LBSMSTableAdapter orderData_LBSMSTableAdapter;
		private System.Windows.Forms.BindingSource orderDataLBSMSBindingSource1;
		private System.Windows.Forms.ComboBox cbOrderType;
		private System.Windows.Forms.Label labelOrderDateTime;
		private System.Windows.Forms.Label labelOrderTime;
		private System.Windows.Forms.GroupBox gbOrderChoose;
		private BentoSystemDataSet3 bentoSystemDataSet3;
		private System.Windows.Forms.BindingSource orderItem_LBSMSBindingSource;
		private BentoSystemDataSet3TableAdapters.OrderItem_LBSMSTableAdapter orderItem_LBSMSTableAdapter;
		private BentoSystemDataSet3TableAdapters.TableAdapterManager tableAdapterManager;
		private BentoSystemDataSet bentoSystemDataSet;
		private System.Windows.Forms.BindingSource product_LBSMSBindingSource;
		private System.Windows.Forms.Label labelOrderNumber;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.Button btnOrderAdd;
		private System.Windows.Forms.CheckBox chbSpicy;
		private System.Windows.Forms.GroupBox gbOrderAmount;
		private System.Windows.Forms.Label labelTotalTitle;
		private System.Windows.Forms.Label labelDiscountTitle;
		private System.Windows.Forms.Label labelSubTotalTitle;
		private System.Windows.Forms.Label labelSubtotal;
		private System.Windows.Forms.Label labelTotal;
		private System.Windows.Forms.Label labelDiscount;
		private System.Windows.Forms.Button btnOrderClear;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Button btnOrderPre;
		private System.Windows.Forms.Button btnOrderOK;
		private System.Windows.Forms.Button btnOrderMemberCheck;
	}
}