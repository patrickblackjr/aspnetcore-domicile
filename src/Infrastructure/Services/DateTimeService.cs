using aspnetcore_domicile.Application.Common.Interfaces;

namespace aspnetcore_domicile.Infrastructure.Services;

public class DateTimeService : IDateTime
{
    public DateTime Now => DateTime.Now;
}
