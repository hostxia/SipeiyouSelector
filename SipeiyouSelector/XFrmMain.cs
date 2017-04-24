using System;
using System.Linq;
using System.Threading;
using DevExpress.Data;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;

namespace SipeiyouSelector
{
    public partial class XFrmMain : XtraForm
    {
        public XFrmMain()
        {
            InitializeComponent();
        }

        private void XFrmMain_Load(object sender, EventArgs e)
        {
            xlueGrade.Properties.DataSource = DicCourse.DicGrade;
            xlueGrade.ItemIndex = 0;
            xccbeSubject.Properties.DataSource = DicCourse.DicSubject;
            xccbeSubject.SetEditValue(DicCourse.DicSubject.First().Value);
            xccbeLevel.Properties.DataSource = DicCourse.DicLevel;
            xccbeLevel.SetEditValue(DicCourse.DicLevel.First().Value);
            xlueTerm.Properties.DataSource = DicCourse.DicTerm;
            xlueTerm.ItemIndex = 0;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            var thread = new Thread(() =>
            {
                try
                {
                    xsbSearch.Invoke(new Action(() => { xsbSearch.Enabled = false; }));
                    var courseCollection = new CourseCollectionHelper().GetAllCourses(xlueGrade.EditValue.ToString(), xlueTerm.EditValue.ToString(), xccbeSubject.EditValue.ToString(), xccbeLevel.EditValue.ToString());
                    gridControl1.Invoke(new Action(() => { gridControl1.DataSource = courseCollection; }));
                }
                catch (Exception exception)
                {
                    XtraMessageBox.Show($"出现错误，请重试！\r\n{exception}", "错误");
                }
                finally
                {
                    xsbSearch.Invoke(new Action(() => { xsbSearch.Enabled = true; }));
                }
            });
            thread.Start();
        }

        private void gridControl1_DataSourceChanged(object sender, EventArgs e)
        {
            gridView1.Columns.ToList().ForEach(c => c.OptionsFilter.AutoFilterCondition = AutoFilterCondition.Contains);
            if (gridView1.Columns.Count > 0)
                gridView1.Columns[0].SummaryItem.SummaryType = SummaryItemType.Count;

            gridView1.BestFitColumns(true);
        }
    }
}