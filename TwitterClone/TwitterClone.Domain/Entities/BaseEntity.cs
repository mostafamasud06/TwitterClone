namespace TwitterClone.Domain.Entities
{
    public class BaseEntity
    {
        public Guid Id { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime? ModifiedAt { get; private set; }

        public Guid CreaatedBy { get; private set; }

        public Guid? ModifiedBy { get; private set; }
    

    // to apply set encapsulation added by construtor
    public BaseEntity(Guid id)
        {// constructor
            Id = id;
            CreatedAt = DateTime.UtcNow;

        }
    }
}
