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
        public IScreen show()
        {
            Log log = Log.getInstance();
            User user = UserRepository.LoggedUser;
            log.CreateLogoff(user);

            Console.WriteLine("========== TELA DE LOGOFF ==========");
            Console.WriteLine("Usuário deslogado com sucesso!");
            Console.WriteLine("");
            return new CloseSystemScreen();
        }
    }
}
