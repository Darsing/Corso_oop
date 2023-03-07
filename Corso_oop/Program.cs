using System;
using System.Collections.Generic;
using System.Linq;

namespace Corso_oop
{
    //classe
    class Personne
    { 
        static int nombreDePersonnes = 0;
        /* pour classer les nom par ordre alphabetique nous avons ecrit devant
         string nom le mot cle 'public' mais avec ce mot cle il est possible de modifier 
        notre variable à l esterieure de la classe Personne chose qui n est pas tres bien 
        en programmation. comme solution nous avons des fonctions(accesseurs) qui vont nous 
        permettre de lire et acceder à la variable et comme autre solution nous avons 
        des Proprietes(get,set) il est egalement possible de mettre private devant set 
        pour indiquer la variable ne pourra d etre modifier à l esterieure de la classe*/
        public string nom { get; set; } //je peux lire et je peux ecrire avec get et set
        public int age { get; set; }
        public string emploi { get; set; }

        int numeroPersonne;

        //accesseurs
        //avec la get on ne peut pas modifier le nom
        //avec la set on peut modifier le nom
        //public string GetNom()
        //{
        //    return nom;
        //}

        //public void SetNom(string value)
        //{
        //    nom = value;
        //}


        //costructore 2:
        //pour gerer le cas d un parametre non specifier
        //j ecris mon contructore de cette façon 

        //public Personne(string nom, int age) : this(nom, age, ("non specifié"))
        //{

        //}

        //constructore 1
        /*nons pouvons egalement gerer emploi avec sa valeur de default null
         * où bien creer un second constructor 
         * dans ma function afficher je geres une condiction
         */

        //public Personne(string nom, int age, string emploi=null)
      
        //{
        //    this.nom = nom;
        //    this.age = age;
        //    this.emploi = emploi;

        //    nombreDePersonnes++;
        //    this.numeroPersonne = nombreDePersonnes;

        //}

        //je veux creer un constructor sans parametre et avec le this() je le passe
        //à l autre constructor qui a des parametres
        public Personne()

        {
            nombreDePersonnes++;
            this.numeroPersonne = nombreDePersonnes;
        }
        public Personne(string nom, int age, string emploi = null) :this()

        {
            this.nom = nom;
            this.age = age;
            this.emploi = emploi;
        }

        //fonction
        public void Afficher()
        {
            Console.WriteLine("Personne N°" + numeroPersonne);
            Console.WriteLine("Nom: " + nom);
            Console.WriteLine("Age: " + age + " ans");

            if (emploi == null)
            {
                Console.WriteLine(" Aucun emploi specifie");
            }
            else
            {
                Console.WriteLine(" Emploi: " + emploi);
            }
           
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

            //Personne personne1 = new Personne("Paul", 23);
            //Console.WriteLine("Nom de la personne1 " + personne1.GetNom()); //accesseur GetNom
            // personne1.SetNom("toto");  // accesseur SetNom

            //personne1.nom = "Toto"; //en utilisant les proprietes set je modifie le nom

            //Personne personne1 = new Personne();  // constructeur sans parametre
            //Personne personne2 = new Personne("Paul", 23); //constructeur avec les parametres
            //personne1.Afficher();
            //personne2.Afficher();
            
            //j ai passe des proprietes à mon constructeur qui n a pas de parametre

            Personne personne1 = new Personne() { nom= "Paul",age= 35,emploi="ingenieur"};
            Personne personne2 = new Personne("Luca", 23, "etudiant");


            personne1.Afficher();
            personne2.Afficher();
            
        }
    }
}
