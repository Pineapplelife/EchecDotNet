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
            if (Math.Abs(a) == 1 && Math.Abs(b) == 1)
            {
                return true;
            }
            else if (Math.Abs(a) == 1 && Math.Abs(b) < 1)
            {
                return true;
            }
            else if (Math.Abs(b) == 1 && Math.Abs(a) < 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override bool IsTrajectoireLibre(int xStart, int yStart, int xEnd, int yEnd, Piece[,] echiquier)
        {
            if (0 < xEnd && xEnd < 7 && 0 < yEnd && yEnd < 7)
            {
                //SE DEPLACE A DROITE
                if (echiquier[xStart + 1, yStart] != null)
                {
                    if (echiquier[xEnd, yEnd] != null) {
                        IsArriveeOnEnnemy(xEnd, yEnd, echiquier);
                    }
                    else {
                        return false;
                    }
                }
                //SE DEPLACE A GAUCHE
                else if (echiquier[xStart - 1, yStart] != null)
                {
                    if (echiquier[xEnd, yEnd] != null) {
                        IsArriveeOnEnnemy(xEnd, yEnd, echiquier);
                    }
                    else {
                        return false;
                    }
                }
                //SE DEPLACE EN BAS
                else if (echiquier[xStart, yStart + 1] != null)
                {
                    if (echiquier[xEnd, yEnd] != null) {
                        IsArriveeOnEnnemy(xEnd, yEnd, echiquier);
                    }
                    else {
                        return false;
                    }
                }
                //SE DEPLACE EN HAUT
                else if (echiquier[xStart, yStart - 1] != null)
                {
                    if (echiquier[xEnd, yEnd] != null) {
                        IsArriveeOnEnnemy(xEnd, yEnd, echiquier);
                    }
                    else {
                        return false;
                    }
                }
                //DIAGONALE BAS DROITE
                else if (echiquier[xStart + 1, yStart + 1] != null)
                {
                    if (echiquier[xEnd, yEnd] != null) {
                        IsArriveeOnEnnemy(xEnd, yEnd, echiquier);
                    }
                    else {
                        return false;
                    }
                }
                //DIAGONALE HAUT GAUCHE
                else if (echiquier[xStart - 1, yStart - 1] != null)
                {
                    if (echiquier[xEnd, yEnd] != null) {
                        IsArriveeOnEnnemy(xEnd, yEnd, echiquier);
                    }
                    else {
                        return false;
                    }
                }
                //DIAGONALE HAUT DROITE
                else if (echiquier[xStart + 1, yStart - 1] != null)
                {
                    if (echiquier[xEnd, yEnd] != null) {
                        IsArriveeOnEnnemy(xEnd, yEnd, echiquier);
                    }
                    else {
                        return false;
                    }
                }
                //DIAGONALE BAS GAUCHE
                else if (echiquier[xStart - 1, yStart + 1] != null)
                {
                    if (echiquier[xEnd, yEnd] != null) {
                        IsArriveeOnEnnemy(xEnd, yEnd, echiquier);
                    }
                    else {
                        return false;
                    }
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
