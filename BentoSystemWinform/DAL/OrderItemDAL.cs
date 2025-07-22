using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BentoSystemWinform.Models;
using System.Data.SqlClient;


namespace BentoSystemWinform.DAL
{
	public class OrderItemDAL
	{
		private string connectionString = @"Data Source = desktop-paksetb\sqlexpress;Database = BentoSystem;Trusted_Connection = True;";

		public List<OrderItemModel> GetAllOrderItems()
		{ 
			List<OrderItemModel> orderItems = new List<OrderItemModel>();

			using (SqlConnection conn = new SqlConnection(connectionString))
			{
				string sql = "SELECT * FROM OrderItem_LBSMS";
				SqlCommand cmd = new SqlCommand(sql, conn);
				conn.Open();
				SqlDataReader reader = cmd.ExecuteReader();
				while (reader.Read())
				{
					OrderItemModel oi = new OrderItemModel
					{
						OrderItemId = Convert.ToInt32(reader["OrderItemId"] ?? 0),
						OrderId = Convert.ToInt32(reader["OrderId"] ?? 0),
						ProductId = Convert.ToInt32(reader["ProductId"] ?? 0),
						Quantity = Convert.ToInt32(reader["Quantity"] ?? 0),
						Spicy = Convert.ToBoolean(reader["Spicy"] ?? false)
					};
					orderItems.Add(oi);
				}
			}
		return orderItems;
		}

		public void InsertOrderItem(OrderItemModel orderItem)
		{
			string sql = @"
            INSERT INTO OrderItem_LBSMS (OrderId, ProductId, Quantity, Spicy)
            VALUES (@OrderId, @ProductId, @Quantity, @Spicy);";

			using (SqlConnection conn = new SqlConnection(connectionString))
			using (SqlCommand cmd = new SqlCommand(sql, conn))
			{
				cmd.Parameters.AddWithValue("@OrderId", orderItem.OrderId);
				cmd.Parameters.AddWithValue("@ProductId", orderItem.ProductId);
				cmd.Parameters.AddWithValue("@Quantity", orderItem.Quantity);
				cmd.Parameters.AddWithValue("@Spicy", orderItem.Spicy);

				conn.Open();
				cmd.ExecuteNonQuery();
			}
		}
	}
}
