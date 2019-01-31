using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fr.Coding.ChessMate.Models;

namespace Fr.Coding.ChessMate
{
    public class Partie
    {
        bool MainCourante = true;
        public Plateau plateau { get; set; }
        public Partie()
        {
            plateau = new Plateau();
        }

        public void Jouer(int xStart, int yStart, int xEnd, int yEnd)
        {
            
        }
    }
}
