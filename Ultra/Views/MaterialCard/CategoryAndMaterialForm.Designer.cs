
namespace Ultra.Views.MaterialCard
{
    partial class CategoryAndMaterialForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoryAndMaterialForm));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("011 - المادة الأولى");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("01 - الصنف الأول", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.PanelMain = new System.Windows.Forms.Panel();
            this.TextSearch = new DevExpress.XtraEditors.SearchControl();
            this.ChartCategoriesAndMaterials = new System.Windows.Forms.TreeView();
            this.LabelHeaderChart = new DevExpress.XtraEditors.LabelControl();
            this.PanelSide = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.ButtonNewMaterial = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonNewCategory = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.TextSearch.Properties)).BeginInit();
            this.PanelSide.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelMain
            // 
            this.PanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelMain.Location = new System.Drawing.Point(0, 0);
            this.PanelMain.Name = "PanelMain";
            this.PanelMain.Size = new System.Drawing.Size(964, 673);
            this.PanelMain.TabIndex = 3;
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
            // ChartCategoriesAndMaterials
            // 
            this.ChartCategoriesAndMaterials.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChartCategoriesAndMaterials.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.ChartCategoriesAndMaterials.Location = new System.Drawing.Point(0, 105);
            this.ChartCategoriesAndMaterials.Name = "ChartCategoriesAndMaterials";
            treeNode1.Name = "NodeMaterial";
            treeNode1.Text = "011 - المادة الأولى";
            treeNode2.Name = "NodeCategory";
            treeNode2.Text = "01 - الصنف الأول";
            this.ChartCategoriesAndMaterials.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2});
            this.ChartCategoriesAndMaterials.RightToLeftLayout = true;
            this.ChartCategoriesAndMaterials.Size = new System.Drawing.Size(281, 566);
            this.ChartCategoriesAndMaterials.TabIndex = 2;
            this.ChartCategoriesAndMaterials.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.ChartCategoriesAndMaterials_AfterSelect);
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
            this.LabelHeaderChart.Text = "دليل الأصناف والمواد";
            // 
            // PanelSide
            // 
            this.PanelSide.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelSide.Controls.Add(this.ChartCategoriesAndMaterials);
            this.PanelSide.Controls.Add(this.panel5);
            this.PanelSide.Controls.Add(this.LabelHeaderChart);
            this.PanelSide.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanelSide.Font = new System.Drawing.Font("Calibri", 8F);
            this.PanelSide.Location = new System.Drawing.Point(964, 0);
            this.PanelSide.Name = "PanelSide";
            this.PanelSide.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.PanelSide.Size = new System.Drawing.Size(283, 673);
            this.PanelSide.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.TextSearch);
            this.panel5.Controls.Add(this.ButtonNewMaterial);
            this.panel5.Controls.Add(this.ButtonNewCategory);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 56);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(281, 49);
            this.panel5.TabIndex = 1;
            // 
            // ButtonNewMaterial
            // 
            this.ButtonNewMaterial.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ButtonNewMaterial.ImageOptions.Image")));
            this.ButtonNewMaterial.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.ButtonNewMaterial.Location = new System.Drawing.Point(182, 6);
            this.ButtonNewMaterial.Name = "ButtonNewMaterial";
            this.ButtonNewMaterial.Size = new System.Drawing.Size(46, 40);
            this.ButtonNewMaterial.TabIndex = 0;
            // 
            // ButtonNewCategory
            // 
            this.ButtonNewCategory.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ButtonNewCategory.ImageOptions.Image")));
            this.ButtonNewCategory.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.ButtonNewCategory.Location = new System.Drawing.Point(234, 6);
            this.ButtonNewCategory.Name = "ButtonNewCategory";
            this.ButtonNewCategory.Size = new System.Drawing.Size(46, 40);
            this.ButtonNewCategory.TabIndex = 0;
            // 
            // CategoryAndMaterialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 673);
            this.Controls.Add(this.PanelMain);
            this.Controls.Add(this.PanelSide);
            this.MaximumSize = new System.Drawing.Size(1249, 705);
            this.Name = "CategoryAndMaterialForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الأصناف والمواد";
            ((System.ComponentModel.ISupportInitialize)(this.TextSearch.Properties)).EndInit();
            this.PanelSide.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelMain;
        private DevExpress.XtraEditors.SearchControl TextSearch;
        private System.Windows.Forms.TreeView ChartCategoriesAndMaterials;
        private DevExpress.XtraEditors.LabelControl LabelHeaderChart;
        private System.Windows.Forms.Panel PanelSide;
        private System.Windows.Forms.Panel panel5;
        private DevExpress.XtraEditors.SimpleButton ButtonNewMaterial;
        private DevExpress.XtraEditors.SimpleButton ButtonNewCategory;
    }
}