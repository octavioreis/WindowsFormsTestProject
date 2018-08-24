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
            this.components = new System.ComponentModel.Container();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.tlpItemsList = new System.Windows.Forms.TableLayoutPanel();
            this.lbItems = new System.Windows.Forms.ListBox();
            this.tlpListOptions = new System.Windows.Forms.TableLayoutPanel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.registryHostView = new TestProject.View.Views.RegistryHostView();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
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
            this.tlpMain.Controls.Add(this.tlpItemsList, 0, 0);
            this.tlpMain.Controls.Add(this.registryHostView, 1, 0);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 1;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.Size = new System.Drawing.Size(598, 338);
            this.tlpMain.TabIndex = 0;
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
            this.tlpItemsList.Size = new System.Drawing.Size(154, 332);
            this.tlpItemsList.TabIndex = 3;
            // 
            // lbItems
            // 
            this.lbItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbItems.FormattingEnabled = true;
            this.lbItems.Location = new System.Drawing.Point(3, 3);
            this.lbItems.Name = "lbItems";
            this.lbItems.Size = new System.Drawing.Size(148, 282);
            this.lbItems.TabIndex = 0;
            this.lbItems.TabStop = false;
            this.lbItems.SelectedIndexChanged += new System.EventHandler(this.lbItems_SelectedIndexChanged);
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
            this.tlpListOptions.Location = new System.Drawing.Point(3, 291);
            this.tlpListOptions.Name = "tlpListOptions";
            this.tlpListOptions.RowCount = 1;
            this.tlpListOptions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpListOptions.Size = new System.Drawing.Size(148, 38);
            this.tlpListOptions.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Image = global::TestProject.View.Properties.Resources.add;
            this.btnAdd.Location = new System.Drawing.Point(3, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(32, 32);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.TabStop = false;
            this.toolTip.SetToolTip(this.btnAdd, "Adicionar");
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnRemove.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Image = global::TestProject.View.Properties.Resources.remove;
            this.btnRemove.Location = new System.Drawing.Point(113, 3);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(32, 32);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.TabStop = false;
            this.toolTip.SetToolTip(this.btnRemove, "Remover");
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // registryHostView
            // 
            this.registryHostView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.registryHostView.Location = new System.Drawing.Point(163, 3);
            this.registryHostView.Name = "registryHostView";
            this.registryHostView.Size = new System.Drawing.Size(432, 332);
            this.registryHostView.TabIndex = 4;
            // 
            // ItemsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpMain);
            this.Name = "ItemsView";
            this.Size = new System.Drawing.Size(598, 338);
            this.tlpMain.ResumeLayout(false);
            this.tlpItemsList.ResumeLayout(false);
            this.tlpItemsList.PerformLayout();
            this.tlpListOptions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.ListBox lbItems;
        private System.Windows.Forms.TableLayoutPanel tlpItemsList;
        private System.Windows.Forms.TableLayoutPanel tlpListOptions;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ToolTip toolTip;
        private RegistryHostView registryHostView;
    }
}
