using System;

public enum Gender
{
    Male,
    Female
}

[Serializable]
public class Child
{
    public string Name { get; set; }
    public int Age { get; set; }
    public Gender Gender { get; set; }
    public DateTime EnrollmentDate { get; set; }
    public int GroupNumber { get; set; }

    public Child(string name, int age, Gender gender, DateTime enrollmentDate, int groupNumber)
    {
        Name = name;
        Age = age;
        Gender = gender;
        EnrollmentDate = enrollmentDate;
        GroupNumber = groupNumber;
    }

    public override string ToString()
    {
        return $"{Name}, {Age} years old, {Gender}, Group {GroupNumber}, Enrolled on {EnrollmentDate.ToShortDateString()}";
    }
}
