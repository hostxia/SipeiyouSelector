using System.Threading;

namespace SipeiyouSelector
{
    public class CourseCollectionHelper
    {
        public CourseCollection GetAllCourses(string sTerm)
        {
            var courseCollection = new CourseCollection();
            foreach (var sGrade in DicCourse.DicGrade.Values)
                foreach (var sLevel in DicCourse.DicLevel.Values)
                    foreach (var sSubject in DicCourse.DicSubject.Values)
                    {
                        var sUrl =
                            $"http://sbj.speiyou.com/search/index/grade:{sGrade}/subject:{sSubject}/level:{sLevel}/term:{sTerm}/gtype:time";
                        var nPageCount = CourseSelectorHelper.GetPages(sUrl);
                        for (var i = 1; i <= nPageCount; i++)
                        {
                            var thread = new Thread(() =>
                            {
                                var pageUrl =
$"http://sbj.speiyou.com/search/index/grade:{sGrade}/subject:{sSubject}/level:{sLevel}/term:{sTerm}/period:0/teaid:/m:/d:/time:/bg:n/nu:/service:/curpage:{i}";
                                courseCollection.AddRange(CourseSelectorHelper.GetCourses(pageUrl));
                            });
                            thread.Start();
                            thread.Join();
                            //var pageUrl =
                            //    $"http://sbj.speiyou.com/search/index/grade:{sGrade}/subject:{sSubject}/level:{sLevel}/term:{sTerm}/period:0/teaid:/m:/d:/time:/bg:n/nu:/service:/curpage:{i}";
                            //courseCollection.AddRange(CourseSelectorHelper.GetCourses(pageUrl));
                        }
                    }
            return courseCollection;
        }
    }
}