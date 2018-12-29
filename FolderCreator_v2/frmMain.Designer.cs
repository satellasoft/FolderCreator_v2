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
			this.txtFolderPath = new System.Windows.Forms.TextBox();
			this.panelBottom = new System.Windows.Forms.Panel();
			this.panelCenter = new System.Windows.Forms.Panel();
			this.clbFiles = new System.Windows.Forms.CheckedListBox();
			this.btnCheckAll = new System.Windows.Forms.Button();
			this.btnUncheckAll = new System.Windows.Forms.Button();
			this.ckMoveFiles = new System.Windows.Forms.CheckBox();
			this.btnList = new System.Windows.Forms.Button();
			this.btnFindFolder = new System.Windows.Forms.Button();
			this.panelTop.SuspendLayout();
			this.panelBottom.SuspendLayout();
			this.panelCenter.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelTop
			// 
			this.panelTop.BackColor = System.Drawing.Color.Crimson;
			this.panelTop.Controls.Add(this.btnList);
			this.panelTop.Controls.Add(this.txtFolderPath);
			this.panelTop.Controls.Add(this.btnFindFolder);
			this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelTop.Location = new System.Drawing.Point(0, 0);
			this.panelTop.Name = "panelTop";
			this.panelTop.Size = new System.Drawing.Size(882, 75);
			this.panelTop.TabIndex = 0;
			// 
			// txtFolderPath
			// 
			this.txtFolderPath.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtFolderPath.Location = new System.Drawing.Point(12, 19);
			this.txtFolderPath.Name = "txtFolderPath";
			this.txtFolderPath.Size = new System.Drawing.Size(734, 34);
			this.txtFolderPath.TabIndex = 1;
			// 
			// panelBottom
			// 
			this.panelBottom.BackColor = System.Drawing.Color.Crimson;
			this.panelBottom.Controls.Add(this.ckMoveFiles);
			this.panelBottom.Controls.Add(this.btnUncheckAll);
			this.panelBottom.Controls.Add(this.btnCheckAll);
			this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panelBottom.Location = new System.Drawing.Point(0, 478);
			this.panelBottom.Name = "panelBottom";
			this.panelBottom.Size = new System.Drawing.Size(882, 75);
			this.panelBottom.TabIndex = 2;
			// 
			// panelCenter
			// 
			this.panelCenter.Controls.Add(this.clbFiles);
			this.panelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelCenter.Location = new System.Drawing.Point(0, 75);
			this.panelCenter.Name = "panelCenter";
			this.panelCenter.Size = new System.Drawing.Size(882, 403);
			this.panelCenter.TabIndex = 3;
			// 
			// clbFiles
			// 
			this.clbFiles.Dock = System.Windows.Forms.DockStyle.Fill;
			this.clbFiles.FormattingEnabled = true;
			this.clbFiles.Location = new System.Drawing.Point(0, 0);
			this.clbFiles.Name = "clbFiles";
			this.clbFiles.Size = new System.Drawing.Size(882, 403);
			this.clbFiles.TabIndex = 2;
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
			// btnList
			// 
			this.btnList.BackgroundImage = global::FolderCreator_v2.Properties.Resources.iconfinder_go_bottom_118767;
			this.btnList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnList.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnList.ForeColor = System.Drawing.Color.White;
			this.btnList.Location = new System.Drawing.Point(820, 11);
			this.btnList.Name = "btnList";
			this.btnList.Size = new System.Drawing.Size(50, 50);
			this.btnList.TabIndex = 2;
			this.btnList.UseVisualStyleBackColor = true;
			this.btnList.Click += new System.EventHandler(this.btnList_Click);
			// 
			// btnFindFolder
			// 
			this.btnFindFolder.BackgroundImage = global::FolderCreator_v2.Properties.Resources.iconfinder_folder_saved_search_118905;
			this.btnFindFolder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnFindFolder.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnFindFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFindFolder.ForeColor = System.Drawing.Color.White;
			this.btnFindFolder.Location = new System.Drawing.Point(763, 11);
			this.btnFindFolder.Name = "btnFindFolder";
			this.btnFindFolder.Size = new System.Drawing.Size(50, 50);
			this.btnFindFolder.TabIndex = 0;
			this.btnFindFolder.UseVisualStyleBackColor = true;
			this.btnFindFolder.Click += new System.EventHandler(this.btnFindFolder_Click);
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(882, 553);
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
	}
}

