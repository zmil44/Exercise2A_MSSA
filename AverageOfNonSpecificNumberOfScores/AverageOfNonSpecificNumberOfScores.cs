using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageOfNonSpecificNumberOfScores
{
    class AverageOfNonSpecificNumberOfScores
    {
        static void Main(string[] args)
        {
            string input;
            string letterGrade;
            bool goodInput = true;



            if (average >= 94)
                letterGrade = "A";
            else if (average < 94 && average >= 90)
                letterGrade = "A-";
            else if (average < 90 && average >= 86)
                letterGrade = "B+";
            else if (average < 85 && average >= 83)
                letterGrade = "B";
            else if (average < 83 && average >= 80)
                letterGrade = "B-";
            else if (average < 80 && average >= 76)
                letterGrade = "C+";
            else if (average < 76 && average >= 73)
                letterGrade = "C";
            else if (average < 73 && average >= 70)
                letterGrade = "C-";
            else if (average < 70 && average >= 66)
                letterGrade = "D+";
            else if (average < 66 && average >= 63)
                letterGrade = "D";
            else if (average < 63 && average >= 60)
                letterGrade = "D-";
            else
                letterGrade = "F";
        }
    }
}
