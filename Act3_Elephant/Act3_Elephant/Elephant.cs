using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act3_Elephant
{
    class Elephant
    {
        private string _nom;
        private int _tailleOreille;

        public string Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }
        public int TailleOreille
        {
            get { return _tailleOreille; }
            set { _tailleOreille = value; }
        }

        public Elephant(string nom, int tailleOreille)
        {
            this._nom = nom;
            this._tailleOreille = tailleOreille;
        }

        public string WhoIAm()
        {
            string phrase = "Je m'appelle " + _nom + " et mes oreilles mesures " + _tailleOreille;
            return phrase;
        }

        public void EcouteMessage(string message, Elephant quiDit)
        {
            Console.WriteLine(_nom + " a entendu un message \n" + quiDit._nom + " a dis : " + message);
        }

        public void EnvoieMessage(string message, Elephant quiRecoit)
        {
            quiRecoit.EcouteMessage(message, quiRecoit);
        }

        public void PlusGrandeOreille(Elephant[] NewElephants, out string Phrase)
        {
            int grandOreille = 0;

            for (int i = 0; i < 10; i++)
            {
                if (NewElephants[grandOreille]._tailleOreille < NewElephants[i]._tailleOreille)
                {
                    grandOreille = i;
                    i = 0;
                }
            }

            Phrase = "L'éléphant qui les plus grande oreille s'appelle " + NewElephants[grandOreille]._nom + " et c'est oreille font " + NewElephants[grandOreille]._tailleOreille + " cm";
        }
    }
}
