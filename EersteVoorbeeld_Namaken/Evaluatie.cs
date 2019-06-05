using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EersteVoorbeeld_Namaken
{
    class Evaluatie
    {
        //velden en eigeschappen
        private int _id;
        public int ID { get { return _id; } }
        private string _onderwerp;
        public string Onderwerp { get { return _onderwerp; } set { _onderwerp = value; } }
        private DateTime _datum;
        public DateTime Datum { get { return _datum; } }
        private double _punt;
        public double Punt { get { return _punt; } }
        private double _totaal;
        public double Totaal { get { return _totaal; } }

        //constructors
        public Evaluatie(int id, string onderwerp, DateTime datum, double punt, double totaal)
        {
            _id = id;
            _onderwerp = onderwerp;
            _datum = datum;
            _punt = punt;
            _totaal = totaal;
        }
        public Evaluatie(string onderwerp, DateTime datum, double punt, double totaal)
        {
            _onderwerp = onderwerp;
            _datum = datum;
            _punt = punt;
            _totaal = totaal;
        }
        //methodes
        public override string ToString()
        {
            return _id + ": " + _onderwerp + " - " + _datum.ToShortDateString() + " - (" + _punt + "/" + _totaal + ")";
        }
    }
}
