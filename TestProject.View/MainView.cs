﻿using System.Collections.Generic;
using System.Windows.Forms;
using TestProject.Controller;
using TestProject.Controller.Interfaces;
using TestProject.Model;
using TestProject.Model.Enums;
using TestProject.ReportGenerator.ReportViewers;

namespace TestProject.View
{
    public partial class MainView : Form, IMainView
    {
        private MainController _controller;

        public MainView()
        {
            InitializeComponent();
        }

        #region IMainView Members

        public void SetController(MainController controller)
        {
            _controller = controller;
        }

        public IItemsView GetItemsView()
        {
            return itemsView;
        }

        public RegistryType? GetSelectedTab()
        {
            if (rbFuels.Checked)
                return RegistryType.Fuel;
            else if (rbTanks.Checked)
                return RegistryType.Tank;
            else if (rbNozzles.Checked)
                return RegistryType.Nozzle;

            return null;
        }

        public void SelectTab(RegistryType type)
        {
            switch (type)
            {
                case RegistryType.Fuel:
                    rbFuels.Checked = true;
                    break;
                case RegistryType.Tank:
                    rbTanks.Checked = true;
                    break;
                case RegistryType.Nozzle:
                    rbNozzles.Checked = true;
                    break;
                default:
                    break;
            }
        }

        public void ShowFuelsReport(IEnumerable<Fuel> fuels)
        {
            var reportForm = new FuelReportViewer(fuels);
            reportForm.ShowDialog();
        }

        public void ShowTanksReport(IEnumerable<Tank> tanks, IEnumerable<Fuel> fuels)
        {
            var reportForm = new TankReportViewer(tanks, fuels);
            reportForm.ShowDialog();
        }

        public void ShowNozzlesReport(IEnumerable<Nozzle> nozzles, IEnumerable<Tank> tanks)
        {
            var reportForm = new NozzleReportViewer(nozzles, tanks);
            reportForm.ShowDialog();
        }

        #endregion

        private void selectedTab_Changed(object sender, System.EventArgs e)
        {
            var radioButton = (RadioButton)sender;
            if (radioButton.Checked)
                _controller.LoadSelectedTab();
        }

        private void fuelsToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            _controller.ShowFuelsReport();
        }

        private void tanksToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            _controller.ShowTanksReport();
        }

        private void nozzlesToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            _controller.ShowNozzlesReport();
        }

        private void closeToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }
    }
}
