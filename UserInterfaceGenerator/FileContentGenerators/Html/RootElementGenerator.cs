using System;
using System.Windows.Forms;

namespace UserInterfaceGenerator.FileContentGenerators.Html
{
	class RootElementGenerator : ControlGenerator
	{
		public override string OpeningElement(TreeNode treeNode, int level)
		{
			return $"<html>{Environment.NewLine}\t<head>{Environment.NewLine}\t\t<title>Generated HTML page</title>{Environment.NewLine}\t</head>{Environment.NewLine}\t<body>{Environment.NewLine}\t\t<form>";
		}

		public override string ClosingElement(TreeNode treeNode, int level)
		{
			return $"\t\t</form>{Environment.NewLine}\t</body>{Environment.NewLine}</html>";
		}
	}
}
