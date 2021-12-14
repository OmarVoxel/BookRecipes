using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace BookRecipes
{
    public class File
    {
        private string _path;
        
        public File(string path) 
            => _path = path;

        public bool Exists() 
            => System.IO.File.Exists(_path);

        public bool IsEmpty() 
            => new FileInfo(_path).Length == 0;

        public List<string> Read() => 
            System.IO.File.ReadAllLines(_path)
                .Select(x => x.Trim('"'))
                .ToList();
    }

    public class ModelData
    {
        

    }
}