using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmbryoExpress.Instrument
{
    public class Instruments
    {
        private DateTime dateTime;
        public DateTime DateTime
        {
            get { return this.dateTime; }
            set { this.dateTime = value; }
        }

        private Incubator incubator;
        public Incubator Incubator
        {
            get { return this.incubator; }
            set { this.incubator = value; }
        }

        private Microscope microscope;
        public Microscope Microscope
        {
            get { return this.microscope; }
            set { this.microscope = value; }
        }

        private Cylinder cylinder;
        public Cylinder Cylinder
        {
            get { return this.cylinder; }
            set { this.cylinder = value; }
        }

        private HotStage hotStage;
        public HotStage HotStage
        {
            get { return this.hotStage; }
            set { this.hotStage = value; }
        }

        private TemperLowering temperLowering;
        public TemperLowering TemperLowering
        {
            get { return this.temperLowering; }
            set { this.temperLowering = value; }
        }

        private Fridge fridge;
        public Fridge Fridge
        {
            get { return this.fridge; }
            set { this.fridge = value; }
        }

        private AirConditioner airConditioner;
        public AirConditioner AirConditioner
        {
            get { return this.airConditioner; }
            set { this.airConditioner = value; }
        }

        private Thermometer thermometer;
        public Thermometer Thermometer
        {
            get { return this.thermometer; }
            set { this.thermometer = value; }
        }

        private Timer timer;
        public Timer Timer
        {
            get { return this.timer; }
            set { this.timer = value; }
        }

        private Co2Measurment co2Measurment;
        public Co2Measurment Co2Measurment
        {
            get { return this.co2Measurment; }
            set { this.co2Measurment = value; }
        }

        public Instruments() { }

        public Instruments(Incubator incubator, Microscope microscope, Cylinder cylinder, HotStage hotStage, TemperLowering temperLowering, 
            Fridge fridge, AirConditioner airConditioner, Thermometer thermometer, Timer timer, Co2Measurment co2Measurment)
        {
            this.incubator = incubator;
            this.microscope = microscope;
            this.cylinder = cylinder;
            this.hotStage = hotStage;
            this.temperLowering = temperLowering;
            this.fridge = fridge;
            this.airConditioner = airConditioner;
            this.thermometer = thermometer;
            this.timer = timer;
            this.co2Measurment = co2Measurment;
        }

    }
}
