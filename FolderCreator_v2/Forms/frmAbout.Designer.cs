namespace FolderCreator_v2.Forms
{
	partial class frmAbout
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbout));
			this.panelTop = new System.Windows.Forms.Panel();
			this.btnList = new System.Windows.Forms.Button();
			this.lbAboutTitle = new System.Windows.Forms.Label();
			this.txtDesc = new System.Windows.Forms.RichTextBox();
			this.spBottom = new System.Windows.Forms.ToolStrip();
			this.tslSiteGunnar = new System.Windows.Forms.ToolStripLabel();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.tslSiteSatellaSoft = new System.Windows.Forms.ToolStripLabel();
			this.panelTop.SuspendLayout();
			this.spBottom.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelTop
			// 
			this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.panelTop.Controls.Add(this.lbAboutTitle);
			this.panelTop.Controls.Add(this.btnList);
			this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelTop.Location = new System.Drawing.Point(0, 0);
			this.panelTop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.panelTop.Name = "panelTop";
			this.panelTop.Size = new System.Drawing.Size(499, 75);
			this.panelTop.TabIndex = 1;
			// 
			// btnList
			// 
			this.btnList.BackgroundImage = global::FolderCreator_v2.Properties.Resources.iconfinder_go_bottom_118767;
			this.btnList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnList.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnList.ForeColor = System.Drawing.Color.White;
			this.btnList.Location = new System.Drawing.Point(922, 45);
			this.btnList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnList.Name = "btnList";
			this.btnList.Size = new System.Drawing.Size(56, 72);
			this.btnList.TabIndex = 2;
			this.btnList.UseVisualStyleBackColor = true;
			// 
			// lbAboutTitle
			// 
			this.lbAboutTitle.AutoSize = true;
			this.lbAboutTitle.Font = new System.Drawing.Font("Segoe UI Semilight", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbAboutTitle.ForeColor = System.Drawing.Color.White;
			this.lbAboutTitle.Location = new System.Drawing.Point(12, 9);
			this.lbAboutTitle.Name = "lbAboutTitle";
			this.lbAboutTitle.Size = new System.Drawing.Size(129, 54);
			this.lbAboutTitle.TabIndex = 3;
			this.lbAboutTitle.Text = "About";
			// 
			// txtDesc
			// 
			this.txtDesc.BackColor = System.Drawing.Color.White;
			this.txtDesc.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtDesc.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.txtDesc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtDesc.Location = new System.Drawing.Point(0, 75);
			this.txtDesc.Name = "txtDesc";
			this.txtDesc.ReadOnly = true;
			this.txtDesc.Size = new System.Drawing.Size(499, 335);
			this.txtDesc.TabIndex = 2;
			this.txtDesc.Text = resources.GetString("txtDesc.Text");
			// 
			// spBottom
			// 
			this.spBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.spBottom.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.spBottom.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.spBottom.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslSiteGunnar,
            this.toolStripSeparator1,
            this.tslSiteSatellaSoft});
			this.spBottom.Location = new System.Drawing.Point(0, 384);
			this.spBottom.Name = "spBottom";
			this.spBottom.Size = new System.Drawing.Size(499, 26);
			this.spBottom.TabIndex = 3;
			// 
			// tslSiteGunnar
			// 
			this.tslSiteGunnar.IsLink = true;
			this.tslSiteGunnar.Name = "tslSiteGunnar";
			this.tslSiteGunnar.Size = new System.Drawing.Size(190, 23);
			this.tslSiteGunnar.Text = "www.gunnarcorrea.com";
			this.tslSiteGunnar.Click += new System.EventHandler(this.tslSiteGunnar_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 26);
			// 
			// tslSiteSatellaSoft
			// 
			this.tslSiteSatellaSoft.IsLink = true;
			this.tslSiteSatellaSoft.Name = "tslSiteSatellaSoft";
			this.tslSiteSatellaSoft.Size = new System.Drawing.Size(163, 23);
			this.tslSiteSatellaSoft.Text = "www.satellasoft.com";
			this.tslSiteSatellaSoft.Click += new System.EventHandler(this.tslSiteSatellaSoft_Click);
			// 
			// frmAbout
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.ClientSize = new System.Drawing.Size(499, 410);
			this.Controls.Add(this.spBottom);
			this.Controls.Add(this.txtDesc);
			this.Controls.Add(this.panelTop);
			this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmAbout";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "About";
			this.panelTop.ResumeLayout(false);
			this.panelTop.PerformLayout();
			this.spBottom.ResumeLayout(false);
			this.spBottom.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panelTop;
		private System.Windows.Forms.Button btnList;
		private System.Windows.Forms.Label lbAboutTitle;
		private System.Windows.Forms.RichTextBox txtDesc;
		private System.Windows.Forms.ToolStrip spBottom;
		private System.Windows.Forms.ToolStripLabel tslSiteGunnar;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripLabel tslSiteSatellaSoft;
	}
}