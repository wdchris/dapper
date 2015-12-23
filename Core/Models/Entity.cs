namespace Core.Models
{
    public class Entity
    {
        public int Id { get; private set; }
        public string Name { get; set; }

        public Entity(int id)
        {
            Id = id;
        }
    }
}
