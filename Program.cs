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
    var serialize = JsonSerializer.Serialize(Student._StudExtent, options) ;
    File.WriteAllText(@"C:\\MAS_Projekt_1\\MAS_Projekt_1.csproj\\json.json", serialize);
}

static void deserializeObjects()
{
    var options = new JsonSerializerOptions
    {
        WriteIndented = true,
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        Encoder = JavaScriptEncoder.Create(UnicodeRanges.All)
    };
    var file = File.ReadAllText(@"C:\json.json");
    List<Student> deserialize = JsonSerializer.Deserialize<List<Student>>(file, options);
}





