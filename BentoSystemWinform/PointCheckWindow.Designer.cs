namespace BentoSystemWinform
{
	partial class PointCheckWindow
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PointCheckWindow));
			this.gbPointCheck = new System.Windows.Forms.GroupBox();
			this.labelPCPoints = new System.Windows.Forms.Label();
			this.labelPCName = new System.Windows.Forms.Label();
			this.labelPCPointsTitle = new System.Windows.Forms.Label();
			this.labelPCNameTitle = new System.Windows.Forms.Label();
			this.gbPointCheck.SuspendLayout();
			this.SuspendLayout();
			// 
			// gbPointCheck
			// 
			this.gbPointCheck.BackColor = System.Drawing.Color.White;
			this.gbPointCheck.Controls.Add(this.labelPCPoints);
			this.gbPointCheck.Controls.Add(this.labelPCName);
			this.gbPointCheck.Controls.Add(this.labelPCPointsTitle);
			this.gbPointCheck.Controls.Add(this.labelPCNameTitle);
			this.gbPointCheck.Font = new System.Drawing.Font("jf open 粉圓 2.1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.gbPointCheck.Location = new System.Drawing.Point(23, 19);
			this.gbPointCheck.Name = "gbPointCheck";
			this.gbPointCheck.Size = new System.Drawing.Size(273, 184);
			this.gbPointCheck.TabIndex = 25;
			this.gbPointCheck.TabStop = false;
			this.gbPointCheck.Text = "會員點數確認";
			this.gbPointCheck.Enter += new System.EventHandler(this.gbPointCheck_Enter);
			// 
			// labelPCPoints
			// 
			this.labelPCPoints.AutoSize = true;
			this.labelPCPoints.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(140)))), ((int)(((byte)(33)))));
			this.labelPCPoints.Location = new System.Drawing.Point(155, 113);
			this.labelPCPoints.Name = "labelPCPoints";
			this.labelPCPoints.Size = new System.Drawing.Size(0, 22);
			this.labelPCPoints.TabIndex = 3;
			// 
			// labelPCName
			// 
			this.labelPCName.AutoSize = true;
			this.labelPCName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(140)))), ((int)(((byte)(33)))));
			this.labelPCName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.labelPCName.Location = new System.Drawing.Point(155, 61);
			this.labelPCName.Name = "labelPCName";
			this.labelPCName.Size = new System.Drawing.Size(0, 22);
			this.labelPCName.TabIndex = 2;
			// 
			// labelPCPointsTitle
			// 
			this.labelPCPointsTitle.AutoSize = true;
			this.labelPCPointsTitle.Font = new System.Drawing.Font("jf open 粉圓 2.1", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.labelPCPointsTitle.Location = new System.Drawing.Point(32, 113);
			this.labelPCPointsTitle.Name = "labelPCPointsTitle";
			this.labelPCPointsTitle.Size = new System.Drawing.Size(110, 22);
			this.labelPCPointsTitle.TabIndex = 1;
			this.labelPCPointsTitle.Text = "可用點數：";
			// 
			// labelPCNameTitle
			// 
			this.labelPCNameTitle.AutoSize = true;
			this.labelPCNameTitle.Font = new System.Drawing.Font("jf open 粉圓 2.1", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.labelPCNameTitle.Location = new System.Drawing.Point(32, 61);
			this.labelPCNameTitle.Name = "labelPCNameTitle";
			this.labelPCNameTitle.Size = new System.Drawing.Size(110, 22);
			this.labelPCNameTitle.TabIndex = 0;
			this.labelPCNameTitle.Text = "會員姓名：";
			// 
			// PointCheckWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(325, 227);
			this.Controls.Add(this.gbPointCheck);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "PointCheckWindow";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "阿萱便當後台系統：會員點數確認";
			this.gbPointCheck.ResumeLayout(false);
			this.gbPointCheck.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.GroupBox gbPointCheck;
		private System.Windows.Forms.Label labelPCPointsTitle;
		private System.Windows.Forms.Label labelPCNameTitle;
		private System.Windows.Forms.Label labelPCPoints;
		private System.Windows.Forms.Label labelPCName;
	}
}