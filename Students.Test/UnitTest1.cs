namespace Students.Test;

using System;
public class StudentTest
{
    [Fact]
    public void New()
    {
        //Arrange
        var student = new Student(1,"jhon", "sturden", new DateTime(2022, 12, 4), new DateTime(2024, 12,4), new DateTime(2024,12,4));

        //Assert
        student.status.Should().Be(Status.New);
    }
    [Fact]
    public void Active()
    {
        //Arrange
        var student = new Student(1,"jhon", "sturden", new DateTime(2021, 10,4), new DateTime(2025,4,1), new DateTime(2025,4,1));

        //Assert
        student.status.Should().Be(Status.Active);
    }
    [Fact]
    public void Graduated()
    {
        //Arrange
        var student = new Student(1,"jhon", "sturden", new DateTime(2019,5,5), new DateTime(2022,5,5), new DateTime(2022,5,5));

        //Assert
        student.status.Should().Be(Status.Graduated);
    }
    [Fact]
    public void Dropout()
    {
        //Arrange
        var student = new Student(1,"jhon", "sturden", new DateTime(2019,5,5), new DateTime(2020,5,5), new DateTime(2022,5,5));

        //Assert
        student.status.Should().Be(Status.Dropout);
    }
}