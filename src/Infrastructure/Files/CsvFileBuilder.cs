using System.Globalization;
using SupplyChainManager.Application.Common.Interfaces;
using SupplyChainManager.Application.TodoLists.Queries.ExportTodos;
using SupplyChainManager.Infrastructure.Files.Maps;
using CsvHelper;

namespace SupplyChainManager.Infrastructure.Files;

public class CsvFileBuilder : ICsvFileBuilder
{
    public byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records)
    {
        using var memoryStream = new MemoryStream();
        using (var streamWriter = new StreamWriter(memoryStream))
        {
            using var csvWriter = new CsvWriter(streamWriter, CultureInfo.InvariantCulture);

            csvWriter.Configuration.RegisterClassMap<TodoItemRecordMap>();
            csvWriter.WriteRecords(records);
        }

        return memoryStream.ToArray();
    }
}
