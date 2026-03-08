namespace MechanicShop.Domain.Common;
/// <summary>
/// Represents a base class for entities that are uniquely identified and support domain event management within the
/// domain model.
/// </summary>
/// <remarks>Entities derived from this class are assigned a unique identifier of type Guid. If an empty Guid is
/// provided during construction, a new Guid is generated automatically. The class provides methods to add, remove, and
/// clear domain events, enabling integration with domain-driven design patterns. This base class is intended to be
/// inherited by domain entities that require identity and domain event handling.</remarks>
public abstract class Entity
{
    public Guid Id { get; }
    private readonly List<DomainEvents> _domainEvents = [];
    protected Entity(){}

    protected Entity(Guid id)
    {
        Id = id == Guid.Empty ? Guid.NewGuid() : id;
    }

    public void AddDomianEvent(DomainEvents domainEvent)
    {
        _domainEvents.Add(domainEvent);
    }
    public void RemoveDomainEvent(DomainEvents domainEvent)
    {
        _domainEvents.Remove(domainEvent);
    }
    public void ClearDomainEvents()
    {
        _domainEvents.Clear();
    }
}
