using BentoSystemWinform.Models;
using System;
using System.Collections.Generic;
using System.Data.Common;
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


		// 取得產品清單（資料層）
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
					list.Add(p);
				}
			}
			return list;
		}

		//新增商品
		public int InsertProduct(ProductModel product)
		{
			string sql = @"INSERT INTO Product_LBSMS
                       (ProductName, ProductPrice, StockQuantity, IsOutOfStock, ProductDesc, ImagePath)
                       VALUES
                       (@ProductName, @ProductPrice, @StockQuantity, @IsOutOfStock, @ProductDesc, @ImagePath)";

			using (SqlConnection conn = new SqlConnection(connectionString))
			using (SqlCommand cmd = new SqlCommand(sql, conn))
			{
				cmd.Parameters.AddWithValue("@ProductName", product.ProductName);
				cmd.Parameters.AddWithValue("@ProductPrice", product.ProductPrice);
				cmd.Parameters.AddWithValue("@StockQuantity", product.StockQuantity);
				cmd.Parameters.AddWithValue("@IsOutOfStock", product.IsOutofstock);
				cmd.Parameters.AddWithValue("@ProductDesc", product.ProductDesc ?? "");
				cmd.Parameters.AddWithValue("@ImagePath", product.ImagePath ?? "");

				conn.Open();
				return cmd.ExecuteNonQuery();
			}
		}

		// 修改商品
		public int UpdateProduct(ProductModel product)
		{
			string sql = @"UPDATE Product_LBSMS SET
                       ProductName=@ProductName,
                       ProductPrice=@ProductPrice,
                       StockQuantity=@StockQuantity,
                       IsOutOfStock=@IsOutOfStock,
                       ProductDesc=@ProductDesc,
                       ImagePath=@ImagePath
                       WHERE ProductId=@ProductId";

			using (SqlConnection conn = new SqlConnection(connectionString))
			using (SqlCommand cmd = new SqlCommand(sql, conn))
			{
				cmd.Parameters.AddWithValue("@ProductName", product.ProductName);
				cmd.Parameters.AddWithValue("@ProductPrice", product.ProductPrice);
				cmd.Parameters.AddWithValue("@StockQuantity", product.StockQuantity);
				cmd.Parameters.AddWithValue("@IsOutOfStock", product.IsOutofstock);
				cmd.Parameters.AddWithValue("@ProductDesc", product.ProductDesc ?? "");
				cmd.Parameters.AddWithValue("@ImagePath", product.ImagePath ?? "");
				cmd.Parameters.AddWithValue("@ProductId", product.ProductId);

				conn.Open();
				return cmd.ExecuteNonQuery();
			}
		}

		// 刪除商品
		public int DeleteProduct(int productId)
		{
			string sql = "DELETE FROM Product_LBSMS WHERE ProductId = @ProductId";

			using (SqlConnection conn = new SqlConnection(connectionString))
			using (SqlCommand cmd = new SqlCommand(sql, conn))
			{
				cmd.Parameters.AddWithValue("@ProductId", productId);
				conn.Open();
				return cmd.ExecuteNonQuery();
			}
		}

		//搜尋商品
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

		// 更新商品庫存數量
		public void UpdateProductStock(int productId, int quantityToDeduct)
		{
			using (SqlConnection conn = new SqlConnection(connectionString))
			{
				string sql = "UPDATE Product_LBSMS SET StockQuantity = StockQuantity - @Quantity WHERE ProductId = @ProductId";
				SqlCommand cmd = new SqlCommand(sql, conn);
				cmd.Parameters.AddWithValue("@Quantity", quantityToDeduct);
				cmd.Parameters.AddWithValue("@ProductId", productId);

				conn.Open();
				cmd.ExecuteNonQuery();
			}
		}
	}
}