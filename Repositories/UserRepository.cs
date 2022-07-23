using izaiasmachado_d3_avaliacao.Interfaces;
using izaiasmachado_d3_avaliacao.Models;
using System.Data.SqlClient;

namespace izaiasmachado_d3_avaliacao.Repositories
{
    internal static class UserRepository
    {
        public static User LoggedUser { get; set; }
        private static readonly string conectionString = "Data source=IZAIAS-LAPTOP\\SQLEXPRESS01; initial catalog=izaiasmachado-d3-avaliacao; user id=izaias; pwd=cteds2022;";

        public static List<User> ReadAll()
        {
            List<User> listUsers = new();
            string querySelectAllUsers = "SELECT IdUser, Name, Email, Password FROM Users";

            using (SqlConnection connection = new SqlConnection(conectionString))
            {
                connection.Open();

                SqlDataReader reader;

                using (SqlCommand command = new(querySelectAllUsers, connection))
                {
                    reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        User user = new()
                        {
                            IdUser = reader["IdUser"].ToString(),
                            Name = reader["Name"].ToString(),
                            Email = reader["Email"].ToString(),
                            Password = reader["Password"].ToString()
                        };

                        listUsers.Add(user);

                    }
                }
            }

            return listUsers;
        }

        public static User GetUserByEmail(string email)
        {
            List<User> users = ReadAll();

            foreach (User user in users)
            {
                if (user.Email == email)
                {
                    return user;
                }
            }

            throw new NullReferenceException("User object is null.");
        }

        public static void TryToLogin(string givenEmail, string givenPassword)
        {
            try
            {
                User user = GetUserByEmail(givenEmail);
                user.ValidateGivenPassword(givenPassword);
                LoggedUser = user;
            }
            catch (Exception e)
            {
                throw new Exception("Invalid credentials");
            }
        }

        public static void Logoff()
        {
            LoggedUser = null;
        }
    }
}
