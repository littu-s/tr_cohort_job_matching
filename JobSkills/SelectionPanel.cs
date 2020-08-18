using System;
using System.Collections.Generic;
using System.Text;

namespace JobSkills
{
    class SelectionPanel
    {
        #region Fields
        List<string> requiredJobSkills = new List<string>()
        {
            "remote",
            "flexible working hours",
            "office based two days per week",
            "react developer"
        };

        List<string> requiredPersonSkills = new List<string>()
        {
            "wants to work remote",
            "react experience",
            "looking for frontend",
            "backend developer",
            "cloud experience",
            "AWS certified"
        };
        #endregion

        #region Methods

        // function to check for ideal match
        public int IdealMatch(List<string> job, List<string> individual)
        {
            int Score = 0;
            //check if the individual's job skill is in preferred job skill; if so, add 10 points to score for each skill
            foreach (string skills in job)
            {
                if (requiredJobSkills.Contains(skills))
                {
                    Score += 10;
                }
            }

            //check if the individual's charcteristics is in preferred person skill; if so, add 10 points to score for each skill
            foreach (string skills in individual)
            {
                if (requiredPersonSkills.Contains(skills))
                {
                    Score += 10;
                }
            }

            return Score;
        }
        #endregion
    }
}
