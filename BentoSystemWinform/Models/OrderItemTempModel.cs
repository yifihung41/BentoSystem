using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BentoSystemWinform.DAL;
using BentoSystemWinform.BLL;
using BentoSystemWinform.Models;
using System.Data.SqlClient;

namespace BentoSystem.Models
{
	public class OrderItemTempModel
	{
		public int ProductId { get; set; }
		public string ProductName { get; set; }
		public int Quantity { get; set; }
		public decimal UnitPrice { get; set; }
		public bool IsSpicy { get; set; }

		// 小計 = 數量 × 單價
		public decimal Subtotal => Quantity * UnitPrice;
	}
}

