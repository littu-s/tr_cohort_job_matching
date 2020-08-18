using System;
using System.Collections.Generic;
using System.Threading.Tasks.Sources;

namespace JobSkills
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> job = new List<string>() 
            {
                "flexible working hours",
                "office based two days per week",
                "react developer"
            };

            List<string> individual = new List<string>()
            {
               "backend developer",
                "cloud experience",
                "AWS certified"
            };

            SelectionPanel selectionPanel = new SelectionPanel();
            int score = selectionPanel.IdealMatch(job, individual);
            
            if(score == 100)
            {
                Console.WriteLine("Ideal match with Selection Score: " + score);
            }

            else if(score == 0)
            {
                Console.WriteLine("Not match with Selection Score: " + score);
            }

            else
            {
                Console.WriteLine("Selection Score: " + score);
            }

            Console.ReadLine();

        }

       
    }
}
