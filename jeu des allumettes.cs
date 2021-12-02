using System;

namespace ConsoleApp1
{
    class Jeu_Des_Allumettes
    {
        static void Main (string[] args)
        {
            int nbAllumettes;
            int choixJoueur;
            int choixOrdinateur;
            Random random = new Random();

            Console.WriteLine(" Bienvenue dans ce programme de jeu des allumettes ");
            Console.WriteLine(" Appuyez sur une touche pour continuer ");
            Console.ReadKey();

            Console.WriteLine("\n Combien d'allumettes voulez-vous utiliser ? Veuillez entrer un nombre ");
            nbAllumettes =  Int32.Parse(Console.ReadLine());

            Console.WriteLine("\n Vous avez choisi de jouer avec " + nbAllumettes + " allumettes ");
            Console.WriteLine(" Appuyez sur une touche pour continuer ");
            Console.ReadKey();

            int nbAllumettesRestantes = nbAllumettes;

            Console.WriteLine(new string('|', nbAllumettes));

            Console.WriteLine("\n Combien d'allumettes voulez-vous prendre ? ");
            choixJoueur = Int32.Parse(Console.ReadLine());

            if (choixJoueur > 0 && choixJoueur < 4 && choixJoueur <= nbAllumettesRestantes)
            {
                nbAllumettesRestantes -= choixJoueur;
                Console.WriteLine("\n Vous avez retiré " + choixJoueur + " Allumette ");
                Console.Write(new string(' ', choixJoueur) + new string('|', nbAllumettesRestantes));
            }
            else
            {
                Console.WriteLine("\n Choisissez un nombre valide d'allumettes ");
                
            }

            if (nbAllumettes == 0)
            {
                Console.WriteLine("\n Vous avez perdu ");
            }

            if ( nbAllumettesRestantes <= 4 && nbAllumettesRestantes > 1)
            {
                choixOrdinateur = nbAllumettesRestantes - 1;
            }
            else if ( nbAllumettesRestantes == 1)
            {
                choixOrdinateur = 1;
            }
            else
            {
                choixOrdinateur = random.Next(1, 3 + 1);
            }

            Console.WriteLine(" \n L'ordinateur a retiré " + choixOrdinateur + " Allumettes ");
            nbAllumettesRestantes -= choixOrdinateur;
            Console.Write(new string(' ', choixJoueur) + new string (' ', choixOrdinateur) + new string('|', nbAllumettesRestantes));   

            if ( nbAllumettesRestantes == 0)
            {
                Console.WriteLine("\n Vous avez gagné, l'ordinateur a retiré la dernière allumette ! ");
            }

            while (nbAllumettesRestantes > 0)
            {
                Console.WriteLine("\n Combien d'allumettes voulez-vous prendre ? ");
                choixJoueur = Int32.Parse(Console.ReadLine());

                if (choixJoueur > 0 && choixJoueur < 4 && choixJoueur <= nbAllumettesRestantes)
                {
                    nbAllumettesRestantes -= choixJoueur;
                    Console.WriteLine(" Vous avez retiré " + choixJoueur + " Allumette ");
                    Console.Write(new string(' ', choixJoueur) + new string(' ', choixOrdinateur) + new string('|', nbAllumettesRestantes));
                }
                else
                {
                    Console.WriteLine(" Choisissez un nombre valide d'allumettes ");
           
                }
                if (nbAllumettes == 0)
                {
                    Console.WriteLine(" Vous avez perdu ");
                    break;
                }


                if (nbAllumettesRestantes <= 4 && nbAllumettesRestantes > 1)
                {
                    choixOrdinateur = nbAllumettesRestantes - 1;
                }
                else if (nbAllumettesRestantes == 1)
                {
                    choixOrdinateur = 1;
                }
                else
                {
                    choixOrdinateur = random.Next(1, 3 + 1);
                }

                Console.WriteLine(" \n L'ordinateur a retiré " + choixOrdinateur + " Allumettes ");
                nbAllumettesRestantes -= choixOrdinateur;
                Console.Write(new string(' ', choixJoueur) + new string(' ', choixOrdinateur) + new string('|', nbAllumettesRestantes));

                if (nbAllumettesRestantes == 0)
                {
                    Console.WriteLine("\n Vous avez gagné, l'ordinateur a retiré la dernière allumette ! ");                  
                }

            }

            if (nbAllumettesRestantes == 0)
            {
                Console.WriteLine("\n Il n'y a plus d'allumettes, la partie est terminée ! A bientôt ! ");
                Console.WriteLine("\n Appuyez sur une touche pour terminer le jeu ");
                Console.ReadKey();
            }

        }
    }
}
