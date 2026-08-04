using BUGS.BLL.ValueObjects;

namespace BUGS.BLL.ViewModels;

public class ContractViewModel
{
    public Header? header { get; set; }
    public string? BondStatement { get; set; }
    public string? CustomerName { get; set; }
    public string? CustomerPhone { get; set; }
    public string? CustomerEmail { get; set; }
    public Address? CustomerAddress { get; set; }
    public Address? PropertyAddress { get; set; }
    public DateTime EffectiveDate { get; set; }
    public DateTime ContractEndDate { get; set; }
    public string? ContractPrice { get; set; }
    public string? RenewalFee { get; set; }
    public ContractStatus Status { get; set; }
    public string? BondType { get; set; }
    public ContractType Type { get; set; }
    public string? ContractBody { get; set; }
    public string? LicenseNumber { get; set; }
}