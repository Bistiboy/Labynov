using System;
using System.Collections.Generic;
using System.Text;

namespace Labynov
{
   unsafe class Map
    {
        public int sizeY { get; set; }

        public int sizeX { get; set; }
        public List<Case> sousSol { get; set; }

        public List<Dalton> mechants = new List<Dalton>();

        public Avrel avrel { get; set; }

        public Rantanplan rantanplan { get; set; }
        public Map()
        {//initialisation de la map par défaut
            this.sizeY = 100;
            this.sizeX = 100;
            this.sousSol = new List<Case>();
            for (int y = 0; y < 50; y++)
            {
                for (int x = 0; x < 100; x++)
                {
                    //Création des cases
                    Case newCase = new Case(x, x);
                    this.sousSol.Add(newCase);
                }
            }
        }
        public Map(int X, int Y)
        {//initialisation de la map de la taille demandé
            this.sizeY = Y;
            this.sizeX = X;
            this.sousSol = new List<Case>();
            for (int y = 0; y < this.sizeY; y++)
            {
                for (int x = 0; x < this.sizeX; x++)
                {
                    //Création des cases
                    Case newCase = new Case(x, x);
                    this.sousSol.Add(newCase);
                }
            }
        }
        //Visuel pour dev
        public void toString()
        {
            foreach ( Case @case in this.sousSol)
            {

                Console.Write(@case.occupePar);

                if (@case.x == sizeX-1)
                {
                    Console.Write("\n");
                }
            }
        }
        public bool estDansSousSol(int index)
        {
            if (index < 0 || index > this.sousSol.Count)
            {
                return false;
            }
            return true;
        }
        public void libererCase(int x ,int y)
        {
            //On calcul l'index de la case dans le tableau et on libere
            this.sousSol[(y * (this.sizeX - 1)) + x].seLibere();
        }
        public void occuperCase(int x, int y , string obstacle)
        {
            //On calcul l'index de la case dans le tableau et on occupe
            this.sousSol[(y * (this.sizeX - 1)) + x].soccupe(obstacle);
        }
        public bool estLibreNord(int x , int y)
        {
            //On calcul l'index de la case dans le tableau et on vérifie pour la ligne d'au dessus .
            int indexCalc = ((y * (this.sizeX - 1)) + x) - this.sizeX;
            if (this.estDansSousSol(indexCalc) && this.sousSol[indexCalc].estLibre() )
            {
                return true;
            }
            else
            {
                return false ;
            }
            
        }
        public bool estLibreSud(int x ,int y)
        {
            //On calcul l'index de la case dans le tableau et on vérifie pour la ligne d'en dessous .
            int indexCalc = ((y * (this.sizeX - 1)) + x) + this.sizeX;
            if (this.estDansSousSol(indexCalc) && this.sousSol[indexCalc].estLibre())
            {
                return true ;
            }
            else
            {
                return false;
            }

        }
        public bool estLibreOuest(int x, int y)
        {
            //On calcul l'index de la case dans le tableau et on vérifie pour la case suivante .
            int indexCalc = ((y * (this.sizeX - 1)) + x) + 1;
            if (this.estDansSousSol(indexCalc) && this.sousSol[indexCalc].estLibre())
            {
                return true;
            }
            else
            {
                return false ;
            }

        }
        public bool estLibreEst(int x, int y)
        {
            //On calcul l'index de la case dans le tableau et on vérifie pour la case précédente .
            int indexCalc = ((y * (this.sizeX - 1)) + x) - 1;
            if (this.estDansSousSol(indexCalc) && this.sousSol[indexCalc].estLibre())
            {
                return true ;
            }
            else
            {
                return false;
            }

        }
        public void creerAvrel(int x, int y)
        {
            this.avrel = new Avrel(x, y);
            this.occuperCase(x, y, this.avrel.signe);
        }
        public void creerDalton(int x , int y, string name)
        {
            Dalton dalton = new Dalton(x, y, name);
            this.occuperCase(x, y, dalton.signe);
            this.mechants.Add(dalton);
        }
        public void creerRantanplan(int x, int y, int vies, int faim , int obeissance)
        {
            this.rantanplan = new Rantanplan(x, y , vies, faim, obeissance);
            this.occuperCase(x, y, rantanplan.signe);
        }
    }
}
