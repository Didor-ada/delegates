using System;

namespace delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            // Demander le nom de l'utilisateur
            // Demander le numéro de téléphone de l'utilisateur

            string nom = DemanderChaineUtilisateur("Quel est votre nom ?");

            // 0610101010 -> 10 chiffres
            string tel = DemanderChaineUtilisateur("Quel est votre numéro de téléphone ?");

            Console.WriteLine();
            Console.WriteLine("Bonjour " + nom + ", vous êtes joignable au " + tel);
        }

        static string DemanderChaineUtilisateur(string message)
        {
            Console.Write(message + " ");
            string reponse = Console.ReadLine();
            return reponse;
        }

    }
}
