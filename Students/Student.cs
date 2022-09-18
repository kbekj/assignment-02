namespace Students;

using System;

public class Student
{
    private int id { get;init; }
    private string GivenName{get; set;}
    private string surname{get; set;} = "";
    public Status status {get;}
    private DateTime startDate{get; set;}
    private DateTime endDate{get; set;}
    private DateTime graduationDate { get; set;}

    public Student(int id, string GivenName, string surname, DateTime startDate, DateTime endDate, DateTime graduationDate){
        this.id = id;
        this.GivenName = GivenName;
        this.startDate = startDate;
        this.endDate = endDate;
        this.graduationDate = graduationDate;
        this.status = CalculateStatus();
    }

private Status CalculateStatus(){
        if (startDate.Year == DateTime.Now.Year )
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