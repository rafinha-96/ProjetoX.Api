using System.ComponentModel;

namespace ProjetoX.Domain.Enuns
{
    public enum SituacaoEnum : short
    {
        [Description("Inativo")]
        Inativo = 0, 
        
        [Description("Ativo")]
        Ativo = 1
    }
}