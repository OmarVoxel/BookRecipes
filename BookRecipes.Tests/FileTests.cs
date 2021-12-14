using System.Linq;
using Xunit;
using FluentAssertions;

namespace BookRecipes.Tests
{
    public class FileTests
    {
        [Fact]
        public void FileExistsAndIsNotEmpty()
        {
            File file = new File(@"..\..\..\..\Recipes.csv");
            file.Exists().Should().Be(true);
            file.IsEmpty().Should().Be(false);
        }
        
        [Fact]
        public void CheckIfTheFirstElemmentInTheListIsARecipe()
        {
            File file = new File(@"..\..\..\..\Recipes.csv");

            file.Read().First().Should().Be("Pollo a la cerveza");
        }
    }
}