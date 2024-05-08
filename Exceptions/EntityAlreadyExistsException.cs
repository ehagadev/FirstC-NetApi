namespace Exceptions;
public class EntityAlreadyExistsException<T> : Exception
{
    public T ExistingEntity { get; }

    public EntityAlreadyExistsException(T existingEntity)
        : base($"{typeof(T).Name} already exists")
    {
        ExistingEntity = existingEntity;
    }

    public EntityAlreadyExistsException(T existingEntity, string message)
        : base(message)
    {
        ExistingEntity = existingEntity;
    }
}