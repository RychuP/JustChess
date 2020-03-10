﻿namespace ConsoleChess.Figures
{
    using System.Collections.Generic;

    using Common;
    using Contracts;
    using Movements.Contracts;

    public class King : BaseFigure, IFigure
    {
        static readonly int[,] pattern = {
            { 0, 0, 0, 0, 0, 0, 0, 0, 0, },
            { 0, 0, 0, 0, 64, 0, 0, 0, 0, },
            { 0, 0, 0, 64, 64, 64, 0, 0, 0, },
            { 0, 64, 64, 0, 64, 0, 64, 64, 0, },
            { 0, 64, 64, 64, 0, 64, 64, 64, 0, },
            { 0, 64, 64, 64, 64, 64, 64, 64, 0, },
            { 0, 0, 64, 64, 64, 64, 64, 0, 0, },
            { 0, 0, 64, 64, 64, 64, 64, 0, 0, },
            { 0, 0, 0, 0, 0, 0, 0, 0, 0, }
        };

        public King(ChessColor color) : base(color)
        {
            Pattern = pattern;
        }

        public override ICollection<IMovement> Move(IMovementStrategy strategy)
        {
            return strategy.GetMovements(this.GetType().Name);
        }
    }
}
