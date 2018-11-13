using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using CSFramework.Common;

namespace CSFramework
{
    public partial class fMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        UCManager manager, baseQueryManager,settingManager, reportManager;

        public fMain()
        {
            InitializeComponent();
            InitUCManager();
        }

        private void InitUCManager()
        {            
            reportManager = new UCManager(this.panelReport, PageControlKey.ReportDemo1);
            settingManager = new UCManager(this.panelSetting, PageControlKey.AccountSetting);
            baseQueryManager = new UCManager(this.panelManager, PageControlKey.QueryPage1Key);
            
            manager = baseQueryManager;            
        }
       
        private void barButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            manager.ActivateControl(e.Item.Tag.ToString());
        }

        private void ribbonMain_SelectedPageChanged(object sender, EventArgs e)
        {
            PageLoad();
        }

        public void PageLoad()
        {
            if (ribbonMain.SelectedPage.PageIndex == 0)
            {
                //if (ribbonMain.SelectedPage.IsInDefaultCategory)
                //{
                //    manager = reportManager;
                //}
                //else
                //{
                    manager = baseQueryManager;
                //}
                //manager.Activate();
            }
            else if (ribbonMain.SelectedPage.PageIndex == 1)
            {
                manager = settingManager;
            }
            else
            {
                manager = reportManager;
            }
            manager.Activate();
        }

        //private const string baseDefaultKey = "QueryPage1Key";
        //private const string settingDefaultKey = "";
        //private const string reportDefaultKey = "";
        private void fMain_Load(object sender, EventArgs e)
        {
            baseQueryManager.ActivateControl(PageControlKey.QueryPage1Key);
            settingManager.ActivateControl(PageControlKey.AccountSetting );
            reportManager.ActivateControl(PageControlKey.ReportDemo1);
            ribbonMain_SelectedPageChanged(null, null);
        }

    }
}
