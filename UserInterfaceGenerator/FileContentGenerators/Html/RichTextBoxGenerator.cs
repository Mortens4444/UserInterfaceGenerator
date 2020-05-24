using System;
using System.Windows.Forms;

namespace UserInterfaceGenerator.FileContentGenerators.Html
{
	class RichTextBoxGenerator : ControlGenerator
	{
		public static int TextAreaId = 1;

		public override string OpeningElement(TreeNode treeNode, int level)
		{
			var id = $"textarea_{TextAreaId}";
			var result = $"{GetIndentation(level)}<textare id=\"{id}\" rows=\"5\" cols=\"10\">{Environment.NewLine}{GetIndentation(level + 1)}{GetTextProperty(treeNode)}";
			TextAreaId++;
			return result;
		}

		public override string ClosingElement(TreeNode treeNode, int level)
		{
			return $"{GetIndentation(level)}</textare>";
		}
	}
}
