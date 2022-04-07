using SupplyChainManager.Application.Common.Interfaces;

namespace SupplyChainManager.Infrastructure.Services;

public class DateTimeService : IDateTime
{
    public DateTime Now => DateTime.Now;
}
