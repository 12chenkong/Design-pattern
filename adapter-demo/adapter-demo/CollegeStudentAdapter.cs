namespace adapter_demo;

public class CollegeStudentAdapter : Student
{

    public CollegeStudent Student;

    public CollegeStudentAdapter(CollegeStudent student)
    {
        this.Student = student;
    }

    public string getFirstName()
    {
        return Student.FirstName;
    }

    public string getLastName()
    {
        return Student.LastName;
    }

    public string getAge()
    {
        return Student.Age;
    }
}