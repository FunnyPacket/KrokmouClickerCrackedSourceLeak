using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace KClicker.utils
{
	// Token: 0x02000002 RID: 2
	public class Imports
	{
		// Token: 0x06000002 RID: 2
		[DllImport("user32.dll")]
		public static extern IntPtr GetForegroundWindow();

		// Token: 0x06000003 RID: 3
		[DllImport("user32.dll", SetLastError = true)]
		public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

		// Token: 0x06000004 RID: 4
		[DllImport("User32.Dll", EntryPoint = "PostMessageA")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

		// Token: 0x06000005 RID: 5
		[DllImport("User32.dll")]
		public static extern short GetAsyncKeyState(Keys vKey);
	}
}
