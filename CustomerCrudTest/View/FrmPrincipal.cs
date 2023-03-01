
using CustomerCrudTest.Model.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerCrudTest.View
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void tipoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Conection"].ConnectionString;

            var optionsBuilder = new DbContextOptionsBuilder<CustomerContext>();

            optionsBuilder.UseSqlServer(connectionString);
            CustomerContext contex = new CustomerContext(optionsBuilder.Options);

            //inicializacion de mis variables globales
            var repository = new Model.Repository.CustomerType.CustomerTypeRepository(contex);
            
            var view = new View.FrmCustomerType();

            //inicializacion de presenter
            var presenter = new Presenter.CustomerType.CustomersTypesPresenter(view, repository);

            view.Show();
            view.MdiParent = this;
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Conection"].ConnectionString;

            var optionsBuilder = new DbContextOptionsBuilder<CustomerContext>();

            optionsBuilder.UseSqlServer(connectionString);
            CustomerContext contex = new CustomerContext(optionsBuilder.Options);

            //inicializacion de mis variables globales
            var repository = new Model.Repository.Customer.CustomerRepository(contex);
            //var view = new View.FrmCustomerMaintenance();
            var view = new View.FrmCustomerMaintenance();

            //inicializacion de presenter
            var presenter = new Presenter.Customer.CustomerPresenter(view, repository);

            view.Show();
            view.MdiParent = this;

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //FrmInvoice frm = new FrmInvoice();
            //frm.Show();

            string connectionString = ConfigurationManager.ConnectionStrings["Conection"].ConnectionString;

            var optionsBuilder = new DbContextOptionsBuilder<CustomerContext>();

            optionsBuilder.UseSqlServer(connectionString);
            CustomerContext contex = new CustomerContext(optionsBuilder.Options);

            //inicializacion de mis variables globales
            var repository = new Model.Repository.Invoices.InvoiceRepository(contex);

            var view = new View.FrmInvoice();

            //inicializacion de presenter
            var presenter = new Presenter.Invoices.InvoicePresenter(view, repository);

            view.Show();

            view.MdiParent = this;
        }
    }
}
