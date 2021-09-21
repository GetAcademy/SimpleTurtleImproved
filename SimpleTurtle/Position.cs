namespace SimpleTurtle
{
    class Position
    {

        public int MyCol { get; private set; }
        public int MyRow { get; private set; }

        public Position(int myCol, int myRow)
        {
            this.MyCol = myCol;
            this.MyRow = myRow;
        }
        public void Move(Direction myDirection)
        {
            if (myDirection == Direction.Right) MyCol++;
            else if (myDirection == Direction.Left) MyCol--;
            else if (myDirection == Direction.Up) MyRow--;
            else if (myDirection == Direction.Down) MyRow++;
        }
    }

}
