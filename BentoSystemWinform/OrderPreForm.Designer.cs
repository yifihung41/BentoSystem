namespace BentoSystemWinform
{
	partial class OrderPreForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderPreForm));
			this.gbOrderPre = new System.Windows.Forms.GroupBox();
			this.dgvOrderPre = new System.Windows.Forms.DataGridView();
			this.labelPreTotalTitle = new System.Windows.Forms.Label();
			this.labelPreTotal = new System.Windows.Forms.Label();
			this.btnPreBack = new System.Windows.Forms.Button();
			this.gbOrderPre.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvOrderPre)).BeginInit();
			this.SuspendLayout();
			// 
			// gbOrderPre
			// 
			this.gbOrderPre.Controls.Add(this.btnPreBack);
			this.gbOrderPre.Controls.Add(this.labelPreTotal);
			this.gbOrderPre.Controls.Add(this.labelPreTotalTitle);
			this.gbOrderPre.Controls.Add(this.dgvOrderPre);
			this.gbOrderPre.Font = new System.Drawing.Font("jf open 粉圓 2.1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.gbOrderPre.Location = new System.Drawing.Point(13, 13);
			this.gbOrderPre.Name = "gbOrderPre";
			this.gbOrderPre.Size = new System.Drawing.Size(300, 410);
			this.gbOrderPre.TabIndex = 0;
			this.gbOrderPre.TabStop = false;
			this.gbOrderPre.Text = "訂單預覽";
			this.gbOrderPre.Enter += new System.EventHandler(this.gbOrderPre_Enter);
			// 
			// dgvOrderPre
			// 
			this.dgvOrderPre.AllowUserToAddRows = false;
			this.dgvOrderPre.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvOrderPre.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
			this.dgvOrderPre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvOrderPre.GridColor = System.Drawing.SystemColors.Control;
			this.dgvOrderPre.Location = new System.Drawing.Point(26, 40);
			this.dgvOrderPre.Name = "dgvOrderPre";
			this.dgvOrderPre.ReadOnly = true;
			this.dgvOrderPre.RowTemplate.Height = 24;
			this.dgvOrderPre.Size = new System.Drawing.Size(248, 269);
			this.dgvOrderPre.TabIndex = 0;
			// 
			// labelPreTotalTitle
			// 
			this.labelPreTotalTitle.AutoSize = true;
			this.labelPreTotalTitle.Font = new System.Drawing.Font("jf open 粉圓 2.1", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.labelPreTotalTitle.Location = new System.Drawing.Point(22, 332);
			this.labelPreTotalTitle.Name = "labelPreTotalTitle";
			this.labelPreTotalTitle.Size = new System.Drawing.Size(136, 24);
			this.labelPreTotalTitle.TabIndex = 1;
			this.labelPreTotalTitle.Text = "訂單總金額：";
			// 
			// labelPreTotal
			// 
			this.labelPreTotal.AutoSize = true;
			this.labelPreTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(140)))), ((int)(((byte)(33)))));
			this.labelPreTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
			this.labelPreTotal.Location = new System.Drawing.Point(167, 333);
			this.labelPreTotal.Name = "labelPreTotal";
			this.labelPreTotal.Size = new System.Drawing.Size(0, 22);
			this.labelPreTotal.TabIndex = 2;
			// 
			// btnPreBack
			// 
			this.btnPreBack.BackColor = System.Drawing.Color.DarkGray;
			this.btnPreBack.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.btnPreBack.FlatAppearance.BorderSize = 0;
			this.btnPreBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPreBack.Font = new System.Drawing.Font("jf open 粉圓 2.1", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnPreBack.ForeColor = System.Drawing.Color.White;
			this.btnPreBack.Image = ((System.Drawing.Image)(resources.GetObject("btnPreBack.Image")));
			this.btnPreBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnPreBack.Location = new System.Drawing.Point(204, 367);
			this.btnPreBack.Name = "btnPreBack";
			this.btnPreBack.Size = new System.Drawing.Size(70, 29);
			this.btnPreBack.TabIndex = 3;
			this.btnPreBack.Text = "  返回";
			this.btnPreBack.UseVisualStyleBackColor = false;
			// 
			// OrderPreForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(325, 435);
			this.Controls.Add(this.gbOrderPre);
			this.Font = new System.Drawing.Font("jf open 粉圓 2.1", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "OrderPreForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "阿萱便當後臺系統：訂單預覽";
			this.gbOrderPre.ResumeLayout(false);
			this.gbOrderPre.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvOrderPre)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox gbOrderPre;
		private System.Windows.Forms.DataGridView dgvOrderPre;
		private System.Windows.Forms.Label labelPreTotal;
		private System.Windows.Forms.Label labelPreTotalTitle;
		private System.Windows.Forms.Button btnPreBack;
	}
}