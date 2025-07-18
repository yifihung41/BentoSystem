
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BentoSystemWinform.DAL;
using BentoSystemWinform.Models;

namespace BentoSystemWinform.BLL
{
	public class OrderDataBLL
	{
		private OrderDataDAL Odal = new OrderDataDAL();
		public List<OrderDataModel> GetAllOrderDatas()
		{
			return Odal.GetAllOrderDatas();
		}
	}
}
