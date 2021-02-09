using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Band7TechTest
{
	internal class InputFile
	{
		private readonly string[] _fileLines;

		public InputFile(string inputFile)
		{
			_fileLines = File.ReadAllLines(inputFile);
		}

		public List<string> Text => _fileLines.ToList();
	}
}
