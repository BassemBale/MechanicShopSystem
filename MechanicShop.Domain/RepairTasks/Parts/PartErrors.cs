using MechanicShop.Domain.Common.Results;

namespace MechanicShop.Domain.RepairTasks.Parts;

public static class PartErrors
{
    public static Error IdRequired =>
        Error.Validation("Part.Id.Required", "Part Id is required.");
    public static Error NameRequired =>
        Error.Validation("Part.Name.Required", "Part name is required.");
    public static Error CostInvalid =>
        Error.Validation("part.Cost.Invalid", "Part cost must be between 1 and 10,000.");
    public static Error QuatityInvalid =>
        Error.Validation("Part.Quantity.invalid", "Quantity must be between 1 and 10.");
}
