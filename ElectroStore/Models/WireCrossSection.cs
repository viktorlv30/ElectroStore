using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ElectroStore.Models
{
    public struct WireCrossSection
    {
        public int _wireNumber;
        public double _wireCross;

        public WireCrossSection(int number, double cross)
        {
            _wireNumber = number;
            _wireCross = cross;
        }

        public override string ToString()
        {
            return string.Format($"{_wireNumber}x{_wireCross}");
        }
    }
}