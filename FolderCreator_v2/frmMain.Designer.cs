namespace FolderCreator_v2
{
	partial class frmMain
	{
		/// <summary>
		/// Variável de designer necessária.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpar os recursos que estão sendo usados.
		/// </summary>
		/// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código gerado pelo Windows Form Designer

		/// <summary>
		/// Método necessário para suporte ao Designer - não modifique 
		/// o conteúdo deste método com o editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
			this.panelTop = new System.Windows.Forms.Panel();
			this.topMenu = new System.Windows.Forms.MenuStrip();
			this.topMenuFile = new System.Windows.Forms.ToolStripMenuItem();
			this.topMenuExtensionFiles = new System.Windows.Forms.ToolStripMenuItem();
			this.topMenuAnotherFiles = new System.Windows.Forms.ToolStripMenuItem();
			this.topMenuAbout = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.topMenuExit = new System.Windows.Forms.ToolStripMenuItem();
			this.btnList = new System.Windows.Forms.Button();
			this.txtFolderPath = new System.Windows.Forms.TextBox();
			this.btnFindFolder = new System.Windows.Forms.Button();
			this.panelBottom = new System.Windows.Forms.Panel();
			this.pbEffect = new System.Windows.Forms.ProgressBar();
			this.btnCreateFolders = new System.Windows.Forms.Button();
			this.ckMoveFiles = new System.Windows.Forms.CheckBox();
			this.btnUncheckAll = new System.Windows.Forms.Button();
			this.btnCheckAll = new System.Windows.Forms.Button();
			this.panelCenter = new System.Windows.Forms.Panel();
			this.clbFiles = new System.Windows.Forms.CheckedListBox();
			this.panelTop.SuspendLayout();
			this.topMenu.SuspendLayout();
			this.panelBottom.SuspendLayout();
			this.panelCenter.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelTop
			// 
			this.panelTop.BackColor = System.Drawing.Color.Crimson;
			this.panelTop.Controls.Add(this.topMenu);
			this.panelTop.Controls.Add(this.btnList);
			this.panelTop.Controls.Add(this.txtFolderPath);
			this.panelTop.Controls.Add(this.btnFindFolder);
			this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelTop.Location = new System.Drawing.Point(0, 0);
			this.panelTop.Name = "panelTop";
			this.panelTop.Size = new System.Drawing.Size(882, 92);
			this.panelTop.TabIndex = 0;
			// 
			// topMenu
			// 
			this.topMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.topMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.topMenuFile});
			this.topMenu.Location = new System.Drawing.Point(0, 0);
			this.topMenu.Name = "topMenu";
			this.topMenu.Size = new System.Drawing.Size(882, 28);
			this.topMenu.TabIndex = 6;
			this.topMenu.Text = "menuStrip1";
			// 
			// topMenuFile
			// 
			this.topMenuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.topMenuExtensionFiles,
            this.topMenuAnotherFiles,
            this.topMenuAbout,
            this.toolStripSeparator1,
            this.topMenuExit});
			this.topMenuFile.Name = "topMenuFile";
			this.topMenuFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
			this.topMenuFile.Size = new System.Drawing.Size(44, 24);
			this.topMenuFile.Text = "File";
			// 
			// topMenuExtensionFiles
			// 
			this.topMenuExtensionFiles.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.topMenuExtensionFiles.ForeColor = System.Drawing.Color.DodgerBlue;
			this.topMenuExtensionFiles.Name = "topMenuExtensionFiles";
			this.topMenuExtensionFiles.Size = new System.Drawing.Size(180, 26);
			this.topMenuExtensionFiles.Text = "Extension Files";
			this.topMenuExtensionFiles.Click += new System.EventHandler(this.topMenuExtensionFiles_Click);
			// 
			// topMenuAnotherFiles
			// 
			this.topMenuAnotherFiles.ForeColor = System.Drawing.Color.DodgerBlue;
			this.topMenuAnotherFiles.Name = "topMenuAnotherFiles";
			this.topMenuAnotherFiles.Size = new System.Drawing.Size(180, 26);
			this.topMenuAnotherFiles.Text = "Another Files";
			this.topMenuAnotherFiles.Click += new System.EventHandler(this.topMenuAnotherFiles_Click);
			// 
			// topMenuAbout
			// 
			this.topMenuAbout.ForeColor = System.Drawing.Color.DodgerBlue;
			this.topMenuAbout.Name = "topMenuAbout";
			this.topMenuAbout.Size = new System.Drawing.Size(180, 26);
			this.topMenuAbout.Text = "About";
			this.topMenuAbout.Click += new System.EventHandler(this.topMenuAbout_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
			// 
			// topMenuExit
			// 
			this.topMenuExit.ForeColor = System.Drawing.Color.Red;
			this.topMenuExit.Name = "topMenuExit";
			this.topMenuExit.Size = new System.Drawing.Size(180, 26);
			this.topMenuExit.Text = "Exit";
			this.topMenuExit.Click += new System.EventHandler(this.topMenuExit_Click);
			// 
			// btnList
			// 
			this.btnList.BackgroundImage = global::FolderCreator_v2.Properties.Resources.iconfinder_go_bottom_118767;
			this.btnList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnList.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnList.ForeColor = System.Drawing.Color.White;
			this.btnList.Location = new System.Drawing.Point(820, 31);
			this.btnList.Name = "btnList";
			this.btnList.Size = new System.Drawing.Size(50, 50);
			this.btnList.TabIndex = 2;
			this.btnList.UseVisualStyleBackColor = true;
			this.btnList.Click += new System.EventHandler(this.btnList_Click);
			// 
			// txtFolderPath
			// 
			this.txtFolderPath.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtFolderPath.ForeColor = System.Drawing.Color.Crimson;
			this.txtFolderPath.Location = new System.Drawing.Point(12, 39);
			this.txtFolderPath.Name = "txtFolderPath";
			this.txtFolderPath.Size = new System.Drawing.Size(734, 34);
			this.txtFolderPath.TabIndex = 1;
			// 
			// btnFindFolder
			// 
			this.btnFindFolder.BackgroundImage = global::FolderCreator_v2.Properties.Resources.iconfinder_folder_saved_search_118905;
			this.btnFindFolder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnFindFolder.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnFindFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFindFolder.ForeColor = System.Drawing.Color.White;
			this.btnFindFolder.Location = new System.Drawing.Point(763, 31);
			this.btnFindFolder.Name = "btnFindFolder";
			this.btnFindFolder.Size = new System.Drawing.Size(50, 50);
			this.btnFindFolder.TabIndex = 0;
			this.btnFindFolder.UseVisualStyleBackColor = true;
			this.btnFindFolder.Click += new System.EventHandler(this.btnFindFolder_Click);
			// 
			// panelBottom
			// 
			this.panelBottom.BackColor = System.Drawing.Color.Crimson;
			this.panelBottom.Controls.Add(this.pbEffect);
			this.panelBottom.Controls.Add(this.btnCreateFolders);
			this.panelBottom.Controls.Add(this.ckMoveFiles);
			this.panelBottom.Controls.Add(this.btnUncheckAll);
			this.panelBottom.Controls.Add(this.btnCheckAll);
			this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panelBottom.Location = new System.Drawing.Point(0, 516);
			this.panelBottom.Name = "panelBottom";
			this.panelBottom.Size = new System.Drawing.Size(882, 75);
			this.panelBottom.TabIndex = 2;
			// 
			// pbEffect
			// 
			this.pbEffect.Enabled = false;
			this.pbEffect.Location = new System.Drawing.Point(439, 11);
			this.pbEffect.MarqueeAnimationSpeed = 10;
			this.pbEffect.Maximum = 50;
			this.pbEffect.Name = "pbEffect";
			this.pbEffect.Size = new System.Drawing.Size(374, 52);
			this.pbEffect.Step = 5;
			this.pbEffect.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
			this.pbEffect.TabIndex = 4;
			this.pbEffect.Visible = false;
			// 
			// btnCreateFolders
			// 
			this.btnCreateFolders.BackgroundImage = global::FolderCreator_v2.Properties.Resources.iconfinder_go_next_118773;
			this.btnCreateFolders.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnCreateFolders.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCreateFolders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCreateFolders.ForeColor = System.Drawing.Color.White;
			this.btnCreateFolders.Location = new System.Drawing.Point(820, 11);
			this.btnCreateFolders.Name = "btnCreateFolders";
			this.btnCreateFolders.Size = new System.Drawing.Size(50, 50);
			this.btnCreateFolders.TabIndex = 3;
			this.btnCreateFolders.UseVisualStyleBackColor = true;
			this.btnCreateFolders.Click += new System.EventHandler(this.btnCreateFolders_Click);
			// 
			// ckMoveFiles
			// 
			this.ckMoveFiles.AutoSize = true;
			this.ckMoveFiles.Checked = true;
			this.ckMoveFiles.CheckState = System.Windows.Forms.CheckState.Checked;
			this.ckMoveFiles.ForeColor = System.Drawing.Color.White;
			this.ckMoveFiles.Location = new System.Drawing.Point(255, 24);
			this.ckMoveFiles.Name = "ckMoveFiles";
			this.ckMoveFiles.Size = new System.Drawing.Size(178, 27);
			this.ckMoveFiles.TabIndex = 2;
			this.ckMoveFiles.Text = "Move files to folder";
			this.ckMoveFiles.UseVisualStyleBackColor = true;
			// 
			// btnUncheckAll
			// 
			this.btnUncheckAll.BackColor = System.Drawing.Color.White;
			this.btnUncheckAll.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnUncheckAll.ForeColor = System.Drawing.Color.Crimson;
			this.btnUncheckAll.Location = new System.Drawing.Point(132, 18);
			this.btnUncheckAll.Name = "btnUncheckAll";
			this.btnUncheckAll.Size = new System.Drawing.Size(117, 36);
			this.btnUncheckAll.TabIndex = 1;
			this.btnUncheckAll.Text = "Uncheck all";
			this.btnUncheckAll.UseVisualStyleBackColor = false;
			this.btnUncheckAll.Click += new System.EventHandler(this.btnUncheckAll_Click);
			// 
			// btnCheckAll
			// 
			this.btnCheckAll.BackColor = System.Drawing.Color.White;
			this.btnCheckAll.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCheckAll.ForeColor = System.Drawing.Color.Crimson;
			this.btnCheckAll.Location = new System.Drawing.Point(12, 18);
			this.btnCheckAll.Name = "btnCheckAll";
			this.btnCheckAll.Size = new System.Drawing.Size(117, 36);
			this.btnCheckAll.TabIndex = 0;
			this.btnCheckAll.Text = "Check all";
			this.btnCheckAll.UseVisualStyleBackColor = false;
			this.btnCheckAll.Click += new System.EventHandler(this.btnCheckAll_Click);
			// 
			// panelCenter
			// 
			this.panelCenter.Controls.Add(this.clbFiles);
			this.panelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelCenter.Location = new System.Drawing.Point(0, 92);
			this.panelCenter.Name = "panelCenter";
			this.panelCenter.Size = new System.Drawing.Size(882, 424);
			this.panelCenter.TabIndex = 3;
			// 
			// clbFiles
			// 
			this.clbFiles.Dock = System.Windows.Forms.DockStyle.Fill;
			this.clbFiles.FormattingEnabled = true;
			this.clbFiles.Location = new System.Drawing.Point(0, 0);
			this.clbFiles.Name = "clbFiles";
			this.clbFiles.Size = new System.Drawing.Size(882, 424);
			this.clbFiles.TabIndex = 2;
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(882, 591);
			this.Controls.Add(this.panelCenter);
			this.Controls.Add(this.panelBottom);
			this.Controls.Add(this.panelTop);
			this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.MaximizeBox = false;
			this.Name = "frmMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Folder Creator V2";
			this.panelTop.ResumeLayout(false);
			this.panelTop.PerformLayout();
			this.topMenu.ResumeLayout(false);
			this.topMenu.PerformLayout();
			this.panelBottom.ResumeLayout(false);
			this.panelBottom.PerformLayout();
			this.panelCenter.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelTop;
		private System.Windows.Forms.TextBox txtFolderPath;
		private System.Windows.Forms.Button btnFindFolder;
		private System.Windows.Forms.Panel panelBottom;
		private System.Windows.Forms.Panel panelCenter;
		private System.Windows.Forms.CheckedListBox clbFiles;
		private System.Windows.Forms.Button btnUncheckAll;
		private System.Windows.Forms.Button btnCheckAll;
		private System.Windows.Forms.CheckBox ckMoveFiles;
		private System.Windows.Forms.Button btnList;
		private System.Windows.Forms.MenuStrip topMenu;
		private System.Windows.Forms.ToolStripMenuItem topMenuFile;
		private System.Windows.Forms.ToolStripMenuItem topMenuExtensionFiles;
		private System.Windows.Forms.ToolStripMenuItem topMenuAbout;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem topMenuExit;
		private System.Windows.Forms.ToolStripMenuItem topMenuAnotherFiles;
		private System.Windows.Forms.Button btnCreateFolders;
		private System.Windows.Forms.ProgressBar pbEffect;
	}
}

