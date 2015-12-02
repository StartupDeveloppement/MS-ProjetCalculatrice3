using System;

namespace Projet.Niveau1.CalculatriceBasique
{
    internal class Program
    {
        
        private static void Main(string[] args)
        {
            Affichage.Afficher("Bonjour !");
            TypeOperation();
        }
        
        private static double Chiffre()
        {
            double premierChiffre = Convert.ToDouble(Console.ReadLine());
            return premierChiffre;
        }
      

        private static void TypeOperation()
        {
            Affichage.Afficher("Quelle type d'opération souhaitez vous faire :");
         
            Affichage.AffichageCouleur("1.Addition", ConsoleColor.Yellow);
            Affichage.AffichageCouleur("2.Soustraction", ConsoleColor.Blue);
			Affichage.AffichageCouleur("3.Division", ConsoleColor.Green);
            Affichage.AffichageCouleur("4.Multiplication", ConsoleColor.Red);

            Console.ForegroundColor = ConsoleColor.White;
            double premierChiffre = 0.0;
            double secondChiffre = 0.0;
            Calcul calcul = new Calcul(premierChiffre, secondChiffre);
            double resultat;
            //try parse
            string saisieClavier = Console.ReadLine();
            int result;
            bool resultatParse = int.TryParse(saisieClavier, out result);
            if (!resultatParse)
            {
                Affichage.Afficher("la saisie n'est pas numerique, recommencez");
                TypeOperation();
            }
            else
            { 
                switch (result)
                {
                case 1:
                    Affichage.AfficherSansRetourLigne("Premier nombre :");
                    premierChiffre = Chiffre();
                    Affichage.AfficherSansRetourLigne("Second nombre :");
                    secondChiffre = Chiffre();

                    calcul = new Calcul(premierChiffre, secondChiffre);
                    resultat = calcul.addition();
                    Affichage.Afficher("Le résultat est : " + resultat);
                    TypeOperation();
                    break;

                case 2:
                    Affichage.AfficherSansRetourLigne("Premier nombre :");
                    premierChiffre = Chiffre();
                    Affichage.AfficherSansRetourLigne("Second nombre :");
                    secondChiffre = Chiffre();
                    calcul = new Calcul(premierChiffre, secondChiffre);
                    resultat = calcul.soustraction();
                    Affichage.Afficher("Le résultat est : " + resultat);
                    TypeOperation();
                    break;
                case 3:
                    Affichage.AfficherSansRetourLigne("Premier nombre :");
                    premierChiffre =Chiffre();
                    Affichage.AfficherSansRetourLigne("Second nombre :");
                    secondChiffre = Chiffre();

                    calcul = new Calcul(premierChiffre, secondChiffre);
                    resultat = calcul.division();

                    Affichage.Afficher("Le résultat est : " + resultat);
                    TypeOperation();
                    break;
                case 4:
                    Affichage.AfficherSansRetourLigne("Premier nombre :");
                    premierChiffre = Chiffre();
                    Affichage.AfficherSansRetourLigne("Second nombre :");
                    secondChiffre = Chiffre();

                    calcul = new Calcul(premierChiffre, secondChiffre);
                    resultat = calcul.Multiplication();

                    Affichage.Afficher("Le résultat est : " + resultat);
                    TypeOperation();
                    break;

                    default:
                    Affichage.Afficher("Mauvaise saisie");
                    TypeOperation();
                    break;
                }
            }
			
	
			
			
			
            
       } 
    }
}