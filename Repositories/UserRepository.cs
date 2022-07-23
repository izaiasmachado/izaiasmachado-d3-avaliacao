using izaiasmachado_d3_avaliacao.Interfaces;
using izaiasmachado_d3_avaliacao.Models;
using System.Data.SqlClient;

namespace izaiasmachado_d3_avaliacao.Repositories
{
    internal class UserRepository : IUser
    {
        private readonly string conectionString = "Data source=IZAIAS-LAPTOP\\SQLEXPRESS01; initial catalog=D3-Avaliacao; user id=izaias; pwd=cteds2022;";


        public List<User> ReadAll()
        {
            List<User> listProducts = new();

            using (SqlConnection con = new SqlConnection(conectionString))
            {
                string querySelectAll = "SELECT IdUser, Name, Email, Password FROM Users";

                con.Open();

                SqlDataReader rdr;

                using (SqlCommand cmd = new(querySelectAll, con))
                {
                    rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {

                        User user = new()
                        {
                            IdUser = rdr[0].ToString(),
                            Name = rdr["Name"].ToString(),
                            Email = rdr["Email"].ToString(),
                            Password = rdr["Password"].ToString()
                        };

                        listProducts.Add(user);

                    }
                }
            }

            return listProducts;
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
