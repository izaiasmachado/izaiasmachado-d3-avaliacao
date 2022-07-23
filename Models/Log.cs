namespace izaiasmachado_d3_avaliacao.Models
{
    internal class Log : Base
    {
        private const string path = "database/logs.txt";

        public Log()
        {
            CreateFolderAndFile(path);
        }

        private static string PrepareLine(User user, int hour, int year, int month, int day)
        {
            string dayString = day.ToString().PadLeft(2, '0');
            string monthString = month.ToString().PadLeft(2, '0');

            return $"Usuário {user.Name} ({user.IdUser}) acessou o sistema às {hour} h do dia {dayString}/{monthString}/{year}";
        }

        public void Create(User user) {
            DateTime moment = DateTime.Now;

            int hour = moment.Hour;
            int year = moment.Year;
            int month = moment.Month;
            int day = moment.Day;

            string[] line = { PrepareLine(user, hour, year, month, day) };
            File.AppendAllLines(path, line);
        }
    }
}
