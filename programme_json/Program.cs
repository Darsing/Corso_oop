using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace programme_json
{
    internal class Program
    { 
        
        class Persone
        {
            public string nom { get;private set; }
            public int age { get;private set; }
            public bool majeur { get;private set; }

            public Persone(string nom, int age, bool majeur)
            {
                this.nom = nom;
                this.age = age;
                this.majeur = majeur;
            }

            public void PrintInfo()
            {
                Console.WriteLine("nom: " + nom + " - age: "+age+ " ans");
            }
        }
        static void Main(string[] args)
        {
            /*
            //Persone p1= new Persone();//sans le constructor
            //p1.nom = "toto";
            //p1.age= 30;
            //p1.majeur = true;
            //p1.PrintInfo();

            //avec le constructor
            Persone p1 = new Persone("Toto", 25, true);
            p1.PrintInfo();

            //Serialiser notre p1
            string json = JsonConvert.SerializeObject(p1);
            Console.WriteLine(json);

            //on peut aussi serialiser une liste
            List<string> noms = new List<string>() { "Paul","Jean","anne"};
            string listJson = JsonConvert.SerializeObject(noms);
            Console.WriteLine(listJson);


            string jsonTiti="{\"nom\":\"titi\",\"age\":15,\"majeur\":false}";
            Persone titi= JsonConvert.DeserializeObject<Persone>(jsonTiti);
            titi.PrintInfo();  

            */
            //creer une liste de personne
            /*
            List<Persone> persones = new List<Persone>()
            {
                new Persone("Hanri",34,true),
                new Persone("Elizabeth",14,false),
                new Persone("Richard",44,true)
            };   
            
            //serialiser
            string json= JsonConvert.SerializeObject(persones);
            Console.WriteLine(json);

            //ecrire ce json ->fichier texte
            string filename = "persones.txt";
            File.WriteAllText(filename, json);
            */

            //lire le json à partir du fichier
            string listjson = File.ReadAllText("persones.txt");

            //creer vos personnes a partir du json

            var personnes =JsonConvert.DeserializeObject<List<Persone>>(listjson);
            foreach(var personne in personnes)
            {
                personne.PrintInfo();
            }
            
        }
        
    }
}
