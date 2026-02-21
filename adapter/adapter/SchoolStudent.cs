namespace adapter;

public class SchoolStudent
{
    private string firstname;
    private string lastname;
    private string emailAddress;


    public SchoolStudent(string firstname, string lastname, string emailAddress)
    {
        this.firstname = firstname;
        this.lastname = lastname;
        this.emailAddress = emailAddress;
    }
    
    public  string GetFirstname()
    {
        return firstname;
    }

    public string GetLastname() => lastname;
    
    public string GetEmail() => emailAddress;
   

}