namespace PowerBIOptionSetValueToTextConverter
{
    partial class MyPluginControl
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyPluginControl));
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.tsbClose = new System.Windows.Forms.ToolStripButton();
            this.tssSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbSample = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.dgvallentites = new System.Windows.Forms.DataGridView();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.LogicalName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ObjectTypeCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.dgvoptiosetfildes = new System.Windows.Forms.DataGridView();
            this.FiledName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtresult = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.toolStripMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvallentites)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvoptiosetfildes)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbClose,
            this.tssSeparator1,
            this.tsbSample,
            this.toolStripButton1,
            this.toolStripComboBox1});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Size = new System.Drawing.Size(1447, 25);
            this.toolStripMenu.TabIndex = 4;
            this.toolStripMenu.Text = "toolStrip1";
            // 
            // tsbClose
            // 
            this.tsbClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbClose.Name = "tsbClose";
            this.tsbClose.Size = new System.Drawing.Size(86, 22);
            this.tsbClose.Text = "Close this tool";
            this.tsbClose.Click += new System.EventHandler(this.tsbClose_Click);
            // 
            // tssSeparator1
            // 
            this.tssSeparator1.Name = "tssSeparator1";
            this.tssSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbSample
            // 
            this.tsbSample.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbSample.Name = "tsbSample";
            this.tsbSample.Size = new System.Drawing.Size(82, 22);
            this.tsbSample.Text = "Load Entittes ";
            this.tsbSample.Click += new System.EventHandler(this.tsbSample_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(155, 22);
            this.toolStripButton1.Text = "Generate Power BI function";
            this.toolStripButton1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // dgvallentites
            // 
            this.dgvallentites.AllowUserToAddRows = false;
            this.dgvallentites.AllowUserToDeleteRows = false;
            this.dgvallentites.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvallentites.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvallentites.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvallentites.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgvallentites.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.dgvallentites.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvallentites.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LogicalName,
            this.ObjectTypeCode});
            this.dgvallentites.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvallentites.Location = new System.Drawing.Point(3, 16);
            this.dgvallentites.MultiSelect = false;
            this.dgvallentites.Name = "dgvallentites";
            this.dgvallentites.ReadOnly = true;
            this.dgvallentites.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvallentites.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvallentites.Size = new System.Drawing.Size(470, 630);
            this.dgvallentites.TabIndex = 5;
            this.dgvallentites.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvallentites_CellClick);
            this.dgvallentites.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(3, 28);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(190, 23);
            this.progressBar1.TabIndex = 13;
            // 
            // LogicalName
            // 
            this.LogicalName.FillWeight = 150F;
            this.LogicalName.HeaderText = "Logical Name";
            this.LogicalName.Name = "LogicalName";
            this.LogicalName.ReadOnly = true;
            // 
            // ObjectTypeCode
            // 
            this.ObjectTypeCode.HeaderText = "ObjectTypeCode";
            this.ObjectTypeCode.Name = "ObjectTypeCode";
            this.ObjectTypeCode.ReadOnly = true;
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(250, 25);
            // 
            // dgvoptiosetfildes
            // 
            this.dgvoptiosetfildes.AllowUserToAddRows = false;
            this.dgvoptiosetfildes.AllowUserToDeleteRows = false;
            this.dgvoptiosetfildes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvoptiosetfildes.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvoptiosetfildes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvoptiosetfildes.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgvoptiosetfildes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvoptiosetfildes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvoptiosetfildes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FiledName});
            this.dgvoptiosetfildes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvoptiosetfildes.Location = new System.Drawing.Point(3, 16);
            this.dgvoptiosetfildes.MultiSelect = false;
            this.dgvoptiosetfildes.Name = "dgvoptiosetfildes";
            this.dgvoptiosetfildes.ReadOnly = true;
            this.dgvoptiosetfildes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvoptiosetfildes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvoptiosetfildes.Size = new System.Drawing.Size(470, 630);
            this.dgvoptiosetfildes.TabIndex = 10;
            this.dgvoptiosetfildes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvoptiosetfildes_CellClick);
            this.dgvoptiosetfildes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvoptiosetfildes_CellContentClick);
            // 
            // FiledName
            // 
            this.FiledName.FillWeight = 400F;
            this.FiledName.HeaderText = "Filed Name";
            this.FiledName.Name = "FiledName";
            this.FiledName.ReadOnly = true;
            // 
            // txtresult
            // 
            this.txtresult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtresult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtresult.Location = new System.Drawing.Point(3, 16);
            this.txtresult.Name = "txtresult";
            this.txtresult.Size = new System.Drawing.Size(471, 630);
            this.txtresult.TabIndex = 12;
            this.txtresult.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvallentites);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(476, 649);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "All Entites";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dgvoptiosetfildes);
            this.groupBox2.Location = new System.Drawing.Point(485, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(476, 649);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Option Set Fileds";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox3.Controls.Add(this.txtresult);
            this.groupBox3.Location = new System.Drawing.Point(967, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(477, 649);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Power BI Query ";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 25);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1447, 655);
            this.tableLayoutPanel1.TabIndex = 18;
            // 
            // MyPluginControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.toolStripMenu);
            this.Name = "MyPluginControl";
            this.PluginIcon = ((System.Drawing.Icon)(resources.GetObject("$this.PluginIcon")));
            this.Size = new System.Drawing.Size(1447, 680);
            this.Load += new System.EventHandler(this.MyPluginControl_Load);
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvallentites)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvoptiosetfildes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripButton tsbClose;
        private System.Windows.Forms.ToolStripButton tsbSample;
        private System.Windows.Forms.ToolStripSeparator tssSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.DataGridView dgvallentites;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.DataGridViewTextBoxColumn LogicalName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ObjectTypeCode;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.DataGridView dgvoptiosetfildes;
        private System.Windows.Forms.DataGridViewTextBoxColumn FiledName;
        private System.Windows.Forms.RichTextBox txtresult;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
