using System.Globalization;
using aspnetcore_domicile.Application.Common.Interfaces;
using aspnetcore_domicile.Application.TodoLists.Queries.ExportTodos;
using aspnetcore_domicile.Infrastructure.Files.Maps;
using CsvHelper;

namespace aspnetcore_domicile.Infrastructure.Files;

public class CsvFileBuilder : ICsvFileBuilder
{
    public byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records)
    {
        using var memoryStream = new MemoryStream();
        using (var streamWriter = new StreamWriter(memoryStream))
        {
            using var csvWriter = new CsvWriter(streamWriter, CultureInfo.InvariantCulture);

            csvWriter.Context.RegisterClassMap<TodoItemRecordMap>();
            csvWriter.WriteRecords(records);
        }

        return memoryStream.ToArray();
    }
}
