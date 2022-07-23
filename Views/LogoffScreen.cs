using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using izaiasmachado_d3_avaliacao.Interfaces;
using izaiasmachado_d3_avaliacao.Views;
using izaiasmachado_d3_avaliacao.Models;
using izaiasmachado_d3_avaliacao.Repositories;

namespace izaiasmachado_d3_avaliacao.Views
{
    internal class LogoffScreen : IScreen
    {
        private IScreen returnScreen = new MainScreen();

        public LogoffScreen()
        {
        }

        public LogoffScreen(IScreen screen)
        {
            returnScreen = screen;
        }

        public IScreen show()
        {
            User user = UserRepository.LoggedUser;
            Log log = Log.getInstance();
            log.CreateLogoff(user);

            UserRepository.Logoff();

            Console.WriteLine("========== TELA DE LOGOFF ==========");
            Console.WriteLine("Usuário deslogado com sucesso!");
            Console.WriteLine("");
            return returnScreen;
        }
    }
}
