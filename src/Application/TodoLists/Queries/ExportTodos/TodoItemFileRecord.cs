using aspnetcore_domicile.Application.Common.Mappings;
using aspnetcore_domicile.Domain.Entities;

namespace aspnetcore_domicile.Application.TodoLists.Queries.ExportTodos;

public class TodoItemRecord : IMapFrom<TodoItem>
{
    public string? Title { get; set; }

    public bool Done { get; set; }
}
