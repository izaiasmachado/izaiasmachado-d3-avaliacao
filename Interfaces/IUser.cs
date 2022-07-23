using izaiasmachado_d3_avaliacao.Models;

namespace izaiasmachado_d3_avaliacao.Interfaces
{
    internal interface IUser
    {
        public List<User> ReadAll();
        public User GetUserByEmail(string email);
    }
}
