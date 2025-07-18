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
using System.Windows.Forms.VisualStyles;
using BentoSystemWinform.DAL;
using BentoSystemWinform.BLL;
using BentoSystemWinform.Models;

namespace BentoSystemWinform
{
	public partial class OrderForm : Form
	{
		// 登入的員工資訊
		public EmployeeModel LoginEmployee;

		// 標記視窗是否正在被拖曳
		private bool isDragging = false;
		// 記錄滑鼠點擊時的座標
		private Point LastLocation;

		//建構函式
		public OrderForm(EmployeeModel emp)
		{
			InitializeComponent();

			// 傳入登入員工資料
			this.LoginEmployee = emp;

			// 綁定滑鼠拖曳事件
			this.MouseDown += new MouseEventHandler(OrderForm_MouseDown);
			this.MouseMove += new MouseEventHandler(OrderForm_MouseMove);
			this.MouseUp += new MouseEventHandler(OrderForm_MouseUp);
			// 遞迴綁定所有子控制項，確保點到任何元件也可拖曳
			AddDragEvents(this.Controls);
		}

		//遞迴綁定所有控制項的拖曳事件
		private void AddDragEvents(Control.ControlCollection controls)
		{
			foreach (Control ctrl in controls)
			{
				ctrl.MouseDown += OrderForm_MouseDown;
				ctrl.MouseMove += OrderForm_MouseMove;
				ctrl.MouseUp += OrderForm_MouseUp;

				// 如果該控制項有子控制項，繼續遞迴綁定
				if (ctrl.HasChildren)
				{
					AddDragEvents(ctrl.Controls);
				}
			}
		}
		
		//滑鼠按下
		private void OrderForm_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				isDragging = true;
				LastLocation = Cursor.Position;
			}
		}
		
		//滑鼠移動
		private void OrderForm_MouseMove(object sender, MouseEventArgs e)
		{
			if (isDragging)
			{
				Point currentPos = Cursor.Position;
				int offsetX = currentPos.X - LastLocation.X;
				int offsetY = currentPos.Y - LastLocation.Y;
				this.Location = new Point(this.Left + offsetX, this.Top + offsetY);
				LastLocation = currentPos;
			}
		}
		
		//滑鼠放開
		private void OrderForm_MouseUp(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				isDragging = false;
			}
		}


		// 側邊欄主介面按鈕
		private void btnMainForm_Click(object sender, EventArgs e)
		{
			this.Hide();
			MainForm mf = new MainForm(LoginEmployee);
			mf.ShowDialog();
			this.Show();
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
			MessageBox.Show("您已在訂單管理畫面。");
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

		//關閉按鈕叫出確認視窗
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

		private void OrderForm_Load(object sender, EventArgs e)
		{

		}

		private void orderItem_LBSMSDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void labelOrderNumber_Click(object sender, EventArgs e)
		{

		}

		private void gbOrderAmount_Enter(object sender, EventArgs e)
		{

		}

		private void labelTotalTitle_Click(object sender, EventArgs e)
		{

		}
	}
}
