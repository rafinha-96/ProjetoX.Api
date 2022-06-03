namespace ProjetoX.Domain.Entities
{
    public abstract class BaseEntity<TPK>
    {
        public int Id { get; set; }
    }
}