using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using InStep.eDNA.EzDNAApiNet;

namespace eDNA_watcher
{
    public class RealResult
    {
        public double dval { get; set; }
        public DateTime timestamp { get; set; }
        public string status { get; set; }
        public string desc { get; set; }
        public string units { get; set; }
    }

    class eDNAReader
    {
        public RealResult getReal(string pnt)
        {

            int nret = 0;
            double dval = 0;
            DateTime timestamp = DateTime.Now;
            string status = "";
            string desc = "";
            string units = "";
            nret = RealTime.DNAGetRTAll(pnt, out dval, out timestamp, out status, out desc, out units);//get RT value
            RealResult realVal;
            if (nret == 0)
            {
                realVal = new RealResult { dval = dval, timestamp = timestamp, status = status, units = units };
                return realVal;
            }
            return null;
        }
    }
}
