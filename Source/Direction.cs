using System;
using System.Linq;

namespace MarsRoverKata.Source
{
    public class Direction : IEquatable<Direction>
    {
        private static Direction FromAngle(int angle) =>
            All.Single(x => x.Angle == angle);

        public static Direction FromCode(string code) =>
            All.Single(x => x.Code == code);

        private static readonly Direction East  = new Direction("E", 0 * Angle.Quarter, 1,  0);
        private static readonly Direction North = new Direction("N", 1 * Angle.Quarter, 0,  -1);
        private static readonly Direction West  = new Direction("W", 2 * Angle.Quarter, -1, 0);
        private static readonly Direction South = new Direction("S", 3 * Angle.Quarter, 0,  1);

        private static readonly Direction[] All = { East,North,West,South };

        private Angle Angle { get; }

        private string Code { get; }

        private Position Delta { get; }

        public Direction Left  => FromAngle(Angle.Add(Angle.Quarter));
        public Direction Right => FromAngle(Angle.Add(-Angle.Quarter));

        private Direction(string code, int angle, int deltaX, int deltaY)
        {
            Angle = new Angle(angle);
            Code  = code;
            Delta = Position.Create(deltaX, deltaY);
        }

        public Position Forward(Position position) =>
            position.Add(Delta);

        public bool Equals(Direction other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return Angle.Equals(other.Angle);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Direction) obj);
        }

        public override int GetHashCode()
        {
            return Angle;
        }
    }
}