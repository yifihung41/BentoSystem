using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BentoSystemWinform.Models
{
	public class MemberModel
	{
		public int MemberId { get; set; }
		public string MemberName { get; set; }
		public string MemberPhone { get; set; }
		public string MemberAddress { get; set; }
		public DateTime Birthday { get; set; }
		public int Points { get; set; }
	}
}
