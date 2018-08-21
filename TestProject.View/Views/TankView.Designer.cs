namespace TestProject.View.Views
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
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.lblCapacity = new System.Windows.Forms.Label();
            this.lblFuel = new System.Windows.Forms.Label();
            this.txtCapacity = new System.Windows.Forms.TextBox();
            this.cbFuel = new System.Windows.Forms.ComboBox();
            this.btnGoToFuel = new System.Windows.Forms.Button();
            this.tlpMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 3;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpMain.Controls.Add(this.lblCapacity, 0, 0);
            this.tlpMain.Controls.Add(this.lblFuel, 0, 1);
            this.tlpMain.Controls.Add(this.txtCapacity, 1, 0);
            this.tlpMain.Controls.Add(this.cbFuel, 1, 1);
            this.tlpMain.Controls.Add(this.btnGoToFuel, 2, 1);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 3;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Size = new System.Drawing.Size(300, 150);
            this.tlpMain.TabIndex = 0;
            // 
            // lblCapacity
            // 
            this.lblCapacity.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCapacity.AutoSize = true;
            this.lblCapacity.Location = new System.Drawing.Point(5, 6);
            this.lblCapacity.Name = "lblCapacity";
            this.lblCapacity.Size = new System.Drawing.Size(64, 13);
            this.lblCapacity.TabIndex = 0;
            this.lblCapacity.Text = "Capacidade";
            // 
            // lblFuel
            // 
            this.lblFuel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblFuel.AutoSize = true;
            this.lblFuel.Location = new System.Drawing.Point(3, 36);
            this.lblFuel.Name = "lblFuel";
            this.lblFuel.Size = new System.Drawing.Size(66, 13);
            this.lblFuel.TabIndex = 1;
            this.lblFuel.Text = "Combustível";
            // 
            // txtCapacity
            // 
            this.txtCapacity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCapacity.Location = new System.Drawing.Point(75, 3);
            this.txtCapacity.Name = "txtCapacity";
            this.txtCapacity.Size = new System.Drawing.Size(184, 20);
            this.txtCapacity.TabIndex = 2;
            // 
            // cbFuel
            // 
            this.cbFuel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbFuel.FormattingEnabled = true;
            this.cbFuel.Location = new System.Drawing.Point(75, 32);
            this.cbFuel.Name = "cbFuel";
            this.cbFuel.Size = new System.Drawing.Size(184, 21);
            this.cbFuel.TabIndex = 3;
            // 
            // btnGoToFuel
            // 
            this.btnGoToFuel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnGoToFuel.Image = global::TestProject.View.Properties.Resources.next;
            this.btnGoToFuel.Location = new System.Drawing.Point(265, 29);
            this.btnGoToFuel.Name = "btnGoToFuel";
            this.btnGoToFuel.Size = new System.Drawing.Size(32, 28);
            this.btnGoToFuel.TabIndex = 4;
            this.btnGoToFuel.UseVisualStyleBackColor = true;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.Label lblCapacity;
        private System.Windows.Forms.Label lblFuel;
        private System.Windows.Forms.TextBox txtCapacity;
        private System.Windows.Forms.ComboBox cbFuel;
        private System.Windows.Forms.Button btnGoToFuel;
    }
}
