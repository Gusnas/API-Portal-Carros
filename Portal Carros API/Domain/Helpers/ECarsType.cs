using System.ComponentModel;

namespace Portal_Carros_API.Domain.Helpers
{
    public enum ECarsType
    {
        [Description("Basic")]
        Basic = 1,
        [Description("Turbo")]
        Turbo = 2,
        [Description("Economic")]
        Economic = 3
    }
}
