using System;
using System.Net;

namespace programme_reseau
{
    internal class Program
    {

        //static void Main(string[] args)
        //{
        //    /* nous avons 3 methode pour faire des requetes http
        //     * -HttpWebRequest c est la 1 methode pas simple à utiliser
        //     * -WebClient c est la 3 ,plus facile à utiliser
        //     * -HttpClient c est la 2 ,plus récent,il y a plus de controle et plus de code
        //     */

        //    // comment realiser les accès au reseau : -avec la WebClient methode
        //    //string url = "file:///C:/xampp/htdocs/ripassoHtmleCss/flexbox1/index.html";
        //    string url1 = "https://codeavecjonathan.com/res/pizzasss1.json";
        //    


        //    //WebClient client = new WebClient(); //nous creons un nouveau object
        //    //comment gerer les exceptions
        //    var webClient = new WebClient();
        //    Console.WriteLine("acces au reseau...");
        //    try
        //    {
        //        string reponse = webClient.DownloadString(url1);
        //        //DownloadString(),pour telecharger les donnees ,ce st les https get
        //        //UploadString() ce sont les http post
        //        Console.WriteLine(reponse);
        //    }
        //    catch(WebException ex)
        //    {
        //        if(ex.Response != null)
        //        {
        //            var statusCode = ((HttpWebResponse)ex.Response).StatusCode;
        //            //Console.WriteLine("ERREUR RESEAU" + ex.Message);
        //            if (statusCode == HttpStatusCode.NotFound)
        //            {
        //                Console.WriteLine("ERREUR RESEAU : Non trouvé");
        //            }
        //            else
        //            {
        //                Console.WriteLine("ERREUR RESEAU " + statusCode);
        //            }
        //        }
        //        else
        //        {
        //            Console.WriteLine("ERREUR RESEAU " + ex.Message);
        //        }


        //    }
        //}

        static void Main(string[] args)
        {
            string url1 = "https://codeavecjonathan.com/res/papillon.jpg";
            var webClient = new WebClient();
            Console.WriteLine("acces au reseau...");
            try
            {
                webClient.DownloadFile(url1, "papillon.jpg");
                Console.WriteLine("Telechargement terminer");
            }
            catch (WebException ex)
            {
                if (ex.Response != null)
                {
                    var statusCode = ((HttpWebResponse)ex.Response).StatusCode;
                    //Console.WriteLine("ERREUR RESEAU" + ex.Message);
                    if (statusCode == HttpStatusCode.NotFound)
                    {
                        Console.WriteLine("ERREUR RESEAU : Non trouvé");
                    }
                    else
                    {
                        Console.WriteLine("ERREUR RESEAU " + statusCode);
                    }
                }
                else
                {
                    Console.WriteLine("ERREUR RESEAU " + ex.Message);
                }

            }


        }
    }
}
