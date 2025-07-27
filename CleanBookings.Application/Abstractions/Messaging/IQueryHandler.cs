using CleanBookings.Domain.Abstractions;

using MediatR;

namespace CleanBookings.Application.Abstractions.Messaging;

public interface IQueryHandler<TQuery, TResponse> : IRequestHandler<TQuery, Result<TResponse>>
    where TQuery : IQuery<TResponse>
{
}
