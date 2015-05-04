using Automation.Library.Logic.Base;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace Automation.Library.ObjectRepository.Login
{
	public class LoginFormObjects : BaseLogic
	{
		private ApplicationUnderTest _app;
		public LoginFormObjects(ApplicationUnderTest app) : base(app)
		{
			_app = app;
		}

		protected WinWindow ParentLoginForm
		{
			get
			{
				if (_parentLoginForm == null)
				{
					_parentLoginForm = new WinWindow(_app);
					_parentLoginForm.SearchProperties[WinWindow.PropertyNames.Name] = "Social club - Login";
				}
				return _parentLoginForm;
			}
		}

		protected WinEdit UserNameFld
		{
			get
			{
				if (_userNameFld == null)
				{
					_userNameFld = new WinEdit(ParentLoginForm);
					_userNameFld.SearchProperties[WinEdit.PropertyNames.Name] = "Username:";
				}
				return _userNameFld;
			}
		}

		protected WinWindow UserPasswordWnd
		{
			get
			{
				if (_userPasswordWnd == null)
				{
					_userPasswordWnd = new WinWindow(_app);
					_userPasswordWnd.SearchProperties[WinWindow.PropertyNames.ControlName] = "txtPassword";
				}
				return _userPasswordWnd;
			}
		}

		protected WinEdit UserPasswordFld
		{
			get
			{
				if (_userPasswordFld == null)
				{
					_userPasswordFld = new WinEdit(UserPasswordWnd);
					_userPasswordFld.WindowTitles.Add("Social club - Login");
				}
				return _userPasswordFld;
			}
		}

		protected WinButton LoginBttn
		{
			get
			{
				if (_loginBttn == null)
				{
					_loginBttn = new WinButton(_app);
					_loginBttn.SearchProperties[WinButton.PropertyNames.Name] = "Login";
				}
				return _loginBttn;
			}
		}


        protected WinWindow LoginPopUpForm
        {
            get
            {
                if (_loginPopUpForm == null)
                {
                    _loginPopUpForm = new WinWindow();
                    _loginPopUpForm.SearchProperties[WinWindow.PropertyNames.Name] = "Login - Message";
                    _loginPopUpForm.WindowTitles.Add("Login - Message");
                }
                return _loginPopUpForm;
            }
        }

        protected WinText LoginStatusMessage
        {
            get
            {
                if (_loginStatusMessage == null)
                {
                    _loginStatusMessage = new WinText(LoginPopUpForm);
                    
                    _loginStatusMessage.SearchProperties[WinText.PropertyNames.Name] = "Please enter a valid username and password.";
                    _loginStatusMessage.WindowTitles.Add("Login - Message");
                }
                return _loginStatusMessage;
            }
        }

        protected WinButton CloseLoginMessageBttn
        {
            get
            {
                if (_closeLoginMessageBttn == null)
                {
                    _closeLoginMessageBttn = new WinButton(LoginPopUpForm);
                    _closeLoginMessageBttn.SearchProperties[WinButton.PropertyNames.Name] = "OK";
                }
                return _closeLoginMessageBttn;
            }
        }
        #region Private Variables
        private WinButton _closeLoginMessageBttn;
        private WinWindow _loginPopUpForm;
		private WinWindow _parentLoginForm;
		private WinEdit _userNameFld;
		private WinWindow _userPasswordWnd;
		private WinEdit _userPasswordFld;
		private WinButton _loginBttn;
        private WinText _loginStatusMessage;
        #endregion Private Variables
    }
}