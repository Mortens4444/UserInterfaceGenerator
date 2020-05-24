using UserInterfaceGenerator.FileContentGenerators;

namespace UserInterfaceGenerator.Forms
{
	partial class MainForm
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("RootElement");
			this.toolStrip = new System.Windows.Forms.ToolStrip();
			this.tsbNewUserInterface = new System.Windows.Forms.ToolStripButton();
			this.tslNewUserInterface = new System.Windows.Forms.ToolStripLabel();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.tsbSaveUI = new System.Windows.Forms.ToolStripButton();
			this.tslSaveUI = new System.Windows.Forms.ToolStripLabel();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.tsbLoadUI = new System.Windows.Forms.ToolStripButton();
			this.tslLoadUI = new System.Windows.Forms.ToolStripLabel();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.tsbGenerateSource = new System.Windows.Forms.ToolStripButton();
			this.tslGeneratelSource = new System.Windows.Forms.ToolStripLabel();
			this.tscbLanguage = new System.Windows.Forms.ToolStripComboBox();
			this.statusStrip = new System.Windows.Forms.StatusStrip();
			this.tsslInfoLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.pMain = new System.Windows.Forms.Panel();
			this.pSource = new System.Windows.Forms.Panel();
			this.rtbSource = new System.Windows.Forms.RichTextBox();
			this.splitter1 = new System.Windows.Forms.Splitter();
			this.pUserInterfaceStructure = new System.Windows.Forms.Panel();
			this.tvUserInterfaceStructure = new System.Windows.Forms.TreeView();
			this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.TslmAddChildControl = new System.Windows.Forms.ToolStripMenuItem();
			this.TslmDeleteControl = new System.Windows.Forms.ToolStripMenuItem();
			this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.toolStrip.SuspendLayout();
			this.statusStrip.SuspendLayout();
			this.pMain.SuspendLayout();
			this.pSource.SuspendLayout();
			this.pUserInterfaceStructure.SuspendLayout();
			this.contextMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStrip
			// 
			this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNewUserInterface,
            this.tslNewUserInterface,
            this.toolStripSeparator1,
            this.tsbSaveUI,
            this.tslSaveUI,
            this.toolStripSeparator3,
            this.tsbLoadUI,
            this.tslLoadUI,
            this.toolStripSeparator4,
            this.tsbGenerateSource,
            this.tslGeneratelSource,
            this.tscbLanguage});
			this.toolStrip.Location = new System.Drawing.Point(0, 0);
			this.toolStrip.Name = "toolStrip";
			this.toolStrip.Size = new System.Drawing.Size(800, 25);
			this.toolStrip.TabIndex = 1;
			this.toolStrip.Text = "toolStrip1";
			// 
			// tsbNewUserInterface
			// 
			this.tsbNewUserInterface.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbNewUserInterface.Image = ((System.Drawing.Image)(resources.GetObject("tsbNewUserInterface.Image")));
			this.tsbNewUserInterface.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbNewUserInterface.Name = "tsbNewUserInterface";
			this.tsbNewUserInterface.Size = new System.Drawing.Size(23, 22);
			this.tsbNewUserInterface.Text = "New UI";
			this.tsbNewUserInterface.Click += new System.EventHandler(this.TsbNewUserInterface_Click);
			// 
			// tslNewUserInterface
			// 
			this.tslNewUserInterface.Name = "tslNewUserInterface";
			this.tslNewUserInterface.Size = new System.Drawing.Size(45, 22);
			this.tslNewUserInterface.Text = "New UI";
			this.tslNewUserInterface.Click += new System.EventHandler(this.TslNewUserInterface_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// tsbSaveUI
			// 
			this.tsbSaveUI.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbSaveUI.Image = ((System.Drawing.Image)(resources.GetObject("tsbSaveUI.Image")));
			this.tsbSaveUI.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbSaveUI.Name = "tsbSaveUI";
			this.tsbSaveUI.Size = new System.Drawing.Size(23, 22);
			this.tsbSaveUI.Text = "Save UI";
			this.tsbSaveUI.Click += new System.EventHandler(this.TsbSaveUI_Click);
			// 
			// tslSaveUI
			// 
			this.tslSaveUI.Name = "tslSaveUI";
			this.tslSaveUI.Size = new System.Drawing.Size(45, 22);
			this.tslSaveUI.Text = "Save UI";
			this.tslSaveUI.Click += new System.EventHandler(this.TslSaveUI_Click);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
			// 
			// tsbLoadUI
			// 
			this.tsbLoadUI.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbLoadUI.Image = ((System.Drawing.Image)(resources.GetObject("tsbLoadUI.Image")));
			this.tsbLoadUI.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbLoadUI.Name = "tsbLoadUI";
			this.tsbLoadUI.Size = new System.Drawing.Size(23, 22);
			this.tsbLoadUI.Text = "Load UI";
			this.tsbLoadUI.Click += new System.EventHandler(this.TsbLoadUI_Click);
			// 
			// tslLoadUI
			// 
			this.tslLoadUI.Name = "tslLoadUI";
			this.tslLoadUI.Size = new System.Drawing.Size(47, 22);
			this.tslLoadUI.Text = "Load UI";
			this.tslLoadUI.Click += new System.EventHandler(this.TslLoadUI_Click);
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
			// 
			// tsbGenerateSource
			// 
			this.tsbGenerateSource.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbGenerateSource.Image = ((System.Drawing.Image)(resources.GetObject("tsbGenerateSource.Image")));
			this.tsbGenerateSource.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbGenerateSource.Name = "tsbGenerateSource";
			this.tsbGenerateSource.Size = new System.Drawing.Size(23, 22);
			this.tsbGenerateSource.Text = "Generate HTML source";
			this.tsbGenerateSource.Click += new System.EventHandler(this.TsbGenerateSource_Click);
			// 
			// tslGeneratelSource
			// 
			this.tslGeneratelSource.Name = "tslGeneratelSource";
			this.tslGeneratelSource.Size = new System.Drawing.Size(92, 22);
			this.tslGeneratelSource.Text = "Generate source";
			this.tslGeneratelSource.Click += new System.EventHandler(this.TslGenerateSource_Click);
			// 
			// tscbLanguage
			// 
			this.tscbLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.tscbLanguage.Items.AddRange(new object[] {
            "HTML",
            "XAML"});
			this.tscbLanguage.Name = "tscbLanguage";
			this.tscbLanguage.Size = new System.Drawing.Size(121, 25);
			this.tscbLanguage.SelectedIndexChanged += new System.EventHandler(this.TscbLanguage_SelectedIndexChanged);
			// 
			// statusStrip
			// 
			this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslInfoLabel});
			this.statusStrip.Location = new System.Drawing.Point(0, 428);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.Size = new System.Drawing.Size(800, 22);
			this.statusStrip.TabIndex = 2;
			this.statusStrip.Text = "statusStrip1";
			// 
			// tsslInfoLabel
			// 
			this.tsslInfoLabel.Name = "tsslInfoLabel";
			this.tsslInfoLabel.Size = new System.Drawing.Size(293, 17);
			this.tsslInfoLabel.Text = "Use right click on the nodes to add or remove controls";
			// 
			// pMain
			// 
			this.pMain.Controls.Add(this.pSource);
			this.pMain.Controls.Add(this.splitter1);
			this.pMain.Controls.Add(this.pUserInterfaceStructure);
			this.pMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pMain.Location = new System.Drawing.Point(0, 25);
			this.pMain.Name = "pMain";
			this.pMain.Size = new System.Drawing.Size(800, 403);
			this.pMain.TabIndex = 3;
			// 
			// pSource
			// 
			this.pSource.Controls.Add(this.rtbSource);
			this.pSource.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pSource.Location = new System.Drawing.Point(227, 0);
			this.pSource.Name = "pSource";
			this.pSource.Size = new System.Drawing.Size(573, 403);
			this.pSource.TabIndex = 2;
			// 
			// rtbSource
			// 
			this.rtbSource.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rtbSource.Location = new System.Drawing.Point(0, 0);
			this.rtbSource.Name = "rtbSource";
			this.rtbSource.Size = new System.Drawing.Size(573, 403);
			this.rtbSource.TabIndex = 0;
			this.rtbSource.Text = "";
			// 
			// splitter1
			// 
			this.splitter1.Location = new System.Drawing.Point(219, 0);
			this.splitter1.Name = "splitter1";
			this.splitter1.Size = new System.Drawing.Size(8, 403);
			this.splitter1.TabIndex = 1;
			this.splitter1.TabStop = false;
			// 
			// pUserInterfaceStructure
			// 
			this.pUserInterfaceStructure.Controls.Add(this.tvUserInterfaceStructure);
			this.pUserInterfaceStructure.Dock = System.Windows.Forms.DockStyle.Left;
			this.pUserInterfaceStructure.Location = new System.Drawing.Point(0, 0);
			this.pUserInterfaceStructure.Name = "pUserInterfaceStructure";
			this.pUserInterfaceStructure.Size = new System.Drawing.Size(219, 403);
			this.pUserInterfaceStructure.TabIndex = 0;
			// 
			// tvUserInterfaceStructure
			// 
			this.tvUserInterfaceStructure.ContextMenuStrip = this.contextMenu;
			this.tvUserInterfaceStructure.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tvUserInterfaceStructure.Location = new System.Drawing.Point(0, 0);
			this.tvUserInterfaceStructure.Name = "tvUserInterfaceStructure";
			treeNode1.Name = "UI";
			treeNode1.Text = "RootElement";
			this.tvUserInterfaceStructure.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
			this.tvUserInterfaceStructure.Size = new System.Drawing.Size(219, 403);
			this.tvUserInterfaceStructure.TabIndex = 1;
			this.tvUserInterfaceStructure.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TvUserInterfaceStructure_NodeMouseClick);
			// 
			// contextMenu
			// 
			this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TslmAddChildControl,
            this.TslmDeleteControl});
			this.contextMenu.Name = "contextMenu";
			this.contextMenu.Size = new System.Drawing.Size(167, 48);
			// 
			// TslmAddChildControl
			// 
			this.TslmAddChildControl.Name = "TslmAddChildControl";
			this.TslmAddChildControl.Size = new System.Drawing.Size(166, 22);
			this.TslmAddChildControl.Text = "Add child control";
			this.TslmAddChildControl.Click += new System.EventHandler(this.TslmAddChildControl_Click);
			// 
			// TslmDeleteControl
			// 
			this.TslmDeleteControl.Name = "TslmDeleteControl";
			this.TslmDeleteControl.Size = new System.Drawing.Size(166, 22);
			this.TslmDeleteControl.Text = "Delete control";
			this.TslmDeleteControl.Click += new System.EventHandler(this.TslmDeleteControl_Click);
			// 
			// saveFileDialog
			// 
			this.saveFileDialog.Filter = "User interface files|*.uif|All files|*";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.pMain);
			this.Controls.Add(this.statusStrip);
			this.Controls.Add(this.toolStrip);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "User Interface Generator";
			this.toolStrip.ResumeLayout(false);
			this.toolStrip.PerformLayout();
			this.statusStrip.ResumeLayout(false);
			this.statusStrip.PerformLayout();
			this.pMain.ResumeLayout(false);
			this.pSource.ResumeLayout(false);
			this.pUserInterfaceStructure.ResumeLayout(false);
			this.contextMenu.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStrip toolStrip;
		private System.Windows.Forms.StatusStrip statusStrip;
		private System.Windows.Forms.Panel pMain;
		private System.Windows.Forms.ContextMenuStrip contextMenu;
		private System.Windows.Forms.ToolStripButton tsbNewUserInterface;
		private System.Windows.Forms.ToolStripButton tsbGenerateSource;
		private System.Windows.Forms.ToolStripLabel tslNewUserInterface;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripLabel tslGeneratelSource;
		private System.Windows.Forms.ToolStripStatusLabel tsslInfoLabel;
		private System.Windows.Forms.ToolStripButton tsbSaveUI;
		private System.Windows.Forms.ToolStripLabel tslSaveUI;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripButton tsbLoadUI;
		private System.Windows.Forms.ToolStripLabel tslLoadUI;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.SaveFileDialog saveFileDialog;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private System.Windows.Forms.ToolStripMenuItem TslmAddChildControl;
		private System.Windows.Forms.ToolStripMenuItem TslmDeleteControl;
		private System.Windows.Forms.Panel pSource;
		private System.Windows.Forms.Splitter splitter1;
		private System.Windows.Forms.Panel pUserInterfaceStructure;
		private System.Windows.Forms.TreeView tvUserInterfaceStructure;
		private System.Windows.Forms.RichTextBox rtbSource;
		private System.Windows.Forms.ToolStripComboBox tscbLanguage;
	}
}

