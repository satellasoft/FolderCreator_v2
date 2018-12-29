namespace FolderCreator_v2.Forms
{
	partial class frmExtensionFiles
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
			this.btnSave = new System.Windows.Forms.Button();
			this.txtExtension = new System.Windows.Forms.TextBox();
			this.btnAdd = new System.Windows.Forms.Button();
			this.panelCenter = new System.Windows.Forms.Panel();
			this.listExtension = new System.Windows.Forms.ListBox();
			this.panelTop.SuspendLayout();
			this.panelCenter.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelTop
			// 
			this.panelTop.BackColor = System.Drawing.Color.DodgerBlue;
			this.panelTop.Controls.Add(this.btnSave);
			this.panelTop.Controls.Add(this.txtExtension);
			this.panelTop.Controls.Add(this.btnAdd);
			this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelTop.Location = new System.Drawing.Point(0, 0);
			this.panelTop.Name = "panelTop";
			this.panelTop.Size = new System.Drawing.Size(377, 68);
			this.panelTop.TabIndex = 1;
			// 
			// btnSave
			// 
			this.btnSave.BackgroundImage = global::FolderCreator_v2.Properties.Resources.iconfinder_Save_1493294;
			this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSave.ForeColor = System.Drawing.Color.White;
			this.btnSave.Location = new System.Drawing.Point(306, 10);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(50, 50);
			this.btnSave.TabIndex = 4;
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// txtExtension
			// 
			this.txtExtension.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtExtension.Location = new System.Drawing.Point(12, 16);
			this.txtExtension.Name = "txtExtension";
			this.txtExtension.Size = new System.Drawing.Size(209, 34);
			this.txtExtension.TabIndex = 3;
			this.txtExtension.Text = ".";
			// 
			// btnAdd
			// 
			this.btnAdd.BackgroundImage = global::FolderCreator_v2.Properties.Resources.iconfinder_list_add_118777;
			this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAdd.ForeColor = System.Drawing.Color.White;
			this.btnAdd.Location = new System.Drawing.Point(243, 10);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(50, 50);
			this.btnAdd.TabIndex = 2;
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// panelCenter
			// 
			this.panelCenter.Controls.Add(this.listExtension);
			this.panelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelCenter.Location = new System.Drawing.Point(0, 68);
			this.panelCenter.Name = "panelCenter";
			this.panelCenter.Size = new System.Drawing.Size(377, 328);
			this.panelCenter.TabIndex = 4;
			// 
			// listExtension
			// 
			this.listExtension.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listExtension.FormattingEnabled = true;
			this.listExtension.ItemHeight = 23;
			this.listExtension.Location = new System.Drawing.Point(0, 0);
			this.listExtension.Name = "listExtension";
			this.listExtension.Size = new System.Drawing.Size(377, 328);
			this.listExtension.TabIndex = 1;
			this.listExtension.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listExtension_KeyDown);
			this.listExtension.MouseHover += new System.EventHandler(this.listExtension_MouseHover);
			// 
			// frmExtensionFiles
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(377, 396);
			this.Controls.Add(this.panelCenter);
			this.Controls.Add(this.panelTop);
			this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmExtensionFiles";
			this.Opacity = 0.98D;
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Extension Files";
			this.panelTop.ResumeLayout(false);
			this.panelTop.PerformLayout();
			this.panelCenter.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel panelTop;
		private System.Windows.Forms.Panel panelCenter;
		private System.Windows.Forms.ListBox listExtension;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.TextBox txtExtension;
		private System.Windows.Forms.Button btnAdd;
	}
}