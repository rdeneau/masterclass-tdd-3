using System;

namespace MarsRoverKata.Source
{
    public class Angle : IEquatable<Angle>
    {
        public const int Quarter  = 90;
        public const int Complete = 360;

        public int Value { get; }

        public Angle(int value)
        {
            Value = (value + Complete) % Complete;
        }

        public static implicit operator int(Angle angle) =>
            angle.Value;

        public Angle Add(int other) =>
            new Angle(Value + other);

        public bool Equals(Angle other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return Value == other.Value;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Angle) obj);
        }

        public override int GetHashCode()
        {
            return Value;
        }
    }
}