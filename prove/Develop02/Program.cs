class Program
{
    static void Main(string[] args)
    {   
        Journal journal = new Journal();

        char choice = '0';


        while ( choice != '5')

        {

        Console.WriteLine("The options are:  ");
        Console.WriteLine("1. Write ");
        Console.WriteLine("2. Display ");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");

        choice =Console.ReadKey().KeyChar;
        Console.WriteLine();

        switch (choice)

           {
            case '1':
                 journal.AddEntry();
                 break;
            case '2':
                 journal.PrintEntries();
                 break;

            case '5':
                 Console.WriteLine ("Press any key to quit.");
                 break;
             }
         Console.ReadKey();
          }

    }
}