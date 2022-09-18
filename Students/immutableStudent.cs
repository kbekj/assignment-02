namespace Students;

public record ImmutableStudent(int Id, string GivenName, string Surname, DateTime StartDate, DateTime EndDate,
    DateTime GraduationDate, Status Status);