using Shop.DB.Interfaces;

namespace Shop.DB.Entities
{
    public class Product : IEntity
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string Manufacturer { get; set; }
        public virtual float Price { get; set; }
    }
}
