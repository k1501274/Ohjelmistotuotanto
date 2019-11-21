using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Korjaamon_veloituslaskuri
{
    public class Korjaamo
    {
        private string nimi;
        private string osoite;
        private double tuntihinta;


        public string Nimi
        {
            get { return nimi; }
            set { nimi = value; }
        }

        public string Osoite
        {
            get { return osoite; }
            set { osoite = value; }
        }

        public double Tuntihinta
        {
            get { return tuntihinta; }
            set { tuntihinta = value; }

        }



        public Korjaamo(string nimi, string osoite, double tuntihinta)
        {
            Nimi = nimi;
            Osoite = osoite;
            Tuntihinta = tuntihinta;

        }

        public void LaskeHinta()
        {
            double varaosanhinta = 0;
            double osatyht = 0;
            double tyohinta = 0;
            double kokonaishinta = 0;
            double tyoaika = 0;
            double aleVaraosa = 0;
            double aleTyo = 0;




            while (varaosanhinta != -1)
            {
                osatyht = osatyht + varaosanhinta;


                Console.Write("Anna tuotteen hinta: (-1 lopettaa tuotteiden syöttämisen)");
                varaosanhinta = Convert.ToDouble(Console.ReadLine());


            }

            Console.Write("Alennus prosentteina varaosista ");
            aleVaraosa = Convert.ToDouble(Console.ReadLine());

            Console.Write("\nkauanko työhön meni aikaa(h)? ");
            tyoaika = Convert.ToDouble(Console.ReadLine());


            Console.Write("Alennus prosentteina tyosta ");
            aleTyo = Convert.ToDouble(Console.ReadLine());




            tyohinta = tuntihinta * tyoaika;




            kokonaishinta = osatyht * ((100 - aleVaraosa) / 100) + tyohinta * ((100 - aleTyo) / 100);





            Console.WriteLine("\nOsat yhteensä: {0} euroa ", osatyht * ((100 - aleVaraosa) / 100));
            Console.WriteLine("{0} euron tuntiveloituksella työveloitus yhteensä: {1} euroa", tuntihinta, tyohinta * ((100 - aleTyo) / 100));
            Console.WriteLine("\nOsat ja työ yhteensä : {0} euroa", kokonaishinta);
            Console.ReadLine();
        }
    }
}
