using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmbryoExpress.Instrument
{
    public class StatisticalItems : BaseInstrument
    {
        public StatisticalItems()
        {

        }

        public StatisticalItems(int excellentEmbryo, int blastocystFormation, int pregnancyRate, int fertilizationRate, int implantationRate)
        {
            this.excellentEmbryo = excellentEmbryo;
            this.blastocystFormation = blastocystFormation;
            this.pregnancyRate = pregnancyRate;
            this.fertilizationRate = fertilizationRate;
            this.implantationRate = implantationRate;
        }
        private int excellentEmbryo;
        public int ExcellentEmbryo
        {
            get { return this.excellentEmbryo; }
            set { this.excellentEmbryo = value; }

        }
        private int blastocystFormation;
        public int BlastocystFormation
        {
            get { return this.blastocystFormation; }
            set { this.blastocystFormation = value; }

        }
        private int pregnancyRate;
        public int PregnancyRate
        {
            get { return this.pregnancyRate; }
            set { this.pregnancyRate = value; }

        }
        private int fertilizationRate;
        public int FertilizationRate
        {
            get { return this.fertilizationRate; }
            set { this.fertilizationRate = value; }

        }
        private int implantationRate;
        public int ImplantationRate
        {
            get { return this.implantationRate; }
            set { this.implantationRate = value; }
        }
    }
}
