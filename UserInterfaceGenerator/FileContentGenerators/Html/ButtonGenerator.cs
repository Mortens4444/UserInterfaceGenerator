using System;
using System.Windows.Forms;

namespace UserInterfaceGenerator.FileContentGenerators.Html
{
	class ButtonGenerator : ControlGenerator
	{
		public override string OpeningElement(TreeNode treeNode, int level)
		{
			var buttonStart = $"{GetIndentation(level)}<button type=\"button\">";
			var text = GetTextProperty(treeNode);
			if (String.IsNullOrEmpty(text))
			{
				return buttonStart;
			}
			return $"{buttonStart}{Environment.NewLine}{GetIndentation(level + 1)}{text}";
		}

		public override string ClosingElement(TreeNode treeNode, int level)
		{
			return $"{GetIndentation(level)}</button>";
		}
	}
}
