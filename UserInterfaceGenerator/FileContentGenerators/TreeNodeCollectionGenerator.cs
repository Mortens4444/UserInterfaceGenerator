using System;
using System.Text;
using System.Windows.Forms;

namespace UserInterfaceGenerator.FileContentGenerators
{
	abstract class TreeNodeCollectionGenerator
	{
		public const string UserInterface = "RootElement";

		protected static string WriteNodes(TreeNodeCollection userInterfaceStructure, Func<TreeNode, int, string> openingElementToStringFunction, Func<TreeNode, int, string> closingElementToStringFunction = null, int level = 0)
		{
			var result = new StringBuilder();
			foreach (TreeNode treeNode in userInterfaceStructure)
			{
				result.AppendLine(openingElementToStringFunction(treeNode, level));
				result.Append(WriteNodes(treeNode.Nodes, openingElementToStringFunction, closingElementToStringFunction, level + 1));
				if (closingElementToStringFunction != null)
				{
					var closingElement = closingElementToStringFunction(treeNode, level);
					if (closingElement != null)
					{
						result.AppendLine(closingElement);
					}
				}
			}
			return result.ToString();
		}

		protected static ControlGenerator GetControlGenerator(TreeNode treeNode, MarkupLanguage markupLanguage)
		{
			var spaceIndex = treeNode.Text.IndexOf(' ');
			var type = spaceIndex == -1 ? treeNode.Text : treeNode.Text.Substring(0, spaceIndex);
			var generatorType = Type.GetType($"UserInterfaceGenerator.FileContentGenerators.{markupLanguage}.{type}Generator");
			if (generatorType == null)
			{
				return null;
			}
			var controlGenerator = (ControlGenerator)Activator.CreateInstance(generatorType);
			return controlGenerator;
		}
	}
}
