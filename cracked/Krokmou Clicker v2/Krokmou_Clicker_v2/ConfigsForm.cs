using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace Krokmou_Clicker_v2
{
	// Token: 0x02000007 RID: 7
	public partial class ConfigsForm : Form
	{
		// Token: 0x0600004E RID: 78 RVA: 0x000023AD File Offset: 0x000005AD
		public ConfigsForm()
		{
			this.InitializeComponent();
			this.setSettings();
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00006458 File Offset: 0x00004658
		private void setSettings()
		{
			this.Red = Convert.ToInt32(MainForm.tb_red * 2.55);
			this.Green = Convert.ToInt32(MainForm.tb_green * 2.55);
			this.Blue = Convert.ToInt32(MainForm.tb_blue * 2.55);
			this.ApplySettings();
		}

		// Token: 0x06000050 RID: 80 RVA: 0x000064BC File Offset: 0x000046BC
		private void ApplySettings()
		{
			this.Decoration_Configs.BackColor = Color.FromArgb(this.Red, this.Green, this.Blue);
			this.ApplyMMC_Btn.BorderColor = Color.FromArgb(this.Red, this.Green, this.Blue);
			this.ApplyCold_Btn.BorderColor = Color.FromArgb(this.Red, this.Green, this.Blue);
			this.ApplyPvPLand_Btn.BorderColor = Color.FromArgb(this.Red, this.Green, this.Blue);
			this.ApplyPvPGym_Btn.BorderColor = Color.FromArgb(this.Red, this.Green, this.Blue);
			this.ApplyProgress.ProgressColor = Color.FromArgb(this.Red, this.Green, this.Blue);
			this.ApplyProgress.ProgressColor2 = Color.FromArgb(this.Red, this.Green, this.Blue);
			this.ConfigsToolTip.TitleForeColor = Color.FromArgb(this.Red, this.Green, this.Blue);
		}

		// Token: 0x06000051 RID: 81 RVA: 0x000065E4 File Offset: 0x000047E4
		private void ApplyMMC_Btn_Click(object sender, EventArgs e)
		{
			MainForm.left_Min = 17;
			this.ApplyProgress.Value = 25;
			MainForm.left_Max = 22;
			this.ApplyProgress.Value = 50;
			MainForm.right_Min = 25;
			this.ApplyProgress.Value = 75;
			MainForm.right_Max = 25;
			this.ApplyProgress.Value = 100;
			this.ConfigsApply_Label.Text = "Minemen Club set.";
		}

		// Token: 0x04000058 RID: 88
		private int Red;

		// Token: 0x04000059 RID: 89
		private int Green;

		// Token: 0x0400005A RID: 90
		private int Blue;
	}
}
