using System;
using System.Windows.Forms;

namespace UserInterfaceGenerator.FileContentGenerators.Html
{
	class TableGenerator : ControlGenerator
	{
		public override string OpeningElement(TreeNode treeNode, int level)
		{
			return $"{GetIndentation(level)}<table style=\"width: 100%\">{Environment.NewLine}" +
				$"{GetIndentation(level + 1)}<tr>{Environment.NewLine}" +
				$"{GetIndentation(level + 2)}<th>Header 1</th>{Environment.NewLine}" +
				$"{GetIndentation(level + 2)}<th>Header 2</th>{Environment.NewLine}" +
				$"{GetIndentation(level + 2)}<th>Header 3</th>{Environment.NewLine}" +
				$"{GetIndentation(level + 1)}</tr>{Environment.NewLine}" +
				$"{GetIndentation(level + 1)}<tr>{Environment.NewLine}" +
				$"{GetIndentation(level + 2)}<td>Data 1</td>{Environment.NewLine}" +
				$"{GetIndentation(level + 2)}<td>Data 2</td>{Environment.NewLine}" +
				$"{GetIndentation(level + 2)}<td>Data 3</td>{Environment.NewLine}" +
				$"{GetIndentation(level + 1)}</tr>{Environment.NewLine}" +
				$"{GetIndentation(level + 1)}<tr>{Environment.NewLine}" +
				$"{GetIndentation(level + 2)}<td>Data 4</td>{Environment.NewLine}" +
				$"{GetIndentation(level + 2)}<td>Data 5</td>{Environment.NewLine}" +
				$"{GetIndentation(level + 2)}<td>Data 6</td>{Environment.NewLine}" +
				$"{GetIndentation(level + 1)}</tr>{Environment.NewLine}";
		}

		public override string ClosingElement(TreeNode treeNode, int level)
		{
			return $"{GetIndentation(level)}</table>";
		}
	}
}
