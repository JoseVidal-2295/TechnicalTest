using System.Windows.Forms;

namespace CustomerCrudTest.View
{
    partial class FrmCustomerMaintenance
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCustomerMaintenance));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsNew = new System.Windows.Forms.ToolStripButton();
            this.tsSave = new System.Windows.Forms.ToolStripButton();
            this.tsClear = new System.Windows.Forms.ToolStripButton();
            this.tsDelete = new System.Windows.Forms.ToolStripButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpInquiry = new System.Windows.Forms.TabPage();
            this.btnSearch = new System.Windows.Forms.Button();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.dgShowData = new System.Windows.Forms.DataGridView();
            this.tpMaintenance = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.cbCustomerType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textAddres = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textCustomerName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textCustomerId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tpInquiry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgShowData)).BeginInit();
            this.tpMaintenance.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            this.toolStrip1.Size = new System.Drawing.Size(536, 31);
            this.toolStrip1.TabIndex = 2;
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
            this.tsSave.Text = "Guardar";
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpInquiry);
            this.tabControl1.Controls.Add(this.tpMaintenance);
            this.tabControl1.Location = new System.Drawing.Point(17, 41);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(495, 297);
            this.tabControl1.TabIndex = 3;
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
            this.tpInquiry.Size = new System.Drawing.Size(487, 269);
            this.tpInquiry.TabIndex = 1;
            this.tpInquiry.Text = "Consulta";
            this.tpInquiry.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(348, 13);
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
            this.textSearch.Size = new System.Drawing.Size(173, 23);
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
            this.dgShowData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgShowData.Location = new System.Drawing.Point(5, 58);
            this.dgShowData.Margin = new System.Windows.Forms.Padding(2);
            this.dgShowData.Name = "dgShowData";
            this.dgShowData.ReadOnly = true;
            this.dgShowData.RowHeadersWidth = 62;
            this.dgShowData.RowTemplate.Height = 28;
            this.dgShowData.Size = new System.Drawing.Size(469, 200);
            this.dgShowData.TabIndex = 0;
            this.dgShowData.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgShowData_CellDoubleClick);
            this.dgShowData.DoubleClick += new System.EventHandler(this.dgShowData_DoubleClick);
            // 
            // tpMaintenance
            // 
            this.tpMaintenance.Controls.Add(this.groupBox1);
            this.tpMaintenance.Location = new System.Drawing.Point(4, 24);
            this.tpMaintenance.Margin = new System.Windows.Forms.Padding(2);
            this.tpMaintenance.Name = "tpMaintenance";
            this.tpMaintenance.Padding = new System.Windows.Forms.Padding(2);
            this.tpMaintenance.Size = new System.Drawing.Size(487, 269);
            this.tpMaintenance.TabIndex = 0;
            this.tpMaintenance.Text = "Mantenimiento";
            this.tpMaintenance.UseVisualStyleBackColor = true;
            this.tpMaintenance.Click += new System.EventHandler(this.tpMaintenance_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbStatus);
            this.groupBox1.Controls.Add(this.cbCustomerType);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textAddres);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textCustomerName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textCustomerId);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(78, 26);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(300, 188);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // cbStatus
            // 
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cbStatus.Location = new System.Drawing.Point(129, 139);
            this.cbStatus.Margin = new System.Windows.Forms.Padding(2);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(147, 23);
            this.cbStatus.TabIndex = 11;
            // 
            // cbCustomerType
            // 
            this.cbCustomerType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCustomerType.FormattingEnabled = true;
            this.cbCustomerType.Location = new System.Drawing.Point(129, 113);
            this.cbCustomerType.Margin = new System.Windows.Forms.Padding(2);
            this.cbCustomerType.Name = "cbCustomerType";
            this.cbCustomerType.Size = new System.Drawing.Size(147, 23);
            this.cbCustomerType.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 139);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Estatus";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 114);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tipo de cliente";
            // 
            // textAddres
            // 
            this.textAddres.Location = new System.Drawing.Point(129, 86);
            this.textAddres.Margin = new System.Windows.Forms.Padding(2);
            this.textAddres.Name = "textAddres";
            this.textAddres.Size = new System.Drawing.Size(147, 23);
            this.textAddres.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 86);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Dirrección";
            // 
            // textCustomerName
            // 
            this.textCustomerName.Location = new System.Drawing.Point(129, 61);
            this.textCustomerName.Margin = new System.Windows.Forms.Padding(2);
            this.textCustomerName.Name = "textCustomerName";
            this.textCustomerName.Size = new System.Drawing.Size(147, 23);
            this.textCustomerName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id. cliente";
            // 
            // textCustomerId
            // 
            this.textCustomerId.Location = new System.Drawing.Point(129, 33);
            this.textCustomerId.Margin = new System.Windows.Forms.Padding(2);
            this.textCustomerId.Name = "textCustomerId";
            this.textCustomerId.ReadOnly = true;
            this.textCustomerId.Size = new System.Drawing.Size(147, 23);
            this.textCustomerId.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // FrmCustomerMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 355);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmCustomerMaintenance";
            this.Text = "Mantenimiento de cliente";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tpInquiry.ResumeLayout(false);
            this.tpInquiry.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgShowData)).EndInit();
            this.tpMaintenance.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ToolStrip toolStrip1;
        private ToolStripButton tsNew;
        private ToolStripButton tsSave;
        private ToolStripButton tsClear;
        private ToolStripButton tsDelete;
        private TabControl tabControl1;
        private TabPage tpInquiry;
        private Button btnSearch;
        private TextBox textSearch;
        private ComboBox cbFilter;
        private DataGridView dgShowData;
        private TabPage tpMaintenance;
        private GroupBox groupBox1;
        private Label label5;
        private Label label4;
        private TextBox textAddres;
        private Label label3;
        private TextBox textCustomerName;
        private Label label1;
        private TextBox textCustomerId;
        private Label label2;
        private ComboBox cbStatus;
        private ComboBox cbCustomerType;
    }
}