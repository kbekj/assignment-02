namespace Assignment2.Tests;

using System;
using Students;

public class StudentTest
{
    [Fact]
    public void New()
    {
        //Arrange
        var student = new Student(1, "jhon", "sturden", new DateTime(2022, 12, 4), new DateTime(2024, 12, 4),
            new DateTime(2024, 12, 4));

        //Assert
        student.Status.Should().Be(Status.New);
    }
    
    [Fact]
    public void Active()
    {
        //Arrange
        var student = new Student(1,"jhon", "sturden", new DateTime(2021, 10,4), new DateTime(2025,4,1), new DateTime(2025,4,1));

        //Assert
        student.Status.Should().Be(Status.Active);
    }
    [Fact]
    public void Graduated()
    {
        //Arrange
        var student = new Student(1,"jhon", "sturden", new DateTime(2019,5,5), new DateTime(2022,5,5), new DateTime(2022,5,5));

        //Assert
        student.Status.Should().Be(Status.Graduated);
    }
    [Fact]
    public void Dropout()
    {
        //Arrange
        var student = new Student(1,"jhon", "sturden", new DateTime(2019,5,5), new DateTime(2020,5,5), new DateTime(2022,5,5));

        //Assert
        student.Status.Should().Be(Status.Dropout);
    }

    [Fact]
    public void Immutable_Student_Status()
    {
        //Arrange
        var student = new ImmutableStudent(1, "john", "sturden", new DateTime(2021, 10, 4), new DateTime(2025, 4, 1),
            new DateTime(2025, 4, 1), Status.Active);
        //Assert
        student.Status.Should().Be(Status.Active);
        


    }
    
    [Fact]
    public void Immutable_Student_Name()
    {
        //Arrange
        var student = new ImmutableStudent(1, "john", "sturden", new DateTime(2021, 10, 4), new DateTime(2025, 4, 1),
            new DateTime(2025, 4, 1), Status.Active);
        //Assert
        student.GivenName.Should().Be("john");

    }
    
    [Fact]
    public void Immutable_Student_ToString()
    {
        //Arrange
        var student = new ImmutableStudent(1, "Billie", "Jean", new DateTime(2021, 10, 4), new DateTime(2025, 4, 1),
            new DateTime(2025, 4, 1), Status.Active);
        //Assert
        student.ToString().Should()
            .BeOneOf(
                "ImmutableStudent { Id = 1, GivenName = Billie, Surname = Jean, StartDate = 04/10/2021 00.00.00, EndDate = 01/04/2025 00.00.00, GraduationDate = 01/04/2025 00.00.00, Status = Active }","ImmutableStudent { Id = 1, GivenName = Billie, Surname = Jean, StartDate = 10/04/2021 00:00:00, EndDate = 04/01/2025 00:00:00, GraduationDate = 04/01/2025 00:00:00, Status = Active }");
        //Use of beOneOf is because github is using american time format (MM/DD/YY), where as I recieve european (DD/MM/YY) on my PC.
    }
}