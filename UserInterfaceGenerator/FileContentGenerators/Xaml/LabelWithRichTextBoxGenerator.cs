using System;
using System.Windows.Forms;

namespace UserInterfaceGenerator.FileContentGenerators.Xaml
{
	class LabelWithRichTextBoxGenerator : ControlGenerator
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
			var child = String.IsNullOrEmpty(target) ? GetTextProperty(treeNode) : $"<Run Text=\"{{Binding {target}}}\">";
			return $"{GetIndentation(level)}</TextBlock>{Environment.NewLine}{GetIndentation(level)}<RichTextBox>{Environment.NewLine}{GetIndentation(level + 1)}<FlowDocument>{Environment.NewLine}{GetIndentation(level + 2)}<Paragraph FontStyle=\"Italic\" TextAlignment=\"Left\" FontSize=\"14\" Foreground=\"Gray\">{Environment.NewLine}{GetIndentation(level + 3)}{child}{Environment.NewLine}{GetIndentation(level + 2)}</Paragraph>{Environment.NewLine}{GetIndentation(level + 1)}</FlowDocument>{Environment.NewLine}{GetIndentation(level)}</RichTextBox>";
		}
	}
}
