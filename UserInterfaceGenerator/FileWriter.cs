using System.IO;

namespace UserInterfaceGenerator
{
	class FileWriter
	{
		internal void WriteTo(string filePath, string fileContent)
		{
			using (var streamWriter = File.CreateText(filePath))
			{
				streamWriter.Write(fileContent);
				streamWriter.Flush();
			}
		}
	}
}
