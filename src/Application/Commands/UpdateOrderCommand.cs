using FluentResults;

namespace MediatR.Pipelines.Application.Commands;

public class UpdateOrderCommand : IRequest<Result>
{
    public Guid Id { get; set; }
}