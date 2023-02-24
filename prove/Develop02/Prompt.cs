using System;

public class Prompt
{
    public void Display()
    {
        var r = new Random();
        //string[] mylist = new string {

        //List<String> myList = new List<string>();

        var myList = new List<string>
        {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
        };
        //Random list = new Random ();
        
        
        int index = r.Next(myList.Count);
        Console.WriteLine(myList[index]);
        
        


    }
    
    /*public void Display()
    {
        
    }*/
    

    
}