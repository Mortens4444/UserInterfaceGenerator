using System;
using System.Windows.Forms;

namespace UserInterfaceGenerator.FileContentGenerators.Xaml
{
	class TreeViewGenerator : ControlGenerator
	{
		public override string OpeningElement(TreeNode treeNode, int level)
		{
			return $"{GetIndentation(level)}<TreeView>{Environment.NewLine}{GetIndentation(level + 1)}<TreeViewItem Header=\"Item1\">";
		}

		public override string ClosingElement(TreeNode treeNode, int level)
		{
			return $"{GetIndentation(level + 1)}</TreeViewItem>{Environment.NewLine}{GetIndentation(level)}</TreeView>";
		}
	}
}
