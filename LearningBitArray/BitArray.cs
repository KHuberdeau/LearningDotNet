using System;
using System.Collections;

namespace LearningBitArray
{
    class BitArray
    {
        static void Main(string[] args)
        {
            BitArray enemyGrid = new BitArray(int 3);

            enemyGrid[0] = false;
            enemyGrid[1] = true;
            enemyGrid.Set(2, false);
        }
    }
}
