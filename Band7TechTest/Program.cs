using System;
using System.Collections.Generic;

namespace Band7TechTest
{
	class Program
	{
		static void Main(string[] args)
		{
			var inputFile = new InputFile("input.csv");
			IEnumerable<OutputLine> outputFileLines = new OutputFile().Transform(inputFile.Text);

			foreach (OutputLine line in outputFileLines)
			{
				Console.WriteLine(line.ToString());
			}

			Console.WriteLine("Finished");
		}
	}
}
