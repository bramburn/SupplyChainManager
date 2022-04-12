namespace SupplyChainManager.Domain.Events;

public class SupplierCreatedEvent : DomainEvent
{
    public SupplierCreatedEvent(Supplier supplier)
    {
        Supplier = supplier;
    }

    public Supplier Supplier { get; }
}
