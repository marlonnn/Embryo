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

        public void Simulator(int i)
        {
            Random radom1 = new Random(i);
            var r1 = radom1.Next(1, 100);
            this.co2Concentration = 1 * r1;

            Random radom2 = new Random(r1);
            var r2 = radom2.Next(15, 38);

            this.temperature = r2;
            this.Cleaning = Cleaning.Cleaned;
            this.Maintenance = Maintenance.Maintained;
            this.Calibration = Calibration.Calibrated;
        }
    }
}
