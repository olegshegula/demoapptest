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

        public NewRegistrationTab CheckIfNewRegistrationWindowExists()
        {
			NewRegistrationWindow.WaitForControlCondition(control => control.Exists, _timeout.WaitForControl);
			Assert.IsTrue(NewRegistrationWindow.Enabled);
            return new NewRegistrationTab(_app);
        }

		public NewRegistrationTab OpenNewRegistrationTab()
		{
			NewRegistrationTab.WaitForControlCondition(control => control.Exists, _timeout.WaitForControl);
			Mouse.Click(NewRegistrationTab);
			return new NewRegistrationTab(_app);
		}

		public NewRegistrationTab OpenMemberTab()
		{
			NewRegistrationTab.WaitForControlCondition(control => control.Exists, _timeout.WaitForControl);
			Mouse.Click(NewRegistrationTab);
			return new NewRegistrationTab(_app);
		}

		public NewRegistrationTab EnterMemberName(string memberName)
		{
			NameFld.WaitForControlCondition(control => control.Exists, _timeout.WaitForControl);
			Keyboard.SendKeys(NameFld, memberName);
			return new NewRegistrationTab(_app);
		}

		public NewRegistrationTab ChooseOccupation(string occupation)
		{
			OccupationDropdown.WaitForControlCondition(control => control.Exists, _timeout.WaitForControl);
			OccupationDropdown.SelectedItem = occupation;
			return new NewRegistrationTab(_app);
		}

		public NewRegistrationTab EnterSalary(string salary)
		{
			SalaryFld.WaitForControlCondition(control => control.Exists, _timeout.WaitForControl);
			Keyboard.SendKeys(SalaryFld, salary);
			return new NewRegistrationTab(_app);
		}

		public NewRegistrationTab ChooseMaritalStatus(string maritalStatus)
		{
			MaritalStatusDropdown.WaitForControlCondition(control => control.Exists, _timeout.WaitForControl);
			MaritalStatusDropdown.SelectedItem = maritalStatus;
			return new NewRegistrationTab(_app);
		}

		public NewRegistrationTab ChooseHealthStatus(string healthStatus)
		{
			HealthStatusDropdown.WaitForControlCondition(control => control.Exists, _timeout.WaitForControl);
			HealthStatusDropdown.SelectedItem = healthStatus;
			return new NewRegistrationTab(_app);
		}

		public NewRegistrationTab EnterNoOfChildren(string noOfChildren)
		{
			NoOfChildrenFld.WaitForControlCondition(control => control.Exists, _timeout.WaitForControl);
			Keyboard.SendKeys(NoOfChildrenFld, noOfChildren);
			return new NewRegistrationTab(_app);
		}

		public NewRegistrationTab ClickRegisterButton()
		{
			RegisterBttn.WaitForControlCondition(control => control.Exists, _timeout.WaitForControl);
			Mouse.Click(RegisterBttn);
			return new NewRegistrationTab(_app);
		}

		public NewRegistrationTab IsRegisterMessageCorrect(string expectedStatusMesage)
		{
			RegisterStatusMessage.WaitForControlCondition(control => control.Exists, _timeout.WaitForControl);
			Assert.AreEqual(expectedStatusMesage, RegisterStatusMessage.DisplayText, "Registration status message is wrong");
			Mouse.Click(CloseRegistrationStatusBttn);
			return new NewRegistrationTab(_app);
		}





        public NewRegistrationTab OpenNewSearchMamberTab()
        {
            NewRegistrationTab.WaitForControlCondition(control => control.Exists, _timeout.WaitForControl);
            Mouse.Click(NewSearchManageTab);
            return new NewRegistrationTab(_app);
        }

        public NewRegistrationTab ClickPrintPreviewButton()
        {
            PrintPreviewBttn.WaitForControlCondition(control => control.Exists, _timeout.WaitForControl);
            Mouse.Click(PrintPreviewBttn);
            return new NewRegistrationTab(_app);
        }

        public NewRegistrationTab IsPrintPreviewWindowOpened()
        {
            NewPrintPreviewWindow.WaitForControlCondition(control => control.Exists, _timeout.WaitForControl);
            Assert.IsTrue(NewPrintPreviewWindow.Enabled);
            NewPrintPreviewWindow.DrawHighlight();            
            return new NewRegistrationTab(_app);
        }

        public NewRegistrationTab OpenSearchTab()
        {
            NewSearchManageTab.WaitForControlCondition(control => control.Exists, _timeout.WaitForControl);
            Mouse.Click(NewSearchManageTab);
            Mouse.Click(TabSearch);
            
            return new NewRegistrationTab(_app);
        }


        public NewRegistrationTab ChooseSearchOccupation(string occupation)
        {
            OccupationSearchDropdown.WaitForControlCondition(control => control.Exists, _timeout.WaitForControl);
            OccupationSearchDropdown.SelectedItem = occupation;
            return new NewRegistrationTab(_app);
        }

        public NewRegistrationTab ChooseSearchMaritalStatus(string maritalStatus)
        {
            MaritalSearchStatusDropdown.WaitForControlCondition(control => control.Exists, _timeout.WaitForControl);
            MaritalSearchStatusDropdown.SelectedItem = maritalStatus;
            return new NewRegistrationTab(_app);
        }

        public NewRegistrationTab ClickSearch()
        {
            SearchBttn.WaitForControlCondition(control => control.Exists, _timeout.WaitForControl);
            Mouse.Click(SearchBttn);
            return new NewRegistrationTab(_app);
        }

        public NewRegistrationTab IsSearchResultCorrect()
        {
            ResultTableWindow.WaitForControlCondition(control => control.Exists, _timeout.WaitForControl);
            var count = TableControl.Rows.Count;
            Assert.AreNotEqual(null,count);
            return new NewRegistrationTab(_app);
        }

		public NewRegistrationTab ClickUpdateButton()
		{
			UpdateBttn.WaitForControlCondition(control => control.Exists, _timeout.WaitForControl);
			Mouse.Click(UpdateBttn);
			return new NewRegistrationTab(_app);
		}

		public NewRegistrationTab IsUpdateMessageCorrect(string expectedStatusMesage)
		{
			UpdateSuccessfullPopUpMessage.WaitForControlCondition(control => control.Exists, _timeout.WaitForControl);
			Assert.AreEqual(expectedStatusMesage, UpdateSuccessfullPopUpMessage.DisplayText, "Registration status message is wrong");
			Mouse.Click(CloseUpdateMessageBttn);
			return new NewRegistrationTab(_app);
		}
    }
}