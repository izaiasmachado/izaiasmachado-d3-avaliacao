using izaiasmachado_d3_avaliacao.Interfaces;

namespace izaiasmachado_d3_avaliacao.Views
{
    internal class MainMenuScreen : IScreen
    {
        public IScreen show()
        {
            Console.WriteLine("========== MENU PRINCIPAL ==========");
            Console.WriteLine("[1] Acessar ");
            Console.WriteLine("[2] Cancelar ");
            Console.Write("Digite a opção escolhida: ");

            IScreen returnMenu = new MainMenuScreen();
            String errorMessage = "Opção Inválida! Tente novamente";
            ErrorTryAgainScreen errorTryAgainMenu = new ErrorTryAgainScreen(returnMenu, errorMessage);

            try
            {
                string optionString = Console.ReadLine();
                Console.WriteLine("");

                int option = Convert.ToInt32(optionString);

                switch (option)
                {
                    case 1:
                        return new LoginScreen();
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
        }
    }
}