using System;
using System.Windows.Forms;

namespace UserInterfaceGenerator.FileContentGenerators.Xaml
{
	class ButtonGenerator : ControlGenerator
	{
		public override string OpeningElement(TreeNode treeNode, int level)
		{
			var text = $"{Environment.NewLine}{GetIndentation(level + 1)}{GetTextProperty(treeNode)}";
			var result = $"{GetIndentation(level)}<Button>";
			if (!String.IsNullOrWhiteSpace(text))
			{
				result += text;
			}
			else
			{
				result += $"{Environment.NewLine}{GetIndentation(level + 1)}<Button.Content>";
			}
			return result;
		}

		public override string ClosingElement(TreeNode treeNode, int level)
		{
			var result = String.Empty;
			var text = $"{Environment.NewLine}{GetIndentation(level + 1)}{GetTextProperty(treeNode)}";
			if (String.IsNullOrWhiteSpace(text))
			{
				result += $"{GetIndentation(level + 1)}</Button.Content>{Environment.NewLine}";
			}
			result += $"{GetIndentation(level)}</Button>";
			return result;
		}
	}
}
