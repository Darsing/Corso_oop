using System;
using System.Collections.Generic;
using System.IO;

namespace programme_fichiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var noms = new List<string>()
            {
                "Jean",
                "Paul",
                "Maria",
            };
            //File.WriteAllText("monFichier.txt", "Voici le contenu que j ai dans mon fichier");
            //File.AppendAllText("monfichier.txt", " je rajoute ce text.");
            File.WriteAllLines("monfichier.txt",noms );
            try
            {
                //string r = File.ReadAllText("monFichier.txt");
                var ligne = File.ReadAllLines("monFichier.txt");
                foreach(var line in ligne)
                {
                    Console.WriteLine(line);
                }
               
            }
            catch(FileNotFoundException ex)
            {
                Console.WriteLine("ERREUR : ce fichier n existe pas" + ex.Message);
            }
            catch
            {
                Console.WriteLine("Une erreur inconnue est arrivee");
            }
             
        }
    }
}
