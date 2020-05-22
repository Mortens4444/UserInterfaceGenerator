using System.Windows.Forms;

namespace UserInterfaceGenerator.FileContentGenerators.Html
{
	class LabelGenerator : ControlGenerator
	{
		public override string OpeningElement(TreeNode treeNode, int level)
		{
			return $"{GetIndentation(level)}<label>{GetTextProperty(treeNode)}</label>";
		}

		public override string ClosingElement(TreeNode treeNode, int level)
		{
			return null;
		}
	}
}
