namespace MarsRoverKata.Source
{
    public class Position
    {
        public static Position Create(int x, int y) =>
            new Position(x, y);

        public int X { get; }
        public int Y { get; }

        private Position(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}