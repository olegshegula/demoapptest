using CodedUITestProject.Common;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace CodedUITestProject
{
    /// <summary>
    /// Summary description for CodedUITests
    /// </summary>
    [CodedUITest]
    public class CodedUiTests : BaseTest
    {
        
	    [TestMethod, TestCategory("Test")]
        [Description("Test1: Successful login to application")]
        public void CorrectLoginTest()
	    {
            Playback.PlaybackSettings.LoggerOverrideState = HtmlLoggerState.ErrorAndWarningOnlySnapshot;
		    LunchApplication()
			    .SetFocus()
				.LoginAs("demo", "demo123")
			    .CheckIfNewRegistrationWindowExists();
        }

         [TestMethod]
         [Description("Test2: Unsuccessful login without password")]
        public void IncorrectLoginTest()
        {
            Playback.PlaybackSettings.LoggerOverrideState = HtmlLoggerState.ErrorAndWarningOnlySnapshot;
            LunchApplication()
               .SetFocus()
               .SetUserName("demo")
               .SubmitLogin()
			   .IsLoginMessageCorrect("Please enter a valid username and password.")
               .ClickOk();
        }

         [TestMethod]
         [Description("Test3: Verifies adding a new member to the club")]
         public void AddClubMemberTest()
         {
             Playback.PlaybackSettings.LoggerOverrideState = HtmlLoggerState.ErrorAndWarningOnlySnapshot;
			 LunchApplication()
				.SetFocus()
				.LoginAs("demo", "demo123")
				.OpenNewRegistrationTab()
				.OpenMemberTab()
				.EnterMemberName("test")
				.ChooseOccupation("Doctor")
				.EnterSalary("1000")
				.ChooseMaritalStatus("Single")
				.ChooseHealthStatus("Good")
				.EnterNoOfChildren("2")
				.ClickRegisterButton()
				.IsRegisterMessageCorrect("New member registered successfully!");
         }


         [TestMethod]
         [Description("Test4: Verifies search results by given Ocupation and Marital parameters")]
         public void SearchSingleDoctorTest()
         {
             Playback.PlaybackSettings.LoggerOverrideState = HtmlLoggerState.ErrorAndWarningOnlySnapshot;
             LunchApplication()
               .SetFocus()
               .LoginAs("demo", "demo123")
               .OpenNewSearchMamberTab()
               .OpenSearchTab()
               .ChooseSearchOccupation("Doctor")
               .ChooseSearchMaritalStatus("Single")
               .ClickSearch()
               .IsSearchResultCorrect();
         }

         [TestMethod]
         [Description("Test5: Verifies print preview window after Print preview button click")]
         public void PrintPreviewTest()
         {
             Playback.PlaybackSettings.LoggerOverrideState = HtmlLoggerState.ErrorAndWarningOnlySnapshot;
             LunchApplication()
               .SetFocus()
               .LoginAs("demo", "demo123")
               .OpenNewSearchMamberTab()
               .ClickPrintPreviewButton()
               .IsPrintPreviewWindowOpened();
         }

	    [TestMethod]
        [Description("Test6: Verifies that club memeber name is updated by given name parametr")]
	    public void EditUserNameTest()
	    {
            Playback.PlaybackSettings.LoggerOverrideState = HtmlLoggerState.ErrorAndWarningOnlySnapshot;
		    LunchApplication()
			    .SetFocus()
			    .LoginAs("demo", "demo123")
			    .OpenNewSearchMamberTab()
			    .OpenSearchTab()
			    .ChooseSearchOccupation("Doctor")
			    .ChooseSearchMaritalStatus("Single")
			    .ClickSearch()
			    .EnterMemberName("update test")
			    .ClickUpdateButton()
				.IsUpdateMessageCorrect("Member details updated successfully");
	    }

		[TestMethod]
        [Description("Test7: This test will fail")]
		public void EditUserNameFailedTest()
		{
            Playback.PlaybackSettings.LoggerOverrideState = HtmlLoggerState.ErrorAndWarningOnlySnapshot;
            Playback.PlaybackSettings.SearchTimeout = 100;
			LunchApplication()
				.SetFocus()
				.LoginAs("demo", "demo123")
				.OpenNewSearchMamberTab()
				.OpenSearchTab()
				.EnterSalary("1000")
				.ChooseSearchMaritalStatus("Single")
				.ClickSearch()
				.EnterMemberName("update test")
				.ClickUpdateButton()
				.IsUpdateMessageCorrect("Member details updated successfully");
		}

	    #region Additional test attributes

        // You can use the following additional attributes as you write your tests:

        ////Use TestInitialize to run code before running each test 
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //}

        ////Use TestCleanup to run code after each test has run
		 [TestCleanup()]
		 public void MyTestCleanup()
		 {
			 CloseApplication();
		 }

        #endregion

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
        private TestContext testContextInstance;
    }
}
