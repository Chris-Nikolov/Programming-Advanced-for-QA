namespace T01_Stidents;

class Program
{
    static void Main(string[] args)
    {
        List<Student> students = new List<Student>();
        
       var n = int.Parse(Console.ReadLine());

       for (var i = 0; i < n; i++)
       {
           var studentInfo = Console.ReadLine().Split().ToArray();
           
           var firstName = studentInfo[0];
           var lastName = studentInfo[1];
           var grade = double.Parse(studentInfo[2]);
           
           Student currentStudent = new Student();
           currentStudent.FirstName = firstName;
           currentStudent.LastName = lastName;
           currentStudent.Grade = grade;
           students.Add(currentStudent);
       }
       
       foreach (var student in students.OrderByDescending(x => x.Grade))
       {
           Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade:F2}");}
    }
    
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }
        
    }
}
