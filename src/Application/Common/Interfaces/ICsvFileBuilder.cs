using aspnetcore_domicile.Application.TodoLists.Queries.ExportTodos;

namespace aspnetcore_domicile.Application.Common.Interfaces;

public interface ICsvFileBuilder
{
    byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
}
