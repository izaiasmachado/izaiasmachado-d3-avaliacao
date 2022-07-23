using izaiasmachado_d3_avaliacao.Models;

namespace izaiasmachado_d3_avaliacao.Interfaces
{
    internal interface ILog
    {
        public void CreateLogin(User user);
        public void CreateLogoff(User user);
    }
}
