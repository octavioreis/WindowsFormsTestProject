﻿namespace TestProject.View.Views
{
    partial class TankView
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
            this.lblCapacity = new System.Windows.Forms.Label();
            this.lblFuel = new System.Windows.Forms.Label();
            this.cbFuel = new System.Windows.Forms.ComboBox();
            this.btnGoToFuel = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.nudCapacity = new System.Windows.Forms.NumericUpDown();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.tlpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCapacity)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 3;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpMain.Controls.Add(this.lblCapacity, 0, 1);
            this.tlpMain.Controls.Add(this.lblFuel, 0, 2);
            this.tlpMain.Controls.Add(this.cbFuel, 1, 2);
            this.tlpMain.Controls.Add(this.btnGoToFuel, 2, 2);
            this.tlpMain.Controls.Add(this.lblName, 0, 0);
            this.tlpMain.Controls.Add(this.txtName, 1, 0);
            this.tlpMain.Controls.Add(this.btnSave, 2, 4);
            this.tlpMain.Controls.Add(this.nudCapacity, 1, 1);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 5;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.Size = new System.Drawing.Size(300, 150);
            this.tlpMain.TabIndex = 0;
            // 
            // lblCapacity
            // 
            this.lblCapacity.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCapacity.AutoSize = true;
            this.lblCapacity.Location = new System.Drawing.Point(5, 32);
            this.lblCapacity.Name = "lblCapacity";
            this.lblCapacity.Size = new System.Drawing.Size(64, 13);
            this.lblCapacity.TabIndex = 0;
            this.lblCapacity.Text = "Capacidade";
            // 
            // lblFuel
            // 
            this.lblFuel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblFuel.AutoSize = true;
            this.lblFuel.Location = new System.Drawing.Point(3, 62);
            this.lblFuel.Name = "lblFuel";
            this.lblFuel.Size = new System.Drawing.Size(66, 13);
            this.lblFuel.TabIndex = 1;
            this.lblFuel.Text = "Combustível";
            // 
            // cbFuel
            // 
            this.cbFuel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbFuel.FormattingEnabled = true;
            this.cbFuel.Location = new System.Drawing.Point(75, 58);
            this.cbFuel.Name = "cbFuel";
            this.cbFuel.Size = new System.Drawing.Size(184, 21);
            this.cbFuel.TabIndex = 2;
            // 
            // btnGoToFuel
            // 
            this.btnGoToFuel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnGoToFuel.FlatAppearance.BorderSize = 0;
            this.btnGoToFuel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoToFuel.Image = global::TestProject.View.Properties.Resources.next;
            this.btnGoToFuel.Location = new System.Drawing.Point(265, 55);
            this.btnGoToFuel.Name = "btnGoToFuel";
            this.btnGoToFuel.Size = new System.Drawing.Size(32, 28);
            this.btnGoToFuel.TabIndex = 3;
            this.toolTip.SetToolTip(this.btnGoToFuel, "Ir até combustível");
            this.btnGoToFuel.UseVisualStyleBackColor = true;
            this.btnGoToFuel.Click += new System.EventHandler(this.btnGoToFuel_Click);
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(34, 6);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Nome";
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(75, 3);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(184, 20);
            this.txtName.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Image = global::TestProject.View.Properties.Resources.save_icon;
            this.btnSave.Location = new System.Drawing.Point(265, 115);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(32, 32);
            this.btnSave.TabIndex = 4;
            this.toolTip.SetToolTip(this.btnSave, "Salvar alterações no tanque (Ctrl+S)");
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // nudCapacity
            // 
            this.nudCapacity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nudCapacity.DecimalPlaces = 2;
            this.nudCapacity.Location = new System.Drawing.Point(75, 29);
            this.nudCapacity.Name = "nudCapacity";
            this.nudCapacity.Size = new System.Drawing.Size(184, 20);
            this.nudCapacity.TabIndex = 6;
            // 
            // TankView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpMain);
            this.Name = "TankView";
            this.Size = new System.Drawing.Size(300, 150);
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCapacity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.Label lblCapacity;
        private System.Windows.Forms.Label lblFuel;
        private System.Windows.Forms.ComboBox cbFuel;
        private System.Windows.Forms.Button btnGoToFuel;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.NumericUpDown nudCapacity;
    }
}
