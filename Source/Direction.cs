using System;
using System.Linq;

namespace MarsRoverKata.Source
{
    public class Direction : IEquatable<Direction>
    {
        public static Direction FromAngle(int angle) =>
            All.Single(x => x.Angle == angle);

        public static Direction FromCode(string code) =>
            All.Single(x => x.Code == code);

        public static readonly Direction East  = new Direction("E", 0);
        public static readonly Direction North = new Direction("N", 90);
        public static readonly Direction West  = new Direction("W", 180);
        public static readonly Direction South = new Direction("S", 270);

        private static readonly Direction[] All = { East,North,West,South };

        private int Angle { get; }

        private string Code { get; }

        public Direction Left => FromAngle((Angle + 90) % 360);

        private Direction(string code, int angle)
        {
            Angle = angle;
            Code  = code;
        }

        public bool Equals(Direction other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return Angle == other.Angle;
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