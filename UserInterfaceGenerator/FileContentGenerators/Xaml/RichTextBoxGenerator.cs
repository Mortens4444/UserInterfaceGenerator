using System;
using System.Windows.Forms;

namespace UserInterfaceGenerator.FileContentGenerators.Xaml
{
	class RichTextBoxGenerator : ControlGenerator
	{
		public override string OpeningElement(TreeNode treeNode, int level)
		{
			var nodeText = GetTextProperty(treeNode);
			var text = String.IsNullOrEmpty(nodeText) ? String.Empty : $" x:Name=\"{nodeText}\"";
			var target = GetTargetProperty(treeNode);
			var child = String.IsNullOrEmpty(target) ? GetTextProperty(treeNode) : $"<Run Text=\"{{Binding {target}}}\">";
			return $"{GetIndentation(level)}<RichTextBox{text}>{Environment.NewLine}{GetIndentation(level + 1)}<FlowDocument>{Environment.NewLine}{GetIndentation(level + 2)}<Paragraph FontStyle=\"Italic\" TextAlignment=\"Left\" FontSize=\"14\" Foreground=\"Gray\">{Environment.NewLine}{GetIndentation(level + 3)}{child}{Environment.NewLine}{GetIndentation(level + 2)}</Paragraph>";
		}

		public override string ClosingElement(TreeNode treeNode, int level)
		{
			return $"{GetIndentation(level + 1)}</FlowDocument>{Environment.NewLine}{GetIndentation(level)}</RichTextBox>";
		}
	}
}
