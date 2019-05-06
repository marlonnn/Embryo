using EmbryoExpress.UI.Report;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmbryoExpress.UI
{
    public partial class ReportForm : DevComponents.DotNetBar.Office2007Form
    {
        private Font _font;
        private Font _boldFont;

        private IncubatorControl incubatorControl;
        private HotStageControl hotStageControl;
        private TemperLoweringControl temperLoweringControl;
        private FridgeControl fridgeControl;
        private AirConditionerControl airConditionerControl;
        private EnvironmentControl environmentControl;
        private StatisticalItemsControl statisticalItemsControl;

        private Control[] _btnControls;

        public ReportForm()
        {
            InitializeComponent();

            _font = Font;
            _boldFont = new Font(Font, FontStyle.Bold);

            _btnControls = new Control[]
            {
                btnIncubator,
                btnHotStage,
                btnTemperatureLowering,
                btnFridge,
                btnAirConditioner,
                btnEnvironment,
                btnStatisticalItems,
                btnReport
            };

            incubatorControl = new IncubatorControl();
            incubatorControl.Dock = DockStyle.Fill;

            hotStageControl = new HotStageControl();
            hotStageControl.Dock = DockStyle.Fill;

            temperLoweringControl = new TemperLoweringControl();
            temperLoweringControl.Dock = DockStyle.Fill;

            fridgeControl = new FridgeControl();
            fridgeControl.Dock = DockStyle.Fill;

            airConditionerControl = new AirConditionerControl();
            airConditionerControl.Dock = DockStyle.Fill;

            environmentControl = new EnvironmentControl();
            environmentControl.Dock = DockStyle.Fill;

            statisticalItemsControl = new StatisticalItemsControl();
            statisticalItemsControl.Dock = DockStyle.Fill;

            panelIncubator.Controls.Add(incubatorControl);
            panelHotStage.Controls.Add(hotStageControl);
            panelTemperatureLowering.Controls.Add(temperLoweringControl);
            panelFridge.Controls.Add(fridgeControl);
            panelAirConditioner.Controls.Add(airConditionerControl);
            panelEnvironment.Controls.Add(environmentControl);
            panelStatisticalItems.Controls.Add(statisticalItemsControl);

            ShowControl(btnIncubator, panelIncubator);
        }

        private void ShowControl(Control toShowLabel, DevExpress.XtraBars.Navigation.NavigationPage toShowPanel)
        {
            foreach (var label in _btnControls)
            {
                bool active = label == toShowLabel;

                var font = active ? _boldFont : _font;
                if (label.Font != font) label.Font = font;

                var color = active ? Color.FromArgb(0, 64, 128) : Color.Black;
                if (label.ForeColor != color) label.ForeColor = color;
            }

            tabControl1.SelectedPage = toShowPanel;
        }

        private void btnIncubator_Click(object sender, EventArgs e)
        {
            ShowControl(btnIncubator, panelIncubator);
        }

        private void btnHotStage_Click(object sender, EventArgs e)
        {
            ShowControl(btnHotStage, panelHotStage);
        }

        private void btnTemperatureLowering_Click(object sender, EventArgs e)
        {
            ShowControl(btnTemperatureLowering, panelTemperatureLowering);
        }

        private void btnFridge_Click(object sender, EventArgs e)
        {
            ShowControl(btnFridge, panelFridge);
        }

        private void btnAirConditioner_Click(object sender, EventArgs e)
        {
            ShowControl(btnAirConditioner, panelAirConditioner);
        }

        private void btnEnvironment_Click(object sender, EventArgs e)
        {
            ShowControl(btnEnvironment, panelEnvironment);
        }

        private void btnStatisticalItems_Click(object sender, EventArgs e)
        {
            ShowControl(btnStatisticalItems, panelStatisticalItems);
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            ShowControl(btnReport, panelReport);
        }
    }
}
