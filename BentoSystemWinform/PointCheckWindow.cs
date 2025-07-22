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
	public partial class PointCheckWindow : Form
	{
		public PointCheckWindow(string memberName, int points)
		{
			InitializeComponent();

			labelPCName.Text = memberName;
			labelPCPoints.Text = points.ToString();
		}

		private void gbPointCheck_Enter(object sender, EventArgs e)
		{

		}
	}
}
