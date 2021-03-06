﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TestProject.Controller;
using TestProject.Controller.ComboBoxOptions;
using TestProject.Controller.Interfaces;
using TestProject.Model;

namespace TestProject.View.Views
{
    public partial class TankView : UserControl, ITankView
    {
        private readonly NoneOption _comboBoxNoneOption = new NoneOption();
        private TankController _controller;

        public string TankName
        {
            get { return txtName.Text; }
            set { txtName.Text = value; }
        }

        public float StorageCapacity
        {
            get { return (float)nudCapacity.Value; }
            set { nudCapacity.Value = (decimal)value; }
        }

        public Fuel Fuel
        {
            get { return cbFuel.SelectedItem as Fuel; }
            set
            {
                if (value != null && cbFuel.Items.Contains(value))
                    cbFuel.SelectedItem = value;
                else
                    cbFuel.SelectedItem = _comboBoxNoneOption;
            }
        }

        public TankView()
        {
            InitializeComponent();
        }

        public void SetController(TankController controller)
        {
            _controller = controller;
        }

        public void SetFuelOptions(IEnumerable<Fuel> fuels)
        {
            cbFuel.Items.Clear();
            cbFuel.Items.Add(_comboBoxNoneOption);
            cbFuel.Items.AddRange(fuels.ToArray());
        }

        public void SetNozzlesUsingTank(IEnumerable<Nozzle> nozzles)
        {
            lbNozzles.Items.Clear();

            foreach (var nozzle in nozzles)
                lbNozzles.Items.Add(nozzle);
        }

        public void SetViewVisibility(bool visible)
        {
            Visible = visible;
        }

        private void btnGoToFuel_Click(object sender, EventArgs e)
        {
            _controller.NavigateToFuel();
        }
    }
}
