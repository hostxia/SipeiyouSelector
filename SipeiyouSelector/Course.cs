using System.Collections.Generic;

namespace SipeiyouSelector
{
    public class Course
    {
        public string 学科 { get; set; }
        public string 老师 { get; set; }
        public string 上课时间 { get; set; }
        public string 上课地点 { get; set; }
        public string 剩余 { get; set; }
        public int 组合 { get; set; }
    }

    public class CourseCollection : List<Course>
    {
    }
}