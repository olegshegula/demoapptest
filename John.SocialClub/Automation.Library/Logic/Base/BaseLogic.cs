using Automation.Library.Logic.Membership;
using Automation.Library.ObjectRepository.Base;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Automation.Library.Logic.Base
{
	public class BaseLogic : ApplicationBaseObjects
    {
        private ApplicationUnderTest _app;
        public BaseLogic(ApplicationUnderTest app) : base(app)
        {
            _app = app;
        }

        public NewRegistrationTab CheckIfMembersipWindowOpened()
        {
            Assert.IsTrue(MembershipMainClient.Exists);
            return new NewRegistrationTab(_app);
        }
    }
}