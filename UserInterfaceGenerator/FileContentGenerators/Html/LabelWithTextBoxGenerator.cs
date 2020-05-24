using System;
using System.Windows.Forms;

namespace UserInterfaceGenerator.FileContentGenerators.Html
{
	class LabelWithTextBoxGenerator : ControlGenerator
	{
		public override string OpeningElement(TreeNode treeNode, int level)
		{
			var text = GetTextProperty(treeNode);
			var id = $"textbox_{text.ToLower().Replace(" ", "_")}";
			return $"{GetIndentation(level)}<label>{text}</label>{Environment.NewLine}{GetIndentation(level)}<input type=\"text\" id=\"{id}\" name=\"{id}\" value=\"{GetTextProperty(treeNode)}\" />";
		}

		public override string ClosingElement(TreeNode treeNode, int level)
		{
			return null;
		}
	}
}
