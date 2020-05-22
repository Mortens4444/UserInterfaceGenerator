using System;
using System.Windows.Forms;

namespace UserInterfaceGenerator.FileContentGenerators.Html
{
	class GroupBoxGenerator : ControlGenerator
	{
		public override string OpeningElement(TreeNode treeNode, int level)
		{
			return $"{GetIndentation(level)}<fieldset>{Environment.NewLine}" +
				$"{GetIndentation(level + 1)}<legend>{GetTextProperty(treeNode)}</legend>";
		}

		public override string ClosingElement(TreeNode treeNode, int level)
		{
			return $"{GetIndentation(level)}</fieldset>";
		}
	}
}
