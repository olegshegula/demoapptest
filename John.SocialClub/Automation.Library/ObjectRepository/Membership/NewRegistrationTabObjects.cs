using Automation.Library.Logic.Base;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace Automation.Library.ObjectRepository.Membership
{
    public class NewRegistrationTabObjects : BaseLogic
    {
        private ApplicationUnderTest _app;

        public NewRegistrationTabObjects(ApplicationUnderTest app) : base(app)
        {
            _app = app;
        }

        protected WinWindow NewRegistrationWindow
		{
			get
			{
                if (_newRegistrationWindow == null)
				{
					_newRegistrationWindow = new WinWindow();
					_newRegistrationWindow.SearchProperties[WinWindow.PropertyNames.Name] = "Social Club - Membership Manager";
					_newRegistrationWindow.SearchProperties.Add(new PropertyExpression(WinWindow.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
				}
                return _newRegistrationWindow;
			}
		}

		protected WinTabPage NewRegistrationTab
		{
			get
			{
				if (_newRegistrationTab == null)
				{
					_newRegistrationTab = new WinTabPage(NewRegistrationWindow);
					_newRegistrationTab.SearchProperties[WinTabPage.PropertyNames.Name] = "New Registration";
					_newRegistrationTab.WindowTitles.Add("Social Club - Membership Manager");
				}
				return _newRegistrationTab;
			}
		}

		protected WinTabPage MemberTab
		{
			get
			{
				if (_newMemberTab == null)
				{
					_newMemberTab = new WinTabPage(NewRegistrationWindow);
					_newMemberTab.SearchProperties[WinTabPage.PropertyNames.Name] = "Member";
					_newMemberTab.WindowTitles.Add("Social Club - Membership Manager");
				}
				return _newMemberTab;
			}
		}

		private WinWindow MemberWindow
		{
			get
			{
				if (_memberWindow == null)
				{
					_memberWindow = new WinWindow(NewRegistrationWindow);
					_memberWindow.SearchProperties[WinWindow.PropertyNames.Name] = "Member";
					_memberWindow.WindowTitles.Add("Social Club - Membership Manager");
				}
				return _memberWindow;
			}
		}

		protected WinEdit NameFld
		{
			get
			{
				if (_nameFld == null)
				{
					_nameFld = new WinEdit(MemberWindow);
					_nameFld.SearchProperties[WinEdit.PropertyNames.Name] = "Date of birth";
					_nameFld.WindowTitles.Add("Social Club - Membership Manager");
				}
				return _nameFld;
			}
		}

		private WinWindow OccupationWindow
		{
			get
			{
				if (_occupationWindow == null)
				{
					_occupationWindow = new WinWindow(MemberWindow);
					_occupationWindow.SearchProperties[WinWindow.PropertyNames.ControlName] = "cmbOccupation";
					_occupationWindow.WindowTitles.Add("Social Club - Membership Manager");
				}
				return _occupationWindow;
			}
		}

		protected WinComboBox OccupationDropdown
		{
			get
			{
				if (_occupationDropdown == null)
				{
					_occupationDropdown = new WinComboBox(OccupationWindow);
					_occupationDropdown.WindowTitles.Add("Social Club - Membership Manager");
				}
				return _occupationDropdown;
			}
		}

		private WinWindow SalaryWindow
		{
			get
			{
				if (_salaryWindow == null)
				{
					_salaryWindow = new WinWindow(MemberWindow);
					_salaryWindow.SearchProperties[WinWindow.PropertyNames.ControlName] = "txtSalary";
					_salaryWindow.WindowTitles.Add("Social Club - Membership Manager");
				}
				return _salaryWindow;
			}
		}

		protected WinEdit SalaryFld
		{
			get
			{
				if (_salaryFld == null)
				{
					_salaryFld = new WinEdit(SalaryWindow);
					_salaryFld.WindowTitles.Add("Social Club - Membership Manager");
				}
				return _salaryFld;
			}
		}

		protected WinComboBox MaritalStatusDropdown
		{
			get
			{
				if (_maritalStatusDropdown == null)
				{
					_maritalStatusDropdown = new WinComboBox(MemberWindow);
					_maritalStatusDropdown.SearchProperties[WinComboBox.PropertyNames.Name] = "Occupation";
					_maritalStatusDropdown.WindowTitles.Add("Social Club - Membership Manager");
				}
				return _maritalStatusDropdown;
			}
		}

		protected WinComboBox HealthStatusDropdown
		{
			get
			{
				if (_healthStatusDropdown == null)
				{
					_healthStatusDropdown = new WinComboBox(MemberWindow);
					_healthStatusDropdown.SearchProperties[WinComboBox.PropertyNames.Name] = "Marital status";
					_healthStatusDropdown.WindowTitles.Add("Social Club - Membership Manager");
				}
				return _healthStatusDropdown;
			}
		}

		private WinWindow NoOfChildrenWindow
		{
			get
			{
				if (_noOfChildrenWindow == null)
				{
					_noOfChildrenWindow = new WinWindow(MemberWindow);
					_noOfChildrenWindow.SearchProperties[WinWindow.PropertyNames.ControlName] = "txtNoOfChildren";
					_noOfChildrenWindow.WindowTitles.Add("Social Club - Membership Manager");
				}
				return _noOfChildrenWindow;
			}
		}

		protected WinEdit NoOfChildrenFld
		{
			get
			{
				if (_noOfChildrenFld == null)
				{
					_noOfChildrenFld = new WinEdit(NoOfChildrenWindow);
					_noOfChildrenFld.WindowTitles.Add("Social Club - Membership Manager");
				}
				return _noOfChildrenFld;
			}
		}

		protected WinButton RegisterBttn
		{
			get
			{
				if (_registerButton == null)
				{
					_registerButton = new WinButton(MemberWindow);
					_registerButton.SearchProperties[WinButton.PropertyNames.Name] = "Register";
					_registerButton.WindowTitles.Add("Social Club - Membership Manager");
				}
				return _registerButton;
			}
		}

		private WinWindow RegistrationSuccessfullWindow
		{
			get
			{
				if (_registrationSuccessfulWindow == null)
				{
					_registrationSuccessfulWindow = new WinWindow();
					_registrationSuccessfulWindow.SearchProperties[WinWindow.PropertyNames.Name] = "Registration Successful";
					_registrationSuccessfulWindow.WindowTitles.Add("Registration Successful");
				}
				return _registrationSuccessfulWindow;
			}
		}

		protected WinText RegisterStatusMessage
		{
			get
			{
				if (_registerStatusMessage == null)
				{
					_registerStatusMessage = new WinText(RegistrationSuccessfullWindow);
					_registerStatusMessage.WindowTitles.Add("Registration Successful");
				}
				return _registerStatusMessage;
			}
		}

		protected WinButton CloseRegistrationStatusBttn
		{
			get
			{
				if (_closeRegistrationStatusBttn == null)
				{
					_closeRegistrationStatusBttn = new WinButton(RegistrationSuccessfullWindow);
					_closeRegistrationStatusBttn.SearchProperties[WinButton.PropertyNames.Name] = "OK";
					_closeRegistrationStatusBttn.WindowTitles.Add("Registration Successful");
				}
				return _closeRegistrationStatusBttn;
			}
		}


        /// <summary>
        /// Search Manage Members tab
        /// </summary>
        protected WinTabPage NewSearchManageTab
        {
            get
            {
                if (_newSearchManageTab == null)
                {
                    _newSearchManageTab = new WinTabPage(NewRegistrationWindow);
                    _newSearchManageTab.SearchProperties[WinTabPage.PropertyNames.Name] = "Search / Manage Members";
                    _newSearchManageTab.WindowTitles.Add("Social Club - Membership Manager");
                }
                return _newSearchManageTab;
            }
        }

        protected WinTabPage TabSearch
        {
            get
            {
                if (_newMemberTab == null)
                {
                    _newMemberTab = new WinTabPage(NewRegistrationWindow);
                    _newMemberTab.SearchProperties[WinTabPage.PropertyNames.Name] = "Search";
                    _newMemberTab.WindowTitles.Add("Social Club - Membership Manager");
                }
                return _newMemberTab;
            }
        }


        private WinWindow SearchWindow
        {
            get
            {
                if (_searchWindow == null)
                {
                    _searchWindow = new WinWindow(NewRegistrationWindow);
                    _searchWindow.SearchProperties[WinWindow.PropertyNames.Name] = "Search";
                    _searchWindow.WindowTitles.Add("Social Club - Membership Manager");
                }
                return _searchWindow;
            }
        }


        protected WinButton PrintPreviewBttn
        {
            get
            {
                if (_printPreviewBttn == null)
                {
                    _printPreviewBttn = new WinButton(NewRegistrationWindow);
                    _printPreviewBttn.SearchProperties[WinButton.PropertyNames.Name] = "Print preview";
                    _printPreviewBttn.WindowTitles.Add("Social Club - Membership Manager");
                }
                return _printPreviewBttn;
            }
        }

        protected WinWindow NewPrintPreviewWindow
        {
            get
            {
                if (_newPrintPreviewWindow == null)
                {
                    _newPrintPreviewWindow = new WinWindow();
                    _newPrintPreviewWindow.SearchProperties[WinWindow.PropertyNames.Name] = "Print preview";
                   
                }
                return _newPrintPreviewWindow;
            }
        }



        private WinWindow OccupationSearchWindow
        {
            get
            {
                if (_occupationSearchWindow == null)
                {
                    _occupationSearchWindow = new WinWindow(SearchWindow);
                    _occupationSearchWindow.SearchProperties[WinWindow.PropertyNames.ControlName] = "cmbSearchOccupation";
                    _occupationSearchWindow.WindowTitles.Add("Social Club - Membership Manager");
                }
                return _occupationSearchWindow;
            }
        }

        protected WinComboBox OccupationSearchDropdown
        {
            get
            {
                if (_occupationSearchDropdown == null)
                {
                    _occupationSearchDropdown = new WinComboBox(OccupationSearchWindow);
                    _occupationSearchDropdown.WindowTitles.Add("Social Club - Membership Manager");
                }
                return _occupationSearchDropdown;
            }
        }


        private WinWindow MaritalSearchWindow
        {
            get
            {
                if (_maritalSearchWindow == null)
                {
                    _maritalSearchWindow = new WinWindow(SearchWindow);
                    _maritalSearchWindow.SearchProperties[WinWindow.PropertyNames.ControlName] = "cmbSearchMaritalStatus";
                    _maritalSearchWindow.WindowTitles.Add("Social Club - Membership Manager");
                }
                return _maritalSearchWindow;
            }
        }

        protected WinComboBox MaritalSearchStatusDropdown
        {
            get
            {
                if (_maritalSearchStatusDropdown == null)
                {
                    _maritalSearchStatusDropdown = new WinComboBox(MaritalSearchWindow);
                    _maritalSearchStatusDropdown.SearchProperties[WinComboBox.PropertyNames.Name] = "Marital status";
                    _maritalSearchStatusDropdown.WindowTitles.Add("Social Club - Membership Manager");
                }
                return _maritalSearchStatusDropdown;
            }
        }

        protected WinButton SearchBttn
        {
            get
            {
                if (_searchBttn == null)
                {
                    _searchBttn = new WinButton(SearchWindow);
                    _searchBttn.SearchProperties[WinButton.PropertyNames.Name] = "Search";
                    _searchBttn.WindowTitles.Add("Social Club - Membership Manager");
                }
                return _searchBttn;
            }
        }


        protected WinWindow ResultTableWindow
        {
            get
            {
                if (_resultTableWindow == null)
                {
                    _resultTableWindow = new WinWindow(NewRegistrationWindow);
                    _resultTableWindow.SearchProperties[WinWindow.PropertyNames.ControlName] = "dataGridViewMembers";
                    _resultTableWindow.WindowTitles.Add("Social Club - Membership Manager");
                }
                return _resultTableWindow;
            }
        }

        protected WinTable TableControl
        {
            get
            {
                if (_tableControl == null)
                {
                    _tableControl = new WinTable(ResultTableWindow);
                    _tableControl.SearchProperties[WinTable.PropertyNames.Name] = "DataGridView";
                    _tableControl.WindowTitles.Add("Social Club - Membership Manager");
                }
                return _tableControl;
            }
        }

		private WinWindow UpdateWindow
		{
			get
			{
				if (_updateWindow == null)
				{
					_updateWindow = new WinWindow(SearchWindow);
					_updateWindow.SearchProperties[WinButton.PropertyNames.Name] = "Update";
					_updateWindow.WindowTitles.Add("Social Club - Membership Manager");
				}
				return _updateWindow;
			}
		}

		protected WinButton UpdateBttn
		{
			get
			{
				if (_updateBttn == null)
				{
					_updateBttn = new WinButton(UpdateWindow);
					_updateBttn.SearchProperties[WinButton.PropertyNames.Name] = "Update";
					_updateBttn.WindowTitles.Add("Social Club - Membership Manager");
				}
				return _updateBttn;
			}
		}



		private WinWindow UpdateSuccessfullPopUpForm
		{
			get
			{
				if (_updateSuccessfullPopUpForm == null)
				{
					_updateSuccessfullPopUpForm = new WinWindow();
					_updateSuccessfullPopUpForm.SearchProperties[WinWindow.PropertyNames.Name] = "Update successfull";
					_updateSuccessfullPopUpForm.WindowTitles.Add("Update successfull");
				}
				return _updateSuccessfullPopUpForm;
			}
		}

		protected WinText UpdateSuccessfullPopUpMessage
		{
			get
			{
				if (_updateSuccessfullPopUpMessage == null)
				{
					_updateSuccessfullPopUpMessage = new WinText(UpdateSuccessfullPopUpForm);

					_updateSuccessfullPopUpMessage.SearchProperties[WinText.PropertyNames.Name] = "Member details updated successfully";
					_updateSuccessfullPopUpMessage.WindowTitles.Add("Update successfull");
				}
				return _updateSuccessfullPopUpMessage;
			}
		}

		protected WinButton CloseUpdateMessageBttn
		{
			get
			{
				if (_closeUpdateMessageBttn == null)
				{
					_closeUpdateMessageBttn = new WinButton(UpdateSuccessfullPopUpForm);
					_closeUpdateMessageBttn.SearchProperties[WinButton.PropertyNames.Name] = "OK";
					_closeUpdateMessageBttn.WindowTitles.Add("Update successfull");
				}
				return _closeUpdateMessageBttn;
			}
		}

        //protected UITestControl StrategicAccountsWindowTableWnd
        //{
        //    get
        //    {
        //        return _strategyTableWnd ?? (_strategyTableWnd = UITestControl.Desktop.Find<WinWindow>(new { ControlName = "dbgDetails" }));
        //    }
        //}

        #region Private Variables
        private WinWindow _newRegistrationWindow;
		private WinTabPage _newRegistrationTab;
		private WinTabPage _newMemberTab;
		private WinWindow _memberWindow;
		private WinEdit _nameFld;
		private WinWindow _occupationWindow;
		private WinComboBox _occupationDropdown;
		private WinWindow _salaryWindow;
		private WinEdit _salaryFld;
		private WinComboBox _maritalStatusDropdown;
		private WinComboBox _healthStatusDropdown;
		private WinWindow _noOfChildrenWindow;
		private WinEdit _noOfChildrenFld;
		private WinButton _registerButton;
		private WinWindow _registrationSuccessfulWindow;
		private WinText _registerStatusMessage;
		private WinButton _closeRegistrationStatusBttn;
        private WinTabPage _newSearchManageTab;
        private WinButton _printPreviewBttn;
        private WinWindow _newPrintPreviewWindow;
        private WinWindow _searchWindow;
        private WinWindow _occupationSearchWindow;
        private WinComboBox _occupationSearchDropdown;
        private WinComboBox _maritalSearchStatusDropdown;
        private WinWindow _maritalSearchWindow;
        private WinButton _searchBttn;
        private WinWindow _resultTableWindow;
        private WinTable _tableControl;
		private WinWindow _updateWindow;
		private WinButton _updateBttn;
		private WinWindow _updateSuccessfullPopUpForm;
		private WinText _updateSuccessfullPopUpMessage;
		private WinButton _closeUpdateMessageBttn;
        #endregion Private Variables

    }
}