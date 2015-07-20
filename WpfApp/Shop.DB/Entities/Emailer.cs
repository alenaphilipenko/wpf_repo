using Shop.DB.Interfaces;

namespace Shop.DB.Entities
{
    public class Emailer : IEntity
    {
        public virtual int Id { get; set; }
        public virtual string Email { get; set; }
        public virtual int Owner { get; set; }
        public virtual string Type { get; set; }
    }
}
