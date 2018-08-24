using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using TestProject.Model;
using TestProject.ReportGenerator.ReportItems;

namespace TestProject.ReportGenerator.ReportViewers
{
    public partial class NozzleReportViewer : Form
    {
        private readonly IEnumerable<NozzleReportItem> _nozzleReportItems;

        public NozzleReportViewer(IEnumerable<Nozzle> nozzles, IEnumerable<Tank> tanks)
        {
            InitializeComponent();

            _nozzleReportItems = nozzles.Select(n => new NozzleReportItem(
                n.Name,
                n.SellingPrice.ToString(),
                tanks.FirstOrDefault(t => t.Id == n.TankId)?.Name))
                .ToArray();
        }

        private void NozzleReportViewer_Load(object sender, EventArgs e)
        {
            NozzleReportItemBindingSource.DataSource = _nozzleReportItems;

            this.reportViewer.RefreshReport();
        }
    }
}
