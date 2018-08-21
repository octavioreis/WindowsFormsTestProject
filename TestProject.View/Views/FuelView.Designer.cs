namespace TestProject.View.Views
{
    partial class FuelView
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
            this.lbFuels = new System.Windows.Forms.ListBox();
            this.tlpRegister = new System.Windows.Forms.TableLayoutPanel();
            this.lblName = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tlpMain.SuspendLayout();
            this.tlpRegister.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 2;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tlpMain.Controls.Add(this.lbFuels, 0, 0);
            this.tlpMain.Controls.Add(this.tlpRegister, 1, 0);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 1;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Size = new System.Drawing.Size(590, 274);
            this.tlpMain.TabIndex = 0;
            // 
            // lbFuels
            // 
            this.lbFuels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbFuels.FormattingEnabled = true;
            this.lbFuels.Location = new System.Drawing.Point(3, 3);
            this.lbFuels.Name = "lbFuels";
            this.lbFuels.Size = new System.Drawing.Size(171, 268);
            this.lbFuels.TabIndex = 0;
            // 
            // tlpRegister
            // 
            this.tlpRegister.ColumnCount = 2;
            this.tlpRegister.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpRegister.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpRegister.Controls.Add(this.lblName, 0, 0);
            this.tlpRegister.Controls.Add(this.lblType, 0, 1);
            this.tlpRegister.Controls.Add(this.textBox1, 1, 0);
            this.tlpRegister.Controls.Add(this.comboBox1, 1, 1);
            this.tlpRegister.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpRegister.Location = new System.Drawing.Point(180, 3);
            this.tlpRegister.Name = "tlpRegister";
            this.tlpRegister.RowCount = 3;
            this.tlpRegister.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpRegister.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpRegister.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpRegister.Size = new System.Drawing.Size(407, 268);
            this.tlpRegister.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(3, 6);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Nome";
            // 
            // lblType
            // 
            this.lblType.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(10, 33);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(28, 13);
            this.lblType.TabIndex = 1;
            this.lblType.Text = "Tipo";
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(44, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(360, 20);
            this.textBox1.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(44, 29);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(360, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // FuelView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpMain);
            this.Name = "FuelView";
            this.Size = new System.Drawing.Size(590, 274);
            this.tlpMain.ResumeLayout(false);
            this.tlpRegister.ResumeLayout(false);
            this.tlpRegister.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.ListBox lbFuels;
        private System.Windows.Forms.TableLayoutPanel tlpRegister;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
