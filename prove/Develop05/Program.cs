using System;

class Program
{
    static void Main(string[] args)
    { 

        goalmanager goalManager = new goalmanager();
       
        char choice = '0';


        while ( choice != '4')

        {

        Console.WriteLine("The options are:  ");
        Console.WriteLine("1. Set goal ");
        Console.WriteLine("2. List goal");
        Console.WriteLine("3. none");
        Console.WriteLine("4. quit");

        choice =Console.ReadKey().KeyChar;
        Console.WriteLine();

        switch (choice)

           {
            case '1':
                 goalManager.Setgoal();
                 break;
            case '2':
                 goalManager.DisplayGoalList();
                 break;
            case '3':
                 goalManager.ChosetoRecord(); 
                 break;
            case '4':
                 Console.WriteLine ("Press any key to quit.");
                 break;
             }
         Console.ReadKey();
          } 
        //Console.WriteLine("Enter your goals. Type 'exit' to finish.");
//
        //while (true)
        //{ 
        //    Console.Write("Enter exit to close program\nOr Enter a kind of goal name: \n1.Simple goal\n2.Eternal Goal\n3.ListGoal\n\n");
        //    string Kindofgoal = Console.ReadLine();
        //    if (Kindofgoal.ToLower() == "exit")
        //                break;
        //
        //    if (int.TryParse(Kindofgoal, out int Kindofgoalnumber))
        //    {
//
        //       if (Kindofgoalnumber == 1)
        //          {      
        //            Console.Write("Enter a name for goal: ");           
        //            string goalName = Console.ReadLine();
        //
        //            
        //            Console.Write("Enter the goal description: ");
        //            string goalDescription = Console.ReadLine();
        //
        //            Console.Write("Enter the points for the goal: ");
        //            string pointForGoal = Console.ReadLine();
        //
        //            // Convert the string to an integer
        //            if (int.TryParse(pointForGoal, out int pointInNumber))
        //            {
        ////s        tring timeinsec1 = "";
        //           simplegoalclass simplegoal1 = new simplegoalclass();
        //           simplegoal1.Setnameofgoal(goalName);
        //           simplegoal1.Setdescription(goalDescription);
        //           simplegoal1.Setpointtodisplay(pointInNumber);
        //
        //           //Console.WriteLine(simplegoal1.DisplayStartingMessage());
        //           //Console.WriteLine(simplegoal1.Displayendingmessage());
        //
        ////         Convert the string to an integer
        //           goalManager.AddGoalDetails(simplegoal1.GetStringRepresentation());
        //            }
        //            else
        //            {
        //                Console.WriteLine("Invalid input for points. Please enter a valid number.");
        //            }
        //           }   
        //        if (Kindofgoalnumber == 2)
        //          {      
        //            Console.Write("Enter a name for goal: ");           
        //            string goalName = Console.ReadLine();
        //
        //            
        //            Console.Write("Enter the goal description: ");
        //            string goalDescription = Console.ReadLine();
        //
        //            Console.Write("Enter the points for the goal: ");
        //            string pointForGoal = Console.ReadLine();
        //
        //            // Convert the string to an integer
        //            if (int.TryParse(pointForGoal, out int pointInNumber))
        //            {
        ////s        tring timeinsec1 = "";
        //           eternalgoalclass eternalgoal1 = new eternalgoalclass();
        //           eternalgoal1.Setnameofgoal(goalName);
        //           eternalgoal1.Setdescription(goalDescription);
        //           eternalgoal1.Setpointtodisplay(pointInNumber);
        //
        //          // Console.WriteLine(simplegoal1.DisplayStartingMessage());
        //           //Console.WriteLine(simplegoal1.Displayendingmessage());
        //
        ////         Convert the string to an integer
        //           goalManager.AddGoalDetails(eternalgoal1.GetStringRepresentation());
        //            }
        //            else
        //            {
        //                Console.WriteLine("Invalid input for points. Please enter a valid number.");
        //            }
        //           }
//
        //           if (Kindofgoalnumber == 3)
        //          {      
        //            Console.Write("Enter a name for goal: ");           
        //            string goalName = Console.ReadLine();
        //
        //            
        //            Console.Write("Enter the goal description: ");
        //            string goalDescription = Console.ReadLine();
        //
        //            Console.Write("Enter the points for the goal: ");
        //            string pointForGoal = Console.ReadLine();
        //            
        //            
        //            // Convert the string to an integer
        //            if (int.TryParse(pointForGoal, out int pointInNumber))  
        //            {
        //                Console.Write("Enter the times to complete goal: ");
        //                string timestocompletegoal = Console.ReadLine();
//
        //                if( int.TryParse(timestocompletegoal, out int timesnumbergoal))
        ////s        tring timeinsec1 = "";
        //               {checklistgoal checklistgoal1 = new checklistgoal();
        //                checklistgoal1.Setnameofgoal(goalName);
        //                checklistgoal1.Setdescription(goalDescription);
        //                checklistgoal1.Setpointtodisplay(pointInNumber);
        //                checklistgoal1.Settimesforgoal(timesnumbergoal);
        //     
        //               // Console.WriteLine(simplegoal1.DisplayStartingMessage());
        //                //Console.WriteLine(simplegoal1.Displayendingmessage());
        //     
        ////              Convert the string to an integer
        //                goalManager.AddGoalDetails(checklistgoal1.GetStringRepresentation());
        //                 }
        //                 else
        //                 {
        //                     Console.WriteLine("Invalid input for times. Please enter a valid number.");
        //                 }
        //                }
        //            else
        //                 {
        //                     Console.WriteLine("Invalid input for points. Please enter a valid number.");
        //                 }
        //                
        //                }
//       //
         //       else 
         //       {
         //           Console.WriteLine("Place a valid number.");
         //       }     
         //   }
        // Display the collected list of goals
       // goalManager.DisplayGoalList();
    }
}
