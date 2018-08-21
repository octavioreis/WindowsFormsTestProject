﻿namespace TestProject.View.Views
{
    partial class NozzleView
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
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblTank = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.cbTank = new System.Windows.Forms.ComboBox();
            this.btnGoToTank = new System.Windows.Forms.Button();
            this.tlpMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 3;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpMain.Controls.Add(this.lblPrice, 0, 0);
            this.tlpMain.Controls.Add(this.lblTank, 0, 1);
            this.tlpMain.Controls.Add(this.txtPrice, 1, 0);
            this.tlpMain.Controls.Add(this.cbTank, 1, 1);
            this.tlpMain.Controls.Add(this.btnGoToTank, 2, 1);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 3;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Size = new System.Drawing.Size(300, 150);
            this.tlpMain.TabIndex = 1;
            // 
            // lblPrice
            // 
            this.lblPrice.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(12, 6);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(35, 13);
            this.lblPrice.TabIndex = 0;
            this.lblPrice.Text = "Preço";
            // 
            // lblTank
            // 
            this.lblTank.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTank.AutoSize = true;
            this.lblTank.Location = new System.Drawing.Point(3, 36);
            this.lblTank.Name = "lblTank";
            this.lblTank.Size = new System.Drawing.Size(44, 13);
            this.lblTank.TabIndex = 1;
            this.lblTank.Text = "Tanque";
            // 
            // txtPrice
            // 
            this.txtPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrice.Location = new System.Drawing.Point(53, 3);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(206, 20);
            this.txtPrice.TabIndex = 2;
            // 
            // cbTank
            // 
            this.cbTank.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbTank.FormattingEnabled = true;
            this.cbTank.Location = new System.Drawing.Point(53, 32);
            this.cbTank.Name = "cbTank";
            this.cbTank.Size = new System.Drawing.Size(206, 21);
            this.cbTank.TabIndex = 3;
            // 
            // btnGoToTank
            // 
            this.btnGoToTank.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnGoToTank.Image = global::TestProject.View.Properties.Resources.next;
            this.btnGoToTank.Location = new System.Drawing.Point(265, 29);
            this.btnGoToTank.Name = "btnGoToTank";
            this.btnGoToTank.Size = new System.Drawing.Size(32, 28);
            this.btnGoToTank.TabIndex = 4;
            this.btnGoToTank.UseVisualStyleBackColor = true;
            // 
            // NozzleView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpMain);
            this.Name = "NozzleView";
            this.Size = new System.Drawing.Size(300, 150);
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblTank;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.ComboBox cbTank;
        private System.Windows.Forms.Button btnGoToTank;
    }
}