using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BentoSystemWinform.DAL;
using BentoSystemWinform.Models;
using BentoSystemWinform.BLL;

namespace BentoSystemWinform
{
	internal static class Program
	{
		/// <summary>
		/// 應用程式的主要進入點。
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			EmployeeModel loginEmployee = null;

			using (var loginForm = new LoginForm())
			{
				if (loginForm.ShowDialog() == DialogResult.OK)
				{
					// 取得登入成功的員工資料
					loginEmployee = loginForm.LoginEmployee;
				}
				else
				{
					// 使用者關閉登入視窗或登入失敗 → 結束程式
					return;
				}
			}

			// 開啟主畫面並傳入登入員工
			Application.Run(new MainForm(loginEmployee));
		}
	}
}