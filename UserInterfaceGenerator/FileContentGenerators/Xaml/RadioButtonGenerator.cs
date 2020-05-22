using System.Windows.Forms;

namespace UserInterfaceGenerator.FileContentGenerators.Xaml
{
	class RadioButtonGenerator : ControlGenerator
	{
		public override string OpeningElement(TreeNode treeNode, int level)
		{
			var result = $"{GetIndentation(level)}<RadioButton GroupName=\"{GetTargetProperty(treeNode)}\" Content=\"{GetTextProperty(treeNode)}\"";
			if (IsChecked(treeNode))
			{
				result += " IsChecked=\"True\"";
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
