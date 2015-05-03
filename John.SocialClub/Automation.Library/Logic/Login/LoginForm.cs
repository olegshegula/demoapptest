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

		public LoginForm SetFocus()
		{
			ParentLoginForm.WaitForControlExist();
			Mouse.Click(ParentLoginForm);
			return this;
		}

		public LoginForm SetUserName(string userName)
		{
			Keyboard.SendKeys(UserNameFld, userName);
			return this;
		}

		public LoginForm SetPassword(string password)
		{
			Keyboard.SendKeys(UserPasswordFld, password);
			return this;
		}

		public LoginForm SubmitLogin()
		{
			Mouse.Click(LoginBttn);
			return this;
		}

        public LoginForm ClickOK()
        {

            Mouse.Click(CloseLoginMessageBttn);
            return this;
        }

               

		public NewRegistrationTab LoginAs(string userName, string password)
		{
			Keyboard.SendKeys(UserNameFld, userName);
			Keyboard.SendKeys(UserPasswordFld, password);
			Mouse.Click(LoginBttn);
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