using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using BentoSystemWinform.DAL;
using BentoSystemWinform.Models;
using System.Windows.Forms;

namespace BentoSystemWinform.BLL
{
	public class MemberBLL
	{
		private MemberDAL Mdal = new MemberDAL();

		// 取得所有會員列表
		public List<MemberModel> GetMemberList() 
		{
			return Mdal.GetAllMembers();
		}

		// 新增會員
		public void InsertMember(MemberModel member)
		{
			Mdal.InsertMember(member);
		}

		// 更新會員
		public void UpdateMember(MemberModel member)
		{
			Mdal.UpdateMember(member);
		}

		// 刪除會員
		public void DeleteMember(int memberId)
		{
			Mdal.DeleteMember(memberId);
		}

		// 搜尋會員
		public List<MemberModel> SearchMemberByName(string keyword)
		{
			return Mdal.SearchMembers(keyword); 
		}
	}
}
