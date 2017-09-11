using System;
using System.Text.RegularExpressions;
using DevExpress.XtraEditors;
using HtmlAgilityPack;

namespace SipeiyouSelector
{
    public static class CourseSelectorHelper
    {
        public static CourseCollection GetCourses(string sUrl)
        {
            var courseCollection = new CourseCollection();
            var htmlWeb = new HtmlWeb();
            HtmlNode docNode = null;
            for (int i = 0; i < 3; i++)
            {
                try
                {
                    docNode = htmlWeb.Load(sUrl).DocumentNode;
                    break;
                }
                catch
                {
                    if (i == 2)
                        throw new Exception("获取信息失败，这可能是由于网站访问量太大导致。");
                }
            }
            if (docNode != null)
                foreach (var node in docNode.SelectNodes("//div[@class='s-r-list']"))
                {
                    var course = new Course
                    {
                        名称 = node.FirstChild.NextSibling.FirstChild.NextSibling.FirstChild.NextSibling.FirstChild.InnerText,
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
            HtmlNode docNode = null;
            for (int i = 0; i < 3; i++)
            {
                try
                {
                    docNode = htmlWeb.Load(sUrl).DocumentNode;
                    break;
                }
                catch
                {
                    if (i == 2)
                        throw new Exception("获取信息失败，这可能是由于网站访问量太大导致。");

                }
            }
            var pageNode = docNode?.SelectSingleNode("//div[@class='pagination mtop40']");
            if (pageNode == null)
                return 0;
            var sPages = pageNode.InnerText;
            return int.Parse(Regex.Match(sPages, @"(?<=/)\d+(?=页)").Value);
        }
    }
}