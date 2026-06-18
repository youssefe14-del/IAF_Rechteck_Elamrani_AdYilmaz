 using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace get.set_Projekt
{
    internal class Rechteck
    {
      //Attribute
        private double hoehe;
        private double breite;


        
        //Eigenschaften
        // regeln den Zugriff auf private Attribute --> nur plausible Werte 
        public double Hoehe
        {
            get { return hoehe; }
            set
            {   // nur positive Werte zulassen
                if (value > 0)
                    {
                        hoehe = value;
                    }

                else
                    {
                        throw new Exception("Höhe muss größer als 0 sein!");
                    }
            }
        }

        // Es werden nur Werte größer als 0 akzeptiert sonst wird eine Fehlermeldung ausgegeben
        public double Breite
        {
            get { return breite; }
            set
            {
                if (value > 0)
                {
                    breite = value;
                }

                else
                {
                    throw new Exception("Breite muss größer als 0 sein!");
                }
            }
        }

        // Berechnet den Umfang des Rechtecks aus Höhe und Breite
        public double Umfang
        {
            get
            { 
                return 2 * hoehe + 2 * breite;
            }
        }


        // Berechnet die Fläche des Rechtecks 
        public double Flaeche
             {
                 get
                 {
                    return hoehe * breite;
                 }
             }

        // Berechnet die Diagonale des Rechtecks
        public double Diagonale()
        {
            return Math.Sqrt ( (hoehe * hoehe) + (breite * breite) );
        }

        // Erstellt ein Rechteck und setzt Höhe und Breite
        public Rechteck(double hoheDesRechtecks, double breiteDesRechtecks)
        {
            Breite = breiteDesRechtecks;
            Hoehe = hoheDesRechtecks;
        }

        // Dreht das Rechteck indem Höhe und Breite vertauscht werden
        public void Rechtsumdrehung()
       {
            double tausch = hoehe;
            hoehe = breite;
            breite = tausch;
       }

        // Der Faktor muss größer als 0 sein, sonst kommt eine Fehlermeldung
        public void zoomen(double faktor)
        { if (faktor > 0)
            {
                hoehe = hoehe * faktor;
                breite = breite * faktor;

            }
            else throw new Exception(" zoomen.faktor muss positiv sein");
        }
    }
}
