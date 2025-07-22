using System;

namespace BentoSystemWinform
{
	partial class MemberForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberForm));
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.btnLogout = new System.Windows.Forms.Button();
			this.btnOrders = new System.Windows.Forms.Button();
			this.btnMembers = new System.Windows.Forms.Button();
			this.btnProducts = new System.Windows.Forms.Button();
			this.btnMainForm = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.btnExit = new System.Windows.Forms.Button();
			this.gbMemberSearch = new System.Windows.Forms.GroupBox();
			this.btnMemberSearch = new System.Windows.Forms.Button();
			this.txtMemberSearch = new System.Windows.Forms.TextBox();
			this.bentoSystemDataSet1 = new BentoSystemWinform.BentoSystemDataSet1();
			this.member_LBSMSBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.member_LBSMSTableAdapter = new BentoSystemWinform.BentoSystemDataSet1TableAdapters.Member_LBSMSTableAdapter();
			this.tableAdapterManager = new BentoSystemWinform.BentoSystemDataSet1TableAdapters.TableAdapterManager();
			this.btnMemberSave = new System.Windows.Forms.Button();
			this.btnMemberDelete = new System.Windows.Forms.Button();
			this.btnMemberUpdate = new System.Windows.Forms.Button();
			this.btnMemberAdd = new System.Windows.Forms.Button();
			this.gbMemberDetails = new System.Windows.Forms.GroupBox();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.txtPoints = new System.Windows.Forms.TextBox();
			this.txtMemberNumber = new System.Windows.Forms.TextBox();
			this.labelMemberNo = new System.Windows.Forms.Label();
			this.txtMemberAddress = new System.Windows.Forms.TextBox();
			this.labelMemberAddress = new System.Windows.Forms.Label();
			this.labelMemberPoints = new System.Windows.Forms.Label();
			this.txtBirthday = new System.Windows.Forms.TextBox();
			this.labelMemberBirthday = new System.Windows.Forms.Label();
			this.txtMemberPhone = new System.Windows.Forms.TextBox();
			this.LabelMemberPhone = new System.Windows.Forms.Label();
			this.txtMemberName = new System.Windows.Forms.TextBox();
			this.lableMemberName = new System.Windows.Forms.Label();
			this.gbMemberList = new System.Windows.Forms.GroupBox();
			this.dgvMember = new System.Windows.Forms.DataGridView();
			this.MemberId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MemberName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MemberPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Birthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Points = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MemberAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			this.gbMemberSearch.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.bentoSystemDataSet1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.member_LBSMSBindingSource)).BeginInit();
			this.gbMemberDetails.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			this.gbMemberList.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvMember)).BeginInit();
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
			this.btnOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
			this.btnOrders.FlatAppearance.BorderSize = 0;
			this.btnOrders.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(140)))), ((int)(((byte)(33)))));
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
			this.btnMembers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(140)))), ((int)(((byte)(33)))));
			this.btnMembers.FlatAppearance.BorderSize = 0;
			this.btnMembers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMembers.Font = new System.Drawing.Font("jf open 粉圓 2.1", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMembers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
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
			// gbMemberSearch
			// 
			this.gbMemberSearch.Controls.Add(this.btnMemberSearch);
			this.gbMemberSearch.Controls.Add(this.txtMemberSearch);
			this.gbMemberSearch.Font = new System.Drawing.Font("jf open 粉圓 2.1", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbMemberSearch.Location = new System.Drawing.Point(682, 11);
			this.gbMemberSearch.Name = "gbMemberSearch";
			this.gbMemberSearch.Size = new System.Drawing.Size(290, 61);
			this.gbMemberSearch.TabIndex = 24;
			this.gbMemberSearch.TabStop = false;
			this.gbMemberSearch.Text = "會員搜尋";
			// 
			// btnMemberSearch
			// 
			this.btnMemberSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnMemberSearch.Image = global::BentoSystemWinform.Properties.Resources.IconSearch;
			this.btnMemberSearch.Location = new System.Drawing.Point(227, 22);
			this.btnMemberSearch.Name = "btnMemberSearch";
			this.btnMemberSearch.Size = new System.Drawing.Size(43, 26);
			this.btnMemberSearch.TabIndex = 14;
			this.btnMemberSearch.Text = " ";
			this.btnMemberSearch.UseVisualStyleBackColor = true;
			this.btnMemberSearch.Click += new System.EventHandler(this.btnMemberSearch_Click);
			// 
			// txtMemberSearch
			// 
			this.txtMemberSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
			this.txtMemberSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtMemberSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(140)))), ((int)(((byte)(33)))));
			this.txtMemberSearch.Location = new System.Drawing.Point(18, 22);
			this.txtMemberSearch.Name = "txtMemberSearch";
			this.txtMemberSearch.Size = new System.Drawing.Size(203, 25);
			this.txtMemberSearch.TabIndex = 13;
			this.txtMemberSearch.TextChanged += new System.EventHandler(this.txtMemberSearch_TextChanged);
			// 
			// bentoSystemDataSet1
			// 
			this.bentoSystemDataSet1.DataSetName = "BentoSystemDataSet1";
			this.bentoSystemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// member_LBSMSBindingSource
			// 
			this.member_LBSMSBindingSource.DataMember = "Member_LBSMS";
			this.member_LBSMSBindingSource.DataSource = this.bentoSystemDataSet1;
			// 
			// member_LBSMSTableAdapter
			// 
			this.member_LBSMSTableAdapter.ClearBeforeFill = true;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.Member_LBSMSTableAdapter = this.member_LBSMSTableAdapter;
			this.tableAdapterManager.UpdateOrder = BentoSystemWinform.BentoSystemDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			// 
			// btnMemberSave
			// 
			this.btnMemberSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(140)))), ((int)(((byte)(33)))));
			this.btnMemberSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMemberSave.Font = new System.Drawing.Font("jf open 粉圓 2.1", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnMemberSave.ForeColor = System.Drawing.Color.White;
			this.btnMemberSave.Location = new System.Drawing.Point(924, 304);
			this.btnMemberSave.Name = "btnMemberSave";
			this.btnMemberSave.Size = new System.Drawing.Size(75, 28);
			this.btnMemberSave.TabIndex = 29;
			this.btnMemberSave.Text = "儲存";
			this.btnMemberSave.UseVisualStyleBackColor = false;
			this.btnMemberSave.Click += new System.EventHandler(this.btnMemberSave_Click);
			// 
			// btnMemberDelete
			// 
			this.btnMemberDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(140)))), ((int)(((byte)(33)))));
			this.btnMemberDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMemberDelete.Font = new System.Drawing.Font("jf open 粉圓 2.1", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnMemberDelete.ForeColor = System.Drawing.Color.White;
			this.btnMemberDelete.Location = new System.Drawing.Point(838, 304);
			this.btnMemberDelete.Name = "btnMemberDelete";
			this.btnMemberDelete.Size = new System.Drawing.Size(75, 28);
			this.btnMemberDelete.TabIndex = 28;
			this.btnMemberDelete.Text = "刪除";
			this.btnMemberDelete.UseVisualStyleBackColor = false;
			this.btnMemberDelete.Click += new System.EventHandler(this.btnMemberDelete_Click);
			// 
			// btnMemberUpdate
			// 
			this.btnMemberUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(140)))), ((int)(((byte)(33)))));
			this.btnMemberUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMemberUpdate.Font = new System.Drawing.Font("jf open 粉圓 2.1", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnMemberUpdate.ForeColor = System.Drawing.Color.White;
			this.btnMemberUpdate.Location = new System.Drawing.Point(752, 304);
			this.btnMemberUpdate.Name = "btnMemberUpdate";
			this.btnMemberUpdate.Size = new System.Drawing.Size(75, 28);
			this.btnMemberUpdate.TabIndex = 27;
			this.btnMemberUpdate.Text = "修改";
			this.btnMemberUpdate.UseVisualStyleBackColor = false;
			this.btnMemberUpdate.Click += new System.EventHandler(this.btnMemberUpdate_Click);
			// 
			// btnMemberAdd
			// 
			this.btnMemberAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(140)))), ((int)(((byte)(33)))));
			this.btnMemberAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMemberAdd.Font = new System.Drawing.Font("jf open 粉圓 2.1", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnMemberAdd.ForeColor = System.Drawing.Color.White;
			this.btnMemberAdd.Location = new System.Drawing.Point(666, 304);
			this.btnMemberAdd.Name = "btnMemberAdd";
			this.btnMemberAdd.Size = new System.Drawing.Size(75, 28);
			this.btnMemberAdd.TabIndex = 26;
			this.btnMemberAdd.Text = "新增";
			this.btnMemberAdd.UseVisualStyleBackColor = false;
			this.btnMemberAdd.Click += new System.EventHandler(this.btnMemberAdd_Click);
			// 
			// gbMemberDetails
			// 
			this.gbMemberDetails.Controls.Add(this.pictureBox4);
			this.gbMemberDetails.Controls.Add(this.txtPoints);
			this.gbMemberDetails.Controls.Add(this.txtMemberNumber);
			this.gbMemberDetails.Controls.Add(this.labelMemberNo);
			this.gbMemberDetails.Controls.Add(this.txtMemberAddress);
			this.gbMemberDetails.Controls.Add(this.labelMemberAddress);
			this.gbMemberDetails.Controls.Add(this.labelMemberPoints);
			this.gbMemberDetails.Controls.Add(this.txtBirthday);
			this.gbMemberDetails.Controls.Add(this.labelMemberBirthday);
			this.gbMemberDetails.Controls.Add(this.txtMemberPhone);
			this.gbMemberDetails.Controls.Add(this.LabelMemberPhone);
			this.gbMemberDetails.Controls.Add(this.txtMemberName);
			this.gbMemberDetails.Controls.Add(this.lableMemberName);
			this.gbMemberDetails.Font = new System.Drawing.Font("jf open 粉圓 2.1", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.gbMemberDetails.Location = new System.Drawing.Point(262, 339);
			this.gbMemberDetails.Name = "gbMemberDetails";
			this.gbMemberDetails.Size = new System.Drawing.Size(737, 247);
			this.gbMemberDetails.TabIndex = 31;
			this.gbMemberDetails.TabStop = false;
			this.gbMemberDetails.Text = "會員詳細資料";
			// 
			// pictureBox4
			// 
			this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
			this.pictureBox4.Location = new System.Drawing.Point(495, 14);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(236, 227);
			this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox4.TabIndex = 27;
			this.pictureBox4.TabStop = false;
			// 
			// txtPoints
			// 
			this.txtPoints.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtPoints.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(140)))), ((int)(((byte)(33)))));
			this.txtPoints.Location = new System.Drawing.Point(118, 164);
			this.txtPoints.Name = "txtPoints";
			this.txtPoints.Size = new System.Drawing.Size(156, 19);
			this.txtPoints.TabIndex = 26;
			// 
			// txtMemberNumber
			// 
			this.txtMemberNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtMemberNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(140)))), ((int)(((byte)(33)))));
			this.txtMemberNumber.Location = new System.Drawing.Point(118, 32);
			this.txtMemberNumber.Name = "txtMemberNumber";
			this.txtMemberNumber.Size = new System.Drawing.Size(156, 19);
			this.txtMemberNumber.TabIndex = 25;
			// 
			// labelMemberNo
			// 
			this.labelMemberNo.AutoSize = true;
			this.labelMemberNo.Location = new System.Drawing.Point(26, 32);
			this.labelMemberNo.Name = "labelMemberNo";
			this.labelMemberNo.Size = new System.Drawing.Size(88, 18);
			this.labelMemberNo.TabIndex = 24;
			this.labelMemberNo.Text = "會員編號：";
			// 
			// txtMemberAddress
			// 
			this.txtMemberAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtMemberAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(140)))), ((int)(((byte)(33)))));
			this.txtMemberAddress.Location = new System.Drawing.Point(118, 197);
			this.txtMemberAddress.Name = "txtMemberAddress";
			this.txtMemberAddress.Size = new System.Drawing.Size(293, 19);
			this.txtMemberAddress.TabIndex = 23;
			// 
			// labelMemberAddress
			// 
			this.labelMemberAddress.AutoSize = true;
			this.labelMemberAddress.Location = new System.Drawing.Point(58, 197);
			this.labelMemberAddress.Name = "labelMemberAddress";
			this.labelMemberAddress.Size = new System.Drawing.Size(56, 18);
			this.labelMemberAddress.TabIndex = 22;
			this.labelMemberAddress.Text = "地址：";
			// 
			// labelMemberPoints
			// 
			this.labelMemberPoints.AutoSize = true;
			this.labelMemberPoints.Location = new System.Drawing.Point(26, 164);
			this.labelMemberPoints.Name = "labelMemberPoints";
			this.labelMemberPoints.Size = new System.Drawing.Size(88, 18);
			this.labelMemberPoints.TabIndex = 20;
			this.labelMemberPoints.Text = "累積點數：";
			// 
			// txtBirthday
			// 
			this.txtBirthday.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtBirthday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(140)))), ((int)(((byte)(33)))));
			this.txtBirthday.Location = new System.Drawing.Point(118, 131);
			this.txtBirthday.Name = "txtBirthday";
			this.txtBirthday.Size = new System.Drawing.Size(156, 19);
			this.txtBirthday.TabIndex = 19;
			// 
			// labelMemberBirthday
			// 
			this.labelMemberBirthday.AutoSize = true;
			this.labelMemberBirthday.Location = new System.Drawing.Point(58, 131);
			this.labelMemberBirthday.Name = "labelMemberBirthday";
			this.labelMemberBirthday.Size = new System.Drawing.Size(56, 18);
			this.labelMemberBirthday.TabIndex = 18;
			this.labelMemberBirthday.Text = "生日：";
			// 
			// txtMemberPhone
			// 
			this.txtMemberPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtMemberPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(140)))), ((int)(((byte)(33)))));
			this.txtMemberPhone.Location = new System.Drawing.Point(118, 98);
			this.txtMemberPhone.Name = "txtMemberPhone";
			this.txtMemberPhone.Size = new System.Drawing.Size(156, 19);
			this.txtMemberPhone.TabIndex = 17;
			// 
			// LabelMemberPhone
			// 
			this.LabelMemberPhone.AutoSize = true;
			this.LabelMemberPhone.Location = new System.Drawing.Point(58, 98);
			this.LabelMemberPhone.Name = "LabelMemberPhone";
			this.LabelMemberPhone.Size = new System.Drawing.Size(56, 18);
			this.LabelMemberPhone.TabIndex = 16;
			this.LabelMemberPhone.Text = "電話：";
			// 
			// txtMemberName
			// 
			this.txtMemberName.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtMemberName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(140)))), ((int)(((byte)(33)))));
			this.txtMemberName.Location = new System.Drawing.Point(118, 65);
			this.txtMemberName.Name = "txtMemberName";
			this.txtMemberName.Size = new System.Drawing.Size(156, 19);
			this.txtMemberName.TabIndex = 15;
			// 
			// lableMemberName
			// 
			this.lableMemberName.AutoSize = true;
			this.lableMemberName.Location = new System.Drawing.Point(58, 65);
			this.lableMemberName.Name = "lableMemberName";
			this.lableMemberName.Size = new System.Drawing.Size(56, 18);
			this.lableMemberName.TabIndex = 14;
			this.lableMemberName.Text = "姓名：";
			this.lableMemberName.Click += new System.EventHandler(this.lableMemberName_Click);
			// 
			// gbMemberList
			// 
			this.gbMemberList.Controls.Add(this.dgvMember);
			this.gbMemberList.Location = new System.Drawing.Point(262, 91);
			this.gbMemberList.Name = "gbMemberList";
			this.gbMemberList.Size = new System.Drawing.Size(737, 200);
			this.gbMemberList.TabIndex = 32;
			this.gbMemberList.TabStop = false;
			this.gbMemberList.Text = "會員清單";
			// 
			// dgvMember
			// 
			this.dgvMember.BackgroundColor = System.Drawing.SystemColors.Control;
			this.dgvMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvMember.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MemberId,
            this.MemberName,
            this.MemberPhone,
            this.Birthday,
            this.Points,
            this.MemberAddress});
			this.dgvMember.Location = new System.Drawing.Point(17, 21);
			this.dgvMember.Name = "dgvMember";
			this.dgvMember.RowTemplate.Height = 24;
			this.dgvMember.Size = new System.Drawing.Size(709, 176);
			this.dgvMember.TabIndex = 0;
			this.dgvMember.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMember_CellClick);
			// 
			// MemberId
			// 
			this.MemberId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.MemberId.DataPropertyName = "MemberId";
			this.MemberId.HeaderText = "編號";
			this.MemberId.Name = "MemberId";
			this.MemberId.ReadOnly = true;
			this.MemberId.ToolTipText = "編號";
			this.MemberId.Width = 63;
			// 
			// MemberName
			// 
			this.MemberName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.MemberName.DataPropertyName = "MemberName";
			this.MemberName.HeaderText = "姓名";
			this.MemberName.Name = "MemberName";
			this.MemberName.ReadOnly = true;
			this.MemberName.ToolTipText = "姓名";
			this.MemberName.Width = 63;
			// 
			// MemberPhone
			// 
			this.MemberPhone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.MemberPhone.DataPropertyName = "MemberPhone";
			this.MemberPhone.HeaderText = "電話";
			this.MemberPhone.Name = "MemberPhone";
			this.MemberPhone.ReadOnly = true;
			this.MemberPhone.ToolTipText = "電話";
			this.MemberPhone.Width = 63;
			// 
			// Birthday
			// 
			this.Birthday.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.Birthday.DataPropertyName = "Birthday";
			this.Birthday.HeaderText = "生日";
			this.Birthday.Name = "Birthday";
			this.Birthday.ReadOnly = true;
			this.Birthday.ToolTipText = "生日";
			this.Birthday.Width = 63;
			// 
			// Points
			// 
			this.Points.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.Points.DataPropertyName = "Points";
			this.Points.HeaderText = "點數";
			this.Points.Name = "Points";
			this.Points.ReadOnly = true;
			this.Points.ToolTipText = "點數";
			this.Points.Width = 63;
			// 
			// MemberAddress
			// 
			this.MemberAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.MemberAddress.DataPropertyName = "MemberAddress";
			this.MemberAddress.HeaderText = "地址";
			this.MemberAddress.Name = "MemberAddress";
			this.MemberAddress.ReadOnly = true;
			this.MemberAddress.ToolTipText = "地址";
			this.MemberAddress.Width = 63;
			// 
			// MemberForm
			// 
			this.AcceptButton = this.btnMemberSearch;
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
			this.ClientSize = new System.Drawing.Size(1033, 629);
			this.Controls.Add(this.gbMemberList);
			this.Controls.Add(this.gbMemberDetails);
			this.Controls.Add(this.btnMemberSave);
			this.Controls.Add(this.btnMemberDelete);
			this.Controls.Add(this.btnMemberUpdate);
			this.Controls.Add(this.btnMemberAdd);
			this.Controls.Add(this.gbMemberSearch);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("jf open 粉圓 2.1", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "MemberForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "阿萱便當後臺系統：會員管理";
			this.Load += new System.EventHandler(this.MemberForm_Load);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MemberForm_MouseDown);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MemberForm_MouseMove);
			this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MemberForm_MouseUp);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			this.gbMemberSearch.ResumeLayout(false);
			this.gbMemberSearch.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.bentoSystemDataSet1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.member_LBSMSBindingSource)).EndInit();
			this.gbMemberDetails.ResumeLayout(false);
			this.gbMemberDetails.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			this.gbMemberList.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvMember)).EndInit();
			this.ResumeLayout(false);

		}

		private void lableMemberName_Click(object sender, EventArgs e)
		{
			throw new NotImplementedException();
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
		private System.Windows.Forms.GroupBox gbMemberSearch;
		private System.Windows.Forms.Button btnMemberSearch;
		private System.Windows.Forms.TextBox txtMemberSearch;
		private BentoSystemDataSet1 bentoSystemDataSet1;
		private System.Windows.Forms.BindingSource member_LBSMSBindingSource;
		private BentoSystemDataSet1TableAdapters.Member_LBSMSTableAdapter member_LBSMSTableAdapter;
		private BentoSystemDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.Button btnMemberSave;
		private System.Windows.Forms.Button btnMemberDelete;
		private System.Windows.Forms.Button btnMemberUpdate;
		private System.Windows.Forms.Button btnMemberAdd;
		private System.Windows.Forms.GroupBox gbMemberDetails;
		private System.Windows.Forms.TextBox txtMemberNumber;
		private System.Windows.Forms.Label labelMemberNo;
		private System.Windows.Forms.TextBox txtMemberAddress;
		private System.Windows.Forms.Label labelMemberAddress;
		private System.Windows.Forms.Label labelMemberPoints;
		private System.Windows.Forms.TextBox txtBirthday;
		private System.Windows.Forms.Label labelMemberBirthday;
		private System.Windows.Forms.TextBox txtMemberPhone;
		private System.Windows.Forms.Label LabelMemberPhone;
		private System.Windows.Forms.TextBox txtMemberName;
		private System.Windows.Forms.Label lableMemberName;
		private System.Windows.Forms.TextBox txtPoints;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.GroupBox gbMemberList;
		private System.Windows.Forms.DataGridView dgvMember;
		private System.Windows.Forms.DataGridViewTextBoxColumn MemberId;
		private System.Windows.Forms.DataGridViewTextBoxColumn MemberName;
		private System.Windows.Forms.DataGridViewTextBoxColumn MemberPhone;
		private System.Windows.Forms.DataGridViewTextBoxColumn Birthday;
		private System.Windows.Forms.DataGridViewTextBoxColumn Points;
		private System.Windows.Forms.DataGridViewTextBoxColumn MemberAddress;
	}
}