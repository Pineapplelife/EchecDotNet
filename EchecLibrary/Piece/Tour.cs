using System;
using System.Collections.Generic;
using System.Text;

namespace Fr.Coding.ChessMate.Models {

    public class Tour : Piece {

        public Tour(bool couleur)
        {
            couleur = this.Couleur;
        }

        // TODO remplir les conditions de deplacement 
        public override bool IsValidMove(int xStart, int yStart, int xEnd, int yEnd) {

            //cliquer sur piece pour recuperer coordonnee de depart,
            //cliquer sur une case pour recuperer coordonnee d'arrivée
            //comparer et valider si true ou false.

            if (xStart == xEnd || yStart == yEnd) {
                Console.WriteLine("Mouvement OK");
                return true;
            }
            else {
                Console.WriteLine("Mouvement Interdit");
                return false;
            }
        }
        public override bool IsTrajectoireLibre(int xStart, int yStart, int xEnd, int yEnd, Piece[,] echiquier)
        {
            if (0 < xEnd && xEnd < 7 && this.IsValidMove(xStart, yStart, xEnd, yEnd) == true)
            {
                if (xStart < xEnd)
                {
                    //HORIZONTAL DROITE
                    while (xStart < xEnd) {

                        if (echiquier[xStart, yStart] == null)
                        {
                            xStart++;
                            continue;

                        }
                        else {
                            if(echiquier[xEnd, yEnd] != null) {
                                IsArriveeOnEnnemy(xEnd, yEnd, echiquier);
                            }
                            else {
                                return false;
                            }
                        }
                    }
                }
                else if (xStart > xEnd) {

                    //HORIZONTAL GAUCHE
                    //HORIZONTAL GAUCHE
                    while (xStart > xEnd) {
                        if (echiquier[xStart, yStart] == null) {
                            xStart--;
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
            }
            else {
                return false;
            }

            if (0 < yStart && yStart < 7) {

                if (yStart < yEnd) {

                    //VERTICALE BAS
                    while (yStart < yEnd) {
                        if (echiquier[xStart, yStart] == null) {
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
                else if (yStart > yEnd) {

                    //VERTICALE HAUT
                    while (yStart > yEnd) {
                        if (echiquier[xStart, yStart] == null) {
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
            }
            else {
                return false;
            }
            return true;
        }
    }
}
