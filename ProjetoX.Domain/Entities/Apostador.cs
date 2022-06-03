using ProjetoX.Domain.Enuns;

namespace ProjetoX.Domain.Entities
{
    public class Apostador : BaseEntity<int>
    {
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public string Hash { get; private set; }
        public SituacaoEnum Situacao { get; private set; }
        public int IdTimeApostado { get; private set; }
        public int IdJogo { get; private set; }
        public int Pontos { get; private set; }
        public short IdTimePreferido { get; private set; }
    }
}