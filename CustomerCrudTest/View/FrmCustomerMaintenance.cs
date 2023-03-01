using CustomerCrudTest.Model.Context;
using CustomerCrudTest.Model.Entity;
using CustomerCrudTest.Presenter;
using CustomerCrudTest.Presenter.Customer;
using CustomerCrudTest.Presenter.CustomerType;
using CustomerCrudTest.View;
using CustomerCrudTest.View.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Windows.Forms;

namespace CustomerCrudTest.View
{
    public partial class FrmCustomerMaintenance : Form,ICustomerView
    {
    

        public FrmCustomerMaintenance()
        {
            InitializeComponent();
        }

        public CustomerPresenter Presenter {private get; set; }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            //LLenamos el combo box tipo de cliente
            fillCbCustomerType();


            //Asignamos el valor "Todos" al combo boxpor defecto
            cbFilter.Text = "Todos";

            //Setiamos el valor inicial del estatus del registro
            cbStatus.Text = "Activo";

            //Ocultamos la primera columna
            dgShowData.RowHeadersVisible = false;
        }

        //Metodo para llenar el combobox tipo cliente
        public void fillCbCustomerType()
        {
            
            cbCustomerType.DataSource = Presenter.GetCustomerType();
            cbCustomerType.ValueMember = "Id";
            cbCustomerType.DisplayMember = "Description";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Presenter.RemoveCustomer(1);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void tsSave_Click(object sender, EventArgs e)
        {
           
            try
            {
                Customers oCustomers = new Customers();
                //Llamamos el metodo que verifica los valores obligatorios
                if (validateFieldRequired() == false)
                {
                    ShowMessage.warning("Nombre, Tipo de cliente, Estatus");

                    return;
                }
                int aa;
                oCustomers.CustName = textCustomerName.Text;
                oCustomers.CustomerTypeId = (int)cbCustomerType.SelectedValue;

                oCustomers.Adress = textAddres.Text;

                oCustomers.Status = (cbStatus.Text == "Activo") ? true : false;
                

                if (string.IsNullOrEmpty(textCustomerId.Text))
                {
                    //Insertarmos el registro
                    Presenter.SaveCustomer(oCustomers);

                }
                else
                {
                    //Actualizamos el registro
                    oCustomers.Id = int.Parse(textCustomerId.Text);

                    Presenter.UpdateCustomer(oCustomers);

                }

                ShowMessage.ok();

                clearField();

                //Llamamos el metodo que llena el grid
                fillGrid();
            }
            catch (Exception ex)
            {

            }

            


        }
        //Metodo para limpiar los campos
        private void clearField()
        {
            textCustomerId.Clear();
            textCustomerName.Clear();
            textAddres.Clear();
            cbStatus.Text = " ";
            cbCustomerType.Text = " ";
            
        }

        private void tsDelete_Click(object sender, EventArgs e)
        {
            //Eliminamos el registro seleccionado

            int customerId = 0;
            try
            {
                //Validamos que el usuario tenga un registro seleccionado
                if (string.IsNullOrEmpty(textCustomerId.Text))
                {
                    ShowMessage.warning();
                    return;
                }

                //Verificamos si el usuario esta seguro de querer eliminar el registro
                if (ShowMessage.question() != DialogResult.Yes)
                {
                    return;
                }

                customerId = int.Parse(textCustomerId.Text);

                Presenter.RemoveCustomer(customerId);

                clearField();

                fillGrid();
            }
            catch (Exception ex)
            {

                //throw;
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

                hideColumn();
            }
            catch (Exception ex)
            {
                ShowMessage.warning(true, "A la hora de filtrar por id el Id debe ser un número entero");
            }
            
        }

        private void dgShowData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgShowData_DoubleClick(object sender, EventArgs e)
        {
            bool status;
            int customerId;
  
            textCustomerId.Text = (this.dgShowData.CurrentRow.Cells["Id"].Value.ToString());
            textCustomerName.Text = (this.dgShowData.CurrentRow.Cells["CustName"].Value.ToString());
            textAddres.Text = (this.dgShowData.CurrentRow.Cells["Adress"].Value.ToString());
            customerId = int.Parse((this.dgShowData.CurrentRow.Cells["CustomerTypeId"].Value.ToString()));
            cbCustomerType.DataSource = Presenter.GetCustomerType();
            cbCustomerType.ValueMember = "Id";
            cbCustomerType.DisplayMember = "Description";
            cbCustomerType.SelectedValue = customerId;

            status = bool.Parse((this.dgShowData.CurrentRow.Cells["Status"].Value.ToString()));
            
            if (status == true)
            {
                cbStatus.Text = "Activo";
            }
            else
            {
                cbStatus.Text = "Inactivo";
            }

            this.tabControl1.SelectedIndex = 1;
        }

        private void tsEdit_Click(object sender, EventArgs e)
        {

        }

        private void tsNew_Click(object sender, EventArgs e)
        {
            clearField();

            this.tabControl1.SelectedIndex = 1;
        }

        private void tsClear_Click(object sender, EventArgs e)
        {
            clearField();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tpMaintenance_Click(object sender, EventArgs e)
        {

        }

        //Metodo para mostrar todos los registros
        private void fillGrid()
        {
            try
            {
                var customerLis = Presenter.GetAll();
                dgShowData.DataSource = customerLis;

                dgShowData.Columns["Id"].HeaderText = "Id cliente";
                dgShowData.Columns["CustName"].HeaderText = "Nombre";
                dgShowData.Columns["Adress"].HeaderText = "Dirección";
                dgShowData.Columns["CustomerTypeId"].HeaderText = "Tipo cliente";
                dgShowData.Columns["Status"].HeaderText = "Registro activo";
            }
            catch (Exception ex)
            {
                
            }
        }

        //Metodo para ocurtar columnas 
        private void hideColumn()
        {
            try
            {
                dgShowData.Columns["CustomerTypeId"].Visible = false;
                dgShowData.Columns["CustomerType"].Visible = false;
            }
            catch (Exception)
            {

                ShowMessage.warning(true, "Ocurrió una situación inesperada ocultando ciertas columnas");
            }

        }

        //Metodo para mostrar un unico registro filtrado por Id
        private void fillGridById(int id)
        {
            try
            {
                var customer = Presenter.GetById(id);

                var customerLis = new List<Customers>();

                customerLis.Add(customer);

                dgShowData.DataSource = customerLis;

                dgShowData.Columns["Id"].HeaderText = "Id cliente";
                dgShowData.Columns["CustName"].HeaderText = "Nombre";
                dgShowData.Columns["Adress"].HeaderText = "Dirección";
                dgShowData.Columns["CustomerTypeId"].HeaderText = "Tipo cliente";
                dgShowData.Columns["Status"].HeaderText = "Registro activo";
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void textSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilter.Text != "Todos")
            {
                //Llamamos el metodo que controla que solo se digiten numeros enteros, ya que el usuario filtrara por id
                e.Handled = ValidateData.integerNumber(sender, e);
            }
        }
        //Metodo para validar que el usuario completo los campos requeridos
        private Boolean validateFieldRequired()
        {
            Boolean result = true;
            if (string.IsNullOrEmpty(textCustomerName.Text) || string.IsNullOrEmpty(cbCustomerType.Text) || string.IsNullOrEmpty(cbStatus.Text))
            {
                result = false;
            }

            return result;
        }
    }
}