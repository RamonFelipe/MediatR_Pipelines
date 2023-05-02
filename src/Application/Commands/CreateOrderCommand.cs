using FluentResults;

namespace MediatR.Pipelines.Application.Commands;

public class CreateOrderCommand : IRequest<Result>
{
    public Guid Id { get; set; }
}