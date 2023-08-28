namespace Krokmou_Clicker_v2
{
	// Token: 0x02000007 RID: 7
	public partial class ConfigsForm : global::System.Windows.Forms.Form
	{
		// Token: 0x06000052 RID: 82 RVA: 0x000065DC File Offset: 0x000047DC
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00006614 File Offset: 0x00004814
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Krokmou_Clicker_v2.ConfigsForm));
			this.Decoration_Configs = new global::System.Windows.Forms.Panel();
			this.label1 = new global::System.Windows.Forms.Label();
			this.guna2Panel1 = new global::Guna.UI2.WinForms.Guna2Panel();
			this.Status1 = new global::System.Windows.Forms.Label();
			this.MMCConfigDate = new global::System.Windows.Forms.Label();
			this.ApplyMMC_Btn = new global::Guna.UI2.WinForms.Guna2Button();
			this.label2 = new global::System.Windows.Forms.Label();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.guna2Panel2 = new global::Guna.UI2.WinForms.Guna2Panel();
			this.Status2 = new global::System.Windows.Forms.Label();
			this.ColdConfigDate = new global::System.Windows.Forms.Label();
			this.ApplyCold_Btn = new global::Guna.UI2.WinForms.Guna2Button();
			this.pictureBox2 = new global::System.Windows.Forms.PictureBox();
			this.label3 = new global::System.Windows.Forms.Label();
			this.guna2Panel3 = new global::Guna.UI2.WinForms.Guna2Panel();
			this.Status4 = new global::System.Windows.Forms.Label();
			this.PvPGymConfigDate = new global::System.Windows.Forms.Label();
			this.ApplyPvPGym_Btn = new global::Guna.UI2.WinForms.Guna2Button();
			this.pictureBox4 = new global::System.Windows.Forms.PictureBox();
			this.label5 = new global::System.Windows.Forms.Label();
			this.guna2Panel4 = new global::Guna.UI2.WinForms.Guna2Panel();
			this.Status3 = new global::System.Windows.Forms.Label();
			this.PvPLandConfigDate = new global::System.Windows.Forms.Label();
			this.ApplyPvPLand_Btn = new global::Guna.UI2.WinForms.Guna2Button();
			this.pictureBox3 = new global::System.Windows.Forms.PictureBox();
			this.label4 = new global::System.Windows.Forms.Label();
			this.ConfigsApply_Label = new global::System.Windows.Forms.Label();
			this.ApplyProgress = new global::Guna.UI2.WinForms.Guna2ProgressBar();
			this.ConfigsToolTip_Box = new global::Guna.UI2.WinForms.Guna2PictureBox();
			this.ConfigsToolTip = new global::Guna.UI2.WinForms.Guna2HtmlToolTip();
			this.guna2Panel1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			this.guna2Panel2.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox2).BeginInit();
			this.guna2Panel3.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox4).BeginInit();
			this.guna2Panel4.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox3).BeginInit();
			this.ConfigsToolTip_Box.BeginInit();
			base.SuspendLayout();
			this.Decoration_Configs.BackColor = global::System.Drawing.Color.FromArgb(0, 192, 0);
			this.Decoration_Configs.Location = new global::System.Drawing.Point(12, 13);
			this.Decoration_Configs.Name = "Decoration_Configs";
			this.Decoration_Configs.Size = new global::System.Drawing.Size(2, 17);
			this.Decoration_Configs.TabIndex = 9;
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 15.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.ForeColor = global::System.Drawing.SystemColors.ControlLightLight;
			this.label1.Location = new global::System.Drawing.Point(17, 9);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(85, 25);
			this.label1.TabIndex = 8;
			this.label1.Text = "Configs";
			this.guna2Panel1.BackColor = global::System.Drawing.Color.FromArgb(30, 30, 30);
			this.guna2Panel1.BorderStyle = global::System.Drawing.Drawing2D.DashStyle.Custom;
			this.guna2Panel1.BorderThickness = 1;
			this.guna2Panel1.Controls.Add(this.Status1);
			this.guna2Panel1.Controls.Add(this.MMCConfigDate);
			this.guna2Panel1.Controls.Add(this.ApplyMMC_Btn);
			this.guna2Panel1.Controls.Add(this.label2);
			this.guna2Panel1.Controls.Add(this.pictureBox1);
			this.guna2Panel1.CustomBorderColor = global::System.Drawing.SystemColors.ControlLightLight;
			this.guna2Panel1.CustomBorderThickness = new global::System.Windows.Forms.Padding(1);
			this.guna2Panel1.Location = new global::System.Drawing.Point(22, 59);
			this.guna2Panel1.Name = "guna2Panel1";
			this.guna2Panel1.Size = new global::System.Drawing.Size(223, 100);
			this.guna2Panel1.TabIndex = 10;
			this.Status1.AutoSize = true;
			this.Status1.ForeColor = global::System.Drawing.SystemColors.ControlLightLight;
			this.Status1.Location = new global::System.Drawing.Point(84, 28);
			this.Status1.Name = "Status1";
			this.Status1.Size = new global::System.Drawing.Size(40, 13);
			this.Status1.TabIndex = 4;
			this.Status1.Text = "Status:";
			this.MMCConfigDate.AutoSize = true;
			this.MMCConfigDate.ForeColor = global::System.Drawing.Color.DimGray;
			this.MMCConfigDate.Location = new global::System.Drawing.Point(5, 82);
			this.MMCConfigDate.Name = "MMCConfigDate";
			this.MMCConfigDate.Size = new global::System.Drawing.Size(65, 13);
			this.MMCConfigDate.TabIndex = 3;
			this.MMCConfigDate.Text = "05/03/2023";
			this.ApplyMMC_Btn.BackColor = global::System.Drawing.Color.Transparent;
			this.ApplyMMC_Btn.BorderColor = global::System.Drawing.Color.FromArgb(0, 192, 0);
			this.ApplyMMC_Btn.BorderRadius = 4;
			this.ApplyMMC_Btn.BorderThickness = 2;
			this.ApplyMMC_Btn.CustomBorderThickness = new global::System.Windows.Forms.Padding(2);
			this.ApplyMMC_Btn.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.ApplyMMC_Btn.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.ApplyMMC_Btn.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.ApplyMMC_Btn.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.ApplyMMC_Btn.FillColor = global::System.Drawing.Color.FromArgb(30, 30, 30);
			this.ApplyMMC_Btn.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.ApplyMMC_Btn.ForeColor = global::System.Drawing.Color.White;
			this.ApplyMMC_Btn.Location = new global::System.Drawing.Point(136, 73);
			this.ApplyMMC_Btn.Name = "ApplyMMC_Btn";
			this.ApplyMMC_Btn.Size = new global::System.Drawing.Size(82, 22);
			this.ApplyMMC_Btn.TabIndex = 2;
			this.ApplyMMC_Btn.Text = "Apply";
			this.ApplyMMC_Btn.Click += new global::System.EventHandler(this.ApplyMMC_Btn_Click);
			this.label2.AutoSize = true;
			this.label2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 15.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label2.ForeColor = global::System.Drawing.SystemColors.ControlLightLight;
			this.label2.Location = new global::System.Drawing.Point(80, 3);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(100, 25);
			this.label2.TabIndex = 1;
			this.label2.Text = "Minemen";
			this.pictureBox1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBox1.Image");
			this.pictureBox1.Location = new global::System.Drawing.Point(3, 3);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(75, 75);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			this.guna2Panel2.BackColor = global::System.Drawing.Color.FromArgb(30, 30, 30);
			this.guna2Panel2.BorderStyle = global::System.Drawing.Drawing2D.DashStyle.Custom;
			this.guna2Panel2.BorderThickness = 1;
			this.guna2Panel2.Controls.Add(this.Status2);
			this.guna2Panel2.Controls.Add(this.ColdConfigDate);
			this.guna2Panel2.Controls.Add(this.ApplyCold_Btn);
			this.guna2Panel2.Controls.Add(this.pictureBox2);
			this.guna2Panel2.Controls.Add(this.label3);
			this.guna2Panel2.CustomBorderColor = global::System.Drawing.SystemColors.ControlLightLight;
			this.guna2Panel2.CustomBorderThickness = new global::System.Windows.Forms.Padding(1);
			this.guna2Panel2.Location = new global::System.Drawing.Point(251, 59);
			this.guna2Panel2.Name = "guna2Panel2";
			this.guna2Panel2.Size = new global::System.Drawing.Size(223, 100);
			this.guna2Panel2.TabIndex = 11;
			this.Status2.AutoSize = true;
			this.Status2.ForeColor = global::System.Drawing.SystemColors.ControlLightLight;
			this.Status2.Location = new global::System.Drawing.Point(84, 28);
			this.Status2.Name = "Status2";
			this.Status2.Size = new global::System.Drawing.Size(40, 13);
			this.Status2.TabIndex = 5;
			this.Status2.Text = "Status:";
			this.ColdConfigDate.AutoSize = true;
			this.ColdConfigDate.ForeColor = global::System.Drawing.Color.DimGray;
			this.ColdConfigDate.Location = new global::System.Drawing.Point(5, 82);
			this.ColdConfigDate.Name = "ColdConfigDate";
			this.ColdConfigDate.Size = new global::System.Drawing.Size(79, 13);
			this.ColdConfigDate.TabIndex = 4;
			this.ColdConfigDate.Text = "DD/MM/YYYY";
			this.ApplyCold_Btn.BackColor = global::System.Drawing.Color.Transparent;
			this.ApplyCold_Btn.BorderColor = global::System.Drawing.Color.FromArgb(0, 192, 0);
			this.ApplyCold_Btn.BorderRadius = 4;
			this.ApplyCold_Btn.BorderThickness = 2;
			this.ApplyCold_Btn.CustomBorderThickness = new global::System.Windows.Forms.Padding(2);
			this.ApplyCold_Btn.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.ApplyCold_Btn.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.ApplyCold_Btn.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.ApplyCold_Btn.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.ApplyCold_Btn.FillColor = global::System.Drawing.Color.FromArgb(30, 30, 30);
			this.ApplyCold_Btn.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.ApplyCold_Btn.ForeColor = global::System.Drawing.Color.White;
			this.ApplyCold_Btn.Location = new global::System.Drawing.Point(136, 73);
			this.ApplyCold_Btn.Name = "ApplyCold_Btn";
			this.ApplyCold_Btn.Size = new global::System.Drawing.Size(82, 22);
			this.ApplyCold_Btn.TabIndex = 5;
			this.ApplyCold_Btn.Text = "Apply";
			this.pictureBox2.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBox2.Image");
			this.pictureBox2.Location = new global::System.Drawing.Point(3, 3);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new global::System.Drawing.Size(75, 75);
			this.pictureBox2.TabIndex = 3;
			this.pictureBox2.TabStop = false;
			this.label3.AutoSize = true;
			this.label3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 15.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label3.ForeColor = global::System.Drawing.SystemColors.ControlLightLight;
			this.label3.Location = new global::System.Drawing.Point(80, 3);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(140, 25);
			this.label3.TabIndex = 4;
			this.label3.Text = "Cold Network";
			this.guna2Panel3.BackColor = global::System.Drawing.Color.FromArgb(30, 30, 30);
			this.guna2Panel3.BorderStyle = global::System.Drawing.Drawing2D.DashStyle.Custom;
			this.guna2Panel3.BorderThickness = 1;
			this.guna2Panel3.Controls.Add(this.Status4);
			this.guna2Panel3.Controls.Add(this.PvPGymConfigDate);
			this.guna2Panel3.Controls.Add(this.ApplyPvPGym_Btn);
			this.guna2Panel3.Controls.Add(this.pictureBox4);
			this.guna2Panel3.Controls.Add(this.label5);
			this.guna2Panel3.CustomBorderColor = global::System.Drawing.SystemColors.ControlLightLight;
			this.guna2Panel3.CustomBorderThickness = new global::System.Windows.Forms.Padding(1);
			this.guna2Panel3.Location = new global::System.Drawing.Point(251, 165);
			this.guna2Panel3.Name = "guna2Panel3";
			this.guna2Panel3.Size = new global::System.Drawing.Size(223, 100);
			this.guna2Panel3.TabIndex = 13;
			this.Status4.AutoSize = true;
			this.Status4.ForeColor = global::System.Drawing.SystemColors.ControlLightLight;
			this.Status4.Location = new global::System.Drawing.Point(84, 28);
			this.Status4.Name = "Status4";
			this.Status4.Size = new global::System.Drawing.Size(40, 13);
			this.Status4.TabIndex = 7;
			this.Status4.Text = "Status:";
			this.PvPGymConfigDate.AutoSize = true;
			this.PvPGymConfigDate.ForeColor = global::System.Drawing.Color.DimGray;
			this.PvPGymConfigDate.Location = new global::System.Drawing.Point(5, 82);
			this.PvPGymConfigDate.Name = "PvPGymConfigDate";
			this.PvPGymConfigDate.Size = new global::System.Drawing.Size(79, 13);
			this.PvPGymConfigDate.TabIndex = 7;
			this.PvPGymConfigDate.Text = "DD/MM/YYYY";
			this.ApplyPvPGym_Btn.BackColor = global::System.Drawing.Color.Transparent;
			this.ApplyPvPGym_Btn.BorderColor = global::System.Drawing.Color.FromArgb(0, 192, 0);
			this.ApplyPvPGym_Btn.BorderRadius = 4;
			this.ApplyPvPGym_Btn.BorderThickness = 2;
			this.ApplyPvPGym_Btn.CustomBorderThickness = new global::System.Windows.Forms.Padding(2);
			this.ApplyPvPGym_Btn.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.ApplyPvPGym_Btn.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.ApplyPvPGym_Btn.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.ApplyPvPGym_Btn.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.ApplyPvPGym_Btn.FillColor = global::System.Drawing.Color.FromArgb(30, 30, 30);
			this.ApplyPvPGym_Btn.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.ApplyPvPGym_Btn.ForeColor = global::System.Drawing.Color.White;
			this.ApplyPvPGym_Btn.Location = new global::System.Drawing.Point(136, 73);
			this.ApplyPvPGym_Btn.Name = "ApplyPvPGym_Btn";
			this.ApplyPvPGym_Btn.Size = new global::System.Drawing.Size(82, 22);
			this.ApplyPvPGym_Btn.TabIndex = 8;
			this.ApplyPvPGym_Btn.Text = "Apply";
			this.pictureBox4.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBox4.Image");
			this.pictureBox4.Location = new global::System.Drawing.Point(3, 3);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new global::System.Drawing.Size(75, 75);
			this.pictureBox4.TabIndex = 6;
			this.pictureBox4.TabStop = false;
			this.label5.AutoSize = true;
			this.label5.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 15.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label5.ForeColor = global::System.Drawing.SystemColors.ControlLightLight;
			this.label5.Location = new global::System.Drawing.Point(80, 3);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(101, 25);
			this.label5.TabIndex = 7;
			this.label5.Text = "PvP Gym";
			this.guna2Panel4.BackColor = global::System.Drawing.Color.FromArgb(30, 30, 30);
			this.guna2Panel4.BorderStyle = global::System.Drawing.Drawing2D.DashStyle.Custom;
			this.guna2Panel4.BorderThickness = 1;
			this.guna2Panel4.Controls.Add(this.Status3);
			this.guna2Panel4.Controls.Add(this.PvPLandConfigDate);
			this.guna2Panel4.Controls.Add(this.ApplyPvPLand_Btn);
			this.guna2Panel4.Controls.Add(this.pictureBox3);
			this.guna2Panel4.Controls.Add(this.label4);
			this.guna2Panel4.CustomBorderColor = global::System.Drawing.SystemColors.ControlLightLight;
			this.guna2Panel4.CustomBorderThickness = new global::System.Windows.Forms.Padding(1);
			this.guna2Panel4.Location = new global::System.Drawing.Point(22, 165);
			this.guna2Panel4.Name = "guna2Panel4";
			this.guna2Panel4.Size = new global::System.Drawing.Size(223, 100);
			this.guna2Panel4.TabIndex = 12;
			this.Status3.AutoSize = true;
			this.Status3.ForeColor = global::System.Drawing.SystemColors.ControlLightLight;
			this.Status3.Location = new global::System.Drawing.Point(84, 28);
			this.Status3.Name = "Status3";
			this.Status3.Size = new global::System.Drawing.Size(40, 13);
			this.Status3.TabIndex = 6;
			this.Status3.Text = "Status:";
			this.PvPLandConfigDate.AutoSize = true;
			this.PvPLandConfigDate.ForeColor = global::System.Drawing.Color.DimGray;
			this.PvPLandConfigDate.Location = new global::System.Drawing.Point(5, 82);
			this.PvPLandConfigDate.Name = "PvPLandConfigDate";
			this.PvPLandConfigDate.Size = new global::System.Drawing.Size(79, 13);
			this.PvPLandConfigDate.TabIndex = 6;
			this.PvPLandConfigDate.Text = "DD/MM/YYYY";
			this.ApplyPvPLand_Btn.BackColor = global::System.Drawing.Color.Transparent;
			this.ApplyPvPLand_Btn.BorderColor = global::System.Drawing.Color.FromArgb(0, 192, 0);
			this.ApplyPvPLand_Btn.BorderRadius = 4;
			this.ApplyPvPLand_Btn.BorderThickness = 2;
			this.ApplyPvPLand_Btn.CustomBorderThickness = new global::System.Windows.Forms.Padding(2);
			this.ApplyPvPLand_Btn.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.ApplyPvPLand_Btn.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.ApplyPvPLand_Btn.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.ApplyPvPLand_Btn.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.ApplyPvPLand_Btn.FillColor = global::System.Drawing.Color.FromArgb(30, 30, 30);
			this.ApplyPvPLand_Btn.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.ApplyPvPLand_Btn.ForeColor = global::System.Drawing.Color.White;
			this.ApplyPvPLand_Btn.Location = new global::System.Drawing.Point(136, 73);
			this.ApplyPvPLand_Btn.Name = "ApplyPvPLand_Btn";
			this.ApplyPvPLand_Btn.Size = new global::System.Drawing.Size(82, 22);
			this.ApplyPvPLand_Btn.TabIndex = 5;
			this.ApplyPvPLand_Btn.Text = "Apply";
			this.pictureBox3.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBox3.Image");
			this.pictureBox3.Location = new global::System.Drawing.Point(3, 3);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new global::System.Drawing.Size(75, 75);
			this.pictureBox3.TabIndex = 3;
			this.pictureBox3.TabStop = false;
			this.label4.AutoSize = true;
			this.label4.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 15.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label4.ForeColor = global::System.Drawing.SystemColors.ControlLightLight;
			this.label4.Location = new global::System.Drawing.Point(80, 3);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(105, 25);
			this.label4.TabIndex = 4;
			this.label4.Text = "PvP Land";
			this.ConfigsApply_Label.ForeColor = global::System.Drawing.SystemColors.ControlLightLight;
			this.ConfigsApply_Label.Location = new global::System.Drawing.Point(25, 281);
			this.ConfigsApply_Label.Name = "ConfigsApply_Label";
			this.ConfigsApply_Label.Size = new global::System.Drawing.Size(449, 16);
			this.ConfigsApply_Label.TabIndex = 14;
			this.ConfigsApply_Label.Text = "...";
			this.ConfigsApply_Label.TextAlign = global::System.Drawing.ContentAlignment.TopCenter;
			this.ApplyProgress.AutoRoundedCorners = true;
			this.ApplyProgress.BorderRadius = 4;
			this.ApplyProgress.Location = new global::System.Drawing.Point(12, 303);
			this.ApplyProgress.Name = "ApplyProgress";
			this.ApplyProgress.ProgressColor = global::System.Drawing.Color.FromArgb(0, 192, 0);
			this.ApplyProgress.ProgressColor2 = global::System.Drawing.Color.FromArgb(0, 192, 0);
			this.ApplyProgress.Size = new global::System.Drawing.Size(472, 10);
			this.ApplyProgress.TabIndex = 15;
			this.ApplyProgress.Text = "guna2ProgressBar1";
			this.ApplyProgress.TextRenderingHint = global::System.Drawing.Text.TextRenderingHint.SystemDefault;
			this.ConfigsToolTip_Box.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("ConfigsToolTip_Box.Image");
			this.ConfigsToolTip_Box.ImageRotate = 0f;
			this.ConfigsToolTip_Box.Location = new global::System.Drawing.Point(100, 14);
			this.ConfigsToolTip_Box.Name = "ConfigsToolTip_Box";
			this.ConfigsToolTip_Box.Size = new global::System.Drawing.Size(16, 16);
			this.ConfigsToolTip_Box.TabIndex = 38;
			this.ConfigsToolTip_Box.TabStop = false;
			this.ConfigsToolTip.SetToolTip(this.ConfigsToolTip_Box, "Here, you can find and apply official configs of KrokmouClicker.");
			this.ConfigsToolTip.AllowLinksHandling = true;
			this.ConfigsToolTip.BackColor = global::System.Drawing.Color.FromArgb(15, 15, 15);
			this.ConfigsToolTip.BorderColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.ConfigsToolTip.ForeColor = global::System.Drawing.SystemColors.ControlLightLight;
			this.ConfigsToolTip.MaximumSize = new global::System.Drawing.Size(0, 0);
			this.ConfigsToolTip.TitleForeColor = global::System.Drawing.Color.FromArgb(0, 192, 0);
			this.ConfigsToolTip.ToolTipTitle = "Configs";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(25, 25, 25);
			base.ClientSize = new global::System.Drawing.Size(496, 325);
			base.Controls.Add(this.ConfigsToolTip_Box);
			base.Controls.Add(this.ApplyProgress);
			base.Controls.Add(this.ConfigsApply_Label);
			base.Controls.Add(this.guna2Panel3);
			base.Controls.Add(this.guna2Panel4);
			base.Controls.Add(this.guna2Panel2);
			base.Controls.Add(this.guna2Panel1);
			base.Controls.Add(this.Decoration_Configs);
			base.Controls.Add(this.label1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = "ConfigsForm";
			this.Text = "PresetsForm";
			this.guna2Panel1.ResumeLayout(false);
			this.guna2Panel1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			this.guna2Panel2.ResumeLayout(false);
			this.guna2Panel2.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox2).EndInit();
			this.guna2Panel3.ResumeLayout(false);
			this.guna2Panel3.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox4).EndInit();
			this.guna2Panel4.ResumeLayout(false);
			this.guna2Panel4.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox3).EndInit();
			this.ConfigsToolTip_Box.EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400005B RID: 91
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400005C RID: 92
		private global::System.Windows.Forms.Panel Decoration_Configs;

		// Token: 0x0400005D RID: 93
		private global::System.Windows.Forms.Label label1;

		// Token: 0x0400005E RID: 94
		private global::Guna.UI2.WinForms.Guna2Panel guna2Panel1;

		// Token: 0x0400005F RID: 95
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000060 RID: 96
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000061 RID: 97
		private global::Guna.UI2.WinForms.Guna2Panel guna2Panel2;

		// Token: 0x04000062 RID: 98
		private global::Guna.UI2.WinForms.Guna2Panel guna2Panel3;

		// Token: 0x04000063 RID: 99
		private global::Guna.UI2.WinForms.Guna2Panel guna2Panel4;

		// Token: 0x04000064 RID: 100
		private global::Guna.UI2.WinForms.Guna2Button ApplyMMC_Btn;

		// Token: 0x04000065 RID: 101
		private global::Guna.UI2.WinForms.Guna2Button ApplyCold_Btn;

		// Token: 0x04000066 RID: 102
		private global::System.Windows.Forms.PictureBox pictureBox2;

		// Token: 0x04000067 RID: 103
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000068 RID: 104
		private global::Guna.UI2.WinForms.Guna2Button ApplyPvPGym_Btn;

		// Token: 0x04000069 RID: 105
		private global::System.Windows.Forms.PictureBox pictureBox4;

		// Token: 0x0400006A RID: 106
		private global::System.Windows.Forms.Label label5;

		// Token: 0x0400006B RID: 107
		private global::Guna.UI2.WinForms.Guna2Button ApplyPvPLand_Btn;

		// Token: 0x0400006C RID: 108
		private global::System.Windows.Forms.PictureBox pictureBox3;

		// Token: 0x0400006D RID: 109
		private global::System.Windows.Forms.Label label4;

		// Token: 0x0400006E RID: 110
		private global::System.Windows.Forms.Label ConfigsApply_Label;

		// Token: 0x0400006F RID: 111
		private global::Guna.UI2.WinForms.Guna2ProgressBar ApplyProgress;

		// Token: 0x04000070 RID: 112
		private global::System.Windows.Forms.Label MMCConfigDate;

		// Token: 0x04000071 RID: 113
		private global::System.Windows.Forms.Label ColdConfigDate;

		// Token: 0x04000072 RID: 114
		private global::System.Windows.Forms.Label PvPGymConfigDate;

		// Token: 0x04000073 RID: 115
		private global::System.Windows.Forms.Label PvPLandConfigDate;

		// Token: 0x04000074 RID: 116
		private global::System.Windows.Forms.Label Status1;

		// Token: 0x04000075 RID: 117
		private global::System.Windows.Forms.Label Status2;

		// Token: 0x04000076 RID: 118
		private global::System.Windows.Forms.Label Status4;

		// Token: 0x04000077 RID: 119
		private global::System.Windows.Forms.Label Status3;

		// Token: 0x04000078 RID: 120
		private global::Guna.UI2.WinForms.Guna2PictureBox ConfigsToolTip_Box;

		// Token: 0x04000079 RID: 121
		private global::Guna.UI2.WinForms.Guna2HtmlToolTip ConfigsToolTip;
	}
}
