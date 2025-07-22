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
using BentoSystemWinform.Models; 
using BentoSystemWinform.BLL;


namespace BentoSystemWinform
{

	public partial class LoginForm : Form
	{
		public EmployeeModel LoginEmployee { get; private set; }

		//滑鼠可拖曳視窗
		private bool isDragging = false; // 標記視窗是否正在被拖曳
		private Point lastLocation; // 記錄滑鼠點擊時的座標

	
		// 建構函式，初始化登入介面
		public LoginForm()
		{
			InitializeComponent();

			// 綁定拖曳事件
			this.MouseDown += new MouseEventHandler(LoginForm_MouseDown);
			this.MouseMove += new MouseEventHandler(LoginForm_MouseMove);
			this.MouseUp += new MouseEventHandler(LoginForm_MouseUp);
			// 遞迴綁定所有子控制項，確保點到任何元件也可拖曳
			AddDragEvents(this.Controls);
		}

		//遞迴綁定所有控制項的拖曳事件
		private void AddDragEvents(Control.ControlCollection controls)
		{
			foreach (Control ctrl in controls)
			{
				ctrl.MouseDown += LoginForm_MouseDown;
				ctrl.MouseMove += LoginForm_MouseMove;
				ctrl.MouseUp += LoginForm_MouseUp;

				// 如果該控制項有子控制項，繼續遞迴綁定
				if (ctrl.HasChildren)
				{
					AddDragEvents(ctrl.Controls);
				}
			}
		}
		
		//滑鼠按下
		private void LoginForm_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				isDragging = true;
				lastLocation = Cursor.Position;
			}
		}
		
		//滑鼠移動
		private void LoginForm_MouseMove(object sender, MouseEventArgs e)
		{
			if (isDragging)
			{
				Point currentPos = Cursor.Position;
				int offsetX = currentPos.X - lastLocation.X;
				int offsetY = currentPos.Y - lastLocation.Y;
				this.Location = new Point(this.Left + offsetX, this.Top + offsetY);
				lastLocation = currentPos;
			}
		}
		
		//滑鼠放開
		private void LoginForm_MouseUp(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				isDragging = false;
			}
		}

		//登入按鈕點擊事件
		public void btnLogin_Click(object sender, EventArgs e)
		{
			string account = txtAccount.Text.Trim();
			string password = txtPassword.Text.Trim();

			// 檢查帳號和密碼是否為空
			if (string.IsNullOrEmpty(account) || string.IsNullOrEmpty(password))
			{
				MessageBox.Show("帳號或密碼不能為空，請重新輸入！");
				return;
			}

			//呼叫 EmployeeDAL 來檢查帳號和密碼
			EmployeeDAL Edal = new EmployeeDAL();
			EmployeeModel emp = Edal.GetEmployeeByAccount(account);

			//查詢後確認帳號是否存在
			if (emp == null)
			{
				MessageBox.Show("此帳號不存在！");
				return;
			}
			

			//確認密碼是否正確
			if (emp.Password != password.Trim())
			{
				MessageBox.Show("密碼錯誤，請重新輸入！");
				return;
			}

			// 登入成功：設定屬性並回傳 OK
			this.LoginEmployee = emp;

			// 選擇性：登入成功歡迎畫面
			WelcomeForm welcomeForm = new WelcomeForm(emp.Account);
			welcomeForm.ShowDialog();

			this.DialogResult = DialogResult.OK; // 告訴 Program.cs 登入成功
			this.Hide(); // 關閉登入視窗
		}

		//登入系統離開按鈕點擊事件
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
				exitConfirmForm.Close();// 只關閉此小視窗，繼續使用主視窗
			}
		}

		
	}
}


