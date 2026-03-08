using MechanicShop.Domain.Common.Results;

namespace MechanicShop.Domain.RepairTasks.Parts;

public static class PartErrors
{
    public static readonly Error IdRequired =
        Error.Validation("Part.Id.Required", "Part Id is required.");
    public static readonly Error NameRequired =
        Error.Validation("Part.Name.Required", "Part name is required.");

    public static readonly Error CostInvalid =
        Error.Validation("part.Cost.Invalid", "Part cost must be between 1 and 10,000.");

    public static readonly Error QuatityInvalid =
        Error.Validation("Part.Quantity.invalid", "Quantity must be between 1 and 10.");
}
