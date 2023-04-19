namespace MAS_MP1;

public class Department
{
    public Address Address { get; set; }
    public string Name { get; set; } 
    public int StudentCapacity { get; set; }
    public static List<Department> _DeptExtent = new();
    public static void show()
    {
        foreach (Department w in _DeptExtent)
        {
            Console.WriteLine(w);
        }
    }
    

    public Department()
    {
        _DeptExtent.Add(this);
    }

    public override string ToString()
    {
        return $"Wydział: {Name}, Adres: {Address}, Liczba miejsc: {StudentCapacity}";
    }
}