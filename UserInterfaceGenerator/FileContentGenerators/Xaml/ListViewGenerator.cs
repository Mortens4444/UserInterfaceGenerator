using System;
using System.Text;
using System.Windows.Forms;

namespace UserInterfaceGenerator.FileContentGenerators.Xaml
{
	class ListViewGenerator : ControlGenerator
	{
		public override string OpeningElement(TreeNode treeNode, int level)
		{
			var text = GetTextProperty(treeNode);
			var xName = String.IsNullOrEmpty(text) ? String.Empty : $" x:Name\"{text}\"";

			var target = GetTargetProperty(treeNode);
			var items = new StringBuilder();
			if (String.IsNullOrEmpty(target))
			{
				for (int i = 1; i <= 2; i++)
				{
					items.AppendLine($"{GetIndentation(level + 1)}<ListViewItem Content=\"Item {i}\"></ListViewItem>");
				}
				return $"{GetIndentation(level)}<ListView{xName}>{Environment.NewLine}{items.ToString()}";
			}

			return $"{GetIndentation(level)}<ListView{xName} ItemsSource=\"{{Binding {target}}}\">";
		}

		public override string ClosingElement(TreeNode treeNode, int level)
		{
			return $"{GetIndentation(level)}</ListView>";
		}
	}
}
