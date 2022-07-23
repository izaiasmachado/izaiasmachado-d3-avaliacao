using izaiasmachado_d3_avaliacao.Models;

namespace izaiasmachado_d3_avaliacao.Interfaces
{
    internal interface IUser
    {
        User GetUserByEmail(string email);
    }
}
