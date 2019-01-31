using System;
using System.Collections.Generic;
using System.Text;

namespace Fr.Coding.ChessMate.Models
{
    public class Cavalier : Piece
    {
        // TODO remplir les conditions de deplacement 
        public override bool IsValidMove(int xStart, int yStart, int xEnd, int yEnd)
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
        public override bool IsTrajectoireLibre(int xStart, int yStart, int xEnd, int yEnd, Piece[,] echiquier)
        {
            if (0 < xEnd && xEnd < 7 && 0 < yEnd && yEnd < 7)
            {
                if (echiquier[xStart + 2, yStart + 1] != null)
                {
                    return false;
                }
                else if (echiquier[xStart + 2, yStart - 1] != null)
                {
                    return false;
                }
                else if (echiquier[xStart + 1, yStart + 2] != null)
                {
                    return false;
                }
                else if (echiquier[xStart + 1, yStart - 2] != null)
                {
                    return false;
                }
                //DELIMITATION
                //DELIMITATION
                else if (echiquier[xStart - 2, yStart + 1] != null)
                {
                    return false;
                }
                else if (echiquier[xStart - 2, yStart - 1] != null)
                {
                    return false;
                }
                else if (echiquier[xStart - 1, yStart + 2] != null)
                {
                    return false;
                }
                else if (echiquier[xStart - 1, yStart - 2] != null)
                {
                    return false;
                }
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
