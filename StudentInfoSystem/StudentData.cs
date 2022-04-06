using System.Collections.Generic;

namespace StudentInfoSystem;

public class StudentData
{
    public static List<Student> TestStudents { get; } = new()
    {
        new Student("Hristiyan", "Ivanov", "Skenderski", "FKST", "KSI", "Middle", "Assigned", "121219081", 6, 2, 30)
    };
}