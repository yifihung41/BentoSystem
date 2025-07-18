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
		public List<ProductModel> GetProductList()
		{
			return Pdal.GetAllProducts();
		}
		public void AddProduct(ProductModel product)
		{
			Pdal.InsertProduct(product);
		}

		public ProductModel SearchProductByName(string keyword) 
		{
			return Pdal.GetProductByName(keyword);
		}
	}
}
