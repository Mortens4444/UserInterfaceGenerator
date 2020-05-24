using System;
using System.Windows.Forms;

namespace UserInterfaceGenerator.FileContentGenerators.Html
{
	class LabelWithRichTextBoxGenerator : ControlGenerator
	{
		public override string OpeningElement(TreeNode treeNode, int level)
		{
			var text = GetTextProperty(treeNode);
			var id = $"textarea_{text.ToLower().Replace(" ", "_")}";
			return $"{GetIndentation(level)}<label>{text}</label>{Environment.NewLine}{GetIndentation(level)}<textarea id=\"{id}\" rows=\"5\" cols=\"10\"></textarea>";
		}

		public override string ClosingElement(TreeNode treeNode, int level)
		{
			return null;
		}
	}
}
