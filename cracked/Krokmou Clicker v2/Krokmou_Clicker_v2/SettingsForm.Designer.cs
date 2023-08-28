namespace Krokmou_Clicker_v2
{
	// Token: 0x0200000B RID: 11
	public partial class SettingsForm : global::System.Windows.Forms.Form
	{
		// Token: 0x0600006F RID: 111 RVA: 0x00009738 File Offset: 0x00007938
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00009770 File Offset: 0x00007970
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Krokmou_Clicker_v2.SettingsForm));
			this.label1 = new global::System.Windows.Forms.Label();
			this.Decoration_Settings = new global::System.Windows.Forms.Panel();
			this.Red_TB = new global::Guna.UI2.WinForms.Guna2TrackBar();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.label4 = new global::System.Windows.Forms.Label();
			this.Green_TB = new global::Guna.UI2.WinForms.Guna2TrackBar();
			this.label5 = new global::System.Windows.Forms.Label();
			this.Blue_TB = new global::Guna.UI2.WinForms.Guna2TrackBar();
			this.TopMost_Check = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.label6 = new global::System.Windows.Forms.Label();
			this.ProcessSelectJavaw = new global::Guna.UI2.WinForms.Guna2RadioButton();
			this.ProcessSelectjava = new global::Guna.UI2.WinForms.Guna2RadioButton();
			this.ProcessSelectCustom = new global::Guna.UI2.WinForms.Guna2RadioButton();
			this.CustomProcessName_Box = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.Decoration_TextBox = new global::System.Windows.Forms.Panel();
			this.guna2HtmlLabel1 = new global::Guna.UI2.WinForms.Guna2HtmlLabel();
			this.Decoration_GuiLabel = new global::System.Windows.Forms.Panel();
			this.Decoration_ProcessLabel = new global::System.Windows.Forms.Panel();
			this.ProcessToolTipBox = new global::Guna.UI2.WinForms.Guna2PictureBox();
			this.ProcessToolTip = new global::Guna.UI2.WinForms.Guna2HtmlToolTip();
			this.GuiToolTip_Box = new global::Guna.UI2.WinForms.Guna2PictureBox();
			this.GuiToolTip = new global::Guna.UI2.WinForms.Guna2HtmlToolTip();
			this.TopMostToolTip_Box = new global::Guna.UI2.WinForms.Guna2PictureBox();
			this.TopMostToolTip = new global::Guna.UI2.WinForms.Guna2HtmlToolTip();
			this.ProcessToolTipBox.BeginInit();
			this.GuiToolTip_Box.BeginInit();
			this.TopMostToolTip_Box.BeginInit();
			base.SuspendLayout();
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 15.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.ForeColor = global::System.Drawing.SystemColors.ControlLightLight;
			this.label1.Location = new global::System.Drawing.Point(17, 9);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(90, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "Settings";
			this.Decoration_Settings.BackColor = global::System.Drawing.Color.FromArgb(0, 192, 0);
			this.Decoration_Settings.Location = new global::System.Drawing.Point(12, 13);
			this.Decoration_Settings.Name = "Decoration_Settings";
			this.Decoration_Settings.Size = new global::System.Drawing.Size(2, 17);
			this.Decoration_Settings.TabIndex = 8;
			this.Red_TB.FillColor = global::System.Drawing.Color.DimGray;
			this.Red_TB.Location = new global::System.Drawing.Point(42, 88);
			this.Red_TB.Name = "Red_TB";
			this.Red_TB.Size = new global::System.Drawing.Size(281, 15);
			this.Red_TB.Style = 1;
			this.Red_TB.TabIndex = 12;
			this.Red_TB.ThumbColor = global::System.Drawing.Color.FromArgb(192, 0, 0);
			this.Red_TB.Value = 13;
			this.Red_TB.Scroll += new global::System.Windows.Forms.ScrollEventHandler(this.Red_TB_Scroll);
			this.label2.AutoSize = true;
			this.label2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label2.ForeColor = global::System.Drawing.SystemColors.ControlLightLight;
			this.label2.Location = new global::System.Drawing.Point(25, 62);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(39, 20);
			this.label2.TabIndex = 15;
			this.label2.Text = "GUI";
			this.label3.AutoSize = true;
			this.label3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label3.ForeColor = global::System.Drawing.SystemColors.ControlLightLight;
			this.label3.Location = new global::System.Drawing.Point(20, 88);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(16, 15);
			this.label3.TabIndex = 16;
			this.label3.Text = "R";
			this.label4.AutoSize = true;
			this.label4.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label4.ForeColor = global::System.Drawing.SystemColors.ControlLightLight;
			this.label4.Location = new global::System.Drawing.Point(20, 109);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(16, 15);
			this.label4.TabIndex = 18;
			this.label4.Text = "G";
			this.Green_TB.FillColor = global::System.Drawing.Color.DimGray;
			this.Green_TB.Location = new global::System.Drawing.Point(42, 109);
			this.Green_TB.Name = "Green_TB";
			this.Green_TB.Size = new global::System.Drawing.Size(281, 15);
			this.Green_TB.Style = 1;
			this.Green_TB.TabIndex = 17;
			this.Green_TB.ThumbColor = global::System.Drawing.Color.FromArgb(0, 192, 0);
			this.Green_TB.Value = 100;
			this.Green_TB.Scroll += new global::System.Windows.Forms.ScrollEventHandler(this.Green_TB_Scroll);
			this.label5.AutoSize = true;
			this.label5.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label5.ForeColor = global::System.Drawing.SystemColors.ControlLightLight;
			this.label5.Location = new global::System.Drawing.Point(20, 130);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(15, 15);
			this.label5.TabIndex = 20;
			this.label5.Text = "B";
			this.Blue_TB.FillColor = global::System.Drawing.Color.DimGray;
			this.Blue_TB.Location = new global::System.Drawing.Point(41, 130);
			this.Blue_TB.Name = "Blue_TB";
			this.Blue_TB.Size = new global::System.Drawing.Size(281, 15);
			this.Blue_TB.Style = 1;
			this.Blue_TB.TabIndex = 19;
			this.Blue_TB.ThumbColor = global::System.Drawing.Color.FromArgb(0, 0, 192);
			this.Blue_TB.Value = 13;
			this.Blue_TB.Scroll += new global::System.Windows.Forms.ScrollEventHandler(this.Blue_TB_Scroll);
			this.TopMost_Check.Animated = true;
			this.TopMost_Check.AutoSize = true;
			this.TopMost_Check.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(0, 192, 0);
			this.TopMost_Check.CheckedState.BorderRadius = 0;
			this.TopMost_Check.CheckedState.BorderThickness = 0;
			this.TopMost_Check.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(0, 192, 0);
			this.TopMost_Check.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 15.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.TopMost_Check.ForeColor = global::System.Drawing.SystemColors.ControlLightLight;
			this.TopMost_Check.Location = new global::System.Drawing.Point(23, 151);
			this.TopMost_Check.Name = "TopMost_Check";
			this.TopMost_Check.Size = new global::System.Drawing.Size(176, 29);
			this.TopMost_Check.TabIndex = 22;
			this.TopMost_Check.Text = "Always On Top";
			this.TopMost_Check.UncheckedState.BorderColor = global::System.Drawing.Color.FromArgb(125, 137, 149);
			this.TopMost_Check.UncheckedState.BorderRadius = 0;
			this.TopMost_Check.UncheckedState.BorderThickness = 0;
			this.TopMost_Check.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(125, 137, 149);
			this.TopMost_Check.CheckedChanged += new global::System.EventHandler(this.TopMost_Check_CheckedChanged);
			this.label6.AutoSize = true;
			this.label6.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label6.ForeColor = global::System.Drawing.SystemColors.ControlLightLight;
			this.label6.Location = new global::System.Drawing.Point(25, 196);
			this.label6.Name = "label6";
			this.label6.Size = new global::System.Drawing.Size(66, 20);
			this.label6.TabIndex = 23;
			this.label6.Text = "Process";
			this.ProcessSelectJavaw.Animated = true;
			this.ProcessSelectJavaw.AutoSize = true;
			this.ProcessSelectJavaw.Checked = true;
			this.ProcessSelectJavaw.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(0, 192, 0);
			this.ProcessSelectJavaw.CheckedState.BorderThickness = 0;
			this.ProcessSelectJavaw.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(0, 192, 0);
			this.ProcessSelectJavaw.CheckedState.InnerColor = global::System.Drawing.Color.White;
			this.ProcessSelectJavaw.CheckedState.InnerOffset = -4;
			this.ProcessSelectJavaw.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.ProcessSelectJavaw.ForeColor = global::System.Drawing.SystemColors.ControlLightLight;
			this.ProcessSelectJavaw.Location = new global::System.Drawing.Point(23, 219);
			this.ProcessSelectJavaw.Name = "ProcessSelectJavaw";
			this.ProcessSelectJavaw.Size = new global::System.Drawing.Size(86, 20);
			this.ProcessSelectJavaw.TabIndex = 30;
			this.ProcessSelectJavaw.TabStop = true;
			this.ProcessSelectJavaw.Text = "javaw.exe";
			this.ProcessSelectJavaw.UncheckedState.BorderColor = global::System.Drawing.Color.FromArgb(125, 137, 149);
			this.ProcessSelectJavaw.UncheckedState.BorderThickness = 2;
			this.ProcessSelectJavaw.UncheckedState.FillColor = global::System.Drawing.Color.Transparent;
			this.ProcessSelectJavaw.UncheckedState.InnerColor = global::System.Drawing.Color.Transparent;
			this.ProcessSelectJavaw.CheckedChanged += new global::System.EventHandler(this.ProcessSelectJavaw_CheckedChanged);
			this.ProcessSelectjava.Animated = true;
			this.ProcessSelectjava.AutoSize = true;
			this.ProcessSelectjava.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(0, 192, 0);
			this.ProcessSelectjava.CheckedState.BorderThickness = 0;
			this.ProcessSelectjava.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(0, 192, 0);
			this.ProcessSelectjava.CheckedState.InnerColor = global::System.Drawing.Color.White;
			this.ProcessSelectjava.CheckedState.InnerOffset = -4;
			this.ProcessSelectjava.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.ProcessSelectjava.ForeColor = global::System.Drawing.SystemColors.ControlLightLight;
			this.ProcessSelectjava.Location = new global::System.Drawing.Point(23, 245);
			this.ProcessSelectjava.Name = "ProcessSelectjava";
			this.ProcessSelectjava.Size = new global::System.Drawing.Size(77, 20);
			this.ProcessSelectjava.TabIndex = 31;
			this.ProcessSelectjava.Text = "java.exe";
			this.ProcessSelectjava.UncheckedState.BorderColor = global::System.Drawing.Color.FromArgb(125, 137, 149);
			this.ProcessSelectjava.UncheckedState.BorderThickness = 2;
			this.ProcessSelectjava.UncheckedState.FillColor = global::System.Drawing.Color.Transparent;
			this.ProcessSelectjava.UncheckedState.InnerColor = global::System.Drawing.Color.Transparent;
			this.ProcessSelectjava.CheckedChanged += new global::System.EventHandler(this.ProcessSelectjava_CheckedChanged);
			this.ProcessSelectCustom.Animated = true;
			this.ProcessSelectCustom.AutoSize = true;
			this.ProcessSelectCustom.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(0, 192, 0);
			this.ProcessSelectCustom.CheckedState.BorderThickness = 0;
			this.ProcessSelectCustom.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(0, 192, 0);
			this.ProcessSelectCustom.CheckedState.InnerColor = global::System.Drawing.Color.White;
			this.ProcessSelectCustom.CheckedState.InnerOffset = -4;
			this.ProcessSelectCustom.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.ProcessSelectCustom.ForeColor = global::System.Drawing.SystemColors.ControlLightLight;
			this.ProcessSelectCustom.Location = new global::System.Drawing.Point(23, 271);
			this.ProcessSelectCustom.Name = "ProcessSelectCustom";
			this.ProcessSelectCustom.Size = new global::System.Drawing.Size(123, 20);
			this.ProcessSelectCustom.TabIndex = 32;
			this.ProcessSelectCustom.Text = "Custom process";
			this.ProcessSelectCustom.UncheckedState.BorderColor = global::System.Drawing.Color.FromArgb(125, 137, 149);
			this.ProcessSelectCustom.UncheckedState.BorderThickness = 2;
			this.ProcessSelectCustom.UncheckedState.FillColor = global::System.Drawing.Color.Transparent;
			this.ProcessSelectCustom.UncheckedState.InnerColor = global::System.Drawing.Color.Transparent;
			this.ProcessSelectCustom.CheckedChanged += new global::System.EventHandler(this.ProcessSelectCustom_CheckedChanged);
			this.CustomProcessName_Box.Animated = true;
			this.CustomProcessName_Box.BackColor = global::System.Drawing.Color.FromArgb(25, 25, 25);
			this.CustomProcessName_Box.BorderColor = global::System.Drawing.Color.Gray;
			this.CustomProcessName_Box.BorderThickness = 0;
			this.CustomProcessName_Box.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.CustomProcessName_Box.DefaultText = "";
			this.CustomProcessName_Box.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.CustomProcessName_Box.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.CustomProcessName_Box.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.CustomProcessName_Box.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.CustomProcessName_Box.FillColor = global::System.Drawing.Color.FromArgb(25, 25, 25);
			this.CustomProcessName_Box.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.CustomProcessName_Box.Font = new global::System.Drawing.Font("Segoe UI", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.CustomProcessName_Box.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.CustomProcessName_Box.Location = new global::System.Drawing.Point(152, 271);
			this.CustomProcessName_Box.Name = "CustomProcessName_Box";
			this.CustomProcessName_Box.PasswordChar = '\0';
			this.CustomProcessName_Box.PlaceholderText = "Process Name";
			this.CustomProcessName_Box.SelectedText = "";
			this.CustomProcessName_Box.Size = new global::System.Drawing.Size(98, 20);
			this.CustomProcessName_Box.TabIndex = 33;
			this.CustomProcessName_Box.TextChanged += new global::System.EventHandler(this.CustomProcessName_Box_TextChanged);
			this.Decoration_TextBox.BackColor = global::System.Drawing.Color.FromArgb(0, 192, 0);
			this.Decoration_TextBox.Location = new global::System.Drawing.Point(152, 292);
			this.Decoration_TextBox.Name = "Decoration_TextBox";
			this.Decoration_TextBox.Size = new global::System.Drawing.Size(98, 2);
			this.Decoration_TextBox.TabIndex = 9;
			this.guna2HtmlLabel1.BackColor = global::System.Drawing.Color.Transparent;
			this.guna2HtmlLabel1.ForeColor = global::System.Drawing.Color.DimGray;
			this.guna2HtmlLabel1.Location = new global::System.Drawing.Point(253, 275);
			this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
			this.guna2HtmlLabel1.Size = new global::System.Drawing.Size(23, 15);
			this.guna2HtmlLabel1.TabIndex = 34;
			this.guna2HtmlLabel1.Text = ".exe";
			this.Decoration_GuiLabel.BackColor = global::System.Drawing.Color.FromArgb(0, 192, 0);
			this.Decoration_GuiLabel.Location = new global::System.Drawing.Point(22, 65);
			this.Decoration_GuiLabel.Name = "Decoration_GuiLabel";
			this.Decoration_GuiLabel.Size = new global::System.Drawing.Size(2, 14);
			this.Decoration_GuiLabel.TabIndex = 9;
			this.Decoration_ProcessLabel.BackColor = global::System.Drawing.Color.FromArgb(0, 192, 0);
			this.Decoration_ProcessLabel.Location = new global::System.Drawing.Point(22, 199);
			this.Decoration_ProcessLabel.Name = "Decoration_ProcessLabel";
			this.Decoration_ProcessLabel.Size = new global::System.Drawing.Size(2, 14);
			this.Decoration_ProcessLabel.TabIndex = 10;
			this.ProcessToolTipBox.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("ProcessToolTipBox.Image");
			this.ProcessToolTipBox.ImageRotate = 0f;
			this.ProcessToolTipBox.Location = new global::System.Drawing.Point(91, 200);
			this.ProcessToolTipBox.Name = "ProcessToolTipBox";
			this.ProcessToolTipBox.Size = new global::System.Drawing.Size(16, 16);
			this.ProcessToolTipBox.TabIndex = 35;
			this.ProcessToolTipBox.TabStop = false;
			this.ProcessToolTip.SetToolTip(this.ProcessToolTipBox, "Change this if the clicker does not work on your client. \r\nGo to discord if you have problems.");
			this.ProcessToolTip.AllowLinksHandling = true;
			this.ProcessToolTip.BackColor = global::System.Drawing.Color.FromArgb(15, 15, 15);
			this.ProcessToolTip.BorderColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.ProcessToolTip.ForeColor = global::System.Drawing.SystemColors.ControlLightLight;
			this.ProcessToolTip.MaximumSize = new global::System.Drawing.Size(0, 0);
			this.ProcessToolTip.TitleForeColor = global::System.Drawing.Color.FromArgb(0, 192, 0);
			this.ProcessToolTip.ToolTipTitle = "Process";
			this.GuiToolTip_Box.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("GuiToolTip_Box.Image");
			this.GuiToolTip_Box.ImageRotate = 0f;
			this.GuiToolTip_Box.Location = new global::System.Drawing.Point(63, 66);
			this.GuiToolTip_Box.Name = "GuiToolTip_Box";
			this.GuiToolTip_Box.Size = new global::System.Drawing.Size(16, 16);
			this.GuiToolTip_Box.TabIndex = 36;
			this.GuiToolTip_Box.TabStop = false;
			this.GuiToolTip.SetToolTip(this.GuiToolTip_Box, "Here, you can custom the GUI of Krokmou Clicker.");
			this.GuiToolTip.AllowLinksHandling = true;
			this.GuiToolTip.BackColor = global::System.Drawing.Color.FromArgb(15, 15, 15);
			this.GuiToolTip.BorderColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.GuiToolTip.ForeColor = global::System.Drawing.SystemColors.ControlLightLight;
			this.GuiToolTip.MaximumSize = new global::System.Drawing.Size(0, 0);
			this.GuiToolTip.TitleForeColor = global::System.Drawing.Color.FromArgb(0, 192, 0);
			this.GuiToolTip.ToolTipTitle = "GUI";
			this.TopMostToolTip_Box.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("TopMostToolTip_Box.Image");
			this.TopMostToolTip_Box.ImageRotate = 0f;
			this.TopMostToolTip_Box.Location = new global::System.Drawing.Point(195, 158);
			this.TopMostToolTip_Box.Name = "TopMostToolTip_Box";
			this.TopMostToolTip_Box.Size = new global::System.Drawing.Size(16, 16);
			this.TopMostToolTip_Box.TabIndex = 37;
			this.TopMostToolTip_Box.TabStop = false;
			this.TopMostToolTip.SetToolTip(this.TopMostToolTip_Box, "This option makes Krokmou Clicker constantly stand out from all other processes.");
			this.TopMostToolTip.AllowLinksHandling = true;
			this.TopMostToolTip.BackColor = global::System.Drawing.Color.FromArgb(15, 15, 15);
			this.TopMostToolTip.BorderColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.TopMostToolTip.ForeColor = global::System.Drawing.SystemColors.ControlLightLight;
			this.TopMostToolTip.MaximumSize = new global::System.Drawing.Size(0, 0);
			this.TopMostToolTip.TitleForeColor = global::System.Drawing.Color.FromArgb(0, 192, 0);
			this.TopMostToolTip.ToolTipTitle = "Always on top";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(25, 25, 25);
			base.ClientSize = new global::System.Drawing.Size(496, 325);
			base.Controls.Add(this.TopMostToolTip_Box);
			base.Controls.Add(this.GuiToolTip_Box);
			base.Controls.Add(this.ProcessToolTipBox);
			base.Controls.Add(this.Decoration_ProcessLabel);
			base.Controls.Add(this.Decoration_GuiLabel);
			base.Controls.Add(this.guna2HtmlLabel1);
			base.Controls.Add(this.Decoration_TextBox);
			base.Controls.Add(this.CustomProcessName_Box);
			base.Controls.Add(this.ProcessSelectCustom);
			base.Controls.Add(this.ProcessSelectjava);
			base.Controls.Add(this.ProcessSelectJavaw);
			base.Controls.Add(this.label6);
			base.Controls.Add(this.TopMost_Check);
			base.Controls.Add(this.label5);
			base.Controls.Add(this.Blue_TB);
			base.Controls.Add(this.label4);
			base.Controls.Add(this.Green_TB);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.Red_TB);
			base.Controls.Add(this.Decoration_Settings);
			base.Controls.Add(this.label1);
			this.ForeColor = global::System.Drawing.SystemColors.ControlLightLight;
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = "SettingsForm";
			this.Text = "SettingsForm";
			this.ProcessToolTipBox.EndInit();
			this.GuiToolTip_Box.EndInit();
			this.TopMostToolTip_Box.EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000097 RID: 151
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000098 RID: 152
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000099 RID: 153
		private global::System.Windows.Forms.Panel Decoration_Settings;

		// Token: 0x0400009A RID: 154
		private global::Guna.UI2.WinForms.Guna2TrackBar Red_TB;

		// Token: 0x0400009B RID: 155
		private global::System.Windows.Forms.Label label2;

		// Token: 0x0400009C RID: 156
		private global::System.Windows.Forms.Label label3;

		// Token: 0x0400009D RID: 157
		private global::System.Windows.Forms.Label label4;

		// Token: 0x0400009E RID: 158
		private global::Guna.UI2.WinForms.Guna2TrackBar Green_TB;

		// Token: 0x0400009F RID: 159
		private global::System.Windows.Forms.Label label5;

		// Token: 0x040000A0 RID: 160
		private global::Guna.UI2.WinForms.Guna2TrackBar Blue_TB;

		// Token: 0x040000A1 RID: 161
		private global::Guna.UI2.WinForms.Guna2CheckBox TopMost_Check;

		// Token: 0x040000A2 RID: 162
		private global::System.Windows.Forms.Label label6;

		// Token: 0x040000A3 RID: 163
		private global::Guna.UI2.WinForms.Guna2RadioButton ProcessSelectJavaw;

		// Token: 0x040000A4 RID: 164
		private global::Guna.UI2.WinForms.Guna2RadioButton ProcessSelectjava;

		// Token: 0x040000A5 RID: 165
		private global::Guna.UI2.WinForms.Guna2RadioButton ProcessSelectCustom;

		// Token: 0x040000A6 RID: 166
		private global::Guna.UI2.WinForms.Guna2TextBox CustomProcessName_Box;

		// Token: 0x040000A7 RID: 167
		private global::System.Windows.Forms.Panel Decoration_TextBox;

		// Token: 0x040000A8 RID: 168
		private global::Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;

		// Token: 0x040000A9 RID: 169
		private global::System.Windows.Forms.Panel Decoration_GuiLabel;

		// Token: 0x040000AA RID: 170
		private global::System.Windows.Forms.Panel Decoration_ProcessLabel;

		// Token: 0x040000AB RID: 171
		private global::Guna.UI2.WinForms.Guna2PictureBox ProcessToolTipBox;

		// Token: 0x040000AC RID: 172
		private global::Guna.UI2.WinForms.Guna2HtmlToolTip ProcessToolTip;

		// Token: 0x040000AD RID: 173
		private global::Guna.UI2.WinForms.Guna2PictureBox GuiToolTip_Box;

		// Token: 0x040000AE RID: 174
		private global::Guna.UI2.WinForms.Guna2HtmlToolTip GuiToolTip;

		// Token: 0x040000AF RID: 175
		private global::Guna.UI2.WinForms.Guna2PictureBox TopMostToolTip_Box;

		// Token: 0x040000B0 RID: 176
		private global::Guna.UI2.WinForms.Guna2HtmlToolTip TopMostToolTip;
	}
}
