using CustomerCrudTest.Model.Entity;
using CustomerCrudTest.Presenter.Customer;
using CustomerCrudTest.Presenter.CustomerType;
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
    public partial class FrmCustomerType : Form,ICustomertypesView
    {
        public FrmCustomerType()
        {
            InitializeComponent();
        }

        public CustomersTypesPresenter Presenter { private get; set; }


        private void tsSave_Click(object sender, EventArgs e)
        {

            CustomerTypes oCustomerTypes = new CustomerTypes();

            //Llamamos el metodo que verifica los valores obligatorios
            if (validateFieldRequired() == false)
            {
                ShowMessage.warning("Descripción");

                return;
            }

            

            try
            {
                oCustomerTypes.Description = textDescription.Text;

                if (string.IsNullOrEmpty(textCustomerTypeId.Text))
                {
                    //Insertarmos el registro
                    oCustomerTypes.Id = 0;
                    Presenter.Save(oCustomerTypes);

                }
                else
                {
                    //Actualizamos el registro
                    oCustomerTypes.Id = int.Parse(textCustomerTypeId.Text);
                    Presenter.Update(oCustomerTypes);

                }

                ShowMessage.ok();

                clearField();

                //Llamamos el metodo que llena el grid
                fillGrid();
            }
            catch (Exception)
            {

            }
            
        }
        //Metodo para validar que el usuario completo los campos requeridos
        private Boolean validateFieldRequired()
        {
            Boolean result = true;
            if (string.IsNullOrEmpty(textDescription.Text))
            {
                result = false;
            }

            return result;
        }

        private void FrmCustomerType_Load(object sender, EventArgs e)
        {
            //Asignamos el valor "Todos" al combo boxpor defecto

            cbFilter.Text = "Todos";

            //Ocultamos la primera columna
            dgShowData.RowHeadersVisible = false;
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

       

        private void dgShowData_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                textCustomerTypeId.Text = (this.dgShowData.CurrentRow.Cells["Id"].Value.ToString());
                textDescription.Text = (this.dgShowData.CurrentRow.Cells["Description"].Value.ToString());

                this.tabControl1.SelectedIndex = 1;
            }
            catch (Exception)
            {

            }
            
        }

        private void tsNew_Click(object sender, EventArgs e)
        {
            clearField();

            this.tabControl1.SelectedIndex = 1;
        }

        private void tsDelete_Click(object sender, EventArgs e)
        {
            //Eliminamos el registro seleccionado

            int customerTypeId = 0;

            if (string.IsNullOrEmpty(textCustomerTypeId.Text))
            {
                ShowMessage.warning();
                return;
            }

            //Verificamos si el usuario esta seguro de querer eliminar el registro
            if (ShowMessage.question() !=DialogResult.Yes)
            {
                return;
            } 

            try
            {
                customerTypeId = int.Parse(textCustomerTypeId.Text ?? "0");

                Presenter.Remove(customerTypeId);

                ShowMessage.ok();

                clearField();

                //Llamamos el metodo que llena el grid
                fillGrid();
            }
            catch (Exception ex)
            {
                ShowMessage.warning(true, "Este registro no se puede eliminar ya que existen clientes asociados a dicho registro");
            }
            
        }

        private void clearField()
        {
            textCustomerTypeId.Clear();
            textDescription.Clear();    

        }

        //Metodo para mostrar todos los registros
        private void fillGrid()
        {
            try
            {
                var customerLis =  Presenter.GetAll();
                dgShowData.DataSource = customerLis;

                dgShowData.Columns["Id"].HeaderText = "Id tipo cliente";
                dgShowData.Columns["Description"].HeaderText = "Descripción";
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        //Metodo para mostrar un unico registro filtrado por Id
        private void fillGridById(int id)
        {
            try
            {
                var customer = Presenter.GetById(id);

                var customerLis = new List<CustomerTypes>();

                customerLis.Add(customer);

                dgShowData.DataSource = customerLis;

                dgShowData.Columns["Id"].HeaderText = "Id tipo cliente";
                dgShowData.Columns["Description"].HeaderText = "Descripción";
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void tsClear_Click(object sender, EventArgs e)
        {
            clearField();
        }

        private void textSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilter.Text != "Todos")
            {
                //Llamamos el metodo que controla que solo se digiten numeros enteros, ya que el usuario filtrara por id
                e.Handled = ValidateData.integerNumber(sender, e);
            }
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tsEdit_Click(object sender, EventArgs e)
        {

        }

    }
}
