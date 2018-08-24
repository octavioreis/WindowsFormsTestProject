using System.Windows.Forms;
using TestProject.Controller;
using TestProject.Controller.Interfaces;

namespace TestProject.View.Views
{
    public partial class SaveView : UserControl, ISaveView
    {
        private SaveController _controller;

        public SaveView()
        {
            InitializeComponent();
        }

        #region ISaveView Members

        public IFuelView GetFuelView()
        {
            return fuelView;
        }

        public ITankView GetTankView()
        {
            return tankView;
        }

        public INozzleView GetNozzleView()
        {
            return nozzleView;
        }

        public void SetSaveButtonTooltip(string text)
        {
            toolTip.SetToolTip(btnSave, text);
        }

        public void SetController(SaveController controller)
        {
            _controller = controller;
        }

        #endregion

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.S))
            {
                SerializeModelChanges();
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void SerializeModelChanges()
        {
            if (_controller.TryUpdateModel(out string message))
            {
                var timer = new Timer
                {
                    Interval = 2000
                };

                lblSaveSuccess.Show();

                timer.Tick += (s, e) =>
                {
                    lblSaveSuccess.Hide();
                    timer.Stop();
                };

                timer.Start();
            }
            else
                MessageBox.Show(message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            SerializeModelChanges();
        }
    }
}
