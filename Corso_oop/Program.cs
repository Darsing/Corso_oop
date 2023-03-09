using System;
using System.Collections.Generic;
using System.Linq;

namespace Corso_oop
{
    //classe Enfant qui herite de la classe Etudiant

    class Enfant : Etudiant
    {
        string classeEcole;
        Dictionary<string,float> tableauDeMatiere;
        public Enfant(string nom, int age, string classeEcole, Dictionary<string, float> tableauDeMatiere) :base (nom,age,null)
        {
            this.classeEcole= classeEcole; 
            this.tableauDeMatiere= tableauDeMatiere;
        }

        public override void Afficher()
        {
            AfficherNomAge();
            Console.WriteLine(" Enfant en " + classeEcole);
            if((tableauDeMatiere != null)&& (tableauDeMatiere.Count>0))
            {
                Console.WriteLine(" Notes moyennes : ");
                foreach (var note in tableauDeMatiere)
                {
                    Console.WriteLine("    " + note.Key + " : " + note.Value + " / 10");
                }
            }
            

            AfficherProfesseurPrincipal();
        }
    }
    //classe Etudiant qui herite de la classe Personne
   class Etudiant : Personne
    {
        string infoEtudes;
        public Personne professeurPrincipal;
        public Etudiant(string nom, int age, string infoEtudes) : base(nom, age)
        {
            this.infoEtudes = infoEtudes;
            
        }
        public override void Afficher()
        {
            AfficherNomAge();
            Console.WriteLine(" Etudiant en " + infoEtudes);
            AfficherProfesseurPrincipal();
        }

        protected void AfficherProfesseurPrincipal()
        {
            if (professeurPrincipal != null)
            {
                Console.WriteLine(" Le professeur principal est : ");
                professeurPrincipal.Afficher();
            }
        }
    }

    class Personne
    { 
        static int nombreDePersonnes = 0;

        protected string nom;
        public int age { get; private set; }
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
        //virtual pour dire que cette methode peut etre surcharger(peut etre redefinie par la
        //classe enfant)
        //override (tu ecrasses la fonction Afficher()) qui se trouve dans la fonction virtual 
        

        //ont peut aussi utiliser la classe 'new' pour surcharger les fonctions
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
            List<Personne> personnes = new List<Personne>()
            {
                //on appelle cela le polymorphismo 
                new Personne("Paul",35, "Chauffeur"),
                new Personne("Jacque",30, "Developpeur"),
                new Etudiant("Anna",20, "Philo"),
                new Enfant("Juliette", 8, "cp",null),
            };

            Personne.AfficherNombreDePersonnes();
            //pour selectionner des personnes qui ont plus de 30ans
            //personnes = personnes.Where(p => p.age >= 30).ToList();
            //savoir si p est un etudiant
            personnes = personnes.Where(p => p is Etudiant).ToList();
            foreach (Personne person in personnes)
            {
                person.Afficher();
            }
            //Personne personne1 = new Personne() { nom= "Paul",age= 35,emploi="ingenieur"};
            //Personne personne2 = new Personne("Luca", 23, "etudiant");

            //je ne peux pas heriter des constructeur de la classe parent
            // je ne peux donc pas ecrire :var etudiant = new Etudiant("paul",30,"proffeseur")
            //mais je peux ecicre comme ceux-ci parcequ il le gere come etant le constructor
            //de defaux de la classe etudiant
            //var etudiant = new Etudiant() { nom= "paul", age=30, emploi="proffeseur" };

            // Etudiant etudiant = new Etudiant("Luca", 23, " meccanique");
            // //etudiant.professeurPrincipal = new Personne("Jacque", 35,"professeur");
            // var professeurPrincipal = new Personne("Jacque", 35, "professeur");

            // etudiant.professeurPrincipal=professeurPrincipal;   
            // etudiant.Afficher();

            // Enfant enfant = new Enfant("Sophie", 8, "cp", new Dictionary<string, float>
            // {
            //     {"math",8f},{ "dicte", 4f },{"geo" ,6.6f}
            // });

            // //var enfant1 = new Enfant("kiki", 7,"cp", null); //cas de dictionnaire null 
            //// var enfant1 = new Enfant("kiki", 7, "cp", new Dictionary<string, float>());//cas un le dictinnaire ne contient pas d element
            // //enfant1.Afficher();

            // enfant.professeurPrincipal=professeurPrincipal;
            // enfant.Afficher();

        }
    }
}
