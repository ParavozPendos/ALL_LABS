using System.ComponentModel;

namespace WinFormsApp3
{
    static class StudyFormSource {
        static public string GetDifinition(Enum value) {
            var field = value.GetType().GetField(value.ToString());
            var attribute = (DescriptionAttribute)field.GetCustomAttributes(typeof(DescriptionAttribute), false).FirstOrDefault();
            return attribute?.Description ?? value.ToString();
        }
        public static List<StudyFormItem> SetupStudyFormComboBox()
        {
           var temporary = Enum.GetValues(typeof(StudyForm))
                .Cast<StudyForm>()
                .Select(f => new StudyFormItem
                {
                    Value = f,
                    Display = GetDifinition(f)
                })
                .ToList();
            return temporary;
        }

    }
    public enum StudyForm
    {
        [Description("Специалист")]
        Spec = 1,
        [Description("Бакалавриат")]
        Bak = 2,
        [Description("Магистратура")]
        Mag = 3,
        [Description("Аспирантура")]
        Asp = 4
    }
    public class StudyFormItem
    {
        public StudyForm Value { get; set; }
        public string Display { get; set; }

        public override string ToString() => Display;
    }

}
