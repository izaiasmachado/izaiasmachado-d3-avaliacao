using izaiasmachado_d3_avaliacao.Repositories;
using izaiasmachado_d3_avaliacao.Models;
using izaiasmachado_d3_avaliacao.Interfaces;
using izaiasmachado_d3_avaliacao.Views;

namespace izaiasmachado_d3_avaliacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IScreen menu = new MainScreen();

            while (menu != null)
            {
                menu = menu.show();
            }
        }
    }
}