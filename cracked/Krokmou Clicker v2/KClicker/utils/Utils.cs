using System;
using System.IO;
using System.Media;
using System.Threading.Tasks;
using Krokmou_Clicker_v2.Properties;

namespace KClicker.utils
{
	// Token: 0x02000003 RID: 3
	internal class Utils
	{
		// Token: 0x06000007 RID: 7 RVA: 0x00002060 File Offset: 0x00000260
		public static void SendLeftClick()
		{
			Imports.SendMessage(Imports.GetForegroundWindow(), 513, 0, 0);
			Task.Delay(1).Wait();
			Imports.SendMessage(Imports.GetForegroundWindow(), 514, 0, 0);
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002093 File Offset: 0x00000293
		public static void SendLeftClickBreak()
		{
			Imports.SendMessage(Imports.GetForegroundWindow(), 514, 0, 0);
			Imports.SendMessage(Imports.GetForegroundWindow(), 513, 0, 0);
		}

		// Token: 0x06000009 RID: 9 RVA: 0x000020BA File Offset: 0x000002BA
		public static void SendRightClick()
		{
			Imports.SendMessage(Imports.GetForegroundWindow(), 516, 0, 0);
			Task.Delay(1).Wait();
			Imports.SendMessage(Imports.GetForegroundWindow(), 517, 0, 0);
		}

		// Token: 0x0600000A RID: 10 RVA: 0x000025E0 File Offset: 0x000007E0
		public static void ClickSound()
		{
			Stream @default = Resources.Default;
			new SoundPlayer(@default).Play();
		}

		// Token: 0x0600000B RID: 11 RVA: 0x000025E0 File Offset: 0x000007E0
		public static void RightClickSound()
		{
			Stream @default = Resources.Default;
			new SoundPlayer(@default).Play();
		}
	}
}
