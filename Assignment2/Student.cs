using System.Runtime.CompilerServices;

namespace Assignment2;

public class Student
{
    public int id { get;init; }
    private string GivenName;
    private string surname;
    private Status status;
    private DateTime startDate;
    private DateTime endDate;
    private DateTime graduationDate { get; }

    public Status getStatus()
    {
        if (graduationDate.Year - DateTime.Now.Year <= 2)
        {
            return Status.New;
        } if (endDate < graduationDate)
        {
            return Status.Dropout;
        } if (graduationDate < DateTime.Now)
        {
            return Status.Graduated;
        }
        return Status.Active;
        
        
    }

    public override string ToString()
    {
        return $"ID: {id}, Full name: {GivenName} {surname}, Status: {status}";
    }
}