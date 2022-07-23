using izaiasmachado_d3_avaliacao.Interfaces;
using izaiasmachado_d3_avaliacao.Models;
using System.Data.SqlClient;

namespace izaiasmachado_d3_avaliacao.Repositories
{
    internal class UserRepository : IUser
    {
        private readonly string conectionString = "Data source=IZAIAS-LAPTOP\\SQLEXPRESS01; initial catalog=izaiasmachado-d3-avaliacao; user id=izaias; pwd=cteds2022;";

        public List<User> ReadAll()
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

        public User GetUserByEmail(string email)
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
    }
}
