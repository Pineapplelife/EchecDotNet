using System;
using System.Collections.Generic;
using System.Text;

namespace Fr.Coding.ChessMate.Models
{
    public class Cavalier : Piece
    {
        // TODO remplir les conditions de deplacement 
        public override bool IsValideMove(int xStart, int yStart, int xEnd, int yEnd)
        {
            if ((xEnd - xStart) + (yEnd - yStart) == 3 && (xEnd != xStart) && (yEnd != yStart)) {
                Console.WriteLine("Mouvement possible");
                return true;
            }
            else {
                Console.WriteLine("Mouvement impossible");
                return false;
            }
        }
    }
}
