namespace TBANewVersion
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnBarK54 = new DevExpress.XtraBars.BarButtonItem();
            this.btnBarAK = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPage4 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPage5 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.panelControlExc = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlExc)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnBarK54,
            this.btnBarAK});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 3;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2,
            this.ribbonPage3,
            this.ribbonPage4,
            this.ribbonPage5});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            this.ribbonControl1.Size = new System.Drawing.Size(1590, 162);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            // 
            // btnBarK54
            // 
            this.btnBarK54.Caption = "Bài Bắn K54";
            this.btnBarK54.Id = 1;
            this.btnBarK54.LargeGlyph = global::TBANewVersion.Properties.Resources.icons8_gun_50;
            this.btnBarK54.LargeWidth = 90;
            this.btnBarK54.Name = "btnBarK54";
            this.btnBarK54.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBarK54_ItemClick);
            // 
            // btnBarAK
            // 
            this.btnBarAK.Caption = "Bài Bắn AK";
            this.btnBarAK.Id = 2;
            this.btnBarAK.LargeGlyph = global::TBANewVersion.Properties.Resources.icons8_assault_rifle_50;
            this.btnBarAK.LargeWidth = 90;
            this.btnBarAK.Name = "btnBarAK";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage1.Image")));
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "  Bài Bắn";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnBarK54);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnBarAK);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.ShowCaptionButton = false;
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage2.Image")));
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Học Viên";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage3.Image")));
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "Giáo Viên";
            // 
            // ribbonPage4
            // 
            this.ribbonPage4.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage4.Image")));
            this.ribbonPage4.Name = "ribbonPage4";
            this.ribbonPage4.Text = "Quản Lý Điểm";
            // 
            // ribbonPage5
            // 
            this.ribbonPage5.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage5.Image")));
            this.ribbonPage5.Name = "ribbonPage5";
            this.ribbonPage5.Text = "Thống Kê";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 864);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(1590, 31);
            // 
            // panelControlExc
            // 
            this.panelControlExc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControlExc.Location = new System.Drawing.Point(0, 162);
            this.panelControlExc.Name = "panelControlExc";
            this.panelControlExc.Size = new System.Drawing.Size(1590, 702);
            this.panelControlExc.TabIndex = 2;
            // 
            // frmMain
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1590, 895);
            this.Controls.Add(this.panelControlExc);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "Phần mềm quản lý hệ thống huấn luyện bắn súng bộ binh";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlExc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage4;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage5;
        private DevExpress.XtraBars.BarButtonItem btnBarK54;
        private DevExpress.XtraBars.BarButtonItem btnBarAK;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraEditors.PanelControl panelControlExc;
    }
}

