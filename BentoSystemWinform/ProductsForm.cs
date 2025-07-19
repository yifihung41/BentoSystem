using BentoSystemWinform.BLL;
using BentoSystemWinform.DAL;
using BentoSystemWinform.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BentoSystemWinform
{
	public partial class ProductsForm : Form
	{
		// 登入的員工資訊
		public EmployeeModel LoginEmployee;

		// 標記視窗是否正在被拖曳
		private bool isDragging = false;
		// 記錄滑鼠點擊時的座標
		private Point LastLocation;

		//宣告產品BLL
		private ProductBLL Pbll = new ProductBLL();


		//建構函式
		public ProductsForm(EmployeeModel emp)
		{
			InitializeComponent();

			// 傳入登入員工資料
			this.LoginEmployee = emp;

			//綁定滑鼠拖曳事件
			this.MouseDown += new MouseEventHandler(ProductForm_MouseDown);
			this.MouseMove += new MouseEventHandler(ProductForm_MouseMove);
			this.MouseUp += new MouseEventHandler(ProductForm_MouseUp);
			// 遞迴綁定所有子控制項，確保點到任何元件也可拖曳
			AddDragEvents(this.Controls);

		}


		//遞迴綁定所有控制項的拖曳事件
		private void AddDragEvents(Control.ControlCollection controls)
		{
			foreach (Control ctrl in controls)
			{
				ctrl.MouseDown += ProductForm_MouseDown;
				ctrl.MouseMove += ProductForm_MouseMove;
				ctrl.MouseUp += ProductForm_MouseUp;

				// 如果該控制項有子控制項，繼續遞迴綁定
				if (ctrl.HasChildren)
				{
					AddDragEvents(ctrl.Controls);
				}
			}
		}


		//滑鼠按下
		private void ProductForm_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				isDragging = true;
				LastLocation = Cursor.Position;
			}
		}


		//滑鼠移動
		private void ProductForm_MouseMove(object sender, MouseEventArgs e)
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
		private void ProductForm_MouseUp(object sender, MouseEventArgs e)
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
			MessageBox.Show("您已在產品管理畫面。");
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



		//載入事件
		private void ProductsForm_Load(object sender, EventArgs e)
		{

			dgvProduct.AutoGenerateColumns = false;
			ProductBLL Pbll = new ProductBLL();
			dgvProduct.DataSource = Pbll.GetProductList();

			//格式：標題欄文字都置中
			foreach (DataGridViewColumn col in dgvProduct.Columns)
			{
				col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
			}

		}


		//重新載入dgv列表
		private void LoadProducts()
		{
			List<ProductModel> products = Pbll.GetProductList();
			dgvProduct.DataSource = null;              // 清除原本資料來源（避免重複綁定）
			dgvProduct.DataSource = products;          // 指定新的資料來源		}
		}

		//dgv
		private void product_LBSMSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			this.Validate();
			this.product_LBSMSBindingSource.EndEdit();
			//this.tableAdapterManager.UpdateAll(this.bentoSystemDataSet);

		}
		private void product_LBSMSDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
		private void txtProductPrice_TextChanged(object sender, EventArgs e)
		{}
		//點選dgv顯示餐點資訊
		private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e) 
		{
			if (e.RowIndex >= 0)
			{
				var selectedRow = (ProductModel)dgvProduct.Rows[e.RowIndex].DataBoundItem;
				if (selectedRow != null)
				{
					DisplayProductDetails(selectedRow);
				}
			}
		}



		//右上角餐點搜尋
		private void btnProductSearch_Click(object sender, EventArgs e)
		{
			string keyword = txtProductSearch.Text.Trim();
			ProductBLL Pbll = new ProductBLL(); // 建立 BLL 物件
			var product = Pbll.SearchProductByName(keyword);
			if (product != null)
				DisplayProductDetails(product);
			else
				MessageBox.Show("找不到此餐點");
		}


		//在下方顯示餐點資訊
		private void DisplayProductDetails(ProductModel product)
		{
			txtProductId.Text = product.ProductId.ToString();
			txtProductName.Text = product.ProductName;
			txtProductPrice.Text = product.ProductPrice.ToString();
			txtStockQuantity.Text = product.StockQuantity.ToString();
			cbIsOutofstock.Checked = product.IsOutofstock;
			txtProductDesc.Text = product.ProductDesc;

			// 顯示圖片（使用相對路徑）
			if (!string.IsNullOrEmpty(product.ImagePath))
			{
				string fullPath = Path.Combine(Application.StartupPath, product.ImagePath);
				if (File.Exists(fullPath))
				{
					pbProductImage.Image = Image.FromFile(fullPath);
				}
				else
				{
					pbProductImage.Image = null; // 檔案不存在就清空
				}
			}
			else
			{
				pbProductImage.Image = null;
			}
		}


		//清空輸入欄位
		private void ClearInputFields()
		{
			txtProductId.Text = "";
			txtProductName.Text = "";
			txtProductPrice.Text = "";
			txtStockQuantity.Text = "";
			cbIsOutofstock.Checked = false;
			txtProductDesc.Text = "";
			pbProductImage.Text = "";
			pbProductImage.Image = null;
		}


		//新增按鈕
		private void btnProductAdd_Click(object sender, EventArgs e)
		{
			ClearInputFields();
			selectedImagePath = "";
		}

		//圖片上傳按鈕
		private string selectedImagePath = "";
		private void btnProductImageUpload_Click(object sender, EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.Title = "選擇餐點圖片";
			ofd.Filter = "圖片檔案 (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png|所有檔案 (*.*)|*.*";


			if (ofd.ShowDialog() == DialogResult.OK)
			{
				try
				{
					// 確保 Images 資料夾存在（使用相對路徑）
					if (!Directory.Exists("Images"))
					{
						Directory.CreateDirectory("Images");
					}

					// 建立圖片儲存路徑
					string fileName = "ProductImage_" + DateTime.Now.ToString("yyyyMMddHHmmss") + Path.GetExtension(ofd.FileName);
					string imagePath = Path.Combine("Images", fileName);

					// 複製圖片到 Images 資料夾
					File.Copy(ofd.FileName, imagePath, true);

					// 顯示圖片
					pbProductImage.Image = Image.FromFile(imagePath);

					// 儲存相對路徑到變數，之後寫入資料庫用
					selectedImagePath = imagePath;
				}
				catch (Exception ex)
				{
					MessageBox.Show("圖片上傳失敗，請檢查檔案格式或路徑是否正確。\n錯誤原因：" + ex.Message);
				}
			}
		}

		//修改按鈕
		private void btnProductUpdate_Click(object sender, EventArgs e)
		{
			if (dgvProduct.SelectedRows.Count == 0)
			{
				MessageBox.Show("請先選擇要修改的餐點。");
				return;
			}

			var product = (ProductModel)dgvProduct.SelectedRows[0].DataBoundItem;

			txtProductId.Text = product.ProductId.ToString();
			txtProductName.Text = product.ProductName;
			txtProductPrice.Text = product.ProductPrice.ToString();
			txtStockQuantity.Text = product.StockQuantity.ToString();
			cbIsOutofstock.Checked = product.IsOutofstock;
			txtProductDesc.Text = product.ProductDesc;

			selectedImagePath = product.ImagePath;
			if (!string.IsNullOrEmpty(selectedImagePath) && File.Exists(selectedImagePath))
				pbProductImage.Image = Image.FromFile(selectedImagePath);
			else
				pbProductImage.Image = null;
		}


		//刪除按鈕
		private void btnProductDelete_Click(object sender, EventArgs e)
		{
			if (int.TryParse(txtProductId.Text, out int productId))
			{
				var confirm = MessageBox.Show("確定要刪除此餐點嗎？", "刪除確認", MessageBoxButtons.YesNo);
				if (confirm == DialogResult.Yes)
				{
					try
					{
						Pbll.DeleteProduct(productId);       // 呼叫 DeleteProduct
						MessageBox.Show("刪除成功！");
						ClearInputFields();
						selectedImagePath = "";
						LoadProducts(); // 重新載入列表
						pbProductImage.Image = null; // 清空圖片顯示
					}
					catch (Exception ex)
					{
						MessageBox.Show("刪除失敗：" + ex.Message);
					}
				}
			}
			else
			{
				MessageBox.Show("請先選擇要刪除的商品！");
			}
		}


		//儲存按鈕
		private void btnProductSave_Click(object sender, EventArgs e)
		{
			ProductModel product = new ProductModel
			{
				ProductName = txtProductName.Text.Trim(),
				ProductPrice = int.Parse(txtProductPrice.Text.Trim()),
				StockQuantity = int.Parse(txtStockQuantity.Text.Trim()),
				IsOutofstock = cbIsOutofstock.Checked,
				ProductDesc = txtProductDesc.Text.Trim(),
				ImagePath = selectedImagePath
			};

			ProductBLL Pbll = new ProductBLL();

			if (string.IsNullOrEmpty(txtProductId.Text))
			{
				Pbll.AddProduct(product);
				MessageBox.Show("新增成功！");
			}
			else
			{
				product.ProductId = int.Parse(txtProductId.Text);
				Pbll.UpdateProduct(product);
				MessageBox.Show("修改成功！");
			}

			LoadProducts();
			
			ClearInputFields();
			selectedImagePath = "";
			pbProductImage.Image = null;
		}

	}
}
