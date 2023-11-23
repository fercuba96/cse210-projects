using System;

class Program 
    
   {    
      static void Main(string[] args)
      {
       Assignment student1 = new Assignment();
       student1.SetStudentname("Fabrizio");
       student1.SetCoursename ("Maths");
       
       Console.WriteLine( student1.GetSummaryinfo());

       MathAssigment mathassignm = new MathAssigment();
       mathassignm.SetStudentname ("Fabri");
       mathassignm.SetCoursename ("AplyMaths");
       mathassignm.SetSectionclass("Section 1.5");
       mathassignm.Setproblems("Problems 1-10");

       Console.WriteLine (mathassignm.GetHomeworkList());

       WrittingAssignment writingassig = new WrittingAssignment();
       writingassig.SetStudentname ("Fabiola");
       writingassig.SetCoursename ("History of EEUU");
       writingassig.SetTitleofbook("From East to West");

       Console.WriteLine (writingassig.GetWrittinginfo());

      }
   }

