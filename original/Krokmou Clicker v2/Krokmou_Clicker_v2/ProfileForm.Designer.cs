namespace Krokmou_Clicker_v2
{
	// Token: 0x02000008 RID: 8
	public partial class ProfileForm : global::System.Windows.Forms.Form
	{
		// Token: 0x06000058 RID: 88 RVA: 0x0000805C File Offset: 0x0000625C
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00008094 File Offset: 0x00006294
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Krokmou_Clicker_v2.ProfileForm));
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.ProfileUsername = new global::System.Windows.Forms.Label();
			this.DecorationUsername = new global::System.Windows.Forms.Panel();
			this.RankLabel = new global::System.Windows.Forms.Label();
			this.IDLabel = new global::System.Windows.Forms.Label();
			this.ProfileRank = new global::System.Windows.Forms.Label();
			this.ProfileID = new global::System.Windows.Forms.Label();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			base.SuspendLayout();
			this.pictureBox1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBox1.Image");
			this.pictureBox1.Location = new global::System.Drawing.Point(223, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(50, 50);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			this.ProfileUsername.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 15.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.ProfileUsername.ForeColor = global::System.Drawing.SystemColors.ControlLightLight;
			this.ProfileUsername.Location = new global::System.Drawing.Point(12, 65);
			this.ProfileUsername.Name = "ProfileUsername";
			this.ProfileUsername.Size = new global::System.Drawing.Size(472, 23);
			this.ProfileUsername.TabIndex = 1;
			this.ProfileUsername.Text = "Username";
			this.ProfileUsername.TextAlign = global::System.Drawing.ContentAlignment.TopCenter;
			this.DecorationUsername.BackColor = global::System.Drawing.Color.FromArgb(0, 192, 0);
			this.DecorationUsername.Location = new global::System.Drawing.Point(198, 93);
			this.DecorationUsername.Name = "DecorationUsername";
			this.DecorationUsername.Size = new global::System.Drawing.Size(100, 2);
			this.DecorationUsername.TabIndex = 2;
			this.RankLabel.AutoSize = true;
			this.RankLabel.ForeColor = global::System.Drawing.SystemColors.ControlLightLight;
			this.RankLabel.Location = new global::System.Drawing.Point(197, 98);
			this.RankLabel.Name = "RankLabel";
			this.RankLabel.Size = new global::System.Drawing.Size(36, 13);
			this.RankLabel.TabIndex = 3;
			this.RankLabel.Text = "Rank:";
			this.IDLabel.AutoSize = true;
			this.IDLabel.ForeColor = global::System.Drawing.SystemColors.ControlLightLight;
			this.IDLabel.Location = new global::System.Drawing.Point(197, 115);
			this.IDLabel.Name = "IDLabel";
			this.IDLabel.Size = new global::System.Drawing.Size(21, 13);
			this.IDLabel.TabIndex = 4;
			this.IDLabel.Text = "ID:";
			this.ProfileRank.ForeColor = global::System.Drawing.SystemColors.ControlLightLight;
			this.ProfileRank.Location = new global::System.Drawing.Point(238, 98);
			this.ProfileRank.Name = "ProfileRank";
			this.ProfileRank.Size = new global::System.Drawing.Size(61, 13);
			this.ProfileRank.TabIndex = 5;
			this.ProfileRank.Text = "Rank";
			this.ProfileRank.TextAlign = global::System.Drawing.ContentAlignment.TopRight;
			this.ProfileID.ForeColor = global::System.Drawing.SystemColors.ControlLightLight;
			this.ProfileID.Location = new global::System.Drawing.Point(223, 115);
			this.ProfileID.Name = "ProfileID";
			this.ProfileID.Size = new global::System.Drawing.Size(76, 13);
			this.ProfileID.TabIndex = 6;
			this.ProfileID.Text = "ID";
			this.ProfileID.TextAlign = global::System.Drawing.ContentAlignment.TopRight;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(25, 25, 25);
			base.ClientSize = new global::System.Drawing.Size(496, 325);
			base.Controls.Add(this.ProfileID);
			base.Controls.Add(this.ProfileRank);
			base.Controls.Add(this.IDLabel);
			base.Controls.Add(this.RankLabel);
			base.Controls.Add(this.DecorationUsername);
			base.Controls.Add(this.ProfileUsername);
			base.Controls.Add(this.pictureBox1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = "ProfileForm";
			this.Text = "ProfileForm";
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400007D RID: 125
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400007E RID: 126
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x0400007F RID: 127
		private global::System.Windows.Forms.Label ProfileUsername;

		// Token: 0x04000080 RID: 128
		private global::System.Windows.Forms.Panel DecorationUsername;

		// Token: 0x04000081 RID: 129
		private global::System.Windows.Forms.Label RankLabel;

		// Token: 0x04000082 RID: 130
		private global::System.Windows.Forms.Label IDLabel;

		// Token: 0x04000083 RID: 131
		private global::System.Windows.Forms.Label ProfileRank;

		// Token: 0x04000084 RID: 132
		private global::System.Windows.Forms.Label ProfileID;
	}
}
