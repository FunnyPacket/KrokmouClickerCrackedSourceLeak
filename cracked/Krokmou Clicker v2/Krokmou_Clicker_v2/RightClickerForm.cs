using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace Krokmou_Clicker_v2
{
	// Token: 0x0200000A RID: 10
	public partial class RightClickerForm : Form
	{
		// Token: 0x0600005B RID: 91 RVA: 0x00002433 File Offset: 0x00000633
		public RightClickerForm()
		{
			this.InitializeComponent();
			this.setSettings();
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00008598 File Offset: 0x00006798
		private void setSettings()
		{
			this.btnToggleRight.Checked = MainForm.right_Click;
			this.MinRCPS_TB.Value = MainForm.right_Min;
			this.MaxRCPS_TB.Value = MainForm.right_Max;
			this.CPSRight_Label.Text = this.MinRCPS_TB.Value.ToString() + " - " + this.MaxRCPS_TB.Value.ToString() + " CPS";
			this.RightClickSound_Check.Checked = MainForm.right_Sound;
			this.Red = Convert.ToInt32(MainForm.tb_red * 2.55);
			this.Green = Convert.ToInt32(MainForm.tb_green * 2.55);
			this.Blue = Convert.ToInt32(MainForm.tb_blue * 2.55);
			this.ApplySettings();
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00008680 File Offset: 0x00006880
		private void ApplySettings()
		{
			this.Decoration_RightClicker.BackColor = Color.FromArgb(this.Red, this.Green, this.Blue);
			this.btnToggleRight.CheckedState.BorderColor = Color.FromArgb(this.Red, this.Green, this.Blue);
			this.btnToggleRight.CheckedState.FillColor = Color.FromArgb(this.Red, this.Green, this.Blue);
			this.MinRCPS_TB.ThumbColor = Color.FromArgb(this.Red, this.Green, this.Blue);
			this.MaxRCPS_TB.ThumbColor = Color.FromArgb(this.Red, this.Green, this.Blue);
			this.RightClickSound_Check.CheckedState.BorderColor = Color.FromArgb(this.Red, this.Green, this.Blue);
			this.RightClickSound_Check.CheckedState.FillColor = Color.FromArgb(this.Red, this.Green, this.Blue);
			this.RightClickSoundToolTip.TitleForeColor = Color.FromArgb(this.Red, this.Green, this.Blue);
		}

		// Token: 0x0600005E RID: 94 RVA: 0x000087BC File Offset: 0x000069BC
		private void MinRCPS_TB_Scroll(object sender, ScrollEventArgs e)
		{
			bool flag = this.MinRCPS_TB.Value >= this.MaxRCPS_TB.Value;
			if (flag)
			{
				this.MinRCPS_TB.Value = this.MaxRCPS_TB.Value;
			}
			MainForm.right_Min = this.MinRCPS_TB.Value;
			this.CPSRight_Label.Text = this.MinRCPS_TB.Value.ToString() + " - " + this.MaxRCPS_TB.Value.ToString() + " CPS";
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00008854 File Offset: 0x00006A54
		private void MaxRCPS_TB_Scroll(object sender, ScrollEventArgs e)
		{
			bool flag = this.MaxRCPS_TB.Value <= this.MinRCPS_TB.Value;
			if (flag)
			{
				this.MaxRCPS_TB.Value = this.MinRCPS_TB.Value;
			}
			MainForm.right_Max = this.MaxRCPS_TB.Value;
			this.CPSRight_Label.Text = this.MinRCPS_TB.Value.ToString() + " - " + this.MaxRCPS_TB.Value.ToString() + " CPS";
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00002452 File Offset: 0x00000652
		private void btnToggleRight_CheckedChanged(object sender, EventArgs e)
		{
			MainForm.right_Click = this.btnToggleRight.Checked;
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00002465 File Offset: 0x00000665
		private void RightClickSound_Check_CheckedChanged(object sender, EventArgs e)
		{
			MainForm.right_Sound = this.RightClickSound_Check.Checked;
		}

		// Token: 0x04000085 RID: 133
		private int Red;

		// Token: 0x04000086 RID: 134
		private int Green;

		// Token: 0x04000087 RID: 135
		private int Blue;
	}
}
