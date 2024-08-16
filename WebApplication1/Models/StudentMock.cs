namespace WebApplication1.Models
{
    public class StudentMock
    {
        List<Student> students;

        public StudentMock()
        {
            students = new List<Student>();
            students.Add(new Student() { Id=1,Name="Ahmed",Address="NasrCty",Img="1.png"});
            students.Add(new Student() { Id = 2, Name = "Ali", Address = "Zamalak", Img = "2.png" });
            students.Add(new Student() { Id = 3, Name = "Aya", Address = "Giza", Img = "3.png" });
        }
        public List<Student> GetStudents()
        {
            return students;
        }

        public Student GetStudentbyId(int Id)
        {
            return students.FirstOrDefault(x=>x.Id==Id);
        }
    }
}
