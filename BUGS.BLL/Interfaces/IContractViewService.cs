using BUGS.BLL.ViewModels;

namespace BUGS.BLL.Interfaces;

public interface IContractViewService
{
    Task<ContractViewModel> GetContractViewModel();
}