using System;

namespace Band7TechTest
{
	internal class OutputLine
	{
		public OutputLine(InputFileLine line)
		{
			OrganisationCode = TransformOrgCode(line.OrganisationCode);
			OrganisationType = TransformOrgType(line.Category);
			NextRegistrationDate = TransformRegistrationDate(line.RegistrationDate);
		}

		public string OrganisationCode { get; }
		public OutputOrgType OrganisationType { get; }
		public DateTime NextRegistrationDate { get; set; }

		private string TransformOrgCode(string inputCode)
		{
			return inputCode;
		}

		private OutputOrgType TransformOrgType(InputCategory inputCategory)
		{
			return (OutputOrgType)inputCategory;
		}

		private DateTime TransformRegistrationDate(DateTime inputDate)
		{
			DateTime transformedDate = inputDate;

			if (inputDate.Date < DateTime.Now.Date)
				transformedDate.AddYears(1);

			return transformedDate;
		}

		public override string ToString()
		{
			return $"Organisation:{OrganisationCode}/Type:{OrganisationType}/Registration Date:{NextRegistrationDate.ToLongDateString()}";
		}
	}
}