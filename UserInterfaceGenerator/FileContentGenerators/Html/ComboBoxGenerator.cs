using System;
using System.Windows.Forms;

namespace UserInterfaceGenerator.FileContentGenerators.Html
{
	class ComboBoxGenerator : ControlGenerator
	{
		public override string OpeningElement(TreeNode treeNode, int level)
		{
			return $"{GetIndentation(level)}<select id=\"option_type\" name=\"option_type\">{Environment.NewLine}" +
				$"{GetIndentation(level + 2)}<option value=\"option1\">Option 1</option>{Environment.NewLine}" +
				$"{GetIndentation(level + 2)}<option value=\"option2\">Option 2</option>{Environment.NewLine}" +
				$"{GetIndentation(level + 2)}<option value=\"option3\">Option 3</option>";
		}

		public override string ClosingElement(TreeNode treeNode, int level)
		{
			return $"{GetIndentation(level)}</select>";
		}
	}
}
