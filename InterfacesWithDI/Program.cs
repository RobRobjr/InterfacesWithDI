using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace InterfacesWithDI
{
    static class Program
    {
        private static Container _container;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            InitDepInjection();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run( _container.GetInstance<FrmMain>() );
        }

        private static void InitDepInjection()
        {
            //Sets up the dependancy injection container
            _container = new Container();

            //Register our types
            _container.Register<ILogger, FileLogger>(Lifestyle.Transient);

            //FrmMain is being tracked/managed by the contianer
            _container.Register<FrmMain>();
        }
    }
}
