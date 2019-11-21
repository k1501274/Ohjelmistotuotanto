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

            
            Korjaamo korjaamo = new Korjaamo("Pärnäsen korjaamo", "Laakerintie 5, 60100 Seinäjoki", 70);

            AsiakasHaku asiakas  = new AsiakasHaku();

            Console.WriteLine("{0}", korjaamo.Nimi);
            Console.WriteLine("{0}\n", korjaamo.Osoite);
            
            

            asiakas.Hae();


            korjaamo.LaskeHinta();
            
           
           
        }

    }


}
