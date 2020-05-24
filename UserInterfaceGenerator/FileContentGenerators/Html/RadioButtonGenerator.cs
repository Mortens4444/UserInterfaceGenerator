using System;
using System.Windows.Forms;

namespace UserInterfaceGenerator.FileContentGenerators.Html
{
	class RadioButtonGenerator : ControlGenerator
	{
		public static int RadioButtonId = 1;

		public override string OpeningElement(TreeNode treeNode, int level)
		{
			var id = $"radiobutton_{RadioButtonId}";
			var result = $"{GetIndentation(level)}<input type=\"radio\" id=\"{id}\" name=\"radio\" value=\"{id}\"";
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
			RadioButtonId++;
			return result;
		}

		public override string ClosingElement(TreeNode treeNode, int level)
		{
			return null;
		}
	}
}
