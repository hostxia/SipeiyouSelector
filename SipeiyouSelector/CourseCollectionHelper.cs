using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace SipeiyouSelector
{
    public class CourseCollectionHelper
    {
        public CourseCollection GetAllCourses(string sGrade, string sTerm, string sSubjects, string sLevels, bool bUseGroup)
        {
            var courseCollection = new CourseCollection();
            foreach (var sLevel in sLevels.Split(',').Select(s => s.Trim()).ToList())
                foreach (var sSubject in sSubjects.Split(',').Select(s => s.Trim()).ToList())
                {
                    var sUrl =
                        $"http://sbj.speiyou.com/search/index/grade:{sGrade}/subject:{sSubject}/level:{sLevel}/term:{sTerm}/gtype:time";
                    var nPageCount = CourseSelectorHelper.GetPages(sUrl);
                    if (nPageCount > 0)
                    {
                        var waitHandles = new WaitHandle[nPageCount];
                        for (var i = 1; i <= nPageCount; i++)
                        {
                            waitHandles[i - 1] = new ManualResetEvent(false);
                            var pageUrl =
    $"http://sbj.speiyou.com/search/index/grade:{sGrade}/subject:{sSubject}/level:{sLevel}/term:{sTerm}/period:/teaid:/m:/d:/time:/bg:n/nu:/service:/curpage:{i}";
                            ThreadPool.QueueUserWorkItem(e =>
                            {
                                var collection = CourseSelectorHelper.GetCourses(((object[])e)[1].ToString());
                                lock (courseCollection)
                                    courseCollection.AddRange(collection);
                                ((ManualResetEvent)((object[])e)[0]).Set();
                            }, new object[] { waitHandles[i - 1], pageUrl });
                        }
                        WaitHandle.WaitAll(waitHandles);
                    }
                }

            return bUseGroup ? SetBestGroup(courseCollection) : courseCollection;
        }

        private CourseCollection SetBestGroup(CourseCollection courseCollection)
        {
            var listSubject = courseCollection.GroupBy(c => c.学科).Select(c => c.Key).Distinct().ToList();
            foreach (var gSubjectPlace in courseCollection.GroupBy(c => c.上课地点))
            {
                if (gSubjectPlace.Select(d => d.期别).Any(d => d.Contains("期")))
                {
                    foreach (var sTerm in gSubjectPlace.Select(d => d.期别).Distinct())
                    {
                        var listSubjectPlace = gSubjectPlace.Where(a => a.期别 == sTerm).OrderBy(a => a.上课时间).ToList();
                        for (var i = 0; i < listSubjectPlace.Count - listSubject.Count; i++)
                        {
                            var listNSubject = listSubjectPlace.Skip(i).Take(listSubject.Count).ToList();
                            if (listNSubject.Select(a => a.学科).Distinct().Count() == listSubject.Count
                                && listNSubject.Select(b => b.上课时间).Distinct().Count() == listSubject.Count
                                && listNSubject.All(e => e.组合 == null))
                                listNSubject.ForEach(c => c.组合 = gSubjectPlace.Key + "-" + sTerm + "-" + (i + 1));
                        }
                    }
                }
                else if (gSubjectPlace.Select(d => d.期别).Any(d => d.Contains("周")))
                {
                    var listSubjectPlace = gSubjectPlace.OrderBy(a => a.上课时间).ToList();
                    for (var i = 0; i < listSubjectPlace.Count - listSubject.Count; i++)
                    {
                        var listNSubject = listSubjectPlace.Skip(i).Take(listSubject.Count).ToList();
                        if (listNSubject.Select(a => a.学科).Distinct().Count() == listSubject.Count
                            && listNSubject.Select(b => b.上课时间).Distinct().Count() == listSubject.Count
                            && listNSubject.All(e => e.组合 == null))
                        {
                            var sGroup = gSubjectPlace.Key + "-" + (i + 1);
                            listNSubject.ForEach(c => c.组合 = sGroup);
                        }
                    }
                }

            }
            return courseCollection;
        }
    }
}