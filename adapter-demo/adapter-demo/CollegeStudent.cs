namespace adapter_demo;

public class CollegeStudent 
{
    string firstName;
    string lastName;
    string age;
    
    
    public CollegeStudent(string firstName,string lastName,string age)
    {
        this.lastName = lastName;
        this.firstName = firstName;
        this.age = age;
    }


    public string FirstName
    {
        get => firstName;
        set => firstName = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string LastName
    {
        get => lastName;
        set => lastName = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string Age
    {
        get => age;
        set => age = value ?? throw new ArgumentNullException(nameof(value));
    }
}