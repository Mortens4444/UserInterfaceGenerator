using System;
using System.Windows.Forms;

namespace UserInterfaceGenerator
{
	class UserInterfaceFileLoader
	{
		public void LoadNodes(TreeView treeView, string fileContent)
		{
			treeView.Nodes.Clear();
			var actualParentNodeCollection = treeView.Nodes;
			var lines = fileContent.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
			foreach (var line in lines)
			{
				var level = GetLevel(line);
				var treeNodeCollection = GetLatestTreeNodeCollectionOnLevel(treeView, level);
				var treeNode = new TreeNode(line.TrimStart('\t'), 0, 0);
				treeNodeCollection.Add(treeNode);
			}
			treeView.ExpandAll();
		}

		private int GetLevel(string line)
		{
			int i = 0;
			while (i < line.Length && line[i] == '\t')
			{
				i++;
			}
			return i;
		}

		private TreeNodeCollection GetLatestTreeNodeCollectionOnLevel(TreeView treeView, int level)
		{
			if (level == 0)
			{
				return treeView.Nodes;
			}

			var parent = GetLatestTreeNodeCollectionOnLevel(treeView, level - 1);
			return parent[parent.Count - 1].Nodes;
		}
	}
}
