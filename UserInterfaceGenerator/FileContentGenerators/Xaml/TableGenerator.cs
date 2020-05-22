using System;
using System.Windows.Forms;

namespace UserInterfaceGenerator.FileContentGenerators.Xaml
{
	class TableGenerator : ControlGenerator
	{
		public override string OpeningElement(TreeNode treeNode, int level)
		{
			return $"{GetIndentation(level)}<Table>{Environment.NewLine}" +
				$"{GetIndentation(level + 1)}<Table.Columns>{Environment.NewLine}" +
				$"{GetIndentation(level + 2)}<TableColumn />{Environment.NewLine}" +
				$"{GetIndentation(level + 2)}<TableColumn />{Environment.NewLine}" +
				$"{GetIndentation(level + 2)}<TableColumn />{Environment.NewLine}" +
				$"{GetIndentation(level + 1)}</Table.Columns>{Environment.NewLine}" +
				$"{GetIndentation(level + 1)}<TableRow>{Environment.NewLine}" +
				$"{GetIndentation(level + 2)}<TableCell>Data 1</TableCell>{Environment.NewLine}" +
				$"{GetIndentation(level + 2)}<TableCell>Data 2</TableCell>{Environment.NewLine}" +
				$"{GetIndentation(level + 2)}<TableCell>Data 3</TableCell>{Environment.NewLine}" +
				$"{GetIndentation(level + 1)}</TableRow>{Environment.NewLine}" +
				$"{GetIndentation(level + 1)}<TableRow>{Environment.NewLine}" +
				$"{GetIndentation(level + 2)}<TableCell>Data 4</TableCell>{Environment.NewLine}" +
				$"{GetIndentation(level + 2)}<TableCell>Data 5</TableCell>{Environment.NewLine}" +
				$"{GetIndentation(level + 2)}<TableCell>Data 6</TableCell>{Environment.NewLine}" +
				$"{GetIndentation(level + 1)}</TableRow>{Environment.NewLine}";
		}

		public override string ClosingElement(TreeNode treeNode, int level)
		{
			return $"{GetIndentation(level)}</Table>";
		}
	}
}
