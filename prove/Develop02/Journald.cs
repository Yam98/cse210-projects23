using System;


class Journal
{
    static string JournalFile = "MyJournal.txt";
    static void Main(string[] args)
    {
        //bool finished = false;
        //int number  = int.Parse(Console.ReadLine());
        //while ( number != 5)
        //do {  //math} 
        //do-while( number != "5" ); //math and comes from do
        //Console.Write("What would you like to do?");
        //int number = int.Parse(Console.ReadLine());
        //return number;
        Save();
        Load();
        Menu();

        
    }

    static void Menu()
    {
        Console.Clear();
        Console.WriteLine("");
        Console.WriteLine("Welcome to the Journal Program");
        Console.WriteLine("Please select one of the following choices.");
        Console.WriteLine("");
        Console.WriteLine("1 Write");
        Console.WriteLine("2 Display");
        Console.WriteLine("3 Load");
        Console.WriteLine("4 Save");
        Console.WriteLine("5 Quit");
        Console.WriteLine("");

        Console.Write("What would you like to do?");
        string number = Console.ReadLine(); 
        //int number = int.Parse(Console.ReadLine());
        switch (number)
        {
            case "1": 
                Write();
                break;
            case "2":
                Display();
                break;
            case "3":
                Load();
                break;
            case "4":
                Save();
                break;
            //case "5":
                //Quit();
                //break;
            default:
                break;
        }
       
        Menu();
            //int numer = number;
            //int result = 0;//math 
            //else if (number == 5)
            //{Environment.Exit(0);}Console.Clear();//math
    }

    static void Write()
    {
        Prompt prompt1 = new Prompt(); 
        prompt1.Display();
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();

        
        
        String newLine = Console.ReadLine();
        File.AppendAllText(JournalFile, $"\nEntry: \n> {newLine}");
        //if ( number == 1 )
        //    {prompt1.Display(); DateTime theCurrentTime = DateTime.Now; string dateText = theCurrentTime.ToShortDateString(); int text = int.Parse(Console.ReadLine());}
    }
    static void Display()
    {
        String JournalText = File.ReadAllText(JournalFile);
        Console.WriteLine(JournalText);
        //Console.WriteLine("hi2");
        //Console.ReadLine();
        
        //Console.WaitForkey();
    }
    static void Load()
    {
        //Console.WriteLine("hi3");
        //Console.ReadLine();
        String JournalText = File.ReadAllText(JournalFile);
        Console.WriteLine("\n===Journal===");
        Console.WriteLine(JournalText);
        Console.WriteLine("\n=============");
    }

    static void Save()
    {
        //onsole.WriteLine("hi4");
        //Console.ReadLine();
        if (!File.Exists(JournalFile))
        {
            File.CreateText(JournalFile);
        }
    }
    
}

