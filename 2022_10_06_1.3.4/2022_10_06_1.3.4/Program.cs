using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace _2022_10_06_1._3._4
{
    class Auto
    {
        //Instanzvariablen
        public int Reifen;
        public double Motor;
        public string Türen;
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            //Objektgenerierung
            Auto MeinAuto = new Auto();
            Auto DeinAuto = new Auto();

            MeinAuto.Reifen = 18;
            MeinAuto.Motor = 158.5;
            MeinAuto.Türen = "Keyless Entry";

            DeinAuto.Reifen = 14;
            DeinAuto.Motor = 45;
            DeinAuto.Türen = "Rostig";

            MeinAuto = DeinAuto;
            DeinAuto.Motor = 100;
        }
    }
}
