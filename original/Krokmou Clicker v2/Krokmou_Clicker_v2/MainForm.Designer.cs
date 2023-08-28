namespace Krokmou_Clicker_v2
{
	// Token: 0x02000004 RID: 4
	public partial class MainForm : global::System.Windows.Forms.Form
	{
		// Token: 0x06000026 RID: 38 RVA: 0x000026DC File Offset: 0x000008DC
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002714 File Offset: 0x00000914
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Krokmou_Clicker_v2.MainForm));
			this.panelSide = new global::System.Windows.Forms.Panel();
			this.guna2CheckBox1 = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.panelProfileBtn = new global::System.Windows.Forms.Panel();
			this.UserRank = new global::System.Windows.Forms.Label();
			this.Username = new global::System.Windows.Forms.Label();
			this.panelHeader = new global::System.Windows.Forms.Panel();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label1 = new global::System.Windows.Forms.Label();
			this.btnMinimize = new global::System.Windows.Forms.Button();
			this.btnClose = new global::System.Windows.Forms.Button();
			this.panelMain = new global::System.Windows.Forms.Panel();
			this.LeftClicker = new global::System.Windows.Forms.Timer(this.components);
			this.RightClicker = new global::System.Windows.Forms.Timer(this.components);
			this.discordBtn_Main = new global::System.Windows.Forms.PictureBox();
			this.btnConfigs = new global::System.Windows.Forms.Button();
			this.UserPic = new global::System.Windows.Forms.PictureBox();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.btnSettings = new global::System.Windows.Forms.Button();
			this.btnRightClicker = new global::System.Windows.Forms.Button();
			this.btnLeftClicker = new global::System.Windows.Forms.Button();
			this.panelSide.SuspendLayout();
			this.panelProfileBtn.SuspendLayout();
			this.panelHeader.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.discordBtn_Main).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.UserPic).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			base.SuspendLayout();
			this.panelSide.BackColor = global::System.Drawing.Color.FromArgb(35, 35, 35);
			this.panelSide.Controls.Add(this.discordBtn_Main);
			this.panelSide.Controls.Add(this.btnConfigs);
			this.panelSide.Controls.Add(this.guna2CheckBox1);
			this.panelSide.Controls.Add(this.panelProfileBtn);
			this.panelSide.Controls.Add(this.pictureBox1);
			this.panelSide.Controls.Add(this.btnSettings);
			this.panelSide.Controls.Add(this.btnRightClicker);
			this.panelSide.Controls.Add(this.btnLeftClicker);
			this.panelSide.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.panelSide.Location = new global::System.Drawing.Point(0, 40);
			this.panelSide.Name = "panelSide";
			this.panelSide.Size = new global::System.Drawing.Size(172, 325);
			this.panelSide.TabIndex = 0;
			this.guna2CheckBox1.AutoSize = true;
			this.guna2CheckBox1.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(0, 192, 0);
			this.guna2CheckBox1.CheckedState.BorderRadius = 0;
			this.guna2CheckBox1.CheckedState.BorderThickness = 0;
			this.guna2CheckBox1.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(0, 192, 0);
			this.guna2CheckBox1.ForeColor = global::System.Drawing.SystemColors.ControlLightLight;
			this.guna2CheckBox1.Location = new global::System.Drawing.Point(3, 6);
			this.guna2CheckBox1.Name = "guna2CheckBox1";
			this.guna2CheckBox1.Size = new global::System.Drawing.Size(40, 17);
			this.guna2CheckBox1.TabIndex = 8;
			this.guna2CheckBox1.Text = "On";
			this.guna2CheckBox1.UncheckedState.BorderColor = global::System.Drawing.Color.FromArgb(125, 137, 149);
			this.guna2CheckBox1.UncheckedState.BorderRadius = 0;
			this.guna2CheckBox1.UncheckedState.BorderThickness = 0;
			this.guna2CheckBox1.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(125, 137, 149);
			this.guna2CheckBox1.CheckedChanged += new global::System.EventHandler(this.guna2CheckBox1_CheckedChanged);
			this.panelProfileBtn.BackColor = global::System.Drawing.Color.Transparent;
			this.panelProfileBtn.Controls.Add(this.UserPic);
			this.panelProfileBtn.Controls.Add(this.UserRank);
			this.panelProfileBtn.Controls.Add(this.Username);
			this.panelProfileBtn.Location = new global::System.Drawing.Point(0, 272);
			this.panelProfileBtn.Name = "panelProfileBtn";
			this.panelProfileBtn.Size = new global::System.Drawing.Size(172, 53);
			this.panelProfileBtn.TabIndex = 7;
			this.panelProfileBtn.Click += new global::System.EventHandler(this.panelProfileBtn_Click);
			this.panelProfileBtn.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.panelProfileBtn_MouseDown);
			this.panelProfileBtn.MouseEnter += new global::System.EventHandler(this.panelProfileBtn_MouseEnter);
			this.panelProfileBtn.MouseLeave += new global::System.EventHandler(this.panelProfileBtn_MouseLeave);
			this.UserRank.AutoSize = true;
			this.UserRank.BackColor = global::System.Drawing.Color.Transparent;
			this.UserRank.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
			this.UserRank.ForeColor = global::System.Drawing.SystemColors.ControlLightLight;
			this.UserRank.Location = new global::System.Drawing.Point(48, 28);
			this.UserRank.Name = "UserRank";
			this.UserRank.Size = new global::System.Drawing.Size(33, 13);
			this.UserRank.TabIndex = 6;
			this.UserRank.Text = "Rank";
			this.Username.AutoSize = true;
			this.Username.BackColor = global::System.Drawing.Color.Transparent;
			this.Username.Font = new global::System.Drawing.Font("Arial", 11.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Username.ForeColor = global::System.Drawing.SystemColors.ControlLightLight;
			this.Username.Location = new global::System.Drawing.Point(47, 9);
			this.Username.Name = "Username";
			this.Username.Size = new global::System.Drawing.Size(80, 18);
			this.Username.TabIndex = 5;
			this.Username.Text = "Username";
			this.panelHeader.BackColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.panelHeader.Controls.Add(this.label2);
			this.panelHeader.Controls.Add(this.label1);
			this.panelHeader.Controls.Add(this.btnMinimize);
			this.panelHeader.Controls.Add(this.btnClose);
			this.panelHeader.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.panelHeader.Location = new global::System.Drawing.Point(0, 0);
			this.panelHeader.Name = "panelHeader";
			this.panelHeader.Size = new global::System.Drawing.Size(668, 40);
			this.panelHeader.TabIndex = 1;
			this.panelHeader.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseDown);
			this.panelHeader.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseMove);
			this.label2.AutoSize = true;
			this.label2.Font = new global::System.Drawing.Font("Arial", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label2.ForeColor = global::System.Drawing.SystemColors.ControlLightLight;
			this.label2.Location = new global::System.Drawing.Point(165, 17);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(28, 14);
			this.label2.TabIndex = 4;
			this.label2.Text = "v2.0";
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 15.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.ForeColor = global::System.Drawing.SystemColors.ControlLightLight;
			this.label1.Location = new global::System.Drawing.Point(3, 8);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(169, 25);
			this.label1.TabIndex = 7;
			this.label1.Text = "Krokmou Clicker";
			this.btnMinimize.BackColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.btnMinimize.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Zoom;
			this.btnMinimize.FlatAppearance.BorderSize = 0;
			this.btnMinimize.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btnMinimize.Font = new global::System.Drawing.Font("Arial", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnMinimize.ForeColor = global::System.Drawing.SystemColors.ControlLightLight;
			this.btnMinimize.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.btnMinimize.Location = new global::System.Drawing.Point(588, 0);
			this.btnMinimize.Name = "btnMinimize";
			this.btnMinimize.Size = new global::System.Drawing.Size(40, 40);
			this.btnMinimize.TabIndex = 6;
			this.btnMinimize.Text = "_";
			this.btnMinimize.UseVisualStyleBackColor = false;
			this.btnMinimize.Click += new global::System.EventHandler(this.btnMinimize_Click);
			this.btnClose.BackColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.btnClose.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Zoom;
			this.btnClose.FlatAppearance.BorderSize = 0;
			this.btnClose.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.Font = new global::System.Drawing.Font("Arial", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnClose.ForeColor = global::System.Drawing.SystemColors.ControlLightLight;
			this.btnClose.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.btnClose.Location = new global::System.Drawing.Point(628, 0);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new global::System.Drawing.Size(40, 40);
			this.btnClose.TabIndex = 4;
			this.btnClose.Text = "x";
			this.btnClose.UseVisualStyleBackColor = false;
			this.btnClose.Click += new global::System.EventHandler(this.btnClose_Click);
			this.panelMain.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.panelMain.Location = new global::System.Drawing.Point(172, 40);
			this.panelMain.Name = "panelMain";
			this.panelMain.Size = new global::System.Drawing.Size(496, 325);
			this.panelMain.TabIndex = 2;
			this.LeftClicker.Tick += new global::System.EventHandler(this.LeftClicker_Tick);
			this.RightClicker.Tick += new global::System.EventHandler(this.RightClicker_Tick);
			this.discordBtn_Main.Image = global::Krokmou_Clicker_v2.Properties.Resources.mini_discordBtn_off;
			this.discordBtn_Main.Location = new global::System.Drawing.Point(134, 6);
			this.discordBtn_Main.Name = "discordBtn_Main";
			this.discordBtn_Main.Size = new global::System.Drawing.Size(32, 32);
			this.discordBtn_Main.TabIndex = 0;
			this.discordBtn_Main.TabStop = false;
			this.discordBtn_Main.Click += new global::System.EventHandler(this.discordBtn_Main_Click);
			this.discordBtn_Main.MouseEnter += new global::System.EventHandler(this.discordBtn_Main_MouseEnter);
			this.discordBtn_Main.MouseLeave += new global::System.EventHandler(this.discordBtn_Main_MouseLeave);
			this.btnConfigs.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Zoom;
			this.btnConfigs.FlatAppearance.BorderSize = 0;
			this.btnConfigs.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btnConfigs.Font = new global::System.Drawing.Font("Arial", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnConfigs.ForeColor = global::System.Drawing.SystemColors.ControlLightLight;
			this.btnConfigs.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("btnConfigs.Image");
			this.btnConfigs.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.btnConfigs.Location = new global::System.Drawing.Point(0, 225);
			this.btnConfigs.Name = "btnConfigs";
			this.btnConfigs.Size = new global::System.Drawing.Size(172, 38);
			this.btnConfigs.TabIndex = 9;
			this.btnConfigs.Text = "Configs";
			this.btnConfigs.UseVisualStyleBackColor = true;
			this.btnConfigs.Click += new global::System.EventHandler(this.btnPresets_Click);
			this.UserPic.BackColor = global::System.Drawing.Color.Transparent;
			this.UserPic.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("UserPic.Image");
			this.UserPic.Location = new global::System.Drawing.Point(9, 9);
			this.UserPic.Name = "UserPic";
			this.UserPic.Size = new global::System.Drawing.Size(32, 32);
			this.UserPic.TabIndex = 4;
			this.UserPic.TabStop = false;
			this.pictureBox1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBox1.Image");
			this.pictureBox1.Location = new global::System.Drawing.Point(45, 6);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(83, 79);
			this.pictureBox1.TabIndex = 3;
			this.pictureBox1.TabStop = false;
			this.btnSettings.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Zoom;
			this.btnSettings.FlatAppearance.BorderSize = 0;
			this.btnSettings.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btnSettings.Font = new global::System.Drawing.Font("Arial", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnSettings.ForeColor = global::System.Drawing.SystemColors.ControlLightLight;
			this.btnSettings.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("btnSettings.Image");
			this.btnSettings.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSettings.Location = new global::System.Drawing.Point(0, 181);
			this.btnSettings.Name = "btnSettings";
			this.btnSettings.Size = new global::System.Drawing.Size(172, 38);
			this.btnSettings.TabIndex = 2;
			this.btnSettings.Text = "Settings";
			this.btnSettings.UseVisualStyleBackColor = true;
			this.btnSettings.Click += new global::System.EventHandler(this.btnSettings_Click);
			this.btnRightClicker.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Zoom;
			this.btnRightClicker.FlatAppearance.BorderSize = 0;
			this.btnRightClicker.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btnRightClicker.Font = new global::System.Drawing.Font("Arial", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnRightClicker.ForeColor = global::System.Drawing.SystemColors.ControlLightLight;
			this.btnRightClicker.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("btnRightClicker.Image");
			this.btnRightClicker.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.btnRightClicker.Location = new global::System.Drawing.Point(0, 137);
			this.btnRightClicker.Name = "btnRightClicker";
			this.btnRightClicker.Size = new global::System.Drawing.Size(172, 38);
			this.btnRightClicker.TabIndex = 1;
			this.btnRightClicker.Text = "Right Clicker";
			this.btnRightClicker.UseVisualStyleBackColor = true;
			this.btnRightClicker.Click += new global::System.EventHandler(this.btnRightClicker_Click);
			this.btnLeftClicker.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Zoom;
			this.btnLeftClicker.FlatAppearance.BorderSize = 0;
			this.btnLeftClicker.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.btnLeftClicker.Font = new global::System.Drawing.Font("Arial", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnLeftClicker.ForeColor = global::System.Drawing.SystemColors.ControlLightLight;
			this.btnLeftClicker.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("btnLeftClicker.Image");
			this.btnLeftClicker.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.btnLeftClicker.Location = new global::System.Drawing.Point(0, 93);
			this.btnLeftClicker.Name = "btnLeftClicker";
			this.btnLeftClicker.Size = new global::System.Drawing.Size(172, 38);
			this.btnLeftClicker.TabIndex = 0;
			this.btnLeftClicker.Text = "Left Clicker";
			this.btnLeftClicker.UseVisualStyleBackColor = true;
			this.btnLeftClicker.Click += new global::System.EventHandler(this.btnLeftClicker_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(25, 25, 25);
			base.ClientSize = new global::System.Drawing.Size(668, 365);
			base.Controls.Add(this.panelMain);
			base.Controls.Add(this.panelSide);
			base.Controls.Add(this.panelHeader);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = "MainForm";
			this.panelSide.ResumeLayout(false);
			this.panelSide.PerformLayout();
			this.panelProfileBtn.ResumeLayout(false);
			this.panelProfileBtn.PerformLayout();
			this.panelHeader.ResumeLayout(false);
			this.panelHeader.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.discordBtn_Main).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.UserPic).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000017 RID: 23
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000018 RID: 24
		private global::System.Windows.Forms.Panel panelSide;

		// Token: 0x04000019 RID: 25
		private global::System.Windows.Forms.Panel panelHeader;

		// Token: 0x0400001A RID: 26
		private global::System.Windows.Forms.Panel panelMain;

		// Token: 0x0400001B RID: 27
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x0400001C RID: 28
		private global::System.Windows.Forms.Button btnSettings;

		// Token: 0x0400001D RID: 29
		private global::System.Windows.Forms.Button btnRightClicker;

		// Token: 0x0400001E RID: 30
		private global::System.Windows.Forms.Button btnLeftClicker;

		// Token: 0x0400001F RID: 31
		private global::System.Windows.Forms.Button btnClose;

		// Token: 0x04000020 RID: 32
		private global::System.Windows.Forms.Button btnMinimize;

		// Token: 0x04000021 RID: 33
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000022 RID: 34
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000023 RID: 35
		private global::System.Windows.Forms.Label Username;

		// Token: 0x04000024 RID: 36
		private global::System.Windows.Forms.Label UserRank;

		// Token: 0x04000025 RID: 37
		private global::System.Windows.Forms.Panel panelProfileBtn;

		// Token: 0x04000026 RID: 38
		public global::System.Windows.Forms.Timer LeftClicker;

		// Token: 0x04000027 RID: 39
		private global::System.Windows.Forms.PictureBox UserPic;

		// Token: 0x04000028 RID: 40
		private global::Guna.UI2.WinForms.Guna2CheckBox guna2CheckBox1;

		// Token: 0x04000029 RID: 41
		private global::System.Windows.Forms.Button btnConfigs;

		// Token: 0x0400002A RID: 42
		public global::System.Windows.Forms.Timer RightClicker;

		// Token: 0x0400002B RID: 43
		private global::System.Windows.Forms.PictureBox discordBtn_Main;
	}
}
