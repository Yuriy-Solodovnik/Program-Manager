using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPZ3
{
    public static class Store
    {
        public static Dictionary<string, Users> Users = new Dictionary<string, Users>();
        public static List<Programs> LPrograms = new List<Programs>();
        public static List<PC> pc = new List<PC>();
        public static void AddUser(Users u) => Users.Add(u.Name, u);
        public static bool RemoveUser(string key, string value)
        {
            if (Users.Keys.Contains(key)&&Users[key].Password == value)
            {
                Users.Remove(key);
                return true;
            }
            else
                return false;
        }
        public static void IsAvalible(PC p)
        {
            for (int i = 0; i < LPrograms.Count; i++)
            {
                if (p.CP < LPrograms[i].CP || p.RAM < LPrograms[i].RAM || p.HDD < LPrograms[i].HDD)
                    LPrograms[i].Avalible = false;
                else
                    LPrograms[i].Avalible = true;
            }
        }
        public static void AddProgram(Programs p) => LPrograms.Add(p);
        public static void RemoveProgram(int index) => LPrograms.RemoveAt(index);
    }
}
