using System;
using System.Windows.Forms;

namespace Krokmou_Clicker_v2
{
	// Token: 0x02000009 RID: 9
	internal static class Program
	{
		// Token: 0x0600005A RID: 90 RVA: 0x00002418 File Offset: 0x00000618
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new LoginForm());
		}
	}
}
