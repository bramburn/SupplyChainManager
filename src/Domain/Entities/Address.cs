using System.ComponentModel.DataAnnotations;

namespace SupplyChainManager.Domain.Entities;

public class Address : AuditableEntity
{
    public int Id { get; set; }

    public string? FirstLine { get; set; }
    public string? SecondLine { get; set; }
    public string? ThirdLine { get; set; }
    public string? PostCode { get; set; }
    public string? County { get; set; }
    public string? Country { get; set; }
    public Supplier Supplier { get; set; }
    public int SupplierId { get; set; }
    
}