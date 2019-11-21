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

        public Position Position { get; private set; }

        public MarsRover(Direction direction, Position position)
        {
            Direction = direction;
            Position  = position;
        }

        public void RotateLeft()
        {
            Direction = Direction.Left;
        }

        public void RotateRight()
        {
            Direction = Direction.Right;
        }

        public void MoveForward()
        {
            Position = Direction.Forward(Position);
        }
    }
}