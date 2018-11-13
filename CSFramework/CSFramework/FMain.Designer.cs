namespace CSFramework
{
    partial class fMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ribbonMain = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonGroup2 = new DevExpress.XtraBars.BarButtonGroup();
            this.barBtnQuery1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnItemAccount = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnPermission = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnReport = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.rbPageManager = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbPageSetting = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupSetting = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbPageReport = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupReports = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.dlaFeel = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.panelBody = new System.Windows.Forms.Panel();
            this.panelReport = new System.Windows.Forms.Panel();
            this.panelSetting = new System.Windows.Forms.Panel();
            this.panelManager = new System.Windows.Forms.Panel();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonMain)).BeginInit();
            this.panelBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonMain
            // 
            this.ribbonMain.ApplicationButtonText = null;
            this.ribbonMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.ribbonMain.ExpandCollapseItem.Id = 0;
            this.ribbonMain.ExpandCollapseItem.Name = "";
            this.ribbonMain.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonMain.ExpandCollapseItem,
            this.barButtonGroup2,
            this.barBtnQuery1,
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButtonItem4,
            this.barButtonItem5,
            this.barButtonItem6,
            this.barBtnItemAccount,
            this.barBtnPermission,
            this.barBtnReport,
            this.barButtonItem7});
            this.ribbonMain.Location = new System.Drawing.Point(0, 0);
            this.ribbonMain.Margin = new System.Windows.Forms.Padding(2);
            this.ribbonMain.MaxItemId = 14;
            this.ribbonMain.Name = "ribbonMain";
            this.ribbonMain.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rbPageManager,
            this.rbPageSetting,
            this.rbPageReport});
            this.ribbonMain.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            this.ribbonMain.SelectedPage = this.rbPageManager;
            this.ribbonMain.Size = new System.Drawing.Size(797, 153);
            this.ribbonMain.SelectedPageChanged += new System.EventHandler(this.ribbonMain_SelectedPageChanged);
            // 
            // barButtonGroup2
            // 
            this.barButtonGroup2.Caption = "barButtonGroup2";
            this.barButtonGroup2.Id = 2;
            this.barButtonGroup2.Name = "barButtonGroup2";
            // 
            // barBtnQuery1
            // 
            this.barBtnQuery1.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
            this.barBtnQuery1.Caption = "钻具信息";
            this.barBtnQuery1.Id = 3;
            this.barBtnQuery1.LargeGlyph = global::CSFramework.Properties.Resources.AccountSummary_32_unchecked;
            this.barBtnQuery1.Name = "barBtnQuery1";
            this.barBtnQuery1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtnQuery1.Tag = "QueryPage1Key";
            this.barBtnQuery1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "打捞工具   ";
            this.barButtonItem1.Id = 4;
            this.barButtonItem1.LargeGlyph = global::CSFramework.Properties.Resources.AccountSummary_32_unchecked;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonItem1.Tag = "QueryPage2Key";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "钻具检验    ";
            this.barButtonItem2.Id = 5;
            this.barButtonItem2.LargeGlyph = global::CSFramework.Properties.Resources.AccountSummary_32_unchecked;
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonItem2.Tag = "ReportPage1Key";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "出入库信息";
            this.barButtonItem3.Id = 6;
            this.barButtonItem3.LargeGlyph = global::CSFramework.Properties.Resources.AccountSummary_32_unchecked;
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "  钻具保养  ";
            this.barButtonItem4.Id = 7;
            this.barButtonItem4.LargeGlyph = global::CSFramework.Properties.Resources.AccountSummary_32_unchecked;
            this.barButtonItem4.Name = "barButtonItem4";
            this.barButtonItem4.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "  钻具维修";
            this.barButtonItem5.Id = 8;
            this.barButtonItem5.LargeGlyph = global::CSFramework.Properties.Resources.AccountSummary_32_unchecked;
            this.barButtonItem5.Name = "barButtonItem5";
            this.barButtonItem5.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "  钻具报废";
            this.barButtonItem6.Id = 9;
            this.barButtonItem6.LargeGlyph = global::CSFramework.Properties.Resources.AccountSummary_32_unchecked;
            this.barButtonItem6.Name = "barButtonItem6";
            this.barButtonItem6.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barBtnItemAccount
            // 
            this.barBtnItemAccount.Caption = "用户设置";
            this.barBtnItemAccount.Id = 10;
            this.barBtnItemAccount.LargeGlyph = global::CSFramework.Properties.Resources.Ribbon_UserManagement;
            this.barBtnItemAccount.Name = "barBtnItemAccount";
            this.barBtnItemAccount.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtnItemAccount.Tag = "AccountSetting";
            this.barBtnItemAccount.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_ItemClick);
            // 
            // barBtnPermission
            // 
            this.barBtnPermission.Caption = "权限设置";
            this.barBtnPermission.Id = 11;
            this.barBtnPermission.LargeGlyph = global::CSFramework.Properties.Resources.Ribbon_Set;
            this.barBtnPermission.Name = "barBtnPermission";
            this.barBtnPermission.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtnPermission.Tag = "PermissionSetting";
            this.barBtnPermission.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_ItemClick);
            // 
            // barBtnReport
            // 
            this.barBtnReport.Caption = "报表样本一";
            this.barBtnReport.Id = 12;
            this.barBtnReport.LargeGlyph = global::CSFramework.Properties.Resources.ConvPath_32_unchecked;
            this.barBtnReport.Name = "barBtnReport";
            this.barBtnReport.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtnReport.Tag = "ReportDemo1";
            this.barBtnReport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_ItemClick);
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Caption = "报表样本二";
            this.barButtonItem7.Id = 13;
            this.barButtonItem7.LargeGlyph = global::CSFramework.Properties.Resources.ConvPath_32_unchecked;
            this.barButtonItem7.Name = "barButtonItem7";
            this.barButtonItem7.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonItem7.Tag = "ReportDemo2";
            this.barButtonItem7.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_ItemClick);
            // 
            // rbPageManager
            // 
            this.rbPageManager.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.rbPageManager.Name = "rbPageManager";
            this.rbPageManager.Text = "  钻具管理  ";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barBtnQuery1);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem3);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem4);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem5);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem6);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "钻具管理";
            // 
            // rbPageSetting
            // 
            this.rbPageSetting.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroupSetting});
            this.rbPageSetting.Name = "rbPageSetting";
            this.rbPageSetting.Text = "      设 置      ";
            // 
            // ribbonPageGroupSetting
            // 
            this.ribbonPageGroupSetting.ItemLinks.Add(this.barBtnItemAccount);
            this.ribbonPageGroupSetting.ItemLinks.Add(this.barBtnPermission);
            this.ribbonPageGroupSetting.Name = "ribbonPageGroupSetting";
            this.ribbonPageGroupSetting.Text = "用户设置";
            // 
            // rbPageReport
            // 
            this.rbPageReport.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroupReports});
            this.rbPageReport.Name = "rbPageReport";
            this.rbPageReport.Text = "     报 表      ";
            // 
            // ribbonPageGroupReports
            // 
            this.ribbonPageGroupReports.ItemLinks.Add(this.barBtnReport);
            this.ribbonPageGroupReports.ItemLinks.Add(this.barButtonItem7);
            this.ribbonPageGroupReports.Name = "ribbonPageGroupReports";
            this.ribbonPageGroupReports.Text = "报表";
            // 
            // dlaFeel
            // 
            this.dlaFeel.LookAndFeel.SkinName = "Blue";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowMinimize = false;
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // panelBody
            // 
            this.panelBody.Controls.Add(this.panelReport);
            this.panelBody.Controls.Add(this.panelSetting);
            this.panelBody.Controls.Add(this.panelManager);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(0, 153);
            this.panelBody.Margin = new System.Windows.Forms.Padding(2);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(797, 271);
            this.panelBody.TabIndex = 2;
            // 
            // panelReport
            // 
            this.panelReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.panelReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelReport.Location = new System.Drawing.Point(0, 0);
            this.panelReport.Margin = new System.Windows.Forms.Padding(2);
            this.panelReport.Name = "panelReport";
            this.panelReport.Size = new System.Drawing.Size(797, 271);
            this.panelReport.TabIndex = 2;
            // 
            // panelSetting
            // 
            this.panelSetting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.panelSetting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSetting.Location = new System.Drawing.Point(0, 0);
            this.panelSetting.Margin = new System.Windows.Forms.Padding(2);
            this.panelSetting.Name = "panelSetting";
            this.panelSetting.Size = new System.Drawing.Size(797, 271);
            this.panelSetting.TabIndex = 1;
            // 
            // panelManager
            // 
            this.panelManager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.panelManager.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelManager.Location = new System.Drawing.Point(0, 0);
            this.panelManager.Margin = new System.Windows.Forms.Padding(2);
            this.panelManager.Name = "panelManager";
            this.panelManager.Size = new System.Drawing.Size(797, 271);
            this.panelManager.TabIndex = 0;
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.barBtnQuery1);
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem3);
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem4);
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem5);
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem6);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "钻具管理";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.barBtnQuery1);
            this.ribbonPageGroup4.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup4.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroup4.ItemLinks.Add(this.barButtonItem3);
            this.ribbonPageGroup4.ItemLinks.Add(this.barButtonItem4);
            this.ribbonPageGroup4.ItemLinks.Add(this.barButtonItem5);
            this.ribbonPageGroup4.ItemLinks.Add(this.barButtonItem6);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "钻具管理";
            // 
            // fMain
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 424);
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.ribbonMain);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "fMain";
            this.Ribbon = this.ribbonMain;
            this.Text = "钻井信息作业系统";
            this.Load += new System.EventHandler(this.fMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonMain)).EndInit();
            this.panelBody.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonMain;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbPageManager;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbPageSetting;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbPageReport;
        private System.Windows.Forms.Panel panelBody;
        private DevExpress.XtraBars.BarButtonGroup barButtonGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem barBtnQuery1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.LookAndFeel.DefaultLookAndFeel dlaFeel;
        private DevExpress.XtraBars.BarButtonItem barBtnItemAccount;
        private DevExpress.XtraBars.BarButtonItem barBtnPermission;
        private DevExpress.XtraBars.BarButtonItem barBtnReport;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupSetting;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupReports;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private System.Windows.Forms.Panel panelReport;
        private System.Windows.Forms.Panel panelSetting;
        private System.Windows.Forms.Panel panelManager;
    }
}

