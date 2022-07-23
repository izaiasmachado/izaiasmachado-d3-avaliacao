using izaiasmachado_d3_avaliacao.Interfaces;

namespace izaiasmachado_d3_avaliacao.Views
{
    internal class ErrorTryAgainScreen : IScreen
    {
        IScreen returnMenu = null;
        string errorMessage = String.Empty;

        public ErrorTryAgainScreen(IScreen menu, String message)
        {
            returnMenu = menu;
            errorMessage = message;
        }

        public IScreen show()
        {
            Console.WriteLine("========== ERRO ==========");
            Console.WriteLine(errorMessage);
            Console.WriteLine("");
            return returnMenu;
        }
    }
}
