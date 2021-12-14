using System.IO;

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
        
    }
}