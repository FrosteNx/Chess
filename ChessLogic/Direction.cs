namespace ChessLogic
{
    public class Direction
    {
        public readonly static Direction North = new Direction(-1, 0);
        public readonly static Direction South = new Direction(1, 0);
        public readonly static Direction West = new Direction(0, -1);
        public readonly static Direction East = new Direction(0, 1);
        public readonly static Direction NorthWest = North + West;
        public readonly static Direction NorthEast = North + East;
        public readonly static Direction SouthWest = South + West;
        public readonly static Direction SouthEast = South + East;

        public int RowChange { get; }
        public int ColumnChange { get; }

        public Direction(int rowChange, int columnChange)
        {
            this.RowChange = rowChange;
            this.ColumnChange = columnChange;
        }

        public static Direction operator +(Direction d1, Direction d2)
        {
            return new Direction(d1.RowChange + d2.RowChange, d1.ColumnChange + d2.ColumnChange);
        }

        public static Direction operator *(int scalar, Direction d)
        {
            return new Direction(scalar * d.RowChange, scalar * d.ColumnChange);
        }
    }
}