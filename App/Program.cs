using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;
using ViewModels;
using Interfaces;
namespace App
{
    static class Config
    {
        public static UnityContainer Container { get; private set; } = new UnityContainer();

        public static void Register()
        {
            Container.RegisterType<IContactsViewModel, ContactsViewModel>();
            //Container.RegisterType<IDetailView, Detail>();
        }
    }

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Config.Register();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new DxContacts());
        }
    }
}
