using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace Krokmou_Clicker_v2
{
	// Token: 0x0200000B RID: 11
	public partial class SettingsForm : Form
	{
		// Token: 0x06000064 RID: 100 RVA: 0x00002478 File Offset: 0x00000678
		public SettingsForm()
		{
			this.InitializeComponent();
			this.setSettings();
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00009314 File Offset: 0x00007514
		private void setSettings()
		{
			this.Red_TB.Value = (int)MainForm.tb_red;
			this.Green_TB.Value = (int)MainForm.tb_green;
			this.Blue_TB.Value = (int)MainForm.tb_blue;
			this.TopMost_Check.Checked = MainForm.topmost;
			bool flag = MainForm.target_Process == "javaw";
			if (flag)
			{
				this.ProcessSelectJavaw.Checked = true;
				this.ProcessSelectjava.Checked = false;
				this.ProcessSelectCustom.Checked = false;
			}
			else
			{
				bool flag2 = MainForm.target_Process == "java";
				if (flag2)
				{
					this.ProcessSelectJavaw.Checked = false;
					this.ProcessSelectjava.Checked = true;
					this.ProcessSelectCustom.Checked = false;
				}
				else
				{
					this.ProcessSelectJavaw.Checked = false;
					this.ProcessSelectjava.Checked = false;
					this.ProcessSelectCustom.Checked = true;
				}
			}
			this.CustomProcessName_Box.Text = MainForm.target_Custom;
			this.Red = Convert.ToInt32((double)this.Red_TB.Value * 2.55);
			this.Green = Convert.ToInt32((double)this.Green_TB.Value * 2.55);
			this.Blue = Convert.ToInt32((double)this.Blue_TB.Value * 2.55);
			this.ApplySettings();
		}

		// Token: 0x06000066 RID: 102 RVA: 0x0000948C File Offset: 0x0000768C
		private void ApplySettings()
		{
			this.Decoration_Settings.BackColor = Color.FromArgb(this.Red, this.Green, this.Blue);
			this.Decoration_TextBox.BackColor = Color.FromArgb(this.Red, this.Green, this.Blue);
			this.Decoration_GuiLabel.BackColor = Color.FromArgb(this.Red, this.Green, this.Blue);
			this.Decoration_ProcessLabel.BackColor = Color.FromArgb(this.Red, this.Green, this.Blue);
			this.GuiToolTip.TitleForeColor = Color.FromArgb(this.Red, this.Green, this.Blue);
			this.TopMostToolTip.TitleForeColor = Color.FromArgb(this.Red, this.Green, this.Blue);
			this.ProcessToolTip.TitleForeColor = Color.FromArgb(this.Red, this.Green, this.Blue);
			this.TopMost_Check.CheckedState.BorderColor = Color.FromArgb(this.Red, this.Green, this.Blue);
			this.TopMost_Check.CheckedState.FillColor = Color.FromArgb(this.Red, this.Green, this.Blue);
			this.ProcessSelectJavaw.CheckedState.BorderColor = Color.FromArgb(this.Red, this.Green, this.Blue);
			this.ProcessSelectJavaw.CheckedState.FillColor = Color.FromArgb(this.Red, this.Green, this.Blue);
			this.ProcessSelectJavaw.Refresh();
			this.ProcessSelectjava.CheckedState.BorderColor = Color.FromArgb(this.Red, this.Green, this.Blue);
			this.ProcessSelectjava.CheckedState.FillColor = Color.FromArgb(this.Red, this.Green, this.Blue);
			this.ProcessSelectjava.Refresh();
			this.ProcessSelectCustom.CheckedState.BorderColor = Color.FromArgb(this.Red, this.Green, this.Blue);
			this.ProcessSelectCustom.CheckedState.FillColor = Color.FromArgb(this.Red, this.Green, this.Blue);
			this.ProcessSelectCustom.Refresh();
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00002497 File Offset: 0x00000697
		private void Red_TB_Scroll(object sender, ScrollEventArgs e)
		{
			this.Red = Convert.ToInt32((double)this.Red_TB.Value * 2.55);
			MainForm.tb_red = (double)this.Red_TB.Value;
			this.ApplySettings();
		}

		// Token: 0x06000068 RID: 104 RVA: 0x000024D3 File Offset: 0x000006D3
		private void Green_TB_Scroll(object sender, ScrollEventArgs e)
		{
			this.Green = Convert.ToInt32((double)this.Green_TB.Value * 2.55);
			MainForm.tb_green = (double)this.Green_TB.Value;
			this.ApplySettings();
		}

		// Token: 0x06000069 RID: 105 RVA: 0x0000250F File Offset: 0x0000070F
		private void Blue_TB_Scroll(object sender, ScrollEventArgs e)
		{
			this.Blue = Convert.ToInt32((double)this.Blue_TB.Value * 2.55);
			MainForm.tb_blue = (double)this.Blue_TB.Value;
			this.ApplySettings();
		}

		// Token: 0x0600006A RID: 106 RVA: 0x0000254B File Offset: 0x0000074B
		private void TopMost_Check_CheckedChanged(object sender, EventArgs e)
		{
			MainForm.topmost = this.TopMost_Check.Checked;
			Form.ActiveForm.TopMost = MainForm.topmost;
		}

		// Token: 0x0600006B RID: 107 RVA: 0x0000256E File Offset: 0x0000076E
		private void ProcessSelectJavaw_CheckedChanged(object sender, EventArgs e)
		{
			MainForm.target_Process = "javaw";
		}

		// Token: 0x0600006C RID: 108 RVA: 0x0000257B File Offset: 0x0000077B
		private void ProcessSelectjava_CheckedChanged(object sender, EventArgs e)
		{
			MainForm.target_Process = "java";
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00002588 File Offset: 0x00000788
		private void ProcessSelectCustom_CheckedChanged(object sender, EventArgs e)
		{
			MainForm.target_Process = this.CustomProcessName_Box.Text;
		}

		// Token: 0x0600006E RID: 110 RVA: 0x000096F4 File Offset: 0x000078F4
		private void CustomProcessName_Box_TextChanged(object sender, EventArgs e)
		{
			bool @checked = this.ProcessSelectCustom.Checked;
			if (@checked)
			{
				MainForm.target_Process = this.CustomProcessName_Box.Text;
				MainForm.target_Custom = this.CustomProcessName_Box.Text;
			}
		}

		// Token: 0x04000094 RID: 148
		private int Red;

		// Token: 0x04000095 RID: 149
		private int Green;

		// Token: 0x04000096 RID: 150
		private int Blue;
	}
}
