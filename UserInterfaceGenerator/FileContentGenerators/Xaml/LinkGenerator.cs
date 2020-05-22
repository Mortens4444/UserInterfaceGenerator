using System;
using System.Windows.Forms;

namespace UserInterfaceGenerator.FileContentGenerators.Xaml
{
	class LinkGenerator : ControlGenerator
	{
		public override string OpeningElement(TreeNode treeNode, int level)
		{
			var text = $"{Environment.NewLine}{GetIndentation(level + 1)}{GetTextProperty(treeNode)}";
			var result = $"{GetIndentation(level)}<Hyperlink NavigateUri=\"{GetTargetProperty(treeNode)}\" RequestNavigate=\"Hyperlink_RequestNavigate\">";
			if (!String.IsNullOrWhiteSpace(text))
			{
				result += text;
			}
			return result;
		}

		public override string ClosingElement(TreeNode treeNode, int level)
		{
			return $"{GetIndentation(level)}</Hyperlink>";
		}
	}
}
