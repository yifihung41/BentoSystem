using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BentoSystemWinform.DAL;
using BentoSystemWinform.BLL;
using BentoSystemWinform.Models;


namespace BentoSystemWinform
{
	public partial class MainForm : Form
	{
		// 登入的員工資訊
		public EmployeeModel LoginEmployee;

		// 標記視窗是否正在被拖曳
		private bool isDragging = false;
		// 記錄滑鼠點擊時的座標
		private Point LastLocation;

		// 定義Timer
		private Timer timer;

		//建構函式
		public MainForm(EmployeeModel emp)
		{
			InitializeComponent();

			// 傳入登入員工資料
			this.LoginEmployee = emp;

			// 左上角顯示歡迎訊息
			lbWelcome.Text = $"Hi，{LoginEmployee.Account} ！歡迎使用阿萱便當後臺系統！";

			
			// 綁定滑鼠拖曳事件
			this.MouseDown += new MouseEventHandler(MainForm_MouseDown);
			this.MouseMove += new MouseEventHandler(MainForm_MouseMove);
			this.MouseUp += new MouseEventHandler(MainForm_MouseUp);
			// 遞迴綁定所有子控制項，確保點到任何元件也可拖曳
			AddDragEvents(this.Controls);

			// 初始化時間顯示Timer
			timer = new Timer();
			timer.Interval = 1000; // 每秒更新一次
			timer.Tick += Timer_Tick;
			timer.Start();
		}


		// 右上角更新目前時間
		private void Timer_Tick(object sender, EventArgs e)
		{
			// 只在內容變動時才更新，減少不必要的 UI 更新
			string now = $"現在時間為：{DateTime.Now:yyyy/MM/dd HH:mm:ss}";
			if (label1.Text != now)
				label1.Text = now;
		}

		//遞迴綁定所有控制項的拖曳事件
		private void AddDragEvents(Control.ControlCollection controls)
		{
			foreach (Control ctrl in controls)
			{
				ctrl.MouseDown += MainForm_MouseDown;
				ctrl.MouseMove += MainForm_MouseMove;
				ctrl.MouseUp += MainForm_MouseUp;

				// 如果該控制項有子控制項，繼續遞迴綁定
				if (ctrl.HasChildren)
				{
					AddDragEvents(ctrl.Controls);
				}
			}
		}

		 // 滑鼠按下
		private void MainForm_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				isDragging = true;
				LastLocation = Cursor.Position; // 儲存滑鼠螢幕位置
			}
		}

		// 滑鼠移動
		private void MainForm_MouseMove(object sender, MouseEventArgs e)
		{
			if (isDragging)
			{
				Point current = Cursor.Position;
				int offsetX = current.X - LastLocation.X;
				int offsetY = current.Y - LastLocation.Y;
				this.Location = new Point(this.Left + offsetX, this.Top + offsetY);
				LastLocation = current; // 更新拖曳起點
			}
		}

		// 滑鼠放開
		private void MainForm_MouseUp(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				isDragging = false;
			}
		}

		
		// 側邊欄主介面按鈕
		private void btnMainForm_Click(object sender, EventArgs e)
		{
			// 避免重複開啟 MainForm，建議只需重新整理內容或直接 return
			// 若確實需要重新開啟，可考慮關閉目前視窗後再開新 MainForm
			// this.Hide();
			// MainForm mf = new MainForm(LoginEmployee);
			// mf.ShowDialog();
			// this.Show();

			// 建議做法：不重複開啟 MainForm
			MessageBox.Show("您已在主畫面。");
		}

		// 側邊欄產品管理介面按鈕
		private void btnProducts_Click(object sender, EventArgs e)
		{
			this.Hide();
			ProductsForm pf = new ProductsForm(LoginEmployee); // 傳遞 LoginEmployee 作為參數
			pf.FormClosed += (s, args) => this.Show(); // 正確顯示主視窗
			pf.Show();
		}

		// 側邊欄會員管理介面按鈕
		private void btnMember_Click(object sender, EventArgs e)
		{
			this.Hide();
			MemberForm mf = new MemberForm(LoginEmployee); // 傳遞 LoginEmployee 作為參數
			mf.FormClosed += (s, args) => this.Show();
			mf.Show();
		}

		// 側邊欄訂單管理介面按鈕
		private void btnOrders_Click(object sender, EventArgs e)
		{
			this.Hide();
			OrderForm of = new OrderForm(LoginEmployee);
			of.FormClosed += (s, args) => this.Show();
			of.Show();
		}

		// 登出按鈕
		private void btnLogout_Click(object sender, EventArgs e)
		{
			this.Hide();                         // 先隱藏目前畫面

			LoginForm loginForm = new LoginForm();
			DialogResult result = loginForm.ShowDialog(); // 讓使用者重新登入

			if (result == DialogResult.OK)
			{
				// 重新取得新登入者的資訊
				this.LoginEmployee = loginForm.LoginEmployee;

				MainForm mainForm = new MainForm(this.LoginEmployee);
				mainForm.Show(); // 顯示自己（原本主畫面）
			}
			else
			{
				// 使用者關閉登入畫面、或取消，整個關掉
				this.Close();
			}
		}

		// 關閉按鈕叫出確認視窗
		private void btnExit_Click(object sender, EventArgs e)
		{
			ExitConfirmForm exitConfirmForm = new ExitConfirmForm();
			DialogResult result = exitConfirmForm.ShowDialog();

			if (result == DialogResult.OK)
			{
				Application.Exit(); // 關閉整個程式
			}
			else if (result == DialogResult.Cancel)
			{
				exitConfirmForm.Close(); // 只關閉此小視窗，繼續使用主視窗
			}
		}

		private void pictureBox7_Click(object sender, EventArgs e)
		{ }

		private void pictureBox8_Click(object sender, EventArgs e)
		{

		}

		private void MainForm_Load(object sender, EventArgs e)
		{

		}
	}
}
