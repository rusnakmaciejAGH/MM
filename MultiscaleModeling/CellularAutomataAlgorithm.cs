using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace grain_growth
{
    public class CellularAutomataAlgorithm : AlgorithmBase
    {
        public void AddRandomGrains(int number)
        {
            int[] notUsedIds = this.GetNotUsedIds();

            for (int i = 0; i < number; ++i)
            {
                if (i < notUsedIds.Length)
                {
                    Cell c;
                    do
                    {
                        c = this.grid.GetCell(RandomHelper.Next(this.Width), RandomHelper.Next(this.Height));
                    } while (c.ID != 0 || c.Selected);

                    c.ID = notUsedIds[i];
                }

                else
                {
                    break;
                }
            }
        }
        public bool Step()
        {
            int changes = 0;

            this.grid.ResetCurrentCellPosition();

            do
            {
                if (this.grid.CurrentCell.ID == 0)
                {
                    if (this.Moore(this.grid.CurrentCell))
                    {
                        ++changes;
                    }
                }
            } while (this.grid.Next());

            if (changes > 0)
            {
                this.grid.CopyNewIDtoID();

                return true;
            }

            return false;
        }
        protected bool Moore(Cell c)
        {
            CounterReturn cr = this.MooreMostCommonCell(c);
            
            if (cr != null)
            {
                this.grid.CurrentCell.NewID = cr.ID;
                return true;
            }

            return false;
        }
        protected CounterReturn MooreMostCommonCell(Cell c)
        {
            Counter counter = new Counter();

            counter.AddCells(c.MoorNeighborhood);

            return counter.MostCommonID;
        }
    }
}
