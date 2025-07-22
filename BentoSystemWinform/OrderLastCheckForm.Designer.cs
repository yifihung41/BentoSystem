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
			this.labelMode = new System.Windows.Forms.Label();
			this.btnSubmit = new System.Windows.Forms.Button();
			this.btnBack = new System.Windows.Forms.Button();
			this.labelTotalAmount = new System.Windows.Forms.Label();
			this.dgvOrderDetails = new System.Windows.Forms.DataGridView();
			this.gbOrderLastCheck.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetails)).BeginInit();
			this.SuspendLayout();
			// 
			// gbOrderLastCheck
			// 
			this.gbOrderLastCheck.Controls.Add(this.labelMode);
			this.gbOrderLastCheck.Controls.Add(this.btnSubmit);
			this.gbOrderLastCheck.Controls.Add(this.btnBack);
			this.gbOrderLastCheck.Controls.Add(this.labelTotalAmount);
			this.gbOrderLastCheck.Controls.Add(this.dgvOrderDetails);
			this.gbOrderLastCheck.Font = new System.Drawing.Font("jf open 粉圓 2.1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.gbOrderLastCheck.Location = new System.Drawing.Point(25, 24);
			this.gbOrderLastCheck.Name = "gbOrderLastCheck";
			this.gbOrderLastCheck.Size = new System.Drawing.Size(431, 410);
			this.gbOrderLastCheck.TabIndex = 0;
			this.gbOrderLastCheck.TabStop = false;
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
			this.btnSubmit.Location = new System.Drawing.Point(277, 330);
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
			this.btnBack.Font = new System.Drawing.Font("jf open 粉圓 2.1", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnBack.ForeColor = System.Drawing.Color.White;
			this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
			this.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnBack.Location = new System.Drawing.Point(24, 331);
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
			this.labelTotalAmount.Location = new System.Drawing.Point(24, 281);
			this.labelTotalAmount.Name = "labelTotalAmount";
			this.labelTotalAmount.Size = new System.Drawing.Size(0, 22);
			this.labelTotalAmount.TabIndex = 4;
			// 
			// dgvOrderDetails
			// 
			this.dgvOrderDetails.AllowUserToAddRows = false;
			this.dgvOrderDetails.AllowUserToDeleteRows = false;
			this.dgvOrderDetails.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
			this.dgvOrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvOrderDetails.Location = new System.Drawing.Point(24, 28);
			this.dgvOrderDetails.Name = "dgvOrderDetails";
			this.dgvOrderDetails.ReadOnly = true;
			this.dgvOrderDetails.RowTemplate.Height = 24;
			this.dgvOrderDetails.Size = new System.Drawing.Size(366, 226);
			this.dgvOrderDetails.TabIndex = 0;
			// 
			// OrderLastCheckForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(489, 459);
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
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox gbOrderLastCheck;
		private System.Windows.Forms.DataGridView dgvOrderDetails;
		private System.Windows.Forms.Label labelTotalAmount;
		private System.Windows.Forms.Button btnSubmit;
		private System.Windows.Forms.Button btnBack;
		private System.Windows.Forms.Label labelMode;
	}
}