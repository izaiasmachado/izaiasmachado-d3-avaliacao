namespace izaiasmachado_d3_avaliacao.Models
{
    internal class Base
    {
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
