using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BentoSystemWinform.DAL;
using BentoSystemWinform.Models;
using BentoSystemWinform.BLL;
using System.Drawing.Drawing2D;

namespace BentoSystemWinform
{
	public partial class WelcomeForm : Form
	{

		private Timer timer;
		public WelcomeForm(string Account)
		{
			InitializeComponent();
			labelWelcomeHint.Text = $"歡迎回來，{Account}";//顯示包含帳號的歡迎訊息

			//初始化Timer
			timer = new Timer();
			timer.Interval = 2000; // 2秒後關閉
			timer.Tick += Timer_Tick;
			timer.Start();
		}

		private void Timer_Tick(object sender, EventArgs e)
		{
			timer.Stop(); // 停止計時器
			timer.Dispose(); // 釋放資源
			this.Close(); // 關閉歡迎視窗
		}
		private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close(); // 手動點按鈕離開
		}
		//private void WelcomeForm_Load(object sender, EventArgs e)
		//{
		//	// 留空即可，避免設計工具出錯
		//}


	}
}
