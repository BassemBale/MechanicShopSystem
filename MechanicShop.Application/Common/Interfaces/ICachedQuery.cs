using MediatR;

namespace MechanicShop.Application.Common.Interfaces;

public interface ICachedQuery
{
    string Cachekey { get; }
    string[] Tags { get; }
    TimeSpan Expiration { get; }

}
public interface ICachedQuery<TRequest> : IRequest<TRequest>, ICachedQuery;