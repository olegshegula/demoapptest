using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace Automation.Library.ObjectRepository.Base
{
    public class ApplicationBaseObjects
    {
        private ApplicationUnderTest _app;
		public ApplicationBaseObjects(ApplicationUnderTest app)
		{
			_app = app;
		}

        protected WinClient MembershipMainClient
		{
			get
			{
                if (_membershipMainClient == null)
				{
                    _membershipMainClient = new WinClient(_app);
                    _membershipMainClient.SearchProperties[WinClient.PropertyNames.Name] = "Social Club - Membership Manager";
                    _membershipMainClient.SearchProperties[WinClient.PropertyNames.ControlName] = "Manage";
				}
                return _membershipMainClient;
			}
		}

		private WinClient _membershipMainClient;
    }
}