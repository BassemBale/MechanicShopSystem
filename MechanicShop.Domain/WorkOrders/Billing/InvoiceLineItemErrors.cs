using MechanicShop.Domain.Common.Results;

namespace MechanicShop.Domain.WorkOrders.Billing;

public static class InvoiceLineItemErrors
{
    public static Error InvoiceIdRequired => Error.Validation(
         "InvoiceLineItemErrors.InvoiceIdRequired", "InvoiceId is required.");

    public static Error LineNumberInvalid => Error.Validation(
       "InvoiceLineItemErrors.LineNumberInvalid", "Line number must be greater than 0.");

    public static Error DescriptionRequired => Error.Validation(
        "InvoiceLineItemErrors.DescriptionRequired", "Description is required.");

    public static Error QuantityInvalid => Error.Validation(
      "InvoiceLineItemErrors.QuantityInvalid", "Quantity must be greater than 0.");

    public static Error UnitPriceInvalid => Error.Validation(
        "InvoiceLineItemErrors.UnitPriceInvalid", "Unit price must be greater than 0.");
}
