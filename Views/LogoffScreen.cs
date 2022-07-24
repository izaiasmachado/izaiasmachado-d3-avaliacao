using izaiasmachado_d3_avaliacao.Interfaces;
using izaiasmachado_d3_avaliacao.Models;
using izaiasmachado_d3_avaliacao.Repositories;
using izaiasmachado_d3_avaliacao.Utils;

namespace izaiasmachado_d3_avaliacao.Views
{
    internal class LogoffScreen : IScreen
    {
        public IScreen show()
        {
            User user = UserRepository.LoggedUser;
            Logger logger = Logger.getInstance();
            logger.CreateLogoff(user);

            UserRepository.Logoff();

            Console.WriteLine("========== TELA DE LOGOFF ==========");
            Console.WriteLine("Usuário deslogado com sucesso!");
            Console.WriteLine("");
            return new MainScreen();
        }
    }
}
