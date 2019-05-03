using EmbryoExpress.Instrument;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmbryoExpress
{
    public class SysData
    {
        private List<Instruments> instrumentsList;
        public List<Instruments> InstrumentsList { get { return this.instrumentsList; } }

        public SysData()
        {
            instrumentsList = new List<Instruments>();
        }

        public void SimulatorInstrumentsData()
        {
            DateTime dt = DateTime.Now;
            for (int i=0; i<30; i++)
            {
                Incubator incubator = new Incubator();
                incubator.Simulator();

                Microscope microscope = new Microscope();
                microscope.Calibration = Calibration.Calibrated;
                microscope.UsageRecord = "显微镜正常使用中";

                Cylinder cylinder = new Cylinder();
                cylinder.Pressure = (i + 1) * 10;
                cylinder.UsageRecord = "气瓶正常使用中";

                HotStage hs = new HotStage();
                hs.Temperature = i + 10;
                hs.UsageRecord = "热台正常使用中";

                TemperLowering theperLowering = new TemperLowering();
                theperLowering.LiquidNitrogen = (i + 10) * 3;
                theperLowering.StartTemperature = i + 10;
                theperLowering.SeedingTemperature = -(i + 10);
                theperLowering.EndTemperature = -(i + 10)* 2;

                Fridge fridge = new Fridge();
                fridge.Temperature = i + 10;
                fridge.ColdStorage = new Range(2, 8);
                fridge.Freezing = new Range(-15, -10);
                fridge.UsageRecord = "冰箱正常使用中";

                AirConditioner airConditioner = new AirConditioner();
                airConditioner.Temperature = i + 10;
                airConditioner.Humidity = (i + 10) * 2;
                airConditioner.UsageRecord = "空调正常使用中";

                Thermometer thermometer = new Thermometer();
                thermometer.Calibration = Calibration.Calibrated;
                thermometer.UsageRecord = "温度计正常使用中";

                Timer timer = new Timer();
                timer.Calibration = Calibration.Calibrated;
                timer.UsageRecord = "计时器正常使用中";

                Co2Measurment co2Measurment = new Co2Measurment();
                co2Measurment.Calibration = Calibration.Calibrated;
                co2Measurment.UsageRecord = "二氧化碳测量仪正常使用中";

                Instruments instruments = new Instruments(incubator, microscope, cylinder, hs, theperLowering,
                    fridge, airConditioner, thermometer, timer, co2Measurment);
                instruments.DateTime = DateTime.Now.AddDays(-i);
                instrumentsList.Add(instruments);
            }
        }
    }
}
