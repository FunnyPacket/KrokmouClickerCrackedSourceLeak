using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace Krokmou_Clicker_v2
{
	// Token: 0x02000005 RID: 5
	public partial class LeftClickerForm : Form
	{
		// Token: 0x06000029 RID: 41 RVA: 0x0000227D File Offset: 0x0000047D
		public LeftClickerForm()
		{
			this.InitializeComponent();
			this.setSettings();
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00003C94 File Offset: 0x00001E94
		private void setSettings()
		{
			this.btnToggleLeft.Checked = MainForm.left_Click;
			this.MinLCPS_TB.Value = MainForm.left_Min;
			this.MaxLCPS_TB.Value = MainForm.left_Max;
			this.CPSLeft_Label.Text = this.MinLCPS_TB.Value.ToString() + " - " + this.MaxLCPS_TB.Value.ToString() + " CPS";
			this.LeftBreak_Check.Checked = MainForm.left_Break;
			this.ClickSound_Check.Checked = MainForm.left_Sound;
			this.Red = Convert.ToInt32(MainForm.tb_red * 2.55);
			this.Green = Convert.ToInt32(MainForm.tb_green * 2.55);
			this.Blue = Convert.ToInt32(MainForm.tb_blue * 2.55);
			this.ApplySettings();
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00003D90 File Offset: 0x00001F90
		private void ApplySettings()
		{
			this.Decoration_LeftClicker.BackColor = Color.FromArgb(this.Red, this.Green, this.Blue);
			this.btnToggleLeft.CheckedState.BorderColor = Color.FromArgb(this.Red, this.Green, this.Blue);
			this.btnToggleLeft.CheckedState.FillColor = Color.FromArgb(this.Red, this.Green, this.Blue);
			this.MinLCPS_TB.ThumbColor = Color.FromArgb(this.Red, this.Green, this.Blue);
			this.MaxLCPS_TB.ThumbColor = Color.FromArgb(this.Red, this.Green, this.Blue);
			this.LeftBreak_Check.CheckedState.BorderColor = Color.FromArgb(this.Red, this.Green, this.Blue);
			this.LeftBreak_Check.CheckedState.FillColor = Color.FromArgb(this.Red, this.Green, this.Blue);
			this.ClickSound_Check.CheckedState.BorderColor = Color.FromArgb(this.Red, this.Green, this.Blue);
			this.ClickSound_Check.CheckedState.FillColor = Color.FromArgb(this.Red, this.Green, this.Blue);
			this.LeftBreakBlocksToolTip.TitleForeColor = Color.FromArgb(this.Red, this.Green, this.Blue);
			this.LeftClickSoundToolTip.TitleForeColor = Color.FromArgb(this.Red, this.Green, this.Blue);
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00003F40 File Offset: 0x00002140
		private void MinLCPS_TB_Scroll(object sender, ScrollEventArgs e)
		{
			bool flag = this.MinLCPS_TB.Value >= this.MaxLCPS_TB.Value;
			if (flag)
			{
				this.MinLCPS_TB.Value = this.MaxLCPS_TB.Value;
			}
			MainForm.left_Min = this.MinLCPS_TB.Value;
			this.CPSLeft_Label.Text = this.MinLCPS_TB.Value.ToString() + " - " + this.MaxLCPS_TB.Value.ToString() + " CPS";
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00003FD8 File Offset: 0x000021D8
		private void MaxLCPS_TB_Scroll(object sender, ScrollEventArgs e)
		{
			bool flag = this.MaxLCPS_TB.Value <= this.MinLCPS_TB.Value;
			if (flag)
			{
				this.MaxLCPS_TB.Value = this.MinLCPS_TB.Value;
			}
			MainForm.left_Max = this.MaxLCPS_TB.Value;
			this.CPSLeft_Label.Text = this.MinLCPS_TB.Value.ToString() + " - " + this.MaxLCPS_TB.Value.ToString() + " CPS";
		}

		// Token: 0x0600002E RID: 46 RVA: 0x0000229C File Offset: 0x0000049C
		private void btnToggleLeft_CheckedChanged(object sender, EventArgs e)
		{
			MainForm.left_Click = this.btnToggleLeft.Checked;
		}

		// Token: 0x0600002F RID: 47 RVA: 0x000022AF File Offset: 0x000004AF
		private void ClickSound_Check_CheckedChanged(object sender, EventArgs e)
		{
			MainForm.left_Sound = this.ClickSound_Check.Checked;
		}

		// Token: 0x06000030 RID: 48 RVA: 0x000022C2 File Offset: 0x000004C2
		private void LeftBreak_Check_CheckedChanged(object sender, EventArgs e)
		{
			MainForm.left_Break = this.LeftBreak_Check.Checked;
		}

		// Token: 0x0400002C RID: 44
		private int Red;

		// Token: 0x0400002D RID: 45
		private int Green;

		// Token: 0x0400002E RID: 46
		private int Blue;
	}
}
