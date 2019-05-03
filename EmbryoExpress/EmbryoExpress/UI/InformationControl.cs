using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmbryoExpress.Instrument;

namespace EmbryoExpress.UI
{
    public partial class InformationControl : UserControl
    {
        private List<Instruments> instrumentsList;
        public InformationControl()
        {
            InitializeComponent();
            SysData sysData = new SysData();
            sysData.SimulatorInstrumentsData();
            instrumentsList = sysData.InstrumentsList;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            ApplyDatas(instrumentsList[0]);
        }

        private void ApplyDatas(Instruments instruments)
        {
            ApplyIncubatorData(instruments.Incubator);
            ApplyMicroscopeData(instruments.Microscope);
            ApplyCylinderData(instruments.Cylinder);
            ApplyHotStageData(instruments.HotStage);
            ApplyTemperLoweringData(instruments.TemperLowering);
            ApplyFridgeData(instruments.Fridge);
            ApplyAirConditionerData(instruments.AirConditioner);
            ApplyThermometerData(instruments.Thermometer);
            ApplyTimer(instruments.Timer);
            ApplyCo2Measument(instruments.Co2Measurment);
        }

        private void ApplyIncubatorData(Incubator incubator)
        {
            this.txtCO2Concentration.Text = string.Format("{0}%", incubator.Co2Concentration);
            this.txtTemperature.Text = string.Format("{0}℃", incubator.Temperature);

            this.txtIncubatorMaintenance.BackColor = incubator.Maintenance == Maintenance.Maintained ?
                 System.Drawing.SystemColors.Window : Color.Yellow;
            this.txtIncubatorMaintenance.Text = incubator.Maintenance.ToDescription();

            this.txtCleaning.BackColor = incubator.Cleaning == Cleaning.Cleaned ? 
                System.Drawing.SystemColors.Window : Color.Yellow;
            this.txtCleaning.Text = incubator.Cleaning.ToDescription();

            this.txtCalibration.BackColor = incubator.Calibration == Calibration.Calibrated ?
                System.Drawing.SystemColors.Window : Color.Yellow;
            this.txtCalibration.Text = incubator.Calibration.ToDescription();
        }

        private void ApplyMicroscopeData(Microscope microscope)
        {
            this.txtMicroCleaning.BackColor = microscope.Cleaning == Cleaning.Cleaned ? 
                System.Drawing.SystemColors.Window : Color.Yellow;
            this.txtMicroCleaning.Text = microscope.Cleaning.ToDescription();
            this.txtMicroUsageRecord.Text = microscope.UsageRecord;
        }

        private void ApplyCylinderData(Cylinder cylinder)
        {
            this.txtCylinderPressure.Text = cylinder.Pressure.ToString();
            this.txtCylinderUsageRercord.Text = cylinder.UsageRecord;
        }

        private void ApplyHotStageData(HotStage hotStage)
        {
            this.txtHotStageTemperature.Text = string.Format("{0}℃", hotStage.Temperature);
            this.txtHotStageUsageRercord.Text = hotStage.UsageRecord;
        }

        private void ApplyTemperLoweringData(TemperLowering temperLowering)
        {
            this.txtLiquidNitrogen.Text = string.Format("{0}%", temperLowering.LiquidNitrogen);
            this.txtStartTemperature.Text = string.Format("{0}℃", temperLowering.StartTemperature);
            this.txtSeedTemperature.Text = string.Format("{0}℃", temperLowering.SeedingTemperature);
            this.txtEndTemperature.Text = string.Format("{0}℃", temperLowering.EndTemperature);
        }

        private void ApplyFridgeData(Fridge fridge)
        {
            this.txtFridgeTemperature.Text = string.Format("{0}℃", fridge.Temperature);
            this.txtColdStorage.Text = string.Format("{0}℃ ~ {1}℃", fridge.ColdStorage.MinValue, fridge.ColdStorage.MaxValue);
            this.txtFreezing.Text = string.Format("{0}℃ ~ {1}℃", fridge.Freezing.MinValue, fridge.Freezing.MaxValue);
            this.txtFridgeUsageRecord.Text = fridge.UsageRecord;
        }

        private void ApplyAirConditionerData(AirConditioner airConditioner)
        {
            this.txtAirTemperature.Text = string.Format("{0}℃", airConditioner.Temperature);
            this.txtAirHumidity.Text = string.Format("{0}%", airConditioner.Humidity);
            this.txtAirUsageRecord.Text = airConditioner.UsageRecord;
        }

        private void ApplyThermometerData(Thermometer thermometer)
        {
            this.txtThermCalibration.BackColor = thermometer.Calibration == Calibration.Calibrated ? 
                System.Drawing.SystemColors.Window : Color.Yellow;
            this.txtThermCalibration.Text = thermometer.Calibration.ToDescription();
            this.txtThermoUsageRecord.Text = thermometer.UsageRecord;
        }

        private void ApplyTimer(Instrument.Timer timer)
        {
            this.txtTimerCalibration.BackColor = timer.Calibration == Calibration.Calibrated ? 
                System.Drawing.SystemColors.Window : Color.Yellow;
            this.txtTimerCalibration.Text = timer.Calibration.ToDescription();
            this.txtTimerUsageRecord.Text = timer.UsageRecord;
        }

        private void ApplyCo2Measument(Co2Measurment co2Measurment)
        {
            this.txtCo2Calibration.BackColor = co2Measurment.Calibration == Calibration.Calibrated ? 
                System.Drawing.SystemColors.Window : Color.Yellow;
            this.txtCo2Calibration.Text = co2Measurment.Calibration.ToDescription();
            this.txtCo2UsageRecord.Text = co2Measurment.UsageRecord;
        }
    }
}
