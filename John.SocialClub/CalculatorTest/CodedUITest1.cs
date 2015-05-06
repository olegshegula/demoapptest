using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace CalculatorTest
{
    /// <summary>
    /// Summary description for CodedUITest1
    /// </summary>
    [CodedUITest]
    public class CalculatorTests
    {
        private ApplicationUnderTest _app;
        [TestMethod]
        public void Test1()
        {
            //run application
            ApplicationUnderTest _app = ApplicationUnderTest.Launch("C:\\Windows\\System32\\calc.exe", "%windir%\\System32\\calc.exe");
            WinWindow calWindow = new WinWindow();
            calWindow.SearchProperties[WinWindow.PropertyNames.Name] = "Calculator";
            calWindow.SetFocus();

            WinButton button1 = new WinButton(calWindow);
            WinButton addButton = new WinButton(calWindow);
            WinButton equalsBttn = new WinButton(calWindow);
            WinText txtResult = new WinText(calWindow);
            
            //search elements
            button1.SearchProperties[WinButton.PropertyNames.Name] = "1";
            addButton.SearchProperties[WinButton.PropertyNames.Name] = "Add";
            equalsBttn.SearchProperties[WinButton.PropertyNames.Name] = "Equals";
            txtResult.SearchProperties[WinText.PropertyNames.Name] = "Result";

            Mouse.Click(button1);
            Mouse.Click(addButton);
            Mouse.Click(button1);
            Mouse.Click(equalsBttn);

            //evaluate the results
            Assert.AreEqual("2", txtResult.DisplayText);

            //close application
            _app.Close();
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
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
           
        //}

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
