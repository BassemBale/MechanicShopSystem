using MechanicShop.Domain.Common.Results;

namespace MechanicShop.Domain.WorkOrders.Billing;

public static class InvoiceErrors
{
    public static readonly Error WorkOrderIdRequired = Error.Validation(
       "Invoice.WorkOrderId.Required", "WorkOrderId is Required.");

    public static readonly Error LineItemsEmpty = Error.Validation(
        "Invoice.LineItems.Empty","Invoice must have line items");

    public static readonly Error InvoiceLocked = Error.Validation(
         "Invoice.Locked","Invoice is locked");

    public static readonly Error DiscountNegative = Error.Validation(
        "Invoice.Discount.Negative","Discount cannot be negative");

    public static readonly Error DiscountExceedsSubtotal = Error.Validation(
        "Invoice.Discount.ExceedsSubtotal","Discount exceeds subtotal");
}
