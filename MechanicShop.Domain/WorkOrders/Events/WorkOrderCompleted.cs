using MechanicShop.Domain.Common;

namespace MechanicShop.Domain.WorkOrders.Events;

public class WorkOrderCompleted : DomainEvents
{
    public Guid WorkOrderId { get; set; }
}
