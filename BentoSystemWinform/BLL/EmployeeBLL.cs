using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BentoSystemWinform.Models;
using System.Data.SqlClient;
using BentoSystemWinform.DAL;

namespace BentoSystemWinform.BLL
{
	public class EmployeeBLL
	{
		private EmployeeDAL Edal = new EmployeeDAL();
		public List<EmployeeModel> GetEmployeeList() 
		{
			return Edal.GetAllEmployees();
		}
	}
}
