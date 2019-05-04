using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmbryoExpress.Instrument
{
    public class Environment :BaseInstrument
    {
        private int temperature;
        public int Temperature
        {
            get { return this.temperature; }
            set { this.temperature = value; }

        }

        private int humidity;
        public int Humidity
        {
            get { return this.humidity; }
            set { this.humidity = value; }
        }

        private int tvoc;
        public int Tvoc
        {
            get { return this.tvoc; }
            set { this.tvoc = value; }
        }
    }
}
