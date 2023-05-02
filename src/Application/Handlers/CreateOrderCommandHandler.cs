using FluentResults;
using MediatR.Pipelines.Application.Commands;

namespace MediatR.Pipelines.Application.Handlers;

public class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommand, Result>
{
    public Task<Result> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
    {
        if (request.Id.ToString() == "00000000-0000-0000-0000-000000000000")
        {
            return Task.Run(() => Result.Fail("Internal error"));
        }

        return Task.Run(() => Result.Ok());
    }
}