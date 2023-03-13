using System;
using System.Collections.Generic;
using System.IO;

namespace programme_fichiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fileName = "monfichier.txt";
            var  noms = new List<string>()
            {
                "Jean",
                "Paul",
                "Maria",
                "Oliva"
            };
            //File.WriteAllText("monFichier.txt", "Voici le contenu que j ai dans mon fichier");
            //File.AppendAllText("monfichier.txt", " je rajoute ce text.");
            File.WriteAllLines(fileName,noms );//je crée mon fichier et son contenu
            try
            {
                //string r = File.ReadAllText("monFichier.txt");
                var ligne = File.ReadAllLines(fileName);//je lis mon fichier
                //Console.WriteLine(ligne);
                //ici le resultat de ligne est dans 3 string parceque on a lu les 3 lignes
                //dans une seule string var ligne = File.ReadAllLines(fileName)
                //on boucle pour recupere les 3 string dans une liste

                foreach (var line in ligne)
                {
                    Console.WriteLine(line);
                }

            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("ERREUR : ce fichier n existe pas" + ex.Message);
            }
            catch
            {
                Console.WriteLine("Une erreur inconnue est arrivée");
            }
             
        }
    }
}
