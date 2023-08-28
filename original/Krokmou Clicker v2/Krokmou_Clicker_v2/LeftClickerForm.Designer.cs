namespace Krokmou_Clicker_v2
{
	// Token: 0x02000005 RID: 5
	public partial class LeftClickerForm : global::System.Windows.Forms.Form
	{
		// Token: 0x06000031 RID: 49 RVA: 0x00003D88 File Offset: 0x00001F88
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00003DC0 File Offset: 0x00001FC0
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Krokmou_Clicker_v2.LeftClickerForm));
			this.label1 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.Decoration_LeftClicker = new global::System.Windows.Forms.Panel();
			this.MaxLCPS_TB = new global::Guna.UI2.WinForms.Guna2TrackBar();
			this.btnToggleLeft = new global::Guna.UI2.WinForms.Guna2ToggleSwitch();
			this.CPSLeft_Label = new global::System.Windows.Forms.Label();
			this.MinLCPS_TB = new global::Guna.UI2.WinForms.Guna2TrackBar();
			this.LeftBreak_Check = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.ClickSound_Check = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.ClickSoundToolTip_Box = new global::Guna.UI2.WinForms.Guna2PictureBox();
			this.LeftClickSoundToolTip = new global::Guna.UI2.WinForms.Guna2HtmlToolTip();
			this.LeftBreakBlocksToolTip_Box = new global::Guna.UI2.WinForms.Guna2PictureBox();
			this.LeftBreakBlocksToolTip = new global::Guna.UI2.WinForms.Guna2HtmlToolTip();
			this.ClickSoundToolTip_Box.BeginInit();
			this.LeftBreakBlocksToolTip_Box.BeginInit();
			base.SuspendLayout();
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 15.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.ForeColor = global::System.Drawing.SystemColors.ControlLightLight;
			this.label1.Location = new global::System.Drawing.Point(17, 9);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(120, 25);
			this.label1.TabIndex = 1;
			this.label1.Text = "Left Clicker";
			this.label2.AutoSize = true;
			this.label2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label2.ForeColor = global::System.Drawing.SystemColors.ControlLightLight;
			this.label2.Location = new global::System.Drawing.Point(15, 41);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(32, 18);
			this.label2.TabIndex = 3;
			this.label2.Text = "Min";
			this.label3.AutoSize = true;
			this.label3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label3.ForeColor = global::System.Drawing.SystemColors.ControlLightLight;
			this.label3.Location = new global::System.Drawing.Point(15, 75);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(36, 18);
			this.label3.TabIndex = 5;
			this.label3.Text = "Max";
			this.Decoration_LeftClicker.BackColor = global::System.Drawing.Color.FromArgb(0, 192, 0);
			this.Decoration_LeftClicker.Location = new global::System.Drawing.Point(12, 13);
			this.Decoration_LeftClicker.Name = "Decoration_LeftClicker";
			this.Decoration_LeftClicker.Size = new global::System.Drawing.Size(2, 17);
			this.Decoration_LeftClicker.TabIndex = 7;
			this.MaxLCPS_TB.FillColor = global::System.Drawing.Color.DimGray;
			this.MaxLCPS_TB.Location = new global::System.Drawing.Point(53, 75);
			this.MaxLCPS_TB.Maximum = 25;
			this.MaxLCPS_TB.Minimum = 1;
			this.MaxLCPS_TB.Name = "MaxLCPS_TB";
			this.MaxLCPS_TB.Size = new global::System.Drawing.Size(281, 18);
			this.MaxLCPS_TB.Style = 1;
			this.MaxLCPS_TB.TabIndex = 8;
			this.MaxLCPS_TB.ThumbColor = global::System.Drawing.Color.FromArgb(0, 192, 0);
			this.MaxLCPS_TB.Value = 13;
			this.MaxLCPS_TB.Scroll += new global::System.Windows.Forms.ScrollEventHandler(this.MaxLCPS_TB_Scroll);
			this.btnToggleLeft.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(0, 192, 0);
			this.btnToggleLeft.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(0, 192, 0);
			this.btnToggleLeft.CheckedState.InnerBorderColor = global::System.Drawing.Color.White;
			this.btnToggleLeft.CheckedState.InnerColor = global::System.Drawing.Color.White;
			this.btnToggleLeft.Location = new global::System.Drawing.Point(143, 14);
			this.btnToggleLeft.Name = "btnToggleLeft";
			this.btnToggleLeft.RightToLeft = global::System.Windows.Forms.RightToLeft.No;
			this.btnToggleLeft.Size = new global::System.Drawing.Size(35, 20);
			this.btnToggleLeft.TabIndex = 9;
			this.btnToggleLeft.UncheckedState.BorderColor = global::System.Drawing.Color.FromArgb(125, 137, 149);
			this.btnToggleLeft.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(125, 137, 149);
			this.btnToggleLeft.UncheckedState.InnerBorderColor = global::System.Drawing.Color.White;
			this.btnToggleLeft.UncheckedState.InnerColor = global::System.Drawing.Color.White;
			this.btnToggleLeft.CheckedChanged += new global::System.EventHandler(this.btnToggleLeft_CheckedChanged);
			this.CPSLeft_Label.AutoSize = true;
			this.CPSLeft_Label.ForeColor = global::System.Drawing.SystemColors.ControlDarkDark;
			this.CPSLeft_Label.Location = new global::System.Drawing.Point(270, 21);
			this.CPSLeft_Label.Name = "CPSLeft_Label";
			this.CPSLeft_Label.Size = new global::System.Drawing.Size(64, 13);
			this.CPSLeft_Label.TabIndex = 10;
			this.CPSLeft_Label.Text = "13 - 13 CPS";
			this.MinLCPS_TB.FillColor = global::System.Drawing.Color.DimGray;
			this.MinLCPS_TB.Location = new global::System.Drawing.Point(53, 41);
			this.MinLCPS_TB.Maximum = 25;
			this.MinLCPS_TB.Minimum = 1;
			this.MinLCPS_TB.Name = "MinLCPS_TB";
			this.MinLCPS_TB.Size = new global::System.Drawing.Size(281, 18);
			this.MinLCPS_TB.Style = 1;
			this.MinLCPS_TB.TabIndex = 11;
			this.MinLCPS_TB.ThumbColor = global::System.Drawing.Color.FromArgb(0, 192, 0);
			this.MinLCPS_TB.Value = 13;
			this.MinLCPS_TB.Scroll += new global::System.Windows.Forms.ScrollEventHandler(this.MinLCPS_TB_Scroll);
			this.LeftBreak_Check.Animated = true;
			this.LeftBreak_Check.AutoSize = true;
			this.LeftBreak_Check.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(0, 192, 0);
			this.LeftBreak_Check.CheckedState.BorderRadius = 0;
			this.LeftBreak_Check.CheckedState.BorderThickness = 0;
			this.LeftBreak_Check.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(0, 192, 0);
			this.LeftBreak_Check.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.LeftBreak_Check.ForeColor = global::System.Drawing.SystemColors.ControlLightLight;
			this.LeftBreak_Check.Location = new global::System.Drawing.Point(22, 118);
			this.LeftBreak_Check.Name = "LeftBreak_Check";
			this.LeftBreak_Check.Size = new global::System.Drawing.Size(116, 22);
			this.LeftBreak_Check.TabIndex = 12;
			this.LeftBreak_Check.Text = "Break Blocks";
			this.LeftBreak_Check.UncheckedState.BorderColor = global::System.Drawing.Color.FromArgb(125, 137, 149);
			this.LeftBreak_Check.UncheckedState.BorderRadius = 0;
			this.LeftBreak_Check.UncheckedState.BorderThickness = 0;
			this.LeftBreak_Check.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(125, 137, 149);
			this.LeftBreak_Check.CheckedChanged += new global::System.EventHandler(this.LeftBreak_Check_CheckedChanged);
			this.ClickSound_Check.Animated = true;
			this.ClickSound_Check.AutoSize = true;
			this.ClickSound_Check.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(0, 192, 0);
			this.ClickSound_Check.CheckedState.BorderRadius = 0;
			this.ClickSound_Check.CheckedState.BorderThickness = 0;
			this.ClickSound_Check.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(0, 192, 0);
			this.ClickSound_Check.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.ClickSound_Check.ForeColor = global::System.Drawing.SystemColors.ControlLightLight;
			this.ClickSound_Check.Location = new global::System.Drawing.Point(22, 146);
			this.ClickSound_Check.Name = "ClickSound_Check";
			this.ClickSound_Check.Size = new global::System.Drawing.Size(107, 22);
			this.ClickSound_Check.TabIndex = 13;
			this.ClickSound_Check.Text = "Click Sound";
			this.ClickSound_Check.UncheckedState.BorderColor = global::System.Drawing.Color.FromArgb(125, 137, 149);
			this.ClickSound_Check.UncheckedState.BorderRadius = 0;
			this.ClickSound_Check.UncheckedState.BorderThickness = 0;
			this.ClickSound_Check.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(125, 137, 149);
			this.ClickSound_Check.CheckedChanged += new global::System.EventHandler(this.ClickSound_Check_CheckedChanged);
			this.ClickSoundToolTip_Box.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("ClickSoundToolTip_Box.Image");
			this.ClickSoundToolTip_Box.ImageRotate = 0f;
			this.ClickSoundToolTip_Box.Location = new global::System.Drawing.Point(126, 150);
			this.ClickSoundToolTip_Box.Name = "ClickSoundToolTip_Box";
			this.ClickSoundToolTip_Box.Size = new global::System.Drawing.Size(16, 16);
			this.ClickSoundToolTip_Box.TabIndex = 38;
			this.ClickSoundToolTip_Box.TabStop = false;
			this.LeftClickSoundToolTip.SetToolTip(this.ClickSoundToolTip_Box, "This option simulates the sound of your mouse clicks.");
			this.LeftClickSoundToolTip.AllowLinksHandling = true;
			this.LeftClickSoundToolTip.BackColor = global::System.Drawing.Color.FromArgb(15, 15, 15);
			this.LeftClickSoundToolTip.BorderColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.LeftClickSoundToolTip.ForeColor = global::System.Drawing.SystemColors.ControlLightLight;
			this.LeftClickSoundToolTip.MaximumSize = new global::System.Drawing.Size(0, 0);
			this.LeftClickSoundToolTip.TitleForeColor = global::System.Drawing.Color.FromArgb(0, 192, 0);
			this.LeftClickSoundToolTip.ToolTipTitle = "Click Sound";
			this.LeftBreakBlocksToolTip_Box.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("LeftBreakBlocksToolTip_Box.Image");
			this.LeftBreakBlocksToolTip_Box.ImageRotate = 0f;
			this.LeftBreakBlocksToolTip_Box.Location = new global::System.Drawing.Point(134, 122);
			this.LeftBreakBlocksToolTip_Box.Name = "LeftBreakBlocksToolTip_Box";
			this.LeftBreakBlocksToolTip_Box.Size = new global::System.Drawing.Size(16, 16);
			this.LeftBreakBlocksToolTip_Box.TabIndex = 39;
			this.LeftBreakBlocksToolTip_Box.TabStop = false;
			this.LeftBreakBlocksToolTip.SetToolTip(this.LeftBreakBlocksToolTip_Box, "This option makes you able to break blocks.\r\n");
			this.LeftBreakBlocksToolTip.AllowLinksHandling = true;
			this.LeftBreakBlocksToolTip.BackColor = global::System.Drawing.Color.FromArgb(15, 15, 15);
			this.LeftBreakBlocksToolTip.BorderColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.LeftBreakBlocksToolTip.ForeColor = global::System.Drawing.SystemColors.ControlLightLight;
			this.LeftBreakBlocksToolTip.MaximumSize = new global::System.Drawing.Size(0, 0);
			this.LeftBreakBlocksToolTip.TitleForeColor = global::System.Drawing.Color.FromArgb(0, 192, 0);
			this.LeftBreakBlocksToolTip.ToolTipTitle = "Break Blocks";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(25, 25, 25);
			base.ClientSize = new global::System.Drawing.Size(496, 325);
			base.Controls.Add(this.LeftBreakBlocksToolTip_Box);
			base.Controls.Add(this.ClickSoundToolTip_Box);
			base.Controls.Add(this.ClickSound_Check);
			base.Controls.Add(this.LeftBreak_Check);
			base.Controls.Add(this.MinLCPS_TB);
			base.Controls.Add(this.CPSLeft_Label);
			base.Controls.Add(this.btnToggleLeft);
			base.Controls.Add(this.MaxLCPS_TB);
			base.Controls.Add(this.Decoration_LeftClicker);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.label1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = "LeftClickerForm";
			this.Text = "LeftClickerForm";
			this.ClickSoundToolTip_Box.EndInit();
			this.LeftBreakBlocksToolTip_Box.EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400002F RID: 47
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000030 RID: 48
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000031 RID: 49
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000032 RID: 50
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000033 RID: 51
		private global::System.Windows.Forms.Panel Decoration_LeftClicker;

		// Token: 0x04000034 RID: 52
		private global::Guna.UI2.WinForms.Guna2TrackBar MaxLCPS_TB;

		// Token: 0x04000035 RID: 53
		private global::Guna.UI2.WinForms.Guna2ToggleSwitch btnToggleLeft;

		// Token: 0x04000036 RID: 54
		private global::System.Windows.Forms.Label CPSLeft_Label;

		// Token: 0x04000037 RID: 55
		private global::Guna.UI2.WinForms.Guna2TrackBar MinLCPS_TB;

		// Token: 0x04000038 RID: 56
		private global::Guna.UI2.WinForms.Guna2CheckBox LeftBreak_Check;

		// Token: 0x04000039 RID: 57
		private global::Guna.UI2.WinForms.Guna2CheckBox ClickSound_Check;

		// Token: 0x0400003A RID: 58
		private global::Guna.UI2.WinForms.Guna2PictureBox ClickSoundToolTip_Box;

		// Token: 0x0400003B RID: 59
		private global::Guna.UI2.WinForms.Guna2HtmlToolTip LeftClickSoundToolTip;

		// Token: 0x0400003C RID: 60
		private global::Guna.UI2.WinForms.Guna2PictureBox LeftBreakBlocksToolTip_Box;

		// Token: 0x0400003D RID: 61
		private global::Guna.UI2.WinForms.Guna2HtmlToolTip LeftBreakBlocksToolTip;
	}
}
