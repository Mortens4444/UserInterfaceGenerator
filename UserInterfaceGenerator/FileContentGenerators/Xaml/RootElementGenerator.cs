using System;
using System.Windows.Forms;

namespace UserInterfaceGenerator.FileContentGenerators.Xaml
{
	class RootElementGenerator : ControlGenerator
	{
		public override string OpeningElement(TreeNode treeNode, int level)
		{
			return $"<Window x:Class=\"WpfApplication.Namespace.Class\"{Environment.NewLine}" +
				$"\txmlns=\"http://schemas.microsoft.com/winfx/2006/xaml/presentation\"{Environment.NewLine}" +
				$"\txmlns:x=\"http://schemas.microsoft.com/winfx/2006/xaml\"{Environment.NewLine}" +
				$"\txmlns:self=\"clr-namespace:WpfApplication.Namespace\"{Environment.NewLine}" +
				$"\tTitle=\"{GetTextProperty(treeNode)}\" Height=\"800\" Width=\"600\">{Environment.NewLine}";
		}

		public override string ClosingElement(TreeNode treeNode, int level)
		{
			return "</Window>";
		}
	}
}
