using System.Windows.Forms;

namespace CustomerCrudTest.View
{
    partial class FrmInvoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInvoice));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbITBIS = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textItemId = new System.Windows.Forms.TextBox();
            this.textQty = new System.Windows.Forms.TextBox();
            this.textPrice = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textSubTotal = new System.Windows.Forms.TextBox();
            this.textTotal = new System.Windows.Forms.TextBox();
            this.textTotalITBIs = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgDetail = new System.Windows.Forms.DataGridView();
            this.cbCustomer = new System.Windows.Forms.ComboBox();
            this.textInvoiceId = new System.Windows.Forms.TextBox();
            this.tpMaintenance = new System.Windows.Forms.TabPage();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.dgShowData = new System.Windows.Forms.DataGridView();
            this.tpInquiry = new System.Windows.Forms.TabPage();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tsDelete = new System.Windows.Forms.ToolStripButton();
            this.tsClear = new System.Windows.Forms.ToolStripButton();
            this.tsSave = new System.Windows.Forms.ToolStripButton();
            this.tsNew = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetail)).BeginInit();
            this.tpMaintenance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgShowData)).BeginInit();
            this.tpInquiry.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id factura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cliente";
            // 
            // btnSearch
            // 
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(365, 24);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(97, 32);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.cbITBIS);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.textItemId);
            this.groupBox1.Controls.Add(this.textQty);
            this.groupBox1.Controls.Add(this.textPrice);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textSubTotal);
            this.groupBox1.Controls.Add(this.textTotal);
            this.groupBox1.Controls.Add(this.textTotalITBIs);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dgDetail);
            this.groupBox1.Controls.Add(this.cbCustomer);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textInvoiceId);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(27, 26);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(636, 333);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(520, 161);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(60, 22);
            this.btnDelete.TabIndex = 29;
            this.btnDelete.Text = "Quitar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(520, 135);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(60, 23);
            this.btnAdd.TabIndex = 28;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button2_Click);
            // 
            // cbITBIS
            // 
            this.cbITBIS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbITBIS.FormattingEnabled = true;
            this.cbITBIS.Items.AddRange(new object[] {
            "I1- 18",
            "I2- 16",
            "E - 0"});
            this.cbITBIS.Location = new System.Drawing.Point(85, 109);
            this.cbITBIS.Margin = new System.Windows.Forms.Padding(2);
            this.cbITBIS.Name = "cbITBIS";
            this.cbITBIS.Size = new System.Drawing.Size(84, 23);
            this.cbITBIS.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 114);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 15);
            this.label10.TabIndex = 26;
            this.label10.Text = "ITBIS";
            // 
            // textItemId
            // 
            this.textItemId.Location = new System.Drawing.Point(85, 81);
            this.textItemId.Margin = new System.Windows.Forms.Padding(2);
            this.textItemId.Name = "textItemId";
            this.textItemId.Size = new System.Drawing.Size(84, 23);
            this.textItemId.TabIndex = 25;
            // 
            // textQty
            // 
            this.textQty.Location = new System.Drawing.Point(255, 81);
            this.textQty.Margin = new System.Windows.Forms.Padding(2);
            this.textQty.Name = "textQty";
            this.textQty.Size = new System.Drawing.Size(84, 23);
            this.textQty.TabIndex = 24;
            this.textQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textQty_KeyPress);
            // 
            // textPrice
            // 
            this.textPrice.Location = new System.Drawing.Point(388, 82);
            this.textPrice.Margin = new System.Windows.Forms.Padding(2);
            this.textPrice.Name = "textPrice";
            this.textPrice.Size = new System.Drawing.Size(84, 23);
            this.textPrice.TabIndex = 23;
            this.textPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textPrice_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(193, 84);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 15);
            this.label9.TabIndex = 22;
            this.label9.Text = "Cantidad";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(342, 84);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 15);
            this.label8.TabIndex = 21;
            this.label8.Text = "Precio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 84);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 15);
            this.label5.TabIndex = 20;
            this.label5.Text = "Id artículo";
            // 
            // textSubTotal
            // 
            this.textSubTotal.Location = new System.Drawing.Point(520, 250);
            this.textSubTotal.Margin = new System.Windows.Forms.Padding(2);
            this.textSubTotal.Name = "textSubTotal";
            this.textSubTotal.ReadOnly = true;
            this.textSubTotal.Size = new System.Drawing.Size(84, 23);
            this.textSubTotal.TabIndex = 19;
            this.textSubTotal.Text = "0";
            // 
            // textTotal
            // 
            this.textTotal.Location = new System.Drawing.Point(520, 290);
            this.textTotal.Margin = new System.Windows.Forms.Padding(2);
            this.textTotal.Name = "textTotal";
            this.textTotal.ReadOnly = true;
            this.textTotal.Size = new System.Drawing.Size(84, 23);
            this.textTotal.TabIndex = 18;
            this.textTotal.Text = "0";
            // 
            // textTotalITBIs
            // 
            this.textTotalITBIs.Location = new System.Drawing.Point(520, 206);
            this.textTotalITBIs.Margin = new System.Windows.Forms.Padding(2);
            this.textTotalITBIs.Name = "textTotalITBIs";
            this.textTotalITBIs.ReadOnly = true;
            this.textTotalITBIs.Size = new System.Drawing.Size(84, 23);
            this.textTotalITBIs.TabIndex = 17;
            this.textTotalITBIs.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(519, 187);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "Total ITBIS";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(520, 230);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "Sub Total";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(520, 273);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Total";
            // 
            // dgDetail
            // 
            this.dgDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDetail.Location = new System.Drawing.Point(17, 135);
            this.dgDetail.Margin = new System.Windows.Forms.Padding(2);
            this.dgDetail.Name = "dgDetail";
            this.dgDetail.ReadOnly = true;
            this.dgDetail.RowHeadersWidth = 62;
            this.dgDetail.RowTemplate.Height = 33;
            this.dgDetail.Size = new System.Drawing.Size(493, 187);
            this.dgDetail.TabIndex = 13;
            this.dgDetail.DoubleClick += new System.EventHandler(this.dgDetail_DoubleClick);
            // 
            // cbCustomer
            // 
            this.cbCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCustomer.FormattingEnabled = true;
            this.cbCustomer.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cbCustomer.Location = new System.Drawing.Point(85, 49);
            this.cbCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.cbCustomer.Name = "cbCustomer";
            this.cbCustomer.Size = new System.Drawing.Size(129, 23);
            this.cbCustomer.TabIndex = 12;
            // 
            // textInvoiceId
            // 
            this.textInvoiceId.Location = new System.Drawing.Point(85, 19);
            this.textInvoiceId.Margin = new System.Windows.Forms.Padding(2);
            this.textInvoiceId.Name = "textInvoiceId";
            this.textInvoiceId.ReadOnly = true;
            this.textInvoiceId.Size = new System.Drawing.Size(129, 23);
            this.textInvoiceId.TabIndex = 2;
            // 
            // tpMaintenance
            // 
            this.tpMaintenance.Controls.Add(this.groupBox1);
            this.tpMaintenance.Location = new System.Drawing.Point(4, 24);
            this.tpMaintenance.Margin = new System.Windows.Forms.Padding(2);
            this.tpMaintenance.Name = "tpMaintenance";
            this.tpMaintenance.Padding = new System.Windows.Forms.Padding(2);
            this.tpMaintenance.Size = new System.Drawing.Size(672, 370);
            this.tpMaintenance.TabIndex = 0;
            this.tpMaintenance.Text = "Mantenimiento";
            this.tpMaintenance.UseVisualStyleBackColor = true;
            // 
            // cbFilter
            // 
            this.cbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Items.AddRange(new object[] {
            "Todos",
            "Id cliente"});
            this.cbFilter.Location = new System.Drawing.Point(24, 27);
            this.cbFilter.Margin = new System.Windows.Forms.Padding(2);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(131, 23);
            this.cbFilter.TabIndex = 1;
            // 
            // dgShowData
            // 
            this.dgShowData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgShowData.Location = new System.Drawing.Point(22, 69);
            this.dgShowData.Margin = new System.Windows.Forms.Padding(2);
            this.dgShowData.Name = "dgShowData";
            this.dgShowData.ReadOnly = true;
            this.dgShowData.RowHeadersWidth = 62;
            this.dgShowData.RowTemplate.Height = 28;
            this.dgShowData.Size = new System.Drawing.Size(517, 224);
            this.dgShowData.TabIndex = 0;
            this.dgShowData.DoubleClick += new System.EventHandler(this.dgShowData_DoubleClick);
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
            this.tpInquiry.Size = new System.Drawing.Size(672, 370);
            this.tpInquiry.TabIndex = 1;
            this.tpInquiry.Text = "Consulta";
            this.tpInquiry.UseVisualStyleBackColor = true;
            // 
            // textSearch
            // 
            this.textSearch.Location = new System.Drawing.Point(170, 28);
            this.textSearch.Margin = new System.Windows.Forms.Padding(2);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(173, 23);
            this.textSearch.TabIndex = 2;
            this.textSearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textSearch_KeyPress);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpInquiry);
            this.tabControl1.Controls.Add(this.tpMaintenance);
            this.tabControl1.Location = new System.Drawing.Point(13, 37);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(680, 398);
            this.tabControl1.TabIndex = 5;
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
            this.toolStrip1.Size = new System.Drawing.Size(722, 31);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // FrmInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 446);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmInvoice";
            this.Text = "Factura";
            this.Load += new System.EventHandler(this.FrmInvoice_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetail)).EndInit();
            this.tpMaintenance.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgShowData)).EndInit();
            this.tpInquiry.ResumeLayout(false);
            this.tpInquiry.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private Label label2;
        private Button btnSearch;
        private RadioButton rbAll;
        private GroupBox groupBox1;
        private DataGridView dgDetail;
        private ComboBox cbCustomer;
        private TextBox textInvoiceId;
        private TabPage tpMaintenance;
        private Button button1;
        private RadioButton rbInactive;
        private RadioButton rbActive;
        private ComboBox cbFilter;
        private DataGridView dgShowData;
        private TabPage tpInquiry;
        private TextBox textSearch;
        private TabControl tabControl1;
        private ToolStripButton tsDelete;
        private ToolStripButton tsClear;
        private ToolStripButton tsSave;
        private ToolStripButton tsNew;
        private ToolStrip toolStrip1;
        private TextBox textItemId;
        private TextBox textQty;
        private TextBox textPrice;
        private Label label9;
        private Label label8;
        private Label label5;
        private TextBox textSubTotal;
        private TextBox textTotal;
        private TextBox textTotalITBIs;
        private Label label7;
        private Label label6;
        private Label label4;
        private Button btnDelete;
        private Button btnAdd;
        private ComboBox cbITBIS;
        private Label label10;
    }
}