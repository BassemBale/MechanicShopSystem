using MechanicShop.Domain.Common;
using MechanicShop.Domain.Common.Results;
using MechanicShop.Domain.RepairTasks.Enums;
using MechanicShop.Domain.RepairTasks.Parts;

namespace MechanicShop.Domain.RepairTasks;

public class RepairTask : AuditableEntity
{
    public string Name { get; private set; } = null!;
    public decimal LaborCost { get; private set; }
    public RepairDurationInMinutes EstimatedDurationInMins { get; private set; }

    private readonly List<Part> _parts = [];
    public IEnumerable<Part> Parts => _parts;
    public decimal TotalCost => LaborCost + Parts.Sum(p => p.Cost * p.Quantity);

    private RepairTask()
    { }

    private RepairTask(Guid id, string name, decimal laborCost, RepairDurationInMinutes estimatedDurationInMins, List<Part> parts)
        : base(id)
    {
        Name = name;
        LaborCost = laborCost;
        EstimatedDurationInMins = estimatedDurationInMins;
        _parts = parts;
    }

    public static Result<RepairTask> Create(
        Guid id,
        string name,
        decimal laborCost,
        RepairDurationInMinutes estimatedDurationInMins,
        List<Part> parts)
    {
        if(string.IsNullOrWhiteSpace(name))
        {
            return RepairTaskErrors.NameRequired;
        }
        if(laborCost <= 0 || laborCost > 10_000)
        {
            return RepairTaskErrors.LaborCostInvalid;
        }
        if (!Enum.IsDefined(estimatedDurationInMins))
        {
            return RepairTaskErrors.DurationInvalid;
        }
        return new RepairTask(id, name, laborCost, estimatedDurationInMins, parts);
    }

    public Result<Updated> UpdateParts(List<Part> incomingParts)
    {
        _parts.RemoveAll(existing => incomingParts.All(p => p.Id != existing.Id));

        foreach (var incoming in incomingParts)
        {
            var existing = _parts.FirstOrDefault(p => p.Id == incoming.Id);
            if(existing is null)
            {
                _parts.Add(incoming);
            }
            else
            {
                var updatedPartResult = existing.Update(incoming.Name!, incoming.Cost, incoming.Quantity);
                if (updatedPartResult.IsError)
                {
                    return updatedPartResult.Errors;
                }
            }
        }
        return Result.Updated;
    }

    public Result<Updated> Update(string name, decimal laborCost, RepairDurationInMinutes estimatedDurationInMins)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            return RepairTaskErrors.NameRequired;
        }
        if (laborCost <= 0 || laborCost > 10_000)
        {
            return RepairTaskErrors.LaborCostInvalid;
        }
        if (!Enum.IsDefined(estimatedDurationInMins))
        {
            return RepairTaskErrors.DurationInvalid;
        }

        Name = name.Trim();
        LaborCost = laborCost;
        EstimatedDurationInMins = estimatedDurationInMins;

        return Result.Updated;
    }
}
