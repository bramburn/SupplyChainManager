using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SupplyChainManager.Domain.Entities;

namespace SupplyChainManager.Infrastructure.Persistence.Configurations;

public class SupplierConfiguration : IEntityTypeConfiguration<Supplier>
{
    public void Configure(EntityTypeBuilder<Supplier> builder)
    {
        builder.Property(it => it.Approved).HasDefaultValue(false);

        //set up one to one relationship
        builder.HasOne<Address>(e => e.Address)
            .WithOne(e => e.Supplier)
            .HasForeignKey<Address>(e=>e.SupplierId);
    }
}