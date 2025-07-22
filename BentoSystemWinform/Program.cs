using System;
using System.Windows.Forms;
using BentoSystemWinform.DAL;
using BentoSystemWinform.Models;
using BentoSystemWinform.BLL;

namespace BentoSystemWinform
{
	internal static class Program
	{
		// 旗標：是否退出整個應用程式
		public static bool IsExitApp = false;

		/// <summary>
		/// 應用程式的主要進入點。
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			while (true)
			{
				if (IsExitApp)
				{
					break; // 跳出迴圈，結束程式
				}

				EmployeeModel loginEmployee = null;

				using (var loginForm = new LoginForm())
				{
					if (loginForm.ShowDialog() == DialogResult.OK)
					{
						loginEmployee = loginForm.LoginEmployee;
					}
					else
					{
						// 使用者關閉登入視窗或登入失敗 → 結束程式
						break;
					}
				}

				if (IsExitApp)
				{
					break;
				}

				using (var mainForm = new MainForm(loginEmployee))
				{
					Application.Run(mainForm);
				}
			}
		}
	}
}
