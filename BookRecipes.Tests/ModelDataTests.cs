using Xunit;
using FluentAssertions;

namespace BookRecipes.Tests
{
    public class ModelDataTests
    {
        [Fact]
        public void FileExists()
        {
            ModelData modelData = new ModelData(@"..\..\..\..\Recipes.csv");
            modelData.Exists().Should().Be(true);
        }
    }
}