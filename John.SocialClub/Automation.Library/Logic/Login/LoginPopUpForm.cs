using Automation.Library.ObjectRepository.Login;
using Microsoft.VisualStudio.TestTools.UITesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Automation.Library.Logic.Login
{
    class LoginPopUpForm: LoginPopUpFormObject
    {
        private ApplicationUnderTest _app;

        public LoginPopUpForm(ApplicationUnderTest app)
            : base(app)
		{
		    _app = app;
		}

       
    }
}
