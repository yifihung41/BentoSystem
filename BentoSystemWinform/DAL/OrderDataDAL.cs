using BentoSystemWinform.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BentoSystemWinform.DAL
{
	public class OrderDataDAL
	{
		private string connectionString = @"Data Source = desktop-paksetb\sqlexpress;Database = BentoSystem;Trusted_Connection = True;";

		public List<OrderDataModel> GetAllOrderDatas() 
		{
			List<OrderDataModel> orderDatas = new List<OrderDataModel>();
			string sql = "SELECT * FROM OrderData_LBSMS";

			using (SqlConnection conn = new SqlConnection(connectionString))
			using (SqlCommand cmd = new SqlCommand(sql, conn))
			{
				conn.Open();
				using (SqlDataReader reader = cmd.ExecuteReader())
				{
					while (reader.Read())
					{
						OrderDataModel od = new OrderDataModel
						{
							OrderId = Convert.ToInt32(reader["OrderId"] ?? 0),
							MemberId = Convert.ToInt32(reader["MemberId"] ?? 0),
							EmployeeId = Convert.ToInt32(reader["EmployeeId"] ?? 0),
							OrderDate = Convert.ToDateTime(reader["OrderDate"] ?? DateTime.MinValue),
							OrderType = reader["OrderType"]?.ToString() ?? ""
						};
						orderDatas.Add(od);
					}
				}
			return orderDatas;
			}
		}


		public int InsertOrderData(OrderDataModel order)
		{
			int newOrderId = 0;
			string sql = @"
        INSERT INTO OrderData_LBSMS (OrderDate, OrderType, EmployeeId, MemberId)
        VALUES (@OrderDate, @OrderType, @EmployeeId, @MemberId);
        SELECT CAST(SCOPE_IDENTITY() AS int);";

			using (SqlConnection conn = new SqlConnection(connectionString))
			using (SqlCommand cmd = new SqlCommand(sql, conn))
			{
				cmd.Parameters.AddWithValue("@OrderDate", order.OrderDate);
				cmd.Parameters.AddWithValue("@OrderType", order.OrderType);
				cmd.Parameters.AddWithValue("@EmployeeId", order.EmployeeId);
				cmd.Parameters.AddWithValue("@MemberId", order.MemberId);

				conn.Open();
				newOrderId = (int)cmd.ExecuteScalar();
			}

			return newOrderId;
		}

	}
}
