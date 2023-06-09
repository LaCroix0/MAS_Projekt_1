namespace MAS_MP1;

public class Data
{
    
    public static void createStudents()
    {
        Department d1 = new()
        {
            Name = "Informatyki",
            StudentCapacity = 300,
            Address = new Address("02-008", "Koszykowa", 86, "Warszawa")
        };

        Department d2 = new()
        {
            Name = "Inżynierii procesów",
            StudentCapacity = 200,
            Address = new Address("00-661", "plac Politechniki", 1, "Warszawa")
        };
        
        Student s1 = new Student
        {
            FirstName = "Paweł",
            LastName = "Kowalski",
            Address = new Address("00-000", "Kasztanowa", 13, "Kobyłka"),
            Department = d1
            
        };
        
        Student s2 = new Student
        {
            FirstName = "Gaweł",
            LastName = "Nowak",
            Address = new Address("00-001", "Nowogrodzka", 9, 2,"Warszawa"),
            Department = d2
        };

        Console.WriteLine("==================");
        Console.WriteLine("Studenci Stworzeni");
        Console.WriteLine("==================");
        Console.WriteLine();
    }
}