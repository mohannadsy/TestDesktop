
namespace Ultra.Views.Store
{
    partial class StoreForm
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("101 - المستودع الفرعي");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("1 - المستودع الرئيسي", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StoreForm));
            this.PanelSide = new System.Windows.Forms.Panel();
            this.ChartAccounts = new System.Windows.Forms.TreeView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.TextSearch = new DevExpress.XtraEditors.SearchControl();
            this.ButtonNewAccount = new DevExpress.XtraEditors.SimpleButton();
            this.LabelHeaderChart = new DevExpress.XtraEditors.LabelControl();
            this.PanelMain = new System.Windows.Forms.Panel();
            this.PanelSide.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextSearch.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelSide
            // 
            this.PanelSide.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelSide.Controls.Add(this.ChartAccounts);
            this.PanelSide.Controls.Add(this.panel5);
            this.PanelSide.Controls.Add(this.LabelHeaderChart);
            this.PanelSide.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanelSide.Font = new System.Drawing.Font("Calibri", 8F);
            this.PanelSide.Location = new System.Drawing.Point(679, 0);
            this.PanelSide.Name = "PanelSide";
            this.PanelSide.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.PanelSide.Size = new System.Drawing.Size(283, 673);
            this.PanelSide.TabIndex = 0;
            // 
            // ChartAccounts
            // 
            this.ChartAccounts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChartAccounts.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.ChartAccounts.Location = new System.Drawing.Point(0, 105);
            this.ChartAccounts.Name = "ChartAccounts";
            treeNode1.Name = "NodeUser";
            treeNode1.Text = "101 - المستودع الفرعي";
            treeNode2.Name = "NodeBranch";
            treeNode2.Text = "1 - المستودع الرئيسي";
            this.ChartAccounts.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2});
            this.ChartAccounts.RightToLeftLayout = true;
            this.ChartAccounts.Size = new System.Drawing.Size(281, 566);
            this.ChartAccounts.TabIndex = 2;
            this.ChartAccounts.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.ChartAccounts_AfterSelect);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.TextSearch);
            this.panel5.Controls.Add(this.ButtonNewAccount);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 56);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(281, 49);
            this.panel5.TabIndex = 1;
            // 
            // TextSearch
            // 
            this.TextSearch.EditValue = "";
            this.TextSearch.Location = new System.Drawing.Point(0, 6);
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
            this.TextSearch.Size = new System.Drawing.Size(226, 40);
            this.TextSearch.TabIndex = 2;
            // 
            // ButtonNewAccount
            // 
            this.ButtonNewAccount.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ButtonNewAccount.ImageOptions.Image")));
            this.ButtonNewAccount.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.ButtonNewAccount.Location = new System.Drawing.Point(232, 6);
            this.ButtonNewAccount.Name = "ButtonNewAccount";
            this.ButtonNewAccount.Size = new System.Drawing.Size(46, 40);
            this.ButtonNewAccount.TabIndex = 0;
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
            this.LabelHeaderChart.Size = new System.Drawing.Size(281, 56);
            this.LabelHeaderChart.TabIndex = 0;
            this.LabelHeaderChart.Text = "دليل المستودعات";
            // 
            // PanelMain
            // 
            this.PanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelMain.Location = new System.Drawing.Point(0, 0);
            this.PanelMain.Name = "PanelMain";
            this.PanelMain.Size = new System.Drawing.Size(679, 673);
            this.PanelMain.TabIndex = 1;
            // 
            // StoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 673);
            this.Controls.Add(this.PanelMain);
            this.Controls.Add(this.PanelSide);
            this.MaximizeBox = false;
            this.Name = "StoreForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "المستودعات";
            this.PanelSide.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TextSearch.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelSide;
        private System.Windows.Forms.Panel panel5;
        private DevExpress.XtraEditors.LabelControl LabelHeaderChart;
        private DevExpress.XtraEditors.SearchControl TextSearch;
        private DevExpress.XtraEditors.SimpleButton ButtonNewAccount;
        private System.Windows.Forms.TreeView ChartAccounts;
        private System.Windows.Forms.Panel PanelMain;
    }
}