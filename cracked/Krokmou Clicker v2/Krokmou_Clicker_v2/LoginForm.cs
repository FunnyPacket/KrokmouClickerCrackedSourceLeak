﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Management;
using System.Media;
using System.Net;
using System.Text;
using System.Windows.Forms;
using Krokmou_Clicker_v2.Properties;

namespace Krokmou_Clicker_v2
{
	// Token: 0x02000006 RID: 6
	public partial class LoginForm : Form
	{
		// Token: 0x06000033 RID: 51 RVA: 0x000022D5 File Offset: 0x000004D5
		public LoginForm()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000034 RID: 52 RVA: 0x0000218E File Offset: 0x0000038E
		private void closeBTN_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00002197 File Offset: 0x00000397
		private void minimizeBTN_Click(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		// Token: 0x06000036 RID: 54 RVA: 0x000022ED File Offset: 0x000004ED
		private void panelHeader_MouseDown(object sender, MouseEventArgs e)
		{
			this.mouseLocation = new Point(-e.X, -e.Y);
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00004D98 File Offset: 0x00002F98
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

		// Token: 0x06000038 RID: 56 RVA: 0x00002309 File Offset: 0x00000509
		private void LoginBTN_MouseEnter(object sender, EventArgs e)
		{
			this.LoginBTN.ForeColor = Color.Black;
		}

		// Token: 0x06000039 RID: 57 RVA: 0x0000231D File Offset: 0x0000051D
		private void LoginBTN_MouseLeave(object sender, EventArgs e)
		{
			this.LoginBTN.ForeColor = Color.White;
		}

		// Token: 0x0600003A RID: 58 RVA: 0x0000231D File Offset: 0x0000051D
		private void LoginBTN_MouseDown(object sender, MouseEventArgs e)
		{
			this.LoginBTN.ForeColor = Color.White;
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00002309 File Offset: 0x00000509
		private void LoginBTN_MouseUp(object sender, MouseEventArgs e)
		{
			this.LoginBTN.ForeColor = Color.Black;
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00002331 File Offset: 0x00000531
		private void btnDiscord_MouseLeave(object sender, EventArgs e)
		{
			this.btnDiscord.Image = Resources.discordBtn_off;
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00002345 File Offset: 0x00000545
		private void LoginBTN_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Cracked by .antigamingchair / google / https://github.com/FunnyPacket", "got cracked https://discord.gg/astre");
			new MainForm().Show();
			base.Hide();
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00004DE8 File Offset: 0x00002FE8
		private static string para3()
		{
			string str = "";
			ManagementObjectCollection.ManagementObjectEnumerator enumerator = new ManagementObjectSearcher("Select * From Win32_processor").Get().GetEnumerator();
			try
			{
				for (;;)
				{
					bool flag = !enumerator.MoveNext();
					if (flag)
					{
						break;
					}
					ManagementObject managementObject = (ManagementObject)enumerator.Current;
					str = managementObject["ProcessorID"].ToString();
				}
			}
			finally
			{
				bool flag2 = enumerator != null;
				if (flag2)
				{
					enumerator.Dispose();
				}
			}
			ManagementObject managementObject2 = new ManagementObject("win32_logicaldisk.deviceid=\"c:\"");
			managementObject2.Get();
			return str + managementObject2["VolumeSerialNumber"].ToString();
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00004EA4 File Offset: 0x000030A4
		public static string StringToHex(string hexstring)
		{
			StringBuilder stringBuilder = new StringBuilder();
			foreach (char value in hexstring)
			{
				stringBuilder.Append(Convert.ToInt32(value).ToString("x"));
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00004F00 File Offset: 0x00003100
		private void HWIDReset()
		{
			this.LoginStatus.Text = "Checking HWID...";
			try
			{
				string address = "https://krokmouclicker.000webhostapp.com/API/execute.php?action=sendhwid&username=" + this.Username.Text + "&hwid=" + LoginForm.para3();
				WebClient webClient = new WebClient();
				string a = webClient.DownloadString("https://krokmouclicker.000webhostapp.com/API/execute.php?action=hwid&username=" + this.Username.Text);
				bool flag = a == "RESET";
				if (flag)
				{
					this.LoginStatus.Text = "Reseting HWID...";
					WebClient webClient2 = new WebClient();
					webClient2.DownloadString(address);
					MessageBox.Show(this.Username.Text + " HWID reset, you can now use for this PC !", "Krokmou Clicker", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				}
			}
			catch (Exception)
			{
				this.LoginStatus.Text = "HWID Error, contact an admin";
				MessageBox.Show("Impossible to get / change HWID, contact an admin !");
				Application.Exit();
			}
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00004FF4 File Offset: 0x000031F4
		private void HWIDAllowed()
		{
			string b = LoginForm.para3();
			try
			{
				WebClient webClient = new WebClient();
				string a = webClient.DownloadString("https://krokmouclicker.000webhostapp.com/API/execute.php?action=hwid&username=" + this.Username.Text);
				bool flag = a == b;
				if (flag)
				{
					this.AllowAccess();
				}
				else
				{
					this.LoginStatus.Text = "Invalid HWID";
					MessageBox.Show("This account is registered to a another PC !", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
			}
			catch (Exception)
			{
				this.LoginStatus.Text = "API Error, contact an admin.";
				MessageBox.Show("API is offline, contact an admin or wait.", "SERVER ERROR", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		// Token: 0x06000042 RID: 66 RVA: 0x000050A4 File Offset: 0x000032A4
		private void GETIP()
		{
			try
			{
				string str = new WebClient().DownloadString("http://ipinfo.io/ip");
				string text = new WebClient().DownloadString("https://krokmouclicker.000webhostapp.com/API/execute.php?action=GETIP&username=" + this.Username.Text);
				string text2 = new WebClient().DownloadString("https://krokmouclicker.000webhostapp.com/API/execute.php?action=IP&username=" + this.Username.Text + "&ip=" + str);
			}
			catch (Exception)
			{
				MessageBox.Show("Impossible to get / change IP, contact an admin !");
				Application.Exit();
			}
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00005134 File Offset: 0x00003334
		public static int Execute(string action, string args)
		{
			WebClient webClient = new WebClient();
			string str = "https://krokmouclicker.000webhostapp.com/API/execute.php";
			string str2 = "?action=" + action;
			string str3 = "&" + args;
			string address = str + str2 + str3;
			string text = webClient.DownloadString(address);
			bool flag = text == null;
			int result;
			if (flag)
			{
				result = 0;
			}
			else
			{
				bool flag2 = !text.StartsWith("LOGIN_GOOD");
				if (flag2)
				{
					LoginForm.CheckError(text);
					result = 0;
				}
				else
				{
					result = 1;
				}
			}
			return result;
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00002367 File Offset: 0x00000567
		public static void RaiseError(string error)
		{
			MessageBox.Show(error, "Oops..", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}

		// Token: 0x06000045 RID: 69 RVA: 0x000051B8 File Offset: 0x000033B8
		public static int CheckError(string error)
		{
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			dictionary.Add("MISSING_PARAMETERS", "Missing parameters");
			dictionary.Add("INVALID_KEY", "The registration key is not valid");
			dictionary.Add("USERNAME_TOO_SHORT", "Your username is too short");
			dictionary.Add("PASSWORD_TOO_SHORT", "Your password is too short");
			dictionary.Add("USERNAME_TAKEN", "The username you choose is already taken");
			dictionary.Add("PASSWORDS_NOT_MATCH", "Passwords do not match");
			dictionary.Add("USER_BANNED", "You are banned.");
			dictionary.Add("NO_ACTION", "No action");
			dictionary.Add("NOT_ENOUGH_PRIVILEGES", "You do not have enough privileges");
			dictionary.Add("INVALID_CREDENTIALS", "Invalid Username or Password.");
			bool flag = !error.StartsWith("API");
			int result;
			if (flag)
			{
				LoginForm.RaiseError(error);
				result = 0;
			}
			else
			{
				string error2 = "Undefined error";
				string[] array = error.Split(new char[]
				{
					':'
				});
				bool flag2 = array.Length == 2 && dictionary.ContainsKey(array[1]);
				if (flag2)
				{
					string key = array[1];
					error2 = dictionary[key];
				}
				LoginForm.RaiseError(error2);
				result = 1;
			}
			return result;
		}

		// Token: 0x06000046 RID: 70 RVA: 0x000052E4 File Offset: 0x000034E4
		private void textBoxUsername_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			if (flag)
			{
				this.LoginBTN_Click(null, null);
			}
		}

		// Token: 0x06000047 RID: 71 RVA: 0x000052E4 File Offset: 0x000034E4
		private void textBoxPassword_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			if (flag)
			{
				this.LoginBTN_Click(null, null);
			}
		}

		// Token: 0x06000048 RID: 72 RVA: 0x0000530C File Offset: 0x0000350C
		private void AllowAccess()
		{
			Stream krokmouLaunch = Resources.KrokmouLaunch;
			new SoundPlayer(krokmouLaunch).Play();
			WebClient webClient = new WebClient();
			LoginForm.UserRank = webClient.DownloadString("https://krokmouclicker.000webhostapp.com/API/execute.php?action=GETRANK&username=" + this.Username.Text);
			LoginForm.UserID = webClient.DownloadString("https://krokmouclicker.000webhostapp.com/API/execute.php?action=GETUSERID&username=" + this.Username.Text);
			LoginForm.UsernameString = this.Username.Text;
			this.LoginStatus.Text = "Logged successfull !";
			MessageBox.Show("Welcome " + this.Username.Text + " enjoy with Krokmou Clicker !");
			MainForm mainForm = new MainForm();
			mainForm.Show();
			base.Hide();
		}

		// Token: 0x06000049 RID: 73 RVA: 0x0000226F File Offset: 0x0000046F
		private void btnDiscord_Click(object sender, EventArgs e)
		{
			Process.Start("https://discord.gg/wadRVZsrpw");
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00002379 File Offset: 0x00000579
		private void btnDiscord_MouseEnter(object sender, EventArgs e)
		{
			this.btnDiscord.Image = Resources.discordBtn_on;
		}

		// Token: 0x0400003E RID: 62
		public Point mouseLocation;

		// Token: 0x0400003F RID: 63
		public static int x;

		// Token: 0x04000040 RID: 64
		public static int y;

		// Token: 0x04000041 RID: 65
		public static string UsernameString = "";

		// Token: 0x04000042 RID: 66
		public static string UserRank = "";

		// Token: 0x04000043 RID: 67
		public static string UserID = "";
	}
}
