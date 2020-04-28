using System;

namespace Labynov
{
    class Program
    {
        static void Main(string[] args)
        {
            Map plateauJeu = new Map(110, 20);
            plateauJeu.creerAvrel(105, 19);
            plateauJeu.creerDalton(102, 19, "Joe");
            plateauJeu.creerDalton(0, 0, "Jack");
            plateauJeu.creerDalton(109, 0, "William");
            plateauJeu.creerRantanplan(55, 10, 5, 50, 50);
            plateauJeu.toString();
        }
    }
}
