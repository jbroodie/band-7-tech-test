using System;

namespace Band7TechTest
{
	internal class InputFileLine
	{
		public InputFileLine(string line)
		{
			string[] fields = line.Split(',');

			OrganisationCode = fields[0];
			Category = ConvertCategory(fields[1]);
			RegistrationDate = DateTime.Parse(fields[2]);

			// Can uncomment for testing
			// Console.WriteLine($"{OrganisationCode} {Category} {RegistrationDate}");
		}

		public string OrganisationCode { get; }
		public InputCategory Category { get; }
		public DateTime RegistrationDate { get; }

		private static InputCategory ConvertCategory(string input)
		{
			if (!int.TryParse(input, out int result))
				result = 0;

			return (InputCategory)result;
		}
	}
}
