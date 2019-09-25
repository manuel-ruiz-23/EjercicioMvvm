/* 
 * Corre al inicio de programa.
 * Registra la Vista inicial dentro de OnStartup method
 * 
 */
using System.Windows;
using Caliburn.Micro;
using pruebaMR.Models;

namespace pruebaMR
{
    public class Bootstrapper : BootstrapperBase
    {
        public Bootstrapper()
        {
            Initialize();
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            DisplayRootViewFor<RegistroViewModel>();
        }
    }
}
