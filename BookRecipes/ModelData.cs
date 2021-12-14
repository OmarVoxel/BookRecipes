using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace BookRecipes
{
    public class ModelData
    {
        private string _path;

        public ModelData(string path) 
            => _path = path;

        public bool Exists() 
            => File.Exists(_path);

        public bool IsEmpty() 
            => new FileInfo(_path).Length == 0;

        public List<string> Read() => 
            File.ReadAllLines(_path)
                .Select(x => x.Trim('"'))
                .ToList();
        
    }
}