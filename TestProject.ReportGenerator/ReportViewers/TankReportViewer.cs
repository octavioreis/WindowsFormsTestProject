using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using TestProject.Model;
using TestProject.ReportGenerator.ReportItems;

namespace TestProject.ReportGenerator.ReportViewers
{
    public partial class TankReportViewer : Form
    {
        private readonly IEnumerable<TankReportItem> _tankReportItems;

        public TankReportViewer(IEnumerable<Tank> tanks, IEnumerable<Fuel> fuels)
        {
            InitializeComponent();

            _tankReportItems = tanks.Select(t => new TankReportItem(
                t.Name,
                t.StorageCapacity.ToString(),
                fuels.FirstOrDefault(f => f.Id == t.FuelId)?.Name))
                .ToArray();
        }

        private void TankReportViewer_Load(object sender, EventArgs e)
        {
            TankReportItemBindingSource.DataSource = _tankReportItems;

            this.reportViewer.RefreshReport();
        }
    }
}
