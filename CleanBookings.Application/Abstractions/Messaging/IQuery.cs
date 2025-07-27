using CleanBookings.Domain.Abstractions;

using MediatR;

namespace CleanBookings.Application.Abstractions.Messaging;

public interface IQuery<TResponse> : IRequest<Result<TResponse>>
{
}
