using izaiasmachado_d3_avaliacao.Repositories;
using izaiasmachado_d3_avaliacao.Models;

namespace izaiasmachado_d3_avaliacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserRepository userRepository = new UserRepository();

            try
            {
                User user = userRepository.GetUserByEmail("admin@email.com");
                user.ValidateGivenPassword("admin123");
                Console.WriteLine("Login feito!");
            } catch (Exception e)
            {
                Console.WriteLine("Credenciais incorretas");
            }
        }
    }
}