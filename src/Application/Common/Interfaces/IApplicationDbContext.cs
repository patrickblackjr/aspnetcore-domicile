using aspnetcore_domicile.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace aspnetcore_domicile.Application.Common.Interfaces;

public interface IApplicationDbContext
{
    DbSet<TodoList> TodoLists { get; }

    DbSet<TodoItem> TodoItems { get; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}
