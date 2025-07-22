using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BentoSystemWinform.Models
{
	public static class FormSwitcher
	{
		public static void SafeSwitchTo(Form currentForm, Form nextForm)
		{
			currentForm.Hide();
			using (nextForm)
			{
				nextForm.ShowDialog();
			}
			if (!currentForm.IsDisposed)
			{
				currentForm.Show();
			}
		}

		public static void SafeLogout(Form currentForm)
		{
			currentForm.Hide();
			using (LoginForm loginForm = new LoginForm())
			{
				loginForm.ShowDialog();
			}
			if (!currentForm.IsDisposed)
			{
				currentForm.Close();
			}
		}
	}
}
