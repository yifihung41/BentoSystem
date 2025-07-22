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

		//取得所有會員資料
		public List<MemberModel> GetAllMembers() 
		{ 
			List<MemberModel> list = new List<MemberModel>();

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
						MemberId = reader["MemberId"] != DBNull.Value ? Convert.ToInt32(reader["MemberId"]) : 0,
						MemberName = reader["MemberName"]?.ToString() ?? "",
						MemberPhone = reader["MemberPhone"]?.ToString() ?? "",
						MemberAddress = reader["MemberAddress"]?.ToString() ?? "",
						Birthday = reader["Birthday"] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(reader["Birthday"]),
						Points = reader["Points"] != DBNull.Value ? Convert.ToInt32(reader["Points"]) : 0
					};
					list.Add(m);
				}
			}
			return list;
		}

		//新增會員
		public int InsertMember(MemberModel member)
		{
			string sql = @"INSERT INTO Member_LBSMS 
                       (MemberName, MemberPhone, MemberAddress, Birthday, Points) 
                       VALUES (@MemberName, @MemberPhone, @MemberAddress, @Birthday, @Points)";

			using (SqlConnection conn = new SqlConnection(connectionString))
			using (SqlCommand cmd = new SqlCommand(sql, conn))
			{
				cmd.Parameters.AddWithValue("@MemberName", member.MemberName);
				cmd.Parameters.AddWithValue("@MemberPhone", member.MemberPhone);
				cmd.Parameters.AddWithValue("@MemberAddress", member.MemberAddress);
				cmd.Parameters.AddWithValue("@Birthday", member.Birthday);
				cmd.Parameters.AddWithValue("@Points", member.Points);
				
				conn.Open();
				return cmd.ExecuteNonQuery(); // 返回受影響的行數
			}
		}

		//修改會員
		public int UpdateMember(MemberModel member) 
		{
			string sql = @"UPDATE Member_LBSMS 
							SET MemberName = @MemberName, 
								MemberPhone = @MemberPhone, 
								MemberAddress = @MemberAddress, 
								Birthday = @Birthday, 
								Points = @Points 
							WHERE MemberId = @MemberId";
			
			using (SqlConnection conn = new SqlConnection(connectionString))
			using (SqlCommand cmd = new SqlCommand(sql, conn))
			{
				cmd.Parameters.AddWithValue("@MemberId", member.MemberId);
				cmd.Parameters.AddWithValue("@MemberName", member.MemberName);
				cmd.Parameters.AddWithValue("@MemberPhone", member.MemberPhone);
				cmd.Parameters.AddWithValue("@MemberAddress", member.MemberAddress);
				cmd.Parameters.AddWithValue("@Birthday", member.Birthday);
				cmd.Parameters.AddWithValue("@Points", member.Points);
				conn.Open();
				return cmd.ExecuteNonQuery(); // 返回受影響的行數
			}
		}

		//刪除會員
		public int DeleteMember(int memberId)
		{
			string sql = @"DELETE FROM Member_LBSMS WHERE MemberId = @MemberId";

			using (SqlConnection conn = new SqlConnection(connectionString))
			using (SqlCommand cmd = new SqlCommand(sql, conn))
			{
				cmd.Parameters.AddWithValue("@MemberId", memberId);
				conn.Open();
				return cmd.ExecuteNonQuery(); // 返回受影響的行數
			}
		}

		//查詢會員
		public List<MemberModel> SearchMembers(string keyword)
		{
			List<MemberModel> list = new List<MemberModel>();
			string sql = @"SELECT * FROM Member_LBSMS 
						   WHERE MemberName LIKE @Keyword 
						   OR MemberPhone LIKE @Keyword 
						   OR MemberAddress LIKE @Keyword";
			using (SqlConnection conn = new SqlConnection(connectionString))
			using (SqlCommand cmd = new SqlCommand(sql, conn))
			{
				cmd.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");
				conn.Open();
				SqlDataReader reader = cmd.ExecuteReader();
				while (reader.Read())
				{
					MemberModel m = new MemberModel
					{
						MemberId = reader["MemberId"] != DBNull.Value ? Convert.ToInt32(reader["MemberId"]) : 0,
						MemberName = reader["MemberName"]?.ToString() ?? "",
						MemberPhone = reader["MemberPhone"]?.ToString() ?? "",
						MemberAddress = reader["MemberAddress"]?.ToString() ?? "",
						Birthday = reader["Birthday"] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(reader["Birthday"]),
						Points = reader["Points"] != DBNull.Value ? Convert.ToInt32(reader["Points"]) : 0
					};
					list.Add(m);
				}
			}
			return list;
		}

		//會員累積點數
		public void AddPointsToMember(int memberId, int pointsToAdd)
		{
			string sql = "UPDATE Member_LBSMS SET Points = Points + @Points WHERE MemberId = @MemberId";

			using (SqlConnection conn = new SqlConnection(connectionString))
			using (SqlCommand cmd = new SqlCommand(sql, conn))
			{
				cmd.Parameters.AddWithValue("@Points", pointsToAdd);
				cmd.Parameters.AddWithValue("@MemberId", memberId);

				conn.Open();
				cmd.ExecuteNonQuery();
			}
		}
	}
}
