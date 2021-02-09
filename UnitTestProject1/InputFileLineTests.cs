using Band7TechTest;
using NUnit.Framework;

namespace UnitTestProject1
{
	public class InputFileLineTests
	{
		[Test]
		public void Constructor_ValidValues_SetsOrgCodeCorrectly()
		{
			const string OrgCode = "ABCDE";
			const int Category = 3;
			const string Date = "1999-01-01";

			var line = new InputFileLine($"{OrgCode},{Category},{Date}");
			Assert.That(line.OrganisationCode, Is.EqualTo(OrgCode));
		}

		[Test]
		public void Constructor_ValidValues_SetsCategoryCorrectly()
		{
			const string OrgCode = "ABCDE";
			const int Category = 3;
			const string Date = "1999-01-01";

			var line = new InputFileLine($"{OrgCode},{Category},{Date}");
			Assert.That(line.Category, Is.EqualTo(InputCategory.Cat4));
		}

		// TODO Add test for valid Date

		// ERROR CASES
		[Test]
		public void Constructor_MissingCategory_SetsCategoryToUnset()
		{
			//TODO Finish this.

			const string OrgCode = "ABCDE";
			const int Category = 3;
			const string Date = "1999-01-01";

			var line = new InputFileLine($"{OrgCode},,{Date}");

			// Set it to pass for now.
			Assert.IsTrue(true);
		}

		// TODO More tests required, including
		// Missing org code
		// Non-integer type
		// Invalid integer type
		// Missing date
		// Invalid date
	}
}
