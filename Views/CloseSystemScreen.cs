﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using izaiasmachado_d3_avaliacao.Interfaces;
using izaiasmachado_d3_avaliacao.Repositories;
using izaiasmachado_d3_avaliacao.Models;

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
                Log log = Log.getInstance();
                log.CreateLogoff(user);
                UserRepository.Logoff();
            }
            Console.WriteLine("Sistema encerrado com sucesso!");
            Console.WriteLine("");
            return null;
        }
    }
}
