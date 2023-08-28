﻿using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using KClicker.utils;
using Krokmou_Clicker_v2.Properties;

namespace Krokmou_Clicker_v2
{
	// Token: 0x02000004 RID: 4
	public partial class MainForm : Form
	{
		// Token: 0x0600000D RID: 13 RVA: 0x00002130 File Offset: 0x00000330
		public MainForm()
		{
			this.InitializeComponent();
			this.SetProfile();
			this.Load();
			this.loadform(new LeftClickerForm());
		}

		// Token: 0x0600000E RID: 14 RVA: 0x0000216D File Offset: 0x0000036D
		private void SetProfile()
		{
			this.Username.Text = MainForm.UsernameInfo;
			this.SetRank();
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002188 File Offset: 0x00000388
		private void SetRank()
		{
			bool flag = LoginForm.UserRank == "Owner";
			if (flag)
			{
				MainForm.UserRankInfo = "Owner";
				this.UserRank.Text = "Owner";
				this.UserRank.ForeColor = Color.Red;
			}
			else
			{
				bool flag2 = LoginForm.UserRank == "BetaTester";
				if (flag2)
				{
					MainForm.UserRankInfo = "Beta-Tester";
					this.UserRank.Text = "Beta-Tester";
					this.UserRank.ForeColor = Color.Pink;
				}
				else
				{
					bool flag3 = LoginForm.UserRank == "Friend";
					if (flag3)
					{
						MainForm.UserRankInfo = "Friend";
						this.UserRank.Text = "Friend";
						this.UserRank.ForeColor = Color.Cyan;
					}
					else
					{
						bool flag4 = LoginForm.UserRank == "Customer";
						if (flag4)
						{
							MainForm.UserRankInfo = "Customer";
							this.UserRank.Text = "Customer";
							this.UserRank.ForeColor = Color.Green;
						}
					}
				}
			}
		}

		// Token: 0x06000010 RID: 16 RVA: 0x000022A6 File Offset: 0x000004A6
		private new void Load()
		{
			this.panelProfileBtn.BackColor = Color.FromArgb(125, 35, 35, 35);
		}

		// Token: 0x06000011 RID: 17 RVA: 0x000022C4 File Offset: 0x000004C4
		public void loadform(object Form)
		{
			bool flag = this.panelMain.Controls.Count > 0;
			if (flag)
			{
				this.panelMain.Controls.RemoveAt(0);
			}
			Form form = Form as Form;
			form.TopLevel = false;
			form.Dock = DockStyle.Fill;
			this.panelMain.Controls.Add(form);
			this.panelMain.Tag = form;
			form.Show();
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002338 File Offset: 0x00000538
		private void btnLeftClicker_Click(object sender, EventArgs e)
		{
			this.loadform(new LeftClickerForm());
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002347 File Offset: 0x00000547
		private void btnRightClicker_Click(object sender, EventArgs e)
		{
			this.loadform(new RightClickerForm());
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002356 File Offset: 0x00000556
		private void btnSettings_Click(object sender, EventArgs e)
		{
			this.loadform(new SettingsForm());
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002365 File Offset: 0x00000565
		private void btnClose_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		// Token: 0x06000016 RID: 22 RVA: 0x0000236E File Offset: 0x0000056E
		private void btnMinimize_Click(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002379 File Offset: 0x00000579
		private void panelHeader_MouseDown(object sender, MouseEventArgs e)
		{
			this.mouseLocation = new Point(-e.X, -e.Y);
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002398 File Offset: 0x00000598
		private void panelHeader_MouseMove(object sender, MouseEventArgs e)
		{
			bool flag = e.Button == MouseButtons.Left;
			if (flag)
			{
				Point mousePosition = Control.MousePosition;
				mousePosition.Offset(this.mouseLocation.X, this.mouseLocation.Y);
				base.Location = mousePosition;
			}
		}

		// Token: 0x06000019 RID: 25 RVA: 0x000023E5 File Offset: 0x000005E5
		private void panelProfileBtn_MouseEnter(object sender, EventArgs e)
		{
			this.panelProfileBtn.BackColor = Color.DimGray;
		}

		// Token: 0x0600001A RID: 26 RVA: 0x000023F9 File Offset: 0x000005F9
		private void panelProfileBtn_MouseLeave(object sender, EventArgs e)
		{
			this.panelProfileBtn.BackColor = Color.FromArgb(35, 35, 35);
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002413 File Offset: 0x00000613
		private void panelProfileBtn_MouseDown(object sender, MouseEventArgs e)
		{
			this.panelProfileBtn.BackColor = Color.Gray;
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002427 File Offset: 0x00000627
		private void panelProfileBtn_Click(object sender, EventArgs e)
		{
			this.panelProfileBtn.BackColor = Color.Gray;
			Thread.Sleep(2);
			this.panelProfileBtn.BackColor = Color.DimGray;
			this.loadform(new ProfileForm());
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002460 File Offset: 0x00000660
		public void StartLeftClicker()
		{
			bool flag = MainForm.left_Click;
			if (flag)
			{
				this.LeftClicker.Start();
			}
			else
			{
				this.LeftClicker.Stop();
			}
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002498 File Offset: 0x00000698
		private void LeftClicker_Tick(object sender, EventArgs e)
		{
			this.LeftClicker.Interval = 1000 / this.rdn.Next(MainForm.left_Min, MainForm.left_Max);
			Process[] processesByName = Process.GetProcessesByName(MainForm.target_Process);
			foreach (Process process in processesByName)
			{
				bool flag = Imports.GetForegroundWindow() == Imports.FindWindow(null, process.MainWindowTitle);
				if (flag)
				{
					bool flag2 = MainForm.left_Click;
					if (flag2)
					{
						bool flag3 = Control.MouseButtons == MouseButtons.Left;
						if (flag3)
						{
							bool flag4 = MainForm.left_Break;
							if (flag4)
							{
								Utils.SendLeftClickBreak();
							}
							else
							{
								Utils.SendLeftClick();
							}
							bool flag5 = MainForm.left_Sound;
							if (flag5)
							{
								Utils.ClickSound();
							}
						}
					}
				}
			}
		}

		// Token: 0x0600001F RID: 31 RVA: 0x0000255C File Offset: 0x0000075C
		private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.guna2CheckBox1.Checked;
			if (@checked)
			{
				this.LeftClicker.Start();
				this.RightClicker.Start();
			}
			else
			{
				this.LeftClicker.Stop();
				this.RightClicker.Stop();
			}
		}

		// Token: 0x06000020 RID: 32 RVA: 0x000025AF File Offset: 0x000007AF
		private void btnPresets_Click(object sender, EventArgs e)
		{
			this.loadform(new ConfigsForm());
		}

		// Token: 0x06000021 RID: 33 RVA: 0x000025C0 File Offset: 0x000007C0
		public void StartRightClicker()
		{
			bool flag = MainForm.right_Click;
			if (flag)
			{
				this.RightClicker.Start();
			}
			else
			{
				this.RightClicker.Stop();
			}
		}

		// Token: 0x06000022 RID: 34 RVA: 0x000025F8 File Offset: 0x000007F8
		private void RightClicker_Tick(object sender, EventArgs e)
		{
			this.RightClicker.Interval = 1000 / this.rdn.Next(MainForm.right_Min, MainForm.right_Max);
			Process[] processesByName = Process.GetProcessesByName("javaw");
			foreach (Process process in processesByName)
			{
				bool flag = Imports.GetForegroundWindow() == Imports.FindWindow(null, process.MainWindowTitle);
				if (flag)
				{
					bool flag2 = MainForm.right_Click;
					if (flag2)
					{
						bool flag3 = Control.MouseButtons == MouseButtons.Right;
						if (flag3)
						{
							Utils.SendRightClick();
							bool flag4 = MainForm.right_Sound;
							if (flag4)
							{
								Utils.ClickSound();
							}
						}
					}
				}
			}
		}

		// Token: 0x06000023 RID: 35 RVA: 0x000026A3 File Offset: 0x000008A3
		private void discordBtn_Main_MouseEnter(object sender, EventArgs e)
		{
			this.discordBtn_Main.Image = Resources.mini_discordBtn_on;
		}

		// Token: 0x06000024 RID: 36 RVA: 0x000026B7 File Offset: 0x000008B7
		private void discordBtn_Main_MouseLeave(object sender, EventArgs e)
		{
			this.discordBtn_Main.Image = Resources.mini_discordBtn_off;
		}

		// Token: 0x06000025 RID: 37 RVA: 0x000026CB File Offset: 0x000008CB
		private void discordBtn_Main_Click(object sender, EventArgs e)
		{
			Process.Start("https://discord.gg/wadRVZsrpw");
		}

		// Token: 0x04000001 RID: 1
		public static string UsernameInfo = LoginForm.UsernameString;

		// Token: 0x04000002 RID: 2
		public static string UserRankInfo = "Unknow";

		// Token: 0x04000003 RID: 3
		public static string UserIDInfo = LoginForm.UserID;

		// Token: 0x04000004 RID: 4
		public static string target_Process = "javaw";

		// Token: 0x04000005 RID: 5
		public static string target_Custom = "";

		// Token: 0x04000006 RID: 6
		public static bool left_Click = false;

		// Token: 0x04000007 RID: 7
		public static int left_Min = 13;

		// Token: 0x04000008 RID: 8
		public static int left_Max = 13;

		// Token: 0x04000009 RID: 9
		public static bool left_Break = false;

		// Token: 0x0400000A RID: 10
		public static bool left_Sound = false;

		// Token: 0x0400000B RID: 11
		public static bool right_Click = false;

		// Token: 0x0400000C RID: 12
		public static int right_Min = 13;

		// Token: 0x0400000D RID: 13
		public static int right_Max = 13;

		// Token: 0x0400000E RID: 14
		public static bool right_Sound = false;

		// Token: 0x0400000F RID: 15
		public static bool topmost = false;

		// Token: 0x04000010 RID: 16
		public static double tb_red = 0.0;

		// Token: 0x04000011 RID: 17
		public static double tb_green = 100.0;

		// Token: 0x04000012 RID: 18
		public static double tb_blue = 0.0;

		// Token: 0x04000013 RID: 19
		public Point mouseLocation;

		// Token: 0x04000014 RID: 20
		public static int x;

		// Token: 0x04000015 RID: 21
		public static int y;

		// Token: 0x04000016 RID: 22
		private Random rdn = new Random();
	}
}
