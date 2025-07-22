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
	public partial class MemberForm : Form
	{
		// 登入的員工資訊
		public EmployeeModel LoginEmployee;

		// 標記視窗是否正在被拖曳
		private bool isDragging = false;
		// 記錄滑鼠點擊時的座標
		private Point LastLocation;

		//建構函式

		public MemberForm(EmployeeModel emp)
		{
			InitializeComponent();

			// 傳入登入員工資料
			this.LoginEmployee = emp;


			//綁定滑鼠拖曳事件
			this.MouseDown += new MouseEventHandler(MemberForm_MouseDown);
			this.MouseMove += new MouseEventHandler(MemberForm_MouseMove);
			this.MouseUp += new MouseEventHandler(MemberForm_MouseUp);
			// 遞迴綁定所有子控制項，確保點到任何元件也可拖曳
			AddDragEvents(this.Controls);

		}

		//遞迴綁定所有控制項的拖曳事件
		private void AddDragEvents(Control.ControlCollection controls)
		{
			foreach (Control ctrl in controls)
			{
				ctrl.MouseDown += MemberForm_MouseDown;
				ctrl.MouseMove += MemberForm_MouseMove;
				ctrl.MouseUp += MemberForm_MouseUp;

				// 如果該控制項有子控制項，繼續遞迴綁定
				if (ctrl.HasChildren)
				{
					AddDragEvents(ctrl.Controls);
				}
			}
		}
		
		//滑鼠按下
		private void MemberForm_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				isDragging = true;
				LastLocation = Cursor.Position;
			}
		}
		
		//滑鼠移動
		private void MemberForm_MouseMove(object sender, MouseEventArgs e)
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
		private void MemberForm_MouseUp(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				isDragging = false;
			}
		}

		// 側邊欄主介面按鈕
		private void btnMainForm_Click(object sender, EventArgs e)
		{
			//this.Hide();
			//MainForm mf = new MainForm(LoginEmployee);
			//mf.ShowDialog();
			//this.Show();

			FormSwitcher.SafeSwitchTo(this, new MainForm(LoginEmployee));
		}

		// 側邊欄產品管理介面按鈕
		private void btnProducts_Click(object sender, EventArgs e)
		{
			//this.Hide();
			//ProductsForm pf = new ProductsForm(LoginEmployee);
			//pf.ShowDialog();
			//this.Close();

			FormSwitcher.SafeSwitchTo(this, new ProductsForm(LoginEmployee));
		}

		// 側邊欄會員管理介面按鈕
		private void btnMember_Click(object sender, EventArgs e)
		{
			MessageBox.Show("您已在會員管理畫面。");
		}

		// 側邊欄訂單管理介面按鈕
		private void btnOrders_Click(object sender, EventArgs e)
		{
			//this.Hide();
			//OrderForm of = new OrderForm(LoginEmployee);
			//of.ShowDialog(); // 以模態方式顯示 OrderForm，MainForm 會自動禁用
			//of.ShowDialog();
			//this.Close();

			FormSwitcher.SafeSwitchTo(this, new OrderForm(LoginEmployee));
		}

		// 登出按鈕
		private void btnLogout_Click(object sender, EventArgs e)
		{
			//foreach (Form f in Application.OpenForms.Cast<Form>().ToList())
			//{
			//	if (f != this) f.Close(); // 關掉其他表單
			//}

			//this.Hide();
			//LoginForm lf = new LoginForm();
			//lf.ShowDialog();
			//this.Close();

			var confirm = MessageBox.Show("確定要登出嗎？", "登出確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (confirm == DialogResult.Yes)
			{
				FormSwitcher.SafeLogout(this);
			}
		}

		//關閉按鈕叫出確認視窗
		private void btnExit_Click(object sender, EventArgs e)
		{
			MessageBox.Show("請先登出再關閉系統。", "系統提醒", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}


		private MemberBLL memberBLL = new MemberBLL();

		private List<MemberModel> currentmemberList = new List<MemberModel>();

		//載入事件
		private void MemberForm_Load(object sender, EventArgs e)
		{
			dgvMember.CellClick += dgvMember_CellClick;
			LoadMemberList();
		}



		// 重新載入dgv列表
		private void LoadMemberList()
		{
			dgvMember.AutoGenerateColumns = false;
			dgvMember.DataSource = memberBLL.GetMemberList();
		}

		// 顯示會員詳細資料
		private void DisplayMemberDetails(MemberModel member)
		{
			if (member == null) return;

			txtMemberNumber.Text = member.MemberId.ToString();
			txtMemberName.Text = member.MemberName;
			txtMemberPhone.Text = member.MemberPhone;
			txtBirthday.Text = member.Birthday.ToString("yyyy/MM/dd"); txtPoints.Text = member.Points.ToString();
			txtMemberAddress.Text = member.MemberAddress;
		}

		// 會員清單點選事件
		private void dgvMember_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0) // 防止點擊標題列
			{
				// 取出該行綁定的資料物件
				MemberModel selectedMember = (MemberModel)dgvMember.Rows[e.RowIndex].DataBoundItem;

				if (selectedMember != null)
				{
					DisplayMemberDetails(selectedMember);
				}
			}
		}

		// 搜尋按鈕
		private void btnMemberSearch_Click(object sender, EventArgs e)
		{
			string keyword = txtMemberSearch.Text.Trim();
			var member = memberBLL.SearchMemberByName(keyword);
			if (member.Count > 0)
			{
				DisplayMemberDetails(member[0]);
			}
			else
			{
				MessageBox.Show("找不到此會員。");
			}
			txtMemberSearch.Text = string.Empty;
		}

		// 新增按鈕，清空輸入欄位
		private void btnMemberAdd_Click(object sender, EventArgs e)
		{
			ClearInputFields();
			
		}

		private void ClearInputFields()
		{
			txtMemberNumber.Text = "";
			txtMemberName.Text = "";
			txtMemberPhone.Text = "";
			txtBirthday.Text = "";
			txtPoints.Text = "";
			txtMemberAddress.Text = "";
		}

		// 修改按鈕，提示選擇會員
		private void btnMemberUpdate_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtMemberNumber.Text))
			{
				MessageBox.Show("請先從列表中選擇一筆會員資料進行修改");
				return;
			}

			// 讓使用者知道可以開始改資料
			MessageBox.Show("請修改下方欄位，完成後請按儲存");

			// 啟用欄位編輯（視需要而定）
			txtMemberName.Enabled = true;
			txtMemberPhone.Enabled = true;
			txtMemberAddress.Enabled = true;
			txtBirthday.Enabled = true;
			txtPoints.Enabled = true;

		}

		// 儲存按鈕（新增或修改都在這裡判斷）
		private void btnMemberSave_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtMemberName.Text))
			{
				MessageBox.Show("會員姓名不可為空");
				return;
			}

			MemberModel member = new MemberModel
			{
				MemberName = txtMemberName.Text.Trim(),
				MemberPhone = txtMemberPhone.Text.Trim(),
				Birthday = DateTime.TryParse(txtBirthday.Text.Trim(), out DateTime birthday) ? birthday : DateTime.MinValue,
				Points = int.TryParse(txtPoints.Text.Trim(), out int pts) ? pts : 0,
				MemberAddress = txtMemberAddress.Text.Trim()
			};

			if (string.IsNullOrEmpty(txtMemberNumber.Text))  // 新增
			{
				memberBLL.InsertMember(member);
				MessageBox.Show("新增成功！");
			}
			else  // 修改
			{
				member.MemberId = int.Parse(txtMemberNumber.Text);
				memberBLL.UpdateMember(member);
				MessageBox.Show("修改成功！");
			}

			LoadMemberList();
			ClearInputFields();
		}

		// 刪除按鈕
		private void btnMemberDelete_Click(object sender, EventArgs e)
		{
			if (int.TryParse(txtMemberNumber.Text, out int memberId))
			{
				var confirm = MessageBox.Show("確定要刪除此會員嗎？", "刪除確認", MessageBoxButtons.YesNo);
				if (confirm == DialogResult.Yes)
				{
					memberBLL.DeleteMember(memberId);
					MessageBox.Show("刪除成功！");
					LoadMemberList();
					ClearInputFields();
				}
			}
			else
			{
				MessageBox.Show("請先選擇要刪除的會員！");
			}
		}

		private void txtMemberSearch_TextChanged(object sender, EventArgs e)
		{

		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{
			AboutForm aboutForm = new AboutForm();
			aboutForm.ShowDialog();  // 彈出關於視窗
		}
	}
}
