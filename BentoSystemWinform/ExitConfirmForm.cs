using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BentoSystemWinform
{
	public partial class ExitConfirmForm : Form
	{
		public ExitConfirmForm()
		{
			InitializeComponent();
		}

		private void btnExitBack_Click(object sender, EventArgs e)
		{
			//只關閉此小視窗
			this.DialogResult = DialogResult.Cancel;
			this.Hide();
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			//關閉整個程式
			this.DialogResult = DialogResult.OK;
			this.Close();
		}
	}
}
