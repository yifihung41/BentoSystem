using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BentoSystemWinform.Models;
using System.Data.SqlClient;

namespace BentoSystemWinform.DAL
{
	public class EmployeeDAL
	{
		private string connectionString = @"Data Source = desktop-paksetb\sqlexpress;Database = BentoSystem;Trusted_Connection = True;";

		public List<EmployeeModel> GetAllEmployees() 
		{ 
			List<EmployeeModel> employees = new List<EmployeeModel>();
			using (SqlConnection conn = new SqlConnection(connectionString))
			{
				string sql = "SELECT * FROM Employee_LBSMS";
				SqlCommand cmd = new SqlCommand(sql, conn);
				conn.Open();
				SqlDataReader reader = cmd.ExecuteReader();
				
				while (reader.Read())
				{
					EmployeeModel e = new EmployeeModel
					{
						EmployeeId = Convert.ToInt32(reader["EmployeeId"] ?? 0),
						Account = reader["Account"]?.ToString() ?? "",
						Password = reader["Password"]?.ToString() ?? ""
					};
					employees.Add(e);
				}
			}
			return employees;
		}

		public EmployeeModel GetEmployeeByAccount(string account)
		{
			using (SqlConnection conn = new SqlConnection(connectionString))
			{
				string sql = "SELECT * FROM Employee_LBSMS WHERE Account = @Account";
				SqlCommand cmd = new SqlCommand(sql, conn);
				cmd.Parameters.AddWithValue("@Account", account);
				
				conn.Open();
				SqlDataReader reader = cmd.ExecuteReader();
				
				if (reader.Read())
				{
					return new EmployeeModel
					{
						EmployeeId = Convert.ToInt32(reader["EmployeeId"]),
						Account = reader["Account"]?.ToString(),
						Password = reader["Password"]?.ToString()
					};
				}
			}
			return null;
		}
	}
}
