using System.Linq;
using Automation.Library.Logic.Membership;
using Automation.Library.ObjectRepository.Login;
using Microsoft.VisualStudio.TestTools.UITesting;
using Automation.Library.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Automation.Library.Logic.Login
{
	public class LoginForm : LoginFormObjects
	{
		private ApplicationUnderTest _app;
        readonly Timeout _timeout = new Timeout();

		public LoginForm(ApplicationUnderTest app) : base(app)
		{
			_app = app;
		}

        private void WaitLoginFormWindowLoaded()
        {
            Tools.WaitControlExists(ParentLoginForm);
        }

		public LoginForm SetFocus()
		{
			ParentLoginForm.WaitForControlExist();
            Tools.Click(ParentLoginForm);
			return this;
		}

		public LoginForm SetUserName(string userName)
		{
		    WaitLoginFormWindowLoaded();
            Tools.SendKeys(UserNameFld, userName);
			return this;
		}

		public LoginForm SetPassword(string password)
		{
		    WaitLoginFormWindowLoaded();
            Tools.SendKeys(UserPasswordFld, password);
			return this;
		}

		public LoginForm SubmitLogin()
		{
		    WaitLoginFormWindowLoaded();
            Tools.Click(LoginBttn);
			return this;
		}

        public LoginForm ClickOk()
        {
            WaitLoginFormWindowLoaded();
            Tools.Click(CloseLoginMessageBttn);
            return this;
        }
        
		public NewRegistrationTab LoginAs(string userName, string password)
		{
		    WaitLoginFormWindowLoaded();
            Tools.SendKeys(UserNameFld, userName);
			Tools.SendKeys(UserPasswordFld, password);
			Tools.Click(LoginBttn);
			return new NewRegistrationTab(_app);
		}

        public LoginForm IsLoginMessageCorrect(string expectedStatusMesage)
        {
            LoginStatusMessage.WaitForControlCondition(control => control.Exists, _timeout.WaitForControl);
            Assert.AreEqual(expectedStatusMesage, LoginStatusMessage.DisplayText);
            return new LoginForm(_app);
        }
    }
}