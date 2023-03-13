using System;
using System.IO;

namespace programme_fichiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fileName = "monfichier.txt";
            var path = "out";
            string pathAndFile = Path.Combine(path, fileName);

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            if (File.Exists(pathAndFile))
            {
                Console.WriteLine("le fichier existe deja on va ecrasser son contenu");
            }
            else
            {
                Console.WriteLine("le fichier n existe pas on va le creer");
            }
            Console.WriteLine("FICHIER : " + pathAndFile);

            //var texte = "";
            //nt nbLigne = 2000;

            //mutable
            //Stringbulder ça marche par block,il va loué un block de memoire
            //SA LIMITE: il n a pas tout les fonctionalites d une chaine de caratectere
            //StringBuilder texte= new StringBuilder();
            //int nbLigne = 50000;

            //-------------------------------------
            //DateTime t1= DateTime.Now;

            //Console.WriteLine("preparation des donnees");

            //for (int i = 1; i <= nbLigne; i++)
            //{
            //    texte = "ligne " + i+ "\n";
            //    // immutable :les donnees ne sont pas changeable ,il a loué la memoire de nouveau

            //    //avec le StringBuilder()
            //    //texte.Append("ligne " + i + "\n");
            //}
            //Console.WriteLine("ok..");

            //Console.WriteLine("ecriture des donnees");
            //File.WriteAllText(pathAndFile, texte);
            ////File.WriteAllText(pathAndFile, texte.ToString());
            //Console.WriteLine("ok");
            //DateTime t2 = DateTime.Now;
            //var diff = (int)((t2 - t1).Milliseconds);
            //Console.WriteLine("Duree (ms) " + diff);

            ////----------------------------------

            //comment gerer les fichiers de plus 1 giga de memoire
            //Stream:flux
            DateTime t1 = DateTime.Now;
            //using (var writeStream = File.CreateText(pathAndFile))
            //{
            //    for (int i = 1; i <= nbLigne; i++)
            //    {
            //        writeStream.WriteLine("ligne " + i);
            //        //j ecris directement dans mon fichier et non dans la memoire
            //    }
            //}

            using (var readStream = File.OpenText(pathAndFile))
            {
                while (true)
                {
                    var line = readStream.ReadLine();
                    if (line == null)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine(line);
                    }
                }
                DateTime t2 = DateTime.Now;
                var diff = (int)((t2 - t1).Milliseconds);
                Console.WriteLine("Duree (ms) " + diff);
            }



        }
    }
}
