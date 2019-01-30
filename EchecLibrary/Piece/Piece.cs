using System;

namespace Fr.Coding.ChessMate.Models
{
    public abstract class Piece
    {
        bool couleur;
        string nom;

        public abstract bool IsValideMove(int xStart, int yStart, int xEnd, int yEnd);

        //TODO faire la vérif pour tour fou reine pion /!\ pas le roi et le cavalier
        public virtual bool IsTrajectoireLibre(int xStart, int yStart, int xEnd, int yEnd, Piece[][] echiquier)
        {
            return true;
        }

    }
}
