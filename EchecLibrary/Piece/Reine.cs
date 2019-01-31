using System;
using System.Collections.Generic;
using System.Text;

namespace Fr.Coding.ChessMate.Models
{
    class Reine : Piece
    {
        private int testX;
        private int testY;

        // TODO remplir les conditions de deplacement 
        public override bool IsValideMove(int xStart, int yStart, int xEnd, int yEnd)
        {
            testX = xStart - yStart;
            testY = xEnd - yEnd;

            if(testX == testY)
            {
                return true;
            }
            elseif (xStart == xEnd) || (yStart == yEnd)
            {
                return true;
            }
            else
            {
                return false;
            }

            throw new NotImplementedException();
        }
    }
}
