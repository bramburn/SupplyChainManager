using MediatR;
using SupplyChainManager.Application.Common.Interfaces;

namespace SupplyChainManager.Application.Supplier.Commands.CreateSupplier;

public class CreateSupplierCommand : IRequest<int>
{
    public int Id { get; set; }

    public string? CompanyCode { get; set; }

    public string? CompanyName { get; set; }
}

public class CreateSupplierCommandHandler : IRequestHandler<CreateSupplierCommand, int>
{
    private readonly IApplicationDbContext _context;

    public CreateSupplierCommandHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<int> Handle(CreateSupplierCommand request, CancellationToken cancellationToken)
    {
        var entity = new Domain.Entities.Supplier
        {
            LastModified = null,
            LastModifiedBy = null,
            CompanyCode = request.CompanyCode,
            CompanyName = request.CompanyName,
            AddressId = 0,
            Address = null,
            ContactPerson = null,
            ContactNumber = null,
            Joined = default,
            Approved = false
        };

        _context.Suppliers.Add(entity);
        await _context.SaveChangesAsync(cancellationToken);

        return entity.Id;
    }
}