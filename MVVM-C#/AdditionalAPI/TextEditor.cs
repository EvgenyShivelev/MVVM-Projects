using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM.AdditionalAPI
{
    public static class TextEditor
    {
        public class StepData : IComparable
        {
            public int StepId { get; set; }
            public string StepDescription { get; set; }
            public StepData(int stepId, string Description)
            {
                StepId = stepId;
                StepDescription = Description;
            }

            public int CompareTo(object obj)
            {
                var otherStep = obj as StepData;

                if (StepId > otherStep.StepId)
                    return 1;
                else if (StepId == otherStep.StepId)
                    return 0;
                else
                    return -1;
            }
        }

        public static List<StepData> ConvertTextIntoSteps(string text)
        {
            var ConvertedSteps = new List<StepData>();
            try
            {
                var steps = text.Split(';');

                foreach (var step in steps)
                {
                    var id = step.Substring(0, step.IndexOf(' '));
                    var otherText = step.Substring(step.IndexOf(' '));
                    ConvertedSteps.Add(new StepData(int.Parse(id), otherText));
                }
            }
            catch { }
            return ConvertedSteps;
        }

        public static string ConvertStepsIntoText(List<StepData> data)
        {
            string answer = "";
            foreach (var step in data)
                answer += step.StepId + " " + step.StepDescription + ";";
            return answer;
        }

        private static int toInt(string s) => int.Parse(s);

        public static int DataToInt(string s1, string s2)
        {

            var fstRiceap = s1.Split('.');
            var scdRiceap = s2.Split('.');

            for (int i = 0; i < fstRiceap.Length; i++)
            {
                if (toInt(fstRiceap[i]) > toInt(scdRiceap[i]))
                    return 1;

                if (toInt(fstRiceap[i]) == toInt(scdRiceap[i]))
                    continue;

                if (toInt(fstRiceap[i]) < toInt(scdRiceap[i]))
                    return -1;
            }

            return 0;
        }
    }
}
