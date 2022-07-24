namespace izaiasmachado_d3_avaliacao.Models
{
    internal class User
    {
        public string IdUser { set; get; } = string.Empty;
        public string Name { set; get; } = string.Empty;
        public string Email { set; get; } = string.Empty;
        public string Password { set; get; } = string.Empty;

        public void ValidateGivenPassword(string password)
        {       
            try
            {
                BCrypt.Net.BCrypt.Verify(password, Password);
            } 
            catch (Exception)
            {
                throw new Exception("Incorrect given password");
            }
        }
    }
}
