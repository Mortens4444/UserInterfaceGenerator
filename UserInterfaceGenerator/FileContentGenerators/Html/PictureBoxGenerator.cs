using System;
using System.Windows.Forms;

namespace UserInterfaceGenerator.FileContentGenerators.Html
{
	class PictureBoxGenerator : ControlGenerator
	{
		public override string OpeningElement(TreeNode treeNode, int level)
		{
			var result = $"{GetIndentation(level)}<img src=\"{GetTargetProperty(treeNode)}\"";
			var text = GetTextProperty(treeNode);
			if (!String.IsNullOrEmpty(text))
			{
				result += $" alt=\"{text}\"";
			}
			result += " />";
			return result;
		}

		public override string ClosingElement(TreeNode treeNode, int level)
		{
			return null;
		}
	}
}
