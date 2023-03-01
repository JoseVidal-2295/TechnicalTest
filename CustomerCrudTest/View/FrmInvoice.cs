using CustomerCrudTest.Model.Entity;
using CustomerCrudTest.Presenter.Invoices;
using CustomerCrudTest.View.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerCrudTest.View
{
    public partial class FrmInvoice : Form, IInvoiceView
    {
        public FrmInvoice()
        {
            InitializeComponent();
        }

        public InvoicePresenter Presenter { private get; set; }

        private DataTable dtDetalle = new DataTable();

        private Invoice oInvoice = new Invoice();

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            decimal percentageItbis = 0;

            try
            {
                //Verificamos si los campos requeridos estan completados
                if (validateFieldRequired() == false)
                {
                    ShowMessage.warning("Cliente, Id artículo, Cantidad, Precio e ITBIS");
                    return;
                };

                //Caputramos el tipo de ITBIS
                switch (cbITBIS.Text)
                {
                    case "I1- 18":
                        percentageItbis = 18;
                        break;
                    case "I2- 16":
                        percentageItbis = 16;
                        break;
                    default:
                        percentageItbis = 0;
                        break;
                }

                //Calculamos el sub total del detalle 
                decimal subTotal = Convert.ToDecimal(this.textPrice.Text) * Convert.ToDecimal(textQty.Text);

                decimal Itbis = Math.Round((subTotal * percentageItbis / 100), 2);

                //Agregamos la fila a nuestro datatable
                DataRow row = this.dtDetalle.NewRow();
                row["Id articulo"] = this.textItemId.Text;
                row["Cantidad"] = Convert.ToInt32(this.textQty.Text);
                row["Precio"] = Convert.ToDecimal(this.textPrice.Text);
                row["ITBIS"] = Itbis;
                row["SubTotal"] = decimal.Round(subTotal, 2);
                row["total"] = decimal.Round(subTotal + Itbis, 2);
                this.dtDetalle.Rows.Add(row);

                //Llamamos el metodo que actualiza los totales
                updateHeader(dtDetalle, (int)cbCustomer.SelectedValue);

                clearFieldDetail();
            }
            catch (Exception)
            {

            }
        }
        private void updateHeader(DataTable detail, int customerId)
        {
            oInvoice = buildInvoice(detail);
            oInvoice.CustomerId = customerId;

            //Llenamos los campos de la cabecera
            textTotalITBIs.Text = oInvoice.TotalItbis.ToString();
            textSubTotal.Text = oInvoice.SubTotal.ToString();
            textTotal.Text = oInvoice.Total.ToString();
        }
        private void createDetailTable()
        {
            //Crea la tabla con el nombre de Detalle
            this.dtDetalle = new DataTable("Detalle");

            //Agrega las columnas que tendra la tabla
            this.dtDetalle.Columns.Add("Id articulo", System.Type.GetType("System.String"));
            this.dtDetalle.Columns.Add("Cantidad", System.Type.GetType("System.Int32"));
            this.dtDetalle.Columns.Add("Precio", System.Type.GetType("System.Decimal"));
            this.dtDetalle.Columns.Add("ITBIS", System.Type.GetType("System.Decimal")); 
            this.dtDetalle.Columns.Add("SubTotal", System.Type.GetType("System.Decimal"));
            this.dtDetalle.Columns.Add("total", System.Type.GetType("System.Decimal"));
            
            //Relacionamos nuestro datagridview con nuestro datatable
            this.dgDetail.DataSource = this.dtDetalle;

            //Ocultamos la primera columna del Grid
            dgDetail.RowHeadersVisible = false;

            dgShowData.RowHeadersVisible = false;

        }
        //Metodo para validar que el usuario completo los campos requeridos
        private Boolean validateFieldRequired()
        {
            Boolean result = true;
            if (string.IsNullOrEmpty(cbCustomer.Text) || string.IsNullOrEmpty(textItemId.Text) || string.IsNullOrEmpty(textQty.Text) ||
                string.IsNullOrEmpty(textPrice.Text) || string.IsNullOrEmpty(cbITBIS.Text))
            {
                result = false;
            }

            return result;
        }

        private void FrmInvoice_Load(object sender, EventArgs e)
        {
            //Creamos la tabla virtual
            createDetailTable();

            //LLenamos el combo box de los clientes
            fillCbCustomerType();

            //Asignamos el valor "Todos" al combo box defecto
            cbFilter.Text = "Todos";
        }

        private void textQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Llamamos el metodo que controla que solo se digiten numeros enteros o decimales
            e.Handled = ValidateData.decimalNumber(sender, e);
        }

        private void textPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Llamamos el metodo que controla que solo se digiten numeros enteros o decimales
            e.Handled = ValidateData.decimalNumber(sender, e);
        }
        public Invoice buildInvoice(DataTable oDataTableo)
        {
            Invoice oInvoice = new Invoice();
            decimal totalItbis = 0;
            decimal subTotal = 0;
            decimal total = 0;

            List<InvoiceDetail> Detalles = new List<InvoiceDetail>();
            foreach (DataRow row in oDataTableo.Rows)
            {
                InvoiceDetail detalle = new InvoiceDetail();

                //Totales de la cabecera
                totalItbis += Convert.ToDecimal(row["ITBIS"].ToString());
                subTotal += Convert.ToDecimal(row["Subtotal"].ToString());
                total += Convert.ToDecimal(row["Total"].ToString());

                detalle.ItemId = row["Id articulo"].ToString();
                detalle.Qty = Convert.ToInt32(row["Cantidad"].ToString());
                detalle.Price = Convert.ToDecimal(row["Precio"].ToString());
                detalle.TotalItbis = Convert.ToDecimal(row["ITBIS"].ToString());
                detalle.SubTotal = Convert.ToDecimal(row["Subtotal"].ToString());
                detalle.Total = Convert.ToDecimal(row["Total"].ToString());
                Detalles.Add(detalle);
            }

            //Agregamos los totales a la cabecera
            oInvoice.TotalItbis = totalItbis;
            oInvoice.SubTotal = subTotal;
            oInvoice.Total = total;

            //Agregamos el detalle a la cabecera
            oInvoice.InvoiceDetail = Detalles;

            return oInvoice;
        }
        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tsSave_Click(object sender, EventArgs e)
        {

            try
            {
                if (dgDetail.RowCount <= 1)
                {
                    ShowMessage.warning(true, "Primero agregue los artículos que deseas vender");

                    return;
                }
          
                if (string.IsNullOrEmpty(cbCustomer.Text))
                {
                    ShowMessage.warning("Favor seleccionar el cliente, para realizar la venta");

                    return;
                }

                if (string.IsNullOrEmpty(textInvoiceId.Text))
                {
                    //Insertarmos el registro
                    Presenter.Save(oInvoice);

                }

                ShowMessage.ok();

                //Llamamos el metodo que llena el grid
                fillGrid();

                enableFields(false);
            }
            catch (Exception ex)
            {

            }
        }

        //Metodo para llenar el combobox de clientes
        public void fillCbCustomerType()
        {
            cbCustomer.DataSource = Presenter.GetCustomer();
            cbCustomer.ValueMember = "Id";
            cbCustomer.DisplayMember = "CustName";
        }

        private void tsDelete_Click(object sender, EventArgs e)
        {
            //Eliminamos el registro seleccionado

            try
            {
                //Validamos que el usuario tenga un registro seleccionado
                if (string.IsNullOrEmpty(textInvoiceId.Text))
                {
                    ShowMessage.warning();
                    return;
                }

                //Verificamos si el usuario esta seguro de querer eliminar el registro
                if (ShowMessage.question() != DialogResult.Yes)
                {
                    return;
                }

                Presenter.Remove(int.Parse(textInvoiceId.Text ?? "0"));

                clearField();

                fillGrid();
            }
            catch (Exception ex)
            {

                //throw;
            }
        }

        //Metodo para limpiar los campos de esta pantalla
        private void clearField()
        {
            //Cabecera
            textInvoiceId.Clear();
            textTotalITBIs.Text = "0";
            textSubTotal.Text = "0";
            textTotal.Text = "0";

            //Detalle
            textItemId.Clear();
            textQty.Clear();
            textPrice.Clear();

        }
        //Metodo para limpiar los campos del detalle de esta pantalla
        private void clearFieldDetail()
        {
            textItemId.Clear();
            textQty.Clear();
            textPrice.Clear();
        }

        //Metodo para deshabilitar y habilitar campos
        private void enableFields(bool value)
        {
            btnAdd.Enabled = value;
            btnDelete.Enabled = value;
            tsSave.Enabled = value;
            cbCustomer.Enabled = value;
            cbITBIS.Enabled = value;
            textItemId.ReadOnly= !value;
            textQty.ReadOnly = !value;
            textPrice.ReadOnly = !value;
        }

        //Metodo para mostrar todos los registros
        private void fillGrid()
        {
            try
            {
                var invoiceList = Presenter.GetAll();
                dgShowData.DataSource = invoiceList;

                dgShowData.Columns["Id"].HeaderText = "Id factura";
                dgShowData.Columns["CustomerId"].HeaderText = "Id cliente";
            }
            catch (Exception ex)
            {

            }
        }

        //Metodo para mostrar un unico registro filtrado por Id
        private void fillGridById(int id)
        {
            try
            {
                var invoice = Presenter.GetById(id);

                var invoiceList = new List<Invoice>();

                invoiceList.Add(invoice);

                dgShowData.DataSource = invoiceList;

                dgShowData.Columns["Id"].HeaderText = "Id factura";
                dgShowData.Columns["CustomerId"].HeaderText = "Id cliente";
            }
            catch (Exception ex)
            {
               
            }
        }

        //Metodo para mostrar el detalle filtrado por Id
        private void showInvoiceDetail(int id)
        {
            try
            {
                //Limpiamos la tabla
                dtDetalle.Clear();

                var invoiceDetails = Presenter.GetDetails(id);

                foreach (var detail in invoiceDetails)
                {
                    DataRow row = this.dtDetalle.NewRow();
                    row["Id articulo"] = detail.ItemId;
                    row["Cantidad"] = detail.Qty;
                    row["Precio"] = detail.Price;
                    row["ITBIS"] = detail.TotalItbis;
                    row["SubTotal"] = detail.SubTotal;
                    row["total"] = detail.Total;
                    this.dtDetalle.Rows.Add(row);
                }

                dgDetail.DataSource = dtDetalle;
                
            }
            catch (Exception ex)
            {

            }
        }

        private void tsClear_Click(object sender, EventArgs e)
        {
            clearField();
        }

        private void tsNew_Click(object sender, EventArgs e)
        {
            clearField();

            enableFields(true);

            dtDetalle.Clear();

            this.tabControl1.SelectedIndex = 1;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilter.Text != "Todos")
            {
                //Llamamos el metodo que controla que solo se digiten numeros enteros, ya que el usuario filtrara por id
                e.Handled = ValidateData.integerNumber(sender, e);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbFilter.Text == "Todos")
                {
                    //Llamamos el metodo que llena el grid con todos los registro
                    fillGrid();
                }
                else
                {

                    fillGridById(int.Parse(textSearch.Text ?? "0"));
                }
            }
            catch (Exception ex)
            {
                ShowMessage.warning(true, "A la hora de filtrar por id el Id debe ser un número entero");
            }
        }

        private void tsEdit_Click(object sender, EventArgs e)
        {

        }

        private void dgDetail_DoubleClick(object sender, EventArgs e)
        {
            textItemId.Text = (this.dgDetail.CurrentRow.Cells["Id articulo"].Value.ToString());
            textQty.Text = (this.dgDetail.CurrentRow.Cells["Cantidad"].Value.ToString());
            textPrice.Text = (this.dgDetail.CurrentRow.Cells["Precio"].Value.ToString());
        }

        private void dgShowData_DoubleClick(object sender, EventArgs e)
        {

            textInvoiceId.Text = (this.dgShowData.CurrentRow.Cells["Id"].Value.ToString());
        
            cbCustomer.DataSource = Presenter.GetCustomer();
            cbCustomer.ValueMember = "Id";
            cbCustomer.DisplayMember = "CustName";
            cbCustomer.SelectedValue = int.Parse((this.dgShowData.CurrentRow.Cells["CustomerId"].Value.ToString()));

            cbITBIS.SelectedValue = (this.dgShowData.CurrentRow.Cells["CustomerId"].Value.ToString());
            textTotalITBIs.Text = (this.dgShowData.CurrentRow.Cells["TotalItbis"].Value.ToString());
            textSubTotal.Text = (this.dgShowData.CurrentRow.Cells["SubTotal"].Value.ToString());
            textTotal.Text = (this.dgShowData.CurrentRow.Cells["Total"].Value.ToString());

            showInvoiceDetail(int.Parse(textInvoiceId.Text ?? "0"));

            enableFields(false);

            this.tabControl1.SelectedIndex = 1;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                //Indice dila actualmente seleccionado y que vamos a eliminar
                int indiceFila = this.dgDetail.CurrentCell.RowIndex;

                //Fila que vamos a eliminar
                DataRow row = this.dtDetalle.Rows[indiceFila];
                decimal itbis = Convert.ToDecimal(row["subTotal"].ToString());

                ////Removemos la fila
                this.dtDetalle.Rows.Remove(row);

                updateHeader(dtDetalle, (int)cbCustomer.SelectedValue);
            }
            catch (Exception ex)
            {
                ShowMessage.warning(true,"No hay fila para remover");

            }
        }

        private void cbCustomer_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void cbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cbCustomer_DropDown(object sender, EventArgs e)
        {
           
        }
    }   
}
