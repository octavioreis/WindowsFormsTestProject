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
            this.tlpItemsList = new System.Windows.Forms.TableLayoutPanel();
            this.tlpListOptions = new System.Windows.Forms.TableLayoutPanel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.tlpMain.SuspendLayout();
            this.tlpItemsList.SuspendLayout();
            this.tlpListOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 2;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.83333F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.16667F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.Controls.Add(this.fuelView1, 1, 0);
            this.tlpMain.Controls.Add(this.nozzleView1, 1, 0);
            this.tlpMain.Controls.Add(this.tankView1, 1, 0);
            this.tlpMain.Controls.Add(this.tlpItemsList, 0, 0);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 1;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.Size = new System.Drawing.Size(718, 532);
            this.tlpMain.TabIndex = 0;
            // 
            // lbItems
            // 
            this.lbItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbItems.FormattingEnabled = true;
            this.lbItems.Location = new System.Drawing.Point(3, 3);
            this.lbItems.Name = "lbItems";
            this.lbItems.Size = new System.Drawing.Size(180, 465);
            this.lbItems.TabIndex = 0;
            this.lbItems.SelectedIndexChanged += new System.EventHandler(this.lbItems_SelectedIndexChanged);
            // 
            // fuelView1
            // 
            this.fuelView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fuelView1.FuelName = "";
            this.fuelView1.FuelType = TestProject.Model.Enums.FuelType.CommonGasoline;
            this.fuelView1.Location = new System.Drawing.Point(195, 3);
            this.fuelView1.Name = "fuelView1";
            this.fuelView1.Size = new System.Drawing.Size(520, 506);
            this.fuelView1.TabIndex = 0;
            this.fuelView1.Visible = false;
            // 
            // nozzleView1
            // 
            this.nozzleView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nozzleView1.Location = new System.Drawing.Point(195, 515);
            this.nozzleView1.Name = "nozzleView1";
            this.nozzleView1.NozzleName = "";
            this.nozzleView1.SellingPrice = "";
            this.nozzleView1.Size = new System.Drawing.Size(520, 14);
            this.nozzleView1.TabIndex = 1;
            this.nozzleView1.Tank = null;
            this.nozzleView1.Visible = false;
            // 
            // tankView1
            // 
            this.tankView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tankView1.Fuel = null;
            this.tankView1.Location = new System.Drawing.Point(3, 515);
            this.tankView1.Name = "tankView1";
            this.tankView1.Size = new System.Drawing.Size(186, 14);
            this.tankView1.StorageCapacity = 0f;
            this.tankView1.TabIndex = 2;
            this.tankView1.TankName = "";
            this.tankView1.Visible = false;
            // 
            // tlpItemsList
            // 
            this.tlpItemsList.ColumnCount = 1;
            this.tlpItemsList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpItemsList.Controls.Add(this.lbItems, 0, 0);
            this.tlpItemsList.Controls.Add(this.tlpListOptions, 0, 1);
            this.tlpItemsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpItemsList.Location = new System.Drawing.Point(3, 3);
            this.tlpItemsList.Name = "tlpItemsList";
            this.tlpItemsList.RowCount = 2;
            this.tlpItemsList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpItemsList.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpItemsList.Size = new System.Drawing.Size(186, 506);
            this.tlpItemsList.TabIndex = 3;
            // 
            // tlpListOptions
            // 
            this.tlpListOptions.AutoSize = true;
            this.tlpListOptions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpListOptions.ColumnCount = 3;
            this.tlpListOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpListOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpListOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpListOptions.Controls.Add(this.btnAdd, 0, 0);
            this.tlpListOptions.Controls.Add(this.btnRemove, 2, 0);
            this.tlpListOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpListOptions.Location = new System.Drawing.Point(3, 474);
            this.tlpListOptions.Name = "tlpListOptions";
            this.tlpListOptions.RowCount = 1;
            this.tlpListOptions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpListOptions.Size = new System.Drawing.Size(180, 29);
            this.tlpListOptions.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAdd.Location = new System.Drawing.Point(3, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnRemove.Location = new System.Drawing.Point(102, 3);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "Remover";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // ItemsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpMain);
            this.Name = "ItemsView";
            this.Size = new System.Drawing.Size(718, 532);
            this.tlpMain.ResumeLayout(false);
            this.tlpItemsList.ResumeLayout(false);
            this.tlpItemsList.PerformLayout();
            this.tlpListOptions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.ListBox lbItems;
        private FuelView fuelView1;
        private NozzleView nozzleView1;
        private TankView tankView1;
        private System.Windows.Forms.TableLayoutPanel tlpItemsList;
        private System.Windows.Forms.TableLayoutPanel tlpListOptions;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
    }
}
