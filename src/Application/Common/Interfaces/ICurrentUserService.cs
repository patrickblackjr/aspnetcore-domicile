namespace aspnetcore_domicile.Application.Common.Interfaces;

public interface ICurrentUserService
{
    string? UserId { get; }
}
