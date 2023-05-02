using MediatR.Pipelines.Application.Commands;
using MediatR.Pipelines.Presentation.Models;
using Microsoft.AspNetCore.Mvc;

namespace MediatR.Pipelines.Presentation.Controllers;

[ApiController]
[Route("[controller]")]
public class OrdersController : ControllerBase
{
    private readonly IMediator _mediator;

    public OrdersController(IMediator mediator)
    {
        this._mediator = mediator;
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] Order order)
    {
        var command = new CreateOrderCommand { Id = order.Id };

        await this._mediator.Send(command);

        return Created("", command.Id);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] Order order)
    {
        var command = new UpdateOrderCommand { Id = order.Id };

        await this._mediator.Send(command);

        return NoContent();
    }
}