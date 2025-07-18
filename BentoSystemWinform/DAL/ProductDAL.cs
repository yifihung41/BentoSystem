using BentoSystemWinform.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BentoSystemWinform.DAL
{
	public class ProductDAL
	{
		private string connectionString = @"Data Source = desktop-paksetb\sqlexpress;Database = BentoSystem;Trusted_Connection = True;";
		public List<ProductModel> GetAllProducts() 
		{ 
			List<ProductModel> list = new List<ProductModel>();

			using (SqlConnection conn = new SqlConnection(connectionString))
			{
				string sql = "SELECT * FROM Product_LBSMS";
				SqlCommand cmd = new SqlCommand(sql, conn);
				conn.Open();
				SqlDataReader reader = cmd.ExecuteReader();

				while (reader.Read())
				{
					ProductModel p = new ProductModel
					{
						ProductId = reader["ProductId"] != DBNull.Value ? Convert.ToInt32(reader["ProductId"]) : 0,
						ProductName = reader["ProductName"]?.ToString() ?? "",
						ProductPrice = reader["ProductPrice"] != DBNull.Value ? Convert.ToInt32(reader["ProductPrice"]) : 0,
						StockQuantity = reader["StockQuantity"] != DBNull.Value ? Convert.ToInt32(reader["StockQuantity"]) : 0,
						IsOutofstock = reader["IsOutOfStock"] != DBNull.Value && Convert.ToBoolean(reader["IsOutOfStock"]),
						ProductDesc = reader["ProductDesc"]?.ToString() ?? "",
						ImagePath = reader["ImagePath"]?.ToString() ?? ""
					 };
					list.Add(p); // 修正：將建立的 ProductModel 加入清單
				}
			}
			return list; // 修正：確保方法返回清單
		}

		//傳入ProductModel物件，將資料寫入資料庫
		public void InsertProduct(ProductModel product)
		{
			using (SqlConnection conn = new SqlConnection(connectionString))
			{
				string sql = @"INSERT INTO Product_LBSMS 
        (ProductName, ProductPrice, StockQuantity, IsOutOfStock, ProductDesc, ImagePath)
        VALUES (@Name, @Price, @Stock, @IsOut, @Desc, @ImagePath)";
				SqlCommand cmd = new SqlCommand(sql, conn);
				cmd.Parameters.AddWithValue("@Name", product.ProductName);
				cmd.Parameters.AddWithValue("@Price", product.ProductPrice);
				cmd.Parameters.AddWithValue("@Stock", product.StockQuantity);
				cmd.Parameters.AddWithValue("@IsOut", product.IsOutofstock);
				cmd.Parameters.AddWithValue("@Desc", product.ProductDesc);
				cmd.Parameters.AddWithValue("@ImagePath", product.ImagePath ?? (object)DBNull.Value);
				conn.Open();
				cmd.ExecuteNonQuery();
			}
		}

		//用關鍵字搜尋餐點名稱
		public ProductModel GetProductByName(string keyword)
		{
			using (SqlConnection conn = new SqlConnection(connectionString))
			{
				string sql = "SELECT TOP 1 * FROM Product_LBSMS WHERE ProductName LIKE @Keyword";
				SqlCommand cmd = new SqlCommand(sql, conn);
				cmd.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");

				conn.Open();
				SqlDataReader reader = cmd.ExecuteReader();

				if (reader.Read())
				{
					return new ProductModel
					{
						ProductId = reader["ProductId"] != DBNull.Value ? Convert.ToInt32(reader["ProductId"]) : 0,
						ProductName = reader["ProductName"]?.ToString() ?? "",
						ProductPrice = reader["ProductPrice"] != DBNull.Value ? Convert.ToInt32(reader["ProductPrice"]) : 0,
						StockQuantity = reader["StockQuantity"] != DBNull.Value ? Convert.ToInt32(reader["StockQuantity"]) : 0,
						IsOutofstock = reader["IsOutOfStock"] != DBNull.Value && Convert.ToBoolean(reader["IsOutOfStock"]),
						ProductDesc = reader["ProductDesc"]?.ToString() ?? "",
						ImagePath = reader["ImagePath"]?.ToString() ?? ""
					};
				}
			}

			return null; // 找不到就傳回 null
		}

	}
}