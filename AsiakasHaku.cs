using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Korjaamon_veloituslaskuri
{
    public class AsiakasHaku : Korjaamo1
    {
        public void Hae()
        {

            {
                //Luetaan asiakaskanta tiedosto
                IEnumerable<string> lines = File.ReadAllLines(@"M:\OSHSU19S\Olio-ohjelmointi\Korjaamon_veloituslaskuri_versio2\Asiakaskanta.csv",/*ääkköset näkyviin*/ System.Text.Encoding.Default);






                Console.Write("\nAnna rekisterinumero (XUP-108, JGU-856 ja BMF-863 löytyy tietokannasta): ");
                string input = Console.ReadLine().Trim();

                //etsitään vastaavuuksia asiakaslistasta
                IEnumerable<string> matches = !string.IsNullOrEmpty(input)
                                              ? lines.Where(line => line.IndexOf(input, StringComparison.OrdinalIgnoreCase) >= 0)
                                              : Enumerable.Empty<string>();

                //jos vastaavuuksia löytyy, kirjoitetaan konsoliin
                Console.WriteLine(matches.Any()
                                  ? String.Format("\nAuton/omistajan tiedot: {0}", String.Join("", matches))

                                  //Jos vastaavuuksia ei löydy
                                  : "\nAsiakasta ei löytynyt, sulje ohjelma ja lisää asiakas tietokantaan");

                Console.WriteLine("\n");



            }
        }


    }
}
