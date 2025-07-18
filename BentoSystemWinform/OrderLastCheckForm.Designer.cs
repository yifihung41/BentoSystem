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
			this.dgvOrderLastCheck = new System.Windows.Forms.DataGridView();
			this.labelOrderLastCheck = new System.Windows.Forms.Label();
			this.labelOrderLastCheckTitle = new System.Windows.Forms.Label();
			this.btnOrderLastCheckBack = new System.Windows.Forms.Button();
			this.btnOrderLastCheckOK = new System.Windows.Forms.Button();
			this.gbOrderLastCheck.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvOrderLastCheck)).BeginInit();
			this.SuspendLayout();
			// 
			// gbOrderLastCheck
			// 
			this.gbOrderLastCheck.Controls.Add(this.btnOrderLastCheckOK);
			this.gbOrderLastCheck.Controls.Add(this.btnOrderLastCheckBack);
			this.gbOrderLastCheck.Controls.Add(this.labelOrderLastCheck);
			this.gbOrderLastCheck.Controls.Add(this.labelOrderLastCheckTitle);
			this.gbOrderLastCheck.Controls.Add(this.dgvOrderLastCheck);
			this.gbOrderLastCheck.Font = new System.Drawing.Font("jf open 粉圓 2.1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.gbOrderLastCheck.Location = new System.Drawing.Point(25, 24);
			this.gbOrderLastCheck.Name = "gbOrderLastCheck";
			this.gbOrderLastCheck.Size = new System.Drawing.Size(271, 383);
			this.gbOrderLastCheck.TabIndex = 0;
			this.gbOrderLastCheck.TabStop = false;
			this.gbOrderLastCheck.Text = "訂單最終確認";
			this.gbOrderLastCheck.Enter += new System.EventHandler(this.gbOrderLastCheck_Enter);
			// 
			// dgvOrderLastCheck
			// 
			this.dgvOrderLastCheck.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
			this.dgvOrderLastCheck.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvOrderLastCheck.Location = new System.Drawing.Point(24, 32);
			this.dgvOrderLastCheck.Name = "dgvOrderLastCheck";
			this.dgvOrderLastCheck.RowTemplate.Height = 24;
			this.dgvOrderLastCheck.Size = new System.Drawing.Size(222, 234);
			this.dgvOrderLastCheck.TabIndex = 0;
			// 
			// labelOrderLastCheck
			// 
			this.labelOrderLastCheck.AutoSize = true;
			this.labelOrderLastCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(140)))), ((int)(((byte)(33)))));
			this.labelOrderLastCheck.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
			this.labelOrderLastCheck.Location = new System.Drawing.Point(167, 285);
			this.labelOrderLastCheck.Name = "labelOrderLastCheck";
			this.labelOrderLastCheck.Size = new System.Drawing.Size(0, 22);
			this.labelOrderLastCheck.TabIndex = 4;
			// 
			// labelOrderLastCheckTitle
			// 
			this.labelOrderLastCheckTitle.AutoSize = true;
			this.labelOrderLastCheckTitle.Font = new System.Drawing.Font("jf open 粉圓 2.1", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.labelOrderLastCheckTitle.Location = new System.Drawing.Point(22, 284);
			this.labelOrderLastCheckTitle.Name = "labelOrderLastCheckTitle";
			this.labelOrderLastCheckTitle.Size = new System.Drawing.Size(136, 24);
			this.labelOrderLastCheckTitle.TabIndex = 3;
			this.labelOrderLastCheckTitle.Text = "訂單總金額：";
			// 
			// btnOrderLastCheckBack
			// 
			this.btnOrderLastCheckBack.BackColor = System.Drawing.Color.DarkGray;
			this.btnOrderLastCheckBack.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.btnOrderLastCheckBack.FlatAppearance.BorderSize = 0;
			this.btnOrderLastCheckBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnOrderLastCheckBack.Font = new System.Drawing.Font("jf open 粉圓 2.1", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnOrderLastCheckBack.ForeColor = System.Drawing.Color.White;
			this.btnOrderLastCheckBack.Image = ((System.Drawing.Image)(resources.GetObject("btnOrderLastCheckBack.Image")));
			this.btnOrderLastCheckBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnOrderLastCheckBack.Location = new System.Drawing.Point(26, 325);
			this.btnOrderLastCheckBack.Name = "btnOrderLastCheckBack";
			this.btnOrderLastCheckBack.Size = new System.Drawing.Size(70, 38);
			this.btnOrderLastCheckBack.TabIndex = 5;
			this.btnOrderLastCheckBack.Text = "  返回";
			this.btnOrderLastCheckBack.UseVisualStyleBackColor = false;
			// 
			// btnOrderLastCheckOK
			// 
			this.btnOrderLastCheckOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(140)))), ((int)(((byte)(33)))));
			this.btnOrderLastCheckOK.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.btnOrderLastCheckOK.FlatAppearance.BorderSize = 0;
			this.btnOrderLastCheckOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnOrderLastCheckOK.Font = new System.Drawing.Font("jf open 粉圓 2.1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnOrderLastCheckOK.ForeColor = System.Drawing.Color.White;
			this.btnOrderLastCheckOK.Image = ((System.Drawing.Image)(resources.GetObject("btnOrderLastCheckOK.Image")));
			this.btnOrderLastCheckOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnOrderLastCheckOK.Location = new System.Drawing.Point(134, 325);
			this.btnOrderLastCheckOK.Name = "btnOrderLastCheckOK";
			this.btnOrderLastCheckOK.Size = new System.Drawing.Size(113, 38);
			this.btnOrderLastCheckOK.TabIndex = 6;
			this.btnOrderLastCheckOK.Text = "  送出訂單";
			this.btnOrderLastCheckOK.UseVisualStyleBackColor = false;
			// 
			// OrderLastCheckForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(321, 435);
			this.Controls.Add(this.gbOrderLastCheck);
			this.Font = new System.Drawing.Font("jf open 粉圓 2.1", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "OrderLastCheckForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "阿萱便當後臺系統：訂單最終確認";
			this.gbOrderLastCheck.ResumeLayout(false);
			this.gbOrderLastCheck.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvOrderLastCheck)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox gbOrderLastCheck;
		private System.Windows.Forms.DataGridView dgvOrderLastCheck;
		private System.Windows.Forms.Label labelOrderLastCheck;
		private System.Windows.Forms.Label labelOrderLastCheckTitle;
		private System.Windows.Forms.Button btnOrderLastCheckOK;
		private System.Windows.Forms.Button btnOrderLastCheckBack;
	}
}