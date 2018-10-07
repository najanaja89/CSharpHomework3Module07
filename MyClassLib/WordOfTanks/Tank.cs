using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyClassLib.WordOfTanks
{
    public class Tank
    {
        private Random rand = new Random();
        public string Name { set; get; }
        private int ammo;
        private int armor;
        private int mobility;

        public string GetAmmo()
        {
            return ammo.ToString();
        }
        public string GetArmor()
        {
            return armor.ToString();
        }
        public string GetMobility()
        {
            return mobility.ToString();
        }


        public Tank(string name)
        {
            Name = name;
            ammo = rand.Next(0, 101);
            armor = rand.Next(0, 101);
            mobility = rand.Next(0, 101);
        }

        public static string operator *(Tank t1, Tank t2)
        {

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

            else if (t1.ammo == t2.ammo && t1.mobility == t2.mobility)
            {
                string result = "draw!";
                return result;
            }


            else return t2.Name;

        }
    }
}
