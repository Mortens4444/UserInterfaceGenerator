using System.Windows.Forms;

namespace UserInterfaceGenerator.FileContentGenerators.Html
{
	class TextBoxGenerator : ControlGenerator
	{
		public static int TextBoxId = 1;

		public override string OpeningElement(TreeNode treeNode, int level)
		{
			var id = $"textbox_{TextBoxId}";
			var result = $"{GetIndentation(level)}<input type=\"text\" id=\"{id}\" name=\"{id}\" value=\"{GetTextProperty(treeNode)}\" />";
			TextBoxId++;
			return result;
		}

		public override string ClosingElement(TreeNode treeNode, int level)
		{
			return null;
		}
	}
}
