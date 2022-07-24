using izaiasmachado_d3_avaliacao.Interfaces;
using izaiasmachado_d3_avaliacao.Repositories;
using izaiasmachado_d3_avaliacao.Models;
using izaiasmachado_d3_avaliacao.Utils;

namespace izaiasmachado_d3_avaliacao.Views
{
    internal class CloseSystemScreen : IScreen
    {
        public IScreen show()
        {
            User user = UserRepository.LoggedUser;
            Console.WriteLine("========== FINALIZAÇÃO ==========");
            if (user != null)
            {
                Console.WriteLine("Logoff do usuário realizado!");
                Logger logger = Logger.getInstance();
                logger.CreateLogoff(user);
                UserRepository.Logoff();
            }
            Console.WriteLine("Sistema encerrado com sucesso!");
            Console.WriteLine("");
            return null;
        }
    }
}
