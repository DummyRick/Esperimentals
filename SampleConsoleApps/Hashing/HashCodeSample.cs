namespace SampleConsoleApps.Hashing
{
    /// <summary>
    /// HashCodeSample
    /// </summary>
    public static class HashCodeSample
    {
        private class PointA : IEquatable<PointA>
        {
            public int X { get; set; }
            public int Y { get; set; }

            public bool Equals(PointA? other)
            {
                return other != null && other.X == this.X && other.Y == this.Y;
            }

            public override bool Equals(object obj)
            {
                return Equals(obj as PointA);
            }

            public override int GetHashCode()
            {
                return HashCode.Combine(X, Y);
            }
        }

        private class PointB : IEquatable<PointB>
        {
            public int X { get; set; }
            public int Y { get; set; }

            public bool Equals(PointB? other)
            {
                return other != null && other.X == this.X && other.Y == this.Y;
            }

            public override bool Equals(object obj)
            {
                return Equals(obj as PointB);
            }

            public override int GetHashCode()
            {
                return HashCode.Combine(X, Y);
            }
        }
        public static void Main()
        {
            var pointA = new PointA() { X = 1, Y = 2 };

            var pointB = new PointB() { X = 1, Y = 2 };


            //Get hash code give you the hash based on reference
            Console.Write($"Same value = {pointA.GetHashCode() == pointB.GetHashCode()}");
        }
    }
}
