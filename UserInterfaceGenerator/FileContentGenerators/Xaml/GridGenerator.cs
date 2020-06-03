using System;
using System.Windows.Forms;

namespace UserInterfaceGenerator.FileContentGenerators.Xaml
{
	class GridGenerator : ControlGenerator
	{
		public override string OpeningElement(TreeNode treeNode, int level)
		{
			return $"{GetIndentation(level)}<Grid>{Environment.NewLine}{GetIndentation(level + 1)}<Grid.RowDefinitions>{Environment.NewLine}{GetIndentation(level + 2)}<RowDefinition Height=\"*\" />{Environment.NewLine}{GetIndentation(level + 1)}</Grid.RowDefinitions>{Environment.NewLine}{GetIndentation(level + 1)}<Grid.ColumnDefinitions>{Environment.NewLine}{GetIndentation(level + 2)}<ColumnDefinition Width=\"*\" />{Environment.NewLine}{GetIndentation(level + 1)}</Grid.ColumnDefinitions>";
		}

		public override string ClosingElement(TreeNode treeNode, int level)
		{
			return $"{GetIndentation(level)}</Grid>";
		}
	}
}
