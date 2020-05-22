using System;
using System.Windows.Forms;

namespace UserInterfaceGenerator.FileContentGenerators.Xaml
{
	class ListViewGenerator : ControlGenerator
	{
		public override string OpeningElement(TreeNode treeNode, int level)
		{
			return $"{GetIndentation(level)}<ListView>{Environment.NewLine}" +
				$"{GetIndentation(level + 1)}<ListViewItem Content=\"Item 1\"></ListViewItem>{Environment.NewLine}" +
				$"{GetIndentation(level + 1)}<ListViewItem Content=\"Item 2\"></ListViewItem>{Environment.NewLine}";
		}

		public override string ClosingElement(TreeNode treeNode, int level)
		{
			return $"{GetIndentation(level)}</ListView>";
		}
	}
}
