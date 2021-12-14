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
            modelData.IsNotEmpty().Should().Be(false);
        }
    }
}