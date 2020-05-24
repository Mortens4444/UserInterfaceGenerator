using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Enums;
using MessageBoxes;
using UserInterfaceGenerator.FileContentGenerators;

namespace UserInterfaceGenerator.Forms
{
	public partial class MainForm : Form
	{
		private static readonly FileGenerator fileGenerator = new FileGenerator();

		public MainForm()
		{
			InitializeComponent();
			rtbSource.SelectionTabs = (new int[10]).Select((item, i) => i * 20).Skip(1).ToArray();
			tvUserInterfaceStructure.ExpandAll();
			tscbLanguage.SelectedIndex = 0;
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

		private void TslGenerateSource_Click(object sender, EventArgs e)
		{
			GenerateSource();
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
				var rootNode = new TreeNode("RootElement", 0, 0)
				{
					Name = "UI"
				};
				tvUserInterfaceStructure.Nodes.Add(rootNode);
				tvUserInterfaceStructure.ExpandAll();
				GetSourceCode();
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
				GetSourceCode();
			}
		}

		private void TsbGenerateSource_Click(object sender, EventArgs e)
		{
			GenerateSource();
		}

		private void GenerateSource()
		{
			switch (tscbLanguage.SelectedItem)
			{
				case "HTML":
					fileGenerator.GenerateHtmlSourceFile(saveFileDialog, tvUserInterfaceStructure.Nodes);
					break;
				case "XAML":
					fileGenerator.GenerateXamlSourceFile(saveFileDialog, tvUserInterfaceStructure.Nodes);
					break;
			}
		}

		private void GetSourceCode()
		{
			IFileContentGenerator fileContentGenerator;
			switch (tscbLanguage.SelectedItem)
			{
				case "HTML":
					fileContentGenerator = new HtmlSourceCodeGenerator();
					break;
				case "XAML":
					fileContentGenerator = new XamlSourceCodeGenerator();
					break;
				default:
					throw new NotImplementedException();
			}
			rtbSource.Text = fileContentGenerator.Generate(tvUserInterfaceStructure.Nodes);
		}

		private void TslmAddChildControl_Click(object sender, EventArgs e)
		{
			var addControlForm = new AddControlForm();
			if (addControlForm.ShowDialog() == DialogResult.OK)
			{
				var node = new TreeNode(addControlForm.ControlDescriptor, 0, 0);
				tvUserInterfaceStructure.SelectedNode.Nodes.Add(node);
				tvUserInterfaceStructure.SelectedNode.ExpandAll();
				GetSourceCode();
			}
		}

		private void TslmDeleteControl_Click(object sender, EventArgs e)
		{
			if (tvUserInterfaceStructure.SelectedNode != tvUserInterfaceStructure.Nodes[0] &&
				tvUserInterfaceStructure.SelectedNode != null)
			{
				tvUserInterfaceStructure.SelectedNode.Remove();
				GetSourceCode();
			}
		}

		private void TscbLanguage_SelectedIndexChanged(object sender, EventArgs e)
		{
			GetSourceCode();
		}

		private void TvUserInterfaceStructure_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
		{
			tvUserInterfaceStructure.SelectedNode = e.Node;
		}
	}
}
