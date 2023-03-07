using System;
using System.Collections.Generic;
using System.Linq;

namespace Corso_oop
{
    //classe
    class Personne
    {
        //variable de la classe : nombreDePersonnes,AfficherNombreDePersonnes()
        static int nombreDePersonnes = 0;

        //variables d instance:  Personne ,Afficher()
        public string nom;
        int age;
        string emploi;
        int numeroPersonne;

        //constructore
        public Personne  (string nom, int age, string emploi)
        {
            this.nom = nom;
            this.age = age;
            this.emploi = emploi;

            nombreDePersonnes++;
            this.numeroPersonne = nombreDePersonnes;

        }

        //fonction
        public void Afficher()
        {
            Console.WriteLine("Personne N°" + numeroPersonne);
            Console.WriteLine("Nom: " + nom);
            Console.WriteLine("Age: " + age + " ans");
            Console.WriteLine("Emploi: " + emploi);
        }

        public static void AfficherNombreDePersonnes()
        {
            //dans une fonction static ont peut acceder a la variable statique
            //ont ne peut pas acceder a une variable d instance dans
            //une fonction statique vu qu on ne sait pas de quel personne ont parle..
            Console.WriteLine("nombre total de personne : " + nombreDePersonnes);
            

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //afficher une personne a la fois
            //Personne personne1 = new Personne("Paul",35, "Chauffeur");
            //personne1.Afficher();

            //creer une liste de personne
            List<Personne> personnes = new List<Personne>()
            {
                new Personne("Paul",35, "Chauffeur"),
                new Personne("Jacque",30, "Developpeur"),
                new Personne("Anna",20, "Edutiante"),
                new Personne("Juliette", 8, "cp"),
            };

            //afficher par ordre alphabetique
           // personnes = personnes.OrderBy(p => p.nom).ToList();

            foreach(Personne person in personnes)
            {
                person.Afficher();
            }

            Personne.AfficherNombreDePersonnes();
           


        }
    }
}
