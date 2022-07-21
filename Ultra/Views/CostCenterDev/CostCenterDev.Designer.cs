
namespace Ultra.Views.CostCenterDev
{
    partial class CostCenterDev
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CostCenterDev));
            this.LabelHeaderChart = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.ButtonNewAccount = new DevExpress.XtraEditors.SimpleButton();
            this.TextSearch = new DevExpress.XtraEditors.SearchControl();
            this.panelControlMain = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextSearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlMain)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelHeaderChart
            // 
            this.LabelHeaderChart.Appearance.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHeaderChart.Appearance.Options.UseFont = true;
            this.LabelHeaderChart.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.LabelHeaderChart.Dock = System.Windows.Forms.DockStyle.Top;
            this.LabelHeaderChart.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.LabelHeaderChart.ImageOptions.Alignment = System.Drawing.ContentAlignment.MiddleRight;
            this.LabelHeaderChart.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("LabelHeaderChart.ImageOptions.Image")));
            this.LabelHeaderChart.Location = new System.Drawing.Point(0, 0);
            this.LabelHeaderChart.Name = "LabelHeaderChart";
            this.LabelHeaderChart.Size = new System.Drawing.Size(962, 56);
            this.LabelHeaderChart.TabIndex = 1;
            this.LabelHeaderChart.Text = "دليل مراكز الكلفة";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.treeList1);
            this.panelControl1.Controls.Add(this.panelControl3);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(0, 56);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(319, 616);
            this.panelControl1.TabIndex = 3;
            // 
            // treeList1
            // 
            this.treeList1.Appearance.BandPanel.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.treeList1.Appearance.BandPanel.Options.UseFont = true;
            this.treeList1.AppearancePrint.BandPanel.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.treeList1.AppearancePrint.BandPanel.Options.UseFont = true;
            this.treeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn1});
            this.treeList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeList1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.treeList1.Location = new System.Drawing.Point(2, 64);
            this.treeList1.Name = "treeList1";
            this.treeList1.BeginUnboundLoad();
            this.treeList1.AppendNode(new object[] {
            "مركز كلفة رئيسي"}, -1);
            this.treeList1.AppendNode(new object[] {
            "مركز كلفة فرعي"}, 0);
            this.treeList1.EndUnboundLoad();
            this.treeList1.OptionsBehavior.PopulateServiceColumns = true;
            this.treeList1.Size = new System.Drawing.Size(315, 550);
            this.treeList1.TabIndex = 4;
            this.treeList1.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.treeList1_FocusedNodeChanged);
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.Visible = true;
            this.treeListColumn1.VisibleIndex = 0;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.ButtonNewAccount);
            this.panelControl3.Controls.Add(this.TextSearch);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl3.Location = new System.Drawing.Point(2, 2);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(315, 62);
            this.panelControl3.TabIndex = 5;
            // 
            // ButtonNewAccount
            // 
            this.ButtonNewAccount.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ButtonNewAccount.ImageOptions.Image")));
            this.ButtonNewAccount.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.ButtonNewAccount.Location = new System.Drawing.Point(263, 11);
            this.ButtonNewAccount.Name = "ButtonNewAccount";
            this.ButtonNewAccount.Size = new System.Drawing.Size(46, 40);
            this.ButtonNewAccount.TabIndex = 3;
            // 
            // TextSearch
            // 
            this.TextSearch.EditValue = "";
            this.TextSearch.Location = new System.Drawing.Point(6, 12);
            this.TextSearch.Name = "TextSearch";
            this.TextSearch.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextSearch.Properties.Appearance.Options.UseFont = true;
            this.TextSearch.Properties.AutoHeight = false;
            this.TextSearch.Properties.ContextImageOptions.Alignment = DevExpress.XtraEditors.ContextImageAlignment.Far;
            this.TextSearch.Properties.ContextImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("TextSearch.Properties.ContextImageOptions.Image")));
            this.TextSearch.Properties.NullValuePrompt = "بحث .....";
            this.TextSearch.Properties.ShowClearButton = false;
            this.TextSearch.Properties.ShowSearchButton = false;
            this.TextSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TextSearch.Size = new System.Drawing.Size(251, 40);
            this.TextSearch.TabIndex = 4;
            // 
            // panelControlMain
            // 
            this.panelControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControlMain.Location = new System.Drawing.Point(319, 56);
            this.panelControlMain.Name = "panelControlMain";
            this.panelControlMain.Size = new System.Drawing.Size(643, 616);
            this.panelControlMain.TabIndex = 5;
            // 
            // CostCenterDev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 672);
            this.Controls.Add(this.panelControlMain);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.LabelHeaderChart);
            this.Name = "CostCenterDev";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CostCenterDev";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TextSearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl LabelHeaderChart;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraTreeList.TreeList treeList1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
        private DevExpress.XtraEditors.PanelControl panelControlMain;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.SimpleButton ButtonNewAccount;
        private DevExpress.XtraEditors.SearchControl TextSearch;
    }
}