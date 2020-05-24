using System;
using System.Linq;

namespace UserInterfaceGenerator
{
	public static class StringExtensions
	{
		public static string ToLowerCamelCase(this string text)
		{
			var elements = text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
			if (!elements.Any())
			{
				return string.Empty;
			}
			var normalizedElements = elements.Skip(1).Select(element => Char.ToUpper(element[0]) + element.Substring(1));
			return elements.First() + String.Join(String.Empty, normalizedElements);
		}
	}
}
