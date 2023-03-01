using CustomerCrudTest.Model.Context;
using CustomerCrudTest.Model.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Configuration;
using System.Windows.Forms;

namespace CustomerCrudTest
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            //Configuracion de conexion
            string connectionString = ConfigurationManager.ConnectionStrings["Conection"].ConnectionString;

            var optionsBuilder = new DbContextOptionsBuilder<CustomerContext>();

            optionsBuilder.UseSqlServer(connectionString);
            CustomerContext contex = new CustomerContext(optionsBuilder.Options);


            //inicializacion de mis variables globales
            var repository = new Model.Repository.Customer.CustomerRepository(contex) ;
            //var view = new View.FrmCustomerMaintenance();
            var view = new View.FrmCustomerMaintenance();

            //inicializacion de presenter
            var presenter = new Presenter.Customer.CustomerPresenter(view, repository);

            //Application.Run(view);
            var view2 = new View.FrmPrincipal();
            Application.Run(view2);


           
        }
    }
}