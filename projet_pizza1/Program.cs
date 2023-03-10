using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace projet_pizza1
{
    class PizzaPersonnalisee : Pizza
    {
        static int nbPizzasPersonnalisee = 0;
        public PizzaPersonnalisee() : base("Personnalisee",5, false, null)
        {
            nbPizzasPersonnalisee++;
            ingredients = new List<string>();
            while (true)
            {
                Console.WriteLine("Rentrez un ingredient pour la pizza personnalisee "+nbPizzasPersonnalisee + "(ENTER pour terminer) :");
                string input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                {
                    break;
                }
                 
                if (!ingredients.Contains(input))
                {
                    ingredients.Add(input);
                    Console.WriteLine(string.Join(", ", ingredients));
                    
                }
                else
                {
                    Console.WriteLine("Erreur ingredint figure dejà dans la liste");
                }
                Console.WriteLine();


            }
            
        }
        
    }
    class Pizza
    {
        public string nom { get; set; }
        public float prix { get;private set; }
        public bool vegetarienne { get;private set; }
        public List<string> ingredients { get; protected set; }

        public Pizza(string nom, float prix, bool vegetarienne, List<string> ingredients)
        {
            this.nom = nom;
            this.prix = prix;
            this.vegetarienne = vegetarienne;
            this.ingredients = ingredients;
        }

        public void Afficher()
        {
            string badgeVegetarienne = " (V)";
            if (!vegetarienne)
            {
                badgeVegetarienne = "";
            }
            //Console.WriteLine(nom + badgeVegetarienne + " - " + prix + "€");//afficharge normale
            //pour afficher le nom de mes pizza en majuscules et minuscule
            //sans toute fois altere/modifier le nom dans la classe pizza
            //je cree une nouvelle variable nomAffiches
            //string nomMajuscule = nom.ToUpper();
            //string nomMinuscule = nom.ToLower();
            //string nomAffiches = nomMajuscule[0] + nomMinuscule[1..];
            //Console.WriteLine(nomAffiches + badgeVegetarienne+ " - " + prix + "€");

            string nomAfficher = FormatPremiereLettreMajuscules(nom);

            //var ingredientsAfficher = new List<string>(); //creation d une nouvelle liste
            //foreach(var ingredient in ingredients)
            //{
            //    ingredientsAfficher.Add(FormatPremiereLettreMajuscules(ingredient));
            //}

            var ingredientsAfficher = ingredients.Select(i => FormatPremiereLettreMajuscules(i)).ToList();
            Console.WriteLine( nomAfficher + badgeVegetarienne + " - " + prix + "€");
            if((ingredients.Count > 0)&&(ingredients !=null) )
            {
                //var r = string.Join(" , ", ingredients);
                //Console.WriteLine(r);
                Console.WriteLine(string.Join(" , ", ingredientsAfficher));
            }
            Console.WriteLine();

        }
        //je cree une fonction pour gerer affiche en majuscule et minuscule de mes noms
        //je la mets en static vu qu elle sera utiliser dans la classe
        private static string FormatPremiereLettreMajuscules(string s)
        {
            //pour controller que le nom 
            //if((s== null) || s.Length == 0)
            //   return s;
            //ont peut aussi utiliser IsNullOrEmpty
            if (string.IsNullOrEmpty(s))
                return s;

            string majuscule = s.ToUpper();
            string minuscule = s.ToLower();
            string resultat = majuscule[0] + minuscule[1..]; //minuscule.Substring(1)
            return resultat;
           
        }

        public bool ContientIngredient(string ingredient)
        {
            return ingredients.Where(i => i.ToLower().Contains(ingredient)).ToList().Count > 0;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8; //pour lire le simbole €

            //Pizza pizza = new Pizza("4 fromages", 9.50, false);
            List<Pizza> pizzes = new List<Pizza>
            {
                new Pizza("4 fromages", 11.50f, true, new List<string>()
                {"mozarella","poulet", "oignon","fromage"}),
                new Pizza("kebap", 8f, false, new List<string>()
                {"mozarella","kebap", "oignon", "salade", "fromage emental"}),
                new Pizza("mexicaine", 13f, false, new List<string>()
                {"mozarella","boeuf", "oignon", "tomates", "mais"}),
                new Pizza("margherita", 8f, true, new List<string>()
                {"mozarella","tomates", "oignon", "baselic", "fromage"}),
                new Pizza("calzone", 12f, false, new List<string>()
                {"mozarella","sauce tomate", "oignon", "jambon"}),
                new Pizza("complete", 9.50f, false, new List<string>()
                {"mozarella","oeuf", "persil", "jambo"}),
                new PizzaPersonnalisee(),
                new PizzaPersonnalisee(),


            };

            //classer par prix du plus petit au plus grand
            //pizzes = pizzes.OrderBy(p =>p.prix).ToList();
            //classer par prix du plus grand au plus petit
            //pizzes = pizzes.OrderByDescending(p => p.prix).ToList();

            /* comment afficher/trier la pizza moins chere et plus chere
             sans utiliser le 'orderby' ,'sort' */
            //Pizza pizzaPrixMin = null;
            //Pizza pizzaPrixMax = null;

            //pizzaPrixMin = pizzes[0];
            //pizzaPrixMax = pizzes[0];

            //foreach (Pizza piz in pizzes)
            //{
            //    if(piz.prix <pizzaPrixMin.prix)
            //    {
            //        pizzaPrixMin=piz;
            //    }
            //    if(piz.prix > pizzaPrixMax.prix)
            //    {
            //        pizzaPrixMax = piz;
            //    }
            //}

            //pizzes = pizzes.Where(p => !p.vegetarienne).ToList();//pour afficher pizza qui ne sont pas V
            //pizzes = pizzes.Where(p => p.vegetarienne).ToList();//pour afficher seulement les pizza V

            //pizzes = pizzes.Where(p => p.ingredients.Contains("tomates")).ToList();
            //pizzes = pizzes.Where(p => p.ingredients.Where(i=>i.ToLower().Contains("tomate")).ToList().Count>0).ToList();
            //pizzes = pizzes.Where(p=>p.ContientIngredient("tomate")).ToList();  
            foreach (Pizza pizza in pizzes)
            {
                pizza.Afficher();
            }

            //Console.WriteLine("La pizza la moins chere est : ");
            //pizzaPrixMin.Afficher();
            //Console.WriteLine("La pizza la plus chere est : ");
            //pizzaPrixMax.Afficher();

     
        }
    }
}
