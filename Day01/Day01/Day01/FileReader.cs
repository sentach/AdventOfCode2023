using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day01
{
    internal class FileReader
    {
        private TextReader _reader;
        private string _fileName;
        public FileReader(string filename)
        {
            _reader = File.OpenText(filename);
            _fileName = filename;
        }

        public IEnumerable<string> ProcessFile(Func<string, string> func)
        {
            var filas = _reader.ReadToEnd().Split("\r\n");
            foreach (var fi in filas)
            {
                yield return func(fi);
            }            
        }

        public void Reset()
        {
            _reader.Close();
            _reader = File.OpenText(_fileName);
        }
    }
}
