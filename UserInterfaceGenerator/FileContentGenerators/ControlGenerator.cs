using System;
using System.Windows.Forms;

namespace UserInterfaceGenerator.FileContentGenerators
{
	abstract class ControlGenerator
	{
		private const string TargetPattern = "(Target:";
		protected const string CheckedPattern = ") (Checked)";

		public abstract string OpeningElement(TreeNode treeNode, int level);

		public abstract string ClosingElement(TreeNode treeNode, int level);

		public static string GetIndentation(int level)
		{
			var result = String.Empty;
			for (int i = 0; i < level; i++)
			{
				result += '\t';
			}
			return result;
		}

		protected string GetTextProperty(TreeNode treeNode)
		{
			var startPattern = "(Text: ";
			var startIndex = treeNode.Text.IndexOf(startPattern);
			if (startIndex == -1)
			{
				return string.Empty;
			}
			startIndex += startPattern.Length;

			var targetPropertyIndex = treeNode.Text.IndexOf(TargetPattern);
			if (targetPropertyIndex < 0)
			{
				var endIndex = treeNode.Text.LastIndexOf(')');
				if (endIndex < 0)
				{
					return String.Empty;
				}
				if (treeNode.Text.EndsWith(CheckedPattern))
				{
					return treeNode.Text.Substring(startIndex, endIndex - startIndex + 1 - CheckedPattern.Length);
				}
				return treeNode.Text.Substring(startIndex, endIndex - startIndex);
			}

			return treeNode.Text.Substring(startIndex, targetPropertyIndex - startIndex - 2);
		}

		protected string GetTargetProperty(TreeNode treeNode)
		{
			var startIndex = treeNode.Text.IndexOf(TargetPattern);
			if (startIndex > -1)
			{
				startIndex += TargetPattern.Length;
				var endIndex = treeNode.Text.LastIndexOf(')');
				return treeNode.Text.Substring(startIndex, endIndex - startIndex).Trim();
			}

			return null;
		}

		protected bool IsChecked(TreeNode treeNode)
		{
			return treeNode.Text.EndsWith(CheckedPattern);
		}
	}
}
