using System;
public class Job
{
    //Create the member variable 
    public string _jobTitle;
    public string _company;
    public int _startYear;
    public int _endYear;
//this hpw to connect to teh main
//By convention, this method should begin with a capital letter, such as Display,
//multiple words each word should be capitalized, such as DisplayJobDetails
    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
    //public string _Airport_attendant = "";

    /*public string _Nurse_assistant = "";
    public string _Coustumer_service = "";
    public string _Call_center_agent = "";
    public string _Airport_attendant = "";*/
}