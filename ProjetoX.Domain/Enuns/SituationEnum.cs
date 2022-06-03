using System.ComponentModel;

namespace ProjetoX.Domain.Enuns
{
    public enum SituationEnum : short
    {
        [Description("Inactive")]
        Inactive = 0, 
        
        [Description("Active")]
        Active = 1
    }
}