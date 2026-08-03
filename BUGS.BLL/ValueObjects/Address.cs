namespace BUGS.BLL.ValueObjects;

public class Address
{
    public string? StreetAddress { get; private set; }
    public string? City { get; private set; }
    public string State { get; private set; }
    public string? ZipCode { get; private set; }

    public Address(string street, string city, string zip)
    {
        StreetAddress = street;
        City = city;
        State = "Al";
        ZipCode = zip;
    }
}