using System.Collections.Generic;

namespace SipeiyouSelector
{
    public class Course
    {
        public string 名称 { get; set; }
        public string 学科 { get; set; }
        public string 老师 { get; set; }
        public string 上课时间 { get; set; }

        public string 期别 => 上课时间.Substring(5, 上课时间.Substring(5).IndexOfAny(new[] { '上', '下', '晚' }));

        public string 上课地点 { get; set; }
        public string 剩余 { get; set; }
        public string 组合 { get; set; }
    }

    public class CourseCollection : List<Course>
    {
    }
}