using Automation.Library.Logic.Base;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Automation.Library.ObjectRepository.Login
{
    class LoginPopUpFormObject : BaseLogic
    {

        private ApplicationUnderTest _app;
        public LoginPopUpFormObject(ApplicationUnderTest app)
            : base(app)
		{
			_app = app;
		}

        protected WinWindow LoginPopUpForm
        {
            get
            {
                if (_loginPopUpForm == null)
                {
                    _loginPopUpForm = new WinWindow(_app);
                    _loginPopUpForm.SearchProperties[WinWindow.PropertyNames.Name] = "Login - Message";
                }
                return _loginPopUpForm;
            }
        }

        protected WinButton OkBttn
        {
            get
            {
                if (_OkBttn == null)
                {
                    _OkBttn = new WinButton(_app);
                    _OkBttn.SearchProperties[WinButton.PropertyNames.Name] = "OK";
                }
                return _OkBttn;
            }
        }

        private WinButton _OkBttn;
        private WinWindow _loginPopUpForm;
    }
}
