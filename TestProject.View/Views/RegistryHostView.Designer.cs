namespace TestProject.View.Views
{
    partial class RegistryHostView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.fuelView = new TestProject.View.Views.FuelView();
            this.tankView = new TestProject.View.Views.TankView();
            this.nozzleView = new TestProject.View.Views.NozzleView();
            this.tlpSave = new System.Windows.Forms.TableLayoutPanel();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblSaveSuccess = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.tlpMain.SuspendLayout();
            this.tlpSave.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.fuelView, 0, 0);
            this.tlpMain.Controls.Add(this.tankView, 0, 0);
            this.tlpMain.Controls.Add(this.nozzleView, 0, 0);
            this.tlpMain.Controls.Add(this.tlpSave, 0, 1);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 2;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.Size = new System.Drawing.Size(407, 331);
            this.tlpMain.TabIndex = 0;
            // 
            // fuelView
            // 
            this.fuelView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fuelView.FuelName = "";
            this.fuelView.FuelType = TestProject.Model.Enums.FuelType.CommonGasoline;
            this.fuelView.Location = new System.Drawing.Point(3, 294);
            this.fuelView.Name = "fuelView";
            this.fuelView.Size = new System.Drawing.Size(401, 14);
            this.fuelView.TabIndex = 0;
            this.fuelView.Visible = false;
            // 
            // tankView
            // 
            this.tankView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tankView.Fuel = null;
            this.tankView.Location = new System.Drawing.Point(3, 274);
            this.tankView.Name = "tankView";
            this.tankView.Size = new System.Drawing.Size(401, 14);
            this.tankView.StorageCapacity = 0F;
            this.tankView.TabIndex = 2;
            this.tankView.TankName = "";
            this.tankView.Visible = false;
            // 
            // nozzleView
            // 
            this.nozzleView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nozzleView.Location = new System.Drawing.Point(3, 3);
            this.nozzleView.Name = "nozzleView";
            this.nozzleView.NozzleName = "";
            this.nozzleView.SellingPrice = 0F;
            this.nozzleView.Size = new System.Drawing.Size(401, 265);
            this.nozzleView.TabIndex = 1;
            this.nozzleView.Tank = null;
            this.nozzleView.Visible = false;
            // 
            // tlpSave
            // 
            this.tlpSave.AutoSize = true;
            this.tlpSave.ColumnCount = 2;
            this.tlpSave.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSave.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpSave.Controls.Add(this.btnSave, 1, 0);
            this.tlpSave.Controls.Add(this.lblSaveSuccess, 0, 0);
            this.tlpSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSave.Location = new System.Drawing.Point(3, 314);
            this.tlpSave.Name = "tlpSave";
            this.tlpSave.RowCount = 1;
            this.tlpSave.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSave.Size = new System.Drawing.Size(401, 14);
            this.tlpSave.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Image = global::TestProject.View.Properties.Resources.save_icon;
            this.btnSave.Location = new System.Drawing.Point(366, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(32, 8);
            this.btnSave.TabIndex = 6;
            this.btnSave.TabStop = false;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblSaveSuccess
            // 
            this.lblSaveSuccess.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblSaveSuccess.AutoSize = true;
            this.lblSaveSuccess.Location = new System.Drawing.Point(258, 0);
            this.lblSaveSuccess.Name = "lblSaveSuccess";
            this.lblSaveSuccess.Size = new System.Drawing.Size(102, 13);
            this.lblSaveSuccess.TabIndex = 7;
            this.lblSaveSuccess.Text = "Salvo com sucesso!";
            this.lblSaveSuccess.Visible = false;
            // 
            // SaveView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpMain);
            this.Name = "SaveView";
            this.Size = new System.Drawing.Size(407, 331);
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.tlpSave.ResumeLayout(false);
            this.tlpSave.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.TableLayoutPanel tlpSave;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblSaveSuccess;
        private FuelView fuelView;
        private TankView tankView;
        private NozzleView nozzleView;
        private System.Windows.Forms.ToolTip toolTip;
    }
}
