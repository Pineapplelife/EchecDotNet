﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Fr.Coding.ChessMate.Models {
    class Pion : Piece {
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
    }
}
