using System;

namespace Projet.Niveau1.CalculatriceBasique
{
    internal class Program
    {
        private static void Main(string[] args)
        { 
            CentrerLeTexte("Bonjour!");
            TypeOperation();
        }
        private static void CentrerLeTexte(string texte)
        {
            int nbEspaces = (Console.WindowWidth - texte.Length) / 2;
            Console.SetCursorPosition(nbEspaces, Console.CursorTop);
            Affichage.Afficher(texte);
        }
        private static void TypeOperation()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Affichage.Afficher("Quelle type d'opération souhaitez vous faire :");
            Console.ForegroundColor = ConsoleColor.Blue;
            Affichage.Afficher("1.Addition");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Affichage.Afficher("2.Soustraction");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Affichage.Afficher("3.Division");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Affichage.Afficher("4.Multiplication");


            Console.ForegroundColor = ConsoleColor.White;
            int saisieClavier = Convert.ToInt16(Console.ReadLine());
           

            if (saisieClavier == 1)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Affichage.AfficherSansRetourLigne("Premier nombre :");
                double premierChiffre = Convert.ToDouble(Console.ReadLine());
                Affichage.AfficherSansRetourLigne("Second nombre :");
                double secondChiffre = Convert.ToDouble(Console.ReadLine());

                var calcul = new Calcul(premierChiffre, secondChiffre);
                var resultat = calcul.addition();

                Console.ForegroundColor = ConsoleColor.Green;
                Affichage.Afficher("Le résultat est : " + resultat);
                TypeOperation();
            }
			
			else if (saisieClavier==2)
			{
                Console.ForegroundColor = ConsoleColor.Gray;
                Affichage.AfficherSansRetourLigne("Premier nombre :");
				    double premierChiffre = Convert.ToDouble(Console.ReadLine());
					Affichage.AfficherSansRetourLigne("Second nombre :");
					double secondChiffre = Convert.ToDouble(Console.ReadLine());

					var calcul = new Calcul(premierChiffre, secondChiffre);
					var resultat = calcul.soustraction();
                Console.ForegroundColor = ConsoleColor.Green;
                Affichage.Afficher("Le résultat est : " + resultat);
					TypeOperation();
			
			}
			
			else if (saisieClavier==3)
			{
                Console.ForegroundColor = ConsoleColor.Gray;
                Affichage.AfficherSansRetourLigne("Premier nombre :");
					double premierChiffre = Convert.ToDouble(Console.ReadLine());
					Affichage.AfficherSansRetourLigne("Second nombre :");
					double secondChiffre = Convert.ToDouble(Console.ReadLine());

					var calcul = new Calcul(premierChiffre, secondChiffre);
					var resultat = calcul.division();
                Console.ForegroundColor = ConsoleColor.Green;
                Affichage.Afficher("Le résultat est : " + resultat);
					TypeOperation();
			
			}
			
			else if (saisieClavier==4)
			{
                Console.ForegroundColor = ConsoleColor.Gray;
                Affichage.AfficherSansRetourLigne("Premier nombre :");
					double premierChiffre = Convert.ToDouble(Console.ReadLine());
					Affichage.AfficherSansRetourLigne("Second nombre :");
					double secondChiffre = Convert.ToDouble(Console.ReadLine());

					var calcul = new Calcul(premierChiffre, secondChiffre);
					var resultat = calcul.Multiplication();
                Console.ForegroundColor = ConsoleColor.Green;
                Affichage.Afficher("Le résultat est : " + resultat);
					TypeOperation();
			
			}
			
			
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Affichage.Afficher("Mauvaise saisie");
                TypeOperation();
            }
        }
    }
}