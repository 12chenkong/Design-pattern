namespace adapter;

public class SchoolStudentAdapter: Student
{
    private SchoolStudent schoolStudent;

    public SchoolStudentAdapter(SchoolStudent schoolStudent)
    {
        this.schoolStudent = schoolStudent;
    }


    public string GetName() => schoolStudent.GetFirstname();
    public string GetSureame() => schoolStudent.GetLastname();
    public string GetEmail()=>schoolStudent.GetEmail();
}