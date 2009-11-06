using System;
namespace Hackovic.TimeReport
{
	interface ILocalizableControl
	{
		void ChangeLanguage();
	}

	public class Langages {

		public const string Bosnian = "bs-Latn-BA";
		public const string English = "en";
		public const string Swedesh = "sv-SE";	
	}
}
