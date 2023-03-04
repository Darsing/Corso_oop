using System;
using System.Collections.Generic;

namespace Corso_oop
{
    //classe
    class Personne
    {
        string nom;
        int age;
        string emploi;

        //constructore
        public Personne  (string nom, int age, string emploi)
        {
            this.nom = nom;
            this.age = age;
            this.emploi = emploi;

        }

        //fonction
        public void Afficher()
        {
            Console.WriteLine("Nom: " + nom);
            Console.WriteLine("Age: " + age + " ans");
            Console.WriteLine("Emploi: " + emploi);
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
            List<Personne> p = new List<Personne>()
            {
                new Personne("Paul",35, "Chauffeur"),
                new Personne("Jacque",30, "Developpeur"),
                new Personne("Anna",20, "Edutiante"),
            };

            foreach(Personne person in p)
            {
                person.Afficher();
            }
            //


        }
    }
}
