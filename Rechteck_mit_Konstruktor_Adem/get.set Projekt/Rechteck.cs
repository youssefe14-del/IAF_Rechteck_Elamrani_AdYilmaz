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
            {// nur positive Werte zulassen
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
        public double Umfang

        {

            get

            {

                return 2 * hoehe + 2 * breite;

            }
        }

             public double Flaeche
        {
            get
            {

                return hoehe * breite;


            }
        
        }
        public Rechteck(double hoheDesRechtecks, double breiteDesRechtecks)
        {
            Breite = breiteDesRechtecks;
            Hoehe = hoheDesRechtecks;
        }
    }
 }
