using aspnetcore_domicile.Application.Common.Exceptions;
using aspnetcore_domicile.Application.TodoItems.Commands.CreateTodoItem;
using aspnetcore_domicile.Application.TodoItems.Commands.DeleteTodoItem;
using aspnetcore_domicile.Application.TodoLists.Commands.CreateTodoList;
using aspnetcore_domicile.Domain.Entities;
using FluentAssertions;
using NUnit.Framework;

namespace aspnetcore_domicile.Application.IntegrationTests.TodoItems.Commands;

using static Testing;

public class DeleteTodoItemTests : BaseTestFixture
{
    [Test]
    public async Task ShouldRequireValidTodoItemId()
    {
        var command = new DeleteTodoItemCommand(99);

        await FluentActions.Invoking(() =>
            SendAsync(command)).Should().ThrowAsync<NotFoundException>();
    }

    [Test]
    public async Task ShouldDeleteTodoItem()
    {
        var listId = await SendAsync(new CreateTodoListCommand
        {
            Title = "New List"
        });

        var itemId = await SendAsync(new CreateTodoItemCommand
        {
            ListId = listId,
            Title = "New Item"
        });

        await SendAsync(new DeleteTodoItemCommand(itemId));

        var item = await FindAsync<TodoItem>(itemId);

        item.Should().BeNull();
    }
}
