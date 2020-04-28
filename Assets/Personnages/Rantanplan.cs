using System;
using System.Collections.Generic;
using System.Text;

namespace Labynov
{
    public class Rantanplan : Personnage
    {
        public int obeissance { get; set; }
        public int vies { get; set; }

        public int faim { get; set; }

        public int viesMax { get; set; }

        public bool inteligent = false;
        public Rantanplan(int x, int y , int vies , int faim, int obeissance) : base(x, y)
        {
            this.name = "Rantanplan";
            this.vies = vies;
            this.viesMax = vies;
            this.faim = faim;
            this.obeissance = obeissance;
            this.signe = "R";
        }
        
        public bool perdreUneVieEtMeurt()
        {
            this.vies -= 1;
            this.faim += this.obeissance / this.viesMax;
            this.obeissance -= this.faim / this.viesMax;
            if(this.vies == 0)
            {
                return true;
            }
            return false;
        }
        //Partie réflexion de rantanplan (il risque d'il y avoir de l'aléatoire )
        public ChoixRantanplan choisieDirection(List<ChoixRantanplan> choix)
        {
            return choix[1];
        }
    }
}
