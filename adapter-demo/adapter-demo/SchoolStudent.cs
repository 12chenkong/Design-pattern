namespace adapter_demo;

public class SchoolStudent : Student
{
    
    string firstName;
    string lastName;
    string age;

    public SchoolStudent(string firstName,string lastName,string age)
    {

        this.lastName = lastName;
        this.firstName = firstName;
        this.age = age;
    }


    public string getFirstName()
    {
        return this.firstName;
    }

    public string getAge()
    {
        return this.age;
    }

    public string getLastName()
    {
        return this.lastName;
    }
}