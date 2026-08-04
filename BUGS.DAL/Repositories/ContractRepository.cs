using BUGS.DAL.Contexts;
using BUGS.DAL.Repositories;
using Microsoft.EntityFrameworkCore;

namespace BUGS.DAL.Models;

public class ContractRepository : IContractRepository
{
    private readonly BUGSDbContext _context;

    public ContractRepository(BUGSDbContext context) => _context = context;

    public async Task AddAsync(Contract contract)
    {
        await _context.Contracts.AddAsync(contract);
        await _context.SaveChangesAsync();
    }

    public async Task<List<Contract>> GetContractsAsync()
    {
        return await _context.Contracts.AsNoTracking().ToListAsync();
    }
}