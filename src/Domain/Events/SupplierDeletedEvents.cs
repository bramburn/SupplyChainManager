namespace SupplyChainManager.Domain.Events;

public class SupplierDeletedEvent : DomainEvent
{
    public SupplierDeletedEvent(Supplier supplier)
    {
        Supplier = supplier;
    }

    public Supplier Supplier { get; }
}
