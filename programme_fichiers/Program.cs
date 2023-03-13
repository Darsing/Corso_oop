using System;
using System.Collections.Generic;
using System.IO;

namespace programme_fichiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //construction du fileName
            //var path= Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            //j ai crée mon fichier dans mes documents
            //on peut aussi creer sur le desktop
            //var path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            //Console.WriteLine(path);

            //on peut aussi mettre notre fichier dans un sous répertoire de notre dossier
            var path = "out"; //nom du repertoire
            //la function pour creer le repertoire
            if(!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
           

            string fileName = "monfichier.txt";
            //je crée un fichier2 pour copier le contenu du fileName
            string fileName2 = "monfichier2.txt";

            string pathAndFile = Path.Combine(path, fileName);
            string pathAndFile2 = Path.Combine(path, fileName2);

            if (File.Exists(pathAndFile))
            {
                Console.WriteLine("le fichier existe deja on va ecrasser son contenu");
            }
            else
            {
                Console.WriteLine("le fichier n existe pas on va le creer");
            }
            Console.WriteLine("FICHIER : " + pathAndFile);
            
            var  noms = new List<string>()
            {
                "Jean",
                "Paul",
                "Maria",
                
            };
            //File.WriteAllText("monFichier.txt", "Voici le contenu que j ai dans mon fichier");
            //File.AppendAllText("monfichier.txt", " je rajoute ce text.");
            File.WriteAllLines(pathAndFile, noms );//je crée mon fichier et son contenu
            try
            {
                //string r = File.ReadAllText("monFichier.txt");
                var ligne = File.ReadAllLines(pathAndFile);//je lis mon fichier
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
            
            //File.Copy(pathAndFile, pathAndFile2);
            //pour supprimer
            File.Delete(pathAndFile2);
        }
    }
}
