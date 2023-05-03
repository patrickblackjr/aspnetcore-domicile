using aspnetcore_domicile.Application.Common.Mappings;
using aspnetcore_domicile.Domain.Entities;

namespace aspnetcore_domicile.Application.TodoItems.Queries.GetTodoItemsWithPagination;

public class TodoItemBriefDto : IMapFrom<TodoItem>
{
    public int Id { get; set; }

    public int ListId { get; set; }

    public string? Title { get; set; }

    public bool Done { get; set; }
}
