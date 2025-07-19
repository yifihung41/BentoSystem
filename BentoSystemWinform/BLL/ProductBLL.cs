using BentoSystemWinform.DAL;
using BentoSystemWinform.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BentoSystemWinform.BLL
{
	public class ProductBLL
	{
		private ProductDAL Pdal = new ProductDAL();

		// 取得所有商品列表
		public List<ProductModel> GetProductList()
		{
			return Pdal.GetAllProducts();
		}

		// 新增商品
		public void AddProduct(ProductModel product)
		{
			Pdal.InsertProduct(product);
		}

		// 更新商品
		public void UpdateProduct(ProductModel product)
		{
			Pdal.UpdateProduct(product);
		}

		// 刪除商品
		public void DeleteProduct(int productId)
		{
			Pdal.DeleteProduct(productId);
		}

		// 搜尋商品
		public ProductModel SearchProductByName(string keyword) 
		{
			return Pdal.GetProductByName(keyword);
		}
	}
}
