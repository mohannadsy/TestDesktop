
namespace Ultra.Views.CostCenter
{
    partial class CostCenterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CostCenterForm));
            this.PanelMain = new DevExpress.XtraEditors.PanelControl();
            this.SidePanel = new DevExpress.XtraEditors.SidePanel();
            this.treeListCostCenters = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.PanelSearch = new DevExpress.Utils.Layout.StackPanel();
            this.buttonNew = new DevExpress.XtraEditors.SimpleButton();
            this.searchCostCenter = new DevExpress.XtraEditors.SearchControl();
            this.PanelHeader = new DevExpress.Utils.Layout.StackPanel();
            this.labelHeaderImage = new DevExpress.XtraEditors.LabelControl();
            this.labelHeaderTitle = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.PanelMain)).BeginInit();
            this.SidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeListCostCenters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PanelSearch)).BeginInit();
            this.PanelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchCostCenter.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelHeader)).BeginInit();
            this.PanelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelMain
            // 
            this.PanelMain.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            resources.ApplyResources(this.PanelMain, "PanelMain");
            this.PanelMain.Name = "PanelMain";
            // 
            // SidePanel
            // 
            this.SidePanel.Controls.Add(this.treeListCostCenters);
            this.SidePanel.Controls.Add(this.panelControl2);
            resources.ApplyResources(this.SidePanel, "SidePanel");
            this.SidePanel.Name = "SidePanel";
            // 
            // treeListCostCenters
            // 
            this.treeListCostCenters.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn1});
            resources.ApplyResources(this.treeListCostCenters, "treeListCostCenters");
            this.treeListCostCenters.Name = "treeListCostCenters";
            this.treeListCostCenters.BeginUnboundLoad();
            this.treeListCostCenters.AppendNode(new object[] {
            "1 - Main Cost Center"}, -1);
            this.treeListCostCenters.AppendNode(new object[] {
            "101 - Sub Cost Center"}, 0);
            this.treeListCostCenters.EndUnboundLoad();
            this.treeListCostCenters.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.treeListCostCenters_FocusedNodeChanged);
            // 
            // treeListColumn1
            // 
            resources.ApplyResources(this.treeListColumn1, "treeListColumn1");
            this.treeListColumn1.FieldName = "treeListColumn1";
            this.treeListColumn1.Name = "treeListColumn1";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.PanelSearch);
            this.panelControl2.Controls.Add(this.PanelHeader);
            resources.ApplyResources(this.panelControl2, "panelControl2");
            this.panelControl2.Name = "panelControl2";
            // 
            // PanelSearch
            // 
            this.PanelSearch.Controls.Add(this.buttonNew);
            this.PanelSearch.Controls.Add(this.searchCostCenter);
            resources.ApplyResources(this.PanelSearch, "PanelSearch");
            this.PanelSearch.Name = "PanelSearch";
            // 
            // buttonNew
            // 
            this.buttonNew.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.buttonNew.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            resources.ApplyResources(this.buttonNew, "buttonNew");
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // searchCostCenter
            // 
            resources.ApplyResources(this.searchCostCenter, "searchCostCenter");
            this.searchCostCenter.Name = "searchCostCenter";
            this.searchCostCenter.Properties.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("SearchControlCostCenters.Properties.Appearance.Font")));
            this.searchCostCenter.Properties.Appearance.Options.UseFont = true;
            this.searchCostCenter.Properties.Appearance.Options.UseTextOptions = true;
            this.searchCostCenter.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.searchCostCenter.Properties.AutoHeight = ((bool)(resources.GetObject("SearchControlCostCenters.Properties.AutoHeight")));
            this.searchCostCenter.Properties.ContextImageOptions.Alignment = DevExpress.XtraEditors.ContextImageAlignment.Far;
            this.searchCostCenter.Properties.ContextImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("SearchControlCostCenters.Properties.ContextImageOptions.Image")));
            this.searchCostCenter.Properties.NullValuePrompt = resources.GetString("SearchControlCostCenters.Properties.NullValuePrompt");
            this.searchCostCenter.Properties.ShowClearButton = false;
            this.searchCostCenter.Properties.ShowSearchButton = false;
            // 
            // PanelHeader
            // 
            this.PanelHeader.Controls.Add(this.labelHeaderImage);
            this.PanelHeader.Controls.Add(this.labelHeaderTitle);
            resources.ApplyResources(this.PanelHeader, "PanelHeader");
            this.PanelHeader.Name = "PanelHeader";
            // 
            // labelHeaderImage
            // 
            this.labelHeaderImage.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("labelControl2.Appearance.Font")));
            this.labelHeaderImage.Appearance.Options.UseFont = true;
            resources.ApplyResources(this.labelHeaderImage, "labelHeaderImage");
            this.labelHeaderImage.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("labelControl2.ImageOptions.Image")));
            this.labelHeaderImage.Name = "labelHeaderImage";
            // 
            // labelHeaderTitle
            // 
            this.labelHeaderTitle.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("labelControl3.Appearance.Font")));
            this.labelHeaderTitle.Appearance.Options.UseFont = true;
            resources.ApplyResources(this.labelHeaderTitle, "labelHeaderTitle");
            this.labelHeaderTitle.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.labelHeaderTitle.ImageOptions.Alignment = System.Drawing.ContentAlignment.MiddleRight;
            this.labelHeaderTitle.Name = "labelHeaderTitle";
            // 
            // CostCenterForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PanelMain);
            this.Controls.Add(this.SidePanel);
            this.MaximizeBox = false;
            this.Name = "CostCenterForm";
            ((System.ComponentModel.ISupportInitialize)(this.PanelMain)).EndInit();
            this.SidePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeListCostCenters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PanelSearch)).EndInit();
            this.PanelSearch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchCostCenter.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelHeader)).EndInit();
            this.PanelHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl PanelMain;
        private DevExpress.XtraEditors.SidePanel SidePanel;
        private DevExpress.XtraTreeList.TreeList treeListCostCenters;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.Utils.Layout.StackPanel PanelSearch;
        private DevExpress.XtraEditors.SimpleButton buttonNew;
        private DevExpress.XtraEditors.SearchControl searchCostCenter;
        private DevExpress.Utils.Layout.StackPanel PanelHeader;
        private DevExpress.XtraEditors.LabelControl labelHeaderImage;
        private DevExpress.XtraEditors.LabelControl labelHeaderTitle;
    }
}