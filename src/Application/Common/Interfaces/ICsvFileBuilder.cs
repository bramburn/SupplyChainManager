using SupplyChainManager.Application.TodoLists.Queries.ExportTodos;

namespace SupplyChainManager.Application.Common.Interfaces;

public interface ICsvFileBuilder
{
    byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
}
