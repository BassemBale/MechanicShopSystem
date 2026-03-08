using MechanicShop.Domain.Common.Results;

namespace MechanicShop.Domain.WorkOrders;

public class WorkOrderErrors
{
    public static Error WorkOrderIdRequired => Error.Validation(
        code:"WorkOrderErrors.WorkOrderIdRequired",
        description: "WorkOrder Id is Required");
}
