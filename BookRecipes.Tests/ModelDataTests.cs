using Xunit;
using FluentAssertions;

namespace BookRecipes.Tests
{
    public class ModelDataTests
    {
        [Fact] 
        public void CsvReturnsAMessegeWhenIsEmpty()
        {
            ModelData modelData = new(@"..\..\..\..\Empty.csv");
            modelData.ShowRecipes().Should().Be("The doccument file is empty");
        }
    }
}