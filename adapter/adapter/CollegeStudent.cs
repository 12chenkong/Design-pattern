namespace adapter;

public class CollegeStudent : Student
{
    private string name;
    private string surname;
    private string email;

    public CollegeStudent(string name, string surname, string email)
    {
        this.name = name;
        this.surname=surname;
        this.email = email;
    }
    
    
    public string GetName()
    {
        return name;
    }

    public string GetSureame()
    {
        return surname;
    }

    public string GetEmail()
    {
        return email;
    }
}