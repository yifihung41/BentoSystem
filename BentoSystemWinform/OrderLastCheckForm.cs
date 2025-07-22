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
using BentoSystemWinform.BLL;
using BentoSystemWinform.Models;
using System.Data.SqlClient;

namespace BentoSystemWinform
{
	public partial class OrderLastCheckForm : Form
	{
		private List<OrderItemTempModel> _orderItems;
		private decimal _total;
		private bool _allowSubmit;

		public OrderLastCheckForm(List<OrderItemTempModel> orderItems, decimal total, string MemberName, string MemberPhone, string OrderType, DateTime OrderTime, int pointEarned, int Points, bool allowSubmit = true)
		{
			InitializeComponent();

			_orderItems = orderItems ?? new List<OrderItemTempModel>();
			_total = total;
			_allowSubmit = allowSubmit;

			SetupDataGridView();
			BindData();
			ConfigureButtons();

			// ✅ 顯示基本資訊：會員資料、訂購方式、時間、點數
			lblCustomerName.Text = $"姓名：{MemberName}";
			lblCustomerPhone.Text = $"電話：{MemberPhone}";
			lblOrderType.Text = $"訂購方式：{OrderType}";
			lblOrderTime.Text = $"下單時間：{OrderTime:yyyy/MM/dd HH:mm:ss}";
			lblEarnedPoints.Text = $"獲得點數：{pointEarned} 點";
			lblUpdatedPoints.Text = $"加總後總點數：{Points} 點";
		}

		private void SetupDataGridView()
		{
			dgvOrderDetails.AutoGenerateColumns = false;
			dgvOrderDetails.Columns.Clear();

			dgvOrderDetails.Columns.Add(new DataGridViewTextBoxColumn
			{
				HeaderText = "品項",
				DataPropertyName = "ProductName",
				Width = 150
			});
			dgvOrderDetails.Columns.Add(new DataGridViewTextBoxColumn
			{
				HeaderText = "單價",
				DataPropertyName = "ProductPrice",
				Width = 100,
				DefaultCellStyle = new DataGridViewCellStyle { Format = "C0" }
			});
			dgvOrderDetails.Columns.Add(new DataGridViewTextBoxColumn
			{
				HeaderText = "數量",
				DataPropertyName = "Quantity",
				Width = 80
			});

			dgvOrderDetails.ReadOnly = true;
			dgvOrderDetails.AllowUserToAddRows = false;
			dgvOrderDetails.AllowUserToDeleteRows = false;
			dgvOrderDetails.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		}

		private void BindData()
		{
			dgvOrderDetails.DataSource = null;
			dgvOrderDetails.DataSource = _orderItems;

			labelTotalAmount.Text = $"總金額：{_total:C0} 元";
			labelTotalAmount.Font = new Font(labelTotalAmount.Font.FontFamily, 14, FontStyle.Bold);
		}

		private void ConfigureButtons()
		{
			btnSubmit.Visible = _allowSubmit;
			btnSubmit.Enabled = _allowSubmit;

			if (_allowSubmit)
			{
				labelMode.Text = "訂單確認（請確認後送出）";
				labelMode.ForeColor = Color.White;
			}
			else
			{
				labelMode.Text = "訂單預覽（僅供參考不可送出）";
				labelMode.ForeColor = Color.White;
			}
		}

		private void btnSubmit_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.OK;
			this.Hide();
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Hide();
		}

		private void labelTotalAmount_Click(object sender, EventArgs e)
		{

		}

		private void dgvOrderDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}

	// 訂單明細 Model，屬性名稱對應UI
	public class OrderItemTempModel
	{
		public int ProductId { get; set; }
		public string ProductName { get; set; }
		public decimal ProductPrice { get; set; }
		public int Quantity { get; set; }
		public bool Spicy { get; set; }

		public decimal Subtotal => ProductPrice * Quantity;
	}
}


