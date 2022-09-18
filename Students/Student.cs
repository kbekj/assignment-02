namespace Students;

using System;

public class Student
{
    public int Id { get;init; }
    public string GivenName{get; set;}
    public string Surname{get; set;}
    
    public Status Status { get; }
    public DateTime StartDate{get; set;}
    public DateTime EndDate{get; set;}
    public DateTime GraduationDate { get; set;}

  
    public Student(int id, string givenName, string surname, DateTime startDate, DateTime endDate, DateTime graduationDate)
    {
        this.Id = id;
        this.GivenName = givenName;
        this.Surname = surname;
        this.StartDate = startDate;
        this.EndDate = endDate;
        this.GraduationDate = graduationDate;
        this.Status = CalculateStatus();
        
    }

private Status CalculateStatus(){
        if (StartDate.Year == DateTime.Now.Year )
        {
            return Status.New;
        } if (EndDate < GraduationDate)
        {
            return Status.Dropout;
        } if (GraduationDate < DateTime.Now)
        {
            return Status.Graduated;
        }
        return Status.Active;         
    }  

    public override string ToString()
    {
        return $"ID: {Id}, Full name: {GivenName} {Surname}, Status: {Status}";
    }
    
}