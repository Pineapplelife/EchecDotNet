﻿using Fr.Coding.ChessMate.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fr.Coding.ChessMate
{

    public class Plateau {

        public Plateau()
        {
            echiquier = new Piece[8, 8];
            pN1= new Pion();
            pN2= new Pion();
            pN3= new Pion();
            pN4= new Pion();
            pN5= new Pion();
            pN6= new Pion();
            pN7= new Pion();
            pN8= new Pion();
            pN1.couleur = false;
            pN2.couleur = false;
            pN3.couleur = false;
            pN4.couleur = false;
            pN5.couleur = false;
            pN6.couleur = false;
            pN7.couleur = false;
            pN8.couleur = false;

            pB1 =new Pion();
            pB2= new Pion();
            pB3= new Pion();
            pB4= new Pion();
            pB5= new Pion();
            pB6= new Pion();
            pB7= new Pion();
            pB8= new Pion();

            pB1.couleur = true;
            pB2.couleur = true;
            pB3.couleur = true;
            pB4.couleur = true;
            pB5.couleur = true;
            pB6.couleur = true;
            pB7.couleur = true;
            pB8.couleur = true;

            cavN1 = new Cavalier();
            cavN2 = new Cavalier();

            cavN1.couleur = false;
            cavN2.couleur = false;

            cavB1 = new Cavalier();
            cavB2 = new Cavalier();

            cavB1.couleur = true;
            cavB2.couleur = true;

            fouN1 = new Fou();
            fouN2 = new Fou();

            fouN1.couleur = false;
            fouN2.couleur = false;

            fouB1 = new Fou();
            fouB2 = new Fou();

            fouB1.couleur = true;
            fouB2.couleur = true;

            tourN1 = new Tour();
            tourN2 = new Tour();

            tourN1.couleur = false;
            tourN2.couleur = false;

            tourB1 = new Tour();
            tourB2 = new Tour();

            tourB1.couleur = true;
            tourB2.couleur = true;

            reineN = new Reine();
            reineB = new Reine();

            reineN.couleur = false;
            reineB.couleur = true;

            roiN = new Roi();
            roiB = new Roi();

            roiN.couleur = false;
            roiB.couleur = true;

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
