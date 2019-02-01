using System;
using System.Collections.Generic;
using System.Text;

namespace Fr.Coding.ChessMate.Models {
    public class Pion : Piece {
        private bool firstmove = true;
        public bool othermove = false;
        // TODO remplir les conditions de deplacement 
        public override bool IsValidMove(int xStart, int yStart, int xEnd, int yEnd) {
            if (this.firstmove == true) {
                if (yStart + 2 == yEnd || yStart + 1 == yEnd) {
                    this.firstmove = false;
                    this.othermove = false;
                    return true;
                }
                else {
                    return false;
                }
            }
            else if (this.othermove == true) {
                if (yStart + 1 == yEnd) {
                    return true;
                }
                /*else if () {
                    //en diagonale pour manger un ennemi
                }*/
                else {
                    return false;
                }
            }
            else {
                return false;
            }
        }
        public override bool IsTrajectoireLibre(int xStart, int yStart, int xEnd, int yEnd, Piece[,] echiquier)
        {
            //COULEUR PION == TRUE
            if (echiquier[xStart, yStart + 1] == null)
            {
                return true;
            }
            //CONLEUR PION == FALSE
            else if (echiquier[xStart, yStart - 1] == null)
            {
                return true;
            }
            else if (echiquier[yStart + 1, xStart] == null && echiquier[yStart, xStart + 1] == null)
            {
                return true;
            }
            else if (echiquier[yStart + 1, xStart] == null && echiquier[yStart, xStart - 1] == null)
            {
                return true;
            }
            else
            {
                return false;
            }
            //DELIMITATION
        }
    }
}
