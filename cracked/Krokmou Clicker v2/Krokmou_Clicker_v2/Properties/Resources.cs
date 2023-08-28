using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Krokmou_Clicker_v2.Properties
{
	// Token: 0x0200000C RID: 12
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
	[DebuggerNonUserCode]
	[CompilerGenerated]
	internal class Resources
	{
		// Token: 0x06000071 RID: 113 RVA: 0x0000259B File Offset: 0x0000079B
		internal Resources()
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000072 RID: 114 RVA: 0x0000AE5C File Offset: 0x0000905C
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				bool flag = Resources.resourceMan == null;
				if (flag)
				{
					ResourceManager resourceManager = new ResourceManager("Krokmou_Clicker_v2.Properties.Resources", typeof(Resources).Assembly);
					Resources.resourceMan = resourceManager;
				}
				return Resources.resourceMan;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000073 RID: 115 RVA: 0x0000AEA4 File Offset: 0x000090A4
		// (set) Token: 0x06000074 RID: 116 RVA: 0x000025A5 File Offset: 0x000007A5
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return Resources.resourceCulture;
			}
			set
			{
				Resources.resourceCulture = value;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000075 RID: 117 RVA: 0x0000AEBC File Offset: 0x000090BC
		internal static UnmanagedMemoryStream Default
		{
			get
			{
				return Resources.ResourceManager.GetStream("Default", Resources.resourceCulture);
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000076 RID: 118 RVA: 0x0000AEE4 File Offset: 0x000090E4
		internal static Bitmap discordBtn_off
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("discordBtn_off", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000077 RID: 119 RVA: 0x0000AF14 File Offset: 0x00009114
		internal static Bitmap discordBtn_on
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("discordBtn_on", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000078 RID: 120 RVA: 0x0000AF44 File Offset: 0x00009144
		internal static UnmanagedMemoryStream KrokmouLaunch
		{
			get
			{
				return Resources.ResourceManager.GetStream("KrokmouLaunch", Resources.resourceCulture);
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000079 RID: 121 RVA: 0x0000AF6C File Offset: 0x0000916C
		internal static Bitmap mini_discordBtn_off
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("mini_discordBtn_off", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600007A RID: 122 RVA: 0x0000AF9C File Offset: 0x0000919C
		internal static Bitmap mini_discordBtn_on
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("mini_discordBtn_on", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x040000B1 RID: 177
		private static ResourceManager resourceMan;

		// Token: 0x040000B2 RID: 178
		private static CultureInfo resourceCulture;
	}
}
