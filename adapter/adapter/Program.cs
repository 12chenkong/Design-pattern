// See https://aka.ms/new-console-template for more information

using adapter;

public class Program
{
    public static void Main(string[] args)
    {
        StudentClient client = new StudentClient();
        
       List<Student>students= client.GetStudentList();
       foreach (var VARIABLE in students)
       {
           Console.WriteLine(VARIABLE.GetName());
           
       }
        
    }
}