﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Levesek_KB
{
    class Leves
    {
        string megnevezes;
        int kaloria;
        double feherje;
        double zsir;
        double szenhidrat;
        double hamu;
        double rost;

        public string Megnevezes { get => megnevezes; set => megnevezes = value; }
        public int Kaloria { get => kaloria; set => kaloria = value; }
        public double Feherje { get => feherje; set => feherje = value; }
        public double Zsir { get => zsir; set => zsir = value; }
        public double Szenhidrat { get => szenhidrat; set => szenhidrat = value; }
        public double Hamu { get => hamu; set => hamu = value; }
        public double Rost { get => rost; set => rost = value; }

        public Leves(string megnevezes, int kaloria, double feherje, double zsir, double szenhidrat, double hamu, double rost)
        {
            this.megnevezes = megnevezes;
            this.kaloria = kaloria;
            this.feherje = feherje;
            this.zsir = zsir;
            this.szenhidrat = szenhidrat;
            this.hamu = hamu;
            this.rost = rost;
        }
    }

    
  

}
