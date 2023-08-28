namespace Krokmou_Clicker_v2
{
	// Token: 0x0200000A RID: 10
	public partial class RightClickerForm : global::System.Windows.Forms.Form
	{
		// Token: 0x06000062 RID: 98 RVA: 0x00008920 File Offset: 0x00006B20
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00008958 File Offset: 0x00006B58
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Krokmou_Clicker_v2.RightClickerForm));
			this.label1 = new global::System.Windows.Forms.Label();
			this.Decoration_RightClicker = new global::System.Windows.Forms.Panel();
			this.btnToggleRight = new global::Guna.UI2.WinForms.Guna2ToggleSwitch();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.MinRCPS_TB = new global::Guna.UI2.WinForms.Guna2TrackBar();
			this.MaxRCPS_TB = new global::Guna.UI2.WinForms.Guna2TrackBar();
			this.CPSRight_Label = new global::System.Windows.Forms.Label();
			this.RightClickSound_Check = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.ClickSoundToolTip_Box = new global::Guna.UI2.WinForms.Guna2PictureBox();
			this.RightClickSoundToolTip = new global::Guna.UI2.WinForms.Guna2HtmlToolTip();
			this.ClickSoundToolTip_Box.BeginInit();
			base.SuspendLayout();
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 15.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.ForeColor = global::System.Drawing.SystemColors.ControlLightLight;
			this.label1.Location = new global::System.Drawing.Point(17, 9);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(134, 25);
			this.label1.TabIndex = 1;
			this.label1.Text = "Right Clicker";
			this.Decoration_RightClicker.BackColor = global::System.Drawing.Color.FromArgb(0, 192, 0);
			this.Decoration_RightClicker.Location = new global::System.Drawing.Point(12, 13);
			this.Decoration_RightClicker.Name = "Decoration_RightClicker";
			this.Decoration_RightClicker.Size = new global::System.Drawing.Size(2, 17);
			this.Decoration_RightClicker.TabIndex = 8;
			this.btnToggleRight.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(0, 192, 0);
			this.btnToggleRight.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(0, 192, 0);
			this.btnToggleRight.CheckedState.InnerBorderColor = global::System.Drawing.Color.White;
			this.btnToggleRight.CheckedState.InnerColor = global::System.Drawing.Color.White;
			this.btnToggleRight.Location = new global::System.Drawing.Point(157, 14);
			this.btnToggleRight.Name = "btnToggleRight";
			this.btnToggleRight.RightToLeft = global::System.Windows.Forms.RightToLeft.No;
			this.btnToggleRight.Size = new global::System.Drawing.Size(35, 20);
			this.btnToggleRight.TabIndex = 10;
			this.btnToggleRight.UncheckedState.BorderColor = global::System.Drawing.Color.FromArgb(125, 137, 149);
			this.btnToggleRight.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(125, 137, 149);
			this.btnToggleRight.UncheckedState.InnerBorderColor = global::System.Drawing.Color.White;
			this.btnToggleRight.UncheckedState.InnerColor = global::System.Drawing.Color.White;
			this.btnToggleRight.CheckedChanged += new global::System.EventHandler(this.btnToggleRight_CheckedChanged);
			this.label2.AutoSize = true;
			this.label2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label2.ForeColor = global::System.Drawing.SystemColors.ControlLightLight;
			this.label2.Location = new global::System.Drawing.Point(15, 41);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(32, 18);
			this.label2.TabIndex = 11;
			this.label2.Text = "Min";
			this.label3.AutoSize = true;
			this.label3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label3.ForeColor = global::System.Drawing.SystemColors.ControlLightLight;
			this.label3.Location = new global::System.Drawing.Point(15, 75);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(36, 18);
			this.label3.TabIndex = 12;
			this.label3.Text = "Max";
			this.MinRCPS_TB.FillColor = global::System.Drawing.Color.DimGray;
			this.MinRCPS_TB.Location = new global::System.Drawing.Point(53, 41);
			this.MinRCPS_TB.Maximum = 25;
			this.MinRCPS_TB.Minimum = 1;
			this.MinRCPS_TB.Name = "MinRCPS_TB";
			this.MinRCPS_TB.Size = new global::System.Drawing.Size(281, 18);
			this.MinRCPS_TB.Style = 1;
			this.MinRCPS_TB.TabIndex = 13;
			this.MinRCPS_TB.ThumbColor = global::System.Drawing.Color.FromArgb(0, 192, 0);
			this.MinRCPS_TB.Value = 13;
			this.MinRCPS_TB.Scroll += new global::System.Windows.Forms.ScrollEventHandler(this.MinRCPS_TB_Scroll);
			this.MaxRCPS_TB.FillColor = global::System.Drawing.Color.DimGray;
			this.MaxRCPS_TB.Location = new global::System.Drawing.Point(53, 75);
			this.MaxRCPS_TB.Maximum = 25;
			this.MaxRCPS_TB.Minimum = 1;
			this.MaxRCPS_TB.Name = "MaxRCPS_TB";
			this.MaxRCPS_TB.Size = new global::System.Drawing.Size(281, 18);
			this.MaxRCPS_TB.Style = 1;
			this.MaxRCPS_TB.TabIndex = 14;
			this.MaxRCPS_TB.ThumbColor = global::System.Drawing.Color.FromArgb(0, 192, 0);
			this.MaxRCPS_TB.Value = 13;
			this.MaxRCPS_TB.Scroll += new global::System.Windows.Forms.ScrollEventHandler(this.MaxRCPS_TB_Scroll);
			this.CPSRight_Label.AutoSize = true;
			this.CPSRight_Label.ForeColor = global::System.Drawing.SystemColors.ControlDarkDark;
			this.CPSRight_Label.Location = new global::System.Drawing.Point(270, 21);
			this.CPSRight_Label.Name = "CPSRight_Label";
			this.CPSRight_Label.Size = new global::System.Drawing.Size(64, 13);
			this.CPSRight_Label.TabIndex = 15;
			this.CPSRight_Label.Text = "13 - 13 CPS";
			this.RightClickSound_Check.Animated = true;
			this.RightClickSound_Check.AutoSize = true;
			this.RightClickSound_Check.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(0, 192, 0);
			this.RightClickSound_Check.CheckedState.BorderRadius = 0;
			this.RightClickSound_Check.CheckedState.BorderThickness = 0;
			this.RightClickSound_Check.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(0, 192, 0);
			this.RightClickSound_Check.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.RightClickSound_Check.ForeColor = global::System.Drawing.SystemColors.ControlLightLight;
			this.RightClickSound_Check.Location = new global::System.Drawing.Point(22, 118);
			this.RightClickSound_Check.Name = "RightClickSound_Check";
			this.RightClickSound_Check.Size = new global::System.Drawing.Size(107, 22);
			this.RightClickSound_Check.TabIndex = 17;
			this.RightClickSound_Check.Text = "Click Sound";
			this.RightClickSound_Check.UncheckedState.BorderColor = global::System.Drawing.Color.FromArgb(125, 137, 149);
			this.RightClickSound_Check.UncheckedState.BorderRadius = 0;
			this.RightClickSound_Check.UncheckedState.BorderThickness = 0;
			this.RightClickSound_Check.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(125, 137, 149);
			this.RightClickSound_Check.CheckedChanged += new global::System.EventHandler(this.RightClickSound_Check_CheckedChanged);
			this.ClickSoundToolTip_Box.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("ClickSoundToolTip_Box.Image");
			this.ClickSoundToolTip_Box.ImageRotate = 0f;
			this.ClickSoundToolTip_Box.Location = new global::System.Drawing.Point(126, 122);
			this.ClickSoundToolTip_Box.Name = "ClickSoundToolTip_Box";
			this.ClickSoundToolTip_Box.Size = new global::System.Drawing.Size(16, 16);
			this.ClickSoundToolTip_Box.TabIndex = 37;
			this.ClickSoundToolTip_Box.TabStop = false;
			this.RightClickSoundToolTip.SetToolTip(this.ClickSoundToolTip_Box, "This option simulates the sound of your mouse clicks.");
			this.RightClickSoundToolTip.AllowLinksHandling = true;
			this.RightClickSoundToolTip.BackColor = global::System.Drawing.Color.FromArgb(15, 15, 15);
			this.RightClickSoundToolTip.BorderColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.RightClickSoundToolTip.ForeColor = global::System.Drawing.SystemColors.ControlLightLight;
			this.RightClickSoundToolTip.MaximumSize = new global::System.Drawing.Size(0, 0);
			this.RightClickSoundToolTip.TitleForeColor = global::System.Drawing.Color.FromArgb(0, 192, 0);
			this.RightClickSoundToolTip.ToolTipTitle = "Click Sound";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(25, 25, 25);
			base.ClientSize = new global::System.Drawing.Size(496, 325);
			base.Controls.Add(this.ClickSoundToolTip_Box);
			base.Controls.Add(this.RightClickSound_Check);
			base.Controls.Add(this.CPSRight_Label);
			base.Controls.Add(this.MaxRCPS_TB);
			base.Controls.Add(this.MinRCPS_TB);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.btnToggleRight);
			base.Controls.Add(this.Decoration_RightClicker);
			base.Controls.Add(this.label1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = "RightClickerForm";
			this.Text = "RightClickerForm";
			this.ClickSoundToolTip_Box.EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000088 RID: 136
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000089 RID: 137
		private global::System.Windows.Forms.Label label1;

		// Token: 0x0400008A RID: 138
		private global::System.Windows.Forms.Panel Decoration_RightClicker;

		// Token: 0x0400008B RID: 139
		private global::Guna.UI2.WinForms.Guna2ToggleSwitch btnToggleRight;

		// Token: 0x0400008C RID: 140
		private global::System.Windows.Forms.Label label2;

		// Token: 0x0400008D RID: 141
		private global::System.Windows.Forms.Label label3;

		// Token: 0x0400008E RID: 142
		private global::Guna.UI2.WinForms.Guna2TrackBar MinRCPS_TB;

		// Token: 0x0400008F RID: 143
		private global::Guna.UI2.WinForms.Guna2TrackBar MaxRCPS_TB;

		// Token: 0x04000090 RID: 144
		private global::System.Windows.Forms.Label CPSRight_Label;

		// Token: 0x04000091 RID: 145
		private global::Guna.UI2.WinForms.Guna2CheckBox RightClickSound_Check;

		// Token: 0x04000092 RID: 146
		private global::Guna.UI2.WinForms.Guna2PictureBox ClickSoundToolTip_Box;

		// Token: 0x04000093 RID: 147
		private global::Guna.UI2.WinForms.Guna2HtmlToolTip RightClickSoundToolTip;
	}
}
