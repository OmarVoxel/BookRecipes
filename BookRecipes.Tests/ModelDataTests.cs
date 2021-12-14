using System.Linq;
using Xunit;
using FluentAssertions;

namespace BookRecipes.Tests
{
    public class ModelDataTests
    {
        [Fact]
        public void FileExistsAndIsNotEmpty()
        {
            ModelData modelData = new ModelData(@"..\..\..\..\Recipes.csv");
            modelData.Exists().Should().Be(true);
            modelData.IsEmpty().Should().Be(false);
        }
        
        [Fact]
        public void CheckIfTheFirstElemmentInTheListIsARecipe()
        {
            ModelData modelData = new ModelData(@"..\..\..\..\Recipes.csv");

            modelData.Read().First().Should().Be("Pollo a la cerveza");
        }


        
    }
}