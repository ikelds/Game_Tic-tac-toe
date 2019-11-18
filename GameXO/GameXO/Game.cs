using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameXO
{
    class Game
    {
        int[] massiv = new int[9];


        public int currenValueInMassiv(int tag)
        {
            return massiv[tag];
        }

        public void setValue_O_InMassiv(int tag)
        {
            massiv[tag] = 1;
        }

        public void setValue_X_InMassiv(int tag)
        {
            massiv[tag] = 2;
        }

        public int checkToEnd()
        {
            if (massiv[0] == massiv[1] & massiv[1] == massiv[2] & massiv[0] != 0)
                return massiv[0];

            if (massiv[3] == massiv[4] & massiv[4] == massiv[5] & massiv[3] != 0)
                return massiv[3];

            if (massiv[6] == massiv[7] & massiv[7] == massiv[8] & massiv[6] != 0)
                return massiv[6];

            if (massiv[0] == massiv[3] & massiv[3] == massiv[6] & massiv[0] != 0)
                return massiv[0];

            if (massiv[1] == massiv[4] & massiv[4] == massiv[7] & massiv[1] != 0)
                return massiv[1];

            if (massiv[2] == massiv[5] & massiv[5] == massiv[8] & massiv[2] != 0)
                return massiv[2];

            if (massiv[0] == massiv[4] & massiv[4] == massiv[8] & massiv[0] != 0)
                return massiv[0];

            if (massiv[6] == massiv[4] & massiv[4] == massiv[2] & massiv[6] != 0)
                return massiv[6];

            if (!massiv.Contains(0))
                return 100;

            return 999;
        }

        public void newGame()
        {
            for (int i = 0; i < 9; i++)
                massiv[i] = 0;
        }
  
    }
}
