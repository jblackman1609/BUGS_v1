using BUGS.DAL.Models;
using BUGS.BLL.ValueObjects;

namespace BUGS.BLL.ViewModels;

public class ContractViewModel
{
    public List<Contract> Contracts { get; set; } = new();
}