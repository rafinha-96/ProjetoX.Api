namespace ProjetoX.Domain.Entities
{
    public class Time : BaseEntity<int>
    {
        public string Nome { get; private set; }
        public short Grupo { get; private set; }
        public int Pontos { get; private set; }
        public bool Classificado { get; private set; }
        public int GolsSofridos { get; private set; }
        public int GolsSMarcados { get; private set; }
        public short Vitoria { get; private set; }
        public short Derrota { get; private set; }
        public short Empate { get; private set; }
    }
}