using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPZ3
{
    public class PC
    {
        int _RAM;
        double _CP;
        int _HDD;
        public PC ()
        {
            _RAM = 16000;
            _CP = 4.21;
            _HDD = 1000;
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
    }
}
