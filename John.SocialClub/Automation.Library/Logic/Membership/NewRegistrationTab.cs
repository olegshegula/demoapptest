using Automation.Library.Common;
using Automation.Library.ObjectRepository.Membership;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Automation.Library.Logic.Membership
{
    public class NewRegistrationTab : NewRegistrationTabObjects
    {
        private ApplicationUnderTest _app;
	    readonly Timeout _timeout = new Timeout();

        public NewRegistrationTab(ApplicationUnderTest app)
            : base(app)
        {
            _app = app;
        }

        private void WaitNewRegistrationWindowLoaded()
        {
            Tools.WaitControlExists(NewRegistrationWindow);
        }
        public NewRegistrationTab CheckIfNewRegistrationWindowExists()
        {
            WaitNewRegistrationWindowLoaded();
			Assert.IsTrue(NewRegistrationWindow.Enabled);
            return this;
        }

		public NewRegistrationTab OpenNewRegistrationTab()
		{
		    //NewRegistrationTab.WaitForControlCondition(control => control.Exists, _timeout.WaitForControl);
            Tools.WaitControlExists(NewRegistrationTab);
			Tools.Click(NewRegistrationTab);
		    return this;
		}

		public NewRegistrationTab OpenMemberTab()
		{
            Tools.WaitControlExists(NewRegistrationTab);
			Tools.Click(NewRegistrationTab);
		    return this;
		}

		public NewRegistrationTab EnterMemberName(string memberName)
		{
            Tools.WaitControlExists(NameFld);
			Tools.SendKeys(NameFld, memberName);
		    return this;
		}

		public NewRegistrationTab ChooseOccupation(string occupation)
		{
            Tools.WaitControlExists(OccupationDropdown);
			OccupationDropdown.SelectedItem = occupation;
		    return this;
		}

		public NewRegistrationTab EnterSalary(string salary)
		{
            Tools.WaitControlExists(SalaryFld);
			Tools.SendKeys(SalaryFld, salary);
		    return this;
		}

		public NewRegistrationTab ChooseMaritalStatus(string maritalStatus)
		{
			//MaritalStatusDropdown.WaitForControlCondition(control => control.Exists, _timeout.WaitForControl);
            Tools.WaitControlExists(MaritalStatusDropdown);
			MaritalStatusDropdown.SelectedItem = maritalStatus;
		    return this;
		}

		public NewRegistrationTab ChooseHealthStatus(string healthStatus)
		{
            Tools.WaitControlExists(HealthStatusDropdown);
			HealthStatusDropdown.SelectedItem = healthStatus;
		    return this;
		}

		public NewRegistrationTab EnterNoOfChildren(string noOfChildren)
		{
            Tools.WaitControlExists(NoOfChildrenFld);
			Tools.SendKeys(NoOfChildrenFld, noOfChildren);
		    return this;
		}

		public NewRegistrationTab ClickRegisterButton()
		{
            Tools.WaitControlExists(RegisterBttn);
			Tools.Click(RegisterBttn);
		    return this;
		}

		public NewRegistrationTab IsRegisterMessageCorrect(string expectedStatusMesage)
		{
            Tools.WaitControlExists(RegisterStatusMessage);
			Assert.AreEqual(expectedStatusMesage, RegisterStatusMessage.DisplayText, "Registration status message is wrong");
			Tools.Click(CloseRegistrationStatusBttn);
		    return this;
		}

        
        public NewRegistrationTab OpenNewSearchMamberTab()
        {
            Tools.WaitControlExists(NewRegistrationTab);
            Tools.Click(NewSearchManageTab);
            return new NewRegistrationTab(_app);
        }

        public NewRegistrationTab ClickPrintPreviewButton()
        {
            Tools.WaitControlExists(PrintPreviewBttn);
            Tools.Click(PrintPreviewBttn);
            return this;
        }

        public NewRegistrationTab IsPrintPreviewWindowOpened()
        {
            Tools.WaitControlExists(NewPrintPreviewWindow);
            Assert.IsTrue(NewPrintPreviewWindow.Enabled);
            return this;
        }

        public NewRegistrationTab OpenSearchTab()
        {
            Tools.WaitControlExists(NewSearchManageTab);
            Tools.Click(NewSearchManageTab);
            Tools.Click(TabSearch);
            return new NewRegistrationTab(_app);
        }


        public NewRegistrationTab ChooseSearchOccupation(string occupation)
        {
            Tools.WaitControlExists(OccupationSearchDropdown);
            OccupationSearchDropdown.SelectedItem = occupation;
            return this;
        }

        public NewRegistrationTab ChooseSearchMaritalStatus(string maritalStatus)
        {
            Tools.WaitControlExists(MaritalSearchStatusDropdown);
            MaritalSearchStatusDropdown.SelectedItem = maritalStatus;
            return this;
        }

        public NewRegistrationTab ClickSearch()
        {
            Tools.WaitControlExists(SearchBttn);
            Tools.Click(SearchBttn);
            return this;
        }

        public NewRegistrationTab IsSearchResultCorrect()
        {
            Tools.WaitControlExists(ResultTableWindow);
            var count = TableControl.Rows.Count;
            Assert.AreNotEqual(null,count);
            return this;
        }

		public NewRegistrationTab ClickUpdateButton()
		{
            Tools.WaitControlExists(UpdateBttn);
			Tools.Click(UpdateBttn);
		    return this;
		}

		public NewRegistrationTab IsUpdateMessageCorrect(string expectedStatusMesage)
		{
            Tools.WaitControlExists(UpdateSuccessfullPopUpMessage);
			Assert.AreEqual(expectedStatusMesage, UpdateSuccessfullPopUpMessage.DisplayText, "Registration status message is wrong");
			Tools.Click(CloseUpdateMessageBttn);
		    return this;
		}
    }
}