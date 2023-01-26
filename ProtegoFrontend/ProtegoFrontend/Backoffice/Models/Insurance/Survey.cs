using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasProjekt.Backoffice.Models.Insurance
{
    public class Survey
    {
        public bool[] Answers = new bool[10];

        public Survey(bool[] Answers)
        {
            this.Answers = Answers;
        }

        public string GetSurveyData()
        {
            StringBuilder StringBuilder = new StringBuilder();

            foreach (var element in Answers)
                StringBuilder.Append(element == true ? "|Yes " : "|No ");
            return StringBuilder.ToString();
        }

        public string PrepareToSave()
        {
            StringBuilder StringBuilder = new StringBuilder();
            foreach (var element in Answers)
                StringBuilder.Append(element == true ? "true;" : "false;");
            return StringBuilder.ToString();
        }
    }
}
