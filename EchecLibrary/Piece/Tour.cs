using System;
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

            if (int xStart == int xEnd) || (int yStart == int yEnd)
            {
                return true;
                Console.WriteLine(Mouvement OK);
            }
            else
            {
                return false;
                Console.WriteLine(Mouvement Interdit);
            }

            throw new NotImplementedException();
        }
    }
}
