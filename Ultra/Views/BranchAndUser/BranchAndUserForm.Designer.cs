
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("011 - المدير العام");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("01 - الفرع الرئيسي", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BranchAndUserForm));
            this.PanelSide = new System.Windows.Forms.Panel();
            this.ChartBranchesAndUsers = new System.Windows.Forms.TreeView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.searchControl1 = new DevExpress.XtraEditors.SearchControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.PanelMain = new System.Windows.Forms.Panel();
            this.PanelSide.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelSide
            // 
            this.PanelSide.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelSide.Controls.Add(this.ChartBranchesAndUsers);
            this.PanelSide.Controls.Add(this.panel5);
            this.PanelSide.Controls.Add(this.labelControl1);
            this.PanelSide.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanelSide.Font = new System.Drawing.Font("Calibri", 8F);
            this.PanelSide.Location = new System.Drawing.Point(679, 0);
            this.PanelSide.Name = "PanelSide";
            this.PanelSide.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.PanelSide.Size = new System.Drawing.Size(283, 620);
            this.PanelSide.TabIndex = 0;
            // 
            // ChartBranchesAndUsers
            // 
            this.ChartBranchesAndUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChartBranchesAndUsers.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.ChartBranchesAndUsers.Location = new System.Drawing.Point(0, 105);
            this.ChartBranchesAndUsers.Name = "ChartBranchesAndUsers";
            treeNode1.Name = "NodeUser";
            treeNode1.Text = "011 - المدير العام";
            treeNode2.Name = "NodeBranch";
            treeNode2.Text = "01 - الفرع الرئيسي";
            this.ChartBranchesAndUsers.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2});
            this.ChartBranchesAndUsers.RightToLeftLayout = true;
            this.ChartBranchesAndUsers.Size = new System.Drawing.Size(281, 513);
            this.ChartBranchesAndUsers.TabIndex = 2;
            this.ChartBranchesAndUsers.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.ChartBranchesAndUsers_AfterSelect);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.searchControl1);
            this.panel5.Controls.Add(this.simpleButton2);
            this.panel5.Controls.Add(this.simpleButton1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 56);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(281, 49);
            this.panel5.TabIndex = 1;
            // 
            // searchControl1
            // 
            this.searchControl1.Location = new System.Drawing.Point(0, 6);
            this.searchControl1.Name = "searchControl1";
            this.searchControl1.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchControl1.Properties.Appearance.Options.UseFont = true;
            this.searchControl1.Properties.AutoHeight = false;
            this.searchControl1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton()});
            this.searchControl1.Properties.ContextImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("searchControl1.Properties.ContextImageOptions.Image")));
            this.searchControl1.Properties.ShowSearchButton = false;
            this.searchControl1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.searchControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.searchControl1.Size = new System.Drawing.Size(176, 40);
            this.searchControl1.TabIndex = 2;
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.simpleButton2.Location = new System.Drawing.Point(182, 6);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(46, 40);
            this.simpleButton2.TabIndex = 0;
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.simpleButton1.Location = new System.Drawing.Point(234, 6);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(46, 40);
            this.simpleButton1.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl1.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.labelControl1.ImageOptions.Alignment = System.Drawing.ContentAlignment.MiddleRight;
            this.labelControl1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("labelControl1.ImageOptions.Image")));
            this.labelControl1.Location = new System.Drawing.Point(0, 0);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(281, 56);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "دليل الفروع والمستخدمين";
            // 
            // PanelMain
            // 
            this.PanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelMain.Location = new System.Drawing.Point(0, 0);
            this.PanelMain.Name = "PanelMain";
            this.PanelMain.Size = new System.Drawing.Size(679, 620);
            this.PanelMain.TabIndex = 1;
            // 
            // BranchAndUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 620);
            this.Controls.Add(this.PanelMain);
            this.Controls.Add(this.PanelSide);
            this.Name = "BranchAndUserForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BranchAndUserForm";
            this.PanelSide.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelSide;
        private System.Windows.Forms.Panel panel5;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SearchControl searchControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.TreeView ChartBranchesAndUsers;
        private System.Windows.Forms.Panel PanelMain;
    }
}