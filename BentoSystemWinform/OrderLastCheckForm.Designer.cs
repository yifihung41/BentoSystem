namespace BentoSystemWinform
{
	partial class OrderLastCheckForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderLastCheckForm));
			this.gbOrderLastCheck = new System.Windows.Forms.GroupBox();
			this.lblEarnedPoints = new System.Windows.Forms.Label();
			this.lblOrderTime = new System.Windows.Forms.Label();
			this.lblOrderType = new System.Windows.Forms.Label();
			this.lblCustomerPhone = new System.Windows.Forms.Label();
			this.lblCustomerName = new System.Windows.Forms.Label();
			this.labelMode = new System.Windows.Forms.Label();
			this.btnSubmit = new System.Windows.Forms.Button();
			this.btnBack = new System.Windows.Forms.Button();
			this.labelTotalAmount = new System.Windows.Forms.Label();
			this.dgvOrderDetails = new System.Windows.Forms.DataGridView();
			this.lblUpdatedPoints = new System.Windows.Forms.Label();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.gbOrderLastCheck.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetails)).BeginInit();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// gbOrderLastCheck
			// 
			this.gbOrderLastCheck.Controls.Add(this.tableLayoutPanel2);
			this.gbOrderLastCheck.Controls.Add(this.labelMode);
			this.gbOrderLastCheck.Controls.Add(this.btnSubmit);
			this.gbOrderLastCheck.Controls.Add(this.btnBack);
			this.gbOrderLastCheck.Controls.Add(this.dgvOrderDetails);
			this.gbOrderLastCheck.Controls.Add(this.tableLayoutPanel1);
			this.gbOrderLastCheck.Font = new System.Drawing.Font("jf open 粉圓 2.1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.gbOrderLastCheck.Location = new System.Drawing.Point(17, 12);
			this.gbOrderLastCheck.Name = "gbOrderLastCheck";
			this.gbOrderLastCheck.Size = new System.Drawing.Size(431, 483);
			this.gbOrderLastCheck.TabIndex = 0;
			this.gbOrderLastCheck.TabStop = false;
			// 
			// lblEarnedPoints
			// 
			this.lblEarnedPoints.AutoSize = true;
			this.lblEarnedPoints.BackColor = System.Drawing.Color.Transparent;
			this.lblEarnedPoints.Location = new System.Drawing.Point(3, 33);
			this.lblEarnedPoints.Name = "lblEarnedPoints";
			this.lblEarnedPoints.Size = new System.Drawing.Size(65, 22);
			this.lblEarnedPoints.TabIndex = 12;
			this.lblEarnedPoints.Text = "label5";
			// 
			// lblOrderTime
			// 
			this.lblOrderTime.AutoSize = true;
			this.lblOrderTime.BackColor = System.Drawing.Color.Transparent;
			this.lblOrderTime.Location = new System.Drawing.Point(3, 90);
			this.lblOrderTime.Name = "lblOrderTime";
			this.lblOrderTime.Size = new System.Drawing.Size(65, 22);
			this.lblOrderTime.TabIndex = 11;
			this.lblOrderTime.Text = "label4";
			// 
			// lblOrderType
			// 
			this.lblOrderType.AutoSize = true;
			this.lblOrderType.BackColor = System.Drawing.Color.Transparent;
			this.lblOrderType.Location = new System.Drawing.Point(3, 60);
			this.lblOrderType.Name = "lblOrderType";
			this.lblOrderType.Size = new System.Drawing.Size(65, 22);
			this.lblOrderType.TabIndex = 10;
			this.lblOrderType.Text = "label3";
			// 
			// lblCustomerPhone
			// 
			this.lblCustomerPhone.AutoSize = true;
			this.lblCustomerPhone.BackColor = System.Drawing.Color.Transparent;
			this.lblCustomerPhone.Location = new System.Drawing.Point(3, 30);
			this.lblCustomerPhone.Name = "lblCustomerPhone";
			this.lblCustomerPhone.Size = new System.Drawing.Size(65, 22);
			this.lblCustomerPhone.TabIndex = 9;
			this.lblCustomerPhone.Text = "label2";
			// 
			// lblCustomerName
			// 
			this.lblCustomerName.AutoSize = true;
			this.lblCustomerName.BackColor = System.Drawing.Color.Transparent;
			this.lblCustomerName.Location = new System.Drawing.Point(3, 0);
			this.lblCustomerName.Name = "lblCustomerName";
			this.lblCustomerName.Size = new System.Drawing.Size(65, 22);
			this.lblCustomerName.TabIndex = 8;
			this.lblCustomerName.Text = "label1";
			// 
			// labelMode
			// 
			this.labelMode.AutoSize = true;
			this.labelMode.BackColor = System.Drawing.Color.Tomato;
			this.labelMode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
			this.labelMode.Location = new System.Drawing.Point(24, -2);
			this.labelMode.Name = "labelMode";
			this.labelMode.Size = new System.Drawing.Size(0, 22);
			this.labelMode.TabIndex = 7;
			// 
			// btnSubmit
			// 
			this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(140)))), ((int)(((byte)(33)))));
			this.btnSubmit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.btnSubmit.FlatAppearance.BorderSize = 0;
			this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSubmit.Font = new System.Drawing.Font("jf open 粉圓 2.1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnSubmit.ForeColor = System.Drawing.Color.White;
			this.btnSubmit.Image = ((System.Drawing.Image)(resources.GetObject("btnSubmit.Image")));
			this.btnSubmit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSubmit.Location = new System.Drawing.Point(291, 420);
			this.btnSubmit.Name = "btnSubmit";
			this.btnSubmit.Size = new System.Drawing.Size(113, 38);
			this.btnSubmit.TabIndex = 6;
			this.btnSubmit.Text = "  送出訂單";
			this.btnSubmit.UseVisualStyleBackColor = false;
			this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
			// 
			// btnBack
			// 
			this.btnBack.BackColor = System.Drawing.Color.DarkGray;
			this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.btnBack.FlatAppearance.BorderSize = 0;
			this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBack.Font = new System.Drawing.Font("jf open 粉圓 2.1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnBack.ForeColor = System.Drawing.Color.White;
			this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
			this.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnBack.Location = new System.Drawing.Point(28, 420);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(70, 38);
			this.btnBack.TabIndex = 5;
			this.btnBack.Text = "  返回";
			this.btnBack.UseVisualStyleBackColor = false;
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// labelTotalAmount
			// 
			this.labelTotalAmount.AutoSize = true;
			this.labelTotalAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(140)))), ((int)(((byte)(33)))));
			this.labelTotalAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
			this.labelTotalAmount.Location = new System.Drawing.Point(3, 0);
			this.labelTotalAmount.Name = "labelTotalAmount";
			this.labelTotalAmount.Size = new System.Drawing.Size(67, 22);
			this.labelTotalAmount.TabIndex = 4;
			this.labelTotalAmount.Text = "總金額";
			this.labelTotalAmount.Click += new System.EventHandler(this.labelTotalAmount_Click);
			// 
			// dgvOrderDetails
			// 
			this.dgvOrderDetails.AllowUserToAddRows = false;
			this.dgvOrderDetails.AllowUserToDeleteRows = false;
			this.dgvOrderDetails.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
			this.dgvOrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvOrderDetails.Location = new System.Drawing.Point(28, 151);
			this.dgvOrderDetails.Name = "dgvOrderDetails";
			this.dgvOrderDetails.ReadOnly = true;
			this.dgvOrderDetails.RowTemplate.Height = 24;
			this.dgvOrderDetails.Size = new System.Drawing.Size(376, 163);
			this.dgvOrderDetails.TabIndex = 0;
			this.dgvOrderDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrderDetails_CellContentClick);
			// 
			// lblUpdatedPoints
			// 
			this.lblUpdatedPoints.AutoSize = true;
			this.lblUpdatedPoints.BackColor = System.Drawing.Color.Transparent;
			this.lblUpdatedPoints.Location = new System.Drawing.Point(3, 66);
			this.lblUpdatedPoints.Name = "lblUpdatedPoints";
			this.lblUpdatedPoints.Size = new System.Drawing.Size(71, 22);
			this.lblUpdatedPoints.TabIndex = 13;
			this.lblUpdatedPoints.Text = "Label6";
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.lblCustomerName, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.lblCustomerPhone, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.lblOrderTime, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.lblOrderType, 0, 2);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(28, 29);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 4;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(376, 123);
			this.tableLayoutPanel1.TabIndex = 14;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 1;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Controls.Add(this.labelTotalAmount, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.lblEarnedPoints, 0, 1);
			this.tableLayoutPanel2.Controls.Add(this.lblUpdatedPoints, 0, 2);
			this.tableLayoutPanel2.Location = new System.Drawing.Point(28, 314);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 3;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(376, 100);
			this.tableLayoutPanel2.TabIndex = 15;
			// 
			// OrderLastCheckForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(471, 512);
			this.Controls.Add(this.gbOrderLastCheck);
			this.Font = new System.Drawing.Font("jf open 粉圓 2.1", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "OrderLastCheckForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "阿萱便當後臺系統：訂單預覽／確認";
			this.gbOrderLastCheck.ResumeLayout(false);
			this.gbOrderLastCheck.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetails)).EndInit();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox gbOrderLastCheck;
		private System.Windows.Forms.DataGridView dgvOrderDetails;
		private System.Windows.Forms.Label labelTotalAmount;
		private System.Windows.Forms.Button btnSubmit;
		private System.Windows.Forms.Button btnBack;
		private System.Windows.Forms.Label labelMode;
		private System.Windows.Forms.Label lblEarnedPoints;
		private System.Windows.Forms.Label lblOrderTime;
		private System.Windows.Forms.Label lblOrderType;
		private System.Windows.Forms.Label lblCustomerPhone;
		private System.Windows.Forms.Label lblCustomerName;
		private System.Windows.Forms.Label lblUpdatedPoints;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
	}
}