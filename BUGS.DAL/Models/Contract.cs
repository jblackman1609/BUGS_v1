namespace BUGS.DAL.Models;

public class Contract
{
    public required string Id { get; set; }
    public Customer Customer { get; set; } = new();
    public string PropertyType { get; set; } = string.Empty;
    public string StreetAddress { get; set; } = string.Empty;
    public string City { get; set; } = string.Empty;
    public string State { get; set; } = string.Empty;
    public string ZipCode { get; set; } = string.Empty;
    public string BondType { get; set; } = string.Empty;
    public DateTime EffectiveDate { get; set; }
    public DateTime ContractEndDate { get; set; }
    public DateTime TimeStamp { get; set; }
}