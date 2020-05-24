using System;
using System.Windows.Forms;

namespace UserInterfaceGenerator.FileContentGenerators.Html
{
	class CheckBoxGenerator : ControlGenerator
	{
		public static int CheckBoxId = 1;

		public override string OpeningElement(TreeNode treeNode, int level)
		{
			var id = $"checkbox_{CheckBoxId}";
			var result = $"{GetIndentation(level)}<input type=\"checkbox\" id=\"{id}\" name=\"{id}\" value=\"{id}\"";
			if (IsChecked(treeNode))
			{
				result += " checked=\"checked\"";
			}
			result += " />";
			var text = GetTextProperty(treeNode);
			if (!String.IsNullOrEmpty(text))
			{
				result += Environment.NewLine;
				result += $"{GetIndentation(level)}<label for=\"{id}\">{GetTextProperty(treeNode)}</label>";
			}
			CheckBoxId++;
			return result;
		}

		public override string ClosingElement(TreeNode treeNode, int level)
		{
			return null;
		}
	}
}
