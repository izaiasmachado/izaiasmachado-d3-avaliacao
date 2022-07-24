using izaiasmachado_d3_avaliacao.Models;

namespace izaiasmachado_d3_avaliacao.Interfaces
{
    internal interface ILogger
    {
        public void CreateLogin(User user);
        public void CreateLogoff(User user);
    }
}
