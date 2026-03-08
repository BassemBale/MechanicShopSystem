using MechanicShop.Domain.Common;
using MechanicShop.Domain.WorkOrders.Enum;

namespace MechanicShop.Domain.WorkOrders;

public sealed class WorkOrder : AuditableEntity
{
    public Guid VehicleId { get; private set; }
    public DateTimeOffset StartAtUtc { get; private set; }
    public DateTimeOffset EndAtUtc { get; private set; }
    public Guid LaborId { get; private set; }
    public Spot Spot { get; private set; }
    public WorkOrderState State { get; private set; }

}
