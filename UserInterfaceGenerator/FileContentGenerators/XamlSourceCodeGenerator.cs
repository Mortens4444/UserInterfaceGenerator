using System.Windows.Forms;
using UserInterfaceGenerator.FileContentGenerators.Xaml;

namespace UserInterfaceGenerator.FileContentGenerators
{
	class XamlSourceCodeGenerator : TreeNodeCollectionGenerator, IFileContentGenerator
	{
		private readonly RootElementGenerator rootElementGenerator = new RootElementGenerator();

		public string Generate(TreeNodeCollection userInterfaceStructure)
		{
			return WriteNodes(userInterfaceStructure, OpeningElementToString, ClosingElementToString);
		}

		private string OpeningElementToString(TreeNode treeNode, int level)
		{
			var controlGenerator = GetControlGenerator(treeNode, MarkupLanguage.Xaml);
			return controlGenerator?.OpeningElement(treeNode, level);
		}

		private string ClosingElementToString(TreeNode treeNode, int level)
		{
			var controlGenerator = GetControlGenerator(treeNode, MarkupLanguage.Xaml);
			return controlGenerator?.ClosingElement(treeNode, level);
		}
	}
}
