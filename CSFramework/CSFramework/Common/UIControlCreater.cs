using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CSFramework.Common
{
    public static class UIControlCreater
    {

        public static UserControl CreateControl(string cName)
        {
            UserControl baseControl;
            switch (cName)
            {
                #region Query control 钻具管理
                case PageControlKey.QueryPage1Key:
                    baseControl = new UIPage.ucQueryPage1();
                    break;
                case PageControlKey.QueryPage2Key:
                    baseControl = new UIPage.ucQueryPage2();
                    break;
                case PageControlKey.ReportPage1Key:
                    baseControl = new UIPage.ucReportPage1();
                    break;
                #endregion

                #region Setting Control 设置
                case PageControlKey.SettingPage1Key:
                    baseControl = new UIPage.ucSettingPage1();
                    break;
                
                case PageControlKey.AccountSetting:
                    baseControl = new UIPage.ucAccountSetting();
                    break;
                case PageControlKey.PermissionSetting :
                    baseControl = new UIPage.ucPermissionSetting();
                    break;
                #endregion

                #region Report control 报表
                case PageControlKey.ReportDemo1:
                    baseControl = new UIPage.ucReportDemo1();
                    break;
                case PageControlKey.ReportDemo2:
                    baseControl = new UIPage.ucReportDemo2();
                    break;
                #endregion

                default:
                    throw new ArgumentException("ControlName error");
            }
            return baseControl;
        }

    }

}
