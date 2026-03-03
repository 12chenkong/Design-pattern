// See https://aka.ms/new-console-template for more informat

using adapter_demo;

public class Program
{
    public static void Main(string[] args)
    {

        // container 
        List<Student> students = new List<Student>();
        
        SchoolStudent student = new SchoolStudent("Kong","chan","20");
        SchoolStudent student1 = new SchoolStudent("tola","saroth","20");
        
        CollegeStudentAdapter Adapter = new CollegeStudentAdapter(new CollegeStudent("Khim","heng","21") );
        
        students.Add(student);
        students.Add(student1);
        students.Add(Adapter);
        
        foreach (var stu in students)
        {
         
            Console.WriteLine(stu.getFirstName());
        }


    }
}