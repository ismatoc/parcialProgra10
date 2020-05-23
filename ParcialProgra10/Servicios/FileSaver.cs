using ParcialProgra10.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialProgra10.Servicios
{
    class FileSaver
    {
        public void SaveToFile<T>(string directoryPath, string fileName, IControlApp<T> report)
        {
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }
            File.WriteAllText(Path.Combine(directoryPath, fileName), report.ToString());
        }
    }
}
