using System;
using System.Windows.Forms;

namespace UserInterfaceGenerator.FileContentGenerators.Html
{
	class ListViewGenerator : ControlGenerator
	{
		public override string OpeningElement(TreeNode treeNode, int level)
		{
			return $"{GetIndentation(level)}<ol>{Environment.NewLine}" +
				$"{GetIndentation(level + 1)}<li>Item 1</li>{Environment.NewLine}" +
				$"{GetIndentation(level + 1)}<li>Item 2</li>";
		}

		public override string ClosingElement(TreeNode treeNode, int level)
		{
			return $"{GetIndentation(level)}</ol>";
		}
	}
}
