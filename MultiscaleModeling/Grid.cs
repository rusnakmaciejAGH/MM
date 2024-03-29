﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace grain_growth
{
    public class Grid
    {
        protected Cell[,] cells;
        public int Width { set; get; }
        public int Height { set; get; }
        public bool periodic;
        public int curPosX;
        public int curPosY;

        public Grid(int width, int height, bool periodic)
        {
            this.Width = width;
            this.Height = height;
            this.periodic = periodic;
            this.cells = new Cell[height, width];

            for (int i = 0; i < height; ++i)
            {
                for (int j = 0; j < width; ++j)
                {
                    this.cells[i, j] = new Cell();
                }
            }
            this.ResetCurrentCellPosition();

            do
            {

                this.CurrentCell.Neighbors = this.NeighborhoodOfCurrentCell;
            } while (this.Next());
        }

        public Cell CurrentCell
        {
            get
            {
                return this.GetCell(this.curPosX, this.curPosY);
            }
        }
        public Cell GetCell(int x, int y)
        {                     
            if (x < 0 || x >= this.Width || y < 0 || y >= this.Height)
            {
                if ( this.periodic )
                {
                    return this.cells[MathFunctions.MathMod(y, this.Height), MathFunctions.MathMod(x, this.Width)];

                }
                else
                {
                    return new Cell();
                }
            }

            else
            {
                return this.cells[y,x];
            }
        }

        public void ResetCurrentCellPosition()
        {
            this.curPosX = 0;
            this.curPosY = 0;
        }

        public void SetCurrentCellPosition(int x, int y)
        {
            this.curPosX = x;
            this.curPosY = y;
        }
        public bool Next()
        {
            if (this.curPosX == this.Width - 1 && this.curPosY == this.Height - 1)
            {
                return false;                
            }
            if (this.curPosX == this.Width - 1)
            {
                this.curPosX = 0;
                this.curPosY += 1;
            }

            else
            {
                this.curPosX += 1;
            }

            return true;
        }
        public void CopyNewIDtoID()
        {
            for (int i = 0; i < this.Height; ++i)
            {
                for (int j = 0; j < this.Width; ++j)
                {
                    this.cells[i, j].ID = this.cells[i, j].NewID;
                }
            }

            
        }

        #region Neighbors
        // Neighbors of current cell by directions of the world
        public Cell NeighborN
        {
            get
            {
                return this.GetNeighbor(0, 1);
            }
        }

        public Cell NeighborNW
        {
            get
            {
                return this.GetNeighbor(1, 1);
            }
        }

        public Cell NeighborW
        {
            get
            {
                return this.GetNeighbor(1, 0);
            }
        }

        public Cell NeighborSW
        {
            get
            {
                return this.GetNeighbor(1, -1);
            }
        }

        public Cell NeighborS
        {
            get
            {
                return this.GetNeighbor(0, -1);
            }
        }

        public Cell NeighborSE
        {
            get
            {
                return this.GetNeighbor(-1, -1);
            }
        }

        public Cell NeighborE
        {
            get
            {
                return this.GetNeighbor(-1, 0);
            }
        }

        public Cell NeighborNE
        {
            get
            {
                return this.GetNeighbor(-1, 1);
            }
        }

        protected Cell GetNeighbor(int diffX, int diffY)
        {
            return this.GetCell(this.curPosX + diffX, this.curPosY + diffY);
        }

        public Cell[] NeighborhoodOfCurrentCell
        {
            get
            {
                List<Cell> cells = new List<Cell>();

                cells.Add(this.NeighborN);
                cells.Add(this.NeighborNE);
                cells.Add(this.NeighborE);
                cells.Add(this.NeighborSE);
                cells.Add(this.NeighborS);
                cells.Add(this.NeighborSW);
                cells.Add(this.NeighborW);
                cells.Add(this.NeighborNW);

                return cells.ToArray();
            }
        }
        #endregion
    }
}
