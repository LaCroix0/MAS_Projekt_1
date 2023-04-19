namespace MAS_MP1;


// To jest klasa czyli przykład obiektu złożonego
public class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public Address Address { get; set; } 
    public Department Department { get; set; }
    public static List<Student> _StudExtent = new();
    private static Random r = new();
    private Dictionary<string, int> grades = new()
    {
        {"PPJ", r.Next(2, 5)},
        {"TAK", r.Next(2, 5)},
        {"AM", r.Next(2, 5)}
    };
    
    private double mean
    {
        get
        {
            return Math.Round(grades.Average(t => t.Value), 2);
        }  
    }
    

    public Student()
    {
        _StudExtent.Add(this);
    }
    
    public static void show()
    {
        foreach (Student s in _StudExtent)
        {
            Console.WriteLine(s);
        }
    }

    public override string ToString()
    {
        return $"Imie i Nazwisko: {FirstName} {LastName}, Oceny:" +
               $"PPJ: {grades["PPJ"]}, " +
               $"TAK: {grades["TAK"]}, " +
               $"AM: {grades["AM"]} " +
               $"Mean: {mean}";
    }
}
