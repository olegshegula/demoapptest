using System.Threading;
using Automation.Library.Logic.Login;
using Microsoft.VisualStudio.TestTools.UITesting;

namespace CodedUITestProject.Common
{
	public class BaseTest
	{
		private ApplicationUnderTest _application;

		public LoginForm LunchApplication()
		{

            _application = ApplicationUnderTest.Launch(@"C:\demoapp\demoapptests\John.SocialClub\John.SocialClub.Desktop\bin\Debug\John.SocialClub.Desktop.exe");
            
            return new LoginForm(_application);
		}

		public void CloseApplication()
		{
			if (_application != null)
			{
				_application.Close();
			}
		}
	}
}