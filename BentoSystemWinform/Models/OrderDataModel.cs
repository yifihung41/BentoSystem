using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BentoSystemWinform.Models
{
	public class OrderDataModel
	{
		public int OrderId { get; set; }
		public int MemberId { get; set; }
		public int EmployeeId { get; set; }
		public DateTime OrderDate { get; set; }
		public string OrderType { get; set; }

		public decimal Discount{ get; set; }
		public decimal Total { get; set; }
	}
}
