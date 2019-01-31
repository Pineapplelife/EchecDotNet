﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Fr.Coding.ChessMate.Models
{
    class Tour : Piece
    {
        // TODO remplir les conditions de deplacement 
        public override bool IsValideMove(int xStart, int yStart, int xEnd, int yEnd)
        {

            //cliquer sur piece pour recuperer coordonnee de depart,
            //cliquer sur une case pour recuperer coordonnee d'arrivée
            //comparer et valider si true ou false.

            if (xStart == xEnd || yStart == yEnd)
            {
                Console.WriteLine("Mouvement OK");
                return true;
            }
            else
            {
                Console.WriteLine("Mouvement Interdit");
                return false;
            }
        }
    }
}
