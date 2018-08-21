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
            this.rbNozzles = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
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
            this.tlpMenu.Controls.Add(this.rbNozzles, 0, 0);
            this.tlpMenu.Controls.Add(this.radioButton2, 1, 0);
            this.tlpMenu.Controls.Add(this.radioButton3, 2, 0);
            this.tlpMenu.Location = new System.Drawing.Point(226, 105);
            this.tlpMenu.Name = "tlpMenu";
            this.tlpMenu.RowCount = 1;
            this.tlpMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMenu.Size = new System.Drawing.Size(348, 46);
            this.tlpMenu.TabIndex = 0;
            // 
            // rbNozzles
            // 
            this.rbNozzles.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbNozzles.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNozzles.Location = new System.Drawing.Point(3, 3);
            this.rbNozzles.Name = "rbNozzles";
            this.rbNozzles.Size = new System.Drawing.Size(110, 40);
            this.rbNozzles.TabIndex = 6;
            this.rbNozzles.TabStop = true;
            this.rbNozzles.Text = "Bicos";
            this.rbNozzles.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbNozzles.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(119, 3);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(110, 40);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Tanques";
            this.radioButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.Location = new System.Drawing.Point(235, 3);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(110, 40);
            this.radioButton3.TabIndex = 8;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Combustíveis";
            this.radioButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton3.UseVisualStyleBackColor = true;
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
        private Views.ItemsView itemsView1;
        private System.Windows.Forms.RadioButton rbNozzles;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
    }
}