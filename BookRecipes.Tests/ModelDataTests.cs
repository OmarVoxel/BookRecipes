using Xunit;
using FluentAssertions;

namespace BookRecipes.Tests
{
    public class ModelDataTests
    {
        [Fact] 
        public void ReturnsAMessegeWhenFileIsEmpty()
        {
            ModelData modelData = new(@"..\..\..\..\Empty.csv");
            modelData.ShowRecipes().Should().Be("The doccument file is empty");
        }
        
        [Fact] 
        public void ReturnsAMessegeWhenFileDoesntExiste()
        {
            ModelData modelData = new(@"..\..\..\..\THISDOESNTEXISTDUDES.csv");
            modelData.ShowRecipes().Should().Be("The doccument doesn't exist");
        }
    }
}