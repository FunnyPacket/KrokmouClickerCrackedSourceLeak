using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Krokmou_Clicker_v2
{
	// Token: 0x02000008 RID: 8
	public partial class ProfileForm : Form
	{
		// Token: 0x06000054 RID: 84 RVA: 0x000023CC File Offset: 0x000005CC
		public ProfileForm()
		{
			this.InitializeComponent();
			this.SetProfile();
			this.setSettings();
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00007F4C File Offset: 0x0000614C
		private void SetProfile()
		{
			this.ProfileUsername.Text = MainForm.UsernameInfo;
			this.ProfileID.Text = MainForm.UserIDInfo;
			bool flag = MainForm.UserRankInfo == "Owner";
			if (flag)
			{
				this.ProfileRank.Text = "Owner";
				this.ProfileRank.ForeColor = Color.Red;
			}
			else
			{
				bool flag2 = MainForm.UserRankInfo == "Friend";
				if (flag2)
				{
					this.ProfileRank.Text = "Friend";
					this.ProfileRank.ForeColor = Color.Cyan;
				}
				else
				{
					bool flag3 = MainForm.UserRankInfo == "Customer";
					if (flag3)
					{
						this.ProfileRank.Text = "Customer";
						this.ProfileRank.ForeColor = Color.Green;
					}
				}
			}
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00008028 File Offset: 0x00006228
		private void setSettings()
		{
			this.Red = Convert.ToInt32(MainForm.tb_red * 2.55);
			this.Green = Convert.ToInt32(MainForm.tb_green * 2.55);
			this.Blue = Convert.ToInt32(MainForm.tb_blue * 2.55);
			this.ApplySettings();
		}

		// Token: 0x06000057 RID: 87 RVA: 0x000023F2 File Offset: 0x000005F2
		private void ApplySettings()
		{
			this.DecorationUsername.BackColor = Color.FromArgb(this.Red, this.Green, this.Blue);
		}

		// Token: 0x0400007A RID: 122
		private int Red;

		// Token: 0x0400007B RID: 123
		private int Green;

		// Token: 0x0400007C RID: 124
		private int Blue;
	}
}
