using System;
using System.Collections.Generic;
using System.Text;

namespace EasyLevel
{
    public class gradingStudents
    {
        public static void Run(List<int> grades)
        {
            if (grades == null || grades.Count == 0) { return; } // Constraints: 1 <= grades.length <= 60, 0 <= grades[i] <= 100

            foreach (int grade in grades)
            {
                if (grade < 0 || grade > 100) { return; } // Return if any grade is out of the specified range 
            }


            List<int> roundedGrades = new List<int>();
            foreach (int grade in grades)
            {
                if (grade < 38)
                {
                    roundedGrades.Add(grade); // No rounding for grades less than 38
                }
                else
                {
                    int nextMultipleOf5 = ((grade / 5) + 1) * 5; // Calculate the next multiple of 5
                    if (nextMultipleOf5 - grade < 3)
                    {
                        roundedGrades.Add(nextMultipleOf5); // Round up to the next multiple of 5 if the difference is less than 3
                    }
                    else
                    {
                        roundedGrades.Add(grade); // No rounding if the difference is 3 or more
                    }
                }
            }
            Console.WriteLine(string.Join(", ", roundedGrades)); // Output the rounded grades
        }
    }
}
