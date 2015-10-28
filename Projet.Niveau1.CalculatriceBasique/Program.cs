using System;

namespace Projet.Niveau1.CalculatriceBasique
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Essaie
            //Console.ForegroundColor = ConsoleColor.Green;
            //Affichage.AfficherSansRetourLigne("\nLe tarif essence donne : ");
           
            Affichage.Afficher("Bonjour !");
            TypeOperation();
        }

        private static void TypeOperation()
        {
            Console.ForegroundColor = ConsoleColor.Pink;
            Affichage.Afficher("Quelle type d'opération souhaitez vous faire :");
            Console.ForegroundColor = ConsoleColor.Blue;
            Affichage.Afficher("1.Addition");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Affichage.Afficher("2.Soustraction");
			Affichage.Afficher("3.Division");
            Affichage.Afficher("4.Multiplication");

            int saisieClavier = Convert.ToInt16(Console.ReadLine());

            if (saisieClavier == 1)
            {
                Affichage.AfficherSansRetourLigne("Premier nombre :");
                double premierChiffre = Convert.ToDouble(Console.ReadLine());
                Affichage.AfficherSansRetourLigne("Second nombre :");
                double secondChiffre = Convert.ToDouble(Console.ReadLine());

                var calcul = new Calcul(premierChiffre, secondChiffre);
                var resultat = calcul.addition();


                Affichage.Afficher("Le résultat est : " + resultat);
                TypeOperation();
            }
			
			else if (saisieClavier==2)
			{
					Affichage.AfficherSansRetourLigne("Premier nombre :");
				    double premierChiffre = Convert.ToDouble(Console.ReadLine());
					Affichage.AfficherSansRetourLigne("Second nombre :");
					double secondChiffre = Convert.ToDouble(Console.ReadLine());

					var calcul = new Calcul(premierChiffre, secondChiffre);
					var resultat = calcul.soustraction();

					Affichage.Afficher("Le résultat est : " + resultat);
					TypeOperation();
			
			}
			
			else if (saisieClavier==3)
			{
					Affichage.AfficherSansRetourLigne("Premier nombre :");
					double premierChiffre = Convert.ToDouble(Console.ReadLine());
					Affichage.AfficherSansRetourLigne("Second nombre :");
					double secondChiffre = Convert.ToDouble(Console.ReadLine());

					var calcul = new Calcul(premierChiffre, secondChiffre);
					var resultat = calcul.division();

					Affichage.Afficher("Le résultat est : " + resultat);
					TypeOperation();
			
			}
			
			else if (saisieClavier==4)
			{
					Affichage.AfficherSansRetourLigne("Premier nombre :");
					double premierChiffre = Convert.ToDouble(Console.ReadLine());
					Affichage.AfficherSansRetourLigne("Second nombre :");
					double secondChiffre = Convert.ToDouble(Console.ReadLine());

					var calcul = new Calcul(premierChiffre, secondChiffre);
					var resultat = calcul.Multiplication();

					Affichage.Afficher("Le résultat est : " + resultat);
					TypeOperation();
			
			}
			
			
            else
            {
                Affichage.Afficher("Mauvaise saisie");
                TypeOperation();
            }
        }
    }
}