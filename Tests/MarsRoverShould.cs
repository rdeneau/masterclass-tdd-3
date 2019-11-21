using FluentAssertions;
using MarsRoverKata.Source;
using Xunit;

namespace MarsRoverKata.Tests
{
    public class MarsRoverShould
    {
        [Theory]
        [InlineData("N", "W")]
        [InlineData("W", "S")]
        [InlineData("S", "E")]
        [InlineData("E", "N")]
        public void Rotate_Left(string initialDirection, string expectedDirection)
        {
            var direction = Direction.FromCode(initialDirection);
            var sut = new MarsRover(direction);
            sut.RotateLeft();

            var expected = Direction.FromCode(expectedDirection);
            sut.Direction.Should().Be(expected);
        }

        [Theory]
        [InlineData("W", "N")]
        [InlineData("S", "W")]
        [InlineData("E", "S")]
        [InlineData("N", "E")]
        public void Rotate_Right(string initialDirection, string expectedDirection)
        {
            var direction = Direction.FromCode(initialDirection);
            var sut = new MarsRover(direction);
            sut.RotateRight();

            var expected = Direction.FromCode(expectedDirection);
            sut.Direction.Should().Be(expected);
        }
    }
}