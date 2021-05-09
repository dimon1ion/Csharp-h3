using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLib.WordOfTanks
{
    public class Tank
    {
        public string Name { get; set; }
        public int Ammunition { get; set; }
        public int Armour { get; set; }
        public int Mobility { get; set; }

        public static Random tmp;

        static Tank()
        {
            tmp = new Random();
        }
        public Tank(string name)
        {
            Name = name;
            this.Ammunition = tmp.Next(0, 100);
            this.Armour = tmp.Next(0, 100);
            this.Mobility = tmp.Next(0, 100);
        }
        public static int operator *(Tank t1, Tank t2)
        {
            int winner = 0;
            int propertyTank1 = t1.Ammunition, propertyTank2 = t2.Ammunition;
            for (int i = 0; i < 3; i++)
            {
                if (i == 1) { propertyTank1 = t1.Armour; propertyTank2 = t2.Armour; }
                else if (i == 2) { propertyTank1 = t1.Mobility; propertyTank2 = t2.Mobility; }
                if (propertyTank1 > propertyTank2)
                {
                    winner++;
                }
                else if (propertyTank1 < propertyTank2)
                {
                    winner--;
                }
            }
            return winner;
        }
    }
}