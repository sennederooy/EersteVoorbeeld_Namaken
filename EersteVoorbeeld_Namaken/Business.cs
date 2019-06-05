using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EersteVoorbeeld_Namaken
{
    class Business
    {
        //velden
        private Persistance _persistence;
        private List<Evaluatie> _evaluatieLijst;

        //eigenschap
        public List<Evaluatie> Lijst
        {
            get { return _evaluatieLijst; }
        }


        //constructor
        public Business()
        {
            _persistence = new Persistance();
            _evaluatieLijst = _persistence.getEvaluatiesFromDB();
        }
        public Business(string connectionstring)
        {
            _persistence = new Persistance(connectionstring);
            _evaluatieLijst = _persistence.getEvaluatiesFromDB();
        }
        //methode
        public double getTotaalPunten()
        {
            double totaal = 0;
            foreach (Evaluatie item in _evaluatieLijst)
            {
                totaal += item.Punt;
            }
            return totaal;
        }
        public double gettotaalTotalen()
        {
            double totaal = 0;
            foreach (Evaluatie item in _evaluatieLijst)
            {
                totaal += item.Totaal;
            }
            return totaal;
        }
        public double getPersentage()
        {
            return getTotaalPunten() / gettotaalTotalen() * 100;
        }
    }
}
