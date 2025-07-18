namespace BentoSystemWinform
{
	partial class ExitConfirmForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExitConfirmForm));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btnExitBack = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(13, 13);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(300, 161);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// btnExitBack
			// 
			this.btnExitBack.BackColor = System.Drawing.Color.Pink;
			this.btnExitBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnExitBack.Image = ((System.Drawing.Image)(resources.GetObject("btnExitBack.Image")));
			this.btnExitBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnExitBack.Location = new System.Drawing.Point(13, 181);
			this.btnExitBack.Name = "btnExitBack";
			this.btnExitBack.Size = new System.Drawing.Size(105, 34);
			this.btnExitBack.TabIndex = 1;
			this.btnExitBack.Text = " 返回系統";
			this.btnExitBack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnExitBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnExitBack.UseVisualStyleBackColor = false;
			this.btnExitBack.Click += new System.EventHandler(this.btnExitBack_Click);
			// 
			// btnExit
			// 
			this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(140)))), ((int)(((byte)(33)))));
			this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
			this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnExit.Location = new System.Drawing.Point(214, 181);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(99, 34);
			this.btnExit.TabIndex = 2;
			this.btnExit.Text = "殘忍離開";
			this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.btnExit.UseVisualStyleBackColor = false;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// ExitConfirmForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(325, 227);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnExitBack);
			this.Controls.Add(this.pictureBox1);
			this.Font = new System.Drawing.Font("jf open 粉圓 2.1", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ExitConfirmForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "離開系統確認";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button btnExitBack;
		private System.Windows.Forms.Button btnExit;
	}
}