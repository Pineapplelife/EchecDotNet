using System;

namespace Fr.Coding.ChessMate.Models
{
    public abstract class Piece
    {
        public bool couleur { get; set; }
        string nom;

        public abstract bool IsValidMove(int xStart, int yStart, int xEnd, int yEnd);

        //TODO faire la vérif pour tour fou reine pion /!\ pas le roi et le cavalier
        public virtual bool IsTrajectoireLibre(int xStart, int yStart, int xEnd, int yEnd, Piece[][] echiquier)
        {
            return true;
        }

    }
}
