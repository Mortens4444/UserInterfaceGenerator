using System;
using System.Windows.Forms;

namespace UserInterfaceGenerator.FileContentGenerators.Xaml
{
	class LabelGenerator : ControlGenerator
	{
		public override string OpeningElement(TreeNode treeNode, int level)
		{
			var text = $"{Environment.NewLine}{GetIndentation(level + 1)}{GetTextProperty(treeNode)}";
			var result = $"{GetIndentation(level)}<TextBlock>";
			if (!String.IsNullOrWhiteSpace(text))
			{
				result += text;
			}
			return result;
		}

		public override string ClosingElement(TreeNode treeNode, int level)
		{
			return $"{GetIndentation(level)}</TextBlock>";
		}
	}
}
