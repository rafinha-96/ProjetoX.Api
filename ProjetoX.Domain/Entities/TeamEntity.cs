namespace ProjetoX.Domain.Entities
{
    public class TeamEntity : BaseEntity<int>
    {
        public string Name { get; private set; }
        public short Group { get; private set; }
        public int Spots { get; private set; }
        public bool Classified { get; private set; }
        public int GoalsConceded { get; private set; }
        public int GoalsScored { get; private set; }
        public short Victories { get; private set; }
        public short Defeats { get; private set; }
        public short draws { get; private set; }
    }
}