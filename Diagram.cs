﻿using System;

namespace make_tetris
{
    class Diagram
    {
      internal int X
        {
            get;
            private set;
        }

        internal int Y
        {
            get;
            private set;
        }

        internal int Turn
        {
            get;
            private set;
        }

        internal int BlockNum
        {
            get;
            private set;
        }

        internal void Reset()
        {
            Random random = new Random();
            X = GameRule.SX;
            Y = GameRule.SY;
            Turn = random.Next() % 4;
            BlockNum = random.Next()%7;
        }

        internal void MoveLeft()
        {
            X--;
        }

        internal void MoveRight()
        {
            X++;
        }

        internal void MoveDown()
        {
            Y++;
        }

        internal void MoveTurn()
        {
            Turn = (Turn + 1) % 4;
        }

        }
}
