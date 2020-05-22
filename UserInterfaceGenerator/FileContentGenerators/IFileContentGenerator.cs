using System.Windows.Forms;

namespace UserInterfaceGenerator.FileContentGenerators
{
	interface IFileContentGenerator
	{
		string Generate(TreeNodeCollection userInterfaceStructure);
	}
}
