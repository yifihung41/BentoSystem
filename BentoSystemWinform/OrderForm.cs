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

		// 欄位宣告區域（物件、變數、清單）
		private OrderDataDAL orderDataDAL = new OrderDataDAL();  // 這裡
		private OrderItemDAL orderItemDAL = new OrderItemDAL();  // 這裡
		private MemberDAL memberDAL = new MemberDAL();

		// 標記視窗是否正在被拖曳
		private bool isDragging = false;
		// 記錄滑鼠點擊時的座標
		private Point LastLocation;

		private bool isInitializing = false;

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
			ProductsForm pf = new ProductsForm(LoginEmployee);
			pf.ShowDialog();
			this.Show();
			pf.Hide();
		}

		// 側邊欄會員管理介面按鈕
		private void btnMember_Click(object sender, EventArgs e)
		{
			MemberForm mf = new MemberForm(LoginEmployee);
			mf.ShowDialog();
			this.Show();
			mf.Hide(); // 釋放資源
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
				this.Hide();
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


		//(宣告)資訊區：載入會員清單
		private MemberBLL mBll = new MemberBLL();
		//(宣告)時間計時器
		private Timer timerTime = new Timer();

		//(宣告)訂單時間顯示標籤
		private void timerOrderTime_Tick(object sender, EventArgs e)
		{
			labelOrderTime.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
		}

		//資訊區：會員/非會員及電話區
		private void MemberTypeChanged(object sender, EventArgs e)
		{
			if (rbtnIsMember.Checked)
			{
				cbMemberList.Enabled = true;
				cbMemberList.SelectedIndex = -1;

				txtInsertOrderName.Enabled = false;
				txtInsertOrderName.ReadOnly = true;
				txtInsertOrderName.Text = string.Empty;

				txtOrderPhone.Clear();
			}
			else if (rbtnNonMember.Checked)
			{
				cbMemberList.Enabled = false;
				cbMemberList.SelectedIndex = -1;

				txtInsertOrderName.Enabled = true;
				txtInsertOrderName.ReadOnly = false;
				txtInsertOrderName.Text = string.Empty;

				txtOrderPhone.Clear();
			}
		}

		private void cbMemberList_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cbMemberList.SelectedItem is MemberModel selectedMember)
			{
				txtOrderPhone.Text = selectedMember.MemberPhone;
			}
		}
		//選擇區：載入商品清單
		ProductBLL Pbll = new ProductBLL();

		private void LoadProductList()
		{
			var products = Pbll.GetProductList();

			if (dgvProductList == null)
			{
				MessageBox.Show("dgvProductList 尚未初始化！");
				return;
			}

			// 可選：自行控制欄位顯示（隱藏不必要的欄位）
			dgvProductList.AutoGenerateColumns = false;
			dgvProductList.DataSource = products;

			// 隱藏不要顯示的欄位（例如主鍵）
			if (dgvProductList.Columns.Contains("ProductId"))
			{
				dgvProductList.Columns["ProductId"].Visible = false;
			}
		}
	




		//選擇區：建立暫存訂單項目
		List<OrderItemTempModel> currentOrderItems;

		//選擇區：點擊加入餐點
		private void btnOrderAdd_Click(object sender, EventArgs e)
		{
			if (currentOrderItems == null || currentOrderItems.Count == 0)
			{
				MessageBox.Show("目前訂單沒有任何品項", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			// 送單前先更新價格計算及顯示
			UpdatePriceCalculation();

			decimal subtotal = currentOrderItems.Sum(x => x.ProductPrice * x.Quantity);
			decimal discount = 0m;

			if (rbtnIsMember.Checked && cbMemberList.SelectedItem is MemberModel member)
			{
				// 先判生日當天免費
				if (member.Birthday.Month == DateTime.Now.Month && member.Birthday.Day == DateTime.Now.Day)
				{
					discount = subtotal;  // 全額折扣
				}
				else if (member.Birthday.Month == DateTime.Now.Month)
				{
					discount = subtotal * 0.2m;  // 生日月八折折扣
				}
			}

			decimal total = subtotal - discount;

			var previewForm = new OrderLastCheckForm(
				currentOrderItems,
				total,
				allowSubmit: false);  // 預覽模式，不可送出

			previewForm.ShowDialog();
		}

		// 金額試算區：生日當月八折、當天免費
		private void UpdatePriceCalculation()
		{
			decimal subtotal = currentOrderItems.Sum(x => x.ProductPrice * x.Quantity);
			decimal discount = 0;
			decimal total = subtotal;

			if (rbtnIsMember.Checked && cbMemberList.SelectedItem is MemberModel member)
			{
				// 先判生日當天免費
				if (member.Birthday.Month == DateTime.Now.Month && member.Birthday.Day == DateTime.Now.Day)
				{
					total = 0;  // 當天免費
					discount = subtotal;
				}
				else if (member.Birthday.Month == DateTime.Now.Month)
				{
					discount = subtotal * 0.2m;  // 生日月折扣20%
					total = subtotal - discount;
				}
			}

			labelSubtotal.Text = $"{subtotal:0} 元";
			labelDiscount.Text = discount > 0 ? $"生日折扣：-{discount:0} 元" : "無折扣";
			labelTotal.Text = $"{total:0} 元";
		}


		// 訂單內容變更（加入餐點、修改數量、刪除）時都呼叫這個
		private void RefreshOrderCalculation()
		{
			UpdatePriceCalculation();
			// 可擴充：更新其他相關 UI
		}

		//右下按鈕區：送出訂單按鈕
		private void btnSubmitOrder_Click(object sender, EventArgs e)
		{
			string name = rbtnIsMember.Checked && cbMemberList.SelectedItem != null
				? ((MemberModel)cbMemberList.SelectedItem).MemberName
				: txtInsertOrderName.Text.Trim();

			string phone = txtOrderPhone.Text.Trim();

			string type = rbtnDelivery.Checked ? "外送" : "自取";

			DateTime now = DateTime.Now;

			decimal subtotal = currentOrderItems.Sum(x => x.Subtotal);

			decimal discount = 0m;
			if (rbtnIsMember.Checked && cbMemberList.SelectedItem is MemberModel member)
			{
				if (member.Birthday.Month == now.Month)
					discount = subtotal * 0.2m;
			}

			decimal total = subtotal - discount;

			var confirmForm = new BentoSystemWinform.OrderLastCheckForm(
				currentOrderItems,
				total,
				true);

			var result = confirmForm.ShowDialog();

			if (result == DialogResult.OK)
			{
				SaveOrderToDatabase(now, type, total);
				MessageBox.Show("訂單送出成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
				ClearOrderForm();  // 呼叫清空頁面
			}
			foreach (var item in currentOrderItems)
			{
				Pbll.DeductStock(item.ProductId, item.Quantity);
			}
			
		}
		// 重新載入商品清單
		public void ReloadProductList()
		{
			LoadProductList();
		}

		//右下：訂單預覽按鈕
		private void btnOrderPreview_Click(object sender, EventArgs e)
		{
			if (currentOrderItems == null || currentOrderItems.Count == 0)
			{
				MessageBox.Show("目前訂單沒有任何品項", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			decimal subtotal = currentOrderItems.Sum(x => x.ProductPrice * x.Quantity);

			var previewForm = new OrderLastCheckForm(
				currentOrderItems,
				subtotal,
				allowSubmit: false);

			previewForm.ShowDialog();
		}

		private void SaveOrderToDatabase(DateTime orderDate, string orderType, decimal total)
		{
			// 建立 OrderData
			OrderDataModel orderData = new OrderDataModel
			{
				OrderDate = orderDate,
				OrderType = orderType,
				EmployeeId = 1, // 假設預設員工 ID 為 1
				MemberId = rbtnIsMember.Checked ? ((MemberModel)cbMemberList.SelectedItem).MemberId : 0
			};

			int newOrderId = orderDataDAL.InsertOrderData(orderData); // 你需要實作這個

			foreach (var item in currentOrderItems)
			{
				OrderItemModel orderItem = new OrderItemModel
				{
					OrderId = newOrderId,
					ProductId = item.ProductId,
					Quantity = item.Quantity,
					//Spicy = item.Spicy
				};
				orderItemDAL.InsertOrderItem(orderItem); 

			}

			// 累積點數（會員專屬）
			if (rbtnIsMember.Checked)
			{
				int pointEarned = (int)(total / 100);
				int memberId = ((MemberModel)cbMemberList.SelectedItem).MemberId;
				memberDAL.AddPointsToMember(memberId, pointEarned); // 這是你要新增的 DAL 方法
			}

			MessageBox.Show("訂單已成功送出！");
			bool wasMember = rbtnIsMember.Checked;
			bool wasNotMember = rbtnNonMember.Checked;



			// 還原會員身份
			rbtnIsMember.Checked = wasMember;
			rbtnNonMember.Checked = wasNotMember;
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

		private void labelOrderDateTime_Click(object sender, EventArgs e)
		{}

		private void labelOrderTime_Click(object sender, EventArgs e)
		{}

		private void gbOrderInfo_Enter(object sender, EventArgs e)
		{}

		//選擇區：數量調整
		private void nudQuantity_ValueChanged(object sender, EventArgs e)
		{
			if (nudQuantity.Value < 1)
				nudQuantity.Value = 1;
			else if (nudQuantity.Value > 100)
				nudQuantity.Value = 100;
		}

		// 右下按鈕：會員點數查詢
		private void btnPointCheck_Click(object sender, EventArgs e)
		{
			if (rbtnIsMember.Checked && cbMemberList.SelectedItem is MemberModel member)
			{
				string memberName = member.MemberName;
				int points = member.Points;

				PointCheckWindow pcw = new PointCheckWindow(memberName, points);
				pcw.ShowDialog();
			}
			else
			{
				MessageBox.Show("非會員無法查詢點數！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void btnOrderAdd_Click_1(object sender, EventArgs e)
		{
			// 確認已選商品
			if (dgvProductList.CurrentRow == null)
			{
				MessageBox.Show("請先選擇一項商品", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			var product = (ProductModel)dgvProductList.CurrentRow.DataBoundItem;

			// 檢查庫存
			if (product.StockQuantity <= 0)
			{
				MessageBox.Show("該商品已缺貨，無法加入訂單", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			int quantity = (int)nudQuantity.Value;
			if (quantity <= 0)
			{
				MessageBox.Show("數量必須大於0", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			if (quantity > product.StockQuantity)
			{
				MessageBox.Show($"庫存不足，最大可訂購數量為 {product.StockQuantity}", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			//// 取得該列的加辣欄勾選狀態
			//bool isSpicy = false;
			//var spicyCell = dgvProductList.CurrentRow.Cells["IsSpicy"];
			//if (spicyCell != null && spicyCell.Value != null)
			//{
			//	isSpicy = Convert.ToBoolean(spicyCell.Value);
			//}

			// 加入暫存訂單清單
			var item = new OrderItemTempModel
			{
				ProductId = product.ProductId,
				ProductName = product.ProductName,
				ProductPrice = product.ProductPrice,
				Quantity = quantity,
				//Spicy = chbIsSpicy.Checked
			};

			currentOrderItems.Add(item);

			MessageBox.Show("已成功加入訂單", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Information);

			// 依你需求，這邊可刷新訂單列表或試算價格
			UpdatePriceCalculation();

		}


		//建構函式
		private void OrderForm_Load(object sender, EventArgs e)
		{
			// 預設為非會員，初始化相關欄位狀態
			rbtnNonMember.Checked = true;
			rbtnIsMember.CheckedChanged += MemberTypeChanged;
			rbtnNonMember.CheckedChanged += MemberTypeChanged;
			cbMemberList.SelectedIndex = -1;
			MemberTypeChanged(null, null); // 初始化欄位狀態

			// 載入會員清單（使用 MemberBLL）
			var members = mBll.GetMemberList();

			// 避免觸發 SelectedIndexChanged 事件導致錯誤
			cbMemberList.SelectedIndexChanged -= cbMemberList_SelectedIndexChanged;

			cbMemberList.DataSource = members;
			cbMemberList.DisplayMember = "MemberName";
			cbMemberList.ValueMember = "MemberId";
			cbMemberList.SelectedIndex = -1;  // 確保無預設選擇

			cbMemberList.SelectedIndexChanged += cbMemberList_SelectedIndexChanged;

			txtOrderPhone.Clear(); // 清除電話欄

			// 初始化時間顯示（每秒更新）
			timerTime.Interval = 1000;
			timerTime.Tick += timerOrderTime_Tick;
			timerTime.Start();

			// 載入商品清單
			LoadProductList();

			// 設定 CellFormatting 事件（例如缺貨變灰色）
			dgvProductList.CellFormatting += dgvProductList_CellFormatting;

			// 初始化訂單清單
			currentOrderItems = new List<OrderItemTempModel>();
		}

		


		private void dgvProductList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if (dgvProductList.Rows[e.RowIndex].DataBoundItem is ProductModel product)
			{
				if (product.IsOutofstock)
				{
					dgvProductList.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGray;
					dgvProductList.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.DarkGray;
					dgvProductList.Rows[e.RowIndex].DefaultCellStyle.SelectionBackColor = Color.LightGray;
					dgvProductList.Rows[e.RowIndex].DefaultCellStyle.SelectionForeColor = Color.DarkGray;
				}
				else
				{
					// 回復正常樣式（避免資料重複載入時顏色殘留）
					dgvProductList.Rows[e.RowIndex].DefaultCellStyle.BackColor = dgvProductList.DefaultCellStyle.BackColor;
					dgvProductList.Rows[e.RowIndex].DefaultCellStyle.ForeColor = dgvProductList.DefaultCellStyle.ForeColor;
					dgvProductList.Rows[e.RowIndex].DefaultCellStyle.SelectionBackColor = dgvProductList.DefaultCellStyle.SelectionBackColor;
					dgvProductList.Rows[e.RowIndex].DefaultCellStyle.SelectionForeColor = dgvProductList.DefaultCellStyle.SelectionForeColor;
				}
			}
		}

		private void rbtnDelivery_CheckedChanged(object sender, EventArgs e)
		{
			if (rbtnDelivery.Checked)
			{
				labelOrderType.Text = "外帶";
			}
		}
		private void rbtnPickup_CheckedChanged(object sender, EventArgs e)
		{
			if (rbtnPickup.Checked)
			{
				labelOrderType.Text = "內用";
			}
		}

		private void ClearOrderForm()
		{
			// 清空訂單明細
			currentOrderItems.Clear();

			// 清空會員資料欄位
			txtInsertOrderName.Text = "";
			txtOrderPhone.Text = "";
			cbMemberList.SelectedIndex = -1;

			// 重置會員與非會員選項
			rbtnIsMember.Checked = false;
			rbtnNonMember.Checked = true;

			// 重置訂購方式（外帶、自取）
			rbtnDelivery.Checked = false;
			rbtnPickup.Checked = false;

			// 清空餐點列表（依你的DataGridView名稱調整）
			dgvProductList.DataSource = null;

			// 重置價格顯示區
			labelSubtotal.Text = "0 元";
			labelDiscount.Text = "無折扣";
			labelTotal.Text = "0 元";

			// 若有UI狀態更新方法，也可以呼叫
			UpdatePriceCalculation();
			MemberTypeChanged(null, null);
		}


	}

}
