using System.Globalization;
using SupplyChainManager.Application.TodoLists.Queries.ExportTodos;
using CsvHelper.Configuration;

namespace SupplyChainManager.Infrastructure.Files.Maps;

public class TodoItemRecordMap : ClassMap<TodoItemRecord>
{
    public TodoItemRecordMap()
    {
        AutoMap(CultureInfo.InvariantCulture);

        Map(m => m.Done).ConvertUsing(c => c.Done ? "Yes" : "No");
    }
}
