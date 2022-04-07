using SupplyChainManager.Application.Common.Mappings;
using SupplyChainManager.Domain.Entities;

namespace SupplyChainManager.Application.TodoLists.Queries.ExportTodos;

public class TodoItemRecord : IMapFrom<TodoItem>
{
    public string? Title { get; set; }

    public bool Done { get; set; }
}
