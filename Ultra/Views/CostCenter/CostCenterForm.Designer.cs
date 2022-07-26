
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
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.PanelSearch = new DevExpress.Utils.Layout.StackPanel();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.SearchControlCostCenters = new DevExpress.XtraEditors.SearchControl();
            this.PanelHeader = new DevExpress.Utils.Layout.StackPanel();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.PanelMain)).BeginInit();
            this.SidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PanelSearch)).BeginInit();
            this.PanelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchControlCostCenters.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelHeader)).BeginInit();
            this.PanelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelMain
            // 
            resources.ApplyResources(this.PanelMain, "PanelMain");
            this.PanelMain.Name = "PanelMain";
            // 
            // SidePanel
            // 
            resources.ApplyResources(this.SidePanel, "SidePanel");
            this.SidePanel.Controls.Add(this.treeList1);
            this.SidePanel.Controls.Add(this.panelControl2);
            this.SidePanel.Name = "SidePanel";
            // 
            // treeList1
            // 
            resources.ApplyResources(this.treeList1, "treeList1");
            this.treeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn1});
            this.treeList1.Name = "treeList1";
            this.treeList1.BeginUnboundLoad();
            this.treeList1.AppendNode(new object[] {
            "1 - Main Cost Center"}, -1);
            this.treeList1.AppendNode(new object[] {
            "101 - Sub Cost Center"}, 0);
            this.treeList1.EndUnboundLoad();
            this.treeList1.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.treeList1_FocusedNodeChanged_1);
            // 
            // treeListColumn1
            // 
            resources.ApplyResources(this.treeListColumn1, "treeListColumn1");
            this.treeListColumn1.FieldName = "treeListColumn1";
            this.treeListColumn1.Name = "treeListColumn1";
            // 
            // panelControl2
            // 
            resources.ApplyResources(this.panelControl2, "panelControl2");
            this.panelControl2.Controls.Add(this.PanelSearch);
            this.panelControl2.Controls.Add(this.PanelHeader);
            this.panelControl2.Name = "panelControl2";
            // 
            // PanelSearch
            // 
            resources.ApplyResources(this.PanelSearch, "PanelSearch");
            this.PanelSearch.Controls.Add(this.simpleButton1);
            this.PanelSearch.Controls.Add(this.SearchControlCostCenters);
            this.PanelSearch.Name = "PanelSearch";
            // 
            // simpleButton1
            // 
            resources.ApplyResources(this.simpleButton1, "simpleButton1");
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // SearchControlCostCenters
            // 
            resources.ApplyResources(this.SearchControlCostCenters, "SearchControlCostCenters");
            this.SearchControlCostCenters.Name = "SearchControlCostCenters";
            this.SearchControlCostCenters.Properties.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("SearchControlCostCenters.Properties.Appearance.Font")));
            this.SearchControlCostCenters.Properties.Appearance.Options.UseFont = true;
            this.SearchControlCostCenters.Properties.Appearance.Options.UseTextOptions = true;
            this.SearchControlCostCenters.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.SearchControlCostCenters.Properties.AutoHeight = ((bool)(resources.GetObject("SearchControlCostCenters.Properties.AutoHeight")));
            this.SearchControlCostCenters.Properties.ContextImageOptions.Alignment = DevExpress.XtraEditors.ContextImageAlignment.Far;
            this.SearchControlCostCenters.Properties.ContextImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("SearchControlCostCenters.Properties.ContextImageOptions.Image")));
            this.SearchControlCostCenters.Properties.NullValuePrompt = resources.GetString("SearchControlCostCenters.Properties.NullValuePrompt");
            this.SearchControlCostCenters.Properties.ShowClearButton = false;
            this.SearchControlCostCenters.Properties.ShowSearchButton = false;
            // 
            // PanelHeader
            // 
            resources.ApplyResources(this.PanelHeader, "PanelHeader");
            this.PanelHeader.Controls.Add(this.labelControl2);
            this.PanelHeader.Controls.Add(this.labelControl3);
            this.PanelHeader.Name = "PanelHeader";
            // 
            // labelControl2
            // 
            resources.ApplyResources(this.labelControl2, "labelControl2");
            this.labelControl2.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("labelControl2.Appearance.Font")));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("labelControl2.ImageOptions.Image")));
            this.labelControl2.Name = "labelControl2";
            // 
            // labelControl3
            // 
            resources.ApplyResources(this.labelControl3, "labelControl3");
            this.labelControl3.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("labelControl3.Appearance.Font")));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.labelControl3.ImageOptions.Alignment = System.Drawing.ContentAlignment.MiddleRight;
            this.labelControl3.Name = "labelControl3";
            // 
            // CostCenterForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PanelMain);
            this.Controls.Add(this.SidePanel);
            this.MaximizeBox = false;
            this.Name = "CostCenterForm";
            this.Load += new System.EventHandler(this.CostCenterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PanelMain)).EndInit();
            this.SidePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PanelSearch)).EndInit();
            this.PanelSearch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SearchControlCostCenters.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelHeader)).EndInit();
            this.PanelHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl PanelMain;
        private DevExpress.XtraEditors.SidePanel SidePanel;
        private DevExpress.XtraTreeList.TreeList treeList1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.Utils.Layout.StackPanel PanelSearch;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SearchControl SearchControlCostCenters;
        private DevExpress.Utils.Layout.StackPanel PanelHeader;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}