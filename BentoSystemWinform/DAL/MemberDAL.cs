using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BentoSystemWinform.Models;
using System.Data.SqlClient;

namespace BentoSystemWinform.DAL
{
	public class MemberDAL
	{
		private string connectionString = @"Data Source = desktop-paksetb\sqlexpress;Database = BentoSystem;Trusted_Connection = True;";

		public List<MemberModel> GetAllMembers() 
		{ 
			List<MemberModel> members = new List<MemberModel>();

			using (SqlConnection conn = new SqlConnection(connectionString))
			{
				string sql = "SELECT * FROM Member_LBSMS";
				SqlCommand cmd = new SqlCommand(sql, conn);
				conn.Open();
				SqlDataReader reader = cmd.ExecuteReader();
				while (reader.Read())
				{
					MemberModel m = new MemberModel
					{
						MemberId = Convert.ToInt32(reader["MemberId"] ?? 0),
						MemberName = reader["MemberName"]?.ToString() ?? "",
						MemberPhone = reader["MemberPhone"]?.ToString() ?? "",
						MemberAddress = reader["MemberAddress"]?.ToString() ?? "",
						Birthday = reader["Birthday"]?.ToString() ?? "",
						Points = Convert.ToInt32(reader["Points"] ?? 0)
					};
					members.Add(m);
				}
			}
			return members;
		}
	}
}
