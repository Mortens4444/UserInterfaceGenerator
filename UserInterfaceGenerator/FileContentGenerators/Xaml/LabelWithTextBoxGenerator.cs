using System;
using System.Windows.Forms;

namespace UserInterfaceGenerator.FileContentGenerators.Xaml
{
	class LabelWithTextBoxGenerator : ControlGenerator
	{
		public override string OpeningElement(TreeNode treeNode, int level)
		{
			var text = $"{Environment.NewLine}{GetIndentation(level + 1)}{GetTextProperty(treeNode)}";
			var result = $"{GetIndentation(level)}<TextBlock>";
			if (!String.IsNullOrWhiteSpace(text))
			{
				result += text;
			}
			return result;
		}

		public override string ClosingElement(TreeNode treeNode, int level)
		{
			var target = GetTargetProperty(treeNode);
			var textBinding = String.IsNullOrEmpty(target) ? String.Empty : $"{{Binding {target}}}";
			return $"{GetIndentation(level)}</TextBlock>{Environment.NewLine}{GetIndentation(level)}<TextBox x:Name=\"tb{GetTextProperty(treeNode).ToLowerCamelCase()}\" Text=\"{textBinding}\" />";
		}
	}
}
