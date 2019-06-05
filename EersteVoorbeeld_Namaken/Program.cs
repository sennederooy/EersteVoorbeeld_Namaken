using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EersteVoorbeeld_Namaken
{
    class Program
    {
        static void Main(string[] args)
        {
            Business _business = new Business();
            //lijst afdrukken
            //percentage berekenen
            double totaalPunten = _business.getTotaalPunten(), totaalTotalen = _business.gettotaalTotalen(), percentage = _business.getPersentage();
            Console.WriteLine("De resultaten zijn: ");
            foreach (Evaluatie item in _business.Lijst)
            {
                Console.WriteLine(item.ToString());

            }
            Console.WriteLine();
            Console.WriteLine("Je behaalde een totaal van: {0}/{1}. Dit is {2}%", totaalPunten, totaalTotalen, Math.Round(percentage, 2));
            Console.ReadKey();
        }
    }
}
