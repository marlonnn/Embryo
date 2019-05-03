using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmbryoExpress.Instrument
{
    public class Incubator : BaseInstrument
    {
        private int co2Concentration;
        public int Co2Concentration
        {
            get { return this.co2Concentration; }
            set { this.co2Concentration = value; }
        }

        private int temperature;
        public int Temperature
        {
            get { return this.temperature; }
            set { this.temperature = value; }
        }

        public void Simulator()
        {
            Random r = new Random();
            this.co2Concentration = 40 * r.Next(1, 2);
            this.temperature = 15 * r.Next(1, 2);
            this.Cleaning = Cleaning.Cleaned;
            this.Maintenance = Maintenance.Maintained;
            this.Calibration = Calibration.Calibrated;
        }
    }
}
