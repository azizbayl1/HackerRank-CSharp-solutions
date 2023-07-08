using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'gradingStudents' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY grades as parameter.
     */

    public static List<int> GradingStudents(List<int> grades)
    {
        var newGrades = new List<int>();

        foreach (var grade in grades)
        {
            int round = (grade / 5 + 1) * 5;

            if (grade > 37)
            {
                if ((round - grade) < 3)
                {
                    int newGrade = round;
                    newGrades.Add(newGrade);
                }
                else
                {
                    newGrades.Add(grade);
                }
            }
            else { newGrades.Add(grade);}
        }
        return newGrades;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int gradesCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> grades = new List<int>();

        for (int i = 0; i < gradesCount; i++)
        {
            int gradesItem = Convert.ToInt32(Console.ReadLine().Trim());
            grades.Add(gradesItem);
        }

        List<int> result = Result.GradingStudents(grades);

        textWriter.WriteLine(String.Join("\n", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
