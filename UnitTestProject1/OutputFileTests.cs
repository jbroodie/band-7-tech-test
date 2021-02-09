using System.Collections.Generic;
using System.Linq;
using Band7TechTest;
using NUnit.Framework;

namespace UnitTestProject1
{
	internal class OutputFileTests
	{
		[Test]
		public void Transform_ValidValues_StripsHeaderLine()
		{
			var lines = new List<string>
			{
				"Header line",
				"A1234,1,2000-01-01"
			};

			IEnumerable<OutputLine> y = new OutputFile().Transform(lines);

			Assert.That(y.Single().ToString(), Is.EqualTo("Organisation:A1234 - Type:Hospital - Registration Date:1st January 2000"));
		}

		// TODO Other tests
	}
}
