using System;
using System.Collections.Generic;
using System.Text;

namespace Fr.Coding.ChessMate.Models
{
    public class Reine : Piece
    {
        private int testX;
        private int testY;

        public Reine(bool couleur)
        {
            this.Couleur = couleur;
        }

        // TODO remplir les conditions de deplacement 
        public override bool IsValidMove(int xStart, int yStart, int xEnd, int yEnd)
        {
            testX = xStart - yStart;
            testY = xEnd - yEnd;

            if (testX == testY)
            {
                return true;
            }
            else if (xStart == xEnd || yStart == yEnd)
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
            if (0 < xEnd && xEnd < 7)
            {
                if (xStart < xEnd)
                {
                    while (xStart < xEnd)
                    {
                        if (echiquier[xStart, yStart] == null)
                        {
                            xStart++;
                            continue;

                        }
                        else
                        {
                            if (echiquier[xEnd, yEnd] != null) {
                                IsArriveeOnEnnemy(xEnd, yEnd, echiquier);
                            }
                            else {
                                return false;
                            }
                        }

                    }
                }
                else if (xStart > xEnd)
                {
                    while (xStart > xEnd)
                    {
                        if (echiquier[xStart, yStart] == null)
                        {
                            xStart--;
                            continue;
                        }
                        else
                        {
                            if (echiquier[xEnd, yEnd] != null) {
                                IsArriveeOnEnnemy(xEnd, yEnd, echiquier);
                            }
                            else {
                                return false;
                            }
                        }
                    }
                }
            }
            else
            {
                return false;
            }
            if (0 < yStart && yStart < 7)
            {
                if (yStart < yEnd)
                {
                    while (yStart < yEnd)
                    {
                        if (echiquier[xStart, yStart] == null)
                        {
                            yStart++;
                            continue;

                        }
                        else
                        {
                            if (echiquier[xEnd, yEnd] != null) {
                                IsArriveeOnEnnemy(xEnd, yEnd, echiquier);
                            }
                            else {
                                return false;
                            }
                        }

                    }
                }
                else if (yStart > yEnd)
                {
                    while (yStart > yEnd)
                    {
                        if (echiquier[xStart, yStart] == null)
                        {
                            yStart--;
                            continue;
                        }
                        else
                        {
                            if (echiquier[xEnd, yEnd] != null) {
                                IsArriveeOnEnnemy(xEnd, yEnd, echiquier);
                            }
                            else {
                                return false;
                            }
                        }
                    }
                }
            }
            else
            {
                return false;
            }
            if (0 < xEnd && xEnd < 7 && 0 < yEnd && yEnd < 7)
            {
                //Diagonale Haut Droit
                if (xStart < xEnd && yStart < yEnd)
                {
                    while (xStart < xEnd && yStart < yEnd)
                    {
                        if (echiquier[xStart, yStart] == null)
                        {
                            xStart++;
                            yStart++;
                            continue;
                        }
                        else
                        {
                            if (echiquier[xEnd, yEnd] != null) {
                                IsArriveeOnEnnemy(xEnd, yEnd, echiquier);
                            }
                            else {
                                return false;
                            }
                        }
                    }
                }
                //Diagonale Bas Gauche
                else if (xStart > xEnd && yStart > yEnd)
                {
                    while (xStart > xEnd && yStart > yEnd)
                    {
                        if (echiquier[xStart, yStart] == null)
                        {
                            xStart--;
                            yStart--;
                            continue;
                        }
                        else
                        {
                            if (echiquier[xEnd, yEnd] != null) {
                                IsArriveeOnEnnemy(xEnd, yEnd, echiquier);
                            }
                            else {
                                return false;
                            }
                        }
                    }
                }
                //
                else if (xStart > xEnd && yStart < yEnd)
                {
                    while (xStart > xEnd && yStart < yEnd)
                    {
                        if (echiquier[xStart, yStart] == null)
                        {
                            xStart--;
                            yStart++;
                            continue;
                        }
                        else
                        {
                            if (echiquier[xEnd, yEnd] != null) {
                                IsArriveeOnEnnemy(xEnd, yEnd, echiquier);
                            }
                            else {
                                return false;
                            }
                        }
                    }
                }
                //
                else if (xStart < xEnd && yStart > yEnd)
                {
                    while (xStart < xEnd && yStart > yEnd)
                    {
                        if (echiquier[xStart, yStart] == null)
                        {
                            xStart++;
                            yStart--;
                            continue;
                        }
                        else
                        {
                            if (echiquier[xEnd, yEnd] != null) {
                                IsArriveeOnEnnemy(xEnd, yEnd, echiquier);
                            }
                            else {
                                return false;
                            }
                        }
                    }
                }
            }
            return true;
        }
    }
}
