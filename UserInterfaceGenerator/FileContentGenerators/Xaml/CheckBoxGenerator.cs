using System;
using System.Windows.Forms;

namespace UserInterfaceGenerator.FileContentGenerators.Xaml
{
	class CheckBoxGenerator : ControlGenerator
	{
		public override string OpeningElement(TreeNode treeNode, int level)
		{
			var result = $"{GetIndentation(level)}<CheckBox";
			if (IsChecked(treeNode))
			{
				result += " IsChecked=\"True\"";
			}
			result += ">";
			var text = GetTextProperty(treeNode);
			if (!String.IsNullOrEmpty(text))
			{
				result += Environment.NewLine;
				result += $"{GetIndentation(level + 1)}{GetTextProperty(treeNode)}";
			}
			return result;
		}

		public override string ClosingElement(TreeNode treeNode, int level)
		{
			return $"{GetIndentation(level)}</CheckBox>";
		}
	}
}
