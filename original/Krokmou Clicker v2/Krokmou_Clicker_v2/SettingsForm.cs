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
		// Token: 0x06000064 RID: 100 RVA: 0x00009345 File Offset: 0x00007545
		public SettingsForm()
		{
			this.InitializeComponent();
			this.setSettings();
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00009364 File Offset: 0x00007564
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

		// Token: 0x06000066 RID: 102 RVA: 0x000094DC File Offset: 0x000076DC
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

		// Token: 0x06000067 RID: 103 RVA: 0x00009743 File Offset: 0x00007943
		private void Red_TB_Scroll(object sender, ScrollEventArgs e)
		{
			this.Red = Convert.ToInt32((double)this.Red_TB.Value * 2.55);
			MainForm.tb_red = (double)this.Red_TB.Value;
			this.ApplySettings();
		}

		// Token: 0x06000068 RID: 104 RVA: 0x0000977F File Offset: 0x0000797F
		private void Green_TB_Scroll(object sender, ScrollEventArgs e)
		{
			this.Green = Convert.ToInt32((double)this.Green_TB.Value * 2.55);
			MainForm.tb_green = (double)this.Green_TB.Value;
			this.ApplySettings();
		}

		// Token: 0x06000069 RID: 105 RVA: 0x000097BB File Offset: 0x000079BB
		private void Blue_TB_Scroll(object sender, ScrollEventArgs e)
		{
			this.Blue = Convert.ToInt32((double)this.Blue_TB.Value * 2.55);
			MainForm.tb_blue = (double)this.Blue_TB.Value;
			this.ApplySettings();
		}

		// Token: 0x0600006A RID: 106 RVA: 0x000097F7 File Offset: 0x000079F7
		private void TopMost_Check_CheckedChanged(object sender, EventArgs e)
		{
			MainForm.topmost = this.TopMost_Check.Checked;
			Form.ActiveForm.TopMost = MainForm.topmost;
		}

		// Token: 0x0600006B RID: 107 RVA: 0x0000981A File Offset: 0x00007A1A
		private void ProcessSelectJavaw_CheckedChanged(object sender, EventArgs e)
		{
			MainForm.target_Process = "javaw";
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00009827 File Offset: 0x00007A27
		private void ProcessSelectjava_CheckedChanged(object sender, EventArgs e)
		{
			MainForm.target_Process = "java";
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00009834 File Offset: 0x00007A34
		private void ProcessSelectCustom_CheckedChanged(object sender, EventArgs e)
		{
			MainForm.target_Process = this.CustomProcessName_Box.Text;
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00009848 File Offset: 0x00007A48
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
