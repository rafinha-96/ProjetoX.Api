using ProjetoX.Domain.Enuns;

namespace ProjetoX.Domain.Entities
{
    public class PunterEntity : BaseEntity<int>
    {
        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Hash { get; private set; }
        public SituationEnum Situation { get; private set; }
        public int IdTeamBet { get; private set; }
        public int IdMatch { get; private set; }
        public int Spots { get; private set; }
        public short IdFavoriteTeam { get; private set; }
    }
}