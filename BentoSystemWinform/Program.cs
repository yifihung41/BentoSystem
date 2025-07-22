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

			// 新增一個外層循環，控制整個應用程式的生命週期
			// 只有當使用者明確選擇退出 (例如點擊 MainFom 的「結束」按鈕) 時，才會退出這個循環
			while (true)
			{
				EmployeeModel loginEmployee = null; // 在每次循環開始時重置登入員工資訊

				// 1. 顯示登入視窗
				using (var loginForm = new LoginForm()) // 確保 LoginForm 資源被釋放
				{
					if (loginForm.ShowDialog() == DialogResult.OK)
					{
						// 取得登入成功的員工資料
						loginEmployee = loginForm.LoginEmployee;
					}
					else
					{
						// 使用者關閉登入視窗或登入失敗 → 結束程式
						return; // 退出 Main 方法，從而終止整個應用程式
					}
				}

				// 2. 開啟主畫面並傳入登入員工
				using (var mainForm = new MainForm(loginEmployee)) // 確保 MainForm 資源被釋放
				{
					// Application.Run() 會阻塞，直到 mainForm 被關閉
					Application.Run(mainForm);
				}
				// 當 mainForm 被關閉後 (例如使用者點擊了登出按鈕)，
				// 執行會回到這裡，然後 while(true) 會讓它再次循環，顯示 LoginForm。
				// 如果 mainForm 是因為 Application.Exit() 而關閉的，
				// 那麼整個應用程式會退出，不會回到這裡。
			}
		}
	}
}