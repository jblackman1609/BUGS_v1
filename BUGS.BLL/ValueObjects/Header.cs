namespace BUGS.BLL.ValueObjects;

public class Header
{
    public string CompanyName { get; private set; }
    public Address CompanyAddress { get; private set; }
    public string CompanyPhone { get; private set; }

    public Header(string name, Address address, string phone)
    {
        CompanyName = name;
        CompanyAddress = address;
        CompanyPhone = phone;
    }
}