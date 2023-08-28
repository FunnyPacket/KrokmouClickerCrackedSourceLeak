namespace Krokmou_Clicker_v2
{
	// Token: 0x02000006 RID: 6
	public partial class LoginForm : global::System.Windows.Forms.Form
	{
		// Token: 0x0600004B RID: 75 RVA: 0x000053C8 File Offset: 0x000035C8
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00005400 File Offset: 0x00003600
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Krokmou_Clicker_v2.LoginForm));
			this.panelHeader = new global::System.Windows.Forms.Panel();
			this.minimizeBTN = new global::System.Windows.Forms.Button();
			this.closeBTN = new global::System.Windows.Forms.Button();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label1 = new global::System.Windows.Forms.Label();
			this.btnMinimize = new global::System.Windows.Forms.Button();
			this.btnClose = new global::System.Windows.Forms.Button();
			this.pictureBox2 = new global::System.Windows.Forms.PictureBox();
			this.Password = new global::System.Windows.Forms.TextBox();
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.panel2 = new global::System.Windows.Forms.Panel();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.Username = new global::System.Windows.Forms.TextBox();
			this.pictureBox3 = new global::System.Windows.Forms.PictureBox();
			this.LoginBTN = new global::System.Windows.Forms.Button();
			this.btnDiscord = new global::System.Windows.Forms.PictureBox();
			this.label3 = new global::System.Windows.Forms.Label();
			this.label4 = new global::System.Windows.Forms.Label();
			this.LoginStatus = new global::System.Windows.Forms.Label();
			this.panelHeader.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox2).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox3).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.btnDiscord).BeginInit();
			base.SuspendLayout();
			this.panelHeader.BackColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.panelHeader.Controls.Add(this.minimizeBTN);
			this.panelHeader.Controls.Add(this.closeBTN);
			this.panelHeader.Controls.Add(this.label2);
			this.panelHeader.Controls.Add(this.label1);
			this.panelHeader.Controls.Add(this.btnMinimize);
			this.panelHeader.Controls.Add(this.btnClose);
			this.panelHeader.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.panelHeader.Location = new global::System.Drawing.Point(0, 0);
			this.panelHeader.Name = "panelHeader";
			this.panelHeader.Size = new global::System.Drawing.Size(489, 40);
			this.panelHeader.TabIndex = 2;
			this.panelHeader.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseDown);
			this.panelHeader.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseMove);
			this.minimizeBTN.BackColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.minimizeBTN.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Zoom;
			this.minimizeBTN.FlatAppearance.BorderSize = 0;
			this.minimizeBTN.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.minimizeBTN.Font = new global::System.Drawing.Font("Arial", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.minimizeBTN.ForeColor = global::System.Drawing.SystemColors.ControlLightLight;
			this.minimizeBTN.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.minimizeBTN.Location = new global::System.Drawing.Point(409, 0);
			this.minimizeBTN.Name = "minimizeBTN";
			this.minimizeBTN.Size = new global::System.Drawing.Size(40, 40);
			this.minimizeBTN.TabIndex = 9;
			this.minimizeBTN.Text = "_";
			this.minimizeBTN.UseVisualStyleBackColor = false;
			this.minimizeBTN.Click += new global::System.EventHandler(this.minimizeBTN_Click);
			this.closeBTN.BackColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.closeBTN.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Zoom;
			this.closeBTN.FlatAppearance.BorderSize = 0;
			this.closeBTN.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.closeBTN.Font = new global::System.Drawing.Font("Arial", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.closeBTN.ForeColor = global::System.Drawing.SystemColors.ControlLightLight;
			this.closeBTN.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.closeBTN.Location = new global::System.Drawing.Point(449, 0);
			this.closeBTN.Name = "closeBTN";
			this.closeBTN.Size = new global::System.Drawing.Size(40, 40);
			this.closeBTN.TabIndex = 8;
			this.closeBTN.Text = "x";
			this.closeBTN.UseVisualStyleBackColor = false;
			this.closeBTN.Click += new global::System.EventHandler(this.closeBTN_Click);
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
			this.pictureBox2.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBox2.Image");
			this.pictureBox2.Location = new global::System.Drawing.Point(96, 279);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new global::System.Drawing.Size(48, 48);
			this.pictureBox2.TabIndex = 6;
			this.pictureBox2.TabStop = false;
			this.Password.BackColor = global::System.Drawing.Color.FromArgb(25, 25, 25);
			this.Password.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.Password.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.Password.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Password.ForeColor = global::System.Drawing.SystemColors.ControlLightLight;
			this.Password.Location = new global::System.Drawing.Point(150, 291);
			this.Password.Name = "Password";
			this.Password.PasswordChar = '•';
			this.Password.Size = new global::System.Drawing.Size(243, 19);
			this.Password.TabIndex = 5;
			this.panel1.BackColor = global::System.Drawing.SystemColors.ControlLightLight;
			this.panel1.Location = new global::System.Drawing.Point(150, 313);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(243, 3);
			this.panel1.TabIndex = 7;
			this.panel2.BackColor = global::System.Drawing.SystemColors.ControlLightLight;
			this.panel2.Location = new global::System.Drawing.Point(150, 259);
			this.panel2.Name = "panel2";
			this.panel2.Size = new global::System.Drawing.Size(243, 3);
			this.panel2.TabIndex = 10;
			this.pictureBox1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBox1.Image");
			this.pictureBox1.Location = new global::System.Drawing.Point(96, 225);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(48, 48);
			this.pictureBox1.TabIndex = 9;
			this.pictureBox1.TabStop = false;
			this.Username.BackColor = global::System.Drawing.Color.FromArgb(25, 25, 25);
			this.Username.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.Username.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.Username.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Username.ForeColor = global::System.Drawing.SystemColors.ControlLightLight;
			this.Username.Location = new global::System.Drawing.Point(150, 237);
			this.Username.MaxLength = 32;
			this.Username.Name = "Username";
			this.Username.Size = new global::System.Drawing.Size(243, 19);
			this.Username.TabIndex = 8;
			this.pictureBox3.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBox3.Image");
			this.pictureBox3.Location = new global::System.Drawing.Point(203, 111);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new global::System.Drawing.Size(83, 79);
			this.pictureBox3.TabIndex = 11;
			this.pictureBox3.TabStop = false;
			this.LoginBTN.BackColor = global::System.Drawing.Color.FromArgb(25, 25, 25);
			this.LoginBTN.FlatAppearance.BorderColor = global::System.Drawing.Color.FromArgb(0, 192, 0);
			this.LoginBTN.FlatAppearance.BorderSize = 2;
			this.LoginBTN.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.FromArgb(25, 25, 25);
			this.LoginBTN.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.FromArgb(0, 192, 0);
			this.LoginBTN.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.LoginBTN.ForeColor = global::System.Drawing.Color.White;
			this.LoginBTN.Location = new global::System.Drawing.Point(96, 356);
			this.LoginBTN.Name = "LoginBTN";
			this.LoginBTN.Size = new global::System.Drawing.Size(297, 48);
			this.LoginBTN.TabIndex = 12;
			this.LoginBTN.Text = "Login";
			this.LoginBTN.UseVisualStyleBackColor = false;
			this.LoginBTN.Click += new global::System.EventHandler(this.LoginBTN_Click);
			this.LoginBTN.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.LoginBTN_MouseDown);
			this.LoginBTN.MouseEnter += new global::System.EventHandler(this.LoginBTN_MouseEnter);
			this.LoginBTN.MouseLeave += new global::System.EventHandler(this.LoginBTN_MouseLeave);
			this.LoginBTN.MouseUp += new global::System.Windows.Forms.MouseEventHandler(this.LoginBTN_MouseUp);
			this.btnDiscord.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("btnDiscord.Image");
			this.btnDiscord.Location = new global::System.Drawing.Point(429, 454);
			this.btnDiscord.Name = "btnDiscord";
			this.btnDiscord.Size = new global::System.Drawing.Size(48, 48);
			this.btnDiscord.TabIndex = 13;
			this.btnDiscord.TabStop = false;
			this.btnDiscord.Click += new global::System.EventHandler(this.btnDiscord_Click);
			this.btnDiscord.MouseEnter += new global::System.EventHandler(this.btnDiscord_MouseEnter);
			this.btnDiscord.MouseLeave += new global::System.EventHandler(this.btnDiscord_MouseLeave);
			this.label3.AutoSize = true;
			this.label3.ForeColor = global::System.Drawing.SystemColors.ControlLightLight;
			this.label3.Location = new global::System.Drawing.Point(147, 221);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(55, 13);
			this.label3.TabIndex = 14;
			this.label3.Text = "Username";
			this.label4.AutoSize = true;
			this.label4.ForeColor = global::System.Drawing.SystemColors.ControlLightLight;
			this.label4.Location = new global::System.Drawing.Point(147, 275);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(53, 13);
			this.label4.TabIndex = 15;
			this.label4.Text = "Password";
			this.LoginStatus.ForeColor = global::System.Drawing.SystemColors.ControlLightLight;
			this.LoginStatus.Location = new global::System.Drawing.Point(96, 407);
			this.LoginStatus.Name = "LoginStatus";
			this.LoginStatus.Size = new global::System.Drawing.Size(297, 23);
			this.LoginStatus.TabIndex = 16;
			this.LoginStatus.TextAlign = global::System.Drawing.ContentAlignment.TopCenter;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(25, 25, 25);
			base.ClientSize = new global::System.Drawing.Size(489, 514);
			base.Controls.Add(this.LoginStatus);
			base.Controls.Add(this.label4);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.btnDiscord);
			base.Controls.Add(this.LoginBTN);
			base.Controls.Add(this.pictureBox3);
			base.Controls.Add(this.panel2);
			base.Controls.Add(this.pictureBox1);
			base.Controls.Add(this.panel1);
			base.Controls.Add(this.pictureBox2);
			base.Controls.Add(this.Password);
			base.Controls.Add(this.panelHeader);
			base.Controls.Add(this.Username);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = "LoginForm";
			this.Text = "LoginForm";
			this.panelHeader.ResumeLayout(false);
			this.panelHeader.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox2).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox3).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.btnDiscord).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000044 RID: 68
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000045 RID: 69
		private global::System.Windows.Forms.Panel panelHeader;

		// Token: 0x04000046 RID: 70
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000047 RID: 71
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000048 RID: 72
		private global::System.Windows.Forms.Button btnMinimize;

		// Token: 0x04000049 RID: 73
		private global::System.Windows.Forms.Button btnClose;

		// Token: 0x0400004A RID: 74
		private global::System.Windows.Forms.Button minimizeBTN;

		// Token: 0x0400004B RID: 75
		private global::System.Windows.Forms.Button closeBTN;

		// Token: 0x0400004C RID: 76
		private global::System.Windows.Forms.PictureBox pictureBox2;

		// Token: 0x0400004D RID: 77
		private global::System.Windows.Forms.TextBox Password;

		// Token: 0x0400004E RID: 78
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x0400004F RID: 79
		private global::System.Windows.Forms.Panel panel2;

		// Token: 0x04000050 RID: 80
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000051 RID: 81
		private global::System.Windows.Forms.TextBox Username;

		// Token: 0x04000052 RID: 82
		private global::System.Windows.Forms.PictureBox pictureBox3;

		// Token: 0x04000053 RID: 83
		private global::System.Windows.Forms.Button LoginBTN;

		// Token: 0x04000054 RID: 84
		private global::System.Windows.Forms.PictureBox btnDiscord;

		// Token: 0x04000055 RID: 85
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000056 RID: 86
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04000057 RID: 87
		private global::System.Windows.Forms.Label LoginStatus;
	}
}
