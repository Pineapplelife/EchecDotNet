using System;
using System.Collections.Generic;
using System.Text;

namespace Fr.Coding.ChessMate.Models
{
    public class Fou : Piece
    {
        private int testX;
        private int testY;

        // TODO remplir les conditions de deplacement 
        public override bool IsValidMove(int xStart, int yStart, int xEnd, int yEnd)
        {
            testX = xStart - yStart;
            testY = xEnd - yEnd;

            if (testX == testY)
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
            if (0 < xEnd && xEnd < 7 && 0 < yEnd && yEnd < 7) {
                //Diagonale BAS Droit
                if (xStart < xEnd && yStart < yEnd) {
                    while (xStart < xEnd && yStart < yEnd) {
                        if (echiquier[xStart, yStart] == null) {
                            xStart++;
                            yStart++;
                            continue;
                        }
                        else {
                            if (echiquier[xEnd, yEnd] != null) {
                                IsArriveeOnEnnemy(xEnd, yEnd, echiquier);
                            }
                            else {
                                return false;
                            }
                        }
                    }
                }
                //Diagonale HAUT Gauche
                else if (xStart > xEnd && yStart > yEnd) {
                    while (xStart > xEnd && yStart > yEnd) {
                        if (echiquier[xStart, yStart] == null) {
                            xStart--;
                            yStart--;
                            continue;
                        }
                        else {
                            if (echiquier[xEnd, yEnd] != null) {
                                IsArriveeOnEnnemy(xEnd, yEnd, echiquier);
                            }
                            else {
                                return false;
                            }
                        }
                    }
                }
                //DIAGONALE BAS GAUCHE 
                else if (xStart > xEnd && yStart < yEnd) {
                    while (xStart > xEnd && yStart < yEnd) {
                        if (echiquier[xStart, yStart] == null) {
                            xStart--;
                            yStart++;
                            continue;
                        }
                        else {
                            if (echiquier[xEnd, yEnd] != null) {
                                IsArriveeOnEnnemy(xEnd, yEnd, echiquier);
                            }
                            else {
                                return false;
                            }
                        }
                    }
                }
                //DIAGONALE HAUT DROIT
                else if (xStart < xEnd && yStart > yEnd) {
                    while (xStart < xEnd && yStart > yEnd) {
                        if (echiquier[xStart, yStart] == null) {
                            xStart++;
                            yStart--;
                            continue;
                        }
                        else {
                            if (echiquier[xEnd, yEnd] != null) {
                                IsArriveeOnEnnemy(xEnd, yEnd, echiquier);
                            }
                            else {
                                return false;
                            }
                        }
                    }
                }
                return true;
            }
            else {
                return false;
            }
        }
    }
}
