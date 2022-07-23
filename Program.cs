using izaiasmachado_d3_avaliacao.Repositories;
using izaiasmachado_d3_avaliacao.Models;

namespace izaiasmachado_d3_avaliacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserRepository userRepository = new UserRepository();
            Log log = new Log();

            try
            {
                User user = userRepository.GetUserByEmail("admin@email.com");
                user.ValidateGivenPassword("admin123");
                Console.WriteLine("Login feito!");
                log.CreateLogin(user);
                log.CreateLogoff(user);
            } catch (Exception e)
            {
                Console.WriteLine("Credenciais incorretas");
            }

        }
    }
}