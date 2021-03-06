﻿using System.Windows.Forms;
using UserInterfaceGenerator.FileContentGenerators.Html;

namespace UserInterfaceGenerator.FileContentGenerators
{
	class HtmlSourceCodeGenerator : TreeNodeCollectionGenerator, IFileContentGenerator
	{
		private readonly RootElementGenerator rootElementGenerator = new RootElementGenerator();

		public HtmlSourceCodeGenerator()
		{
			CheckBoxGenerator.CheckBoxId = 1;
			RadioButtonGenerator.RadioButtonId = 1;
			RichTextBoxGenerator.TextAreaId = 1;
			TextBoxGenerator.TextBoxId = 1;
			DatePickerGenerator.DatePickerId = 1;
		}

		public string Generate(TreeNodeCollection userInterfaceStructure)
		{
			return WriteNodes(userInterfaceStructure, OpeningElementToString, ClosingElementToString, 2);
		}

		private string OpeningElementToString(TreeNode treeNode, int level)
		{
			var controlGenerator = GetControlGenerator(treeNode, MarkupLanguage.Html);
			return controlGenerator?.OpeningElement(treeNode, level);
		}

		private string ClosingElementToString(TreeNode treeNode, int level)
		{
			var controlGenerator = GetControlGenerator(treeNode, MarkupLanguage.Html);
			return controlGenerator?.ClosingElement(treeNode, level);
		}
	}
}
