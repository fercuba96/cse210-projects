public class goalmanager 

{
   // private List<string> goalList = new List<string>();

    private List<Goal> goalList = new List<Goal>();

    public void AddGoalDetails(string goalDetails)
    {
        goalList.Add(goalDetails);
    }

    public void DisplayGoalList()
    {
        Console.WriteLine("List of goals:");
        for (int i = 0; i < goalList.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goalList[i]}");
        }
    }
    

    public void ChosetoRecord()
    {
       Console.WriteLine("Choose which Goal to Complete: ");
       DisplayGoalList();
       if (int.TryParse(Console.ReadLine(), out int Goalnumbertochange))
       {
        RecordEvents(Goalnumbertochange);
       }
       else{
         Console.WriteLine("Enter a valid number.");
       }

    }

    public void RecordEvents(int index)
    {
        if (index >= 1 && index <= goalList.Count)
        {               
            Goal goalToUpdate = goalList[index - 1];

            // Assuming Goal class has a method to mark it as completed
            goalToUpdate.MarkAsCompleted();

            Console.WriteLine($"Goal at index {index} updated successfully.");
        }
        else
        {
            Console.WriteLine("Invalid index. Please enter a valid number within the range of the goal list.");
        }
    }

    public void Setgoal()
    {
        Console.WriteLine("Enter your goals. Type 'exit' to finish.");

        while (true)
        { 
            Console.Write("Enter exit to close program\nOr Enter a kind of goal name: \n1.Simple goal\n2.Eternal Goal\n3.ListGoal\n\n");
            string Kindofgoal = Console.ReadLine();
            if (Kindofgoal.ToLower() == "exit")
                        break;
        
            if (int.TryParse(Kindofgoal, out int Kindofgoalnumber))
            {

               if (Kindofgoalnumber == 1)
                  {      
                    Console.Write("Enter a name for goal: ");           
                    string goalName = Console.ReadLine();
        
                    
                    Console.Write("Enter the goal description: ");
                    string goalDescription = Console.ReadLine();
        
                    Console.Write("Enter the points for the goal: ");
                    string pointForGoal = Console.ReadLine();
        
                    // Convert the string to an integer
                    if (int.TryParse(pointForGoal, out int pointInNumber))
                    {
        //s        tring timeinsec1 = "";
                   simplegoalclass simplegoal1 = new simplegoalclass();
                   simplegoal1.Setnameofgoal(goalName);
                   simplegoal1.Setdescription(goalDescription);
                   simplegoal1.Setpointtodisplay(pointInNumber);
        
                   //Console.WriteLine(simplegoal1.DisplayStartingMessage());
                   //Console.WriteLine(simplegoal1.Displayendingmessage());
        
        //         Convert the string to an integer
                   AddGoalDetails(simplegoal1.GetStringRepresentation());
                    }
                    else
                    {
                        Console.WriteLine("Invalid input for points. Please enter a valid number.");
                    }
                   }   
                if (Kindofgoalnumber == 2)
                  {      
                    Console.Write("Enter a name for goal: ");           
                    string goalName = Console.ReadLine();
        
                    
                    Console.Write("Enter the goal description: ");
                    string goalDescription = Console.ReadLine();
        
                    Console.Write("Enter the points for the goal: ");
                    string pointForGoal = Console.ReadLine();
        
                    // Convert the string to an integer
                    if (int.TryParse(pointForGoal, out int pointInNumber))
                    {
        //s        tring timeinsec1 = "";
                   eternalgoalclass eternalgoal1 = new eternalgoalclass();
                   eternalgoal1.Setnameofgoal(goalName);
                   eternalgoal1.Setdescription(goalDescription);
                   eternalgoal1.Setpointtodisplay(pointInNumber);
        
                  // Console.WriteLine(simplegoal1.DisplayStartingMessage());
                   //Console.WriteLine(simplegoal1.Displayendingmessage());
        
        //         Convert the string to an integer
                   AddGoalDetails(eternalgoal1.GetStringRepresentation());
                    }
                    else
                    {
                        Console.WriteLine("Invalid input for points. Please enter a valid number.");
                    }
                   }

                   if (Kindofgoalnumber == 3)
                  {      
                    Console.Write("Enter a name for goal: ");           
                    string goalName = Console.ReadLine();
        
                    
                    Console.Write("Enter the goal description: ");
                    string goalDescription = Console.ReadLine();
        
                    Console.Write("Enter the points for the goal: ");
                    string pointForGoal = Console.ReadLine();
                    
                    
                    // Convert the string to an integer
                    if (int.TryParse(pointForGoal, out int pointInNumber))  
                    {
                        Console.Write("Enter the times to complete goal: ");
                        string timestocompletegoal = Console.ReadLine();

                        if( int.TryParse(timestocompletegoal, out int timesnumbergoal))
        //s        tring timeinsec1 = "";
                       {checklistgoal checklistgoal1 = new checklistgoal();
                        checklistgoal1.Setnameofgoal(goalName);
                        checklistgoal1.Setdescription(goalDescription);
                        checklistgoal1.Setpointtodisplay(pointInNumber);
                        checklistgoal1.Settimesforgoal(timesnumbergoal);
             
                       // Console.WriteLine(simplegoal1.DisplayStartingMessage());
                        //Console.WriteLine(simplegoal1.Displayendingmessage());
             
        //              Convert the string to an integer
                         AddGoalDetails(checklistgoal1.GetStringRepresentation());
                         }
                         else
                         {
                             Console.WriteLine("Invalid input for times. Please enter a valid number.");
                         }
                        }
                    else
                         {
                             Console.WriteLine("Invalid input for points. Please enter a valid number.");
                         }
                        
                        }

                else 
                {
                    Console.WriteLine("Place a valid number.");
                }     
            }
    }
    }
}