namespace SipeiyouSelector
{
    partial class XFrmMain
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.xceGroup = new DevExpress.XtraEditors.CheckEdit();
            this.xccbeLevel = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.xccbeSubject = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.xlueGrade = new DevExpress.XtraEditors.LookUpEdit();
            this.xlueTerm = new DevExpress.XtraEditors.LookUpEdit();
            this.xsbSearch = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xceGroup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xccbeLevel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xccbeSubject.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xlueGrade.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xlueTerm.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(12, 86);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(898, 478);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.DataSourceChanged += new System.EventHandler(this.gridControl1_DataSourceChanged);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.xceGroup);
            this.layoutControl1.Controls.Add(this.xccbeLevel);
            this.layoutControl1.Controls.Add(this.xccbeSubject);
            this.layoutControl1.Controls.Add(this.xlueGrade);
            this.layoutControl1.Controls.Add(this.xlueTerm);
            this.layoutControl1.Controls.Add(this.xsbSearch);
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(922, 576);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // xceGroup
            // 
            this.xceGroup.Location = new System.Drawing.Point(12, 60);
            this.xceGroup.Name = "xceGroup";
            this.xceGroup.Properties.Caption = "使用排课组合";
            this.xceGroup.Size = new System.Drawing.Size(447, 19);
            this.xceGroup.StyleController = this.layoutControl1;
            this.xceGroup.TabIndex = 2;
            // 
            // xccbeLevel
            // 
            this.xccbeLevel.Location = new System.Drawing.Point(526, 36);
            this.xccbeLevel.Name = "xccbeLevel";
            this.xccbeLevel.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.xccbeLevel.Properties.DisplayMember = "Key";
            this.xccbeLevel.Properties.SelectAllItemVisible = false;
            this.xccbeLevel.Properties.ValueMember = "Value";
            this.xccbeLevel.Size = new System.Drawing.Size(384, 20);
            this.xccbeLevel.StyleController = this.layoutControl1;
            this.xccbeLevel.TabIndex = 6;
            // 
            // xccbeSubject
            // 
            this.xccbeSubject.Location = new System.Drawing.Point(75, 36);
            this.xccbeSubject.Name = "xccbeSubject";
            this.xccbeSubject.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.xccbeSubject.Properties.DisplayMember = "Key";
            this.xccbeSubject.Properties.SelectAllItemVisible = false;
            this.xccbeSubject.Properties.ValueMember = "Value";
            this.xccbeSubject.Size = new System.Drawing.Size(384, 20);
            this.xccbeSubject.StyleController = this.layoutControl1;
            this.xccbeSubject.TabIndex = 2;
            // 
            // xlueGrade
            // 
            this.xlueGrade.Location = new System.Drawing.Point(75, 12);
            this.xlueGrade.Name = "xlueGrade";
            this.xlueGrade.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.xlueGrade.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Key", "年级")});
            this.xlueGrade.Properties.DisplayMember = "Key";
            this.xlueGrade.Properties.ValueMember = "Value";
            this.xlueGrade.Size = new System.Drawing.Size(384, 20);
            this.xlueGrade.StyleController = this.layoutControl1;
            this.xlueGrade.TabIndex = 5;
            // 
            // xlueTerm
            // 
            this.xlueTerm.Location = new System.Drawing.Point(526, 12);
            this.xlueTerm.Name = "xlueTerm";
            this.xlueTerm.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.xlueTerm.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Key", "班级类型")});
            this.xlueTerm.Properties.DisplayMember = "Key";
            this.xlueTerm.Properties.ValueMember = "Value";
            this.xlueTerm.Size = new System.Drawing.Size(384, 20);
            this.xlueTerm.StyleController = this.layoutControl1;
            this.xlueTerm.TabIndex = 4;
            // 
            // xsbSearch
            // 
            this.xsbSearch.Location = new System.Drawing.Point(794, 60);
            this.xsbSearch.Name = "xsbSearch";
            this.xsbSearch.Size = new System.Drawing.Size(116, 22);
            this.xsbSearch.StyleController = this.layoutControl1;
            this.xsbSearch.TabIndex = 2;
            this.xsbSearch.Text = "查询";
            this.xsbSearch.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem4,
            this.layoutControlItem3,
            this.layoutControlItem5,
            this.layoutControlItem7,
            this.layoutControlItem6,
            this.emptySpaceItem1,
            this.layoutControlItem2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(922, 576);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 74);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(902, 482);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.xlueGrade;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(451, 24);
            this.layoutControlItem4.Text = "年级：";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(60, 14);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.xlueTerm;
            this.layoutControlItem3.Location = new System.Drawing.Point(451, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(451, 24);
            this.layoutControlItem3.Text = "班级类型：";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(60, 14);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.xccbeSubject;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(451, 24);
            this.layoutControlItem5.Text = "学科：";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(60, 14);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.xceGroup;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(451, 26);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.xccbeLevel;
            this.layoutControlItem6.Location = new System.Drawing.Point(451, 24);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(451, 24);
            this.layoutControlItem6.Text = "班次：";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(60, 14);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(451, 48);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(331, 26);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.xsbSearch;
            this.layoutControlItem2.Location = new System.Drawing.Point(782, 48);
            this.layoutControlItem2.MaxSize = new System.Drawing.Size(120, 26);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(120, 26);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(120, 26);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // XFrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 576);
            this.Controls.Add(this.layoutControl1);
            this.Name = "XFrmMain";
            this.Text = "选课系统";
            this.Load += new System.EventHandler(this.XFrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xceGroup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xccbeLevel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xccbeSubject.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xlueGrade.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xlueTerm.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.LookUpEdit xlueTerm;
        private DevExpress.XtraEditors.SimpleButton xsbSearch;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.LookUpEdit xlueGrade;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.CheckedComboBoxEdit xccbeSubject;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraEditors.CheckedComboBoxEdit xccbeLevel;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.CheckEdit xceGroup;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
    }
}

