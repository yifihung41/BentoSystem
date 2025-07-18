using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BentoSystemWinform.Models
{
	public class ProductModel
	{
		public int ProductId { get; set; }
		public string ProductName { get; set; }
		public int ProductPrice { get; set; }
		public int StockQuantity { get; set; }
		public bool IsOutofstock { get; set; }
		public string ProductDesc { get; set; }
		public string ImagePath { get; set; }


	}
}
