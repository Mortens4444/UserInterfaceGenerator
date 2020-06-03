using System.Windows.Forms;

namespace UserInterfaceGenerator.FileContentGenerators.Html
{
	class DatePickerGenerator : ControlGenerator
	{
		public static int DatePickerId = 1;

		public override string OpeningElement(TreeNode treeNode, int level)
		{
			var id = $"datepicker_{DatePickerId}";
			var result = $"{GetIndentation(level)}<input type=\"date\" id=\"{id}\" name=\"{id}\" />";
			DatePickerId++;
			return result;
		}

		public override string ClosingElement(TreeNode treeNode, int level)
		{
			return null;
		}
	}
}
