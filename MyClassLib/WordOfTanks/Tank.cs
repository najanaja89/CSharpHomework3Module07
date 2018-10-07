using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyClassLib.WordOfTanks
{
    class Tank
    {
        private Random rand = new Random();
        private string Name { set; get; }
        private int ammo;
        private int armor;
        private int mobility;

        string GetAmmo()
        {
            return ammo.ToString();
        }
        string GetArmor()
        {
            return armor.ToString();
        }
        string GetMobility()
        {
            return mobility.ToString();
        }


        public Tank(string name)
        {
            Name = name;
            ammo = rand.Next(0, 100);
            armor = rand.Next(0, 100);
            mobility = rand.Next(0, 100);
        }

        public static string operator *(Tank t1, Tank t2)
        {
            Tank t3 = new Tank("Winner");

            if (t1.mobility > t2.mobility && t1.ammo > t2.ammo)
            {
                return t1.Name;
            }
            else if (t1.mobility > t2.mobility && t1.armor > t2.armor)
            {
                return t1.Name;
            }

            else if (t1.ammo > t2.ammo && t1.armor > t2.armor)
            {
                return t1.Name;
            }

            else if (t1.ammo == t2.ammo && t1.armor == t2.armor)
            {
                string result = "draw!";
                return result;
            }

            else if (t1.mobility == t2.mobility && t1.armor == t2.armor)
            {
                string result = "draw!";
                return result;
            }

            else return t2.Name;

        }
    }
}
