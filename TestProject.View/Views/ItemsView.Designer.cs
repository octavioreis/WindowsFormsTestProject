namespace TestProject.View.Views
{
    partial class ItemsView
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
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.lbItems = new System.Windows.Forms.ListBox();
            this.fuelView1 = new TestProject.View.Views.FuelView();
            this.nozzleView1 = new TestProject.View.Views.NozzleView();
            this.tankView1 = new TestProject.View.Views.TankView();
            this.tlpMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 2;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.83333F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.16666F));
            this.tlpMain.Controls.Add(this.lbItems, 0, 0);
            this.tlpMain.Controls.Add(this.fuelView1, 1, 0);
            this.tlpMain.Controls.Add(this.nozzleView1, 1, 0);
            this.tlpMain.Controls.Add(this.tankView1, 1, 0);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 1;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.Size = new System.Drawing.Size(718, 532);
            this.tlpMain.TabIndex = 0;
            // 
            // lbItems
            // 
            this.lbItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbItems.FormattingEnabled = true;
            this.lbItems.Location = new System.Drawing.Point(3, 3);
            this.lbItems.Name = "lbItems";
            this.lbItems.Size = new System.Drawing.Size(186, 526);
            this.lbItems.TabIndex = 0;
            this.lbItems.SelectedIndexChanged += new System.EventHandler(this.lbItems_SelectedIndexChanged);
            // 
            // fuelView1
            // 
            this.fuelView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fuelView1.FuelName = "";
            this.fuelView1.Location = new System.Drawing.Point(3, 3);
            this.fuelView1.Name = "fuelView1";
            this.fuelView1.Size = new System.Drawing.Size(514, 150);
            this.fuelView1.TabIndex = 0;
            this.fuelView1.Visible = false;
            // 
            // nozzleView1
            // 
            this.nozzleView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nozzleView1.Location = new System.Drawing.Point(3, 315);
            this.nozzleView1.Name = "nozzleView1";
            this.nozzleView1.NozzleName = "";
            this.nozzleView1.SellingPrice = "";
            this.nozzleView1.Size = new System.Drawing.Size(514, 208);
            this.nozzleView1.TabIndex = 1;
            this.nozzleView1.Tank = null;
            this.nozzleView1.Visible = false;
            // 
            // tankView1
            // 
            this.tankView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tankView1.Fuel = null;
            this.tankView1.Location = new System.Drawing.Point(3, 159);
            this.tankView1.Name = "tankView1";
            this.tankView1.Size = new System.Drawing.Size(514, 150);
            this.tankView1.StorageCapacity = "";
            this.tankView1.TabIndex = 2;
            this.tankView1.TankName = "";
            this.tankView1.Visible = false;
            // 
            // ItemsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpMain);
            this.Name = "ItemsView";
            this.Size = new System.Drawing.Size(718, 532);
            this.tlpMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.ListBox lbItems;
        private FuelView fuelView1;
        private NozzleView nozzleView1;
        private TankView tankView1;
    }
}
