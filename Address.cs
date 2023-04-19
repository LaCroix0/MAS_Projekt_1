namespace MAS_MP1;

public class Address
{
    public static List<Address> extent = new();
    public string Street { get; set; }
    public int HouseNumber { get; set; }
    public int? FlatNumber { get; set; }
    public string City { get; set; }
    public string ZipCode { get; set; }
    public bool isFlat;

    // Obiekt address posiada pole flatNumber które jest obietem opcjonalnym
    public Address(string zipCode, string street, int houseNumber, int flatNumber, string city)
    {
        ZipCode = zipCode;
        Street = street;
        HouseNumber = houseNumber;
        FlatNumber = flatNumber;
        City = city;
        isFlat = true;
        
        extent.Add(this);
    }

    public Address(string zipCode, string street, int houseNumber, string city)
    {
        ZipCode = zipCode;
        Street = street;
        HouseNumber = houseNumber;
        City = city;
        isFlat = false;
        
        extent.Add(this);
    }

    public Address()
    {
        
    }

    public override string ToString()
    {
        if (isFlat)
        {
            return $"{Street}, {HouseNumber}/{FlatNumber}, {City} {ZipCode}";
            
        }
        
        return $"{Street}, {HouseNumber}, {City}, {ZipCode}";
    }
}