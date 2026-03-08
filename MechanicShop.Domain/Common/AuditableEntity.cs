namespace MechanicShop.Domain.Common;
/// <summary>
/// Represents a base entity that provides auditing properties for tracking creation and modification details.
/// </summary>
/// <remarks>Inherit from this class to enable automatic recording of when an entity was created or last modified,
/// and by whom. This is useful for maintaining historical records and supporting accountability in data management
/// scenarios.</remarks>
public abstract class AuditableEntity : Entity
{
    protected AuditableEntity(){}
    protected AuditableEntity(Guid id) :
        base(id)
    {
        
    }

    public DateTimeOffset CreatedAtUtc {  get; set; }
    public string? CreatedBy { get; set; }
    public DateTimeOffset LastModifiedUtc { get; set; }
    public string? LastModifiedBy { get; set; }

}
