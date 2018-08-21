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
            this.cbFuels = new System.Windows.Forms.CheckBox();
            this.cbTanks = new System.Windows.Forms.CheckBox();
            this.cbNozzles = new System.Windows.Forms.CheckBox();
            this.tlpMain.SuspendLayout();
            this.tlpMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.tlpMenu, 0, 1);
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
            this.tlpMenu.Controls.Add(this.cbFuels, 2, 0);
            this.tlpMenu.Controls.Add(this.cbTanks, 1, 0);
            this.tlpMenu.Controls.Add(this.cbNozzles, 0, 0);
            this.tlpMenu.Location = new System.Drawing.Point(226, 105);
            this.tlpMenu.Name = "tlpMenu";
            this.tlpMenu.RowCount = 1;
            this.tlpMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMenu.Size = new System.Drawing.Size(348, 46);
            this.tlpMenu.TabIndex = 0;
            // 
            // cbFuels
            // 
            this.cbFuels.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbFuels.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkGray;
            this.cbFuels.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbFuels.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFuels.Location = new System.Drawing.Point(235, 3);
            this.cbFuels.Name = "cbFuels";
            this.cbFuels.Size = new System.Drawing.Size(110, 40);
            this.cbFuels.TabIndex = 3;
            this.cbFuels.Text = "Combustíveis";
            this.cbFuels.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbFuels.UseVisualStyleBackColor = true;
            // 
            // cbTanks
            // 
            this.cbTanks.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbTanks.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkGray;
            this.cbTanks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbTanks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTanks.Location = new System.Drawing.Point(119, 3);
            this.cbTanks.Name = "cbTanks";
            this.cbTanks.Size = new System.Drawing.Size(110, 40);
            this.cbTanks.TabIndex = 4;
            this.cbTanks.Text = "Tanques";
            this.cbTanks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbTanks.UseVisualStyleBackColor = true;
            // 
            // cbNozzles
            // 
            this.cbNozzles.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbNozzles.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkGray;
            this.cbNozzles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbNozzles.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNozzles.Location = new System.Drawing.Point(3, 3);
            this.cbNozzles.Name = "cbNozzles";
            this.cbNozzles.Size = new System.Drawing.Size(110, 40);
            this.cbNozzles.TabIndex = 5;
            this.cbNozzles.Text = "Bicos";
            this.cbNozzles.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbNozzles.UseVisualStyleBackColor = true;
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
        private System.Windows.Forms.CheckBox cbFuels;
        private System.Windows.Forms.CheckBox cbTanks;
        private System.Windows.Forms.CheckBox cbNozzles;
    }
}