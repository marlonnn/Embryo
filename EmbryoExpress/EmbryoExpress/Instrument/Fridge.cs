using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmbryoExpress.Instrument
{
    public class Fridge : BaseInstrument
    {
        private int temperature;
        public int Temperature
        {
            get { return this.temperature; }
            set { this.temperature = value; }

        }

        private Range coldStorage;
        public Range ColdStorage
        {
            get { return this.coldStorage; }
            set { this.coldStorage = value; }
        }

        private Range freezing;
        public Range Freezing
        {
            get { return this.freezing; }
            set { this.freezing = value; }
        }
    }
}
