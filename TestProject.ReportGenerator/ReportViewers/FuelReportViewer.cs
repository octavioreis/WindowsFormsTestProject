using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using TestProject.Globalization;
using TestProject.Model;
using TestProject.ReportGenerator.ReportItems;

namespace TestProject.ReportGenerator.ReportViewers
{
    public partial class FuelReportViewer : Form
    {
        private readonly IEnumerable<FuelReportItem> _fuelReportItems;

        public FuelReportViewer(IEnumerable<Fuel> fuels)
        {
            InitializeComponent();

            _fuelReportItems = fuels.Select(f => new FuelReportItem(
                f.Name,
                Translator.Translate(f.Type.ToString())))
                .ToArray();
        }

        private void FuelReportViewer_Load(object sender, EventArgs e)
        {
            FuelReportItemBindingSource.DataSource = _fuelReportItems;

            this.reportViewer1.RefreshReport();
        }
    }
}
