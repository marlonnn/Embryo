using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmbryoExpress.Instrument
{
    public class TemperLowering : BaseInstrument
    {
        private int liquidNitrogen;
        public int LiquidNitrogen
        {
            get { return this.liquidNitrogen; }
            set { this.liquidNitrogen = value; }
        }

        private int startTemperature;
        public int StartTemperature
        {
            get { return this.startTemperature; }
            set { this.startTemperature = value; }
        }

        private int seedingTemperature;
        public int SeedingTemperature
        {
            get { return this.seedingTemperature; }
            set { this.seedingTemperature = value; }
        }

        private int endTemperature;
        public int EndTemperature
        {
            get { return this.endTemperature; }
            set { this.endTemperature = value; }
        }
    }
}
