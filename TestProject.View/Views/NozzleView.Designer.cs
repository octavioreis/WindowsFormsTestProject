namespace TestProject.View.Views
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
            this.components = new System.ComponentModel.Container();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblTank = new System.Windows.Forms.Label();
            this.cbTank = new System.Windows.Forms.ComboBox();
            this.btnGoToTank = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.nudSellingPrice = new System.Windows.Forms.NumericUpDown();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.tlpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSellingPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 3;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpMain.Controls.Add(this.lblPrice, 0, 1);
            this.tlpMain.Controls.Add(this.lblTank, 0, 2);
            this.tlpMain.Controls.Add(this.cbTank, 1, 2);
            this.tlpMain.Controls.Add(this.btnGoToTank, 2, 2);
            this.tlpMain.Controls.Add(this.lblName, 0, 0);
            this.tlpMain.Controls.Add(this.txtName, 1, 0);
            this.tlpMain.Controls.Add(this.btnSave, 2, 4);
            this.tlpMain.Controls.Add(this.nudSellingPrice, 1, 1);
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
            this.tlpMain.TabIndex = 1;
            // 
            // lblPrice
            // 
            this.lblPrice.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(12, 32);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(35, 13);
            this.lblPrice.TabIndex = 0;
            this.lblPrice.Text = "Preço";
            // 
            // lblTank
            // 
            this.lblTank.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTank.AutoSize = true;
            this.lblTank.Location = new System.Drawing.Point(3, 62);
            this.lblTank.Name = "lblTank";
            this.lblTank.Size = new System.Drawing.Size(44, 13);
            this.lblTank.TabIndex = 1;
            this.lblTank.Text = "Tanque";
            // 
            // cbTank
            // 
            this.cbTank.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbTank.FormattingEnabled = true;
            this.cbTank.Location = new System.Drawing.Point(53, 58);
            this.cbTank.Name = "cbTank";
            this.cbTank.Size = new System.Drawing.Size(206, 21);
            this.cbTank.TabIndex = 2;
            // 
            // btnGoToTank
            // 
            this.btnGoToTank.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnGoToTank.FlatAppearance.BorderSize = 0;
            this.btnGoToTank.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoToTank.Image = global::TestProject.View.Properties.Resources.next;
            this.btnGoToTank.Location = new System.Drawing.Point(265, 55);
            this.btnGoToTank.Name = "btnGoToTank";
            this.btnGoToTank.Size = new System.Drawing.Size(32, 28);
            this.btnGoToTank.TabIndex = 3;
            this.toolTip.SetToolTip(this.btnGoToTank, "Ir até tanque");
            this.btnGoToTank.UseVisualStyleBackColor = true;
            this.btnGoToTank.Click += new System.EventHandler(this.btnGoToTank_Click);
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 6);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Nome";
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(53, 3);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(206, 20);
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
            this.toolTip.SetToolTip(this.btnSave, "Salvar alterações no bico (Ctrl+S)");
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // nudSellingPrice
            // 
            this.nudSellingPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nudSellingPrice.DecimalPlaces = 2;
            this.nudSellingPrice.Location = new System.Drawing.Point(53, 29);
            this.nudSellingPrice.Name = "nudSellingPrice";
            this.nudSellingPrice.Size = new System.Drawing.Size(206, 20);
            this.nudSellingPrice.TabIndex = 6;
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
            ((System.ComponentModel.ISupportInitialize)(this.nudSellingPrice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblTank;
        private System.Windows.Forms.ComboBox cbTank;
        private System.Windows.Forms.Button btnGoToTank;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.NumericUpDown nudSellingPrice;
    }
}
