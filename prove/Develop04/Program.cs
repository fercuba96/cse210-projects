using System;

class Program
{
    static void Main(string[] args)
    {
       Displayact Displayact3 = new Displayact();

        char choice = '0';


        while ( choice != '4')

        {

        Console.WriteLine("The options are:  ");
        Console.WriteLine("1. Breath ");
        Console.WriteLine("2. Reflect ");
        Console.WriteLine("3. list");
        Console.WriteLine("4. quit");

        choice =Console.ReadKey().KeyChar;
        Console.WriteLine();

        switch (choice)

           {
            case '1':
                 Displayact3.Breathingacttodisplay();
                 break;
            case '2':
                 Displayact3.Reflectingacttodisplay();
                 break;
            case '3':
                 Displayact3.Listingactivitytodisplay(); 
                 break;
            case '4':
                 Console.WriteLine ("Press any key to quit.");
                 break;
             }
         Console.ReadKey();
          } 
       }
}