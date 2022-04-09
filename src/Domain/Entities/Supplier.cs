namespace SupplyChainManager.Domain.Entities;

public class Supplier : AuditableEntity
{

  
    public int Id { get; set; }

    public string? CompanyCode { get; set; }

    public string? CompanyName { get; set; }


    public int? AddressId { get; set; }
    public Address? Address { get; set; }

    public string? ContactPerson { get; set; }
    public string? ContactNumber { get; set; }

    public DateTime Joined { get; set; }

    public bool Approved { get; set; }


}