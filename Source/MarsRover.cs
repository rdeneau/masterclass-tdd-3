namespace MarsRoverKata.Source
{
    /// <summary>
    /// Direction of coordinates:
    /// • X: West  -> East
    /// • Y: North -> South
    /// </summary>
    public class MarsRover
    {
        public Direction Direction { get; private set; }

        public MarsRover(Direction direction)
        {
            Direction = direction;
        }

        public void RotateLeft()
        {
            Direction = Direction.Left;
        }
    }
}