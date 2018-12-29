namespace FolderCreator_v2.Forms
{
	partial class frmAnotherFiles
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
			this.panelTop = new System.Windows.Forms.Panel();
			this.lbAboutTitle = new System.Windows.Forms.Label();
			this.btnList = new System.Windows.Forms.Button();
			this.listAnotherFiles = new System.Windows.Forms.ListBox();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.panelTop.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelTop
			// 
			this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.panelTop.Controls.Add(this.btnSave);
			this.panelTop.Controls.Add(this.btnAdd);
			this.panelTop.Controls.Add(this.lbAboutTitle);
			this.panelTop.Controls.Add(this.btnList);
			this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelTop.Location = new System.Drawing.Point(0, 0);
			this.panelTop.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
			this.panelTop.Name = "panelTop";
			this.panelTop.Size = new System.Drawing.Size(593, 89);
			this.panelTop.TabIndex = 2;
			// 
			// lbAboutTitle
			// 
			this.lbAboutTitle.AutoSize = true;
			this.lbAboutTitle.Font = new System.Drawing.Font("Segoe UI Semilight", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbAboutTitle.ForeColor = System.Drawing.Color.White;
			this.lbAboutTitle.Location = new System.Drawing.Point(14, 13);
			this.lbAboutTitle.Name = "lbAboutTitle";
			this.lbAboutTitle.Size = new System.Drawing.Size(129, 54);
			this.lbAboutTitle.TabIndex = 3;
			this.lbAboutTitle.Text = "About";
			// 
			// btnList
			// 
			this.btnList.BackgroundImage = global::FolderCreator_v2.Properties.Resources.iconfinder_go_bottom_118767;
			this.btnList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnList.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnList.ForeColor = System.Drawing.Color.White;
			this.btnList.Location = new System.Drawing.Point(1037, 65);
			this.btnList.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
			this.btnList.Name = "btnList";
			this.btnList.Size = new System.Drawing.Size(63, 104);
			this.btnList.TabIndex = 2;
			this.btnList.UseVisualStyleBackColor = true;
			// 
			// listAnotherFiles
			// 
			this.listAnotherFiles.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listAnotherFiles.FormattingEnabled = true;
			this.listAnotherFiles.HorizontalScrollbar = true;
			this.listAnotherFiles.ItemHeight = 23;
			this.listAnotherFiles.Location = new System.Drawing.Point(0, 89);
			this.listAnotherFiles.Name = "listAnotherFiles";
			this.listAnotherFiles.Size = new System.Drawing.Size(593, 480);
			this.listAnotherFiles.TabIndex = 3;
			this.listAnotherFiles.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lbAnotherFiles_KeyDown);
			// 
			// btnSave
			// 
			this.btnSave.BackgroundImage = global::FolderCreator_v2.Properties.Resources.iconfinder_Save_1493294;
			this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSave.ForeColor = System.Drawing.Color.White;
			this.btnSave.Location = new System.Drawing.Point(508, 17);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(50, 50);
			this.btnSave.TabIndex = 6;
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.BackgroundImage = global::FolderCreator_v2.Properties.Resources.iconfinder_list_add_118777;
			this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAdd.ForeColor = System.Drawing.Color.White;
			this.btnAdd.Location = new System.Drawing.Point(445, 17);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(50, 50);
			this.btnAdd.TabIndex = 5;
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// frmAnotherFiles
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(593, 569);
			this.Controls.Add(this.listAnotherFiles);
			this.Controls.Add(this.panelTop);
			this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "frmAnotherFiles";
			this.Opacity = 0.98D;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Another Files";
			this.panelTop.ResumeLayout(false);
			this.panelTop.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelTop;
		private System.Windows.Forms.Label lbAboutTitle;
		private System.Windows.Forms.Button btnList;
		private System.Windows.Forms.ListBox listAnotherFiles;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnAdd;
	}
}