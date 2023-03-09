using System;
using System.Collections.Generic;
using System.Linq;

namespace Corso_oop
{
    //classe Etudiant qui herite de la classe Personne
   class Etudiant : Personne
    {
        string infoEtudes;
        Personne professeurPrincipal;
        public Etudiant(string nom, int age, string infoEtudes, Personne professeurPrincipal=null) : base(nom, age)
        {
            this.infoEtudes = infoEtudes;
            this.professeurPrincipal = professeurPrincipal;
        }
        public override void Afficher()
        {
            AfficherNomAge();
            Console.WriteLine(" Etudiant en " + infoEtudes);
            Console.WriteLine(" Le professeur principal est : ");
            professeurPrincipal.Afficher();
        }
    }

    class Personne
    { 
        static int nombreDePersonnes = 0;

        protected string nom;
        protected int age;
        protected string emploi;

        int numeroPersonne;

        public Personne(string nom, int age, string emploi = null) 

        {
            this.nom = nom;
            this.age = age;
            this.emploi = emploi;

            nombreDePersonnes++;
            this.numeroPersonne = nombreDePersonnes;
        }

        //fonction
        public virtual void Afficher()
        {
            AfficherNomAge();
            if (emploi == null)
            {
                Console.WriteLine(" Aucun emploi specifie");
            }
            else
            {
                Console.WriteLine(" Emploi: " + emploi);
            }
           
        }


        protected void AfficherNomAge()
        {
            Console.WriteLine("Personne N°" + numeroPersonne);
            Console.WriteLine("Nom: " + nom);
            Console.WriteLine("Age: " + age + " ans");


        }
        public static void AfficherNombreDePersonnes()
        {
            Console.WriteLine("nombre total de personne : " + nombreDePersonnes);    

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {


            //creer une liste de personne
            //List<Personne> personnes = new List<Personne>()
            //{
            //    new Personne("Paul",35, "Chauffeur"),
            //    new Personne("Jacque",30, "Developpeur"),
            //    new Personne("Anna",20, "Edutiante"),
            //    new Personne("Juliette", 8, "cp"),
            //    new Personne("Kiki", 18),
            //};

            //foreach (Personne person in personnes)
            //{
            //    person.Afficher();
            //}

            // Personne.AfficherNombreDePersonnes();


            //Personne personne1 = new Personne() { nom= "Paul",age= 35,emploi="ingenieur"};
            //Personne personne2 = new Personne("Luca", 23, "etudiant");

            //je ne peux pas heriter des constructeur de la classe parent
            // je ne peux donc pas ecrire :var etudiant = new Etudiant("paul",30,"proffeseur")
            //mais je peux ecicre comme ceux-ci parcequ il le gere come etant le constructor
            //de defaux de la classe etudiant
            //var etudiant = new Etudiant() { nom= "paul", age=30, emploi="proffeseur" };

            Personne professeur = new Personne("Jacque", 35,"professeur");
            Etudiant etudiant1 = new Etudiant("Luca", 23," meccanique", professeur);
            etudiant1.Afficher();
            
        }
    }
}
