using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPZ3
{
    public class Programs
    {
        string _Name;
        string _OS;
        string _Maker;
        bool _Avalible = false;
        DateTime _InstalDate;
        double _Version;
        int _RAM;
        double _CP;
        int _HDD;
        Random r = new Random();
        public Programs ()
        {
            _Name = "VisualStudio";
            _OS = "Windows";
            _Maker = "Microsoft";
            _InstalDate = DateTime.Today;
            _Version = 1.00;
            _RAM = 4;
            _CP = 2.4;
            _HDD = 10;
        }
        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                if (value == "")
                    return;
                else
                    _Name = value;
            }
        }
        public string OS
        {
            get
            {
                return _OS;
            }
            set
            {
                if (value == "")
                    return;
                else
                    _OS = value;
            }
        }
        public string Maker
        {
            get
            {
                return _Maker;
            }
            set
            {
                if (value == "")
                    return;
                else
                    _Maker = value;
            }
        }
        public bool Avalible
        {
            get
            {
                return _Avalible;
            }
            set
            {
                _Avalible = value;
            }
        }
        public DateTime InstalDate
        {
            get
            {
                return _InstalDate;
            }
            set
            {
                if (value == null)
                    return;
                else
                    _InstalDate = value;
            }
        }
        public double Version
        {
            get
            {
                return _Version;
            }
            set
            {
                if (value == 0.0)
                    return;
                else
                    _Version = value;
            }
        }
        public int RAM
        {
            get
            {
                return _RAM;
            }
            set
            {
                if (value < 2000)
                    return;
                else
                    _RAM = value;
            }
        }
        public double CP
        {
            get
            {
                return _CP;
            }
            set
            {
                if (value == 0.0)
                    return;
                else
                    _CP = value;
            }
        }
        public int HDD
        {
            get
            {
                return _HDD;
            }
            set
            {
                if (value < 5)
                    return;
                else
                    _HDD = value;
            }
        }
        public void UpdateProgram(double version)
        {
            if (version > _Version)
            {
                _Version = version;
                HDD += r.Next(1, 10);
                CP += r.NextDouble();
                RAM += r.Next(1, 10);
            }
            else
                return;
        }
        public static bool operator >(Programs p1, Programs p2)
        {
            return (p1.RAM > p2.RAM && p1.CP > p2.CP && p1.HDD > p2.HDD);
        }
        public static bool operator <(Programs p1, Programs p2)
        {
            return (p1.RAM < p2.RAM && p1.CP < p2.CP && p1.HDD < p2.HDD);
        }
    }
}
