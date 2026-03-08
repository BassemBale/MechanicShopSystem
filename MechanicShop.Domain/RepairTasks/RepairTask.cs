using MechanicShop.Domain.Common;
using MechanicShop.Domain.RepairTasks.Enum;
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
}
