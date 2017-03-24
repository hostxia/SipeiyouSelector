using System.Collections.Generic;

namespace SipeiyouSelector
{
    public static class DicCourse
    {
        public static Dictionary<string, string> DicGrade => new Dictionary<string, string>
        {
            {"小学一年级", "1"}
        };

        public static Dictionary<string, string> DicSubject => new Dictionary<string, string>
        {
            {"数学", "ff80808127d77caa0127d7e10f1c00c4"},
            {"语文", "ff80808127d77caa0127d7e13be500c6"},
            {"英语", "ff80808127d77caa0127d7e164bd00c8"}
        };

        public static Dictionary<string, string> DicLevel => new Dictionary<string, string>
        {
            {"尖子", "3"}
        };

        public static Dictionary<string, string> DicTerm => new Dictionary<string, string>
        {
            {"暑期班", "2"},
            {"秋季班", "3"}
        };
    }
}