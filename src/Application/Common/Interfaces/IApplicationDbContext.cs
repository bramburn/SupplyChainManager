using SupplyChainManager.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace SupplyChainManager.Application.Common.Interfaces;

public interface IApplicationDbContext
{
    DbSet<TodoList> TodoLists { get; }

    DbSet<TodoItem> TodoItems { get; }

    DbSet<Domain.Entities.Supplier> Suppliers { get; }
    DbSet<Address> Addresses { get; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}