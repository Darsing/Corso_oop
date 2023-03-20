using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ripassoClasse.classi
{
    internal class Prodotti
    {
        public string nome { get;private set; }
        public float prix { get;private set; }
        public bool vegetarienne { get; private set; } 
        public List<string> ingredients { get; private set; }

        

        public Prodotti(string nome, float prix,bool vegetarienne, List<string> ingredients)
        {
            this.nome = nome;
            this.prix = prix; 
            this.vegetarienne= vegetarienne;
            this.ingredients = ingredients;

        }

        public void Afficher()
        {
            //string vege = "(V) ";
            //if(!vegetarienne )
            //{
            //    vege = "";
            //}
            //Console.WriteLine(nome + vege + " - " + prix + "€");
            string nomAfficher = Formatazione(nome);
            string vege = vegetarienne ? "(V)" : "";
            Console.WriteLine(nomAfficher + vege+ " - " + prix + "€");

           var ingredientList = ingredients.Select(i=>Formatazione(i)).ToList();
            if(ingredients!= null && ingredients.Count > 0)
            {
                    Console.WriteLine(string.Join(", ", ingredientList));
            }
            Console.WriteLine();

        }

        private static string Formatazione(string s)
        {
            if(string.IsNullOrEmpty(s))
            return s;

            string nomMinuscule = s.ToLower();
            string nomMajuscule = s.ToUpper();
            string mista = nomMajuscule[0] + nomMinuscule[1..];
            return mista;
        }
    }
}
