using System.Windows.Forms;

namespace UserInterfaceGenerator.FileContentGenerators.Html
{
	class NumericUpDownGenerator : ControlGenerator
	{
		public override string OpeningElement(TreeNode treeNode, int level)
		{
			return $"{GetIndentation(level)}<input type=\"number\" min=\"1\" max=\"100\" />";
		}

		public override string ClosingElement(TreeNode treeNode, int level)
		{
			return null;
		}
	}
}
