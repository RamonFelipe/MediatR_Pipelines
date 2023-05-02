namespace MediatR.Pipelines.Presentation.Models;

public class OrderItem
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int Amount { get; set; }
}