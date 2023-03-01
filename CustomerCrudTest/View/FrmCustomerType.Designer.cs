namespace CustomerCrudTest.View
{
    partial class FrmCustomerType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCustomerType));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpInquiry = new System.Windows.Forms.TabPage();
            this.btnSearch = new System.Windows.Forms.Button();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.dgShowData = new System.Windows.Forms.DataGridView();
            this.tpMaintenance = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textCustomerTypeId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsNew = new System.Windows.Forms.ToolStripButton();
            this.tsSave = new System.Windows.Forms.ToolStripButton();
            this.tsClear = new System.Windows.Forms.ToolStripButton();
            this.tsDelete = new System.Windows.Forms.ToolStripButton();
            this.tabControl1.SuspendLayout();
            this.tpInquiry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgShowData)).BeginInit();
            this.tpMaintenance.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpInquiry);
            this.tabControl1.Controls.Add(this.tpMaintenance);
            this.tabControl1.Location = new System.Drawing.Point(12, 41);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(414, 276);
            this.tabControl1.TabIndex = 0;
            // 
            // tpInquiry
            // 
            this.tpInquiry.Controls.Add(this.btnSearch);
            this.tpInquiry.Controls.Add(this.textSearch);
            this.tpInquiry.Controls.Add(this.cbFilter);
            this.tpInquiry.Controls.Add(this.dgShowData);
            this.tpInquiry.Location = new System.Drawing.Point(4, 24);
            this.tpInquiry.Margin = new System.Windows.Forms.Padding(2);
            this.tpInquiry.Name = "tpInquiry";
            this.tpInquiry.Padding = new System.Windows.Forms.Padding(2);
            this.tpInquiry.Size = new System.Drawing.Size(406, 248);
            this.tpInquiry.TabIndex = 1;
            this.tpInquiry.Text = "Consulta";
            this.tpInquiry.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(295, 16);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(97, 32);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // textSearch
            // 
            this.textSearch.Location = new System.Drawing.Point(153, 17);
            this.textSearch.Margin = new System.Windows.Forms.Padding(2);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(131, 23);
            this.textSearch.TabIndex = 2;
            this.textSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textSearch_KeyPress);
            // 
            // cbFilter
            // 
            this.cbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Items.AddRange(new object[] {
            "Todos",
            "Id cliente"});
            this.cbFilter.Location = new System.Drawing.Point(7, 16);
            this.cbFilter.Margin = new System.Windows.Forms.Padding(2);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(131, 23);
            this.cbFilter.TabIndex = 1;
            // 
            // dgShowData
            // 
            this.dgShowData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgShowData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgShowData.Location = new System.Drawing.Point(5, 63);
            this.dgShowData.Margin = new System.Windows.Forms.Padding(2);
            this.dgShowData.Name = "dgShowData";
            this.dgShowData.ReadOnly = true;
            this.dgShowData.RowHeadersWidth = 62;
            this.dgShowData.RowTemplate.Height = 28;
            this.dgShowData.Size = new System.Drawing.Size(387, 172);
            this.dgShowData.TabIndex = 0;
            this.dgShowData.DoubleClick += new System.EventHandler(this.dgShowData_DoubleClick);
            // 
            // tpMaintenance
            // 
            this.tpMaintenance.Controls.Add(this.groupBox1);
            this.tpMaintenance.Location = new System.Drawing.Point(4, 24);
            this.tpMaintenance.Margin = new System.Windows.Forms.Padding(2);
            this.tpMaintenance.Name = "tpMaintenance";
            this.tpMaintenance.Padding = new System.Windows.Forms.Padding(2);
            this.tpMaintenance.Size = new System.Drawing.Size(406, 248);
            this.tpMaintenance.TabIndex = 0;
            this.tpMaintenance.Text = "Mantenimiento";
            this.tpMaintenance.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textDescription);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textCustomerTypeId);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(43, 30);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(300, 167);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // textDescription
            // 
            this.textDescription.Location = new System.Drawing.Point(129, 62);
            this.textDescription.Margin = new System.Windows.Forms.Padding(2);
            this.textDescription.Name = "textDescription";
            this.textDescription.Size = new System.Drawing.Size(147, 23);
            this.textDescription.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id. tipo cliente";
            // 
            // textCustomerTypeId
            // 
            this.textCustomerTypeId.Location = new System.Drawing.Point(129, 33);
            this.textCustomerTypeId.Margin = new System.Windows.Forms.Padding(2);
            this.textCustomerTypeId.Name = "textCustomerTypeId";
            this.textCustomerTypeId.ReadOnly = true;
            this.textCustomerTypeId.Size = new System.Drawing.Size(147, 23);
            this.textCustomerTypeId.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripción";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsNew,
            this.tsSave,
            this.tsClear,
            this.tsDelete});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(441, 31);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // tsNew
            // 
            this.tsNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsNew.Image = ((System.Drawing.Image)(resources.GetObject("tsNew.Image")));
            this.tsNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsNew.Name = "tsNew";
            this.tsNew.Size = new System.Drawing.Size(28, 28);
            this.tsNew.Text = "Nuevo";
            this.tsNew.Click += new System.EventHandler(this.tsNew_Click);
            // 
            // tsSave
            // 
            this.tsSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsSave.Image = ((System.Drawing.Image)(resources.GetObject("tsSave.Image")));
            this.tsSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsSave.Name = "tsSave";
            this.tsSave.Size = new System.Drawing.Size(28, 28);
            this.tsSave.Text = "&Guardar";
            this.tsSave.Click += new System.EventHandler(this.tsSave_Click);
            // 
            // tsClear
            // 
            this.tsClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsClear.Image = ((System.Drawing.Image)(resources.GetObject("tsClear.Image")));
            this.tsClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsClear.Name = "tsClear";
            this.tsClear.Size = new System.Drawing.Size(28, 28);
            this.tsClear.Text = "Limpiar";
            this.tsClear.Click += new System.EventHandler(this.tsClear_Click);
            // 
            // tsDelete
            // 
            this.tsDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsDelete.Image")));
            this.tsDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsDelete.Name = "tsDelete";
            this.tsDelete.Size = new System.Drawing.Size(28, 28);
            this.tsDelete.Text = "Eliminar";
            this.tsDelete.Click += new System.EventHandler(this.tsDelete_Click);
            // 
            // FrmCustomerType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 322);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmCustomerType";
            this.Text = "Mantenimiento tipo de cliente";
            this.Load += new System.EventHandler(this.FrmCustomerType_Load);
            this.tabControl1.ResumeLayout(false);
            this.tpInquiry.ResumeLayout(false);
            this.tpInquiry.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgShowData)).EndInit();
            this.tpMaintenance.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpInquiry;
        private System.Windows.Forms.DataGridView dgShowData;
        private System.Windows.Forms.TabPage tpMaintenance;
        private System.Windows.Forms.TextBox textDescription;
        private System.Windows.Forms.TextBox textCustomerTypeId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsNew;
        private System.Windows.Forms.ToolStripButton tsSave;
        private System.Windows.Forms.ToolStripButton tsClear;
        private System.Windows.Forms.ToolStripButton tsDelete;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}