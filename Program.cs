using System;
using System.Linq;

namespace delegates
{
    class Program
    {

        public delegate string ValidationChaine(string s);

        static void Main(string[] args)
        {
            // Demander le nom de l'utilisateur
            // Demander le numéro de téléphone de l'utilisateur

            string nom = DemanderChaineUtilisateur("Quel est votre nom ?", CheckValidationNom);

            // 0610101010 -> 10 chiffres
            string tel = DemanderChaineUtilisateur("Quel est votre numéro de téléphone ?", CheckValidationTel);

            Console.WriteLine();
            Console.WriteLine("Bonjour " + nom + ", vous êtes joignable au " + tel);
        }

        static string DemanderChaineUtilisateur(string message, ValidationChaine fonctionValidation = null)
        {
            Console.Write(message + " ");
            string reponse = Console.ReadLine();
            if (fonctionValidation != null)
            {
                string erreur = fonctionValidation(reponse);
                if (erreur != null)
                {
                    Console.WriteLine("Erreur : " + erreur);
                    return DemanderChaineUtilisateur(message, fonctionValidation);
                }
            }
            return reponse;
        }

        static string CheckValidationNom(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
            {
                return "Attention le nom ne doit pas être vide";
            }

            if (s.Any(char.IsDigit)) // any : est-ce qu'il y a un des caractères dans s qui serait un chiffre, si il y a un chiffre -> return
            {
                return "Attention le nom ne doit pas contenir de chiffres";
            }

            return null;
        }

        static string CheckValidationTel(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
            {
                return "Attention le numéro de téléphone ne doit pas être vide";
            }

            if (s.Length != 10)
            {
                return "Le numéro de téléphone doit contenir 10 chiffres";
            }

            if (!s.All(char.IsDigit)) // any : est-ce qu'il y a un des caractères dans s qui serait un chiffre, si il y a un chiffre -> return
            {
                return "Attention le numéro de téléphone doit contenir uniquement des chiffres";
            }

            return null;
        }

    }
}
