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
            var position = Position.Create(0, 0);

            var sut = new MarsRover(direction, position);
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
            var position  = Position.Create(0, 0);

            var sut = new MarsRover(direction, position);
            sut.RotateRight();

            var expected = Direction.FromCode(expectedDirection);
            sut.Direction.Should().Be(expected);
        }

        [Theory]
        [InlineData("N", 1, 0)]
        [InlineData("S", 1, 2)]
        [InlineData("W", 0, 1)]
        [InlineData("E", 2, 1)]
        public void Move_Forward(string initialDirection, int endX, int endY)
        {
            var direction = Direction.FromCode(initialDirection);
            var position  = Position.Create(1, 1);

            var sut = new MarsRover(direction, position);
            sut.MoveForward();

            sut.Position.X.Should().Be(endX);
            sut.Position.Y.Should().Be(endY);
        }
    }
}