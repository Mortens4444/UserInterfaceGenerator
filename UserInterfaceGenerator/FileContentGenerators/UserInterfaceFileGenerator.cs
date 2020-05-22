using System.Text;
using System.Windows.Forms;

namespace UserInterfaceGenerator.FileContentGenerators
{
	class UserInterfaceFileGenerator : TreeNodeCollectionGenerator, IFileContentGenerator
	{
		public string Generate(TreeNodeCollection userInterfaceStructure)
		{
			return WriteNodes(userInterfaceStructure, OpeningElementToString);
		}

		private string OpeningElementToString(TreeNode treeNode, int level)
		{
			var result = new StringBuilder();
			result.Append(ControlGenerator.GetIndentation(level));
			result.Append(treeNode.Text);
			return result.ToString();
		}
	}
}
