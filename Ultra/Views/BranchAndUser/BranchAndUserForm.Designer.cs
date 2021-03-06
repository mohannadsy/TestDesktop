
namespace Ultra.Views.BranchAndUser
{
    partial class BranchAndUserForm
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
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("011 - المدير العام");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("01 - الفرع الرئيسي", new System.Windows.Forms.TreeNode[] {
            treeNode7});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BranchAndUserForm));
            this.PanelSide = new System.Windows.Forms.Panel();
            this.ChartBranchesAndUsers = new System.Windows.Forms.TreeView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.TextSearch = new DevExpress.XtraEditors.SearchControl();
            this.ButtonNewUser = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonNewBranch = new DevExpress.XtraEditors.SimpleButton();
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
            this.PanelSide.Controls.Add(this.ChartBranchesAndUsers);
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
            // ChartBranchesAndUsers
            // 
            this.ChartBranchesAndUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChartBranchesAndUsers.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.ChartBranchesAndUsers.Location = new System.Drawing.Point(0, 105);
            this.ChartBranchesAndUsers.Name = "ChartBranchesAndUsers";
            treeNode7.Name = "NodeUser";
            treeNode7.Text = "011 - المدير العام";
            treeNode8.Name = "NodeBranch";
            treeNode8.Text = "01 - الفرع الرئيسي";
            this.ChartBranchesAndUsers.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode8});
            this.ChartBranchesAndUsers.RightToLeftLayout = true;
            this.ChartBranchesAndUsers.Size = new System.Drawing.Size(281, 566);
            this.ChartBranchesAndUsers.TabIndex = 2;
            this.ChartBranchesAndUsers.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.ChartBranchesAndUsers_AfterSelect);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.TextSearch);
            this.panel5.Controls.Add(this.ButtonNewUser);
            this.panel5.Controls.Add(this.ButtonNewBranch);
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
            this.TextSearch.Size = new System.Drawing.Size(176, 40);
            this.TextSearch.TabIndex = 2;
            // 
            // ButtonNewUser
            // 
            this.ButtonNewUser.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ButtonNewUser.ImageOptions.Image")));
            this.ButtonNewUser.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.ButtonNewUser.Location = new System.Drawing.Point(182, 6);
            this.ButtonNewUser.Name = "ButtonNewUser";
            this.ButtonNewUser.Size = new System.Drawing.Size(46, 40);
            this.ButtonNewUser.TabIndex = 0;
            // 
            // ButtonNewBranch
            // 
            this.ButtonNewBranch.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ButtonNewBranch.ImageOptions.Image")));
            this.ButtonNewBranch.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.ButtonNewBranch.Location = new System.Drawing.Point(234, 6);
            this.ButtonNewBranch.Name = "ButtonNewBranch";
            this.ButtonNewBranch.Size = new System.Drawing.Size(46, 40);
            this.ButtonNewBranch.TabIndex = 0;
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
            this.LabelHeaderChart.Text = "دليل الفروع والمستخدمين";
            // 
            // PanelMain
            // 
            this.PanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelMain.Location = new System.Drawing.Point(0, 0);
            this.PanelMain.Name = "PanelMain";
            this.PanelMain.Size = new System.Drawing.Size(679, 673);
            this.PanelMain.TabIndex = 1;
            // 
            // BranchAndUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 673);
            this.Controls.Add(this.PanelMain);
            this.Controls.Add(this.PanelSide);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(964, 705);
            this.MinimumSize = new System.Drawing.Size(964, 705);
            this.Name = "BranchAndUserForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الفروع والمستخدمين";
            this.PanelSide.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TextSearch.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelSide;
        private System.Windows.Forms.Panel panel5;
        private DevExpress.XtraEditors.SimpleButton ButtonNewBranch;
        private DevExpress.XtraEditors.LabelControl LabelHeaderChart;
        private DevExpress.XtraEditors.SearchControl TextSearch;
        private DevExpress.XtraEditors.SimpleButton ButtonNewUser;
        private System.Windows.Forms.TreeView ChartBranchesAndUsers;
        private System.Windows.Forms.Panel PanelMain;
    }
}