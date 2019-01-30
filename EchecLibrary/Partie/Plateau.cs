using System;
using System.Collections.Generic;
using System.Text;

namespace Fr.Coding.ChessMate.Partie
{

    class Plateau : Partie {

        Piece[,] echiquier = new Piece[8, 8];

        public void afficherPlateau ()
        {
            for (int i = 0; i<Piece[i].length; i++)
			{
                for (int y = 0; y < Piece[y].length; y++)
                {
                    Console.WriteLine(Piece[i, y]);
                }
                
			}     
        }
           

    }
}
