using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using izaiasmachado_d3_avaliacao.Interfaces;
using izaiasmachado_d3_avaliacao.Repositories;
using izaiasmachado_d3_avaliacao.Models;
using izaiasmachado_d3_avaliacao.Views;

namespace izaiasmachado_d3_avaliacao.Views
{
    internal class LoggedScreen : IScreen
    {
        public IScreen show()
        {
            IScreen returnMenu = new MainScreen();
            String errorMessage = "Opção Inválida! Tente novamente";
            ErrorTryAgainScreen errorTryAgainMenu = new ErrorTryAgainScreen(returnMenu, errorMessage);

            Console.WriteLine("========== TELA LOGADO ==========");
            Console.WriteLine("[1] Deslogar ");
            Console.WriteLine("[2] Encerrar Sistema ");
            Console.Write("Digite a opção escolhida: ");

            try
            {
                string optionString = Console.ReadLine();
                Console.WriteLine("");

                int option = Convert.ToInt32(optionString);

                switch (option)
                {
                    case 1:
                        return new LogoffScreen();
                    case 2:
                        return new CloseSystemScreen();
                    default:
                        return errorTryAgainMenu;
                }
            }
            catch (Exception e)
            {
                return errorTryAgainMenu;
            }

            return null;
        }
    }
}
