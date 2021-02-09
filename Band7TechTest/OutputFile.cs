using System.Collections.Generic;
using System.Linq;

namespace Band7TechTest
{
	internal class OutputFile
	{
		public IEnumerable<OutputLine> Transform(IEnumerable<string> input)
		{
			IEnumerable<InputFileLine> inputLines =
				input
					.Skip(1)        // TODO Make this an extension method in ExtensionMethods class
					//.Take(1)		// For testing only
					.Select(line => new InputFileLine(line));

			var list = new List<OutputLine>();
			foreach (InputFileLine line in inputLines)
			{
				var outputFileLine = new OutputLine(line);
				list.Add(outputFileLine);
			}

			return list.AsEnumerable();
		}
	}
}