using System;

class Program
{
    static void Main(string[] args)
    {
       MathAssignment mathAssignment1 = new MathAssignment("Nestor Gomez", "Fractions", "7.2", "8-17");
       Console.WriteLine(mathAssignment1.getSummary());
       Console.WriteLine(mathAssignment1.GetHomeworkList());

       WritingAssignment writingAssignment1 = new WritingAssignment("Nestor Gomez", "Fractions", "The Causes of World War II by Mary Waters");
       Console.WriteLine(writingAssignment1.getSummary());
       Console.WriteLine(writingAssignment1.GetWritingInformation());
    }
}