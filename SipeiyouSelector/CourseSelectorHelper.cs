using System.Text.RegularExpressions;
using HtmlAgilityPack;

namespace SipeiyouSelector
{
    public static class CourseSelectorHelper
    {
        public static CourseCollection GetCourses(string sUrl)
        {
            var htmlWeb = new HtmlWeb();
            var docNode = htmlWeb.Load(sUrl).DocumentNode;
            var courseCollection = new CourseCollection();
            foreach (var node in docNode.SelectNodes("//div[@class='s-r-list']"))
            {
                var course = new Course
                {
                    老师 = node.FirstChild.FirstChild.NextSibling.InnerText,
                    上课地点 =
                        node.FirstChild.NextSibling.FirstChild.NextSibling.FirstChild.NextSibling.NextSibling
                            .NextSibling.NextSibling.NextSibling.InnerText,
                    上课时间 =
                        node.FirstChild.NextSibling.FirstChild.NextSibling.FirstChild.NextSibling.NextSibling
                            .NextSibling.NextSibling.FirstChild.NextSibling.InnerText,
                    学科 =
                        node.FirstChild.NextSibling.FirstChild.NextSibling.FirstChild.NextSibling.NextSibling
                            .NextSibling.FirstChild.InnerText,
                    剩余 = node.FirstChild.NextSibling.FirstChild.NextSibling.NextSibling.FirstChild.FirstChild.InnerText
                };
                courseCollection.Add(course);
            }
            return courseCollection;
        }

        public static int GetPages(string sUrl)
        {
            var htmlWeb = new HtmlWeb();
            var docNode = htmlWeb.Load(sUrl).DocumentNode;
            var sPages = docNode.SelectSingleNode("//div[@class='pagination mtop40']").InnerText;
            return int.Parse(Regex.Match(sPages, @"(?<=/)\d+(?=页)").Value);
        }
    }
}