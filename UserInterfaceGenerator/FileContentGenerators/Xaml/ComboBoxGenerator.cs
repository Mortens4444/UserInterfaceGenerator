using System;
using System.Windows.Forms;

namespace UserInterfaceGenerator.FileContentGenerators.Xaml
{
	class ComboBoxGenerator : ControlGenerator
	{
		public override string OpeningElement(TreeNode treeNode, int level)
		{
			return $"{GetIndentation(level)}<ComboBox>{Environment.NewLine}" +
				$"{GetIndentation(level + 2)}<ComboBoxItem IsSelected=\"True\">Option 1</option>{Environment.NewLine}" +
				$"{GetIndentation(level + 2)}<ComboBoxItem>Option 2</option>{Environment.NewLine}" +
				$"{GetIndentation(level + 2)}<ComboBoxItem>Option 3</option>";
		}

		public override string ClosingElement(TreeNode treeNode, int level)
		{
			return $"{GetIndentation(level)}</ComboBox>";
		}
	}
}
