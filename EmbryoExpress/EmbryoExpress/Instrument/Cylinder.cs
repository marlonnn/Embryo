using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmbryoExpress.Instrument
{
    public class Cylinder : BaseInstrument
    {
        private int pressure;
        public int Pressure
        {
            get { return this.pressure; }
            set { this.pressure = value; }
        }
    }
}
