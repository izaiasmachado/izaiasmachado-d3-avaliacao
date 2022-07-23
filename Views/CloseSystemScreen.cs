using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using izaiasmachado_d3_avaliacao.Interfaces;

namespace izaiasmachado_d3_avaliacao.Views
{
    internal class CloseSystemScreen : IScreen
    {
        public IScreen show()
        {
            Console.WriteLine("========== FINALIZAÇÃO ==========");
            Console.WriteLine("Sistema encerrado com sucesso!");
            return null;
        }
    }
}
