using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Korjaamon_veloituslaskuri
{
    public class Korjaamo1
    {


        public static void Main(string[] args)
        {


            
            Laskuri laskuri = new Laskuri("Pärnäsen korjaamo", "Laakerintie 5, 60100 Seinäjoki", 70);

            AsiakasHaku asiakas = new AsiakasHaku();

            Console.WriteLine("{0}", laskuri.Nimi);
            Console.WriteLine("{0}\n", laskuri.Osoite);
            




            asiakas.Hae();


            laskuri.LaskeHinta();
            
           
           
        }

}


}
