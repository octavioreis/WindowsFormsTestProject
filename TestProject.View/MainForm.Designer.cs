namespace TestProject.View
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.tlpMenu = new System.Windows.Forms.TableLayoutPanel();
            this.chkFuels = new System.Windows.Forms.CheckBox();
            this.chkTanks = new System.Windows.Forms.CheckBox();
            this.chkNozzles = new System.Windows.Forms.CheckBox();
            this.itemsView1 = new TestProject.View.Views.ItemsView();
            this.tlpMain.SuspendLayout();
            this.tlpMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.tlpMenu, 0, 1);
            this.tlpMain.Controls.Add(this.itemsView1, 0, 2);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 3;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.64102F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 74.35898F));
            this.tlpMain.Size = new System.Drawing.Size(800, 450);
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
            this.tlpMenu.Controls.Add(this.chkFuels, 2, 0);
            this.tlpMenu.Controls.Add(this.chkTanks, 1, 0);
            this.tlpMenu.Controls.Add(this.chkNozzles, 0, 0);
            this.tlpMenu.Location = new System.Drawing.Point(226, 105);
            this.tlpMenu.Name = "tlpMenu";
            this.tlpMenu.RowCount = 1;
            this.tlpMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMenu.Size = new System.Drawing.Size(348, 46);
            this.tlpMenu.TabIndex = 0;
            // 
            // chkFuels
            // 
            this.chkFuels.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkFuels.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkGray;
            this.chkFuels.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkFuels.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFuels.Location = new System.Drawing.Point(235, 3);
            this.chkFuels.Name = "chkFuels";
            this.chkFuels.Size = new System.Drawing.Size(110, 40);
            this.chkFuels.TabIndex = 3;
            this.chkFuels.Text = "Combustíveis";
            this.chkFuels.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkFuels.UseVisualStyleBackColor = true;
            // 
            // chkTanks
            // 
            this.chkTanks.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkTanks.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkGray;
            this.chkTanks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkTanks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTanks.Location = new System.Drawing.Point(119, 3);
            this.chkTanks.Name = "chkTanks";
            this.chkTanks.Size = new System.Drawing.Size(110, 40);
            this.chkTanks.TabIndex = 4;
            this.chkTanks.Text = "Tanques";
            this.chkTanks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkTanks.UseVisualStyleBackColor = true;
            // 
            // chkNozzles
            // 
            this.chkNozzles.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkNozzles.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkGray;
            this.chkNozzles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkNozzles.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNozzles.Location = new System.Drawing.Point(3, 3);
            this.chkNozzles.Name = "chkNozzles";
            this.chkNozzles.Size = new System.Drawing.Size(110, 40);
            this.chkNozzles.TabIndex = 5;
            this.chkNozzles.Text = "Bicos";
            this.chkNozzles.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkNozzles.UseVisualStyleBackColor = true;
            // 
            // itemsView1
            // 
            this.itemsView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemsView1.Location = new System.Drawing.Point(3, 157);
            this.itemsView1.Name = "itemsView1";
            this.itemsView1.Size = new System.Drawing.Size(794, 290);
            this.itemsView1.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tlpMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Databoff - Projeto teste";
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.tlpMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.TableLayoutPanel tlpMenu;
        private System.Windows.Forms.CheckBox chkFuels;
        private System.Windows.Forms.CheckBox chkTanks;
        private System.Windows.Forms.CheckBox chkNozzles;
        private Views.ItemsView itemsView1;
    }
}