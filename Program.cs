using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;
using MAS_MP1;

int input = 0;
while (input != 6)
{
        Console.WriteLine("1) stwórz studentów");
        Console.WriteLine("2) pokaż wydziały");
        Console.WriteLine("3) pokaż studentów");
        Console.WriteLine("4) serializacja");
        Console.WriteLine("5) deserializacja");
        Console.WriteLine("6) koniec");
        input = Convert.ToInt32(Console.ReadLine());
        switch (input)
        {
            case 1:
                Data.createStudents();
                break;
            case 2:
                Department.show();
                break;
            case 3:
                Student.show();
                break;
            case 4:
                serializeObjects();
                break;
            case 5:
                deserializeObjects();
                break;
            case 6:
                break;
            
        }
}

    
static void serializeObjects()
{
    var options = new JsonSerializerOptions
    {
        WriteIndented = true,
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        Encoder = JavaScriptEncoder.Create(UnicodeRanges.All)
    };
    File.WriteAllText(@"C:\MAS_Projekt_1\json.json", JsonSerializer.Serialize(Student._StudExtent, options));
    
    Console.WriteLine("==================");
    Console.WriteLine("Serializacja udana");
    Console.WriteLine("==================");
    Console.WriteLine();
}

static void deserializeObjects()
{
    var options = new JsonSerializerOptions
    {
        WriteIndented = true,
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        Encoder = JavaScriptEncoder.Create(UnicodeRanges.All)
    };
    JsonSerializer.Deserialize<List<Student>>(File.ReadAllText(@"C:\MAS_Projekt_1\json.json"), options);
    
    Console.WriteLine("==================");
    Console.WriteLine("Deserializacja udana");
    Console.WriteLine("==================");
    Console.WriteLine();
}





