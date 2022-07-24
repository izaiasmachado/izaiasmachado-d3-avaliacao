using izaiasmachado_d3_avaliacao.Models;
using izaiasmachado_d3_avaliacao.Interfaces;

namespace izaiasmachado_d3_avaliacao.Utils
{
    internal enum LogActionsEnum
    {
        LOGIN,
        LOGOFF
    }

    internal sealed class Logger : ILogger
    {
        private static string ActionToString(LogActionsEnum action)
        {
            switch (action)
            {
                case LogActionsEnum.LOGIN:
                    return "logou";
                case LogActionsEnum.LOGOFF:
                    return "deslogou";
                default:
                    return String.Empty;
            }
        }

        private const string path = "database/logs.txt";
        private static Logger instance = null;

        private Logger()
        {
            CreateFolderAndFile(path);
        }

        public static Logger getInstance()
        {
            if (instance == null)
            {
                instance = new Logger();
            }
            
            return instance;
        }

        private static string PrepareLine(User user, LogActionsEnum action, int hour, int year, int month, int day)
        {
            string dayString = day.ToString().PadLeft(2, '0');
            string monthString = month.ToString().PadLeft(2, '0');
            string actionString = ActionToString(action);

            return $"Usuário {user.Name} ({user.IdUser}) {actionString} no sistema às {hour} h do dia {dayString}/{monthString}/{year}";
        }

        private void Create(User user, LogActionsEnum action) {
            DateTime moment = DateTime.Now;

            int hour = moment.Hour;
            int year = moment.Year;
            int month = moment.Month;
            int day = moment.Day;

            string[] line = { PrepareLine(user, action, hour, year, month, day) };
            File.AppendAllLines(path, line);
        }

        public void CreateLogin(User user)
        {
            Create(user, LogActionsEnum.LOGIN);
        }
        public void CreateLogoff(User user)
        {
            Create(user, LogActionsEnum.LOGOFF);
        }

        public static void CreateFolderAndFile(string path)
        {
            string folder = path.Split("/")[0];

            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }

            if (!File.Exists(path))
            {
                File.Create(path).Close();
            }
        }
    }
}
