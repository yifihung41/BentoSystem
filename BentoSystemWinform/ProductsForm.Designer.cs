namespace BentoSystemWinform
{
	partial class ProductsForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductsForm));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.btnLogout = new System.Windows.Forms.Button();
			this.btnOrders = new System.Windows.Forms.Button();
			this.btnMembers = new System.Windows.Forms.Button();
			this.btnProducts = new System.Windows.Forms.Button();
			this.btnMainForm = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.gbProductSearch = new System.Windows.Forms.GroupBox();
			this.btnProductSearch = new System.Windows.Forms.Button();
			this.txtProductSearch = new System.Windows.Forms.TextBox();
			this.gbProductDetails = new System.Windows.Forms.GroupBox();
			this.txtProductId = new System.Windows.Forms.TextBox();
			this.labelProductNo = new System.Windows.Forms.Label();
			this.btnProductImageUpload = new System.Windows.Forms.Button();
			this.pbProductImage = new System.Windows.Forms.PictureBox();
			this.txtProductDesc = new System.Windows.Forms.TextBox();
			this.labelProductDesc = new System.Windows.Forms.Label();
			this.cbIsOutofstock = new System.Windows.Forms.CheckBox();
			this.labelSoldOut = new System.Windows.Forms.Label();
			this.txtStockQuantity = new System.Windows.Forms.TextBox();
			this.labelStockQuantity = new System.Windows.Forms.Label();
			this.txtProductPrice = new System.Windows.Forms.TextBox();
			this.LabelProductPrice = new System.Windows.Forms.Label();
			this.txtProductName = new System.Windows.Forms.TextBox();
			this.lableProductName = new System.Windows.Forms.Label();
			this.btnProductAdd = new System.Windows.Forms.Button();
			this.btnProductUpdate = new System.Windows.Forms.Button();
			this.btnProductDelete = new System.Windows.Forms.Button();
			this.btnProductSave = new System.Windows.Forms.Button();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.btnExit = new System.Windows.Forms.Button();
			this.gbProductList = new System.Windows.Forms.GroupBox();
			this.dgvProduct = new System.Windows.Forms.DataGridView();
			this.ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ProductPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.StockQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.IsOutofstock = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.ProductDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.product_LBSMSBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.bentoSystemDataSet = new BentoSystemWinform.BentoSystemDataSet();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.gbProductSearch.SuspendLayout();
			this.gbProductDetails.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbProductImage)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			this.gbProductList.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.product_LBSMSBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bentoSystemDataSet)).BeginInit();
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
			this.panel1.TabIndex = 10;
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
			this.btnOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
			this.btnOrders.FlatAppearance.BorderSize = 0;
			this.btnOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnOrders.Font = new System.Drawing.Font("jf open 粉圓 2.1", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnOrders.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
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
			this.btnProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(140)))), ((int)(((byte)(33)))));
			this.btnProducts.FlatAppearance.BorderSize = 0;
			this.btnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnProducts.Font = new System.Drawing.Font("jf open 粉圓 2.1", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnProducts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
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
			// gbProductSearch
			// 
			this.gbProductSearch.Controls.Add(this.btnProductSearch);
			this.gbProductSearch.Controls.Add(this.txtProductSearch);
			this.gbProductSearch.Font = new System.Drawing.Font("jf open 粉圓 2.1", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbProductSearch.Location = new System.Drawing.Point(682, 11);
			this.gbProductSearch.Name = "gbProductSearch";
			this.gbProductSearch.Size = new System.Drawing.Size(290, 61);
			this.gbProductSearch.TabIndex = 13;
			this.gbProductSearch.TabStop = false;
			this.gbProductSearch.Text = "餐點搜尋";
			// 
			// btnProductSearch
			// 
			this.btnProductSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnProductSearch.Image = global::BentoSystemWinform.Properties.Resources.IconSearch;
			this.btnProductSearch.Location = new System.Drawing.Point(227, 22);
			this.btnProductSearch.Name = "btnProductSearch";
			this.btnProductSearch.Size = new System.Drawing.Size(43, 26);
			this.btnProductSearch.TabIndex = 14;
			this.btnProductSearch.Text = " ";
			this.btnProductSearch.UseVisualStyleBackColor = true;
			this.btnProductSearch.Click += new System.EventHandler(this.btnProductSearch_Click);
			// 
			// txtProductSearch
			// 
			this.txtProductSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
			this.txtProductSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtProductSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(140)))), ((int)(((byte)(33)))));
			this.txtProductSearch.Location = new System.Drawing.Point(18, 22);
			this.txtProductSearch.Name = "txtProductSearch";
			this.txtProductSearch.Size = new System.Drawing.Size(203, 25);
			this.txtProductSearch.TabIndex = 13;
			// 
			// gbProductDetails
			// 
			this.gbProductDetails.Controls.Add(this.txtProductId);
			this.gbProductDetails.Controls.Add(this.labelProductNo);
			this.gbProductDetails.Controls.Add(this.btnProductImageUpload);
			this.gbProductDetails.Controls.Add(this.pbProductImage);
			this.gbProductDetails.Controls.Add(this.txtProductDesc);
			this.gbProductDetails.Controls.Add(this.labelProductDesc);
			this.gbProductDetails.Controls.Add(this.cbIsOutofstock);
			this.gbProductDetails.Controls.Add(this.labelSoldOut);
			this.gbProductDetails.Controls.Add(this.txtStockQuantity);
			this.gbProductDetails.Controls.Add(this.labelStockQuantity);
			this.gbProductDetails.Controls.Add(this.txtProductPrice);
			this.gbProductDetails.Controls.Add(this.LabelProductPrice);
			this.gbProductDetails.Controls.Add(this.txtProductName);
			this.gbProductDetails.Controls.Add(this.lableProductName);
			this.gbProductDetails.Font = new System.Drawing.Font("jf open 粉圓 2.1", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.gbProductDetails.Location = new System.Drawing.Point(262, 327);
			this.gbProductDetails.Name = "gbProductDetails";
			this.gbProductDetails.Size = new System.Drawing.Size(737, 247);
			this.gbProductDetails.TabIndex = 15;
			this.gbProductDetails.TabStop = false;
			this.gbProductDetails.Text = "餐點詳細資料";
			// 
			// txtProductId
			// 
			this.txtProductId.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtProductId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(140)))), ((int)(((byte)(33)))));
			this.txtProductId.Location = new System.Drawing.Point(120, 32);
			this.txtProductId.Name = "txtProductId";
			this.txtProductId.Size = new System.Drawing.Size(156, 19);
			this.txtProductId.TabIndex = 13;
			// 
			// labelProductNo
			// 
			this.labelProductNo.AutoSize = true;
			this.labelProductNo.Location = new System.Drawing.Point(26, 32);
			this.labelProductNo.Name = "labelProductNo";
			this.labelProductNo.Size = new System.Drawing.Size(88, 18);
			this.labelProductNo.TabIndex = 12;
			this.labelProductNo.Text = "餐點編號：";
			// 
			// btnProductImageUpload
			// 
			this.btnProductImageUpload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(140)))), ((int)(((byte)(33)))));
			this.btnProductImageUpload.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.btnProductImageUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnProductImageUpload.Font = new System.Drawing.Font("jf open 粉圓 2.1", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnProductImageUpload.ForeColor = System.Drawing.Color.White;
			this.btnProductImageUpload.Location = new System.Drawing.Point(635, 207);
			this.btnProductImageUpload.Name = "btnProductImageUpload";
			this.btnProductImageUpload.Size = new System.Drawing.Size(75, 28);
			this.btnProductImageUpload.TabIndex = 11;
			this.btnProductImageUpload.Text = "上傳";
			this.btnProductImageUpload.UseVisualStyleBackColor = false;
			this.btnProductImageUpload.Click += new System.EventHandler(this.btnProductImageUpload_Click);
			// 
			// pbProductImage
			// 
			this.pbProductImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pbProductImage.Location = new System.Drawing.Point(449, 34);
			this.pbProductImage.Name = "pbProductImage";
			this.pbProductImage.Size = new System.Drawing.Size(261, 148);
			this.pbProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbProductImage.TabIndex = 10;
			this.pbProductImage.TabStop = false;
			// 
			// txtProductDesc
			// 
			this.txtProductDesc.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtProductDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(140)))), ((int)(((byte)(33)))));
			this.txtProductDesc.Location = new System.Drawing.Point(120, 197);
			this.txtProductDesc.Name = "txtProductDesc";
			this.txtProductDesc.Size = new System.Drawing.Size(314, 19);
			this.txtProductDesc.TabIndex = 9;
			// 
			// labelProductDesc
			// 
			this.labelProductDesc.AutoSize = true;
			this.labelProductDesc.Location = new System.Drawing.Point(26, 197);
			this.labelProductDesc.Name = "labelProductDesc";
			this.labelProductDesc.Size = new System.Drawing.Size(88, 18);
			this.labelProductDesc.TabIndex = 8;
			this.labelProductDesc.Text = "餐點描述：";
			// 
			// cbIsOutofstock
			// 
			this.cbIsOutofstock.AutoSize = true;
			this.cbIsOutofstock.Location = new System.Drawing.Point(120, 166);
			this.cbIsOutofstock.Name = "cbIsOutofstock";
			this.cbIsOutofstock.Size = new System.Drawing.Size(15, 14);
			this.cbIsOutofstock.TabIndex = 7;
			this.cbIsOutofstock.UseVisualStyleBackColor = true;
			// 
			// labelSoldOut
			// 
			this.labelSoldOut.AutoSize = true;
			this.labelSoldOut.Location = new System.Drawing.Point(26, 164);
			this.labelSoldOut.Name = "labelSoldOut";
			this.labelSoldOut.Size = new System.Drawing.Size(88, 18);
			this.labelSoldOut.TabIndex = 6;
			this.labelSoldOut.Text = "今日售完：";
			// 
			// txtStockQuantity
			// 
			this.txtStockQuantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtStockQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(140)))), ((int)(((byte)(33)))));
			this.txtStockQuantity.Location = new System.Drawing.Point(120, 133);
			this.txtStockQuantity.Name = "txtStockQuantity";
			this.txtStockQuantity.Size = new System.Drawing.Size(156, 19);
			this.txtStockQuantity.TabIndex = 5;
			// 
			// labelStockQuantity
			// 
			this.labelStockQuantity.AutoSize = true;
			this.labelStockQuantity.Location = new System.Drawing.Point(26, 131);
			this.labelStockQuantity.Name = "labelStockQuantity";
			this.labelStockQuantity.Size = new System.Drawing.Size(88, 18);
			this.labelStockQuantity.TabIndex = 4;
			this.labelStockQuantity.Text = "目前剩餘：";
			// 
			// txtProductPrice
			// 
			this.txtProductPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtProductPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(140)))), ((int)(((byte)(33)))));
			this.txtProductPrice.Location = new System.Drawing.Point(120, 100);
			this.txtProductPrice.Name = "txtProductPrice";
			this.txtProductPrice.Size = new System.Drawing.Size(156, 19);
			this.txtProductPrice.TabIndex = 3;
			this.txtProductPrice.TextChanged += new System.EventHandler(this.txtProductPrice_TextChanged);
			// 
			// LabelProductPrice
			// 
			this.LabelProductPrice.AutoSize = true;
			this.LabelProductPrice.Location = new System.Drawing.Point(58, 98);
			this.LabelProductPrice.Name = "LabelProductPrice";
			this.LabelProductPrice.Size = new System.Drawing.Size(56, 18);
			this.LabelProductPrice.TabIndex = 2;
			this.LabelProductPrice.Text = "價格：";
			// 
			// txtProductName
			// 
			this.txtProductName.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtProductName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(140)))), ((int)(((byte)(33)))));
			this.txtProductName.Location = new System.Drawing.Point(120, 67);
			this.txtProductName.Name = "txtProductName";
			this.txtProductName.Size = new System.Drawing.Size(156, 19);
			this.txtProductName.TabIndex = 1;
			// 
			// lableProductName
			// 
			this.lableProductName.AutoSize = true;
			this.lableProductName.Location = new System.Drawing.Point(26, 65);
			this.lableProductName.Name = "lableProductName";
			this.lableProductName.Size = new System.Drawing.Size(88, 18);
			this.lableProductName.TabIndex = 0;
			this.lableProductName.Text = "餐點名稱：";
			// 
			// btnProductAdd
			// 
			this.btnProductAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(140)))), ((int)(((byte)(33)))));
			this.btnProductAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnProductAdd.Font = new System.Drawing.Font("jf open 粉圓 2.1", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnProductAdd.ForeColor = System.Drawing.Color.White;
			this.btnProductAdd.Location = new System.Drawing.Point(666, 298);
			this.btnProductAdd.Name = "btnProductAdd";
			this.btnProductAdd.Size = new System.Drawing.Size(75, 28);
			this.btnProductAdd.TabIndex = 16;
			this.btnProductAdd.Text = "新增";
			this.btnProductAdd.UseVisualStyleBackColor = false;
			this.btnProductAdd.Click += new System.EventHandler(this.btnProductAdd_Click);
			// 
			// btnProductUpdate
			// 
			this.btnProductUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(140)))), ((int)(((byte)(33)))));
			this.btnProductUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnProductUpdate.Font = new System.Drawing.Font("jf open 粉圓 2.1", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnProductUpdate.ForeColor = System.Drawing.Color.White;
			this.btnProductUpdate.Location = new System.Drawing.Point(752, 298);
			this.btnProductUpdate.Name = "btnProductUpdate";
			this.btnProductUpdate.Size = new System.Drawing.Size(75, 28);
			this.btnProductUpdate.TabIndex = 17;
			this.btnProductUpdate.Text = "修改";
			this.btnProductUpdate.UseVisualStyleBackColor = false;
			this.btnProductUpdate.Click += new System.EventHandler(this.btnProductUpdate_Click);
			// 
			// btnProductDelete
			// 
			this.btnProductDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(140)))), ((int)(((byte)(33)))));
			this.btnProductDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnProductDelete.Font = new System.Drawing.Font("jf open 粉圓 2.1", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnProductDelete.ForeColor = System.Drawing.Color.White;
			this.btnProductDelete.Location = new System.Drawing.Point(838, 298);
			this.btnProductDelete.Name = "btnProductDelete";
			this.btnProductDelete.Size = new System.Drawing.Size(75, 28);
			this.btnProductDelete.TabIndex = 18;
			this.btnProductDelete.Text = "刪除";
			this.btnProductDelete.UseVisualStyleBackColor = false;
			this.btnProductDelete.Click += new System.EventHandler(this.btnProductDelete_Click);
			// 
			// btnProductSave
			// 
			this.btnProductSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(140)))), ((int)(((byte)(33)))));
			this.btnProductSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnProductSave.Font = new System.Drawing.Font("jf open 粉圓 2.1", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnProductSave.ForeColor = System.Drawing.Color.White;
			this.btnProductSave.Location = new System.Drawing.Point(924, 298);
			this.btnProductSave.Name = "btnProductSave";
			this.btnProductSave.Size = new System.Drawing.Size(75, 28);
			this.btnProductSave.TabIndex = 19;
			this.btnProductSave.Text = "儲存";
			this.btnProductSave.UseVisualStyleBackColor = false;
			this.btnProductSave.Click += new System.EventHandler(this.btnProductSave_Click);
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(262, 12);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(209, 73);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox3.TabIndex = 21;
			this.pictureBox3.TabStop = false;
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
			this.btnExit.TabIndex = 11;
			this.btnExit.UseVisualStyleBackColor = false;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// gbProductList
			// 
			this.gbProductList.Controls.Add(this.dgvProduct);
			this.gbProductList.Location = new System.Drawing.Point(262, 92);
			this.gbProductList.Name = "gbProductList";
			this.gbProductList.Size = new System.Drawing.Size(737, 200);
			this.gbProductList.TabIndex = 22;
			this.gbProductList.TabStop = false;
			this.gbProductList.Text = "餐點清單";
			// 
			// dgvProduct
			// 
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
			this.dgvProduct.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("jf open 粉圓 2.1", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle6.NullValue = "無";
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
			this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductId,
            this.ProductName,
            this.ProductPrice,
            this.StockQuantity,
            this.IsOutofstock,
            this.ProductDesc});
			this.dgvProduct.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvProduct.Location = new System.Drawing.Point(3, 21);
			this.dgvProduct.Name = "dgvProduct";
			this.dgvProduct.RowTemplate.Height = 24;
			this.dgvProduct.Size = new System.Drawing.Size(731, 176);
			this.dgvProduct.TabIndex = 0;
			this.dgvProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct_CellClick);
			// 
			// ProductId
			// 
			this.ProductId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.ProductId.DataPropertyName = "ProductId";
			this.ProductId.HeaderText = "編號";
			this.ProductId.Name = "ProductId";
			this.ProductId.ReadOnly = true;
			this.ProductId.ToolTipText = "編號";
			this.ProductId.Width = 63;
			// 
			// ProductName
			// 
			this.ProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.ProductName.DataPropertyName = "ProductName";
			this.ProductName.HeaderText = "名稱";
			this.ProductName.Name = "ProductName";
			this.ProductName.ReadOnly = true;
			this.ProductName.ToolTipText = "名稱";
			this.ProductName.Width = 63;
			// 
			// ProductPrice
			// 
			this.ProductPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.ProductPrice.DataPropertyName = "ProductPrice";
			this.ProductPrice.HeaderText = "價格";
			this.ProductPrice.Name = "ProductPrice";
			this.ProductPrice.ReadOnly = true;
			this.ProductPrice.ToolTipText = "價格";
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
			// IsOutofstock
			// 
			this.IsOutofstock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.IsOutofstock.DataPropertyName = "IsOutofstock";
			this.IsOutofstock.HeaderText = "售罄";
			this.IsOutofstock.Name = "IsOutofstock";
			this.IsOutofstock.ReadOnly = true;
			this.IsOutofstock.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.IsOutofstock.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.IsOutofstock.ToolTipText = "售罄";
			this.IsOutofstock.Width = 63;
			// 
			// ProductDesc
			// 
			this.ProductDesc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.ProductDesc.DataPropertyName = "ProductDesc";
			this.ProductDesc.HeaderText = "餐點描述";
			this.ProductDesc.Name = "ProductDesc";
			this.ProductDesc.ReadOnly = true;
			this.ProductDesc.ToolTipText = "餐點描述";
			this.ProductDesc.Width = 93;
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
			// ProductsForm
			// 
			this.AcceptButton = this.btnProductSearch;
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
			this.ClientSize = new System.Drawing.Size(1033, 629);
			this.Controls.Add(this.gbProductList);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.btnProductSave);
			this.Controls.Add(this.btnProductDelete);
			this.Controls.Add(this.btnProductUpdate);
			this.Controls.Add(this.btnProductAdd);
			this.Controls.Add(this.gbProductDetails);
			this.Controls.Add(this.gbProductSearch);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("jf open 粉圓 2.1", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "ProductsForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "阿萱便當後臺系統：產品管理";
			this.Load += new System.EventHandler(this.ProductsForm_Load);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ProductForm_MouseDown);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ProductForm_MouseMove);
			this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ProductForm_MouseUp);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.gbProductSearch.ResumeLayout(false);
			this.gbProductSearch.PerformLayout();
			this.gbProductDetails.ResumeLayout(false);
			this.gbProductDetails.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbProductImage)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			this.gbProductList.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.product_LBSMSBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bentoSystemDataSet)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnOrders;
		private System.Windows.Forms.Button btnMembers;
		private System.Windows.Forms.Button btnProducts;
		private System.Windows.Forms.Button btnMainForm;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button btnLogout;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.GroupBox gbProductSearch;
		private System.Windows.Forms.Button btnProductSearch;
		private System.Windows.Forms.TextBox txtProductSearch;
		private BentoSystemDataSet bentoSystemDataSet;
		private System.Windows.Forms.BindingSource product_LBSMSBindingSource;
		private System.Windows.Forms.GroupBox gbProductDetails;
		private System.Windows.Forms.TextBox txtProductName;
		private System.Windows.Forms.Label lableProductName;
		private System.Windows.Forms.TextBox txtProductPrice;
		private System.Windows.Forms.Label LabelProductPrice;
		private System.Windows.Forms.TextBox txtStockQuantity;
		private System.Windows.Forms.Label labelStockQuantity;
		private System.Windows.Forms.TextBox txtProductDesc;
		private System.Windows.Forms.Label labelProductDesc;
		private System.Windows.Forms.CheckBox cbIsOutofstock;
		private System.Windows.Forms.Label labelSoldOut;
		private System.Windows.Forms.PictureBox pbProductImage;
		private System.Windows.Forms.Button btnProductImageUpload;
		private System.Windows.Forms.Button btnProductAdd;
		private System.Windows.Forms.Button btnProductUpdate;
		private System.Windows.Forms.Button btnProductDelete;
		private System.Windows.Forms.Button btnProductSave;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.TextBox txtProductId;
		private System.Windows.Forms.Label labelProductNo;
		private System.Windows.Forms.GroupBox gbProductList;
		private System.Windows.Forms.DataGridView dgvProduct;
		private System.Windows.Forms.DataGridViewTextBoxColumn ProductId;
		private System.Windows.Forms.DataGridViewTextBoxColumn	ProductName;
		private System.Windows.Forms.DataGridViewTextBoxColumn ProductPrice;
		private System.Windows.Forms.DataGridViewTextBoxColumn StockQuantity;
		private System.Windows.Forms.DataGridViewCheckBoxColumn IsOutofstock;
		private System.Windows.Forms.DataGridViewTextBoxColumn ProductDesc;
		private System.Windows.Forms.DataGridViewTextBoxColumn ProductNameColumn;
	}
}