using System.Collections.Generic;

namespace SipeiyouSelector
{
    public static class DicCourse
    {
        public static Dictionary<string, string> DicGrade => new Dictionary<string, string>
        {
            {"托班", "-9"},
            {"小班", "-8"},
            {"中班", "-7"},
            {"大班", "-6"},
            {"学前班", "0"},
            {"小学一年级", "1"},
            {"小学二年级", "2"},
            {"小学三年级", "3"},
            {"小学四年级", "4"},
            {"小学五年级", "5"},
            {"小学六年级", "6"},
            {"初中一年级", "7"},
            {"初中二年级", "8"},
            {"初中三年级", "9"},
            {"高中一年级", "10"},
            {"高中二年级", "11"},
            {"高中三年级", "12"},
            {"小学组", "13"},
            {"初中组", "14"},
            {"高中组", "15"},
            {"小升初", "0000000049571bfa01495ea8e62b468f"}
        };

        public static Dictionary<string, string> DicSubject => new Dictionary<string, string>
        {
            {"数学", "ff80808127d77caa0127d7e10f1c00c4"},
            {"语文", "ff80808127d77caa0127d7e13be500c6"},
            {"英语", "ff80808127d77caa0127d7e164bd00c8"},
            {"物理", "ff80808127d77caa0127d7e199bc00cb"},
            {"化学", "ff80808127d77caa0127d7e1e29c00ce"},
            {"历史", "ff808081320175f1013214e924aa473f"},
            {"地理", "ff8080815895acb70158b87e2c46000e"},
            {"生物", "ff80808127d77caa0127d7e2117700d0"},
            {"政治", "ff8080812a6661e6012a84cf938a029a"},
            {"综合", "ff8080812843003e0128443e78f1005f"},
            {"数学联赛", "4028871d280025ea012800b206313809"},
        };

        public static Dictionary<string, string> DicLevel => new Dictionary<string, string>
        {
            {"基础", "1"},
            {"提高", "2"},
            {"尖子", "3"},
            {"尖子A", "3.5"},
            {"目标", "4"},
            {"考试", "7"},
            {"竞赛", "9"}
        };

        public static Dictionary<string, string> DicTerm => new Dictionary<string, string>
        {
            {"春季班", "1"},
            {"暑期班", "2"},
            {"秋季班", "3"},
            {"短期班", "5"},
            {"活动类", "6"},
            {"考试类", "ff8080812eb4e425012ebd619d0f0a49"}
        };
    }
}