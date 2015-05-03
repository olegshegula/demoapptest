using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace Automation.Library.Common
{
    class Tools
    {
      
            public static void Click(UITestControl control)
            {
                var tm = new Timeout();
                control.WaitForControlExist(tm.WaitForControl);
                Mouse.Click(control);
            }

            public static void DoubleClick(UITestControl control)
            {
                var tm = new Timeout();
                control.WaitForControlExist(tm.WaitForControl);
                Mouse.DoubleClick(control);
            }

            public static void SendKeys(UITestControl control, string text)
            {
                var tm = new Timeout();
                control.WaitForControlExist(tm.WaitForControl);
                Keyboard.SendKeys(control, text);
            }

            public static void SetDropdownValue(WinComboBox control, string value)
            {
                var tm = new Timeout();
                control.WaitForControlExist(tm.WaitForControl);
                control.SelectedItem = value;
            }

            public static void WaitControlExists(UITestControl control)
            {
                var tm = new Timeout();
                control.WaitForControlExist(tm.WaitForControl);
            }
        }
    }

