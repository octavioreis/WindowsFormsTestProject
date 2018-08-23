namespace TestProject.View
{
    partial class MainView
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.tlpMenu = new System.Windows.Forms.TableLayoutPanel();
            this.rbFuels = new System.Windows.Forms.RadioButton();
            this.rbTanks = new System.Windows.Forms.RadioButton();
            this.rbNozzles = new System.Windows.Forms.RadioButton();
            this.itemsView = new TestProject.View.Views.ItemsView();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.tlpMain.SuspendLayout();
            this.tlpMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.tlpMenu, 0, 1);
            this.tlpMain.Controls.Add(this.itemsView, 0, 2);
            this.tlpMain.Controls.Add(this.pbLogo, 0, 0);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 3;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Size = new System.Drawing.Size(784, 461);
            this.tlpMain.TabIndex = 0;
            // 
            // tlpMenu
            // 
            this.tlpMenu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tlpMenu.AutoSize = true;
            this.tlpMenu.ColumnCount = 3;
            this.tlpMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpMenu.Controls.Add(this.rbFuels, 0, 0);
            this.tlpMenu.Controls.Add(this.rbTanks, 1, 0);
            this.tlpMenu.Controls.Add(this.rbNozzles, 2, 0);
            this.tlpMenu.Location = new System.Drawing.Point(218, 104);
            this.tlpMenu.Name = "tlpMenu";
            this.tlpMenu.RowCount = 1;
            this.tlpMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMenu.Size = new System.Drawing.Size(348, 46);
            this.tlpMenu.TabIndex = 0;
            // 
            // rbFuels
            // 
            this.rbFuels.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbFuels.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFuels.Location = new System.Drawing.Point(3, 3);
            this.rbFuels.Name = "rbFuels";
            this.rbFuels.Size = new System.Drawing.Size(110, 40);
            this.rbFuels.TabIndex = 6;
            this.rbFuels.TabStop = true;
            this.rbFuels.Text = "Combustíveis";
            this.rbFuels.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbFuels.UseVisualStyleBackColor = true;
            this.rbFuels.CheckedChanged += new System.EventHandler(this.selectedTab_Changed);
            // 
            // rbTanks
            // 
            this.rbTanks.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbTanks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTanks.Location = new System.Drawing.Point(119, 3);
            this.rbTanks.Name = "rbTanks";
            this.rbTanks.Size = new System.Drawing.Size(110, 40);
            this.rbTanks.TabIndex = 7;
            this.rbTanks.TabStop = true;
            this.rbTanks.Text = "Tanques";
            this.rbTanks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbTanks.UseVisualStyleBackColor = true;
            this.rbTanks.CheckedChanged += new System.EventHandler(this.selectedTab_Changed);
            // 
            // rbNozzles
            // 
            this.rbNozzles.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbNozzles.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNozzles.Location = new System.Drawing.Point(235, 3);
            this.rbNozzles.Name = "rbNozzles";
            this.rbNozzles.Size = new System.Drawing.Size(110, 40);
            this.rbNozzles.TabIndex = 8;
            this.rbNozzles.TabStop = true;
            this.rbNozzles.Text = "Bicos";
            this.rbNozzles.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbNozzles.UseVisualStyleBackColor = true;
            this.rbNozzles.CheckedChanged += new System.EventHandler(this.selectedTab_Changed);
            // 
            // itemsView
            // 
            this.itemsView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemsView.Location = new System.Drawing.Point(3, 156);
            this.itemsView.Name = "itemsView";
            this.itemsView.Size = new System.Drawing.Size(778, 302);
            this.itemsView.TabIndex = 1;
            // 
            // pbLogo
            // 
            this.pbLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbLogo.Image = global::TestProject.View.Properties.Resources.logo;
            this.pbLogo.Location = new System.Drawing.Point(319, 3);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.pbLogo.Size = new System.Drawing.Size(146, 95);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbLogo.TabIndex = 2;
            this.pbLogo.TabStop = false;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.tlpMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "MainView";
            this.Text = "Databoff - Projeto teste";
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.tlpMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.TableLayoutPanel tlpMenu;
        private Views.ItemsView itemsView;
        private System.Windows.Forms.RadioButton rbNozzles;
        private System.Windows.Forms.RadioButton rbTanks;
        private System.Windows.Forms.RadioButton rbFuels;
        private System.Windows.Forms.PictureBox pbLogo;
    }
}