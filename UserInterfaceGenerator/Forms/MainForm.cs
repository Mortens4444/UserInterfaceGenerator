using System;
using System.IO;
using System.Windows.Forms;
using Enums;
using MessageBoxes;

namespace UserInterfaceGenerator.Forms
{
	public partial class MainForm : Form
	{
		private static readonly FileGenerator fileGenerator = new FileGenerator();

		public MainForm()
		{
			InitializeComponent();
			tvUserInterfaceStructure.ExpandAll();
		}

		private void TslNewUserInterface_Click(object sender, EventArgs e)
		{
			CreateNewUserInterface();
		}

		private void TslSaveUI_Click(object sender, EventArgs e)
		{
			fileGenerator.SaveUserInterfaceFile(saveFileDialog, tvUserInterfaceStructure.Nodes);
		}

		private void TslLoadUI_Click(object sender, EventArgs e)
		{
			LoadUserInterfaceFile();
		}

		private void TslGenerateHtmlSource_Click(object sender, EventArgs e)
		{
			fileGenerator.GenerateHtmlSourceFile(saveFileDialog, tvUserInterfaceStructure.Nodes);
		}

		private void TslGenerateXamlSource_Click(object sender, EventArgs e)
		{
			fileGenerator.GenerateXamlSourceFile(saveFileDialog, tvUserInterfaceStructure.Nodes);
		}

		private void TsbNewUserInterface_Click(object sender, EventArgs e)
		{
			CreateNewUserInterface();
		}

		private void CreateNewUserInterface()
		{
			if (ConfirmBox.Show("Confirmation", "Are you sure you want to create a new user interface? All of your current changes will be lost!", Decide.No) == DialogResult.Yes)
			{
				tvUserInterfaceStructure.Nodes.Clear();
				var rootNode = new TreeNode("User interface", 0, 0)
				{
					Name = "UI"
				};
				tvUserInterfaceStructure.Nodes.Add(rootNode);
				tvUserInterfaceStructure.ExpandAll();
			}
		}

		private void TsbSaveUI_Click(object sender, EventArgs e)
		{
			fileGenerator.SaveUserInterfaceFile(saveFileDialog, tvUserInterfaceStructure.Nodes);
		}

		private void TsbLoadUI_Click(object sender, EventArgs e)
		{
			LoadUserInterfaceFile();
		}

		private void LoadUserInterfaceFile()
		{
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				var userInterfaceFileLoader = new UserInterfaceFileLoader();
				var fileContent = File.ReadAllText(openFileDialog.FileName);
				userInterfaceFileLoader.LoadNodes(tvUserInterfaceStructure, fileContent);
			}
		}

		private void TsbGenerateHtmlSource_Click(object sender, EventArgs e)
		{
			fileGenerator.GenerateHtmlSourceFile(saveFileDialog, tvUserInterfaceStructure.Nodes);
		}

		private void TsbGenerateXamlSource_Click(object sender, EventArgs e)
		{
			fileGenerator.GenerateXamlSourceFile(saveFileDialog, tvUserInterfaceStructure.Nodes);
		}

		private void TslmAddChildControl_Click(object sender, EventArgs e)
		{
			var addControlForm = new AddControlForm();
			if (addControlForm.ShowDialog() == DialogResult.OK)
			{
				var node = new TreeNode(addControlForm.ControlDescriptor, 0, 0);
				tvUserInterfaceStructure.SelectedNode.Nodes.Add(node);
				tvUserInterfaceStructure.SelectedNode.ExpandAll();
			}
		}

		private void TslmDeleteControl_Click(object sender, EventArgs e)
		{
			if (tvUserInterfaceStructure.SelectedNode != tvUserInterfaceStructure.Nodes[0] &&
				tvUserInterfaceStructure.SelectedNode != null)
			{
				tvUserInterfaceStructure.SelectedNode.Remove();
			}
		}
	}
}
