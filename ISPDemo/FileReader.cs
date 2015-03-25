using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPDemo
{
    class FileReader : IReader
    {
        public string ReadFile(string filename)
        {
            if (File.Exists(filename))
            {
                string result = File.ReadAllText(filename);
                return result;
            }
            return string.Empty;
        }
    }
}
