using SupplyChainManager.Domain.Common;

namespace SupplyChainManager.Application.Common.Interfaces;

public interface IDomainEventService
{
    Task Publish(DomainEvent domainEvent);
}
