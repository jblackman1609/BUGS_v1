using BUGS.DAL.Models;

namespace BUGS.DAL.Repositories;

public interface IContractRepository
{
    Task<List<Contract>> GetContractsAsync();
    Task AddAsync(Contract contract);
}