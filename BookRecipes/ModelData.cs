namespace BookRecipes
{
    public class ModelData
    {
        private string _path;

        public ModelData(string path) 
            => _path = path;

        public bool Exists() => System.IO.File.Exists(_path);
        
        
    }
}