using Fr.Coding.ChessMate.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fr.Coding.ChessMate
{

    public class Plateau {

        public Plateau()
        {
            echiquier = new Piece[8, 8];
            pN1= new Pion(false);
            pN2= new Pion(false);
            pN3= new Pion(false);
            pN4= new Pion(false);
            pN5= new Pion(false);
            pN6= new Pion(false);
            pN7= new Pion(false);
            pN8= new Pion(false);

            pB1 =new Pion(true);
            pB2= new Pion(true);
            pB3= new Pion(true);
            pB4= new Pion(true);
            pB5= new Pion(true);
            pB6= new Pion(true);
            pB7= new Pion(true);
            pB8= new Pion(true);

            cavN1 = new Cavalier(false);
            cavN2 = new Cavalier(false);

            cavB1 = new Cavalier(true);
            cavB2 = new Cavalier(true);

            fouN1 = new Fou(false);
            fouN2 = new Fou(false);

            fouB1 = new Fou(true);
            fouB2 = new Fou(true);

            tourN1 = new Tour(false);
            tourN2 = new Tour(false);

            tourB1 = new Tour(true);
            tourB2 = new Tour(true);

            reineN = new Reine(false);
            reineB = new Reine(true);

            roiN = new Roi(false);
            roiB = new Roi(true);
            roiB.Couleur = true;

            initierPlateau(echiquier);
        }

        public Piece[,] echiquier { get; set; }

        //Création Pions noir
        Piece pN1;
        Piece pN2;
        Piece pN3;
        Piece pN4;
        Piece pN5;
        Piece pN6;
        Piece pN7;
        Piece pN8;
                 
        //Créatio;
        Piece pB1;
        Piece pB2;
        Piece pB3;
        Piece pB4;
        Piece pB5;
        Piece pB6;
        Piece pB7;
        Piece pB8;

        //Création Cavaliers noir
        Piece cavN1; 
        Piece cavN2; 
                   
        //Création ;C
        Piece cavB1; 
        Piece cavB2; 
                   
        //Création ;F
        Piece fouN1; 
        Piece fouN2; 
                   
        //Création ;F
        Piece fouB1; 
        Piece fouB2; 
                   
        //Création ;T
        Piece tourN1;
        Piece tourN2;
                   
        //Création ;T
        Piece tourB1;
        Piece tourB2;
                   
        //Création ;R
        Piece reineN;
        Piece reineB;
                   
        //Création ;R
        Piece roiN;
        Piece roiB;



        public void initierPlateau(Piece[,] echiquier)
        {
            //Placement ligne blanche
            echiquier[0, 0] = tourB1;
            echiquier[0, 1] = cavB1;
            echiquier[0, 2] = fouB1;
            echiquier[0, 3] = roiB;
            echiquier[0, 4] = reineB;
            echiquier[0, 5] = fouB2;
            echiquier[0, 6] = cavB2;
            echiquier[0, 7] = tourB2;

            //Placement pions blancs
            echiquier[1, 0] = pB1;
            echiquier[1, 1] = pB2;
            echiquier[1, 2] = pB3;
            echiquier[1, 3] = pB4;
            echiquier[1, 4] = pB5;
            echiquier[1, 5] = pB6;
            echiquier[1, 6] = pB7;
            echiquier[1, 7] = pB8;

            //Placement pions noirs
            //echiquier[6, 0] = pN1;
            echiquier[6, 1] = pN2;
            echiquier[6, 2] = pN3;
            echiquier[6, 3] = pN4;
            echiquier[6, 4] = pN5;
            echiquier[6, 5] = pN6;
            echiquier[6, 6] = pN7;
            echiquier[6, 7] = pN8;

            //Placement ligne noire
            echiquier[7, 0] = tourN1;
            echiquier[7, 1] = cavN1;
            echiquier[7, 2] = fouN1;
            echiquier[7, 3] = roiN;
            echiquier[7, 4] = reineN;
            echiquier[7, 5] = fouN2;
            echiquier[7, 6] = cavN2;
            echiquier[7, 7] = tourN2;



        }

        public void afficherPlateau (Piece[,] echiquier)
        {
            for (int i = 0; i< 8; i++)
			{

                for (int y = 0; y < 8; y++)
                {
                    Console.WriteLine("|");
                }
                
			}     
        }
           

    }
}
