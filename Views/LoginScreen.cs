using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using izaiasmachado_d3_avaliacao.Interfaces;
using izaiasmachado_d3_avaliacao.Repositories;
using izaiasmachado_d3_avaliacao.Models;
using izaiasmachado_d3_avaliacao.Utils;

namespace izaiasmachado_d3_avaliacao.Views
{
    internal class LoginScreen : IScreen
    {
        public IScreen show()
        {
            IScreen returnMenu = new LoginScreen();
            String errorMessage = "Credenciais incorretas! Tente novamente";
            ErrorTryAgainScreen errorTryAgainMenu = new ErrorTryAgainScreen(returnMenu, errorMessage);

            Console.WriteLine("========== TELA DE LOGIN ==========");
            Console.Write("Email: ");
            string givenEmail = Console.ReadLine();

            Console.Write("Senha: ");
            string givenPassword = Console.ReadLine();
            Console.WriteLine("");

            try
            {
                UserRepository.TryToLogin(givenEmail, givenPassword);
                User user = UserRepository.LoggedUser;
                
                Logger logger = Logger.getInstance();
                logger.CreateLogin(user);

                return new LoggedScreen();
            }
            catch (Exception e)
            {
                return errorTryAgainMenu;
            }

            return null;
        }
    }
}
