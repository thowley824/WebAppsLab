using System;

public class Person
{
    public String FirstName { get; set; }
    public String LastName { get; set; }
    public DateTime Birthday { get; set; }
    public int Age
    {
        get
        {
            return DateTime.Now.Year - Birthday.Year;
        }

    }
}
