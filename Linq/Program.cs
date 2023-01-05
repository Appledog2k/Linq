using Linq;

internal class Program
{
    private static void Main(string[] args)
    {
        // Aggregate Functions
        Linq.AggregateFunc.AggregateFuncSum();

        // OrderBy Operators
        Console.WriteLine("----------------------------------------------------------------");
        List<Student> ObjStudent = new List<Student>(){
        new Student() { Id=1,Name = "Suresh Dasari", Gender = "Male", Subjects = new List<string> { "Mathematics", "Physics" },Age = 13 },
        new Student() {Id=2, Name = "Rohini Alavala", Gender = "Female", Subjects = new List<string> { "Entomology", "Botany" },Age = 17 },
        new Student() { Id=3,Name = "Praveen Kumar", Gender = "Male", Subjects = new List<string> { "Computers", "Operating System", "Java" } ,Age = 14},
        new Student() { Id=4,Name = "Sateesh Chandra", Gender = "Male", Subjects = new List<string> { "English", "Social Studies", "Chemistry" },Age = 13 },
        new Student() {Id=5, Name = "Madhav Sai", Gender = "Male", Subjects = new List<string> { "Accounting", "Charted" } ,Age = 19}
        };
        var studentNames = ObjStudent.OrderBy(x => x.Name).ToList();
        foreach (var student in studentNames)
        {
            Console.WriteLine(student.Name);
        }
        Console.WriteLine("----------------------------------------------------------------");
        var studentNames1 = ObjStudent.OrderByDescending(x => x.Name).ToList();
        foreach (var student in studentNames1)
        {
            Console.WriteLine(student.Name);
        }
        Console.WriteLine("----------------------------------------------------------------");
        // ThenBy được sử dụng cùng OrderBy để sắp xếp trên nhiều trường trong tập dữ liệu
        var studentNames2 = ObjStudent.OrderBy(x => x.Name).ThenBy(x => x.Id).ToList();
        foreach (var student in studentNames2)
        {
            Console.WriteLine(student.Name + " " + student.Id);
        }
        Console.WriteLine("----------------------------------------------------------------");
    }

}