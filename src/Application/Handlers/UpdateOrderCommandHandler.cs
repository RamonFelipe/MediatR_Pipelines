using FluentResults;
using MediatR.Pipelines.Application.Commands;

namespace MediatR.Pipelines.Application.Handlers;

public class UpdateOrderCommandHandler : IRequestHandler<UpdateOrderCommand, Result>
{
    public Task<Result> Handle(UpdateOrderCommand request, CancellationToken cancellationToken)
    {
        // if (request.Id.ToString() == "00000000-0000-0000-0000-000000000000")
        // {
        //     return Task.Run(() => Result.Fail("Internal error"));
        // }

        return Task.Run(() => Result.Ok());
    }
}