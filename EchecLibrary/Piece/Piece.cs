using System;

namespace Fr.Coding.ChessMate.Models
{
    public abstract class Piece
    {
        public bool couleur { get; set; }
        string nom;

        public abstract bool IsValidMove(int xStart, int yStart, int xEnd, int yEnd);

        //TODO faire la vérif pour tour fou reine pion /!\ pas le roi et le cavalier
        public virtual bool IsTrajectoireLibre(int xStart, int yStart, int xEnd, int yEnd, Piece[,] echiquier)
        {
            return true;
        }

        //Méthode qui vérifie si il y a un ennemi sur la case d'arrivée et dans ce cas là appeler la méthode Manger() (nom provisoire) 
        public virtual bool IsArriveeOnEnnemy(int xEnd, int yEnd, Piece[,] echiquier) {
            
            if(echiquier[xEnd, yEnd].couleur != this.couleur) {
                Console.WriteLine("MIAM");
                //Manger();
                return true;
            }
            else {
                Console.WriteLine("Déplacement impossible");
                return false;
            }
        }
    }
}
