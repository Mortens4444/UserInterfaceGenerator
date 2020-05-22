using System;
using System.IO;
using System.Windows.Forms;
using Enums;
using MessageBoxes;
using UserInterfaceGenerator.FileContentGenerators;

namespace UserInterfaceGenerator
{
	class FileGenerator
	{
		private const string AllFilesFilter = "All files|*";
		private static readonly string UserInterfaceFilesFilter = $"User interface files|*.uif|{AllFilesFilter}";
		private static readonly string XamlFilesFilter = $"XAML files|*.xaml|{AllFilesFilter}";
		private static readonly string HtmlFilesFilter = $"HTML files|*.html|{AllFilesFilter}";

		public void SaveUserInterfaceFile(SaveFileDialog saveFileDialog, TreeNodeCollection treeNodeCollection)
		{
			var filePath = GetSaveFilePath(saveFileDialog, UserInterfaceFilesFilter);
			CreateFile(new UserInterfaceFileGenerator(), filePath, treeNodeCollection);
		}

		public void GenerateHtmlSourceFile(SaveFileDialog saveFileDialog, TreeNodeCollection treeNodeCollection)
		{
			var filePath = GetSaveFilePath(saveFileDialog, HtmlFilesFilter);
			CreateFile(new HtmlSourceCodeGenerator(), filePath, treeNodeCollection);
		}

		public void GenerateXamlSourceFile(SaveFileDialog saveFileDialog, TreeNodeCollection treeNodeCollection)
		{
			var filePath = GetSaveFilePath(saveFileDialog, XamlFilesFilter);
			CreateFile(new XamlSourceCodeGenerator(), filePath, treeNodeCollection);
		}

		private string GetSaveFilePath(SaveFileDialog saveFileDialog, string filter)
		{
			saveFileDialog.Filter = filter;
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				return saveFileDialog.FileName;
			}

			return null;
		}

		private void CreateFile(IFileContentGenerator fileContentGenerator, string filePath, TreeNodeCollection treeNodeCollection)
		{
			if (!String.IsNullOrEmpty(filePath))
			{
				var fileContent = fileContentGenerator.Generate(treeNodeCollection);
				var fileWriter = new FileWriter();
				var isSourceFileCreation = IsFileCreationAllowed(filePath);
				if (isSourceFileCreation)
				{
					fileWriter.WriteTo(filePath, fileContent);
				}
			}
		}

		private bool IsFileCreationAllowed(string filePath)
		{
			var result = false;
			if (File.Exists(filePath))
			{
				if (ConfirmBox.Show("Confirmation", "Are you sure you want to overwrite the existing file?", Decide.No) == DialogResult.Yes)
				{
					result = true;
				}
			}
			else
			{
				result = true;
			}
			return result;
		}
	}
}
