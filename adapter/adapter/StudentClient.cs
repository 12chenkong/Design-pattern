using System.Collections;

namespace adapter;

public class StudentClient
{
   public List<Student> GetStudentList()
   {
      List<Student> students = new List<Student>();
      students.Add(new CollegeStudent("Chan","kong","123@gmail.com"));
      
      students.Add(new SchoolStudentAdapter(new SchoolStudent("Khim","Limh","123@gmail.com")));
      return students;
   }
}