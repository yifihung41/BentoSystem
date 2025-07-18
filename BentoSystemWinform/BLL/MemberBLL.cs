using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using BentoSystemWinform.DAL;
using BentoSystemWinform.Models;

namespace BentoSystemWinform.BLL
{
	public class MemberBLL
	{
		private MemberDAL Mdal = new MemberDAL();
		public List<MemberModel> GetMemberList() 
		{
			return Mdal.GetAllMembers();
		}
	}
}
