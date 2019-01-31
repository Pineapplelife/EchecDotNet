using System;
using System.Collections.Generic;
using System.Text;

namespace Fr.Coding.ChessMate.Models
{
    public class Roi : Piece
    {
        private int a;
        private int b;
        // TODO remplir les conditions de deplacement 
        public override bool IsValidMove(int xStart, int yStart, int xEnd, int yEnd)
        {
            a = xEnd - xStart;
            b = yEnd - yStart;
            if(Math.Abs(a) == 1 && Math.Abs(b) == 1) {
                return true;
            }
            else if(Math.Abs(a) == 1 && Math.Abs(b) < 1) {
                return true;
            }
            else if(Math.Abs(b) == 1 && Math.Abs(a) < 1) {
                return true;
            }
            else {
                return false;
            }
        }
    }
}
