namespace UserInterfaceGenerator.Forms
{
	partial class AddControlForm
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
			this.panel = new System.Windows.Forms.Panel();
			this.tbTarget = new System.Windows.Forms.TextBox();
			this.lblTarget = new System.Windows.Forms.Label();
			this.chkIsChecked = new System.Windows.Forms.CheckBox();
			this.lblText = new System.Windows.Forms.Label();
			this.tbText = new System.Windows.Forms.TextBox();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.cbControlType = new System.Windows.Forms.ComboBox();
			this.lblControlType = new System.Windows.Forms.Label();
			this.panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel
			// 
			this.panel.Controls.Add(this.tbTarget);
			this.panel.Controls.Add(this.lblTarget);
			this.panel.Controls.Add(this.chkIsChecked);
			this.panel.Controls.Add(this.lblText);
			this.panel.Controls.Add(this.tbText);
			this.panel.Controls.Add(this.btnCancel);
			this.panel.Controls.Add(this.btnAdd);
			this.panel.Controls.Add(this.cbControlType);
			this.panel.Controls.Add(this.lblControlType);
			this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel.Location = new System.Drawing.Point(0, 0);
			this.panel.Name = "panel";
			this.panel.Size = new System.Drawing.Size(424, 181);
			this.panel.TabIndex = 0;
			// 
			// tbTarget
			// 
			this.tbTarget.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbTarget.Location = new System.Drawing.Point(15, 128);
			this.tbTarget.Name = "tbTarget";
			this.tbTarget.Size = new System.Drawing.Size(405, 20);
			this.tbTarget.TabIndex = 8;
			// 
			// lblTarget
			// 
			this.lblTarget.AutoSize = true;
			this.lblTarget.Location = new System.Drawing.Point(12, 112);
			this.lblTarget.Name = "lblTarget";
			this.lblTarget.Size = new System.Drawing.Size(38, 13);
			this.lblTarget.TabIndex = 7;
			this.lblTarget.Text = "Target";
			// 
			// chkIsChecked
			// 
			this.chkIsChecked.AutoSize = true;
			this.chkIsChecked.Location = new System.Drawing.Point(333, 79);
			this.chkIsChecked.Name = "chkIsChecked";
			this.chkIsChecked.Size = new System.Drawing.Size(79, 17);
			this.chkIsChecked.TabIndex = 6;
			this.chkIsChecked.Text = "Is checked";
			this.chkIsChecked.UseVisualStyleBackColor = true;
			// 
			// lblText
			// 
			this.lblText.AutoSize = true;
			this.lblText.Location = new System.Drawing.Point(12, 61);
			this.lblText.Name = "lblText";
			this.lblText.Size = new System.Drawing.Size(28, 13);
			this.lblText.TabIndex = 5;
			this.lblText.Text = "Text";
			// 
			// tbText
			// 
			this.tbText.Location = new System.Drawing.Point(15, 77);
			this.tbText.Name = "tbText";
			this.tbText.Size = new System.Drawing.Size(312, 20);
			this.tbText.TabIndex = 4;
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(346, 155);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 3;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// btnAdd
			// 
			this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnAdd.Location = new System.Drawing.Point(265, 155);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(75, 23);
			this.btnAdd.TabIndex = 2;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.AddButton_Click);
			// 
			// cbControlType
			// 
			this.cbControlType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbControlType.FormattingEnabled = true;
			this.cbControlType.Location = new System.Drawing.Point(15, 25);
			this.cbControlType.Name = "cbControlType";
			this.cbControlType.Size = new System.Drawing.Size(158, 21);
			this.cbControlType.TabIndex = 1;
			// 
			// lblControlType
			// 
			this.lblControlType.AutoSize = true;
			this.lblControlType.Location = new System.Drawing.Point(12, 9);
			this.lblControlType.Name = "lblControlType";
			this.lblControlType.Size = new System.Drawing.Size(63, 13);
			this.lblControlType.TabIndex = 0;
			this.lblControlType.Text = "Control type";
			// 
			// AddControlForm
			// 
			this.AcceptButton = this.btnAdd;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(424, 181);
			this.Controls.Add(this.panel);
			this.MinimumSize = new System.Drawing.Size(440, 220);
			this.Name = "AddControlForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Add control";
			this.panel.ResumeLayout(false);
			this.panel.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel;
		private System.Windows.Forms.Label lblControlType;
		private System.Windows.Forms.ComboBox cbControlType;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Label lblText;
		private System.Windows.Forms.TextBox tbText;
		private System.Windows.Forms.CheckBox chkIsChecked;
		private System.Windows.Forms.TextBox tbTarget;
		private System.Windows.Forms.Label lblTarget;
	}
}